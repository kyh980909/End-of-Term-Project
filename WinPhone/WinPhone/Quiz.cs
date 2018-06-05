using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPhone
{
    class Quiz
    {
        public string[,] Question1 =   // 문제와 답 2차원 배열 생성
        {
            { "ㅅㅍㄱ" , "선풍기"},
            { "ㅈㅇㄱ", "주인공"},
            { "ㅎㅁ", "희망"},
            { "ㄷㄱㄴㄱ", "동갑내기" },
            { "ㅂㄹㅊㄱ", "벼락치기" }
        };

        public string[,] Hint1 =        // 힌트 2차원 배열 생성
        {
            {"바람", "여름"},
            {"중심인물", "소설의" },
            {"가능성", "꿈"},
            {"친구", "또래" },
            {"날림", "서둘러" }
        };

        public string[,] Question2 =   // 문제와 답 2차원 배열 생성
        {
            { "ㅇㄷㅇ" , "열대야"},
            { "ㅂㅁㄹ", "부메랑"},
            { "ㄱㄱㄷ", "구구단"},
            { "ㅂㅇㅆㄱ", "받아쓰기" },
            { "ㅂㄷ", "변덕" }
        };

        public string[,] Hint2 =        // 힌트 2차원 배열 생성
        {
            {"밤", "무더위"},
            {"돌아오다", "무기" },
            {"곱셈", "외우다"},
            {"글씨", "그대로" },
            {"변화무쌍", "날씨" }
        };

    }
}
