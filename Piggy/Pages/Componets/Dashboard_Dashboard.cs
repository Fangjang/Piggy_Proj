using Dapper;
using Piggy.models;
using Piggy.provider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piggy.Pages.Componets
{
    public partial class Dashboard_Dashboard : Form
    {
        private Dashboard _dashboard;
        public Dashboard_Dashboard(Dashboard dashboard)
        {
            InitializeComponent();
            loadRecentSalesData();
            this._dashboard = dashboard;
            dashboard.Dashboard_Sales_Update();
        }
        public void loadRecentSalesData()
        {
            var query = @"
        SELECT * FROM pigs WHERE isSold = true ORDER BY soldDate DESC;
    ";

            using (var conn = ConnectionProvider.GetConnection())
            {
                var latestData = conn.Query<PigModel>(query);
                dgvhome.DataSource = latestData;
                dgvhome.Columns["IsSold"].Visible = false;



                dgvhome.Columns[0].HeaderText = "ID";
                dgvhome.Columns[1].HeaderText = "Age (Years)";
                dgvhome.Columns[2].HeaderText = "Weight (KG)";
                dgvhome.Columns[3].HeaderText = "Sex";
                dgvhome.Columns[5].HeaderText = "Purchased at (Price)";

                // responsive 
                foreach (DataGridViewColumn column in dgvhome.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }

            var lastDaySalesQuery = @"
        SELECT SUM(soldPrice) AS total_sold_price
        FROM pigs
        WHERE soldDate >= DATE_SUB(NOW(), INTERVAL 24 HOUR);
    ";
            using (var conn = ConnectionProvider.GetConnection())
            {
                var xxx = conn.Query<float?>(lastDaySalesQuery).FirstOrDefault() ?? 0;
                salesToday.Text = "Sales Today : " + xxx.ToString();
            }

            var lastDaySalesCountQuery = @"
        SELECT COUNT(*) AS numsales
        FROM pigs
        WHERE soldDate >= DATE_SUB(NOW(), INTERVAL 24 HOUR);
    ";
            using (var conn = ConnectionProvider.GetConnection())
            {
                var xxx = conn.Query<int>(lastDaySalesCountQuery).FirstOrDefault();
                soldTodayElm.Text = "Sold today : " + xxx;
            }

            var allTimeProfitQuery = @"
        SELECT SUM(soldPrice) - SUM(pigPrice) AS profit
        FROM pigs
        WHERE isSold = true;
    ";
            using (var conn = ConnectionProvider.GetConnection())
            {
                var xxx = conn.Query<decimal?>(allTimeProfitQuery).FirstOrDefault() ?? 0;
                profitAllTime.Text = "Profit : " + xxx.ToString();
            }
        }

        /*   public void loadRecentSalesData()
           {
               var query = @"
               SELECT * from pigs where isSold = true order by soldDate desc;
   ";
               using (var conn = ConnectionProvider.GetConnection())
               {
                   var latestData = conn.Query<PigModel>(query);
                   dgvhome.DataSource = latestData;
                   dgvhome.Columns["IsSold"].Visible = false;
                   dgvhome.Columns[0].HeaderText = "ID";
                   dgvhome.Columns[1].HeaderText = "Age (Years)";
                   dgvhome.Columns[2].HeaderText = "Weight (KG)";
                   dgvhome.Columns[3].HeaderText = "Sex";
                   dgvhome.Columns[6].HeaderText = "Sold On (Date)";
                   dgvhome.Columns[5].HeaderText = "Sold on ";
                   dgvhome.Columns[7].HeaderText = "Purchased at (Price)";

                   // responsive 
                   dgvhome.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                   dgvhome.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                   dgvhome.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                   dgvhome.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                   dgvhome.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                   dgvhome.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                   dgvhome.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                   dgvhome.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


               }

               var lastDaySalesQuery = @"
                 SELECT SUM(soldPrice) AS total_sold_price
               FROM pigs
               WHERE soldDate >= DATE_SUB(NOW(), INTERVAL 24 HOUR);
                   ";
               using (var conn = ConnectionProvider.GetConnection())
               {
                   var xxx = conn.Query<float>(lastDaySalesQuery).FirstOrDefault();
                   salesToday.Text = "Sales Today : " + xxx;
               }

               var lastDaySalesCountQuery = @"
                           SELECT 
                           COUNT(*) AS numsales
                           FROM pigs
                           WHERE soldDate >= DATE_SUB(NOW(), INTERVAL 24 HOUR);

                   ";
               using (var conn = ConnectionProvider.GetConnection())
               {
                   var xxx = conn.Query<int>(lastDaySalesCountQuery).FirstOrDefault();
                   soldTodayElm.Text = "Sold today : " + xxx;
               }



               var allTimeProfitQuery = @"
                          SELECT SUM(soldPrice) - SUM(pigPrice) AS profit
   FROM 
       pigs
   WHERE 
       isSold = true;


                   ";
               using (var conn = ConnectionProvider.GetConnection())
               {
                   var xxx = conn.Query<int>(allTimeProfitQuery).FirstOrDefault();
                   profitAllTime.Text = "Profit : " + xxx;
               }







           }*/

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void dgvhome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
