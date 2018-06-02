/********************************************************************
 * Original from SDEV 240                                           *
 *                                                                  *
 * From book:                                                       *
 * Microsoft Visual C# 2015:                                        *
 * An Introduction to Object-Oriented Programming 6th Edition       *
 * by Joyce Farrell                                                 *
 *                                                                  *
 * Instructions (Page 603, Exercise 3):                             *
 * Create a project named FiveColors2. Its Form contains at least   *
 * five RadioButton objects, each labeled with a color. When the    *
 * user clicks a RadioButton, change the BackColor of the Form      *
 * appropriately.                                                   *
 ********************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiveColors2
{
    public partial class FiveColors2 : Form
    {
        public FiveColors2()
        {
            InitializeComponent();
            optRed.CheckedChanged += new EventHandler(backColor_ColorChanged);
            optOrange.CheckedChanged += new EventHandler(backColor_ColorChanged);
            optGreen.CheckedChanged += new EventHandler(backColor_ColorChanged);
            optBlue.CheckedChanged += new EventHandler(backColor_ColorChanged);
            optPurple.CheckedChanged += new EventHandler(backColor_ColorChanged);
        }
        private void backColor_ColorChanged(object sender, EventArgs e)
        {
            if (optRed.Checked)
            {
                this.BackColor = Color.Red;
                this.ForeColor = Color.White;
            }
            else if (optOrange.Checked)
            {
                this.BackColor = Color.Orange;
                this.ForeColor = Color.White;
            }
            else if (optGreen.Checked)
            {
                this.BackColor = Color.Green;
                this.ForeColor = Color.White;
            }
            else if (optBlue.Checked)
            {
                this.BackColor = Color.Blue;
                this.ForeColor = Color.White;
            }
            else if (optPurple.Checked)
            {
                this.BackColor = Color.Purple;
                this.ForeColor = Color.White;
            }
        }
    }
}
