namespace finalProject
{
    partial class register
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnRegister = new Button();
            label3 = new Label();
            lnkLogin = new LinkLabel();
            cboxShowPassword = new CheckBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Cursor = Cursors.IBeam;
            txtUserName.Font = new Font("Consolas", 14F);
            txtUserName.Location = new Point(45, 64);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Username";
            txtUserName.Size = new Size(357, 35);
            txtUserName.TabIndex = 0;
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
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 35);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 120);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(2, 123, 236);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(147, 211);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(142, 47);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(48, 269);
            label3.Name = "label3";
            label3.Size = new Size(244, 25);
            label3.TabIndex = 5;
            label3.Text = "Already have an account? ";
            // 
            // lnkLogin
            // 
            lnkLogin.AutoSize = true;
            lnkLogin.Cursor = Cursors.Hand;
            lnkLogin.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkLogin.Location = new Point(279, 269);
            lnkLogin.Name = "lnkLogin";
            lnkLogin.Size = new Size(113, 25);
            lnkLogin.TabIndex = 6;
            lnkLogin.TabStop = true;
            lnkLogin.Text = "Login Here!";
            lnkLogin.LinkClicked += lnkLogin_LinkClicked;
            // 
            // cboxShowPassword
            // 
            cboxShowPassword.AutoSize = true;
            cboxShowPassword.Cursor = Cursors.Hand;
            cboxShowPassword.Location = new Point(760, 296);
            cboxShowPassword.Name = "cboxShowPassword";
            cboxShowPassword.Size = new Size(18, 17);
            cboxShowPassword.TabIndex = 7;
            cboxShowPassword.UseVisualStyleBackColor = true;
            cboxShowPassword.CheckedChanged += cboxShowPassword_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.BurlyWood;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(827, 592);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtUserName);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnRegister);
            panel2.Controls.Add(lnkLogin);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(374, 120);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(435, 353);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
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
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 624);
            Controls.Add(cboxShowPassword);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += register_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Button btnRegister;
        private Label label3;
        private LinkLabel lnkLogin;
        private CheckBox cboxShowPassword;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
    }
}
