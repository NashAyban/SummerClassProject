namespace finalProject
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lnkRegiter = new LinkLabel();
            btnLogin = new Button();
            cboxShowPassword = new CheckBox();
            panel1 = new Panel();
            txtUserName = new TextBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("Consolas", 14F);
            txtPassword.Location = new Point(45, 149);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "********";
            txtPassword.Size = new Size(357, 35);
            txtPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(37, 35);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(37, 120);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(45, 271);
            label3.Name = "label3";
            label3.Size = new Size(217, 25);
            label3.TabIndex = 4;
            label3.Text = "Don't have an account?";
            // 
            // lnkRegiter
            // 
            lnkRegiter.AutoSize = true;
            lnkRegiter.Cursor = Cursors.Hand;
            lnkRegiter.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkRegiter.Location = new Point(250, 271);
            lnkRegiter.Name = "lnkRegiter";
            lnkRegiter.Size = new Size(135, 25);
            lnkRegiter.TabIndex = 5;
            lnkRegiter.TabStop = true;
            lnkRegiter.Text = "Sign Up Here!";
            lnkRegiter.LinkClicked += lnkRegiter_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(2, 123, 236);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(151, 211);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(142, 47);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // cboxShowPassword
            // 
            cboxShowPassword.AutoSize = true;
            cboxShowPassword.Cursor = Cursors.Hand;
            cboxShowPassword.Location = new Point(371, 159);
            cboxShowPassword.Name = "cboxShowPassword";
            cboxShowPassword.Size = new Size(18, 17);
            cboxShowPassword.TabIndex = 7;
            cboxShowPassword.TextAlign = ContentAlignment.MiddleCenter;
            cboxShowPassword.UseVisualStyleBackColor = true;
            cboxShowPassword.CheckedChanged += cboxShowPassword_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cboxShowPassword);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lnkRegiter);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(374, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(435, 353);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // txtUserName
            // 
            txtUserName.Cursor = Cursors.IBeam;
            txtUserName.Font = new Font("Consolas", 14F);
            txtUserName.Location = new Point(45, 64);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "username";
            txtUserName.Size = new Size(357, 35);
            txtUserName.TabIndex = 0;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.BurlyWood;
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(14, 16);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(827, 592);
            panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-78, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(546, 565);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(855, 624);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel lnkRegiter;
        private Button btnLogin;
        private CheckBox cboxShowPassword;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox txtUserName;
    }
}