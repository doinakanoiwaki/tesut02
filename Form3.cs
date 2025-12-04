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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ここでも必ず選択肢を渡す
            string selectedOption = "";

            if (radioButton1.Checked) selectedOption = "Option1";
            else if (radioButton2.Checked) selectedOption = "Option2";
            else if (radioButton3.Checked) selectedOption = "Option3";


            FormⅣ formⅣ = new FormⅣ(); // Form3 のインスタンスを作成
            formⅣ.Show();              // Form3 を表示
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // Form3 のインスタンスを作成
            form2.Show();              // Form3 を表示
            this.Hide();
        }

        private void buttonShowGraph_Click(object sender, EventArgs e)
        {
            string selectedOption = "";

            if (radioButton1.Checked) selectedOption = "Option1";
            else if (radioButton2.Checked) selectedOption = "Option2";
            else if (radioButton3.Checked) selectedOption = "Option3";

            // FormⅣに選択値を渡して表示
            FormⅣ FormⅣ = new FormⅣ(selectedOption);
            FormⅣ.Show();
        }
    }
}
