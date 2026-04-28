namespace Samostalni_projekat_2026_Andrej_Radunovic
{
    partial class PostControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNaslov = new System.Windows.Forms.Label();
            this.imeLabel = new System.Windows.Forms.Label();
            this.labelGlasovi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNaslov
            // 
            this.labelNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNaslov.Location = new System.Drawing.Point(3, 0);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(360, 50);
            this.labelNaslov.TabIndex = 0;
            this.labelNaslov.Text = "Placeholder";
            // 
            // imeLabel
            // 
            this.imeLabel.AutoSize = true;
            this.imeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imeLabel.Location = new System.Drawing.Point(369, 3);
            this.imeLabel.Name = "imeLabel";
            this.imeLabel.Size = new System.Drawing.Size(102, 16);
            this.imeLabel.TabIndex = 1;
            this.imeLabel.Text = "By: Placeholder";
            // 
            // labelGlasovi
            // 
            this.labelGlasovi.AutoSize = true;
            this.labelGlasovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGlasovi.Location = new System.Drawing.Point(369, 34);
            this.labelGlasovi.Name = "labelGlasovi";
            this.labelGlasovi.Size = new System.Drawing.Size(132, 16);
            this.labelGlasovi.TabIndex = 2;
            this.labelGlasovi.Text = "Glasovi: Placeholder";
            // 
            // PostControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.labelGlasovi);
            this.Controls.Add(this.imeLabel);
            this.Controls.Add(this.labelNaslov);
            this.Name = "PostControl";
            this.Size = new System.Drawing.Size(500, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNaslov;
        private System.Windows.Forms.Label imeLabel;
        private System.Windows.Forms.Label labelGlasovi;
    }
}
