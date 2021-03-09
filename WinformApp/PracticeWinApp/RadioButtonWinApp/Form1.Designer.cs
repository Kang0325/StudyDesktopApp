
namespace RadioButtonWinApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.RdbKorea = new System.Windows.Forms.RadioButton();
            this.RdbChina = new System.Windows.Forms.RadioButton();
            this.RdbJapan = new System.Windows.Forms.RadioButton();
            this.RdbOther = new System.Windows.Forms.RadioButton();
            this.RdbMale = new System.Windows.Forms.RadioButton();
            this.RdbFemale = new System.Windows.Forms.RadioButton();
            this.GrbCountry = new System.Windows.Forms.GroupBox();
            this.GrbGender = new System.Windows.Forms.GroupBox();
            this.GrbCountry.SuspendLayout();
            this.GrbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "결과";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RdbKorea
            // 
            this.RdbKorea.AutoSize = true;
            this.RdbKorea.Location = new System.Drawing.Point(15, 20);
            this.RdbKorea.Name = "RdbKorea";
            this.RdbKorea.Size = new System.Drawing.Size(71, 16);
            this.RdbKorea.TabIndex = 1;
            this.RdbKorea.TabStop = true;
            this.RdbKorea.Text = "대한민국";
            this.RdbKorea.UseVisualStyleBackColor = true;
            // 
            // RdbChina
            // 
            this.RdbChina.AutoSize = true;
            this.RdbChina.Location = new System.Drawing.Point(15, 42);
            this.RdbChina.Name = "RdbChina";
            this.RdbChina.Size = new System.Drawing.Size(47, 16);
            this.RdbChina.TabIndex = 2;
            this.RdbChina.TabStop = true;
            this.RdbChina.Text = "중국";
            this.RdbChina.UseVisualStyleBackColor = true;
            // 
            // RdbJapan
            // 
            this.RdbJapan.AutoSize = true;
            this.RdbJapan.Location = new System.Drawing.Point(15, 64);
            this.RdbJapan.Name = "RdbJapan";
            this.RdbJapan.Size = new System.Drawing.Size(47, 16);
            this.RdbJapan.TabIndex = 3;
            this.RdbJapan.TabStop = true;
            this.RdbJapan.Text = "일본";
            this.RdbJapan.UseVisualStyleBackColor = true;
            // 
            // RdbOther
            // 
            this.RdbOther.AutoSize = true;
            this.RdbOther.Location = new System.Drawing.Point(15, 86);
            this.RdbOther.Name = "RdbOther";
            this.RdbOther.Size = new System.Drawing.Size(79, 16);
            this.RdbOther.TabIndex = 4;
            this.RdbOther.TabStop = true;
            this.RdbOther.Text = "그 외 국가";
            this.RdbOther.UseVisualStyleBackColor = true;
            // 
            // RdbMale
            // 
            this.RdbMale.AutoSize = true;
            this.RdbMale.Location = new System.Drawing.Point(10, 20);
            this.RdbMale.Name = "RdbMale";
            this.RdbMale.Size = new System.Drawing.Size(47, 16);
            this.RdbMale.TabIndex = 5;
            this.RdbMale.TabStop = true;
            this.RdbMale.Text = "남성";
            this.RdbMale.UseVisualStyleBackColor = true;
            // 
            // RdbFemale
            // 
            this.RdbFemale.AutoSize = true;
            this.RdbFemale.Location = new System.Drawing.Point(61, 20);
            this.RdbFemale.Name = "RdbFemale";
            this.RdbFemale.Size = new System.Drawing.Size(47, 16);
            this.RdbFemale.TabIndex = 6;
            this.RdbFemale.TabStop = true;
            this.RdbFemale.Text = "여성";
            this.RdbFemale.UseVisualStyleBackColor = true;
            // 
            // GrbCountry
            // 
            this.GrbCountry.Controls.Add(this.RdbKorea);
            this.GrbCountry.Controls.Add(this.RdbChina);
            this.GrbCountry.Controls.Add(this.RdbJapan);
            this.GrbCountry.Controls.Add(this.RdbOther);
            this.GrbCountry.Location = new System.Drawing.Point(12, 12);
            this.GrbCountry.Name = "GrbCountry";
            this.GrbCountry.Size = new System.Drawing.Size(119, 117);
            this.GrbCountry.TabIndex = 7;
            this.GrbCountry.TabStop = false;
            this.GrbCountry.Text = "국가";
            // 
            // GrbGender
            // 
            this.GrbGender.Controls.Add(this.RdbMale);
            this.GrbGender.Controls.Add(this.RdbFemale);
            this.GrbGender.Location = new System.Drawing.Point(137, 12);
            this.GrbGender.Name = "GrbGender";
            this.GrbGender.Size = new System.Drawing.Size(115, 52);
            this.GrbGender.TabIndex = 5;
            this.GrbGender.TabStop = false;
            this.GrbGender.Text = "성별";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 140);
            this.Controls.Add(this.GrbGender);
            this.Controls.Add(this.GrbCountry);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GrbCountry.ResumeLayout(false);
            this.GrbCountry.PerformLayout();
            this.GrbGender.ResumeLayout(false);
            this.GrbGender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton RdbKorea;
        private System.Windows.Forms.RadioButton RdbChina;
        private System.Windows.Forms.RadioButton RdbJapan;
        private System.Windows.Forms.RadioButton RdbOther;
        private System.Windows.Forms.RadioButton RdbMale;
        private System.Windows.Forms.RadioButton RdbFemale;
        private System.Windows.Forms.GroupBox GrbCountry;
        private System.Windows.Forms.GroupBox GrbGender;
    }
}

