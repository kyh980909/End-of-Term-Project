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
    public partial class Stage1 : Form
    {
        int num = 0;                // 문제 번호
        bool clearCheck = false;    // 클리어 체크
        Quiz quiz = new Quiz();
        public Stage1()
        {
            InitializeComponent();

            Question.Text = quiz.Question1[num, 0];
            Hint1.Text = quiz.Hint1[num, 0];
            Hint2.Text = quiz.Hint1[num, 1];
        }

        private void Menu_Click(object sender, EventArgs e)       // Menu 이미지 클릭 이벤트
        {
            MenuPanel.Visible = true;                             // MenuPanel을 보여줌
        }

        private void ExitButton_Click(object sender, EventArgs e) // ExitButton버튼 이벤트
        {
            Close();                                              // 현재 폼 닫기
            InitialGameSelect select = new InitialGameSelect();   // InitialGameSelect폼 생성
            select.Visible = true;                                // InitialGameSelect 보여줌
        }

        private void Complete_Click(object sender, EventArgs e)
        {
            if (quiz.Question1[num,1] == Input.Text)
            {
                if (num < 4)    // 인덱스 범위 초과 예외 처리
                {
                    MessageBox.Show("정답입니다!!");
                    num++;
                    Question.Text = quiz.Question1[num, 0];
                    Hint1.Text = quiz.Hint1[num, 0];
                    Hint2.Text = quiz.Hint1[num, 1];
                    Input.Clear();
                    progressBar1.PerformStep();
                }          
                if (num == 5)   // 문제를 다 맞췄을 때 조건
                {
                    MessageBox.Show("스테이지 클리어!!");
                    MenuPanel.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("오답입니다ㅠㅠ");
                Input.Clear();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MenuPanel.Visible = false;
        }
    }
}
