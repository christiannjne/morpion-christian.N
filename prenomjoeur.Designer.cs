namespace morpion_christian.N
{
    partial class prenomjoeur
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbx_prenomx = new System.Windows.Forms.TextBox();
            this.tbx_prenom0 = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "prenom joeur x";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(89, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "prenom joueur 0";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tbx_prenomx
            // 
            this.tbx_prenomx.Location = new System.Drawing.Point(264, 34);
            this.tbx_prenomx.Name = "tbx_prenomx";
            this.tbx_prenomx.Size = new System.Drawing.Size(184, 26);
            this.tbx_prenomx.TabIndex = 2;
            // 
            // tbx_prenom0
            // 
            this.tbx_prenom0.Location = new System.Drawing.Point(264, 114);
            this.tbx_prenom0.Name = "tbx_prenom0";
            this.tbx_prenom0.Size = new System.Drawing.Size(184, 26);
            this.tbx_prenom0.TabIndex = 3;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(528, 51);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(147, 71);
            this.btn_ok.TabIndex = 5;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // prenomjoeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 179);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tbx_prenom0);
            this.Controls.Add(this.tbx_prenomx);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "prenomjoeur";
            this.Text = "prenomjoeur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbx_prenomx;
        private System.Windows.Forms.TextBox tbx_prenom0;
        private System.Windows.Forms.Button btn_ok;
    }
}