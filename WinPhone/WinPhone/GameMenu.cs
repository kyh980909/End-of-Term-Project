﻿using System;
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
    public partial class GameMenu : Form
    {
        public GameMenu()
        {
            InitializeComponent();
        }

        private void GameInfo_Click(object sender, EventArgs e) // 게임정보 버튼 이벤트
        {

        }

        private void GameEnd_Click(object sender, EventArgs e) // 게임종료 버튼 이벤트
        {
            Close(); // 현재 폼을 닫는다.
        }
    }
}
