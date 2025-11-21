namespace finalProject
{
    partial class DashboardForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            label1 = new Label();
            lblUserName = new Label();
            progressBar = new ProgressBar();
            btnProjectName = new Button();
            btnCreateProject = new Button();
            lblDateStart = new Label();
            label2 = new Label();
            label3 = new Label();
            lblDueDate = new Label();
            tipProgress = new ToolTip(components);
            panel1 = new Panel();
            label4 = new Label();
            lblProgress = new Label();
            panel2 = new Panel();
            lnklblLogout = new LinkLabel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(15, 21);
            label1.Name = "label1";
            label1.Size = new Size(156, 31);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            label1.Click += label1_Click;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Bold);
            lblUserName.Location = new Point(736, 21);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(90, 31);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Name";
            lblUserName.Click += lblUserName_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(59, 84);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(753, 57);
            progressBar.TabIndex = 2;
            progressBar.Click += progressBar_Click;
            // 
            // btnProjectName
            // 
            btnProjectName.BackColor = Color.Gainsboro;
            btnProjectName.Cursor = Cursors.Hand;
            btnProjectName.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnProjectName.Location = new Point(59, 207);
            btnProjectName.Name = "btnProjectName";
            btnProjectName.Size = new Size(753, 216);
            btnProjectName.TabIndex = 4;
            btnProjectName.TextAlign = ContentAlignment.TopCenter;
            btnProjectName.UseVisualStyleBackColor = false;
            btnProjectName.Click += btnProjectName_Click;
            // 
            // btnCreateProject
            // 
            btnCreateProject.AutoSize = true;
            btnCreateProject.BackColor = Color.FromArgb(2, 123, 236);
            btnCreateProject.Cursor = Cursors.Hand;
            btnCreateProject.FlatStyle = FlatStyle.Flat;
            btnCreateProject.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateProject.ForeColor = Color.White;
            btnCreateProject.Location = new Point(323, 442);
            btnCreateProject.Name = "btnCreateProject";
            btnCreateProject.Size = new Size(270, 59);
            btnCreateProject.TabIndex = 5;
            btnCreateProject.Text = "Create Project";
            btnCreateProject.UseVisualStyleBackColor = false;
            btnCreateProject.Click += btnCreateProject_Click;
            // 
            // lblDateStart
            // 
            lblDateStart.AutoSize = true;
            lblDateStart.BackColor = Color.Gainsboro;
            lblDateStart.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateStart.Location = new Point(253, 297);
            lblDateStart.Name = "lblDateStart";
            lblDateStart.Size = new Size(112, 29);
            lblDateStart.TabIndex = 6;
            lblDateStart.Text = "StartDate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(103, 297);
            label2.Name = "label2";
            label2.Size = new Size(74, 29);
            label2.TabIndex = 7;
            label2.Text = "Start:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(493, 297);
            label3.Name = "label3";
            label3.Size = new Size(66, 29);
            label3.TabIndex = 8;
            label3.Text = "End:";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.BackColor = Color.Gainsboro;
            lblDueDate.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDueDate.Location = new Point(603, 297);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(107, 29);
            lblDueDate.TabIndex = 9;
            lblDueDate.Text = "DueDate";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(progressBar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblDueDate);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblDateStart);
            panel1.Controls.Add(btnCreateProject);
            panel1.Controls.Add(btnProjectName);
            panel1.Controls.Add(lblProgress);
            panel1.Location = new Point(-15, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(886, 557);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            label4.Location = new Point(59, 172);
            label4.Name = "label4";
            label4.Size = new Size(119, 32);
            label4.TabIndex = 10;
            label4.Text = "Recent:";
            label4.Click += label4_Click;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProgress.Location = new Point(766, 49);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(61, 29);
            lblProgress.TabIndex = 3;
            lblProgress.Text = "00%";
            lblProgress.Click += lblProgress_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.BurlyWood;
            panel2.Controls.Add(lnklblLogout);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblUserName);
            panel2.Location = new Point(-1, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(855, 73);
            panel2.TabIndex = 11;
            // 
            // lnklblLogout
            // 
            lnklblLogout.AutoSize = true;
            lnklblLogout.Location = new Point(750, 50);
            lnklblLogout.Name = "lnklblLogout";
            lnklblLogout.Size = new Size(62, 20);
            lnklblLogout.TabIndex = 2;
            lnklblLogout.TabStop = true;
            lnklblLogout.Text = "Log Out";
            lnklblLogout.LinkClicked += lnklblLogout_LinkClicked;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 624);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += DashboardForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lblUserName;
        private ProgressBar progressBar;
        private Button btnProjectName;
        private Button btnCreateProject;
        private Label lblDateStart;
        private Label label2;
        private Label label3;
        private Label lblDueDate;
        private ToolTip tipProgress;
        private Panel panel1;
        private Label lblProgress;
        private Panel panel2;
        private Label label4;
        private LinkLabel lnklblLogout;
    }
}