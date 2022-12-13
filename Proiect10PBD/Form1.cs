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

        private void buttonNepromovati_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand(@"
                SELECT studenti.nume, studenti.prenume, note.nota, note.id_materie FROM studenti
                INNER JOIN note ON note.nr_legitimatie = studenti.nr_legitimatie
                GROUP BY note.id_materie, note.nr_legitimatie
                HAVING MAX(note.nota) < 5", DBConnexion.con);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;
            dataGridView1.DataSource = bSource;
        }

        private void buttonRaport5_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand(@"
                SELECT studenti.nume, studenti.prenume, MAX(materii.an_studiu) AS an_studiu, studenti.nr_legitimatie FROM studenti 
                INNER JOIN note ON note.nr_legitimatie = studenti.nr_legitimatie 
                INNER JOIN materii ON materii.id_materie = note.id_materie 
                GROUP BY studenti.nr_legitimatie", DBConnexion.con);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;
            dataGridView1.DataSource = bSource;
        }

        private void buttonRaport6_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand(@"
               SELECT studenti.nume, studenti.prenume, studenti.nr_legitimatie, materii.nume_materie, MAX(note.nota) AS nota_finala FROM studenti
                INNER JOIN note ON note.nr_legitimatie = studenti.nr_legitimatie
                INNER JOIN materii ON materii.id_materie = note.id_materie 
                GROUP BY note.id_materie, note.nr_legitimatie
                HAVING MAX(note.nota) > 4
                ORDER BY studenti.nume, studenti.prenume, materii.an_studiu, materii.nume_materie", DBConnexion.con);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;
            dataGridView1.DataSource = bSource;
        }

        private void buttonPromovabilitate_Click(object sender, EventArgs e)
        {
            var promovabilitate = new Promovabilitate();
            promovabilitate.Show();
        }

        private void buttonStudentiMaterii_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand(@"
                SELECT studenti.nr_legitimatie, studenti.nume, studenti.prenume, materii1.an_studiu, materii2.an_studiu
                FROM studenti 
                INNER JOIN note AS note1 ON note1.nr_legitimatie = studenti.nr_legitimatie 
                INNER JOIN note AS note2 ON note2.nr_legitimatie = studenti.nr_legitimatie
                INNER JOIN materii AS materii1 ON materii1.id_materie = note1.id_materie 
                INNER JOIN materii AS materii2 ON materii2.id_materie = note2.id_materie 
                GROUP BY studenti.nr_legitimatie, materii1.id_materie, materii2.id_materie
                HAVING ((MAX(note1.nota) < 5 AND materii1.an_studiu = 1) AND (MAX(note2.nota) < 5 AND materii2.an_studiu = 2)) 
                OR ((MAX(note1.nota) < 5 AND materii1.an_studiu = 2) AND (MAX(note2.nota) < 5 AND materii2.an_studiu = 3));", DBConnexion.con);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;
            dataGridView1.DataSource = bSource;
        }

        private void buttonTheStudent_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand(@"
               SELECT MAX(suma_prezentari) AS Nr_prezentari, studenti.nume, studenti.prenume, Promovabilitate_student(studenti.nr_legitimatie) AS promovabilitate
                FROM (
                    SELECT SUM(maxim_prezentari) AS suma_prezentari, studenti.nr_legitimatie
	                FROM (
    	                SELECT MAX(note.nr_prezentare) as maxim_prezentari, studenti.nr_legitimatie
		                FROM note 
		                INNER JOIN studenti ON note.nr_legitimatie = studenti.nr_legitimatie 
		                GROUP BY studenti.nr_legitimatie, note.id_materie
	                ) AS tabel_sume
	                INNER JOIN studenti ON tabel_sume.nr_legitimatie = studenti.nr_legitimatie 
	                GROUP BY studenti.nr_legitimatie
                ) AS tabel_maxim
                INNER JOIN studenti ON tabel_maxim.nr_legitimatie = studenti.nr_legitimatie ", DBConnexion.con);
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
