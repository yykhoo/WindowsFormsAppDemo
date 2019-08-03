using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LstCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = lstCity.GetItemText(lstCity.SelectedItem);
            MessageBox.Show(text);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;

            MessageBox.Show(name + address);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;

            connectionString = @"Data Source=DESKTOP-0H4DLNS\MSSQLSERVER2017; Initial Catalog=Demodb; User ID=sa; Password=abc123";

            cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            string sql, Output = "";

            sql = "SELECT * FROM TUTORIAL";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            while( dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + '-' + dataReader.GetValue(1) + "\n";
            }


            MessageBox.Show(Output);

            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }

        private void BindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demodbDataSet.Tutorial' table. You can move, or remove it, as needed.
            this.tutorialTableAdapter.Fill(this.demodbDataSet.Tutorial);

        }
    }
}
