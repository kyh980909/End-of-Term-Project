using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPhone
{
    public partial class RealTimeKeyWordApp : Form
    {
        Panel panel = new Panel();
        string[] KeywordRank = new string[20];
        string[] KeywordRank1 = new string[10];
        string[] KeywordRank2 = new string[10];

        RealTimeKeyWord keyword = new RealTimeKeyWord();
        
        int i = 0;

        public RealTimeKeyWordApp()
        {
            InitializeComponent();

            Controls.Add(panel);

            panel.Size = new Size(308, 433);
            panel.Location = new Point(12, 68);
            panel.SendToBack();
            panel.BackColor = Color.LemonChiffon;
            panel.BorderStyle = BorderStyle.Fixed3D;

            KeywordRank = keyword.Keyword();

            for (int k = 0; k < 10; k++)
                KeywordRank1[k] = KeywordRank[k];

            for (int k = 10; k < 20; k++)
                KeywordRank2[k - 10] = KeywordRank[k];

            foreach (var item in KeywordRank1)
            {
                Label label = new Label();
                Controls.Add(label);
                label.Font = new Font("돋움", 11);
                //label.Font = true;
                label.BringToFront();
                label.AutoSize = true;
                label.BackColor = Color.LemonChiffon;
                label.Location = new Point(20, 80 + i * 40);
                label.Text = i + 1 + "." +item;
                i++;
            }
            i = 0;
            foreach (var item in KeywordRank2)
            {
                Label label = new Label();
                Controls.Add(label);
                label.Font = new Font("돋움", 11);
                label.BringToFront();
                label.AutoSize = true;
                label.BackColor = Color.LemonChiffon;
                label.Location = new Point(180, 80 + i * 40);
                label.Text = i + 11 + "." + item;
                i++;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();   // Form1폼 클래스 생성
            form1.Visible = true;        // Form1폼을 보이게 함
            Close();
        }
    }
}
