namespace Meters_en_centimeters
{
    partial class MetersEnCentimetersForm
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
            this.txtCentimeters = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAantalMeters = new System.Windows.Forms.Label();
            this.lblCentimeters = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBereken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aantal centimeters";
            // 
            // txtCentimeters
            // 
            this.txtCentimeters.Location = new System.Drawing.Point(118, 18);
            this.txtCentimeters.Name = "txtCentimeters";
            this.txtCentimeters.Size = new System.Drawing.Size(100, 20);
            this.txtCentimeters.TabIndex = 1;
            this.txtCentimeters.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAantalMeters
            // 
            this.lblAantalMeters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAantalMeters.Location = new System.Drawing.Point(278, 16);
            this.lblAantalMeters.Name = "lblAantalMeters";
            this.lblAantalMeters.Size = new System.Drawing.Size(100, 23);
            this.lblAantalMeters.TabIndex = 3;
            this.lblAantalMeters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCentimeters
            // 
            this.lblCentimeters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCentimeters.Location = new System.Drawing.Point(408, 16);
            this.lblCentimeters.Name = "lblCentimeters";
            this.lblCentimeters.Size = new System.Drawing.Size(100, 23);
            this.lblCentimeters.TabIndex = 4;
            this.lblCentimeters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Meters";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Centimeters";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(118, 73);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(100, 23);
            this.btnBereken.TabIndex = 7;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // MetersEnCentimetersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 113);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCentimeters);
            this.Controls.Add(this.lblAantalMeters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCentimeters);
            this.Controls.Add(this.label1);
            this.Name = "MetersEnCentimetersForm";
            this.Text = "Meters en centimeters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCentimeters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAantalMeters;
        private System.Windows.Forms.Label lblCentimeters;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBereken;
    }
}

