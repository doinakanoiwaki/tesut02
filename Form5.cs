
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tesut02
{
    public partial class Form5 : Form
    {
        private string registeredName = "";

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


            private void label1_Click(object sender, EventArgs e)
        {
            // 未登録なら注意
            if (string.IsNullOrEmpty(registeredName))
            {
                MessageBox.Show("まだ名前が登録されていません。");
                return;
            }

            // 登録した名前を表示
            label1.Text = registeredName;
        }

        

            private void button2_Click(object sender, EventArgs e)
        {
            // ---- 編集モードに戻す処理 ----
            if (button2.Text == "編集")
            {
                textBox1.Enabled = true;
                textBox1.BackColor = Color.White;
                textBox1.BorderStyle = BorderStyle.FixedSingle;
                button2.Text = "登録";
                return;
            }

            // ---- 登録処理 ----

            // 名前を保存
            registeredName = textBox1.Text;

            // TextBox を透明化＆編集不可に
            textBox1.Enabled = false;
            textBox1.BackColor = Color.FromArgb(0, 0, 0, 0); // 透明風
            textBox1.BorderStyle = BorderStyle.None;

            // ボタンの文字を「編集」に変更
            button2.Text = "編集";
        }

    }
}

