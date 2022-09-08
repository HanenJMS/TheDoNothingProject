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
            button1.Text = "Directory";
            button2.Text = "File";
            button3.Text = "Close";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
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

        private void CreateFile_Click(object sender, EventArgs e)
        {

            button.SetFileManager();
            button.CreateDirectory(textBox1.Text);
        }

        private void MoveFile_Click(object sender, EventArgs e)
        {

            button.SetFileManager();
            button.MoveDirectory(textBox1.Text, textBox2.Text);
        }

        private void DeleteFile_Click(object sender, EventArgs e)
        {

            button.SetFileManager();
            button.DeleteDirectory(textBox1.Text);
        }

        private void Write_Click(object sender, EventArgs e)
        {
            button.SetFileManager();
            button.WriteToFile(textBox1.Text, textBox2.Text);
        }

        private void Read_Click(object sender, EventArgs e)
        {
            button.SetFileManager();
            textBox2.Text = button.ReadFromFile(textBox1.Text);
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            button.SetFileManager();
            button.CopyFileTo(textBox1.Text, textBox2.Text);
        }
    }
}
