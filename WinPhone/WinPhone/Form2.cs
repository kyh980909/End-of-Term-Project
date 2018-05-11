using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinPhone
{
    public partial class Form2 : Form
    {
        GetCelcius celcius = new GetCelcius();
        ChangeVillage getVillage = new ChangeVillage(); //구 에 따른 동들 불러오는 클래스

        public Form2()
        {
            InitializeComponent();
        }

        private void SelectCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedCountry; // 선택된 구를 저장할 변수
            List<string> villageList = new List<string>();

            SelectedCountry = SelectCountry.SelectedItem.ToString(); // 콤보박스에서 선택한 구를 저장

            celcius.Country(SelectedCountry);     // GetCelcius 클래스에 있는 Country 메서드에 선택한 지역구를 넘겨줌

            villageList = getVillage.village(SelectedCountry);  // 선택된 구에 따른 동의 리스트를 반환해주는 메서드를 통해 villageList에 리스트 대입
            

            switch (SelectedCountry)
            {
                case "강남구":
                    foreach (var item in villageList)       // 콤보박스 초기화
                        SelectVillage.Items.Remove(item);   
                    foreach (var item in villageList)       // 선택된 구에 따른 동 들을 콤보박스에 추가
                        SelectVillage.Items.Add(item);
                    break;
                case "강동구":
                    foreach (var item in villageList)       // 콤보박스 초기화
                        SelectVillage.Items.Remove(item);
                    foreach (var item in villageList)
                        SelectVillage.Items.Add(item);
                    break;
                default:
                    break;
            }
        }

        private void Select_Click(object sender, EventArgs e)
        {
            ((Form1)(this.Owner)).Country.Text = celcius.country;    // Form1의 County 라벨의 접근제한자를 public으로 변경하여 사용
            ((Form1)(this.Owner)).Celcius.Text = celcius.Celcius();  // Form1의 Celcius 라벨의 접근제한자를 public으로 변경하여 사용
            this.Close();
        }

        private void SelectVillage_SelectedIndexChanged(object sender, EventArgs e)
        {
            celcius.Villege(SelectVillage.SelectedItem.ToString());
        }
    }
}
