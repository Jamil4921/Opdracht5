using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace oefening2
{
    public partial class childForm : Form
    {
        public childForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = Interaction.InputBox("Add number","Inputbox");

            double userInputNumber = double.Parse(userInput);

            listBox1.Items.Add(userInputNumber);

            double average = 0;
            foreach(double n in listBox1.Items)
            {
                average = average + n;

            }

            average = average / listBox1.Items.Count;
            textBox1.Text = average.ToString();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
