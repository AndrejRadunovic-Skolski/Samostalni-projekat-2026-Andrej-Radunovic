namespace Samostalni_projekat_2026_Andrej_Radunovic
{
    partial class Admin
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
            this.textBoxKorisnik = new System.Windows.Forms.TextBox();
            this.buttonBrisanjeKorisnika = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxObjava = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxKategorija = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxKorisnik
            // 
            this.textBoxKorisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKorisnik.Location = new System.Drawing.Point(13, 3);
            this.textBoxKorisnik.Name = "textBoxKorisnik";
            this.textBoxKorisnik.Size = new System.Drawing.Size(172, 31);
            this.textBoxKorisnik.TabIndex = 0;
            // 
            // buttonBrisanjeKorisnika
            // 
            this.buttonBrisanjeKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrisanjeKorisnika.Location = new System.Drawing.Point(13, 52);
            this.buttonBrisanjeKorisnika.Name = "buttonBrisanjeKorisnika";
            this.buttonBrisanjeKorisnika.Size = new System.Drawing.Size(172, 45);
            this.buttonBrisanjeKorisnika.TabIndex = 1;
            this.buttonBrisanjeKorisnika.Text = "Brisi korisnika(ID)";
            this.buttonBrisanjeKorisnika.UseVisualStyleBackColor = true;
            this.buttonBrisanjeKorisnika.Click += new System.EventHandler(this.buttonBrisanjeKorisnika_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.textBoxKorisnik);
            this.panel1.Controls.Add(this.buttonBrisanjeKorisnika);
            this.panel1.Location = new System.Drawing.Point(12, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.textBoxObjava);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(237, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 3;
            // 
            // textBoxObjava
            // 
            this.textBoxObjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxObjava.Location = new System.Drawing.Point(13, 3);
            this.textBoxObjava.Name = "textBoxObjava";
            this.textBoxObjava.Size = new System.Drawing.Size(172, 31);
            this.textBoxObjava.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Brisi objavu (ID)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.textBoxKategorija);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(237, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 140);
            this.panel3.TabIndex = 3;
            // 
            // textBoxKategorija
            // 
            this.textBoxKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKategorija.Location = new System.Drawing.Point(13, 3);
            this.textBoxKategorija.Name = "textBoxKategorija";
            this.textBoxKategorija.Size = new System.Drawing.Size(172, 31);
            this.textBoxKategorija.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(13, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Dodaj kategoriju(ime)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(13, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "Brisi kategoriju(ime)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(11, 213);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(201, 49);
            this.button4.TabIndex = 26;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(449, 274);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Admin";
            this.Text = "t";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKorisnik;
        private System.Windows.Forms.Button buttonBrisanjeKorisnika;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxObjava;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxKategorija;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}