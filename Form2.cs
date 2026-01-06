using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace tesut02
{
    public partial class Form2 : Form
    {
        private MonthCalendar calendar;
        private Label todayLabel;
        private Panel resultPanel;
        private Label resultTitle;
        private Button startButton;
        private PictureBox userIcon;

        public Form2()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            this.Load += Form2_Load;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Text = "健康チェック - ホーム";

            this.BackColor = Color.White;

            // カレンダー
            calendar = new MonthCalendar();
            calendar.Location = new Point(50, 50);
            calendar.MaxSelectionCount = 1;
            calendar.TodayDate = DateTime.Today;
            calendar.SelectionStart = DateTime.Today;
            calendar.Font = new Font("Meiryo", 10);
            this.Controls.Add(calendar);

            // 今日の日付ラベル
            todayLabel = new Label();
            todayLabel.Text = $"今日: {DateTime.Today:yyyy/MM/dd}";
            todayLabel.Font = new Font("Meiryo", 12, FontStyle.Bold);
            todayLabel.Location = new Point(50, calendar.Bottom + 10);
            todayLabel.AutoSize = true;
            this.Controls.Add(todayLabel);

            // 結果パネル
            resultPanel = new Panel();
            resultPanel.BackColor = Color.FromArgb(0, 102, 204); // 青系
            resultPanel.Size = new Size(400, 300);
            resultPanel.Location = new Point(calendar.Right + 50, 50);
            this.Controls.Add(resultPanel);

            // 結果タイトル
            resultTitle = new Label();
            resultTitle.Text = "今日の結果";
            resultTitle.Font = new Font("Meiryo", 18, FontStyle.Bold);
            resultTitle.ForeColor = Color.Yellow;
            resultTitle.BackColor = Color.Transparent;
            resultTitle.Location = new Point(30, 30);
            resultTitle.AutoSize = true;
            resultPanel.Controls.Add(resultTitle);

            // スタートボタン
            startButton = new Button();
            startButton.Text = "質問を開始する";
            startButton.Size = new Size(250, 50);
            startButton.Location = new Point((this.ClientSize.Width - startButton.Width) / 2, this.ClientSize.Height - 120);
            startButton.Anchor = AnchorStyles.Bottom;
            startButton.Click += button1_Click;
            DesignButton(startButton);
            this.Controls.Add(startButton);

            // ユーザーアイコン
            userIcon = new PictureBox();
            userIcon.Size = new Size(60, 60);
            userIcon.Location = new Point(this.ClientSize.Width - 80, 20);
            userIcon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            userIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            userIcon.Image = Image.FromFile(Application.StartupPath + @"\user_icon.png"); // アイコン画像を配置
            userIcon.Cursor = Cursors.Hand;
            userIcon.Click += pictureBox1_Click;
            this.Controls.Add(userIcon);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void DesignButton(Button btn)
        {
            btn.Font = new Font("Meiryo", 12F, FontStyle.Bold);
            btn.BackColor = Color.FromArgb(74, 144, 226);
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 134, 216);
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(54, 124, 206);

            int radius = 18;
            btn.Region = new Region(GetRoundPath(btn.ClientRectangle, radius));
            btn.Resize += (s, e) =>
            {
                btn.Region = new Region(GetRoundPath(btn.ClientRectangle, radius));
            };
            btn.TextAlign = ContentAlignment.MiddleCenter;
        }

        private GraphicsPath GetRoundPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            return path;
        }

    }
}