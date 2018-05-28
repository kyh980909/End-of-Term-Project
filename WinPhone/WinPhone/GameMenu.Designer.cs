namespace WinPhone
{
    partial class GameMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GameName = new System.Windows.Forms.Label();
            this.GameStart = new System.Windows.Forms.Button();
            this.GameInfo = new System.Windows.Forms.Button();
            this.GameEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameName
            // 
            this.GameName.AutoSize = true;
            this.GameName.Font = new System.Drawing.Font("돋움", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GameName.Location = new System.Drawing.Point(289, 94);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(431, 67);
            this.GameName.TabIndex = 0;
            this.GameName.Text = "게임이름미정";
            // 
            // GameStart
            // 
            this.GameStart.Location = new System.Drawing.Point(385, 268);
            this.GameStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GameStart.Name = "GameStart";
            this.GameStart.Size = new System.Drawing.Size(195, 52);
            this.GameStart.TabIndex = 1;
            this.GameStart.Text = "게임 시작";
            this.GameStart.UseVisualStyleBackColor = true;
            // 
            // GameInfo
            // 
            this.GameInfo.Location = new System.Drawing.Point(385, 328);
            this.GameInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GameInfo.Name = "GameInfo";
            this.GameInfo.Size = new System.Drawing.Size(195, 51);
            this.GameInfo.TabIndex = 2;
            this.GameInfo.Text = "게임 설명";
            this.GameInfo.UseVisualStyleBackColor = true;
            this.GameInfo.Click += new System.EventHandler(this.GameInfo_Click);
            // 
            // GameEnd
            // 
            this.GameEnd.Location = new System.Drawing.Point(385, 386);
            this.GameEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GameEnd.Name = "GameEnd";
            this.GameEnd.Size = new System.Drawing.Size(195, 51);
            this.GameEnd.TabIndex = 3;
            this.GameEnd.Text = "게임 종료";
            this.GameEnd.UseVisualStyleBackColor = true;
            this.GameEnd.Click += new System.EventHandler(this.GameEnd_Click);
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 549);
            this.ControlBox = false;
            this.Controls.Add(this.GameEnd);
            this.Controls.Add(this.GameInfo);
            this.Controls.Add(this.GameStart);
            this.Controls.Add(this.GameName);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GameMenu";
            this.Text = "GameMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameName;
        private System.Windows.Forms.Button GameStart;
        private System.Windows.Forms.Button GameInfo;
        private System.Windows.Forms.Button GameEnd;
    }
}