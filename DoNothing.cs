using System;
using System.Windows.Forms;
using The_Do_Nothing_Project.Control;

namespace The_Do_Nothing_Project
{
    public partial class DoNothing : Form
    {
        Client button = new Client();
        public DoNothing()
        {
            InitializeComponent();
        }
        private void DoNothing_Load(object sender, EventArgs e)
        {
            button1.Text = "Don't push. It does nothing";
            button2.Text = "Push this instead";
            button3.Text = "Close";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button.SetWrong();
            MessageBox.Show(button.OnClick());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button.SetRight();
            MessageBox.Show(button.OnClick());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button.SetIdle();
            MessageBox.Show(button.OnClick());
        }
        private void Create_Click(object sender, EventArgs e)
        {
            button.SetDirectoryManager();
            button.CreateDirectory(textBox1.Text);
        }

        private void Mover_Click(object sender, EventArgs e)
        {
            button.SetDirectoryManager();
            button.MoveDirectory(textBox1.Text, textBox2.Text);
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            button.SetDirectoryManager();
            button.DeleteDirectory(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
