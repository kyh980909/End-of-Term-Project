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
            this.Stage1 = new System.Windows.Forms.Button();
            this.Stage2 = new System.Windows.Forms.Button();
            this.Stage3 = new System.Windows.Forms.Button();
            this.Stage4 = new System.Windows.Forms.Button();
            this.Stage5 = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.SuspendLayout();
            // 
            // Stage1
            // 
            this.Stage1.Location = new System.Drawing.Point(35, 40);
            this.Stage1.Name = "Stage1";
            this.Stage1.Size = new System.Drawing.Size(260, 50);
            this.Stage1.TabIndex = 0;
            this.Stage1.Text = "초보자 단계";
            this.Stage1.UseVisualStyleBackColor = true;
            this.Stage1.Click += new System.EventHandler(this.Stage1_Click);
            // 
            // Stage2
            // 
            this.Stage2.Location = new System.Drawing.Point(35, 140);
            this.Stage2.Name = "Stage2";
            this.Stage2.Size = new System.Drawing.Size(260, 50);
            this.Stage2.TabIndex = 1;
            this.Stage2.Text = "유망주 단계";
            this.Stage2.UseVisualStyleBackColor = true;
            this.Stage2.Click += new System.EventHandler(this.Stage2_Click);
            // 
            // Stage3
            // 
            this.Stage3.Location = new System.Drawing.Point(35, 240);
            this.Stage3.Name = "Stage3";
            this.Stage3.Size = new System.Drawing.Size(260, 50);
            this.Stage3.TabIndex = 2;
            this.Stage3.Text = "중급자 단계";
            this.Stage3.UseVisualStyleBackColor = true;
            this.Stage3.Click += new System.EventHandler(this.Stage3_Click);
            // 
            // Stage4
            // 
            this.Stage4.Location = new System.Drawing.Point(35, 340);
            this.Stage4.Name = "Stage4";
            this.Stage4.Size = new System.Drawing.Size(260, 50);
            this.Stage4.TabIndex = 3;
            this.Stage4.Text = "실력자 단계";
            this.Stage4.UseVisualStyleBackColor = true;
            this.Stage4.Click += new System.EventHandler(this.Stage4_Click);
            // 
            // Stage5
            // 
            this.Stage5.Location = new System.Drawing.Point(35, 440);
            this.Stage5.Name = "Stage5";
            this.Stage5.Size = new System.Drawing.Size(260, 50);
            this.Stage5.TabIndex = 4;
            this.Stage5.Text = "우수자 단계";
            this.Stage5.UseVisualStyleBackColor = true;
            this.Stage5.Click += new System.EventHandler(this.Stage5_Click);
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
            this.Controls.Add(this.Stage5);
            this.Controls.Add(this.Stage4);
            this.Controls.Add(this.Stage3);
            this.Controls.Add(this.Stage2);
            this.Controls.Add(this.Stage1);
            this.Name = "InitialGameSelect";
            this.Text = "InitialGame";
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Stage1;
        private System.Windows.Forms.Button Stage2;
        private System.Windows.Forms.Button Stage3;
        private System.Windows.Forms.Button Stage4;
        private System.Windows.Forms.Button Stage5;
        private System.Windows.Forms.PictureBox Back;
    }
}