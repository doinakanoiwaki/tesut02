using System;
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

            chart1.Series.Clear();
            Series series = new Series("データ");
            series.ChartType = SeriesChartType.Column;

            // ラジオボタン選択に応じてデータ切り替え
            switch (selectedOption)
            {
                case "Option1":
                    series.Points.AddXY("A", 10);
                    break;

                case "Option2":
                    series.Points.AddXY("X", 5);
                    break;

                case "Option3":
                    series.Points.AddXY("P", 12);
                    break;

                case "Option4":
                    series.Points.AddXY("M", 8);
                    break;

                case "Option5":
                    series.Points.AddXY("U", 20);
                    break;
            }

            chart1.Series.Add(series);

        }

        private void chart1_Click(object sender, EventArgs e)
        {
        }
    }
}