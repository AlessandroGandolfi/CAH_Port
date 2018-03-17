using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace SocketClientCAH
{
    public partial class Form1 : MaterialForm
    {
        Stream mioStream;
        Button[] vettBtn;
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            vettBtn = new[] { btnCartaBiancaPlayer1, btnCartaBiancaPlayer2, btnCartaBiancaPlayer3, btnCartaBiancaPlayer4, btnCartaBiancaPlayer5 };
        }

        private void btnConnetti_Click(object sender, EventArgs e)
        {
            object username = txtUsername.Text;
            txtIPConnessione.Enabled = false;
            if (username.ToString() != "" && txtIPConnessione.Text != "")
            {
                btnConnetti.Visible = false;
                ParameterizedThreadStart tConnessione = new ParameterizedThreadStart(creaConnessione);
                Thread t1 = new Thread(tConnessione);
                t1.Start(username);
            }
            else
                MessageBox.Show("Inserisci uno username per partecipare!");
        }

        public void creaConnessione(object objUser)
        {
            TcpClient mioClient;
            mioClient = new TcpClient(txtIPConnessione.Text, 7777);
            mioStream = mioClient.GetStream();

            ParameterizedThreadStart tStart = new ParameterizedThreadStart(ascolto);
            Thread t2 = new Thread(tStart);
            t2.Start(mioClient);

            txtUsername.Invoke((Action)delegate
            {
                txtUsername.Enabled = false;
            });

            gestioneClient(objUser.ToString());
        }

        public void gestioneClient(string username)
        {
            StreamWriter sw = new StreamWriter(mioStream);
            sw.AutoFlush = true;
            sw.WriteLine("username;"+username);
        }

        public void ascolto(object mioClient)
        {
            string username = txtUsername.Text;
            int contBtnPlayer = 5;
            while (true)
            {
                TcpClient tcpClient = ((TcpClient)mioClient);
                //per leggere dati trasmessi in connessione uso uno stream
                mioStream = tcpClient.GetStream();
                StreamReader sr = new StreamReader(mioStream);
                string msg = sr.ReadLine();
                string[] vett = msg.Split(';');

                if (vett[0] == "inizioBianca" && vett[1] == username)
                {
                    for (int i = 0; i < contBtnPlayer; i++)
                    {
                        vettBtn[i].Invoke((Action)delegate
                        {
                            vettBtn[i].Text = vett[i + 2];
                            vettBtn[i].Enabled = true;
                        });
                    }
                }
                else if(vett[0] == "cartaNera")
                {
                    btnCartaNera.Invoke((Action)delegate
                    {
                        btnCartaNera.Text = vett[1];
                    });
                }
                else if(vett[0] == "NTurno")
                {
                    lblTurno.Invoke((Action)delegate
                    {
                        lblTurno.Text = "TURNO " + vett[1];
                    });
                }
            }
        }
    }
}
