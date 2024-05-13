namespace _15_9_Inlogsysteem
{
    partial class inlogSysteem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inlogSysteem));
            this.btnInlog = new System.Windows.Forms.Button();
            this.gebruikersnaam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGebruikersnaam = new System.Windows.Forms.TextBox();
            this.txtWachtwoord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInlog
            // 
            this.btnInlog.Location = new System.Drawing.Point(231, 136);
            this.btnInlog.Margin = new System.Windows.Forms.Padding(2);
            this.btnInlog.Name = "btnInlog";
            this.btnInlog.Size = new System.Drawing.Size(107, 27);
            this.btnInlog.TabIndex = 0;
            this.btnInlog.Text = "inloggen";
            this.btnInlog.UseVisualStyleBackColor = true;
            this.btnInlog.Click += new System.EventHandler(this.btnInlog_Click);
            // 
            // gebruikersnaam
            // 
            this.gebruikersnaam.AutoSize = true;
            this.gebruikersnaam.BackColor = System.Drawing.Color.Transparent;
            this.gebruikersnaam.Location = new System.Drawing.Point(94, 56);
            this.gebruikersnaam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gebruikersnaam.Name = "gebruikersnaam";
            this.gebruikersnaam.Size = new System.Drawing.Size(110, 17);
            this.gebruikersnaam.TabIndex = 1;
            this.gebruikersnaam.Text = "gebruikersnaam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(94, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "wachtwoord";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtGebruikersnaam
            // 
            this.txtGebruikersnaam.Location = new System.Drawing.Point(231, 56);
            this.txtGebruikersnaam.Margin = new System.Windows.Forms.Padding(2);
            this.txtGebruikersnaam.Name = "txtGebruikersnaam";
            this.txtGebruikersnaam.Size = new System.Drawing.Size(107, 22);
            this.txtGebruikersnaam.TabIndex = 3;
            this.txtGebruikersnaam.TextChanged += new System.EventHandler(this.txtGebruikersnaam_TextChanged);
            // 
            // txtWachtwoord
            // 
            this.txtWachtwoord.BackColor = System.Drawing.Color.White;
            this.txtWachtwoord.Location = new System.Drawing.Point(231, 93);
            this.txtWachtwoord.Name = "txtWachtwoord";
            this.txtWachtwoord.PasswordChar = '●';
            this.txtWachtwoord.Size = new System.Drawing.Size(107, 22);
            this.txtWachtwoord.TabIndex = 4;
            // 
            // inlogSysteem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(430, 237);
            this.Controls.Add(this.txtWachtwoord);
            this.Controls.Add(this.btnInlog);
            this.Controls.Add(this.gebruikersnaam);
            this.Controls.Add(this.txtGebruikersnaam);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "inlogSysteem";
            this.Text = "Inlogsysteem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInlog;
        private System.Windows.Forms.Label gebruikersnaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGebruikersnaam;
        private System.Windows.Forms.TextBox txtWachtwoord;
    }
}

