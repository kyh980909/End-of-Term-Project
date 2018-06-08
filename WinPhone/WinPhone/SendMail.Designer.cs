namespace WinPhone
{
    partial class SendMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendMail));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Send = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Mail_ID = new System.Windows.Forms.TextBox();
            this.Mail_PW = new System.Windows.Forms.TextBox();
            this.To = new System.Windows.Forms.TextBox();
            this.Sender_Name = new System.Windows.Forms.TextBox();
            this.Subject = new System.Windows.Forms.TextBox();
            this.Context = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "PW";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "이름";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "받는 사람 이메일 주소";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "제목";
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(120, 478);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 13;
            this.Send.Text = "전송";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Back
            // 
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.Location = new System.Drawing.Point(3, 3);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(25, 25);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Back.TabIndex = 14;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "Google 아이디를 입력해주세요";
            // 
            // Mail_ID
            // 
            this.Mail_ID.Location = new System.Drawing.Point(31, 43);
            this.Mail_ID.Name = "Mail_ID";
            this.Mail_ID.Size = new System.Drawing.Size(135, 21);
            this.Mail_ID.TabIndex = 16;
            // 
            // Mail_PW
            // 
            this.Mail_PW.Location = new System.Drawing.Point(202, 43);
            this.Mail_PW.Name = "Mail_PW";
            this.Mail_PW.PasswordChar = '*';
            this.Mail_PW.Size = new System.Drawing.Size(118, 21);
            this.Mail_PW.TabIndex = 17;
            // 
            // To
            // 
            this.To.Location = new System.Drawing.Point(152, 73);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(168, 21);
            this.To.TabIndex = 19;
            // 
            // Sender_Name
            // 
            this.Sender_Name.Location = new System.Drawing.Point(44, 101);
            this.Sender_Name.Name = "Sender_Name";
            this.Sender_Name.Size = new System.Drawing.Size(276, 21);
            this.Sender_Name.TabIndex = 20;
            // 
            // Subject
            // 
            this.Subject.Location = new System.Drawing.Point(45, 130);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(275, 21);
            this.Subject.TabIndex = 21;
            // 
            // Context
            // 
            this.Context.Location = new System.Drawing.Point(11, 157);
            this.Context.Name = "Context";
            this.Context.Size = new System.Drawing.Size(309, 306);
            this.Context.TabIndex = 22;
            this.Context.Text = "";
            // 
            // SendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 513);
            this.ControlBox = false;
            this.Controls.Add(this.Context);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.Sender_Name);
            this.Controls.Add(this.To);
            this.Controls.Add(this.Mail_PW);
            this.Controls.Add(this.Mail_ID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SendMail";
            this.Text = "SendMail";
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Mail_ID;
        private System.Windows.Forms.TextBox Mail_PW;
        private System.Windows.Forms.TextBox To;
        private System.Windows.Forms.TextBox Sender_Name;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.RichTextBox Context;
    }
}