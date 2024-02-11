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
using System.Collections;
using System.Runtime.Remoting.Contexts;

namespace Personel_Registration01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Personel_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        void temizle()
        {
            TxtId.Text = "";
            TxtName.Text = "";
            TxtSurname.Text = "";
            CmbCity.Text = "";
            MskSalary.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            TxtJob.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CmbCity.Items.Add("Bartin");
            CmbCity.Items.Add("Ankara");
            CmbCity.Items.Add("Istanbul");
            CmbCity.Items.Add("Izmir");
            CmbCity.Items.Add("Bursa");
            


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personel_DBDataSet1.Personel_table' table. You can move, or remove it, as needed.
            this.personel_tableTableAdapter.Fill(this.personel_DBDataSet1.Personel_table);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Personel_table (Personel_name,Personel_surname,Personel_city,Personel_salary,Personel_job,Personel_status) values(@p1,@p2,@p3,@p4,@p5,@p6)",connection);
            command.Parameters.AddWithValue("@p1", TxtName.Text);
            command.Parameters.AddWithValue("@p2", TxtSurname.Text);
            command.Parameters.AddWithValue("@p3", CmbCity.Text);
            command.Parameters.AddWithValue("@p4", MskSalary.Text);
            command.Parameters.AddWithValue("@p5", TxtJob.Text);
            command.Parameters.AddWithValue("@p6", label8.Text);
            command.Connection = connection;
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Registration is successfully");
            }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                label8.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked == true)
            {
                label8.Text = "False";
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void CmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            TxtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbCity.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskSalary.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtJob.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if(label8.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if(label8.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand commanddel = new SqlCommand("Delete from Personel_table where Personel_id=@k1", connection);
            commanddel.Parameters.AddWithValue("@k1", TxtId.Text);
            commanddel.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Registration is delete\n");
            temizle();
            
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand commandupdate = new SqlCommand("update Personel_table SET Personel_name =@u1,Personel_surname = @u2,Personel_city = @u3,Personel_salary = @u4,Personel_status = @u5,Personel_job = @u6 where Personel_id = @u7",connection);
            commandupdate.Parameters.AddWithValue("@u7", TxtId.Text);
            commandupdate.Parameters.AddWithValue("@u1", TxtName.Text);
            commandupdate.Parameters.AddWithValue("@u2", TxtSurname.Text);
            commandupdate.Parameters.AddWithValue("@u3", CmbCity.Text);
            commandupdate.Parameters.AddWithValue("@u4", MskSalary.Text);
            commandupdate.Parameters.AddWithValue("@u5", label8.Text);
            commandupdate.Parameters.AddWithValue("@u6", TxtJob.Text);


            commandupdate.ExecuteNonQuery();
           connection.Close();
            MessageBox.Show("Update is completed");
        }

        private void BtnIstatistic_Click(object sender, EventArgs e)
        {
            EmployeeIstatistic fr = new EmployeeIstatistic();
            fr.Show();

        }

        private void BtnGraph_Click(object sender, EventArgs e)
        {
            Graphics frc = new Graphics();
            frc.Show();
        }
    }
    }

