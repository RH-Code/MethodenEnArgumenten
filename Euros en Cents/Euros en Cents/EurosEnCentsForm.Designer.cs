namespace Euros_en_Cents
{
    partial class EurosEnCentsForm
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
            this.txtEurocenten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEuros = new System.Windows.Forms.Label();
            this.lblCenten = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBereken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoer eurocenten:";
            // 
            // txtEurocenten
            // 
            this.txtEurocenten.Location = new System.Drawing.Point(118, 17);
            this.txtEurocenten.Name = "txtEurocenten";
            this.txtEurocenten.Size = new System.Drawing.Size(100, 20);
            this.txtEurocenten.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEuros
            // 
            this.lblEuros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEuros.Location = new System.Drawing.Point(297, 17);
            this.lblEuros.Name = "lblEuros";
            this.lblEuros.Size = new System.Drawing.Size(100, 20);
            this.lblEuros.TabIndex = 3;
            this.lblEuros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCenten
            // 
            this.lblCenten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCenten.Location = new System.Drawing.Point(424, 16);
            this.lblCenten.Name = "lblCenten";
            this.lblCenten.Size = new System.Drawing.Size(100, 20);
            this.lblCenten.TabIndex = 4;
            this.lblCenten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Euros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Centen";
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(118, 90);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(100, 23);
            this.btnBereken.TabIndex = 7;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // EurosEnCentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 129);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCenten);
            this.Controls.Add(this.lblEuros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEurocenten);
            this.Controls.Add(this.label1);
            this.Name = "EurosEnCentsForm";
            this.Text = "Euros en centen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEurocenten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEuros;
        private System.Windows.Forms.Label lblCenten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBereken;
    }
}

