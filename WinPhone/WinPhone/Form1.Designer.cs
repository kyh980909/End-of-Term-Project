namespace WinPhone
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StateBar = new System.Windows.Forms.GroupBox();
            this.ShutDown = new System.Windows.Forms.PictureBox();
            this.Date = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.CurrentTime = new System.Windows.Forms.Timer(this.components);
            this.GameApp = new System.Windows.Forms.Button();
            this.CelciusLabel = new System.Windows.Forms.Label();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.VillageLabel = new System.Windows.Forms.Label();
            this.MailApp = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.RT_KeyWord = new System.Windows.Forms.Button();
            this.StateBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShutDown)).BeginInit();
            this.SuspendLayout();
            // 
            // StateBar
            // 
            this.StateBar.Controls.Add(this.ShutDown);
            this.StateBar.Controls.Add(this.Date);
            this.StateBar.Controls.Add(this.Time);
            this.StateBar.Location = new System.Drawing.Point(0, -6);
            this.StateBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StateBar.Name = "StateBar";
            this.StateBar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StateBar.Size = new System.Drawing.Size(332, 33);
            this.StateBar.TabIndex = 0;
            this.StateBar.TabStop = false;
            // 
            // ShutDown
            // 
            this.ShutDown.Image = ((System.Drawing.Image)(resources.GetObject("ShutDown.Image")));
            this.ShutDown.InitialImage = ((System.Drawing.Image)(resources.GetObject("ShutDown.InitialImage")));
            this.ShutDown.Location = new System.Drawing.Point(157, 11);
            this.ShutDown.Name = "ShutDown";
            this.ShutDown.Size = new System.Drawing.Size(17, 17);
            this.ShutDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShutDown.TabIndex = 2;
            this.ShutDown.TabStop = false;
            this.ShutDown.Click += new System.EventHandler(this.ShutDown_Click);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(5, 14);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(29, 12);
            this.Date.TabIndex = 1;
            this.Date.Text = "날짜";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(270, 14);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(53, 12);
            this.Time.TabIndex = 0;
            this.Time.Text = "현재시간";
            // 
            // CurrentTime
            // 
            this.CurrentTime.Enabled = true;
            this.CurrentTime.Interval = 30000;
            this.CurrentTime.Tick += new System.EventHandler(this.CurrentTimeTick);
            // 
            // GameApp
            // 
            this.GameApp.Font = new System.Drawing.Font("HY견고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GameApp.Location = new System.Drawing.Point(8, 436);
            this.GameApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GameApp.Name = "GameApp";
            this.GameApp.Size = new System.Drawing.Size(65, 65);
            this.GameApp.TabIndex = 1;
            this.GameApp.Text = "게임";
            this.GameApp.UseVisualStyleBackColor = true;
            this.GameApp.Click += new System.EventHandler(this.GameApp_Click);
            // 
            // CelciusLabel
            // 
            this.CelciusLabel.AutoSize = true;
            this.CelciusLabel.Font = new System.Drawing.Font("돋움", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CelciusLabel.Location = new System.Drawing.Point(114, 131);
            this.CelciusLabel.Name = "CelciusLabel";
            this.CelciusLabel.Size = new System.Drawing.Size(163, 67);
            this.CelciusLabel.TabIndex = 5;
            this.CelciusLabel.Text = "기온";
            this.CelciusLabel.Click += new System.EventHandler(this.CelciusLabel_Click);
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CountryLabel.Location = new System.Drawing.Point(136, 216);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(28, 19);
            this.CountryLabel.TabIndex = 6;
            this.CountryLabel.Text = "구";
            // 
            // VillageLabel
            // 
            this.VillageLabel.AutoSize = true;
            this.VillageLabel.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.VillageLabel.Location = new System.Drawing.Point(146, 237);
            this.VillageLabel.Name = "VillageLabel";
            this.VillageLabel.Size = new System.Drawing.Size(16, 11);
            this.VillageLabel.TabIndex = 7;
            this.VillageLabel.Text = "동";
            // 
            // MailApp
            // 
            this.MailApp.Font = new System.Drawing.Font("HY견고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MailApp.Location = new System.Drawing.Point(90, 437);
            this.MailApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MailApp.Name = "MailApp";
            this.MailApp.Size = new System.Drawing.Size(65, 65);
            this.MailApp.TabIndex = 2;
            this.MailApp.Text = "메일";
            this.MailApp.UseVisualStyleBackColor = true;
            this.MailApp.Click += new System.EventHandler(this.MailApp_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("HY견고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(255, 437);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 65);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // RT_KeyWord
            // 
            this.RT_KeyWord.Font = new System.Drawing.Font("HY견고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RT_KeyWord.Location = new System.Drawing.Point(172, 436);
            this.RT_KeyWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RT_KeyWord.Name = "RT_KeyWord";
            this.RT_KeyWord.Size = new System.Drawing.Size(65, 65);
            this.RT_KeyWord.TabIndex = 3;
            this.RT_KeyWord.Text = "실시간 검색어";
            this.RT_KeyWord.UseVisualStyleBackColor = true;
            this.RT_KeyWord.Click += new System.EventHandler(this.RT_KeyWord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 513);
            this.ControlBox = false;
            this.Controls.Add(this.VillageLabel);
            this.Controls.Add(this.CountryLabel);
            this.Controls.Add(this.CelciusLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.RT_KeyWord);
            this.Controls.Add(this.MailApp);
            this.Controls.Add(this.GameApp);
            this.Controls.Add(this.StateBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "WinPhone";
            this.StateBar.ResumeLayout(false);
            this.StateBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShutDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox StateBar;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Timer CurrentTime;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Button GameApp;
        public System.Windows.Forms.Label CountryLabel;
        public System.Windows.Forms.Label CelciusLabel;
        public System.Windows.Forms.Label VillageLabel;
        private System.Windows.Forms.PictureBox ShutDown;
        private System.Windows.Forms.Button MailApp;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button RT_KeyWord;
    }
}

