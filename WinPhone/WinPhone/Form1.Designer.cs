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
            this.StateBar = new System.Windows.Forms.GroupBox();
            this.Time = new System.Windows.Forms.Label();
            this.CurrentTime = new System.Windows.Forms.Timer(this.components);
            this.Date = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.StateBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // StateBar
            // 
            this.StateBar.Controls.Add(this.Date);
            this.StateBar.Controls.Add(this.Time);
            this.StateBar.Location = new System.Drawing.Point(0, -8);
            this.StateBar.Name = "StateBar";
            this.StateBar.Size = new System.Drawing.Size(451, 41);
            this.StateBar.TabIndex = 0;
            this.StateBar.TabStop = false;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(369, 17);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(67, 15);
            this.Time.TabIndex = 0;
            this.Time.Text = "현재시간";
            // 
            // CurrentTime
            // 
            this.CurrentTime.Enabled = true;
            this.CurrentTime.Interval = 30000;
            this.CurrentTime.Tick += new System.EventHandler(this.CurrentTimeTick);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(6, 17);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(37, 15);
            this.Date.TabIndex = 1;
            this.Date.Text = "날짜";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 559);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 66);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(247, 559);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 66);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(364, 559);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 66);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 637);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StateBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.StateBar.ResumeLayout(false);
            this.StateBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox StateBar;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Timer CurrentTime;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

