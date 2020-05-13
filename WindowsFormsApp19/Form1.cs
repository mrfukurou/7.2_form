using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Ss = "";
                StringBuilder a = new StringBuilder(stroka.Text);
                string str = a.ToString();
                if (!String.IsNullOrWhiteSpace(str))
                {
                    var s = str.ToLower().Split(new[] { ' ','.', ',', '?', '!', ':', ';' }, StringSplitOptions.RemoveEmptyEntries)
                    .GroupBy(x => x)
                    .Where(x => x.Count() == 1)
                    .Select(x => x.Key);
                    foreach (var rez in s)
                        Ss += rez+ ",";
                            words.Text=Convert.ToString(Ss);
                    attention.Clear();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch { attention.Text = Convert.ToString("Некорректный ввод! "); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            attention.Clear();
            stroka.Clear();
            words.Clear();
        }
    }
}
