using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1Calculator
{
    public partial class Form1 : Form
    {
        Calculator calc = new Calculator();
        public Form1()
        {
            InitializeComponent();

            calc.CreateButtonsField(this);
            calc.CreateTextBox(this);
            calc.AllClicks();
            this.Size = new System.Drawing.Size(270, 370);
            this.Text = "Calculator";
        }

    }
}
