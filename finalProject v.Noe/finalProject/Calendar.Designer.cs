namespace finalProject
{
    partial class CalendarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarForm));
            cal = new MonthCalendar();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cal
            // 
            cal.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cal.Location = new Point(71, 50);
            cal.Margin = new Padding(14, 34, 14, 34);
            cal.Name = "cal";
            cal.TabIndex = 0;
            cal.DateChanged += cal_DateChanged;
            cal.DateSelected += cal_DateSelected;
            // 
            // panel1
            // 
            panel1.BackColor = Color.BurlyWood;
            panel1.Controls.Add(cal);
            panel1.Location = new Point(-11, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 322);
            panel1.TabIndex = 1;
            // 
            // CalendarForm
            // 
            AutoScaleDimensions = new SizeF(15F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(380, 296);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 10, 5, 10);
            MaximizeBox = false;
            Name = "CalendarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calendar";
            Load += CalendarForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar cal;
        private Panel panel1;
    }
}