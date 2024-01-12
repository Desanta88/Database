using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Carica_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=programma;pwd=12345;database=etichettadiscografica";
            string query = "SELECT * FROM album";
            MySqlConnection connect = new MySqlConnection(connectionString);
            connect.Open();
            MySqlCommand comm=new MySqlCommand(query,connect);
            comm.ExecuteNonQuery();
            MySqlDataAdapter adapter = new MySqlDataAdapter(comm);
            DataTable data=new DataTable();
            adapter.Fill(data);
            dataGridView1.DataSource = data;
            comm.ExecuteNonQuery();

            connect.Close();

        }
    }
}
