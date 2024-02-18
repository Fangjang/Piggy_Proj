using Dapper;
using Piggy.models;
using Piggy.provider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piggy.Pages.Componets
{
    public partial class SellPigForm : Form
    {
        private Dashboard_Pigs _pigsInstance;
        private Dashboard dashboardInstance;
        public SellPigForm(Dashboard_Pigs _Pigs, Dashboard dashboard)
        {
            InitializeComponent();
            this._pigsInstance = _Pigs;
            this.dashboardInstance = dashboard;
        }

        private void PurchasePigElm_Click(object sender, EventArgs e)
        {
            var pigID = pigIdNice.Text.Trim();
            var sellingAmount = sellingAmountElm.Text.Trim();


            if (string.IsNullOrEmpty(pigID) || string.IsNullOrEmpty(sellingAmount))
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }
            if (!float.TryParse(sellingAmount, out _) ||
                !int.TryParse(pigID, out _) )
            {
                MessageBox.Show("Invalid Fields!");
                return;
            }
            using (var conn = ConnectionProvider.GetConnection())
            {
                var hasPigquery = @"
                Select  count(*) from pigs where pigid = @pigID
        ";
                var dataCount = conn.Query<int>(hasPigquery, new { pigID }).FirstOrDefault();
                if (dataCount != 0)
                {
                    var getPigQuery = @"
                Select  * from pigs where pigid = @pigID
        ";
                    var datPig = conn.Query<PigModel>(getPigQuery, new { pigID }).FirstOrDefault();

                    DialogResult result = MessageBox.Show(

                        "Are you sure you want to sell pig ? \n " +
                        "Pig weight : "
                        + datPig.pigweight.ToString() + "\n" +
                        "Pig Sex : " + (datPig.pigsex == "M" ? "Male" : "Female") + "\n" +
                        "Age : " + datPig.pigage.ToString() + "\n" +
                        "Selling Amount : " + sellingAmount + "\n" +
                        "Pig Breed : " + datPig.pigBreed + "\n"
                        ,
                        "Sell Pig", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        var soldDate = DateTime.Now;

                        var sellPigQuery = @"
                          Update pigs set isSold = true  where pigid = @pigID;
                          Update pigs set soldDate = now()  where pigid = @pigID;
                          Update pigs set soldPrice = @sellingAmount where pigid = @pigID;
                        ";
                        var p = conn.Query(sellPigQuery, new { pigID, soldDate, sellingAmount });
                        MessageBox.Show("Pig sold successfully!");
                        ///////////////
                        _pigsInstance.LoadPigs();
                        dashboardInstance.Dashboard_Sales_Update();
                        this.Hide();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("No pig with that tag or id found!");
                }

            }
        }
    }
}
