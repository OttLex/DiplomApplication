using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Model.EF;
using Microsoft.Data.SqlClient;
using Npgsql;

namespace WinFormsAppDiplom
{
    public partial class Form1 : Form
    {
        button cl1 = new button();
        Button btn1;
        public Form1()
        {
            InitializeComponent();

            using (var context = new AppDBContext())
            {
                //context.Database.EnsureCreated();
            }

            cl1.CreateMyButton(btn1, "не тыкай", this, 50, 50, 120, 50, Click_My_Button);


            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=ScenarioEditor;Trusted_Connection=True;";
            string sqlExpression = "SELECT * FROM Objects";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                    }
                }
                Console.Read();

            }
            
        }

        public void Click_My_Button(object sender, EventArgs e)
        {
        MessageBox.Show("зачем тыкнул");
        }
 
     
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
