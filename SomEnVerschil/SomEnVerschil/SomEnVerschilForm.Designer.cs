namespace SomEnVerschil
{
    partial class SomEnVerschilForm
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
            this.txtGetal1 = new System.Windows.Forms.TextBox();
            this.txtGetal2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSom = new System.Windows.Forms.Label();
            this.lblVerschil = new System.Windows.Forms.Label();
            this.btnBereken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Getal 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Getal 2:";
            // 
            // txtGetal1
            // 
            this.txtGetal1.Location = new System.Drawing.Point(101, 26);
            this.txtGetal1.Name = "txtGetal1";
            this.txtGetal1.Size = new System.Drawing.Size(100, 20);
            this.txtGetal1.TabIndex = 2;
            this.txtGetal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGetal2
            // 
            this.txtGetal2.Location = new System.Drawing.Point(101, 71);
            this.txtGetal2.Name = "txtGetal2";
            this.txtGetal2.Size = new System.Drawing.Size(100, 20);
            this.txtGetal2.TabIndex = 3;
            this.txtGetal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Som:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Verschil:";
            // 
            // lblSom
            // 
            this.lblSom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSom.Location = new System.Drawing.Point(101, 152);
            this.lblSom.Name = "lblSom";
            this.lblSom.Size = new System.Drawing.Size(100, 20);
            this.lblSom.TabIndex = 6;
            this.lblSom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVerschil
            // 
            this.lblVerschil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVerschil.Location = new System.Drawing.Point(101, 191);
            this.lblVerschil.Name = "lblVerschil";
            this.lblVerschil.Size = new System.Drawing.Size(100, 20);
            this.lblVerschil.TabIndex = 7;
            this.lblVerschil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(26, 110);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(175, 23);
            this.btnBereken.TabIndex = 8;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // SomEnVerschilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 232);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.lblVerschil);
            this.Controls.Add(this.lblSom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGetal2);
            this.Controls.Add(this.txtGetal1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SomEnVerschilForm";
            this.Text = "Bereken de som en het verschil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGetal1;
        private System.Windows.Forms.TextBox txtGetal2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSom;
        private System.Windows.Forms.Label lblVerschil;
        private System.Windows.Forms.Button btnBereken;
    }
}

