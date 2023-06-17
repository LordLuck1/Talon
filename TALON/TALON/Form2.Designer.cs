namespace TALON
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Password = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Users = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(440, 199);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(167, 22);
            this.Password.TabIndex = 6;
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(440, 143);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(167, 22);
            this.Login.TabIndex = 5;
            this.Login.Enter += new System.EventHandler(this.Login_Enter);
            this.Login.Leave += new System.EventHandler(this.Login_Leave);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(462, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Продолжить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // Users
            // 
            this.Users.Location = new System.Drawing.Point(440, 87);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(167, 22);
            this.Users.TabIndex = 7;
            this.Users.Enter += new System.EventHandler(this.Users_Enter);
            this.Users.Leave += new System.EventHandler(this.Users_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(102, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TALON.Properties.Resources._1614564388_90_p_fon_dlya_fotoshopa_odnotonnii_belii_100_scaled;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Регистрация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Users;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}