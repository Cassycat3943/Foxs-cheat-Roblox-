using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foxs_cheat
{
    public partial class Form1 : Form
    {
        WeAreDevs_API.Module Devs = new WeAreDevs_API.Module();

        EasyExploits.Module FoxsCheat = new EasyExploits.Module();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FoxsCheat.ExecuteScript(this.richTextBox1.Text);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FoxsCheat.killRoblox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FoxsCheat.LaunchExploit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Devs.ToggleClickTeloport();
        }
    }
}
