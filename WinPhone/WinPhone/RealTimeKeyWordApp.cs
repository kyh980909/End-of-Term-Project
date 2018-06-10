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
        Panel panel = new Panel();              // Panel 객체 생성
        string[] KeywordRank = new string[20];  // 실시간 검색어를 저장할 문자열 배열
        string[] KeywordRank1 = new string[10]; // 실검 1~10위 저장
        string[] KeywordRank2 = new string[10]; // 실검 11~20위 저장

        RealTimeKeyWord keyword = new RealTimeKeyWord();    // 실시간 검색어 클래스 생성
        
        int i = 0;  // 배열 인덱스용

        public RealTimeKeyWordApp()
        {
            InitializeComponent();

            Controls.Add(panel);    // panel 추가

            panel.Size = new Size(308, 400);        // panel 사이즈
            panel.Location = new Point(12, 68);     // panel 위치
            panel.SendToBack();                     // panel을 맨뒤로 보내기
            panel.BackColor = Color.LemonChiffon;   // panel 배경색 변경
            panel.BorderStyle = BorderStyle.Fixed3D;// panel 테두리 스타일 변경

            KeywordRank = keyword.Keyword();        // 실검 클래스에 있는 메서드를 사용해 문자열 배열에 저장

            for (int k = 0; k < 10; k++)            // 1~10위 저장
                KeywordRank1[k] = KeywordRank[k];

            for (int k = 10; k < 20; k++)           // 11~20위 저장
                KeywordRank2[k - 10] = KeywordRank[k];

            foreach (var item in KeywordRank1)      // 1~10위 실검을 나타낼 라벨을 동적으로 생성
            {
                Label label = new Label();          // 라벨 클래스 생성
                Controls.Add(label);                // 라벨 추가
                label.Font = new Font("돋움", 11);  // 라벨 글씨체, 글자크기 변경
                label.BringToFront();               // 라벨을 맨 앞으로
                label.AutoSize = true;              // 라벨의 사이즈를 자동으로 조절
                label.BackColor = Color.LemonChiffon;   // 라벨 배경색 변경
                label.Location = new Point(20, 80 + i * 40);        // 라벨 포지션 지정
                label.Text = i + 1 + "." +item;     // 라벨에 실검 순위별로 저장
                i++;                                // 다음 값으로
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
                label.Location = new Point(155, 80 + i * 40);
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

        private void refresh_Click(object sender, EventArgs e)
        {
            i = 0;

            KeywordRank = keyword.Keyword();        // 실검 클래스에 있는 메서드를 사용해 문자열 배열에 저장

            for (int k = 0; k < 10; k++)            // 1~10위 저장
                KeywordRank1[k] = KeywordRank[k];

            for (int k = 10; k < 20; k++)           // 11~20위 저장
                KeywordRank2[k - 10] = KeywordRank[k];

            foreach (var item in KeywordRank1)      // 1~10위 실검을 나타낼 라벨을 동적으로 생성
            {
                Label label = new Label();          // 라벨 클래스 생성
                Controls.Add(label);                // 라벨 추가
                label.Font = new Font("돋움", 11);  // 라벨 글씨체, 글자크기 변경
                label.BringToFront();               // 라벨을 맨 앞으로
                label.AutoSize = true;              // 라벨의 사이즈를 자동으로 조절
                label.BackColor = Color.LemonChiffon;   // 라벨 배경색 변경
                label.Location = new Point(20, 80 + i * 40);        // 라벨 포지션 지정
                label.Text = i + 1 + "." + item;     // 라벨에 실검 순위별로 저장
                i++;                                // 다음 값으로
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
                label.Location = new Point(155, 80 + i * 40);
                label.Text = i + 11 + "." + item;
                i++;
            }

            MessageBox.Show("새로고침 되었습니다!");
        }
    }
}
