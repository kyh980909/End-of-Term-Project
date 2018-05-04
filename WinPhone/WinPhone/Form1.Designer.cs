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
            this.Date = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.CurrentTime = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Celcius = new System.Windows.Forms.Label();
            this.StateBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // StateBar
            // 
            this.StateBar.Controls.Add(this.Date);
            this.StateBar.Controls.Add(this.Time);
            this.StateBar.Location = new System.Drawing.Point(0, -6);
            this.StateBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StateBar.Name = "StateBar";
            this.StateBar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StateBar.Size = new System.Drawing.Size(395, 33);
            this.StateBar.TabIndex = 0;
            this.StateBar.TabStop = false;
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
            this.Time.Location = new System.Drawing.Point(272, 14);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 436);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 437);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 65);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(172, 436);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 65);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(255, 437);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 65);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Celcius
            // 
            this.Celcius.AutoSize = true;
            this.Celcius.Font = new System.Drawing.Font("돋움", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Celcius.Location = new System.Drawing.Point(110, 117);
            this.Celcius.Name = "Celcius";
            this.Celcius.Size = new System.Drawing.Size(214, 67);
            this.Celcius.TabIndex = 5;
            this.Celcius.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 513);
            this.Controls.Add(this.Celcius);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StateBar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.StateBar.ResumeLayout(false);
            this.StateBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label Celcius;
    }
}

