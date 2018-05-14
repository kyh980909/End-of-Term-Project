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

            celcius.Country(SelectedCountry);                        // GetCelcius 클래스에 있는 Country 메서드에 선택한 지역구를 넘겨줌

            villageList = getVillage.village(SelectedCountry);       // 선택된 구에 따른 동의 리스트를 반환해주는 메서드를 통해 villageList리스트에 대입

            SelectVillage.Items.Clear();                             // 구를 선택하는 콤보박스가 선택 되었을 때 동을 선택하는 콤보박스의 리스트를 초기화 - 구를 선택할 때 마다 동들이 계속 추가되는 것을 방지

            switch (SelectedCountry)
            {
                case "강남구":
                    foreach (var item in villageList)               // 선택된 구에 따른 동들을 콤보박스에 추가
                        SelectVillage.Items.Add(item);
                    break;
                case "강동구":
                    foreach (var item in villageList)
                        SelectVillage.Items.Add(item);
                    break;
                case "강북구":
                    foreach (var item in villageList)
                        SelectVillage.Items.Add(item);
                    break;
                case "강서구":
                    foreach (var item in villageList)
                        SelectVillage.Items.Add(item);
                    break;
                case "관악구":
                    foreach (var item in villageList)
                        SelectVillage.Items.Add(item);
                    break;
                case "광진구":
                    foreach (var item in villageList)
                        SelectVillage.Items.Add(item);
                    break;
                case "구로구":
                    foreach (var item in villageList)
                        SelectVillage.Items.Add(item);
                    break;
                case "금천구":
                    foreach (var item in villageList)
                        SelectVillage.Items.Add(item);
                    break;
                case "노원구":
                    foreach (var item in villageList)
                        SelectVillage.Items.Add(item);
                    break;
                case "도봉구":
                    foreach (var item in villageList)
                        SelectVillage.Items.Add(item);
                    break;
                case "동대문구":
                    foreach (var item in villageList)
                        SelectVillage.Items.Add(item);
                    break;
                case "동작구":
                    foreach (var item in villageList)
                        SelectVillage.Items.Add(item);
                    break;
                case "마포구":
                    foreach (var item in villageList)
                        SelectVillage.Items.Add(item);
                    break;
                case "서대문구":
                    foreach (var item in villageList)
                        SelectVillage.Items.Add(item);
                    break;
                case "서초구":
                    foreach (var item in villageList)
                        SelectVillage.Items.Add(item);
                    break;
                case "성동구":
                    foreach (var item in villageList)
                        SelectVillage.Items.Add(item);
                    break;
                case "성북구":
                    foreach (var item in villageList)
                        SelectVillage.Items.Add(item);
                    break;
                case "송파구":
                    foreach (var item in villageList)
                        SelectVillage.Items.Add(item);
                    break;
                case "양천구":
                    foreach (var item in villageList)
                        SelectVillage.Items.Add(item);
                    break;
                case "영등포구":
                    foreach (var item in villageList)
                        SelectVillage.Items.Add(item);
                    break;
                case "용산구":
                    foreach (var item in villageList)
                        SelectVillage.Items.Add(item);
                    break;
                case "은평구":
                    foreach (var item in villageList)
                        SelectVillage.Items.Add(item);
                    break;
                case "종로구":
                    foreach (var item in villageList)
                        SelectVillage.Items.Add(item);
                    break;
                case "중구":
                    foreach (var item in villageList)
                        SelectVillage.Items.Add(item);
                    break;
                case "중랑구":
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
