using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_Do_Nothing_Project.StateMachine;

namespace The_Do_Nothing_Project
{
    public partial class DoNothing : Form
    {
        Client client = new Client();
        public DoNothing()
        {
            InitializeComponent();
            button1.Text = "Don't push. It does nothing";
        }
        private void DoNothing_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            client.SetWrong();
            textBox1.Text = client.OnHit();
        }
    }
}
