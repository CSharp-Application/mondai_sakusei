using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace 計算問題作成アプリ
{
    public partial class kekka : Form
    {
        public List<string> list { get; set; }

        public kekka()
        {
            InitializeComponent();
        }

        private void kekka_Load(object sender, EventArgs e)
        {
            foreach (string s in list)
            {
                listBox1.Items.Add(s);
            }
        }
    }
}
