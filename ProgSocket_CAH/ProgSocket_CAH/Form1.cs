using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using ADOSQLServer2016_c;
using System.Data.SqlClient;

namespace ProgSocket_CAH
{
    public partial class Form1 : MaterialForm
    {
        Socket mioSocket;
        Stream mioStream;
        TcpListener server;
        //liste carte
        List<string> carteNere = new List<string>();
        List<string> carteBianche = new List<string>();
        //giocatore, ultima carta scelta, punteggio
        string[,] tabellaGestGiocatori = new string[4,3];
        //contatore turni
        int contTurni = 1;
        //contatore giocatori
        int contGioc = 0;

        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            btnAvviaPartita.Visible = false;
            btnChiudiConnessione.Visible = false;
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }

        private void btnCreaConnessione_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(creaConnessione);
            t1.Start();
        }

        public void creaConnessione()
        {
            int nPort = 7777;
            IPAddress indirizzoIP = IPAddress.Parse(GetLocalIPAddress().ToString());
            lblIP.Invoke((Action)delegate
            {
                lblIP.Text += GetLocalIPAddress().ToString();
            });
            btnCreaConnessione.Invoke((Action)delegate
            {
                btnCreaConnessione.Visible = false;
            });
            btnChiudiConnessione.Invoke((Action)delegate
            {
                btnChiudiConnessione.Visible = true;
            });
            //tcplistener, classe per creazione e avvio server
            server = new TcpListener(indirizzoIP, nPort);
            server.Start();
            
            Thread t2 = new Thread(ascolto);
            t2.Start();
        }

        public void ascolto()
        {
            while (true)
            {
                //si blocca programma fino ad arrivo di richiesta
                mioSocket = server.AcceptSocket();
                //per leggere dati trasmessi in connessione uso uno stream
                mioStream = new NetworkStream(mioSocket);

                ParameterizedThreadStart ascoltoSW = new ParameterizedThreadStart(ascoltoStreamReader);
                Thread t3 = new Thread(ascoltoSW);
                t3.Start(mioStream);
            }
        }

        public void ascoltoStreamReader(object stream)
        {
            Stream mioStream = ((Stream)stream);
            while (mioSocket.Connected == true)
            {
                StreamReader sr = new StreamReader(mioStream);
                string msg = sr.ReadLine();
                string[] vett = msg.Split(';');
                switch (vett[0])
                {
                    case "username":
                        aggiungiGiocatore(vett[1]);
                        break;
                    case "cartaScelta":
                        aggiungiPunto(vett);
                        break;
                }
            }
        }

        public void aggiungiGiocatore(string newUser)
        {
            tabellaGestGiocatori[contGioc, 0] = newUser;
            listBoxGiocatoriServer.Invoke((Action)delegate
            {
                listBoxGiocatoriServer.Items.Add(tabellaGestGiocatori[contGioc, 0]);
            });
            contGioc++;
            if (listBoxGiocatoriServer.Items.Count == 2)
                btnAvviaPartita.Invoke((Action)delegate
                {
                    btnAvviaPartita.Visible = true;
                });
        }

        private void btnAvviaPartita_Click(object sender, EventArgs e)
        {
            ADOSQLServer2016 ado = new ADOSQLServer2016("CAH.mdf");
            DataTable dt;
            Random rnd = new Random();

            int[] idCN = new int[7];
            int[] idCB = new int[50];

            for (int i = 0; i < idCN.Length; i++)
                idCN[i] = 0;

            for (int i = 0; i < idCB.Length; i++)
                idCB[i] = 0;

            SqlCommand cmd = new SqlCommand();
            int idNewCN;
            int idNewCB;
            cmd.CommandType = CommandType.Text;

            //estrazione carte nere
            for (int i = 0; i < 7; i++)
            {
                do
                {
                    idNewCN = rnd.Next(1, 40);
                } while (controlloVettID(idCN, idNewCN));
                idCN[i] = idNewCN;
                cmd.CommandText = "select TestoNera from CarteNere where IdCartaNera=" + idNewCN;
                dt = ado.EseguiQuery(cmd);
                carteNere.Add(dt.Rows[0][0].ToString());
            }
            
            //estrazione carte bianche
            for (int i = 0; i < 50; i++)
            {
                do
                {
                    idNewCB = rnd.Next(1, 100);
                } while (controlloVettID(idCB, idNewCB));
                idCB[i] = idNewCB;
                cmd.CommandText = "select TestoBianca from CarteBianche where IdCartaBianca=" + idNewCB;
                dt = ado.EseguiQuery(cmd);
                carteBianche.Add(dt.Rows[0][0].ToString());
            }

            distribuzioneCarte();
        }
        
        public void distribuzioneCarte()
        {
            StreamWriter sw = new StreamWriter(mioStream);
            sw.AutoFlush = true;
            for (int i = 0; i < contGioc; i++) { 
                
                sw.WriteLine("inizioBianca;"+tabellaGestGiocatori[i, 0].ToString()+";"+carteBianche[0].ToString() + ";" + carteBianche[1].ToString() + ";" + carteBianche[2].ToString() + ";" + carteBianche[3].ToString() + ";" + carteBianche[4].ToString());
                carteBianche.RemoveAt(0);
                carteBianche.RemoveAt(1);
                carteBianche.RemoveAt(2);
                carteBianche.RemoveAt(3);
                carteBianche.RemoveAt(4);
            }
            sw.WriteLine("NTurno;" + contTurni.ToString());
            contTurni++;
            sw.WriteLine("cartaNera;" + carteNere[0].ToString());
            carteNere.RemoveAt(0);
        }

        public void aggiungiPunto(string[] vettCarteScelte)
        {

        }

        public bool controlloVettID(int[] vett, int id)
        {
            bool pres = false;
            for (int i = 0; i < vett.Length; i++)
            {
                if (id == vett[i])
                    pres = true;
            }
            return pres;
        }
    }
    
}
