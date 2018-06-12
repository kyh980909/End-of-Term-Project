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
    public partial class InitialGameMenu : Form
    {
        public InitialGameMenu()
        {
            InitializeComponent();
        }

        private void GameInfo_Click(object sender, EventArgs e) // 게임정보 버튼 이벤트
        {

        }

        private void GameEnd_Click(object sender, EventArgs e) // 게임종료 버튼 이벤트
        {
            Form1 form1 = new Form1();  // Form1의 visible을 True로 바꿔주기 위해 생성
            form1.Visible = true;       // Form1 보여줌
            Close(); // 현재 폼을 닫는다.
        }

        private void GameStart_Click(object sender, EventArgs e)    // GameStart 버튼 이벤트
        {
            Visible = false;                // 현재 폼 감추기
            InitialGameSelect selectForm = new InitialGameSelect(); // InitialGameSelect폼 클래스 생성
            selectForm.stage2.Enabled = false;
            selectForm.stage3.Enabled = false;
            selectForm.stage4.Enabled = false;
            selectForm.stage5.Enabled = false;
            selectForm.ShowDialog();        // InitialGameSelect폼 열기

        }
    }
}
