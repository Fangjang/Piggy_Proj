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

namespace Piggy.Pages.Componets
{


    public partial class Dashboard_Pigs : Form
    {

        private Dashboard dashboard;
        public Dashboard_Pigs(Dashboard dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
            dashboard.Dashboard_Sales_Update();
            LoadPigs();
        }


        public void LoadPigs()
        {
            using (var conn = ConnectionProvider.GetConnection
            ())
            {
                var dataCountQuery = @"
                            SELECT * FROM pigs where isSold is false;
                    ";

                var TotalPigsCount = @"
                            SELECT count(*) FROM pigs where isSold is false ;
                    ";
                var MalePigsCount = @"
  SELECT count(*) FROM pigs where isSold is false and pigsex = ""M"";
";
                var FemalePigsCount = @"
  SELECT count(*) FROM pigs where isSold is false and pigsex = ""F"";
";
                var TotalPigsCountQuery = conn.Query<int>(TotalPigsCount).FirstOrDefault();

                var MalePigsCountQuery = conn.Query<int>(MalePigsCount).FirstOrDefault();
                var FemalePigsCountQuery = conn.Query<int>(FemalePigsCount).FirstOrDefault();


                totalPigsCountTop.Text = "Total Pigs : " + TotalPigsCountQuery;
                MalePigCount.Text = "Male Pigs : " + MalePigsCountQuery;
                FemalePigCount.Text = "Female Pigs : " + FemalePigsCountQuery;
                var memberList = conn.Query<PigModel>(dataCountQuery);
                dgvPig.DataSource = memberList;
                dgvPig.Columns["IsSold"].Visible = false;
                dgvPig.Columns["soldDate"].Visible = false;
                dgvPig.Columns["soldPrice"].Visible = false;
                dgvPig.Columns[0].HeaderText = "ID";
                dgvPig.Columns[1].HeaderText = "Age (Years)";
                dgvPig.Columns[2].HeaderText = "Weight (KG)";
                dgvPig.Columns[3].HeaderText = "Sex";
                dgvPig.Columns[0].Width = 100;
                dgvPig.Columns[1].Width = 200;
                dgvPig.Columns[2].Width = 200;
                dgvPig.Columns[3].Width = 195;
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Purchase_Pig_Btn_Click(object sender, EventArgs e)
        {
            PurchasePigForm form = new PurchasePigForm(this, dashboard);
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SellPigForm sp = new SellPigForm(this, dashboard);
            sp.Show();
        }

        private void Dashboard_Pigs_Load(object sender, EventArgs e)
        {

        }
    }
}
