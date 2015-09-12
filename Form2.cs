using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Teamproject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // 종료 이벤트를 취소 시킨다
            this.Visible = false; // 폼을 표시하지 않는다;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ckViewTime1.Hide();
            TxtLyric.SelectionStart = TxtLyric.Text.Length;
         
        }

        private void TxtLyric_TextChanged(object sender, EventArgs e)
        {
           // TxtLyric.Select(0, 0);
        }

    }
}
