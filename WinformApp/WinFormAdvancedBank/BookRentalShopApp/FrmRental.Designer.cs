﻿
namespace BookRentalShopApp
{
    partial class FrmRental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRental));
            this.GrbDetail = new System.Windows.Forms.GroupBox();
            this.CboRentalState = new System.Windows.Forms.ComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.BtnSearchBook = new System.Windows.Forms.Button();
            this.BtnSearchMember = new System.Windows.Forms.Button();
            this.DtpRentalDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TxtBookName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.TxtMemberName = new MetroFramework.Controls.MetroTextBox();
            this.TxtIdx = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnNew = new MetroFramework.Controls.MetroButton();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.TxtReturnDate = new System.Windows.Forms.TextBox();
            this.GrbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbDetail
            // 
            this.GrbDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrbDetail.Controls.Add(this.TxtReturnDate);
            this.GrbDetail.Controls.Add(this.CboRentalState);
            this.GrbDetail.Controls.Add(this.metroLabel5);
            this.GrbDetail.Controls.Add(this.BtnSearchBook);
            this.GrbDetail.Controls.Add(this.BtnSearchMember);
            this.GrbDetail.Controls.Add(this.DtpRentalDate);
            this.GrbDetail.Controls.Add(this.metroLabel2);
            this.GrbDetail.Controls.Add(this.TxtBookName);
            this.GrbDetail.Controls.Add(this.metroLabel8);
            this.GrbDetail.Controls.Add(this.TxtMemberName);
            this.GrbDetail.Controls.Add(this.TxtIdx);
            this.GrbDetail.Controls.Add(this.metroLabel4);
            this.GrbDetail.Controls.Add(this.metroLabel3);
            this.GrbDetail.Controls.Add(this.metroLabel1);
            this.GrbDetail.Controls.Add(this.BtnSave);
            this.GrbDetail.Controls.Add(this.BtnNew);
            this.GrbDetail.Location = new System.Drawing.Point(437, 63);
            this.GrbDetail.Name = "GrbDetail";
            this.GrbDetail.Size = new System.Drawing.Size(350, 364);
            this.GrbDetail.TabIndex = 0;
            this.GrbDetail.TabStop = false;
            this.GrbDetail.Text = "상세";
            // 
            // CboRentalState
            // 
            this.CboRentalState.FormattingEnabled = true;
            this.CboRentalState.Location = new System.Drawing.Point(99, 185);
            this.CboRentalState.Name = "CboRentalState";
            this.CboRentalState.Size = new System.Drawing.Size(97, 20);
            this.CboRentalState.TabIndex = 9;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(21, 186);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(72, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "대여상태 :";
            // 
            // BtnSearchBook
            // 
            this.BtnSearchBook.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearchBook.Image")));
            this.BtnSearchBook.Location = new System.Drawing.Point(298, 85);
            this.BtnSearchBook.Name = "BtnSearchBook";
            this.BtnSearchBook.Size = new System.Drawing.Size(41, 23);
            this.BtnSearchBook.TabIndex = 6;
            this.BtnSearchBook.UseVisualStyleBackColor = true;
            this.BtnSearchBook.Click += new System.EventHandler(this.BtnSearchBook_Click);
            // 
            // BtnSearchMember
            // 
            this.BtnSearchMember.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearchMember.Image")));
            this.BtnSearchMember.Location = new System.Drawing.Point(298, 56);
            this.BtnSearchMember.Name = "BtnSearchMember";
            this.BtnSearchMember.Size = new System.Drawing.Size(41, 23);
            this.BtnSearchMember.TabIndex = 4;
            this.BtnSearchMember.UseVisualStyleBackColor = true;
            this.BtnSearchMember.Click += new System.EventHandler(this.BtnSearchMember_Click);
            // 
            // DtpRentalDate
            // 
            this.DtpRentalDate.CustomFormat = "yyyy-MM-dd";
            this.DtpRentalDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpRentalDate.Location = new System.Drawing.Point(99, 115);
            this.DtpRentalDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtpRentalDate.Name = "DtpRentalDate";
            this.DtpRentalDate.Size = new System.Drawing.Size(240, 29);
            this.DtpRentalDate.TabIndex = 7;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(35, 154);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "반납일 :";
            // 
            // TxtBookName
            // 
            // 
            // 
            // 
            this.TxtBookName.CustomButton.Image = null;
            this.TxtBookName.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.TxtBookName.CustomButton.Name = "";
            this.TxtBookName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBookName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBookName.CustomButton.TabIndex = 1;
            this.TxtBookName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBookName.CustomButton.UseSelectable = true;
            this.TxtBookName.CustomButton.Visible = false;
            this.TxtBookName.Lines = new string[0];
            this.TxtBookName.Location = new System.Drawing.Point(99, 85);
            this.TxtBookName.MaxLength = 32767;
            this.TxtBookName.Name = "TxtBookName";
            this.TxtBookName.PasswordChar = '\0';
            this.TxtBookName.PromptText = "도서명";
            this.TxtBookName.ReadOnly = true;
            this.TxtBookName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBookName.SelectedText = "";
            this.TxtBookName.SelectionLength = 0;
            this.TxtBookName.SelectionStart = 0;
            this.TxtBookName.ShortcutsEnabled = true;
            this.TxtBookName.Size = new System.Drawing.Size(193, 23);
            this.TxtBookName.TabIndex = 5;
            this.TxtBookName.UseSelectable = true;
            this.TxtBookName.WaterMark = "도서명";
            this.TxtBookName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBookName.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(35, 119);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(58, 19);
            this.metroLabel8.TabIndex = 9;
            this.metroLabel8.Text = "대여일 :";
            // 
            // TxtMemberName
            // 
            // 
            // 
            // 
            this.TxtMemberName.CustomButton.Image = null;
            this.TxtMemberName.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.TxtMemberName.CustomButton.Name = "";
            this.TxtMemberName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtMemberName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtMemberName.CustomButton.TabIndex = 1;
            this.TxtMemberName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtMemberName.CustomButton.UseSelectable = true;
            this.TxtMemberName.CustomButton.Visible = false;
            this.TxtMemberName.Lines = new string[0];
            this.TxtMemberName.Location = new System.Drawing.Point(99, 56);
            this.TxtMemberName.MaxLength = 32767;
            this.TxtMemberName.Name = "TxtMemberName";
            this.TxtMemberName.PasswordChar = '\0';
            this.TxtMemberName.PromptText = "대여 회원";
            this.TxtMemberName.ReadOnly = true;
            this.TxtMemberName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtMemberName.SelectedText = "";
            this.TxtMemberName.SelectionLength = 0;
            this.TxtMemberName.SelectionStart = 0;
            this.TxtMemberName.ShortcutsEnabled = true;
            this.TxtMemberName.Size = new System.Drawing.Size(193, 23);
            this.TxtMemberName.TabIndex = 3;
            this.TxtMemberName.UseSelectable = true;
            this.TxtMemberName.WaterMark = "대여 회원";
            this.TxtMemberName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtMemberName.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtIdx
            // 
            // 
            // 
            // 
            this.TxtIdx.CustomButton.Image = null;
            this.TxtIdx.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.TxtIdx.CustomButton.Name = "";
            this.TxtIdx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtIdx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtIdx.CustomButton.TabIndex = 1;
            this.TxtIdx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtIdx.CustomButton.UseSelectable = true;
            this.TxtIdx.CustomButton.Visible = false;
            this.TxtIdx.Lines = new string[0];
            this.TxtIdx.Location = new System.Drawing.Point(99, 27);
            this.TxtIdx.MaxLength = 32767;
            this.TxtIdx.Name = "TxtIdx";
            this.TxtIdx.PasswordChar = '\0';
            this.TxtIdx.PromptText = "순번";
            this.TxtIdx.ReadOnly = true;
            this.TxtIdx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtIdx.SelectedText = "";
            this.TxtIdx.SelectionLength = 0;
            this.TxtIdx.SelectionStart = 0;
            this.TxtIdx.ShortcutsEnabled = true;
            this.TxtIdx.Size = new System.Drawing.Size(240, 23);
            this.TxtIdx.TabIndex = 2;
            this.TxtIdx.UseSelectable = true;
            this.TxtIdx.WaterMark = "순번";
            this.TxtIdx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtIdx.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(35, 85);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(58, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "도서명 :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(21, 57);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(72, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "대여회원 :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(49, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "순번 :";
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(257, 326);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNew.Location = new System.Drawing.Point(171, 326);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 11;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseSelectable = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Location = new System.Drawing.Point(23, 64);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowTemplate.Height = 23;
            this.DgvData.Size = new System.Drawing.Size(392, 363);
            this.DgvData.TabIndex = 1;
            this.DgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellClick);
            // 
            // TxtReturnDate
            // 
            this.TxtReturnDate.Location = new System.Drawing.Point(99, 154);
            this.TxtReturnDate.Name = "TxtReturnDate";
            this.TxtReturnDate.ReadOnly = true;
            this.TxtReturnDate.Size = new System.Drawing.Size(240, 21);
            this.TxtReturnDate.TabIndex = 15;
            // 
            // FrmRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.GrbDetail);
            this.Name = "FrmRental";
            this.Text = "대여 관리";
            this.Load += new System.EventHandler(this.FrmDivCode_Load);
            this.Resize += new System.EventHandler(this.FrmDivCode_Resize);
            this.GrbDetail.ResumeLayout(false);
            this.GrbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbDetail;
        private MetroFramework.Controls.MetroTextBox TxtMemberName;
        private MetroFramework.Controls.MetroTextBox TxtIdx;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BtnNew;
        private System.Windows.Forms.DataGridView DgvData;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox TxtBookName;
        private MetroFramework.Controls.MetroDateTime DtpRentalDate;
        private System.Windows.Forms.Button BtnSearchMember;
        private System.Windows.Forms.Button BtnSearchBook;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ComboBox CboRentalState;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.TextBox TxtReturnDate;
    }
}