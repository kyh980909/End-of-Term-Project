namespace WinPhone
{
    partial class Stage3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stage3));
            this.Complete = new System.Windows.Forms.Button();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MenuLabel = new System.Windows.Forms.Label();
            this.Hint = new System.Windows.Forms.GroupBox();
            this.Hint2 = new System.Windows.Forms.Label();
            this.Hint1 = new System.Windows.Forms.Label();
            this.Question = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.PictureBox();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuPanel.SuspendLayout();
            this.Hint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).BeginInit();
            this.SuspendLayout();
            // 
            // Complete
            // 
            this.Complete.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Complete.Location = new System.Drawing.Point(106, 452);
            this.Complete.Name = "Complete";
            this.Complete.Size = new System.Drawing.Size(111, 38);
            this.Complete.TabIndex = 24;
            this.Complete.Text = "확인";
            this.Complete.UseVisualStyleBackColor = true;
            this.Complete.Click += new System.EventHandler(this.Complete_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.MediumPurple;
            this.MenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuPanel.Controls.Add(this.BackButton);
            this.MenuPanel.Controls.Add(this.ExitButton);
            this.MenuPanel.Controls.Add(this.MenuLabel);
            this.MenuPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MenuPanel.Location = new System.Drawing.Point(72, 130);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(10);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(188, 233);
            this.MenuPanel.TabIndex = 21;
            this.MenuPanel.Visible = false;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(36, 151);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(119, 34);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "뒤로가기";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(36, 80);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(119, 34);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "나가기";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MenuLabel
            // 
            this.MenuLabel.AutoSize = true;
            this.MenuLabel.Font = new System.Drawing.Font("돋움", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MenuLabel.Location = new System.Drawing.Point(67, 17);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(60, 24);
            this.MenuLabel.TabIndex = 0;
            this.MenuLabel.Text = "메뉴";
            // 
            // Hint
            // 
            this.Hint.Controls.Add(this.Hint2);
            this.Hint.Controls.Add(this.Hint1);
            this.Hint.Location = new System.Drawing.Point(49, 271);
            this.Hint.Name = "Hint";
            this.Hint.Size = new System.Drawing.Size(233, 153);
            this.Hint.TabIndex = 23;
            this.Hint.TabStop = false;
            this.Hint.Text = "도움말";
            // 
            // Hint2
            // 
            this.Hint2.AutoSize = true;
            this.Hint2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Hint2.Location = new System.Drawing.Point(160, 64);
            this.Hint2.Name = "Hint2";
            this.Hint2.Size = new System.Drawing.Size(51, 21);
            this.Hint2.TabIndex = 1;
            this.Hint2.Text = "힌트2";
            // 
            // Hint1
            // 
            this.Hint1.AutoSize = true;
            this.Hint1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Hint1.Location = new System.Drawing.Point(31, 64);
            this.Hint1.Name = "Hint1";
            this.Hint1.Size = new System.Drawing.Size(51, 21);
            this.Hint1.TabIndex = 0;
            this.Hint1.Text = "힌트1";
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Question.Location = new System.Drawing.Point(118, 198);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(63, 32);
            this.Question.TabIndex = 22;
            this.Question.Text = "문제";
            // 
            // Menu
            // 
            this.Menu.Image = ((System.Drawing.Image)(resources.GetObject("Menu.Image")));
            this.Menu.Location = new System.Drawing.Point(303, 3);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(25, 25);
            this.Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Menu.TabIndex = 20;
            this.Menu.TabStop = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Input
            // 
            this.Input.Font = new System.Drawing.Font("돋움체", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Input.Location = new System.Drawing.Point(72, 118);
            this.Input.Multiline = false;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(188, 52);
            this.Input.TabIndex = 19;
            this.Input.Text = "";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 44);
            this.progressBar1.Maximum = 5;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "중급자 단계";
            // 
            // Stage3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 513);
            this.ControlBox = false;
            this.Controls.Add(this.Complete);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.Hint);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Name = "Stage3";
            this.Text = "중급자 단계";
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.Hint.ResumeLayout(false);
            this.Hint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Complete;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label MenuLabel;
        private System.Windows.Forms.GroupBox Hint;
        private System.Windows.Forms.Label Hint2;
        private System.Windows.Forms.Label Hint1;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.PictureBox Menu;
        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
    }
}