namespace EnkelAdressebok
{
    partial class Form1
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
            this.tbFnavn = new System.Windows.Forms.TextBox();
            this.tbEnavn = new System.Windows.Forms.TextBox();
            this.tbMnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nyOppføringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slettOppføringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btForrige = new System.Windows.Forms.Button();
            this.btNeste = new System.Windows.Forms.Button();
            this.pNyOppf = new System.Windows.Forms.Panel();
            this.btLagre = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNyMnum = new System.Windows.Forms.TextBox();
            this.tbNyEnavn = new System.Windows.Forms.TextBox();
            this.tbNyFnavn = new System.Windows.Forms.TextBox();
            this.pVisning = new System.Windows.Forms.Panel();
            this.pLoggOn = new System.Windows.Forms.Panel();
            this.btLoggInn = new System.Windows.Forms.Button();
            this.tbPassord = new System.Windows.Forms.TextBox();
            this.lPassord = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pNyOppf.SuspendLayout();
            this.pVisning.SuspendLayout();
            this.pLoggOn.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFnavn
            // 
            this.tbFnavn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbFnavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFnavn.Location = new System.Drawing.Point(153, 17);
            this.tbFnavn.Name = "tbFnavn";
            this.tbFnavn.Size = new System.Drawing.Size(152, 29);
            this.tbFnavn.TabIndex = 0;
            // 
            // tbEnavn
            // 
            this.tbEnavn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbEnavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEnavn.Location = new System.Drawing.Point(153, 52);
            this.tbEnavn.Name = "tbEnavn";
            this.tbEnavn.Size = new System.Drawing.Size(152, 29);
            this.tbEnavn.TabIndex = 1;
            // 
            // tbMnum
            // 
            this.tbMnum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbMnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMnum.Location = new System.Drawing.Point(153, 87);
            this.tbMnum.Name = "tbMnum";
            this.tbMnum.Size = new System.Drawing.Size(152, 29);
            this.tbMnum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fornavn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Etternavn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mobilnummer:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyOppføringToolStripMenuItem,
            this.slettOppføringToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(450, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nyOppføringToolStripMenuItem
            // 
            this.nyOppføringToolStripMenuItem.Name = "nyOppføringToolStripMenuItem";
            this.nyOppføringToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.nyOppføringToolStripMenuItem.Text = "Ny oppføring";
            this.nyOppføringToolStripMenuItem.Click += new System.EventHandler(this.nyOppføringToolStripMenuItem_Click);
            // 
            // slettOppføringToolStripMenuItem
            // 
            this.slettOppføringToolStripMenuItem.Name = "slettOppføringToolStripMenuItem";
            this.slettOppføringToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.slettOppføringToolStripMenuItem.Text = "Slett oppføring";
            this.slettOppføringToolStripMenuItem.Click += new System.EventHandler(this.slettOppføringToolStripMenuItem_Click);
            // 
            // btForrige
            // 
            this.btForrige.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btForrige.Location = new System.Drawing.Point(153, 127);
            this.btForrige.Name = "btForrige";
            this.btForrige.Size = new System.Drawing.Size(41, 41);
            this.btForrige.TabIndex = 7;
            this.btForrige.Text = "<--";
            this.btForrige.UseVisualStyleBackColor = true;
            this.btForrige.Click += new System.EventHandler(this.bla_Click);
            // 
            // btNeste
            // 
            this.btNeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNeste.Location = new System.Drawing.Point(210, 127);
            this.btNeste.Name = "btNeste";
            this.btNeste.Size = new System.Drawing.Size(43, 41);
            this.btNeste.TabIndex = 8;
            this.btNeste.Text = "-->";
            this.btNeste.UseVisualStyleBackColor = true;
            this.btNeste.Click += new System.EventHandler(this.bla_Click);
            // 
            // pNyOppf
            // 
            this.pNyOppf.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pNyOppf.Controls.Add(this.btLagre);
            this.pNyOppf.Controls.Add(this.label4);
            this.pNyOppf.Controls.Add(this.label5);
            this.pNyOppf.Controls.Add(this.label6);
            this.pNyOppf.Controls.Add(this.tbNyMnum);
            this.pNyOppf.Controls.Add(this.tbNyEnavn);
            this.pNyOppf.Controls.Add(this.tbNyFnavn);
            this.pNyOppf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pNyOppf.Location = new System.Drawing.Point(414, 287);
            this.pNyOppf.Name = "pNyOppf";
            this.pNyOppf.Size = new System.Drawing.Size(361, 173);
            this.pNyOppf.TabIndex = 9;
            // 
            // btLagre
            // 
            this.btLagre.Location = new System.Drawing.Point(155, 127);
            this.btLagre.Name = "btLagre";
            this.btLagre.Size = new System.Drawing.Size(100, 37);
            this.btLagre.TabIndex = 12;
            this.btLagre.Text = "Lagre";
            this.btLagre.UseVisualStyleBackColor = true;
            this.btLagre.Click += new System.EventHandler(this.btLagre_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mobilnummer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Etternavn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fornavn:";
            // 
            // tbNyMnum
            // 
            this.tbNyMnum.Location = new System.Drawing.Point(155, 87);
            this.tbNyMnum.Name = "tbNyMnum";
            this.tbNyMnum.Size = new System.Drawing.Size(150, 29);
            this.tbNyMnum.TabIndex = 8;
            // 
            // tbNyEnavn
            // 
            this.tbNyEnavn.Location = new System.Drawing.Point(155, 52);
            this.tbNyEnavn.Name = "tbNyEnavn";
            this.tbNyEnavn.Size = new System.Drawing.Size(150, 29);
            this.tbNyEnavn.TabIndex = 7;
            // 
            // tbNyFnavn
            // 
            this.tbNyFnavn.Location = new System.Drawing.Point(153, 17);
            this.tbNyFnavn.Name = "tbNyFnavn";
            this.tbNyFnavn.Size = new System.Drawing.Size(152, 29);
            this.tbNyFnavn.TabIndex = 6;
            // 
            // pVisning
            // 
            this.pVisning.Controls.Add(this.label1);
            this.pVisning.Controls.Add(this.tbFnavn);
            this.pVisning.Controls.Add(this.btNeste);
            this.pVisning.Controls.Add(this.tbEnavn);
            this.pVisning.Controls.Add(this.btForrige);
            this.pVisning.Controls.Add(this.tbMnum);
            this.pVisning.Controls.Add(this.label3);
            this.pVisning.Controls.Add(this.label2);
            this.pVisning.Location = new System.Drawing.Point(37, 47);
            this.pVisning.Name = "pVisning";
            this.pVisning.Size = new System.Drawing.Size(361, 173);
            this.pVisning.TabIndex = 10;
            // 
            // pLoggOn
            // 
            this.pLoggOn.Controls.Add(this.btLoggInn);
            this.pLoggOn.Controls.Add(this.tbPassord);
            this.pLoggOn.Controls.Add(this.lPassord);
            this.pLoggOn.Location = new System.Drawing.Point(80, 290);
            this.pLoggOn.Name = "pLoggOn";
            this.pLoggOn.Size = new System.Drawing.Size(288, 150);
            this.pLoggOn.TabIndex = 11;
            // 
            // btLoggInn
            // 
            this.btLoggInn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoggInn.Location = new System.Drawing.Point(38, 84);
            this.btLoggInn.Name = "btLoggInn";
            this.btLoggInn.Size = new System.Drawing.Size(170, 41);
            this.btLoggInn.TabIndex = 14;
            this.btLoggInn.Text = "Logg inn!";
            this.btLoggInn.UseVisualStyleBackColor = true;
            this.btLoggInn.Click += new System.EventHandler(this.btLoggInn_Click);
            // 
            // tbPassord
            // 
            this.tbPassord.Location = new System.Drawing.Point(37, 58);
            this.tbPassord.Name = "tbPassord";
            this.tbPassord.PasswordChar = '*';
            this.tbPassord.Size = new System.Drawing.Size(171, 20);
            this.tbPassord.TabIndex = 13;
            // 
            // lPassord
            // 
            this.lPassord.AutoSize = true;
            this.lPassord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPassord.Location = new System.Drawing.Point(33, 30);
            this.lPassord.Name = "lPassord";
            this.lPassord.Size = new System.Drawing.Size(219, 25);
            this.lPassord.TabIndex = 12;
            this.lPassord.Text = "Skriv inn ditt passord:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 264);
            this.Controls.Add(this.pLoggOn);
            this.Controls.Add(this.pNyOppf);
            this.Controls.Add(this.pVisning);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Adresseliste";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pNyOppf.ResumeLayout(false);
            this.pNyOppf.PerformLayout();
            this.pVisning.ResumeLayout(false);
            this.pVisning.PerformLayout();
            this.pLoggOn.ResumeLayout(false);
            this.pLoggOn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFnavn;
        private System.Windows.Forms.TextBox tbEnavn;
        private System.Windows.Forms.TextBox tbMnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nyOppføringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slettOppføringToolStripMenuItem;
        private System.Windows.Forms.Button btForrige;
        private System.Windows.Forms.Button btNeste;
        private System.Windows.Forms.Panel pNyOppf;
        private System.Windows.Forms.Button btLagre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNyMnum;
        private System.Windows.Forms.TextBox tbNyEnavn;
        private System.Windows.Forms.TextBox tbNyFnavn;
        private System.Windows.Forms.Panel pVisning;
        private System.Windows.Forms.Panel pLoggOn;
        private System.Windows.Forms.TextBox tbPassord;
        private System.Windows.Forms.Label lPassord;
        private System.Windows.Forms.Button btLoggInn;
    }
}

