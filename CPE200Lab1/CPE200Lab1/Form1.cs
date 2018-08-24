using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE200Lab1
{

    public partial class Form1 : Form
    {
        double z, y, x;
        string a;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }
        private void operater_cilck(object sender, EventArgs e)
        {
            
            z = double.Parse(lblDisplay.Text);                             
                a = ((Button)sender).Text;
                lblDisplay.Text = ((Button)sender).Text;        
           
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
          
            y = double.Parse(lblDisplay.Text);
            y = (y / 100) * z;
            if(a == "+")
            {
                x = z + y;
            }
            else if (a == "-")
            {
                x = z - y;
            }
            lblDisplay.Text = x.ToString();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
           
             y = double.Parse(lblDisplay.Text);
            if (a == "+")
            {
                x = (z + y);                              
            }
            else if (a == "-")
            {
                x = (z - y);                             
            }
            else if (a == "X")
            {
                x = (z * y);                              
            }
            else if (a == "÷")
            {
                x = (z / y); 
            }



            string l = x.ToString();
            if(l.Length > 8)
            {
                lblDisplay.Text = "ERROR";
            }
            else
            {
                lblDisplay.Text = x.ToString();
            }
               
                
            
            
        }
        private void btnnumber_click(object sender, EventArgs e)
        {
        
           
            if (((Button)sender).Text == "C")
            {
                lblDisplay.Text = "0";
            }
            else if (((Button)sender).Text == ".")
            {
                if (lblDisplay.Text.Contains('.') == false)
                    lblDisplay.Text += ".";
            }
            else if (lblDisplay.Text == "0" || lblDisplay.Text == a)
            {
               lblDisplay.Text = ((Button)sender).Text;
            }
            else if (lblDisplay.Text == "ERROR")
            {
                lblDisplay.Text = "0";
            }
            else if (lblDisplay.Text.Length < 8)
            {
                    lblDisplay.Text += ((Button)sender).Text;                        
            }

        }
    }
}
