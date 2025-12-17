
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
            this.WindowState = FormWindowState.Maximized;
            this.Text = "健康を知ろう - Nutrient Checker";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormⅣ FormⅣ = new FormⅣ(); // Form2 のインスタンスを作成
            FormⅣ.Show();              // Form2 を表示
            this.Hide();
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
                textBox1.Visible = true;
                textBox1.ReadOnly = false;
                textBox1.BackColor = Color.White;
                textBox1.BorderStyle = BorderStyle.FixedSingle;

                button2.Text = "登録";
                return;
            }

            // ---- 登録処理 ----
            registeredName = textBox1.Text;

            // ★ 登録した名前をすぐにラベルへ反映！
            label1.Text = registeredName;

            // テキストボックスを非表示
            textBox1.Visible = false;

            button2.Text = "編集";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();   // 今のフォームを閉じる
        }

    }
}

