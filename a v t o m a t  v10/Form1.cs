using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a_v_t_o_m_a_t__v10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] strMas = richTextBox1.Lines;
            richTextBox1.AppendText("\r\n");
            foreach (string str in strMas)
            {
                //richTextBox1.AppendText("\r\n");
                //richTextBox1.AppendText(str + " ???");
                SyntaxAuto auto = new SyntaxAuto(str);
                try
                {
                    auto.Exec();
                }
                catch { };
            }
        }
    }
}
