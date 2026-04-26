namespace Samostalni_projekat_2026_Andrej_Radunovic
{
    partial class Objava
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
            this.TextboxNaslov = new System.Windows.Forms.TextBox();
            this.TextboxTekst = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OdgovorLabel = new System.Windows.Forms.Label();
            this.buttonObjavi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboKategorija = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelOdgovor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextboxNaslov
            // 
            this.TextboxNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxNaslov.Location = new System.Drawing.Point(131, 87);
            this.TextboxNaslov.Name = "TextboxNaslov";
            this.TextboxNaslov.Size = new System.Drawing.Size(418, 38);
            this.TextboxNaslov.TabIndex = 0;
            // 
            // TextboxTekst
            // 
            this.TextboxTekst.Location = new System.Drawing.Point(131, 146);
            this.TextboxTekst.Name = "TextboxTekst";
            this.TextboxTekst.Size = new System.Drawing.Size(418, 238);
            this.TextboxTekst.TabIndex = 1;
            this.TextboxTekst.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naslov:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tekst:";
            // 
            // OdgovorLabel
            // 
            this.OdgovorLabel.AutoSize = true;
            this.OdgovorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OdgovorLabel.Location = new System.Drawing.Point(0, 430);
            this.OdgovorLabel.Name = "OdgovorLabel";
            this.OdgovorLabel.Size = new System.Drawing.Size(125, 29);
            this.OdgovorLabel.TabIndex = 4;
            this.OdgovorLabel.Text = "Odgovara:";
            // 
            // buttonObjavi
            // 
            this.buttonObjavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObjavi.Location = new System.Drawing.Point(353, 401);
            this.buttonObjavi.Name = "buttonObjavi";
            this.buttonObjavi.Size = new System.Drawing.Size(196, 52);
            this.buttonObjavi.TabIndex = 5;
            this.buttonObjavi.Text = "Napravi objavu";
            this.buttonObjavi.UseVisualStyleBackColor = true;
            this.buttonObjavi.Click += new System.EventHandler(this.buttonObjavi_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-12, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(599, 69);
            this.label3.TabIndex = 6;
            this.label3.Text = "POSTAVLJANJE OBJAVE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboKategorija
            // 
            this.ComboKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboKategorija.FormattingEnabled = true;
            this.ComboKategorija.Location = new System.Drawing.Point(131, 401);
            this.ComboKategorija.Name = "ComboKategorija";
            this.ComboKategorija.Size = new System.Drawing.Size(216, 28);
            this.ComboKategorija.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-4, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kategorija:";
            // 
            // LabelOdgovor
            // 
            this.LabelOdgovor.AutoSize = true;
            this.LabelOdgovor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOdgovor.Location = new System.Drawing.Point(131, 432);
            this.LabelOdgovor.Name = "LabelOdgovor";
            this.LabelOdgovor.Size = new System.Drawing.Size(94, 29);
            this.LabelOdgovor.TabIndex = 9;
            this.LabelOdgovor.Text = "IdPosta";
            // 
            // Objava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(575, 463);
            this.Controls.Add(this.LabelOdgovor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboKategorija);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonObjavi);
            this.Controls.Add(this.OdgovorLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextboxTekst);
            this.Controls.Add(this.TextboxNaslov);
            this.Name = "Objava";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextboxNaslov;
        private System.Windows.Forms.RichTextBox TextboxTekst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label OdgovorLabel;
        private System.Windows.Forms.Button buttonObjavi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboKategorija;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelOdgovor;
    }
}