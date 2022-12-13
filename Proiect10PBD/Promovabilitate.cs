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
    public partial class Promovabilitate : Form
    {
        public Promovabilitate()
        {
            InitializeComponent();
        }

        private void buttonPromovabilitate_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand(@"SELECT Promovabilitate(@materie)", DBConnexion.con);
            cmd.Parameters.AddWithValue("@materie",textBoxMaterie.Text);
            labelPromovabilitate.Text = cmd.ExecuteScalar().ToString() + "%";
        }
    }
}
