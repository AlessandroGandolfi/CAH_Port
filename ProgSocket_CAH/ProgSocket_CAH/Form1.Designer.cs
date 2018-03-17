namespace ProgSocket_CAH
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreaConnessione = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnChiudiConnessione = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIpServer = new System.Windows.Forms.Label();
            this.btnAvviaPartita = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listBoxGiocatoriServer = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreaConnessione
            // 
            this.btnCreaConnessione.Depth = 0;
            this.btnCreaConnessione.Location = new System.Drawing.Point(12, 140);
            this.btnCreaConnessione.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreaConnessione.Name = "btnCreaConnessione";
            this.btnCreaConnessione.Primary = true;
            this.btnCreaConnessione.Size = new System.Drawing.Size(164, 55);
            this.btnCreaConnessione.TabIndex = 0;
            this.btnCreaConnessione.Text = "Crea Connessione";
            this.btnCreaConnessione.UseVisualStyleBackColor = true;
            this.btnCreaConnessione.Click += new System.EventHandler(this.btnCreaConnessione_Click);
            // 
            // btnChiudiConnessione
            // 
            this.btnChiudiConnessione.Depth = 0;
            this.btnChiudiConnessione.Location = new System.Drawing.Point(12, 297);
            this.btnChiudiConnessione.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChiudiConnessione.Name = "btnChiudiConnessione";
            this.btnChiudiConnessione.Primary = true;
            this.btnChiudiConnessione.Size = new System.Drawing.Size(164, 55);
            this.btnChiudiConnessione.TabIndex = 2;
            this.btnChiudiConnessione.Text = "Chiudi Connessione";
            this.btnChiudiConnessione.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(47, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sockets Against Humanity";
            // 
            // lblIpServer
            // 
            this.lblIpServer.AutoSize = true;
            this.lblIpServer.Location = new System.Drawing.Point(12, 152);
            this.lblIpServer.Name = "lblIpServer";
            this.lblIpServer.Size = new System.Drawing.Size(0, 13);
            this.lblIpServer.TabIndex = 6;
            // 
            // btnAvviaPartita
            // 
            this.btnAvviaPartita.Depth = 0;
            this.btnAvviaPartita.Location = new System.Drawing.Point(12, 219);
            this.btnAvviaPartita.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAvviaPartita.Name = "btnAvviaPartita";
            this.btnAvviaPartita.Primary = true;
            this.btnAvviaPartita.Size = new System.Drawing.Size(164, 55);
            this.btnAvviaPartita.TabIndex = 7;
            this.btnAvviaPartita.Text = "Avvia Partita";
            this.btnAvviaPartita.UseVisualStyleBackColor = true;
            this.btnAvviaPartita.Click += new System.EventHandler(this.btnAvviaPartita_Click);
            // 
            // listBoxGiocatoriServer
            // 
            this.listBoxGiocatoriServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGiocatoriServer.FormattingEnabled = true;
            this.listBoxGiocatoriServer.ItemHeight = 18;
            this.listBoxGiocatoriServer.Location = new System.Drawing.Point(221, 219);
            this.listBoxGiocatoriServer.Name = "listBoxGiocatoriServer";
            this.listBoxGiocatoriServer.Size = new System.Drawing.Size(216, 148);
            this.listBoxGiocatoriServer.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(216, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lista giocatori connessi:";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblIP.Location = new System.Drawing.Point(216, 140);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(41, 25);
            this.lblIP.TabIndex = 10;
            this.lblIP.Text = "IP: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(462, 399);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxGiocatoriServer);
            this.Controls.Add(this.btnAvviaPartita);
            this.Controls.Add(this.lblIpServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChiudiConnessione);
            this.Controls.Add(this.btnCreaConnessione);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnCreaConnessione;
        private MaterialSkin.Controls.MaterialRaisedButton btnChiudiConnessione;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIpServer;
        private MaterialSkin.Controls.MaterialRaisedButton btnAvviaPartita;
        private System.Windows.Forms.ListBox listBoxGiocatoriServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIP;
    }
}

