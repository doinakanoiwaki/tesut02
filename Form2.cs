using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace tesut02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Load += Form2_Load;
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

        private void Form2_Load(object sender, EventArgs e)
        {
            DesignButton(button1);
        }

        private void DesignButton(Button btn)
        {
            // テキスト（必要なら変更）
            // btn.Text = "スタート";

            // フォント（おしゃれ寄り・標準で入ってる）
            btn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);

            // ベースカラー（落ち着いたブルー）
            btn.BackColor = Color.FromArgb(74, 144, 226);
            btn.ForeColor = Color.White;

            // フラット化（枠線なし）
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

            // ホバー/押下時の色
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 134, 216);
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(54, 124, 206);

            // 角丸（Load時 + サイズ変更時も維持）
            int radius = 18;
            btn.Region = new Region(GetRoundPath(btn.ClientRectangle, radius));
            btn.Resize += (s, e) =>
            {
                btn.Region = new Region(GetRoundPath(btn.ClientRectangle, radius));
            };

            // 文字位置（中央）
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
