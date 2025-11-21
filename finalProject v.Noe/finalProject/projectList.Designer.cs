namespace finalProject
{
    partial class projectList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(projectList));
            btnAdd = new Button();
            dgvProjectList = new DataGridView();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProjectList).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(2, 123, 236);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(477, 524);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(171, 47);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add Task";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvProjectList
            // 
            dgvProjectList.BackgroundColor = Color.LightGray;
            dgvProjectList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProjectList.Location = new Point(40, 129);
            dgvProjectList.Name = "dgvProjectList";
            dgvProjectList.ReadOnly = true;
            dgvProjectList.RowHeadersWidth = 51;
            dgvProjectList.Size = new Size(789, 379);
            dgvProjectList.TabIndex = 5;
            dgvProjectList.CellContentClick += dgvProjectList_CellContentClick;
            dgvProjectList.SelectionChanged += dgvProjectList_SelectionChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(dgvProjectList);
            panel1.Location = new Point(-8, -3);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(866, 701);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(2, 123, 236);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(282, 524);
            button1.Name = "button1";
            button1.Size = new Size(171, 47);
            button1.TabIndex = 15;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.BurlyWood;
            panel2.Controls.Add(label4);
            panel2.Location = new Point(8, 3);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(855, 68);
            panel2.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(14, 19);
            label4.Name = "label4";
            label4.Size = new Size(161, 31);
            label4.TabIndex = 0;
            label4.Text = "Project List";
            // 
            // projectList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 624);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "projectList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "projectList";
            Load += projectList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProjectList).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAdd;
        private DataGridView dgvProjectList;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private Button button1;
    }
}