using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace tesut02
{
    // グラフを表示するフォーム
    public partial class FormⅣ : Form
    {
        // ★Form3 から受け取る回答リスト
        private List<int> answers;  


        public List<int> Answers { get; }

        public FormⅣ(List<int> answers)
        {
            InitializeComponent();
            this.answers = answers;
        }

        public FormⅣ()
        {
            InitializeComponent();
        }


        private void FormⅣ_Load(object sender, EventArgs e)
        {
            // フォーム最大化
            this.WindowState = FormWindowState.Maximized;

            // ===== フォーム背景 =====
            // 背景画像を設定
            // 背景画像設定

            string bgPath = Application.StartupPath + @"\HealthBackground.png";
            this.BackgroundImage = Image.FromFile(bgPath);
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // ===== Chartの基本設定 =====
            chart1.Series.Clear();
            chart1.BackColor = Color.Transparent;

            ChartArea area = chart1.ChartAreas[0];
            area.BackColor = Color.Transparent;

            // 軸の色・フォント（柔らかく）
            area.AxisX.LabelStyle.Font = new Font("Meiryo", 12);
            area.AxisY.LabelStyle.Font = new Font("Meiryo", 12);
            area.AxisX.LineColor = Color.Gray;
            area.AxisY.LineColor = Color.Gray;
            area.AxisX.MajorGrid.LineColor = Color.FromArgb(200, Color.LightGray);
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(200, Color.LightGray);

            // ===== シリーズ設定 =====
            Series series = new Series("回答集計");
            series.ChartType = SeriesChartType.Column;

            // バーを少し柔らかい色に
            series.Color = Color.FromArgb(180, 79, 129, 235);
            series.BorderWidth = 0;

            // ===== 回答集計 =====
            int[] count = new int[5];
            foreach (int a in answers)
            {
                if (a >= 1 && a <= 5)
                    count[a - 1]++;
            }

            // ===== グラフに反映 =====
            series.Points.AddXY("非常に当てはまる", count[0]);
            series.Points.AddXY("当てはまる", count[1]);
            series.Points.AddXY("どちらでもない", count[2]);
            series.Points.AddXY("当てはまらない", count[3]);
            series.Points.AddXY("まったく当てはまらない", count[4]);

            chart1.Series.Add(series);

            double avg = answers.Count > 0 ? answers.Average() : 0;
            label1.Font = new Font("Meiryo", 20);
            label1.BackColor = Color.Transparent;

            if (avg >= 4.0)
            {
                label1.Text = "【健康状態：良好】\n" +
               "あなたの食生活はバランスが取れており、栄養面でも安定しています。\n" +
               "今後も健康を維持するために、以下の習慣を意識しましょう：\n\n" +
               "1. 毎食にたんぱく質（肉・魚・卵・豆腐など）を取り入れる\n" +
               "2. 揚げ物は週2回以内に抑え、焼く・蒸す調理を中心にする\n" +
               "3. 緑黄色野菜（ほうれん草・人参・ブロッコリーなど）を1日2回以上摂取\n" +
               "4. 間食はナッツ・ヨーグルト・果物など栄養価の高いものにする\n" +
               "5. 水分を1日1.5〜2Lを目安にこまめに摂る";
            }
            else if (avg >= 3.0)
            {
                label1.Text = "【健康状態：やや偏りあり】\n" +
              "食生活に一部偏りが見られます。体調や肌の調子に影響する前に改善しましょう：\n\n" +
              "1. 主食だけで済ませず、必ずおかず（たんぱく質）を加える\n" +
              "2. 加工肉や脂質の多い食品は週3回以内に抑える\n" +
              "3. 野菜は1日350gを目安に、色の濃い野菜を意識して摂る\n" +
              "4. 朝食を抜かず、1日3食のリズムを整える\n" +
              "5. ビタミンB群・Cを含む食品（レバー・柑橘類・緑黄色野菜）を積極的に摂る";
            }
            else if (avg >= 2.0)
            {
                label1.Text = "【健康状態：改善が必要】\n" +
              "栄養バランスが崩れ始めており、疲れやすさ・肌荒れ・集中力低下などが起こりやすい状態です。\n" +
              "以下の改善を意識しましょう：\n\n" +
              "1. 毎食にたんぱく質を加える（卵・豆腐・魚・鶏肉など）\n" +
              "2. 揚げ物・スナック菓子は週1〜2回に制限し、代わりに蒸し料理や煮物を選ぶ\n" +
              "3. 野菜・果物を毎日摂取し、特にビタミンC・Eを意識する\n" +
              "4. 間食を甘いものからヨーグルト・果物・ナッツに置き換える\n" +
              "5. 食事の時間を一定にし、夜遅くの食事は避ける";

            }
            else
            {
                label1.Text = "【健康状態：要注意】\n" +
              "食生活がかなり偏っている可能性があります。免疫力低下・肌荒れ・疲労感などが出やすい状態です。\n" +
              "早急に以下の改善を取り入れましょう：\n\n" +
              "1. 主食だけで済ませず、必ずたんぱく質と野菜を加える\n" +
              "2. 加工食品・揚げ物・スナック菓子の頻度を週1回以下に抑える\n" +
              "3. 野菜・果物を毎日摂取し、色の濃い野菜を中心にする\n" +
              "4. 水分をこまめに摂り、ジュースや甘い飲料は控える\n" +
              "5. 朝食をしっかり摂り、1日3食のリズムを整えることで代謝を安定させる";

            }

            // 凡例
            chart1.Legends[0].BackColor = Color.Transparent;
            chart1.Legends[0].Font = new Font("Meiryo", 10);
        }

        private void chart1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(); // Form2 のインスタンスを作成
            form5.Show();              // Form2 を表示
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(); // Form2 のインスタンスを作成
            form3.Show();              // Form2 を表示
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 終了ボタンの処理
            button3.Location = new Point(50, 100);
            Application.Exit();
        }
    }
}