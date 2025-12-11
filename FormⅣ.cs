using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace tesut02
{
    // グラフを表示するフォーム
    public partial class FormⅣ : Form
    {
        private string selectedOption; // Form3から受け取る値

        public FormⅣ(string option)
        {
            InitializeComponent();
            selectedOption = option;
        }

        public FormⅣ()
        {
            InitializeComponent();
            selectedOption = "Option1"; // デフォルト値を設定（必要なら）
        }

        private void FormⅣ_Load(object sender, EventArgs e)
        {
            // フォームを最大化して表示
            this.WindowState = FormWindowState.Maximized;

            int sum = 0;

            chart1.Series.Clear();
            Series series = new Series("データ");
            series.ChartType = SeriesChartType.Column;

            // ラジオボタン選択に応じてデータ切り替え
            switch (selectedOption)
            {
                case "Option1":
                    series.Points.AddXY("非常に当てはまる", 1);
                    break;

                case "Option2":
                    series.Points.AddXY("当てはまる", 1);
                    break;

                case "Option3":
                    series.Points.AddXY("どちらでもない", 1);
                    break;

                case "Option4":
                    series.Points.AddXY("当てはまらない", 1);
                    break;

                case "Option5":
                    series.Points.AddXY("まったく当てはまらない", 1);
                    break;
            }

            chart1.Series.Add(series);

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