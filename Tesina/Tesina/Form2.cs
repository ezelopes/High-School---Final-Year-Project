using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;

namespace Tesina
{
    //delegates are used to manipulate controls like text box and list box ....etc from threads, they are an interface.
    //we need this delegate to change the contents of the text box (received messages)
    delegate void UpdateTextBox(string msg);
    delegate void UpdateProgressBar(int valore);

    public partial class Form2 : Form
    {
        private TcpListener ConnectionListener;
        private Socket ClientConnection;
        private NetworkStream DataStream;
        private Thread ListeningThread;
        Thread tt;
        int punteggio_corrente = 0;
        int punteggio_record_account = 0;
        int punteggio_record = 0;
        int conta = 0;
        Boolean partita_iniziata = false;

        public Form2(string nome_account, int pnt, int pnt2)
        {
            InitializeComponent();
            lbl_nomeaccount.Text = nome_account;
            punteggio_record_account = pnt;
            punteggio_record = pnt2;
            lbl_recordPersonale.Text = punteggio_record_account.ToString();
            lbl_recordTotale.Text = punteggio_record.ToString();

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 60;
            CheckForIllegalCrossThreadCalls = false;
        }


        private void ricercaConnessioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  IPAddress.Parse(textBox3.Text);
            ListeningThread = new Thread(new ThreadStart(ListenForConnections));
            ListeningThread.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = false;
                
                progressBar1.Value = 0;

                punteggio_corrente = 0;
                lbl_punteggioCorrente.Text = "0";

                if (tt != null)
                    tt.Abort();

                tt = new Thread(new ThreadStart(prova));

                tt.Start();
               
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong Ip Address");
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(ConnectionListener != null)
                ConnectionListener.Stop();
            if(ClientConnection != null)
                ClientConnection.Close();
            if (ListeningThread != null)
            {
                ListeningThread.Abort();
               // ListeningThread.Join();
            }
            if (tt != null)
            {
                tt.Abort();
               // tt.Join();
            }
            Application.OpenForms["Form1"].Enabled = true;
            // System.Environment.Exit(System.Environment.ExitCode);//exit and close all threads and release all recources
        }

        private void prova()
        {
            conta = 0;
            partita_iniziata = true;
            do
            {
                try
                {
                    progressBar1.PerformStep();
                    conta++;
                    lbl_tempo.Text = "Tempo: " + conta.ToString();

                    if (conta >= 50)
                    {
                        lbl_tempo.ForeColor = Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                System.Threading.Thread.Sleep(1000);
            } while (conta < 60);

            conta = 0;
            progressBar1.Value = 0;
            lbl_tempo.ForeColor = Color.Black;
            button1.Enabled = true;
            partita_iniziata = false;

            DBConnect inserimentodb = new DBConnect();
            string sqlFormattedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            inserimentodb.InsertPunteggio(lbl_nomeaccount.Text, punteggio_corrente, sqlFormattedDate);
            MessageBox.Show("Punteggio salvato!");
        }

        
        private void ListenForConnections()
        {
            try
            {
                ConnectionListener = new TcpListener(IPAddress.Any, 9000);
                ConnectionListener.Start();
                ChangeTextBoxContent("Listening For Connections");
                ClientConnection = ConnectionListener.AcceptSocket();
                DataStream = new NetworkStream(ClientConnection);
                ChangeTextBoxContent("Connection Received");
                button1.Enabled = true;


                ConnectionListener.Stop(); //DEVO ACCETTARNE SOLO UNO
                HandleConnection(); //mantieni viva la connessione
                DataStream.Close();
                ClientConnection.Close();
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
        }
        private void HandleConnection()
        {
            string message;
            do
            {
                while (partita_iniziata == true)
                {

                    try
                    {
                        Byte[] bytes = new Byte[ClientConnection.ReceiveBufferSize];
                        int numero_bytes = DataStream.Read(bytes, 0, ClientConnection.ReceiveBufferSize);
                        message = Encoding.ASCII.GetString(bytes, 0, numero_bytes);
                        if (partita_iniziata == true)
                        {
                            //if (message == "0\0") //CANESTRO FATTO
                            //{
                            if ((progressBar1.Value) >= 50)
                                punteggio_corrente += 3;
                            else
                                punteggio_corrente += 2;
                            ChangeTextBoxContent(message);
                        }
                        //}
                    }
                    catch (Exception ex)
                    {
                      //  ChangeTextBoxContent(ex.Message);
                        break;
                    }

                }
            } while (true);
        }
        

        private void ChangeTextBoxContent(string tx)
        {
            if (textBox1.InvokeRequired)
            { 
                Invoke(new UpdateTextBox(ChangeTextBoxContent), new object[] { tx });
            }
            else
            {
                lbl_punteggioCorrente.Text = punteggio_corrente.ToString();
                textBox1.Text += tx + "\r\n";
            }
        }

        private void classificheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost/SitoClassifica_Tesina/Accedi.php");
        }

        private void guidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"Tesina 29_6_2016.pdf");
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ConnectionListener != null)
                ConnectionListener.Stop();
            if (ClientConnection != null)
                ClientConnection.Close();
            if (ListeningThread != null)
            {
                ListeningThread.Abort();
                // ListeningThread.Join();
            }
            if (tt != null)
            {
                tt.Abort();
                // tt.Join();
            }
            this.Close();
            Application.OpenForms["Form1"].Enabled = true;
        }
    }
}
