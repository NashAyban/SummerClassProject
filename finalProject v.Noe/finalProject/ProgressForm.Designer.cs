namespace finalProject
{
    partial class ProgressForm
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
            dgvProjects = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProjects).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProjects
            // 
            dgvProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProjects.Location = new Point(23, 21);
            dgvProjects.Margin = new Padding(3, 2, 3, 2);
            dgvProjects.Name = "dgvProjects";
            dgvProjects.RowHeadersWidth = 51;
            dgvProjects.Size = new Size(698, 350);
            dgvProjects.TabIndex = 0;
            dgvProjects.CellContentClick += dgvProjects_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(dgvProjects);
            panel1.Location = new Point(0, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 395);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.BurlyWood;
            panel2.Controls.Add(label4);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(748, 55);
            panel2.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 15);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 0;
            label4.Text = "Progress";
            // 
            // ProgressForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 468);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProgressForm";
            Text = "Progress";
            Load += ProgressForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProjects).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProjects;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
    }
}