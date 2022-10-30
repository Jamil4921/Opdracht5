using System.Diagnostics.Metrics;
using System.Reflection;

namespace Oefening3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int x = 0;
        public int y = 30;
        public int breeteSize = 0;
        public int hooghtSize = 0;
     
        public static List<TextBox> ListOfTextBoxes = new List<TextBox>();

        public void reAdjust()
        {

        }

        private void toevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                breeteSize = (this.Size.Width);
                hooghtSize = (this.Size.Height);

                TextBox Rechthoek = new TextBox();
                Rechthoek.Multiline = true;
                Rechthoek.Location = new Point(x, y);
                Rechthoek.Size = new Size(breeteSize, hooghtSize);
                Rechthoek.BackColor = Color.Green;
                this.Controls.Add(Rechthoek);
                ListOfTextBoxes.Add(Rechthoek);
 
        }
    }
}