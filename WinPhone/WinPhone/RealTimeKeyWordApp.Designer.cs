namespace WinPhone
{
    partial class RealTimeKeyWordApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealTimeKeyWordApp));
            this.NaverLogo = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NaverLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.SuspendLayout();
            // 
            // NaverLogo
            // 
            this.NaverLogo.Image = ((System.Drawing.Image)(resources.GetObject("NaverLogo.Image")));
            this.NaverLogo.Location = new System.Drawing.Point(12, 32);
            this.NaverLogo.Name = "NaverLogo";
            this.NaverLogo.Size = new System.Drawing.Size(138, 30);
            this.NaverLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NaverLogo.TabIndex = 0;
            this.NaverLogo.TabStop = false;
            // 
            // Back
            // 
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.Location = new System.Drawing.Point(1, 1);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(25, 25);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Back.TabIndex = 15;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("돋움", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(145, 34);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(190, 27);
            this.label21.TabIndex = 17;
            this.label21.Text = "실시간 검색어";
            // 
            // RealTimeKeyWordApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(332, 513);
            this.ControlBox = false;
            this.Controls.Add(this.Back);
            this.Controls.Add(this.NaverLogo);
            this.Controls.Add(this.label21);
            this.Name = "RealTimeKeyWordApp";
            this.Text = "RealTimeKeyWord";
            ((System.ComponentModel.ISupportInitialize)(this.NaverLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox NaverLogo;
        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.Label label21;
    }
}