using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPhone
{
    class Quiz1
    {
        public string[,] Question =   // 문제와 답 2차원 배열 생성
        {
            { "ㅅㅍㄱ" , "선풍기"},
            { "ㅈㅇㄱ", "주인공"},
            { "ㅎㅁ", "희망"},
            { "ㄷㄱㄴㄱ", "동갑내기" },
            { "ㅂㄹㅊㄱ", "벼락치기" }
        };

        public string[,] Hint =        // 힌트 2차원 배열 생성
        {
            {"바람", "여름"},
            {"중심인물", "소설의" },
            {"가능성", "꿈"},
            {"친구", "또래" },
            {"날림", "서둘러" }
        };
        
    }
}
