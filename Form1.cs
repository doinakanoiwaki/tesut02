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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 自分自身のフォームを最大化する
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // Form2 のインスタンスを作成
            form2.Show();              // Form2 を表示
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(); // Form3 のインスタンスを作成
            form3.Show();              // Form3 を表示
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 終了ボタンの処理
            button1.Location = new Point(50, 100);
            Application.Exit();
        }
    }
}
