using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject
{
    public partial class CalendarForm : Form
    {
        private bool isSelectingStart = true; //initialized as true for the start date but will become false in the end date

        //this is an encapsulation and where the start and end date are stored
        public DateTime? StartDate { get; private set; } = null;
        public DateTime? EndDate { get; private set; } = null;

        public CalendarForm()
        {
            InitializeComponent();
        }

        private void cal_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (isSelectingStart)
            {
                //user selects the start date
                StartDate = e.Start;
                MessageBox.Show("Start Date Selected: " + StartDate.Value.ToShortDateString() );
                isSelectingStart = false; //will become false for the end date
            }
            else
            {
                //user select the end date
                EndDate = e.Start;
                MessageBox.Show("End Date Selected: " + EndDate.Value.ToShortDateString());
                isSelectingStart = true;

                //validate if the start date is before the end date
                if (StartDate > EndDate)
                {
                    MessageBox.Show("Start date must be before end date.");

                    //reset everything if the date is not valid
                    StartDate = null;
                    EndDate = null;
                    isSelectingStart = true;
                }
                else
                {
                    //valid date and the windows form will close
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }

        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {

        }

        private void cal_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
