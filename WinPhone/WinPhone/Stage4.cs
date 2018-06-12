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
    public partial class Stage4 : Form
    {
        int num = 0;
        Quiz quiz = new Quiz();
        public Stage4()
        {
            InitializeComponent();

            Question.Text = quiz.Question4[num, 0];
            Hint1.Text = quiz.Hint4[num, 0];
            Hint2.Text = quiz.Hint4[num, 1];
            Input.SelectionAlignment = HorizontalAlignment.Center;  // RichTextBox 가운데 정렬
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            MenuPanel.Visible = true;                             // MenuPanel을 보여줌
            Complete.Enabled = false;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();                                              // 현재 폼 닫기
            InitialGameSelect select = new InitialGameSelect();   // InitialGameSelect폼 생성
            select.Visible = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MenuPanel.Visible = false;
            Complete.Enabled = true;
        }

        private void Complete_Click(object sender, EventArgs e)
        {
            try
            {
                if (quiz.Question4[num, 1] == Input.Text)        // 문제와 입력받을 값을 비교
                {
                    num++;                                      // 문제 정답을 맞췄을 때 문제 번호 1 증가
                    MessageBox.Show("정답입니다!!");
                    if (num < 5)
                    {
                        Question.Text = quiz.Question4[num, 0]; // 다음 문제로 넘어가기
                        Hint1.Text = quiz.Hint4[num, 0];        // 다음 힌트로 넘어가기
                        Hint2.Text = quiz.Hint4[num, 1];        // 다음 힌트로 넘어가기
                        Input.Clear();                          // 텍스트 박스 초기화
                        progressBar1.PerformStep();             // progressBar1 한칸 채우기       
                    }

                    if (num == 5)   // 문제를 다 맞췄을 때 조건
                    {
                        progressBar1.PerformStep();             // progressBar1 한칸 채우기
                        MessageBox.Show("스테이지 클리어!!");
                        MenuPanel.Visible = true;               // MenuPanel 숨기기
                        Complete.Enabled = false;
                        InitialGameSelect.check4 = true;
                    }
                }
                else
                {
                    MessageBox.Show("오답입니다ㅠㅠ");
                    Input.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("다 푸셨어요!!");
            }
        }
    }
}
