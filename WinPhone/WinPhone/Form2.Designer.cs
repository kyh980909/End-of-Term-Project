namespace WinPhone
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectVillage = new System.Windows.Forms.ComboBox();
            this.Select = new System.Windows.Forms.Button();
            this.SelectCountry = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "주소(구)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "주소(읍/면/동)";
            // 
            // SelectVillage
            // 
            this.SelectVillage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectVillage.FormattingEnabled = true;
            this.SelectVillage.Location = new System.Drawing.Point(104, 117);
            this.SelectVillage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectVillage.Name = "SelectVillage";
            this.SelectVillage.Size = new System.Drawing.Size(106, 20);
            this.SelectVillage.TabIndex = 4;
            this.SelectVillage.SelectedIndexChanged += new System.EventHandler(this.SelectVillage_SelectedIndexChanged);
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(81, 174);
            this.Select.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(66, 18);
            this.Select.TabIndex = 6;
            this.Select.Text = "확인";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // SelectCountry
            // 
            this.SelectCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectCountry.FormattingEnabled = true;
            this.SelectCountry.Items.AddRange(new object[] {
            "강남구",
            "강동구",
            "강북구",
            "강서구",
            "관악구",
            "광진구",
            "구로구",
            "금천구",
            "노원구",
            "도봉구",
            "동대문구",
            "동작구",
            "마포구",
            "서대문구",
            "서초구",
            "성동구",
            "성북구",
            "송파구",
            "양천구",
            "영등포구",
            "용산구",
            "은평구",
            "종로구",
            "중구",
            "중랑구"});
            this.SelectCountry.Location = new System.Drawing.Point(104, 42);
            this.SelectCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectCountry.Name = "SelectCountry";
            this.SelectCountry.Size = new System.Drawing.Size(106, 20);
            this.SelectCountry.TabIndex = 2;
            this.SelectCountry.SelectedIndexChanged += new System.EventHandler(this.SelectCountry_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 202);
            this.ControlBox = false;
            this.Controls.Add(this.Select);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SelectVillage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectCountry);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.ComboBox SelectCountry;
        public System.Windows.Forms.ComboBox SelectVillage;
    }
}