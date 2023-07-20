namespace Pro
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.IDtextbox = new System.Windows.Forms.TextBox();
            this.Passwordtextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LoginButtom = new System.Windows.Forms.Button();
            this.C_or_F = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IDtextbox
            // 
            this.IDtextbox.Location = new System.Drawing.Point(284, 182);
            this.IDtextbox.Name = "IDtextbox";
            this.IDtextbox.Size = new System.Drawing.Size(286, 20);
            this.IDtextbox.TabIndex = 0;
            // 
            // Passwordtextbox
            // 
            this.Passwordtextbox.Location = new System.Drawing.Point(284, 245);
            this.Passwordtextbox.Name = "Passwordtextbox";
            this.Passwordtextbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Passwordtextbox.Size = new System.Drawing.Size(286, 20);
            this.Passwordtextbox.TabIndex = 1;
            this.Passwordtextbox.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginButtom
            // 
            this.LoginButtom.Location = new System.Drawing.Point(393, 309);
            this.LoginButtom.Name = "LoginButtom";
            this.LoginButtom.Size = new System.Drawing.Size(75, 23);
            this.LoginButtom.TabIndex = 5;
            this.LoginButtom.Text = "Login";
            this.LoginButtom.UseVisualStyleBackColor = true;
            this.LoginButtom.Click += new System.EventHandler(this.LoginButtom_Click);
            // 
            // C_or_F
            // 
            this.C_or_F.AutoSize = true;
            this.C_or_F.ForeColor = System.Drawing.Color.Red;
            this.C_or_F.Location = new System.Drawing.Point(374, 245);
            this.C_or_F.Name = "C_or_F";
            this.C_or_F.Size = new System.Drawing.Size(0, 13);
            this.C_or_F.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.C_or_F);
            this.Controls.Add(this.LoginButtom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Passwordtextbox);
            this.Controls.Add(this.IDtextbox);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDtextbox;
        private System.Windows.Forms.TextBox Passwordtextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button LoginButtom;
        private System.Windows.Forms.Label C_or_F;
    }
}