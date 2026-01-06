using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace tesut02
{
    public partial class Form3 : Form
    {
        int i = 0;
        Random rnd = new Random();

        public List<int> answers = new List<int>();

        // UI部品
        Label label1;
        RadioButton radioButton1;
        RadioButton radioButton2;
        RadioButton radioButton3;
        RadioButton radioButton4;
        RadioButton radioButton5;

        Button button1; // 戻る
        Button button2; // 回答

        public Form3()
        {
            // InitializeComponent(); ← 使わない

            this.WindowState = FormWindowState.Maximized;

            // 背景画像
            this.BackgroundImage = Image.FromFile(@"C:\Users\kd141\OneDrive\画像\a soft pastel backgr.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // ちらつき防止
            this.DoubleBuffered = true;

            CreateUI();
        }

        private void CreateUI()
        {
            // 質問文ラベル
            label1 = new Label();
            label1.Text = "質問文";
            label1.Font = new Font("Meiryo", 18);
            label1.AutoSize = false;
            label1.Height = 150;
            label1.Dock = DockStyle.Top;
            label1.Padding = new Padding(20);
            label1.BackColor = Color.Transparent;   // ★透過

            this.Controls.Add(label1);

            // ラジオボタンパネル
            FlowLayoutPanel panelRadio = new FlowLayoutPanel();
            panelRadio.Dock = DockStyle.Top;
            panelRadio.FlowDirection = FlowDirection.TopDown;
            panelRadio.WrapContents = false;
            panelRadio.AutoSize = true;
            panelRadio.Padding = new Padding(40, 10, 0, 10);
            panelRadio.BackColor = Color.Transparent;   // ★透過

            // ラジオボタン生成
            radioButton1 = CreateRadio("非常に当てはまる");
            radioButton2 = CreateRadio("当てはまる");
            radioButton3 = CreateRadio("どちらともいえない");
            radioButton4 = CreateRadio("あまり当てはまらない");
            radioButton5 = CreateRadio("全く当てはまらない");

            // それぞれの背景を透明に
            radioButton1.BackColor = Color.Transparent;
            radioButton2.BackColor = Color.Transparent;
            radioButton3.BackColor = Color.Transparent;
            radioButton4.BackColor = Color.Transparent;
            radioButton5.BackColor = Color.Transparent;

            panelRadio.Controls.Add(radioButton1);
            panelRadio.Controls.Add(radioButton2);
            panelRadio.Controls.Add(radioButton3);
            panelRadio.Controls.Add(radioButton4);
            panelRadio.Controls.Add(radioButton5);

            this.Controls.Add(panelRadio);

            // ★ボタンパネル
            FlowLayoutPanel panelButtons = new FlowLayoutPanel();
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.FlowDirection = FlowDirection.LeftToRight;
            panelButtons.AutoSize = true;
            panelButtons.Padding = new Padding(20);
            panelButtons.BackColor = Color.Transparent;   // ★透過

            button1 = new Button();
            button1.Text = "戻る";
            button1.Font = new Font("Meiryo", 14);
            button1.Click += button1_Click;

            button2 = new Button();
            button2.Text = "回答";
            button2.Font = new Font("Meiryo", 14);
            button2.Click += button2_Click;

            panelButtons.Controls.Add(button1);
            panelButtons.Controls.Add(button2);

            this.Controls.Add(panelButtons);

            // 初期質問
            label1.Text =
                "主食（ご飯やパン）だけで食事を終えることが多いですか？\n" +
                "それとも、毎回おかず（肉・魚・卵・豆腐など）も一緒に食べていますか？";
        }

        private RadioButton CreateRadio(string text)
        {
            RadioButton rb = new RadioButton();
            rb.Text = text;
            rb.Font = new Font("Meiryo", 16);
            rb.AutoSize = true;
            rb.BackColor = Color.Transparent;   // ★透過
            return rb;
        }

        private int GetSelectedAnswer()
        {
            if (radioButton1.Checked) return 1;
            if (radioButton2.Checked) return 2;
            if (radioButton3.Checked) return 3;
            if (radioButton4.Checked) return 4;
            if (radioButton5.Checked) return 5;
            return 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int answer = GetSelectedAnswer();
            if (answer == 0)
            {
                MessageBox.Show("回答を選んでください");
                return;
            }

            answers.Add(answer);

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;

            int x = rnd.Next(5);

            // ★あなたの質問切り替えロジック（元コードそのまま）
            // ----------------------------------------------------
            if (i == 0)
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
            else if (i == 2 || i == 3)
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
                        label1.Text = "間食でスナック菓子、ナッツ、ケーキなどを食べたりすることが多い";
                        break;
                    default:
                        label1.Text = "料理やサラダにマヨネーズ、ドレッシング、オリーブオイル、バターなどを使うことが多い";
                        break;
                }
            }
            else if (i == 4 || i == 5)
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
                        label1.Text = "果物類・ドライフルーツを食べることが多い";
                        break;
                    default:
                        label1.Text = "主食が白米、食パン、うどんであることが多い";
                        break;
                }
            }
            else if (i == 6 || i == 7)
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
            else if (i == 8 || i == 9)
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
            else if (i == 10)
            {
                FormⅣ f = new FormⅣ(answers);
                f.Show();
                this.Hide();
                return;
            }

            i++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
    }
}
