using System;
using System.Collections.Generic;
using System.Drawing;
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