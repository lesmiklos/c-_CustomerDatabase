using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;

//namespace TabControls { }

 /*   {
    public partial class Tabby: TabControl
    {
        string connectionString = @"server=localhost;database=customers;uid=les;pwd=1234Alway$;";
        int CustID = 0;  // take note

        public Tabby()
                 
        
        {
           void TabControls();
        }

    

        

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        
            private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

            void Gridfill()
            {
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {


                    mysqlCon.Open();
                    MySqlDataAdapter sqlDa = new MySqlDataAdapter("CustomerViewAll", mysqlCon);
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable dtblcustomers = new DataTable();
                    sqlDa.Fill(dtblcustomers);
                    dataGridView.DataSource = dtblcustomers;
                    dataGridView.Columns[0].Visible = false;


                }
            }

            private void TabControls_Load(object sender, EventArgs e)
            {
                Clear();
                Gridfill();
            }








}
    }

*/