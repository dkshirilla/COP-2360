//Programmer: Douglas Shirilla
//Date: 02/07/2017
//Class: COP 2360
//Instructor: Dr. Spears
//Purpose: Create a GUI program that accepts a word from a user and converts
//it into the pig latin equivalent. A convert button will handle the event and 
//a second textbox will display the result


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGPAY_A3_COP2360
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            //declare string variable to hold the value
            String inputText = InputTextBox.Text;

            //display result 
            ResultTextBox.Text = inputText.Substring(1, inputText.Length-1) +
                 inputText.Substring(0, 1) + "ay";
        }
    }
}
