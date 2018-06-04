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
    public partial class Form1 : Form
    {
        GetCelcius celcius = new GetCelcius();  // 현재 온도를 가져오는 클래스 생성

        public Form1()
        {            
            InitializeComponent();
            Date.Text = DateTime.Today.Year.ToString() + "년 " + DateTime.Today.Month.ToString() + "월 " + DateTime.Today.Day.ToString() + "일"; // Date라벨에 오늘 날짜를 표시
            Time.Text = DateTime.Now.ToShortTimeString();   // Time라벨에 현재 시간 표시
            CelciusLabel.Text = celcius.Celcius();          // CelciusLabel라벨에 현재 온도 표시
            CountryLabel.Text = celcius.countryValue;       // CountryLabel라벨에 선택한 구 표시
            VillageLabel.Text = celcius.villegeValue;       // VillageLabel라벨에 선택한 동 표시
        }

        private void CurrentTimeTick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToShortTimeString();   // 타이머가 1초마다 현재 시간을 업데이트 해줌
        }

        private void CelciusLabel_Click(object sender, EventArgs e)     // CelciusLabel을 클릭 이벤트
        {
            Form2 form2 = new Form2();    // Form2 클래스 생성

            form2.ShowDialog();       // Form2를 보여줌                  
        }

        private void ShutDown_Click(object sender, EventArgs e)     // 종료 버튼 이미지 클릭 이벤트
        {
            Application.Exit();                                     // 윈폼 종료 메서드
        }

        private void GameApp_Click(object sender, EventArgs e)      // GameApp 버튼 이벤트
        {
            Visible = false;        // 현재 폼 감추기
            InitialGameMenu gamemenu = new InitialGameMenu();       // InitialGameMenu폼 클래스 생성
            gamemenu.ShowDialog();      // InitialGameMenu폼 열기 
        }
    }
}
