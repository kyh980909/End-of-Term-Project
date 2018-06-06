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
    public partial class InitialGameSelect : Form
    {
        public InitialGameSelect()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)     // 뒤로가기 이미지 클릭 이벤트
        {
            InitialGameMenu gameMenu = new InitialGameMenu();   // InitialGameMenu폼 클래스 생성
            gameMenu.Visible = true;                            // InitialGameMenu폼을 보이게 함
            Close();                                            // 현재 폼 닫음
        }

        private void Stage1_Click(object sender, EventArgs e)   // Stage1 버튼 이벤트
        {
            Visible = false;                                    // 현재 폼 감추기
            Stage1 stage1 = new Stage1();                       // Stage1폼 클래스 생성
            stage1.ShowDialog();                                // Stage1폼 열기
        }

        private void Stage2_Click(object sender, EventArgs e)   // Stage2 버튼 이벤트
        {
            Visible = false;                                    // 현재 폼 감추기
            Stage2 stage2 = new Stage2();                       // Stage2폼 클래스 생성
            stage2.ShowDialog();                                // Stage2폼 열기
        }

        private void Stage3_Click(object sender, EventArgs e)
        {
            Visible = false;                                    // 현재 폼 감추기
            Stage3 stage3 = new Stage3();                       // Stage3폼 클래스 생성
            stage3.ShowDialog();
        }

        private void Stage4_Click(object sender, EventArgs e)
        {
            Visible = false;                                    // 현재 폼 감추기
            Stage4 stage4 = new Stage4();                       // Stage4폼 클래스 생성
            stage4.ShowDialog();
        }

        private void Stage5_Click(object sender, EventArgs e)
        {
            Visible = false;                                    // 현재 폼 감추기
            Stage5 stage5 = new Stage5();                       // Stage5폼 클래스 생성
            stage5.ShowDialog();
        }
    }
}
