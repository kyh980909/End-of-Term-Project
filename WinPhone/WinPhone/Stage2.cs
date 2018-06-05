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
    public partial class Stage2 : Form
    {
        int num = 0;
        Quiz quiz = new Quiz();
        public Stage2()
        {
            InitializeComponent();

            Question.Text = quiz.Question2[num, 0];
            Hint1.Text = quiz.Hint2[num, 0];
            Hint2.Text = quiz.Hint2[num, 1];
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            MenuPanel.Visible = true;                             // MenuPanel을 보여줌
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();                                              // 현재 폼 닫기
            InitialGameSelect select = new InitialGameSelect();   // InitialGameSelect폼 생성
            select.Visible = true;                                // InitialGameSelect 보여줌
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MenuPanel.Visible = false;
        }

        private void Complete_Click(object sender, EventArgs e)
        {
            if (quiz.Question2[num, 1] == Input.Text)
            {
                MessageBox.Show("정답입니다!!");
                if (num < 4)
                    num++;
                Question.Text = quiz.Question2[num, 0];
                Hint1.Text = quiz.Hint2[num, 0];
                Hint2.Text = quiz.Hint2[num, 1];
                Input.Clear();
                progressBar1.PerformStep();

            }
            else
            {
                MessageBox.Show("오답입니다ㅠㅠ");
                Input.Clear();
            }
        }
    }
}
