namespace Pro
{
    partial class L1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(L1));
            this.Member = new System.Windows.Forms.Button();
            this.Normal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Member
            // 
            this.Member.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Member.BackgroundImage")));
            this.Member.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Member.Location = new System.Drawing.Point(360, 160);
            this.Member.Name = "Member";
            this.Member.Size = new System.Drawing.Size(304, 286);
            this.Member.TabIndex = 1;
            this.Member.UseVisualStyleBackColor = true;
            this.Member.Click += new System.EventHandler(this.button1_Click);
            // 
            // Normal
            // 
            this.Normal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Normal.BackgroundImage")));
            this.Normal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Normal.Location = new System.Drawing.Point(807, 160);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(304, 286);
            this.Normal.TabIndex = 2;
            this.Normal.UseVisualStyleBackColor = true;
            this.Normal.Click += new System.EventHandler(this.button2_Click);
            // 
            // L1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1439, 661);
            this.Controls.Add(this.Normal);
            this.Controls.Add(this.Member);
            this.Name = "L1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Member;
        private System.Windows.Forms.Button Normal;
    }
}

