using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace Personel_Registration01
{

    
    public partial class EmployeeIstatistic : Form
    {
        public EmployeeIstatistic()
        {
            InitializeComponent();
        }
        // Total employee 
        SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Personel_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void EmployeeIstatistic_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Personel_table",connection);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while(dr1.Read())
            {
                LblToplamPersonel.Text = dr1[0].ToString(); 
            }
            connection.Close();

            // Married Employee
            connection.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM Personel_table where Personel_status = 1 ",connection);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while(dr2.Read())
            {
                LblMarried.Text = dr2[0].ToString();
            }
            connection.Close();
            // Single Employee
            connection.Open();
            SqlCommand cmd3 = new SqlCommand("SELECT COUNT (*) FROM Personel_table where Personel_status = 0", connection);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while(dr3.Read())
            {
                LblSingle.Text = dr3[0].ToString();
            }
            connection.Close();

            //Cities

            connection.Open();
            SqlCommand cmd4 = new SqlCommand("SELECT COUNT(DISTINCT(Personel_city)) from Personel_table",connection);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while(dr4.Read())
            {
                LblCities.Text = dr4[0].ToString();
            }
            connection.Close();

            //Total Salary
            connection.Open();
            SqlCommand cmd5 = new SqlCommand("SELECT SUM(Personel_salary) from Personel_table", connection);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            while (dr5.Read())
            {
                LblTotalSalary.Text = dr5[0].ToString();
            }
            connection.Close();

            //Average Salary
            connection.Open();
            SqlCommand cmd6 = new SqlCommand("SELECT AVG(Personel_salary) from Personel_table", connection);
            SqlDataReader dr6 = cmd6.ExecuteReader();
            while(dr6.Read())
            {
                LblAverageSalary.Text = dr6[0].ToString();
            }
        }
        

    }
}
