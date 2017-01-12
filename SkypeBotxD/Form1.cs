using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SKYPE4COMLib;

namespace SkypeBotxD
{
    public partial class Form1 : Form
    {
        Skype _skype = new Skype();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _skype.Attach();
                MessageBox.Show("Attached To Skype!");
            }
            catch { MessageBox.Show("Falied To Attach To Skype!"); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (User user in _skype.Friends)
            {
                _skype.SendMessage(user.Handle, textBox1.Text + "\n\n\n (star)TrapKillo SkypeBot(star)");
            }
        }
    }
}
