namespace WinPhone
{
    partial class InitialGameSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialGameSelect));
            this.stage1 = new System.Windows.Forms.Button();
            this.stage2 = new System.Windows.Forms.Button();
            this.stage3 = new System.Windows.Forms.Button();
            this.stage4 = new System.Windows.Forms.Button();
            this.stage5 = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.SuspendLayout();
            // 
            // stage1
            // 
            this.stage1.Location = new System.Drawing.Point(35, 40);
            this.stage1.Name = "stage1";
            this.stage1.Size = new System.Drawing.Size(260, 50);
            this.stage1.TabIndex = 0;
            this.stage1.Text = "초보자 단계";
            this.stage1.UseVisualStyleBackColor = true;
            this.stage1.Click += new System.EventHandler(this.Stage1_Click);
            // 
            // stage2
            // 
            this.stage2.Location = new System.Drawing.Point(35, 140);
            this.stage2.Name = "stage2";
            this.stage2.Size = new System.Drawing.Size(260, 50);
            this.stage2.TabIndex = 1;
            this.stage2.Text = "유망주 단계";
            this.stage2.UseVisualStyleBackColor = true;
            this.stage2.Click += new System.EventHandler(this.Stage2_Click);
            // 
            // stage3
            // 
            this.stage3.Location = new System.Drawing.Point(35, 240);
            this.stage3.Name = "stage3";
            this.stage3.Size = new System.Drawing.Size(260, 50);
            this.stage3.TabIndex = 2;
            this.stage3.Text = "중급자 단계";
            this.stage3.UseVisualStyleBackColor = true;
            this.stage3.Click += new System.EventHandler(this.Stage3_Click);
            // 
            // stage4
            // 
            this.stage4.Location = new System.Drawing.Point(35, 340);
            this.stage4.Name = "stage4";
            this.stage4.Size = new System.Drawing.Size(260, 50);
            this.stage4.TabIndex = 3;
            this.stage4.Text = "실력자 단계";
            this.stage4.UseVisualStyleBackColor = true;
            this.stage4.Click += new System.EventHandler(this.Stage4_Click);
            // 
            // stage5
            // 
            this.stage5.Location = new System.Drawing.Point(35, 440);
            this.stage5.Name = "stage5";
            this.stage5.Size = new System.Drawing.Size(260, 50);
            this.stage5.TabIndex = 4;
            this.stage5.Text = "우수자 단계";
            this.stage5.UseVisualStyleBackColor = true;
            this.stage5.Click += new System.EventHandler(this.Stage5_Click);
            // 
            // Back
            // 
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.Location = new System.Drawing.Point(1, 1);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(25, 25);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Back.TabIndex = 5;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // InitialGameSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 513);
            this.ControlBox = false;
            this.Controls.Add(this.Back);
            this.Controls.Add(this.stage5);
            this.Controls.Add(this.stage4);
            this.Controls.Add(this.stage3);
            this.Controls.Add(this.stage2);
            this.Controls.Add(this.stage1);
            this.Name = "InitialGameSelect";
            this.Text = "InitialGame";
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Back;
        public System.Windows.Forms.Button stage2;
        public System.Windows.Forms.Button stage3;
        public System.Windows.Forms.Button stage4;
        public System.Windows.Forms.Button stage5;
        public System.Windows.Forms.Button stage1;
    }
}