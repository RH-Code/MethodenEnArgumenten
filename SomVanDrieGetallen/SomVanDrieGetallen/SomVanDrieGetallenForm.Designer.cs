namespace SomVanDrieGetallen
{
    partial class SomVanDrieGetallenForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtGetal1 = new System.Windows.Forms.TextBox();
            this.txtGetal3 = new System.Windows.Forms.TextBox();
            this.txtGetal2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSom = new System.Windows.Forms.Label();
            this.btnMaakSom = new System.Windows.Forms.Button();
            this.btnWissen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Getal 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Getal 3:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Getal 2:";
            // 
            // txtGetal1
            // 
            this.txtGetal1.Location = new System.Drawing.Point(91, 20);
            this.txtGetal1.Name = "txtGetal1";
            this.txtGetal1.Size = new System.Drawing.Size(100, 20);
            this.txtGetal1.TabIndex = 0;
            this.txtGetal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGetal3
            // 
            this.txtGetal3.Location = new System.Drawing.Point(91, 107);
            this.txtGetal3.Name = "txtGetal3";
            this.txtGetal3.Size = new System.Drawing.Size(100, 20);
            this.txtGetal3.TabIndex = 2;
            this.txtGetal3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGetal2
            // 
            this.txtGetal2.Location = new System.Drawing.Point(91, 62);
            this.txtGetal2.Name = "txtGetal2";
            this.txtGetal2.Size = new System.Drawing.Size(100, 20);
            this.txtGetal2.TabIndex = 1;
            this.txtGetal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Som:";
            // 
            // lblSom
            // 
            this.lblSom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblSom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSom.Location = new System.Drawing.Point(91, 163);
            this.lblSom.Name = "lblSom";
            this.lblSom.Size = new System.Drawing.Size(100, 23);
            this.lblSom.TabIndex = 7;
            this.lblSom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnMaakSom
            // 
            this.btnMaakSom.Location = new System.Drawing.Point(22, 210);
            this.btnMaakSom.Name = "btnMaakSom";
            this.btnMaakSom.Size = new System.Drawing.Size(169, 30);
            this.btnMaakSom.TabIndex = 3;
            this.btnMaakSom.Text = "Maak som";
            this.btnMaakSom.UseVisualStyleBackColor = true;
            this.btnMaakSom.Click += new System.EventHandler(this.btnMaakSom_Click);
            // 
            // btnWissen
            // 
            this.btnWissen.Location = new System.Drawing.Point(22, 258);
            this.btnWissen.Name = "btnWissen";
            this.btnWissen.Size = new System.Drawing.Size(169, 30);
            this.btnWissen.TabIndex = 8;
            this.btnWissen.Text = "Wissen";
            this.btnWissen.UseVisualStyleBackColor = true;
            this.btnWissen.Click += new System.EventHandler(this.btnWissen_Click);
            // 
            // SomVanDrieGetallenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 307);
            this.Controls.Add(this.btnWissen);
            this.Controls.Add(this.btnMaakSom);
            this.Controls.Add(this.lblSom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGetal2);
            this.Controls.Add(this.txtGetal3);
            this.Controls.Add(this.txtGetal1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SomVanDrieGetallenForm";
            this.Text = "Som van drie gehele getallen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGetal1;
        private System.Windows.Forms.TextBox txtGetal3;
        private System.Windows.Forms.TextBox txtGetal2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSom;
        private System.Windows.Forms.Button btnMaakSom;
        private System.Windows.Forms.Button btnWissen;
    }
}

