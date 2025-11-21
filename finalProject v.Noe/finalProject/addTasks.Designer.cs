namespace finalProject
{
    partial class addTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addTasks));
            label1 = new Label();
            txtTasks = new TextBox();
            btnAdd = new Button();
            dgvTasks = new DataGridView();
            panel1 = new Panel();
            button2 = new Button();
            panel2 = new Panel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(56, 52);
            label1.Name = "label1";
            label1.Size = new Size(171, 31);
            label1.TabIndex = 0;
            label1.Text = "Task Name:";
            // 
            // txtTasks
            // 
            txtTasks.Cursor = Cursors.IBeam;
            txtTasks.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTasks.Location = new Point(233, 51);
            txtTasks.Name = "txtTasks";
            txtTasks.Size = new Size(436, 34);
            txtTasks.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(687, 49);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(69, 39);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.TextAlign = ContentAlignment.TopRight;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvTasks
            // 
            dgvTasks.BackgroundColor = SystemColors.ControlLight;
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Location = new Point(72, 123);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.ReadOnly = true;
            dgvTasks.RowHeadersWidth = 51;
            dgvTasks.Size = new Size(721, 361);
            dgvTasks.TabIndex = 3;
            dgvTasks.CellContentClick += dgvTasks_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(dgvTasks);
            panel1.Controls.Add(txtTasks);
            panel1.Location = new Point(-1, 76);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(855, 566);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(2, 123, 236);
            button2.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(371, 505);
            button2.Name = "button2";
            button2.Size = new Size(110, 49);
            button2.TabIndex = 4;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.BurlyWood;
            panel2.Controls.Add(label4);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(855, 68);
            panel2.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(14, 19);
            label4.Name = "label4";
            label4.Size = new Size(137, 31);
            label4.TabIndex = 0;
            label4.Text = "Add Task";
            // 
            // addTasks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 642);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "addTasks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addTasks";
            Load += addTasks_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtTasks;
        private Button btnAdd;
        private DataGridView dgvTasks;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private Button button2;
    }
}