namespace SocketClientCAH
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtIPConnessione = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnCartaNera = new System.Windows.Forms.Button();
            this.btnConnetti = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCartaBianca1 = new System.Windows.Forms.Button();
            this.btnCartaBianca2 = new System.Windows.Forms.Button();
            this.btnCartaBianca3 = new System.Windows.Forms.Button();
            this.btnCartaBianca4 = new System.Windows.Forms.Button();
            this.btnCartaBiancaPlayer1 = new System.Windows.Forms.Button();
            this.btnCartaBiancaPlayer2 = new System.Windows.Forms.Button();
            this.btnCartaBiancaPlayer3 = new System.Windows.Forms.Button();
            this.btnCartaBiancaPlayer4 = new System.Windows.Forms.Button();
            this.btnCartaBiancaPlayer5 = new System.Windows.Forms.Button();
            this.lblTurno = new MaterialSkin.Controls.MaterialLabel();
            this.lblClassifica = new MaterialSkin.Controls.MaterialLabel();
            this.lBClassifica = new System.Windows.Forms.ListBox();
            this.txtUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(13, 78);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(95, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Inserisci IP : ";
            // 
            // txtIPConnessione
            // 
            this.txtIPConnessione.BackColor = System.Drawing.Color.White;
            this.txtIPConnessione.Depth = 0;
            this.txtIPConnessione.Hint = "";
            this.txtIPConnessione.Location = new System.Drawing.Point(114, 78);
            this.txtIPConnessione.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIPConnessione.Name = "txtIPConnessione";
            this.txtIPConnessione.PasswordChar = '\0';
            this.txtIPConnessione.SelectedText = "";
            this.txtIPConnessione.SelectionLength = 0;
            this.txtIPConnessione.SelectionStart = 0;
            this.txtIPConnessione.Size = new System.Drawing.Size(129, 23);
            this.txtIPConnessione.TabIndex = 1;
            this.txtIPConnessione.UseSystemPasswordChar = false;
            // 
            // btnCartaNera
            // 
            this.btnCartaNera.BackColor = System.Drawing.Color.Black;
            this.btnCartaNera.Enabled = false;
            this.btnCartaNera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartaNera.ForeColor = System.Drawing.Color.White;
            this.btnCartaNera.Location = new System.Drawing.Point(17, 117);
            this.btnCartaNera.Name = "btnCartaNera";
            this.btnCartaNera.Size = new System.Drawing.Size(146, 207);
            this.btnCartaNera.TabIndex = 2;
            this.btnCartaNera.Text = "CARTA NERA";
            this.btnCartaNera.UseVisualStyleBackColor = false;
            // 
            // btnConnetti
            // 
            this.btnConnetti.Depth = 0;
            this.btnConnetti.Location = new System.Drawing.Point(263, 77);
            this.btnConnetti.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConnetti.Name = "btnConnetti";
            this.btnConnetti.Primary = true;
            this.btnConnetti.Size = new System.Drawing.Size(110, 23);
            this.btnConnetti.TabIndex = 3;
            this.btnConnetti.Text = "Connetti";
            this.btnConnetti.UseVisualStyleBackColor = true;
            this.btnConnetti.Click += new System.EventHandler(this.btnConnetti_Click);
            // 
            // btnCartaBianca1
            // 
            this.btnCartaBianca1.BackColor = System.Drawing.Color.White;
            this.btnCartaBianca1.Enabled = false;
            this.btnCartaBianca1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartaBianca1.ForeColor = System.Drawing.Color.Black;
            this.btnCartaBianca1.Location = new System.Drawing.Point(263, 117);
            this.btnCartaBianca1.Name = "btnCartaBianca1";
            this.btnCartaBianca1.Size = new System.Drawing.Size(146, 207);
            this.btnCartaBianca1.TabIndex = 4;
            this.btnCartaBianca1.Text = "CARTA BIANCA";
            this.btnCartaBianca1.UseVisualStyleBackColor = false;
            // 
            // btnCartaBianca2
            // 
            this.btnCartaBianca2.BackColor = System.Drawing.Color.White;
            this.btnCartaBianca2.Enabled = false;
            this.btnCartaBianca2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartaBianca2.ForeColor = System.Drawing.Color.Black;
            this.btnCartaBianca2.Location = new System.Drawing.Point(415, 117);
            this.btnCartaBianca2.Name = "btnCartaBianca2";
            this.btnCartaBianca2.Size = new System.Drawing.Size(146, 207);
            this.btnCartaBianca2.TabIndex = 5;
            this.btnCartaBianca2.Text = "CARTA BIANCA";
            this.btnCartaBianca2.UseVisualStyleBackColor = false;
            // 
            // btnCartaBianca3
            // 
            this.btnCartaBianca3.BackColor = System.Drawing.Color.White;
            this.btnCartaBianca3.Enabled = false;
            this.btnCartaBianca3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartaBianca3.ForeColor = System.Drawing.Color.Black;
            this.btnCartaBianca3.Location = new System.Drawing.Point(567, 117);
            this.btnCartaBianca3.Name = "btnCartaBianca3";
            this.btnCartaBianca3.Size = new System.Drawing.Size(146, 207);
            this.btnCartaBianca3.TabIndex = 6;
            this.btnCartaBianca3.Text = "CARTA BIANCA";
            this.btnCartaBianca3.UseVisualStyleBackColor = false;
            // 
            // btnCartaBianca4
            // 
            this.btnCartaBianca4.BackColor = System.Drawing.Color.White;
            this.btnCartaBianca4.Enabled = false;
            this.btnCartaBianca4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartaBianca4.ForeColor = System.Drawing.Color.Black;
            this.btnCartaBianca4.Location = new System.Drawing.Point(719, 117);
            this.btnCartaBianca4.Name = "btnCartaBianca4";
            this.btnCartaBianca4.Size = new System.Drawing.Size(146, 207);
            this.btnCartaBianca4.TabIndex = 7;
            this.btnCartaBianca4.Text = "CARTA BIANCA";
            this.btnCartaBianca4.UseVisualStyleBackColor = false;
            // 
            // btnCartaBiancaPlayer1
            // 
            this.btnCartaBiancaPlayer1.BackColor = System.Drawing.Color.White;
            this.btnCartaBiancaPlayer1.Enabled = false;
            this.btnCartaBiancaPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartaBiancaPlayer1.ForeColor = System.Drawing.Color.Black;
            this.btnCartaBiancaPlayer1.Location = new System.Drawing.Point(245, 388);
            this.btnCartaBiancaPlayer1.Name = "btnCartaBiancaPlayer1";
            this.btnCartaBiancaPlayer1.Size = new System.Drawing.Size(128, 183);
            this.btnCartaBiancaPlayer1.TabIndex = 8;
            this.btnCartaBiancaPlayer1.Text = "CARTA BIANCA PLAYER";
            this.btnCartaBiancaPlayer1.UseVisualStyleBackColor = false;
            // 
            // btnCartaBiancaPlayer2
            // 
            this.btnCartaBiancaPlayer2.BackColor = System.Drawing.Color.White;
            this.btnCartaBiancaPlayer2.Enabled = false;
            this.btnCartaBiancaPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartaBiancaPlayer2.ForeColor = System.Drawing.Color.Black;
            this.btnCartaBiancaPlayer2.Location = new System.Drawing.Point(379, 388);
            this.btnCartaBiancaPlayer2.Name = "btnCartaBiancaPlayer2";
            this.btnCartaBiancaPlayer2.Size = new System.Drawing.Size(128, 183);
            this.btnCartaBiancaPlayer2.TabIndex = 9;
            this.btnCartaBiancaPlayer2.Text = "CARTA BIANCA PLAYER";
            this.btnCartaBiancaPlayer2.UseVisualStyleBackColor = false;
            // 
            // btnCartaBiancaPlayer3
            // 
            this.btnCartaBiancaPlayer3.BackColor = System.Drawing.Color.White;
            this.btnCartaBiancaPlayer3.Enabled = false;
            this.btnCartaBiancaPlayer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartaBiancaPlayer3.ForeColor = System.Drawing.Color.Black;
            this.btnCartaBiancaPlayer3.Location = new System.Drawing.Point(513, 388);
            this.btnCartaBiancaPlayer3.Name = "btnCartaBiancaPlayer3";
            this.btnCartaBiancaPlayer3.Size = new System.Drawing.Size(128, 183);
            this.btnCartaBiancaPlayer3.TabIndex = 10;
            this.btnCartaBiancaPlayer3.Text = "CARTA BIANCA PLAYER";
            this.btnCartaBiancaPlayer3.UseVisualStyleBackColor = false;
            // 
            // btnCartaBiancaPlayer4
            // 
            this.btnCartaBiancaPlayer4.BackColor = System.Drawing.Color.White;
            this.btnCartaBiancaPlayer4.Enabled = false;
            this.btnCartaBiancaPlayer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartaBiancaPlayer4.ForeColor = System.Drawing.Color.Black;
            this.btnCartaBiancaPlayer4.Location = new System.Drawing.Point(647, 388);
            this.btnCartaBiancaPlayer4.Name = "btnCartaBiancaPlayer4";
            this.btnCartaBiancaPlayer4.Size = new System.Drawing.Size(128, 183);
            this.btnCartaBiancaPlayer4.TabIndex = 11;
            this.btnCartaBiancaPlayer4.Text = "CARTA BIANCA PLAYER";
            this.btnCartaBiancaPlayer4.UseVisualStyleBackColor = false;
            // 
            // btnCartaBiancaPlayer5
            // 
            this.btnCartaBiancaPlayer5.BackColor = System.Drawing.Color.White;
            this.btnCartaBiancaPlayer5.Enabled = false;
            this.btnCartaBiancaPlayer5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartaBiancaPlayer5.ForeColor = System.Drawing.Color.Black;
            this.btnCartaBiancaPlayer5.Location = new System.Drawing.Point(781, 388);
            this.btnCartaBiancaPlayer5.Name = "btnCartaBiancaPlayer5";
            this.btnCartaBiancaPlayer5.Size = new System.Drawing.Size(128, 183);
            this.btnCartaBiancaPlayer5.TabIndex = 12;
            this.btnCartaBiancaPlayer5.Text = "CARTA BIANCA PLAYER";
            this.btnCartaBiancaPlayer5.UseVisualStyleBackColor = false;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.BackColor = System.Drawing.Color.White;
            this.lblTurno.Depth = 0;
            this.lblTurno.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTurno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTurno.Location = new System.Drawing.Point(462, 77);
            this.lblTurno.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(69, 19);
            this.lblTurno.TabIndex = 14;
            this.lblTurno.Text = "TURNO _";
            // 
            // lblClassifica
            // 
            this.lblClassifica.AutoSize = true;
            this.lblClassifica.Depth = 0;
            this.lblClassifica.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblClassifica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblClassifica.Location = new System.Drawing.Point(13, 350);
            this.lblClassifica.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblClassifica.Name = "lblClassifica";
            this.lblClassifica.Size = new System.Drawing.Size(84, 19);
            this.lblClassifica.TabIndex = 15;
            this.lblClassifica.Text = "Classifica :";
            // 
            // lBClassifica
            // 
            this.lBClassifica.FormattingEnabled = true;
            this.lBClassifica.Location = new System.Drawing.Point(17, 373);
            this.lBClassifica.Name = "lBClassifica";
            this.lBClassifica.Size = new System.Drawing.Size(146, 147);
            this.lBClassifica.TabIndex = 16;
            // 
            // txtUsername
            // 
            this.txtUsername.Depth = 0;
            this.txtUsername.Hint = "Inserisci Username";
            this.txtUsername.Location = new System.Drawing.Point(719, 78);
            this.txtUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.Size = new System.Drawing.Size(170, 23);
            this.txtUsername.TabIndex = 17;
            this.txtUsername.UseSystemPasswordChar = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 601);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lBClassifica);
            this.Controls.Add(this.lblClassifica);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.btnCartaBiancaPlayer5);
            this.Controls.Add(this.btnCartaBiancaPlayer4);
            this.Controls.Add(this.btnCartaBiancaPlayer3);
            this.Controls.Add(this.btnCartaBiancaPlayer2);
            this.Controls.Add(this.btnCartaBiancaPlayer1);
            this.Controls.Add(this.btnCartaBianca4);
            this.Controls.Add(this.btnCartaBianca3);
            this.Controls.Add(this.btnCartaBianca2);
            this.Controls.Add(this.btnCartaBianca1);
            this.Controls.Add(this.btnConnetti);
            this.Controls.Add(this.btnCartaNera);
            this.Controls.Add(this.txtIPConnessione);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Client CAH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIPConnessione;
        private System.Windows.Forms.Button btnCartaNera;
        private MaterialSkin.Controls.MaterialRaisedButton btnConnetti;
        private System.Windows.Forms.Button btnCartaBianca1;
        private System.Windows.Forms.Button btnCartaBianca2;
        private System.Windows.Forms.Button btnCartaBianca3;
        private System.Windows.Forms.Button btnCartaBianca4;
        private System.Windows.Forms.Button btnCartaBiancaPlayer1;
        private System.Windows.Forms.Button btnCartaBiancaPlayer2;
        private System.Windows.Forms.Button btnCartaBiancaPlayer3;
        private System.Windows.Forms.Button btnCartaBiancaPlayer4;
        private System.Windows.Forms.Button btnCartaBiancaPlayer5;
        private MaterialSkin.Controls.MaterialLabel lblTurno;
        private MaterialSkin.Controls.MaterialLabel lblClassifica;
        private System.Windows.Forms.ListBox lBClassifica;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsername;
    }
}

