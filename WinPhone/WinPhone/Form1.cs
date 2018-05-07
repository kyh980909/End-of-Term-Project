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
            Celcius.Text = celcius.Celcius();
            Country.Text = celcius.country;
        }

        private void CurrentTimeTick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToShortTimeString();   // 타이머가 1초마다 현재 시간을 업데이트 해줌
        }

        private void Celcius_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.ShowDialog(this);
        }
    }
}
