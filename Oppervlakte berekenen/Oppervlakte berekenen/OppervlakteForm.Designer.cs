namespace Oppervlakte_berekenen
{
    partial class OppervlakteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBreedte = new System.Windows.Forms.TextBox();
            this.txtHoogte = new System.Windows.Forms.TextBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Breedte (cm):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lengte (cm):";
            // 
            // txtBreedte
            // 
            this.txtBreedte.Location = new System.Drawing.Point(90, 19);
            this.txtBreedte.Name = "txtBreedte";
            this.txtBreedte.Size = new System.Drawing.Size(100, 20);
            this.txtBreedte.TabIndex = 2;
            this.txtBreedte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHoogte
            // 
            this.txtHoogte.Location = new System.Drawing.Point(90, 56);
            this.txtHoogte.Name = "txtHoogte";
            this.txtHoogte.Size = new System.Drawing.Size(100, 20);
            this.txtHoogte.TabIndex = 3;
            this.txtHoogte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(23, 99);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(167, 24);
            this.btnBereken.TabIndex = 4;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // OppervlakteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 142);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txtHoogte);
            this.Controls.Add(this.txtBreedte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OppervlakteForm";
            this.Text = "Bereken de oppervlakte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBreedte;
        private System.Windows.Forms.TextBox txtHoogte;
        private System.Windows.Forms.Button btnBereken;
    }
}

