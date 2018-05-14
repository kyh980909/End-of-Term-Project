using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WinPhone
{
    class ChangeVillage
    {
        public List<string> village(string country)                 // 리스트를 반환하고 매개변수로 자료형이 문자열인 변수를 받아서 처리하는 메서드를 만듦
        {
            StreamReader file = new StreamReader(country + ".txt"); // 파일 입출력 클래스 생성
            List<string> villageList = new List<string>();          // 문자열 리스트 생성
            string str;                                             // 파일입출력 과정에서 문자열을 하나씩 임시로 받아올 변수 선언
            int i = 0;                                              // 줄을 구분할 변수 선언

            while (true)                                            // 파일이 몇 줄이 있는지 모르기 때문에 무한반복
            {
                str = file.ReadLine();                              // 파일에서 읽어들인 내용을 str 변수에 저장
                if (str == null)                                    // while문이 돌다가 null을 만나면 무한루프를 빠져나옴
                    break;

                i++;                                                // while문이 한 번 돌 때마다 1씩 증가
                villageList.Add(str);                               // 리스트에 파일에서 읽어들인 내용을 추가
            }
            file.Close();                                           // 파일스트림 닫기

            return villageList;                                     // villageList 반환
        }
    }
}
