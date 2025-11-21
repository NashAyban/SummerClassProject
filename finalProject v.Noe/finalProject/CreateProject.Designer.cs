namespace finalProject
{
    partial class CreateProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateProjectForm));
            txtProjectName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCreate = new Button();
            btnCancel = new Button();
            lnkStartDate = new LinkLabel();
            lnkDueDate = new LinkLabel();
            btnSelectDate = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtProjectName
            // 
            txtProjectName.Cursor = Cursors.IBeam;
            txtProjectName.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProjectName.Location = new Point(238, 96);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Size = new Size(486, 34);
            txtProjectName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 96);
            label1.Name = "label1";
            label1.Size = new Size(179, 29);
            label1.TabIndex = 1;
            label1.Text = "Project Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(91, 179);
            label2.Name = "label2";
            label2.Size = new Size(135, 29);
            label2.TabIndex = 2;
            label2.Text = "Start Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(91, 223);
            label3.Name = "label3";
            label3.Size = new Size(127, 29);
            label3.TabIndex = 3;
            label3.Text = "End Date:";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(2, 123, 236);
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(416, 335);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(139, 45);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Silver;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(237, 335);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(139, 45);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lnkStartDate
            // 
            lnkStartDate.AutoSize = true;
            lnkStartDate.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkStartDate.Location = new Point(238, 179);
            lnkStartDate.Name = "lnkStartDate";
            lnkStartDate.Size = new Size(175, 29);
            lnkStartDate.TabIndex = 8;
            lnkStartDate.TabStop = true;
            lnkStartDate.Text = "MM/DD/YYYY";
            lnkStartDate.LinkClicked += lnkStartDate_LinkClicked;
            // 
            // lnkDueDate
            // 
            lnkDueDate.AutoSize = true;
            lnkDueDate.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkDueDate.Location = new Point(238, 223);
            lnkDueDate.Name = "lnkDueDate";
            lnkDueDate.Size = new Size(175, 29);
            lnkDueDate.TabIndex = 9;
            lnkDueDate.TabStop = true;
            lnkDueDate.Text = "MM/DD/YYYY";
            // 
            // btnSelectDate
            // 
            btnSelectDate.BackColor = Color.FromArgb(2, 123, 236);
            btnSelectDate.Cursor = Cursors.Hand;
            btnSelectDate.FlatStyle = FlatStyle.Flat;
            btnSelectDate.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelectDate.ForeColor = Color.White;
            btnSelectDate.Location = new Point(238, 268);
            btnSelectDate.Name = "btnSelectDate";
            btnSelectDate.Size = new Size(190, 44);
            btnSelectDate.TabIndex = 10;
            btnSelectDate.Text = "Select Date";
            btnSelectDate.UseVisualStyleBackColor = false;
            btnSelectDate.Click += btnSelectDate_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(lnkDueDate);
            panel1.Controls.Add(btnCreate);
            panel1.Controls.Add(btnSelectDate);
            panel1.Controls.Add(txtProjectName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lnkStartDate);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-1, 80);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(865, 545);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.BurlyWood;
            panel2.Controls.Add(label4);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(855, 72);
            panel2.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(14, 21);
            label4.Name = "label4";
            label4.Size = new Size(172, 31);
            label4.TabIndex = 0;
            label4.Text = "New Project";
            // 
            // CreateProjectForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 624);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CreateProjectForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Project";
            Load += CreateProjectForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtProjectName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCreate;
        private Button btnCancel;
        private LinkLabel lnkStartDate;
        private LinkLabel lnkDueDate;
        private Button btnSelectDate;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
    }
}