
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tesut02
{
    public partial class Form5 : Form
    {
        private string registeredName = "";
        private string accountFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "account.txt");

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Text = "健康を知ろう - Nutrient Checker";
            LoadAccountName();
        }

        private void LoadAccountName()
        {
            if (File.Exists(accountFilePath))
            {
                registeredName = File.ReadAllText(accountFilePath);
                label1.Text = registeredName;
            }
        }

        private void SaveAccountName(string name)
        {
            File.WriteAllText(accountFilePath, name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormⅣ formⅣ = new FormⅣ();
            formⅣ.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "編集")
            {
                textBox1.Visible = true;
                textBox1.ReadOnly = false;
                textBox1.BackColor = Color.White;
                textBox1.BorderStyle = BorderStyle.FixedSingle;
                button2.Text = "登録";
                return;
            }

            registeredName = textBox1.Text;
            label1.Text = registeredName;
            SaveAccountName(registeredName);

            textBox1.Visible = false;
            button2.Text = "編集";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}

