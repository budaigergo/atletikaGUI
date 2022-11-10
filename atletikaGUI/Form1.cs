using MaxMind.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Pkix;
using Org.BouncyCastle.Asn1.BC;
using Microsoft.Win32;

namespace atletikaGUI
{


    public partial class Form1 : Form
    {

        MySqlConnection conn;
        MySqlCommand command;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "atletikavb2017";

            conn = new MySqlConnection(builder.ConnectionString);
            command = conn.CreateCommand();

            VersenySzamokLekeres();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            command.CommandText = "SELECT * FROM nemzetek WHERE NemzetId IN(SELECT DISTINCT NemzetKod FROM versenyekszamok WHERE Nem = 'F' AND Helyezes = 1)";
            conn.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.listBoxOrszagok.Items.Add(reader["Nemzet"]);
            }
            conn.Close();
        }

        public void VersenySzamokLekeres()
        {
            command.CommandText = "SELECT DISTINCT Versenyszam FROM versenyekszamok";
            conn.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.listBoxVersenyszamok.Items.Add(reader["Versenyszam"]);

            }
            conn.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string versenyszam = this.listBoxVersenyszamok.SelectedItem as string;
            string erem = this.eremvalaszto.Value.ToString();

            if (versenyszam == null)
            {
                MessageBox.Show("Nem adott meg versenyszámot","hiba");
            }
            else if (erem == null)
            {
                MessageBox.Show("Nem adott meg érmet","hiba");
            }
            else if (Convert.ToInt32(erem)<0 || Convert.ToInt32(erem) >3)
            {
                MessageBox.Show("Csak érmes helyezéseket tartalmaz a statisztika!","hiba");
            }
            else
            {
                command.CommandText = $"SELECT * FROM versenyekszamok WHERE versenyszam='{versenyszam}' and helyezes='{erem}' AND nem='F'";
                conn.Open();
                MySqlDataReader reader=command.ExecuteReader();
                while (reader.Read())
                {
                    this.nev.Text = reader["VersenyzoNev"].ToString();
                    this.eredmeny.Text = reader["Eredmeny"].ToString();
                    this.nemzet.Text = reader["NemzetKod"].ToString();
                }
                reader.Close();
                command.CommandText = $"SELECT * FROM nemzetek WHERE nemzetid={this.nemzet.Text}";
                reader=command.ExecuteReader();
                while (reader.Read()) 
                {
                    this.nemzet.Text = reader["Nemzet"].ToString();
                }
                reader.Close();
                conn.Close();
            }

        }
    }
}
