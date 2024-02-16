using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using Piggy.models;
using Piggy.provider;
using Piggy.Pages;
namespace Piggy.Pages.Componets
{
    public partial class PurchasePigForm : Form
    {
        private Dashboard_Pigs _pigsInstance;
        private Dashboard dashboard;

        public PurchasePigForm(Dashboard_Pigs _Pigs, Dashboard dashboard)
        {
            InitializeComponent();
            this._pigsInstance = _Pigs;
            this.dashboard = dashboard;
        }




        private void PurchasePigElm_Click(object sender, EventArgs e)
        {
            if (
            ageElm.Text == "0.0"
            || weightElm.Text == "0.00" || breedElm.Text == ""
            )
            {
                MessageBox.Show("Invalid Fields!");
                return;
            }

            var age = float.Parse(ageElm.Text);
            var weight = float.Parse(weightElm.Text);
            var price = float.Parse(priceElm.Text);
            var sex = genderElm.Text.Trim();
            var breed = breedElm.Text.Trim();
            using (var conn = ConnectionProvider.GetConnection())
            {
                var dataCountQuery = @"
                            INSERT INTO piggydb.pigs
                            (pigage, pigweight, pigsex, pigPrice, pigBreed)
                            VALUES 
                            (@age, @weight, @sex, @price, @breed);  
                    ";

                var dataCount = conn.Execute(dataCountQuery, new { age, weight, sex, price, breed});
                if (dataCount > 0)
                {
                    MessageBox.Show("Pig has been Added!");
                    _pigsInstance.LoadPigs();
                    dashboard.Dashboard_Sales_Update();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to add pig!");
                }
            }


        }
    }
}
