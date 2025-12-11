
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tesut02
{
    public partial class Form3 : Form
    {
        int i = 0;

        string[] Proteinquestions = new string[]
        {

            "最近、筋肉量の減少・疲れやすさ・肌や髪のハリの低下などを感じることはありますか？",

            "プロテインやヨーグルト、ゆで卵、チーズなどの高たんぱくなおやつ・サプリを摂ることはありますか？",

            "普段、1日にどのくらい肉・魚・卵・大豆製品などを食べていますか？",

            "食事のときに「たんぱく質を意識して摂ろう」と思うことはありますか？",

            "主食（ご飯やパン）だけで食事を終えることが多いですか？それとも、毎回おかず（肉・   魚・卵・豆腐など）も一緒に食べていますか？\r\n",

        };

        string[] Fatquestions = new string[]
        {

            "",

            "",

            "",

            "",

            "",

        };

        string[] Carboquestions = new string[]
        {

            "",

            "",

            "",

            "",

            "",

        };

        string[] Vitaminquestions = new string[]
        {

            "",

            "",

            "",

            "",

            "",

        };

        string[] Mineralquestions = new string[]
        {

            "",

            "",

            "",

            "",

            "",

        };

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "普段、1日にどのくらい肉・魚・卵・大豆製品などを食べていますか？";
        }


        private void button2_Click(object sender, EventArgs e)
        {



            if (i == 0)
            {
                label1.Text = "最近、筋肉量の減少・疲れやすさ・肌や髪のハリの低下などを感じることはありますか？\r\n";
            }
            else if (i == 1)
            {
                label1.Text = "プロテインやヨーグルト、ゆで卵、チーズなどの高たんぱくなおやつ・サプリを摂ることはありますか？\r\n";
            }
            else if (i == 2)
            {
                label1.Text = "（ここに3つ目の質問を追加できます）";
            }


            else if (i == 10)  // 最後の質問が終わったら FormⅣ を開く
            {
                FormⅣ f = new FormⅣ();
                f.Show();
                this.Hide();
                return;
            }

            i++;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // Form3 のインスタンスを作成
            form2.Show();              // Form3 を表示
            this.Hide();
        }

        

    }
}

