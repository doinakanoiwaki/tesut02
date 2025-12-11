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

            // グラフ初期化
            chart1.Series.Clear();
            Series series = new Series("回答集計");
            series.ChartType = SeriesChartType.Column;

            // ★回答1〜5の集計
            int[] count = new int[5];
            foreach (int a in answers)
            {
                if (a >= 1 && a <= 5)
                    count[a - 1]++;
            }

            // ★グラフに反映
            series.Points.AddXY("非常に当てはまる(1)", count[0]);
            series.Points.AddXY("当てはまる(2)", count[1]);
            series.Points.AddXY("どちらでもない(3)", count[2]);
            series.Points.AddXY("当てはまらない(4)", count[3]);
            series.Points.AddXY("まったく当てはまらない(5)", count[4]);

            chart1.Series.Add(series);

            // 見やすいようにフォント調整
            chart1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Meiryo", 12);
            chart1.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Meiryo", 12);


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