
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

        Random rnd = new Random();

        


       

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "主食（ご飯やパン）だけで食事を終えることが多いですか？それとも、毎回おかず（肉・   魚・卵・豆腐など）も一緒に食べていますか？";
        }


        private void button2_Click(object sender, EventArgs e)
        {

            int x = rnd.Next(5);
            // 0〜9 のランダムな整数が入る

            if (i == 0)
            {
                switch(x)
                {
                    case 0:
                        label1.Text = "最近、筋肉量の減少・疲れやすさ・肌や髪のハリの低下などを感じることはありますか？";
                        break;
                    case 1:
                        label1.Text = "プロテインやヨーグルト、ゆで卵、チーズなどの高たんぱくなおやつ・サプリを摂ることはありますか？";
                        break;
                    case 2:
                        label1.Text = "普段、1日にどのくらい肉・魚・卵・大豆製品などを食べていますか？";
                        break;
                    default:
                        label1.Text = "食事のときに「たんぱく質を意識して摂ろう」と思うことはありますか？";
                        break;
                }
            }
            else if (i == 1)
            {
                switch (x)
                {
                    case 0:
                        label1.Text = "最近、筋肉量の減少・疲れやすさ・肌や髪のハリの低下などを感じることはありますか？";
                        break;
                    case 1:
                        label1.Text = "プロテインやヨーグルト、ゆで卵、チーズなどの高たんぱくなおやつ・サプリを摂ることはありますか？";
                        break;
                    case 2:
                        label1.Text = "普段、1日にどのくらい肉・魚・卵・大豆製品などを食べていますか？";
                        break;
                    default:
                        label1.Text = "食事のときに「たんぱく質を意識して摂ろう」と思うことはありますか？";
                        break;
                }

            }    
            else if (i == 2)
            {
                switch (x)
                {
                    case 0:
                        label1.Text = "日常的に揚げ物を食べることが多い";
                        break;
                    case 1:
                        label1.Text = "バター、チーズ、卵などを食べることが多い";
                        break;
                    case 2:
                        label1.Text = "脂質が多い肉や加工肉を食べることが多い";
                        break;
                    case 3:
                        label1.Text = "間食でスナック菓子、ナッツ、ケーキなどを食べたりすることが多い\r\n";
                        break;
                    default:
                        label1.Text = "料理やサラダにマヨネーズ、ドレッシング、オリーブオイル、バターなどを\r\n　使うことが多い\r\n";
                        break;

                }
            }

            else if (i == 3)
            {
                switch (x)
                {
                    case 0:
                        label1.Text = "日常的に揚げ物を食べることが多い";
                        break;
                    case 1:
                        label1.Text = "バター、チーズ、卵などを食べることが多い";
                        break;
                    case 2:
                        label1.Text = "脂質が多い肉や加工肉を食べることが多い";
                        break;
                    case 3:
                        label1.Text = "間食でスナック菓子、ナッツ、ケーキなどを食べたりすることが多い\r\n";
                        break;
                    default:
                        label1.Text = "料理やサラダにマヨネーズ、ドレッシング、オリーブオイル、バターなどを\r\n　使うことが多い\r\n";
                        break;

                }

            }

            else if (i == 4)
            {
                switch (x)
                {
                    case 0:
                        label1.Text = "類・根菜類を食べることが多い";
                        break;
                    case 1:
                        label1.Text = "牛乳・ヨーグルトを食べることが多い";
                        break;
                    case 2:
                        label1.Text = "豆類・種実類を食べることが多い";
                        break;
                    case 3:
                        label1.Text = " 果物類・ドライフルーツを食べることが多い";
                        break;
                    default:
                        label1.Text = "主食が白米、食パン、うどんであることが多い";
                        break;

                }
            }

            else if (i == 5)
            {
                switch (x)
                {
                    case 0:
                        label1.Text = "類・根菜類を食べることが多い";
                        break;
                    case 1:
                        label1.Text = "牛乳・ヨーグルトを食べることが多い";
                        break;
                    case 2:
                        label1.Text = "豆類・種実類を食べることが多い";
                        break;
                    case 3:
                        label1.Text = " 果物類・ドライフルーツを食べることが多い";
                        break;
                    default:
                        label1.Text = "主食が白米、食パン、うどんであることが多い";
                        break;

                }
            }

            else if (i == 6)
            {
                switch (x)
                {
                    case 0:
                        label1.Text = "緑黄色野菜はたべますか？";
                        break;
                    case 1:
                        label1.Text = "最近、疲れやすいと感じますか？";
                        break;
                    case 2:
                        label1.Text = "口内炎や唇の荒れが気になりますか？";
                        break;
                    case 3:
                        label1.Text = "風邪をひきやすいと感じますか？";
                        break;
                    default:
                        label1.Text = "外に出る時間が少ないですか？";
                        break;

                }
            }

            else if (i == 7)
            {
                switch (x)
                {
                    case 0:
                        label1.Text = "緑黄色野菜はたべますか？";
                        break;
                    case 1:
                        label1.Text = "最近、疲れやすいと感じますか？";
                        break;
                    case 2:
                        label1.Text = "口内炎や唇の荒れが気になりますか？";
                        break;
                    case 3:
                        label1.Text = "風邪をひきやすいと感じますか？";
                        break;
                    default:
                        label1.Text = "外に出る時間が少ないですか？";
                        break;

                }
            }

            else if (i == 8)
            {
                switch (x)
                {
                    case 0:
                        label1.Text = "最近、疲れやすくなったり、だるさを感じることが多い。";
                        break;
                    case 1:
                        label1.Text = "足がつる・こむら返りが起こることが増えた。";
                        break;
                    case 2:
                        label1.Text = "肌荒れや口内炎ができやすくなった。";
                        break;
                    case 3:
                        label1.Text = "集中力が続かず、イライラしやすい。";
                        break;
                    default:
                        label1.Text = "髪の毛が抜けやすくなったり、爪が割れやすくなった。";
                        break;

                }
            }

            else if (i == 9)
            {
                switch (x)
                {
                    case 0:
                        label1.Text = "最近、疲れやすくなったり、だるさを感じることが多い。";
                        break;
                    case 1:
                        label1.Text = "足がつる・こむら返りが起こることが増えた。";
                        break;
                    case 2:
                        label1.Text = "肌荒れや口内炎ができやすくなった。";
                        break;
                    case 3:
                        label1.Text = "集中力が続かず、イライラしやすい。";
                        break;
                    default:
                        label1.Text = "髪の毛が抜けやすくなったり、爪が割れやすくなった。";
                        break;

                }
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

