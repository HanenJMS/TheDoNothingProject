using System;
using System.IO;
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

        private void button4_Click(object sender, EventArgs e)
        {
            button.SetFileHandle();
            string path = @"C:\Users\Hanen\Desktop\DotNet Web Projects\The Do Nothing Project\newFolder";
            button.Create(path);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string path = @"C:\Users\Hanen\Desktop\DotNet Web Projects\The Do Nothing Project\newFolder";
            string dest = @"C:\Users\Hanen\Desktop\newFolder";
            button.Move(path, dest);
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            Directory.Delete(@"C:\Users\Hanen\Desktop\newFolder");
        }
    }
}
