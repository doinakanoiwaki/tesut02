using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tesut02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 画面を最大化
            this.WindowState = FormWindowState.Maximized;
            this.Text = "健康を知ろう - Nutrient Checker";

            // 背景画像設定
        
            string bgPath = Application.StartupPath + @"\A_2D.png";
            this.BackgroundImage = Image.FromFile(bgPath);
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // 半透明パネル（やや暗めのグレー）
            Panel overlay = new Panel();
            overlay.BackColor = Color.FromArgb(100, 230, 230, 230); // 薄いグレーで背景を落ち着かせる
            overlay.Dock = DockStyle.Fill;
            this.Controls.Add(overlay);

            // タイトルラベル
            Label title = new Label();
            title.Text = "健康を知ろう";
            title.Font = new Font("Yu Gothic UI", 48, FontStyle.Bold);
            title.ForeColor = Color.FromArgb(0, 60, 120); // 濃い青
            title.BackColor = Color.Transparent;
            title.AutoSize = true;
            title.Location = new Point((this.ClientSize.Width / 2) - 200, 100);
            title.Anchor = AnchorStyles.Top;
            overlay.Controls.Add(title);

            // ボタン群
            FlowLayoutPanel btnPanel = new FlowLayoutPanel();
            btnPanel.FlowDirection = FlowDirection.TopDown;
            btnPanel.BackColor = Color.Transparent;
            btnPanel.Anchor = AnchorStyles.None;
            btnPanel.Size = new Size(300, 400);
            btnPanel.Location = new Point(
                (this.ClientSize.Width - btnPanel.Width) / 2,
                (this.ClientSize.Height - btnPanel.Height) / 2 + 100
            );

            // ボタン作成
            Button btnMenu = CreateStyledButton("メニュー");
            btnMenu.Click += (s, ev) => { new Form2().Show(); this.Hide(); };
            btnPanel.Controls.Add(btnMenu);

            Button btnQuiz = CreateStyledButton("クイズ");
            btnQuiz.Click += (s, ev) => { new Form3().Show(); this.Hide(); };
            btnPanel.Controls.Add(btnQuiz);

            Button btnAccount = CreateStyledButton("アカウント");
            btnAccount.Click += (s, ev) => { new Form5().Show(); this.Hide(); };
            btnPanel.Controls.Add(btnAccount);

            Button btnExit = CreateStyledButton("終了");
            btnExit.BackColor = Color.FromArgb(255, 100, 100);
            btnExit.ForeColor = Color.White;
            btnExit.Click += (s, ev) => Application.Exit();
            btnPanel.Controls.Add(btnExit);

            overlay.Controls.Add(btnPanel);

            // 注意書き
            Label note = new Label();
            note.Text = "※このアプリはあくまで指標なので重く受け止めないでください。";
            note.Font = new Font("Yu Gothic UI", 12);
            note.ForeColor = Color.DarkRed;
            note.BackColor = Color.Transparent;
            note.AutoSize = true;
            note.Anchor = AnchorStyles.Bottom;
            note.Location = new Point(50, this.ClientSize.Height - 60);
            overlay.Controls.Add(note);
        }

        private Button CreateStyledButton(string text)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Font = new Font("Yu Gothic UI", 18, FontStyle.Bold);
            btn.Size = new Size(250, 60);
            btn.Margin = new Padding(15);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 2;
            btn.FlatAppearance.BorderColor = Color.FromArgb(0, 90, 160);
            btn.BackColor = Color.FromArgb(255, 255, 255, 240); // 薄い白
            btn.ForeColor = Color.FromArgb(0, 64, 128);
            btn.Cursor = Cursors.Hand;

            // 影をつけて立体感を出す
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 240, 255);
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 230, 250);
            return btn;
        }
    }
}
