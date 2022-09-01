using System;
using System.Windows.Forms;
using The_Do_Nothing_Project.StateMachine;

namespace The_Do_Nothing_Project
{
    public partial class DoNothing : Form
    {
        Client button = new Client();
        public DoNothing()
        {
            InitializeComponent();
            button1.Text = "Don't push. It does nothing";
            button2.Text = "Push this instead";
            button3.Text = "Close";
        }
        private void DoNothing_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            button.SetWrong();
            textBox1.Text = button.OnClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button.SetRight();
            textBox1.Text = button.OnClick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button.SetIdle();
            textBox1.Text = button.OnClick();
        }
    }
}
