namespace tastatur_kalkulator
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
            this.btSlettTB = new System.Windows.Forms.Button();
            this.btKomma = new System.Windows.Forms.Button();
            this.btDele = new System.Windows.Forms.Button();
            this.btSlett = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btPluss = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.btGange = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.btErlik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSlettTB
            // 
            this.btSlettTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSlettTB.Location = new System.Drawing.Point(122, 64);
            this.btSlettTB.Name = "btSlettTB";
            this.btSlettTB.Size = new System.Drawing.Size(116, 50);
            this.btSlettTB.TabIndex = 59;
            this.btSlettTB.Text = "←";
            this.btSlettTB.UseVisualStyleBackColor = true;
            this.btSlettTB.Click += new System.EventHandler(this.bt_Click);
            // 
            // btKomma
            // 
            this.btKomma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKomma.Location = new System.Drawing.Point(122, 288);
            this.btKomma.Name = "btKomma";
            this.btKomma.Size = new System.Drawing.Size(50, 50);
            this.btKomma.TabIndex = 58;
            this.btKomma.Text = ",";
            this.btKomma.UseVisualStyleBackColor = true;
            this.btKomma.Click += new System.EventHandler(this.bt_Click);
            // 
            // btDele
            // 
            this.btDele.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDele.Location = new System.Drawing.Point(188, 120);
            this.btDele.Name = "btDele";
            this.btDele.Size = new System.Drawing.Size(50, 50);
            this.btDele.TabIndex = 57;
            this.btDele.Text = "/";
            this.btDele.UseVisualStyleBackColor = true;
            this.btDele.Click += new System.EventHandler(this.bt_Click);
            // 
            // btSlett
            // 
            this.btSlett.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSlett.Location = new System.Drawing.Point(10, 64);
            this.btSlett.Name = "btSlett";
            this.btSlett.Size = new System.Drawing.Size(106, 50);
            this.btSlett.TabIndex = 56;
            this.btSlett.Text = "C";
            this.btSlett.UseVisualStyleBackColor = true;
            this.btSlett.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt0
            // 
            this.bt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt0.Location = new System.Drawing.Point(10, 288);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(50, 50);
            this.bt0.TabIndex = 55;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt_Click);
            // 
            // btPluss
            // 
            this.btPluss.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPluss.Location = new System.Drawing.Point(188, 288);
            this.btPluss.Name = "btPluss";
            this.btPluss.Size = new System.Drawing.Size(50, 50);
            this.btPluss.TabIndex = 54;
            this.btPluss.Text = "+";
            this.btPluss.UseVisualStyleBackColor = true;
            this.btPluss.Click += new System.EventHandler(this.bt_Click);
            // 
            // btMinus
            // 
            this.btMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMinus.Location = new System.Drawing.Point(188, 232);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(50, 50);
            this.btMinus.TabIndex = 53;
            this.btMinus.Text = "-";
            this.btMinus.UseVisualStyleBackColor = true;
            this.btMinus.Click += new System.EventHandler(this.bt_Click);
            // 
            // btGange
            // 
            this.btGange.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGange.Location = new System.Drawing.Point(188, 176);
            this.btGange.Name = "btGange";
            this.btGange.Size = new System.Drawing.Size(50, 50);
            this.btGange.TabIndex = 52;
            this.btGange.Text = "*";
            this.btGange.UseVisualStyleBackColor = true;
            this.btGange.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt7
            // 
            this.bt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.Location = new System.Drawing.Point(10, 120);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(50, 50);
            this.bt7.TabIndex = 51;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt3
            // 
            this.bt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.Location = new System.Drawing.Point(122, 232);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(50, 50);
            this.bt3.TabIndex = 50;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt9
            // 
            this.bt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.Location = new System.Drawing.Point(122, 120);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(50, 50);
            this.bt9.TabIndex = 49;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt8
            // 
            this.bt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.Location = new System.Drawing.Point(66, 120);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(50, 50);
            this.bt8.TabIndex = 48;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt6
            // 
            this.bt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.Location = new System.Drawing.Point(122, 176);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(50, 50);
            this.bt6.TabIndex = 47;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt5
            // 
            this.bt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.Location = new System.Drawing.Point(66, 176);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(50, 50);
            this.bt5.TabIndex = 46;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt4
            // 
            this.bt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.Location = new System.Drawing.Point(10, 176);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(50, 50);
            this.bt4.TabIndex = 45;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt_Click);
            // 
            // display
            // 
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(10, 14);
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.Size = new System.Drawing.Size(228, 31);
            this.display.TabIndex = 44;
            this.display.Text = "0";
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(10, 232);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(50, 50);
            this.bt1.TabIndex = 43;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt2
            // 
            this.bt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.Location = new System.Drawing.Point(66, 232);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(50, 50);
            this.bt2.TabIndex = 42;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt_Click);
            // 
            // btErlik
            // 
            this.btErlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btErlik.Location = new System.Drawing.Point(66, 288);
            this.btErlik.Name = "btErlik";
            this.btErlik.Size = new System.Drawing.Size(50, 50);
            this.btErlik.TabIndex = 41;
            this.btErlik.Text = "=";
            this.btErlik.UseVisualStyleBackColor = true;
            this.btErlik.Click += new System.EventHandler(this.bt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 360);
            this.Controls.Add(this.btSlettTB);
            this.Controls.Add(this.btKomma);
            this.Controls.Add(this.btDele);
            this.Controls.Add(this.btSlett);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.btPluss);
            this.Controls.Add(this.btMinus);
            this.Controls.Add(this.btGange);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.display);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.btErlik);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSlettTB;
        private System.Windows.Forms.Button btKomma;
        private System.Windows.Forms.Button btDele;
        private System.Windows.Forms.Button btSlett;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btPluss;
        private System.Windows.Forms.Button btMinus;
        private System.Windows.Forms.Button btGange;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button btErlik;
    }
}

