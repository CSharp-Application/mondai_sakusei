using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 計算問題作成アプリ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> list = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            list.Clear();
            for (int i = 0; i < int.Parse(nanko.Value.ToString()); i++)
            {
                string s = "";
                s += random.Next(0, int.Parse(mae.Value.ToString()));
                switch (syurui.SelectedItem)
                {
                    case "＋":
                        s += "＋";
                        break;
                    case "ー":
                        s += "ー";
                        break;
                    case "×":
                        s += "×";
                        break;
                    case "÷":
                        s += "÷";
                        break;
                }
                s += random.Next(0, int.Parse(ato.Value.ToString()));
                list.Add(s);
            }
            kekka form = new kekka();
            form.list = list;
            form.ShowDialog();
        }
    }
}