//this is my own work
//Noah Vandervelden
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiApp
{
    public partial class piCalc : Form
    {
        public piCalc()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            int input;
            input = int.Parse(txtbx_input.Text);
            double pi = 4;
            double denom = 1;
            for(int i = 0; i < input; i++)
            {
                //this will increase the denom by 2 depending on if it is a positive or negative 
                //and it will siwtch the sign 
                if (denom > 0)
                {
                    denom = (denom + 2) * -1;
                }
                else if(denom < 0)
                {
                    denom = (denom - 2) * -1;
                }
                pi = (4 / denom) + pi;
            }
            //this is what displays in the text box
            txtbx_output.Text = pi.ToString();
            
        }
    }
}
