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

namespace Personel_Registration01
{
    public partial class Graphics : Form
    {
        public Graphics()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Personel_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void Graphics_Load(object sender, EventArgs e)
        {

            //City
            connection.Open();
            SqlCommand cmdch1 = new SqlCommand("SELECT (Personel_city),COUNT(*) from Personel_table GROUP BY Personel_city", connection);
            SqlDataReader dr1 = cmdch1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["City"].Points.AddXY(dr1[0], dr1[1]);
            }
            connection.Close();
            //Salary
            connection.Open();
            SqlCommand cmdch2 = new SqlCommand("SELECT (Personel_job),AVG(Personel_salary) from Personel_table GROUP BY Personel_job", connection);
            SqlDataReader dr2 = cmdch2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Job_Salary"].Points.AddXY(dr2[0], dr2[1]);
            }



            connection.Close();

        }
    }
}
