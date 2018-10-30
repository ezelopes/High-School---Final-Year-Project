using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; //direttiva using OleDb
using System.Security.Cryptography;

namespace Tesina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection conn;

        private void btn_accedi_Click(object sender, EventArgs e)
        {
            try {
                bool corretto = false;
                string nome_account = txt_nomeacc.Text;
                string psw = GetSha256FromString(txt_pswdacc.Text);
                int punteggio_record_account = 0;
                int punteggio_record_tot = 0;
                DBConnect login = new DBConnect();
                corretto = login.Login(nome_account, psw);
               
                if (corretto)
                {
                    punteggio_record_account = login.PunteggioUtente(nome_account);
                    punteggio_record_tot = login.PunteggioMondiale();
                    Form2 frm = new Form2(nome_account, punteggio_record_account, punteggio_record_tot);
                    frm.Show();
                    this.Enabled = false;
                }
                else
                    MessageBox.Show("Sbagliato");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public static string GetSha256FromString(string strData)
        {
            var message = Encoding.ASCII.GetBytes(strData);
            SHA256Managed hashString = new SHA256Managed();
            string hex = "";

            var hashValue = hashString.ComputeHash(message);
            foreach (byte x in hashValue)
            {
                hex += String.Format("{0:x2}", x);
            }
            return hex;
        }
    }
}
