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
    }
}
