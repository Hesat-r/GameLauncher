namespace GameLauncher.User
{
    partial class Userspiele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Userspiele));
            this.lblLauncher = new System.Windows.Forms.Label();
            this.lblgame = new System.Windows.Forms.Label();
            this.pbxzurueck = new System.Windows.Forms.PictureBox();
            this.lbxspiele = new System.Windows.Forms.ListBox();
            this.btnspielstarten = new System.Windows.Forms.Button();
            this.lblspielebeschreibung = new System.Windows.Forms.Label();
            this.lblalter = new System.Windows.Forms.Label();
            this.lblalterzahl = new System.Windows.Forms.Label();
            this.pbxminimize = new System.Windows.Forms.PictureBox();
            this.pbxschließen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxzurueck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxminimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxschließen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLauncher
            // 
            this.lblLauncher.Font = new System.Drawing.Font("Paper Flowers", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLauncher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(198)))), ((int)(((byte)(199)))));
            this.lblLauncher.Location = new System.Drawing.Point(483, 42);
            this.lblLauncher.Name = "lblLauncher";
            this.lblLauncher.Size = new System.Drawing.Size(404, 136);
            this.lblLauncher.TabIndex = 9;
            this.lblLauncher.Text = "Launcher";
            // 
            // lblgame
            // 
            this.lblgame.Font = new System.Drawing.Font("Paper Flowers", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(50)))), ((int)(((byte)(37)))));
            this.lblgame.Location = new System.Drawing.Point(285, 42);
            this.lblgame.Name = "lblgame";
            this.lblgame.Size = new System.Drawing.Size(244, 136);
            this.lblgame.TabIndex = 8;
            this.lblgame.Text = "Game";
            // 
            // pbxzurueck
            // 
            this.pbxzurueck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxzurueck.Image = ((System.Drawing.Image)(resources.GetObject("pbxzurueck.Image")));
            this.pbxzurueck.Location = new System.Drawing.Point(21, 28);
            this.pbxzurueck.Name = "pbxzurueck";
            this.pbxzurueck.Size = new System.Drawing.Size(63, 76);
            this.pbxzurueck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxzurueck.TabIndex = 1;
            this.pbxzurueck.TabStop = false;
            this.pbxzurueck.Click += new System.EventHandler(this.pbxzurueck_Click);
            // 
            // lbxspiele
            // 
            this.lbxspiele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.lbxspiele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbxspiele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(198)))), ((int)(((byte)(199)))));
            this.lbxspiele.FormattingEnabled = true;
            this.lbxspiele.ItemHeight = 20;
            this.lbxspiele.Location = new System.Drawing.Point(21, 181);
            this.lbxspiele.Name = "lbxspiele";
            this.lbxspiele.Size = new System.Drawing.Size(343, 464);
            this.lbxspiele.TabIndex = 1;
            this.lbxspiele.SelectedIndexChanged += new System.EventHandler(this.lbxspiele_SelectedIndexChanged);
            // 
            // btnspielstarten
            // 
            this.btnspielstarten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(50)))), ((int)(((byte)(37)))));
            this.btnspielstarten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnspielstarten.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnspielstarten.ForeColor = System.Drawing.Color.Black;
            this.btnspielstarten.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnspielstarten.Location = new System.Drawing.Point(828, 659);
            this.btnspielstarten.Name = "btnspielstarten";
            this.btnspielstarten.Size = new System.Drawing.Size(276, 52);
            this.btnspielstarten.TabIndex = 3;
            this.btnspielstarten.Text = "Spielestarten";
            this.btnspielstarten.UseVisualStyleBackColor = false;
            this.btnspielstarten.Click += new System.EventHandler(this.btnspielstarten_Click);
            // 
            // lblspielebeschreibung
            // 
            this.lblspielebeschreibung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblspielebeschreibung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblspielebeschreibung.ForeColor = System.Drawing.Color.White;
            this.lblspielebeschreibung.Location = new System.Drawing.Point(399, 185);
            this.lblspielebeschreibung.Name = "lblspielebeschreibung";
            this.lblspielebeschreibung.Size = new System.Drawing.Size(674, 460);
            this.lblspielebeschreibung.TabIndex = 2;
            this.lblspielebeschreibung.Text = "spielebeschreibung";
            // 
            // lblalter
            // 
            this.lblalter.AutoSize = true;
            this.lblalter.Font = new System.Drawing.Font("Paper Flowers", 49.75F);
            this.lblalter.ForeColor = System.Drawing.Color.White;
            this.lblalter.Location = new System.Drawing.Point(24, 648);
            this.lblalter.Name = "lblalter";
            this.lblalter.Size = new System.Drawing.Size(134, 69);
            this.lblalter.TabIndex = 19;
            this.lblalter.Text = "Alter:";
            // 
            // lblalterzahl
            // 
            this.lblalterzahl.AutoSize = true;
            this.lblalterzahl.Font = new System.Drawing.Font("Paper Flowers", 49.75F);
            this.lblalterzahl.ForeColor = System.Drawing.Color.White;
            this.lblalterzahl.Location = new System.Drawing.Point(140, 648);
            this.lblalterzahl.Name = "lblalterzahl";
            this.lblalterzahl.Size = new System.Drawing.Size(54, 69);
            this.lblalterzahl.TabIndex = 20;
            this.lblalterzahl.Text = "#";
            // 
            // pbxminimize
            // 
            this.pbxminimize.Image = ((System.Drawing.Image)(resources.GetObject("pbxminimize.Image")));
            this.pbxminimize.Location = new System.Drawing.Point(970, 12);
            this.pbxminimize.Name = "pbxminimize";
            this.pbxminimize.Size = new System.Drawing.Size(64, 55);
            this.pbxminimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxminimize.TabIndex = 22;
            this.pbxminimize.TabStop = false;
            this.pbxminimize.Click += new System.EventHandler(this.pbxminimize_Click);
            // 
            // pbxschließen
            // 
            this.pbxschließen.Image = ((System.Drawing.Image)(resources.GetObject("pbxschließen.Image")));
            this.pbxschließen.Location = new System.Drawing.Point(1040, 12);
            this.pbxschließen.Name = "pbxschließen";
            this.pbxschließen.Size = new System.Drawing.Size(64, 55);
            this.pbxschließen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxschließen.TabIndex = 21;
            this.pbxschließen.TabStop = false;
            this.pbxschließen.Click += new System.EventHandler(this.pbxschließen_Click);
            // 
            // Userspiele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(1116, 719);
            this.Controls.Add(this.pbxminimize);
            this.Controls.Add(this.pbxschließen);
            this.Controls.Add(this.lblalterzahl);
            this.Controls.Add(this.lblalter);
            this.Controls.Add(this.lblspielebeschreibung);
            this.Controls.Add(this.btnspielstarten);
            this.Controls.Add(this.pbxzurueck);
            this.Controls.Add(this.lbxspiele);
            this.Controls.Add(this.lblLauncher);
            this.Controls.Add(this.lblgame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Text = "Userspiele";
            this.Load += new System.EventHandler(this.Userspiele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxzurueck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxminimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxschließen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLauncher;
        private System.Windows.Forms.Label lblgame;
        private System.Windows.Forms.PictureBox pbxzurueck;
        private System.Windows.Forms.ListBox lbxspiele;
        private System.Windows.Forms.Button btnspielstarten;
        private System.Windows.Forms.Label lblspielebeschreibung;
        private System.Windows.Forms.Label lblalter;
        private System.Windows.Forms.Label lblalterzahl;
        private System.Windows.Forms.PictureBox pbxminimize;
        private System.Windows.Forms.PictureBox pbxschließen;
    }
}