namespace oefening2
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            childForm child = new childForm();
            child.MdiParent = this;
            child.Show();

        }
    }
}