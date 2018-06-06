namespace WinPhone
{
    partial class InitialGameMenu
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
            this.GameEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameName
            // 
            this.GameName.AutoSize = true;
            this.GameName.Font = new System.Drawing.Font("돋움", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GameName.Location = new System.Drawing.Point(42, 99);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(235, 53);
            this.GameName.TabIndex = 0;
            this.GameName.Text = "초성게임";
            // 
            // GameStart
            // 
            this.GameStart.Location = new System.Drawing.Point(78, 228);
            this.GameStart.Name = "GameStart";
            this.GameStart.Size = new System.Drawing.Size(171, 42);
            this.GameStart.TabIndex = 1;
            this.GameStart.Text = "게임 시작";
            this.GameStart.UseVisualStyleBackColor = true;
            this.GameStart.Click += new System.EventHandler(this.GameStart_Click);
            // 
            // GameEnd
            // 
            this.GameEnd.Location = new System.Drawing.Point(78, 323);
            this.GameEnd.Name = "GameEnd";
            this.GameEnd.Size = new System.Drawing.Size(171, 41);
            this.GameEnd.TabIndex = 3;
            this.GameEnd.Text = "게임 종료";
            this.GameEnd.UseVisualStyleBackColor = true;
            this.GameEnd.Click += new System.EventHandler(this.GameEnd_Click);
            // 
            // InitialGameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 513);
            this.ControlBox = false;
            this.Controls.Add(this.GameEnd);
            this.Controls.Add(this.GameStart);
            this.Controls.Add(this.GameName);
            this.Name = "InitialGameMenu";
            this.Text = "InitialGameMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameName;
        private System.Windows.Forms.Button GameStart;
        private System.Windows.Forms.Button GameEnd;
    }
}