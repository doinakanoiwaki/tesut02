using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void FormⅣ_Load(object sender, EventArgs e)
        {
            // フォームを最大化して表示
            this.WindowState = FormWindowState.Maximized;

            // Chartの初期化
            chart1.Series.Clear();
  
            // 新しい系列を作成
            Series series = new Series("データ")
            {
                ChartType = SeriesChartType.Column
            };


            // ラジオボタンの選択に応じてデータを変える
            switch (selectedOption)
            {
                // Option1が選ばれた場合のデータ
                case "Option1":
                    series.Points.AddXY("A", 10);
                    series.Points.AddXY("B", 20);
                    series.Points.AddXY("C", 30);
                    break;

                case "Option2":
                    series.Points.AddXY("X", 5);
                    series.Points.AddXY("Y", 15);
                    series.Points.AddXY("Z", 25);
                    break;

                case "Option3":
                    series.Points.AddXY("P", 12);
                    series.Points.AddXY("Q", 18);
                    series.Points.AddXY("R", 24);
                    break;

            }
            // Chartに系列を追加して表示
            chart1.Series.Add(series);

        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }

}
