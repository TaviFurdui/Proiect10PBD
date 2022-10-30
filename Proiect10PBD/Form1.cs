using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect10PBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DBConnexion.con.Open();
        }

        private void butonMaterii_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("select * from materii", DBConnexion.con);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;
            dataGridView1.DataSource = bSource;
        }

        private void buttonStudenti_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("select * from studenti", DBConnexion.con);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;
            dataGridView1.DataSource = bSource;
        }

        private void buttonNote_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("select * from note", DBConnexion.con);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;
            dataGridView1.DataSource = bSource;
        }
    }
}
