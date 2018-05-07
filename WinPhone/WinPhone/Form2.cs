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
    public partial class Form2 : Form
    {
        GetCelcius celcius = new GetCelcius();

        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            celcius.Country(comboBox2.SelectedItem.ToString());     // 콤보박스에서 어떤 구인지 선택하면 GetCelcius 클래스에 Country메서드에 선택한 지역구 를 넘겨줌 
        }

        private void Select_Click(object sender, EventArgs e)
        {
            ((Form1)(this.Owner)).Country.Text = celcius.country;    // Form1의 County 라벨의 접근제한자를 public으로 변경하여 사용
            ((Form1)(this.Owner)).Celcius.Text = celcius.Celcius();  // Form1의 Celcius 라벨의 접근제한자를 public으로 변경하여 사용
            this.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            celcius.Villege(comboBox3.SelectedItem.ToString());
        }
    }
}
