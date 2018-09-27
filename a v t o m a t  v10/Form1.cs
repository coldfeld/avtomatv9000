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
            richTextBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            string[] strMas = richTextBox1.Lines;
            richTextBox1.AppendText("\r\n");
            foreach (string str in strMas)
            {
                if (str == "") continue;
                int position = 0;
                SyntaxAuto auto = new SyntaxAuto(str);
                try
                {
                    auto.Exec(out position);
                    richTextBox2.AppendText("Строка" + str + "  : успешно\n");
                    richTextBox2.AppendText("Список идентификаторов: ");
                    foreach (string s in auto.idbuffer)
                    {
                        richTextBox2.AppendText(s + " ");
                    }
                    richTextBox2.AppendText(";\nСписок констант: ");
                    if (auto.constbuffer.Count == 0) richTextBox2.AppendText( "отсутствуют"); else
                    foreach (string s in auto.constbuffer)
                    {
                        richTextBox2.AppendText(s + " ");
                    }
                    richTextBox2.AppendText("\n");
                }
                catch (Exception ex)
                {
                    string buf = null;
                    for (int i = 0; i < position+1; i++)
                    {
                        if(i < str.Length) buf += str[i];
                    }
                    richTextBox2.AppendText(buf + "<< место ошибки. \n");
                    richTextBox2.AppendText(ex.Message);
                    
                    continue;
                };
            }
        }
    }
}
