
namespace EsiniBul
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
            this.pnlButonlar = new System.Windows.Forms.Panel();
            this.BtnTekrarOyna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlButonlar
            // 
            this.pnlButonlar.Location = new System.Drawing.Point(12, 12);
            this.pnlButonlar.Name = "pnlButonlar";
            this.pnlButonlar.Size = new System.Drawing.Size(240, 240);
            this.pnlButonlar.TabIndex = 0;
            // 
            // BtnTekrarOyna
            // 
            this.BtnTekrarOyna.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTekrarOyna.Location = new System.Drawing.Point(59, 79);
            this.BtnTekrarOyna.Name = "BtnTekrarOyna";
            this.BtnTekrarOyna.Size = new System.Drawing.Size(124, 73);
            this.BtnTekrarOyna.TabIndex = 1;
            this.BtnTekrarOyna.Text = "Tekrar Oyna";
            this.BtnTekrarOyna.UseVisualStyleBackColor = true;
            this.BtnTekrarOyna.Visible = false;
            this.BtnTekrarOyna.Click += new System.EventHandler(this.BtnTekrarOyna_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 261);
            this.Controls.Add(this.BtnTekrarOyna);
            this.Controls.Add(this.pnlButonlar);
            this.Location = new System.Drawing.Point(600, 1000);
            this.Name = "Form1";
            this.Text = "Esini Bul";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButonlar;
        private System.Windows.Forms.Button BtnTekrarOyna;
    }
}

