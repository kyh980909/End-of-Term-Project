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
        int num = 0;
        Quiz1 quiz = new Quiz1();
        public Stage1()
        {
            InitializeComponent();


            Question.Text = quiz.Question[num, 0];
            Hint1.Text = quiz.Hint[num, 0];
            Hint2.Text = quiz.Hint[num, 1];

        }

        private void Menu_Click(object sender, EventArgs e)     // Menu 이미지 클릭 이벤트
        {
            MenuPanel.Visible = true;                           // MenuPanel을 보여줌
        }

        private void ExitButton_Click(object sender, EventArgs e) // ExitButton버튼 이벤트
        {
            Close();                                            // 현재 폼 닫기
            InitialGameSelect select = new InitialGameSelect(); // InitialGameSelect폼 생성
            select.Visible = true;                              // InitialGameSelect 보여줌
        }

        private void Complete_Click(object sender, EventArgs e)
        {
            if (quiz.Question[num,1] == Input.Text)
            {
                MessageBox.Show("정답입니다!!");
                if(num < 4)
                    num++;
                Question.Text = quiz.Question[num, 0];
                Hint1.Text = quiz.Hint[num, 0];
                Hint2.Text = quiz.Hint[num, 1];
                Input.Clear();
            }
            else
            {
                MessageBox.Show("오답입니다ㅠㅠ");
                Input.Clear();
            }
        }
    }
}
