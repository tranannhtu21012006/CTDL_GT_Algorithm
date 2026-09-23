namespace DijkstraTest2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lbInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSource = new System.Windows.Forms.ComboBox();
            this.cbDestination = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.tbKM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lable12 = new System.Windows.Forms.Label();
            this.tbLiter = new System.Windows.Forms.TextBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.southMap = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbInfo
            // 
            this.lbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInfo.AutoSize = true;
            this.lbInfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbInfo.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.ImageKey = "(none)";
            this.lbInfo.Location = new System.Drawing.Point(82, 23);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(874, 32);
            this.lbInfo.TabIndex = 1;
            this.lbInfo.Text = "Ứng dụng thuật toán Dijkstra tìm kiếm đường đi tối ưu chi phí vận tải";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bảng ước tính chi phí vận chuyển";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::Nhom9_DoAnCTDLGT.Properties.Resources.BACKGROUND;
            this.label5.Location = new System.Drawing.Point(179, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm đi:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = global::Nhom9_DoAnCTDLGT.Properties.Resources.BACKGROUND;
            this.label6.Location = new System.Drawing.Point(531, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "Điểm đến:";
            // 
            // cbSource
            // 
            this.cbSource.BackColor = System.Drawing.SystemColors.Info;
            this.cbSource.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSource.FormattingEnabled = true;
            this.cbSource.Items.AddRange(new object[] {
            "Đồng Nai",
            "TP. Hồ Chí Minh",
            "Tây Ninh",
            "Đồng Tháp",
            "An Giang",
            "Vĩnh Long",
            "TP. Cần Thơ",
            "Cà Mau"});
            this.cbSource.Location = new System.Drawing.Point(279, 92);
            this.cbSource.Name = "cbSource";
            this.cbSource.Size = new System.Drawing.Size(171, 29);
            this.cbSource.TabIndex = 1;
            // 
            // cbDestination
            // 
            this.cbDestination.BackColor = System.Drawing.SystemColors.Info;
            this.cbDestination.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDestination.FormattingEnabled = true;
            this.cbDestination.Items.AddRange(new object[] {
            "Đồng Nai",
            "TP. Hồ Chí Minh",
            "Tây Ninh",
            "Đồng Tháp",
            "An Giang",
            "Vĩnh Long",
            "TP. Cần Thơ",
            "Cà Mau"});
            this.cbDestination.Location = new System.Drawing.Point(645, 92);
            this.cbDestination.Name = "cbDestination";
            this.cbDestination.Size = new System.Drawing.Size(171, 29);
            this.cbDestination.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.tbPath);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tbKM);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lable12);
            this.panel3.Controls.Add(this.tbLiter);
            this.panel3.Controls.Add(this.tbCost);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(431, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(574, 290);
            this.panel3.TabIndex = 10;
            // 
            // tbPath
            // 
            this.tbPath.BackColor = System.Drawing.SystemColors.Info;
            this.tbPath.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPath.Location = new System.Drawing.Point(173, 224);
            this.tbPath.Multiline = true;
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(383, 45);
            this.tbPath.TabIndex = 8;
            // 
            // tbKM
            // 
            this.tbKM.BackColor = System.Drawing.SystemColors.Info;
            this.tbKM.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKM.Location = new System.Drawing.Point(173, 57);
            this.tbKM.Name = "tbKM";
            this.tbKM.Size = new System.Drawing.Size(231, 32);
            this.tbKM.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 45);
            this.label7.TabIndex = 5;
            this.label7.Text = "Chi phí vận tải:";
            // 
            // lable12
            // 
            this.lable12.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable12.Location = new System.Drawing.Point(17, 60);
            this.lable12.Name = "lable12";
            this.lable12.Size = new System.Drawing.Size(269, 45);
            this.lable12.TabIndex = 10;
            this.lable12.Text = "Quãng đường đi:";
            // 
            // tbLiter
            // 
            this.tbLiter.BackColor = System.Drawing.SystemColors.Info;
            this.tbLiter.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLiter.Location = new System.Drawing.Point(173, 114);
            this.tbLiter.Name = "tbLiter";
            this.tbLiter.Size = new System.Drawing.Size(231, 32);
            this.tbLiter.TabIndex = 9;
            // 
            // tbCost
            // 
            this.tbCost.BackColor = System.Drawing.SystemColors.Info;
            this.tbCost.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCost.Location = new System.Drawing.Point(173, 168);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(231, 32);
            this.tbCost.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 45);
            this.label8.TabIndex = 6;
            this.label8.Text = "Đường đi:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 32);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tổng nhiên liệu:";
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRun.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(431, 472);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(200, 40);
            this.btnRun.TabIndex = 11;
            this.btnRun.Text = "Tính đường đi";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // southMap
            // 
            this.southMap.BackColor = System.Drawing.Color.AntiqueWhite;
            this.southMap.BackgroundImage = global::Nhom9_DoAnCTDLGT.Properties.Resources.MAP;
            this.southMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.southMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.southMap.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.southMap.Location = new System.Drawing.Point(20, 160);
            this.southMap.Name = "southMap";
            this.southMap.Size = new System.Drawing.Size(393, 391);
            this.southMap.TabIndex = 6;
            this.southMap.Paint += new System.Windows.Forms.PaintEventHandler(this.southMap_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.BackgroundImage = global::Nhom9_DoAnCTDLGT.Properties.Resources.BACKGROUND;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 749);
            this.Controls.Add(this.southMap);
            this.Controls.Add(this.cbDestination);
            this.Controls.Add(this.cbSource);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btnRun);
            this.Name = "Form1";
            this.Text = "Ứng dụng Dijkstra";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSource;
        private System.Windows.Forms.ComboBox cbDestination;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.TextBox tbLiter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbKM;
        private System.Windows.Forms.Label lable12;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Panel southMap;

    }
}





