namespace QLBANHANG.GUI
{
    partial class frmLAPPHIEUKIEMKE
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
            this.dgHangHoa = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaPKK = new System.Windows.Forms.TextBox();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtSLBan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSLXuat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSLNhap = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMaHangHoa = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnThemPKK = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtxtNgay = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgHangHoa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgHangHoa
            // 
            this.dgHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column7,
            this.Column2});
            this.dgHangHoa.Location = new System.Drawing.Point(30, 219);
            this.dgHangHoa.Name = "dgHangHoa";
            this.dgHangHoa.Size = new System.Drawing.Size(834, 83);
            this.dgHangHoa.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(331, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 33);
            this.label2.TabIndex = 22;
            this.label2.Text = "PHIẾU KIỂM KÊ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtxtNgay);
            this.groupBox1.Controls.Add(this.txtMaPKK);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Mã phiếu kiểm kê";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(121, 94);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(120, 20);
            this.txtMaNV.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "MaNV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ngày";
            // 
            // txtMaPKK
            // 
            this.txtMaPKK.Location = new System.Drawing.Point(121, 19);
            this.txtMaPKK.Name = "txtMaPKK";
            this.txtMaPKK.Size = new System.Drawing.Size(120, 20);
            this.txtMaPKK.TabIndex = 0;
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(658, 428);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(75, 23);
            this.btnBoqua.TabIndex = 4;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(561, 428);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtSLBan);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.btnTaoMoi);
            this.groupBox4.Controls.Add(this.txtSLXuat);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtSLNhap);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtMaHangHoa);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(30, 330);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(472, 177);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // txtSLBan
            // 
            this.txtSLBan.Location = new System.Drawing.Point(107, 140);
            this.txtSLBan.Name = "txtSLBan";
            this.txtSLBan.Size = new System.Drawing.Size(153, 20);
            this.txtSLBan.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Số lượng bán";
            // 
            // txtSLXuat
            // 
            this.txtSLXuat.Location = new System.Drawing.Point(107, 105);
            this.txtSLXuat.Name = "txtSLXuat";
            this.txtSLXuat.Size = new System.Drawing.Size(153, 20);
            this.txtSLXuat.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số lượng xuất";
            // 
            // txtSLNhap
            // 
            this.txtSLNhap.Location = new System.Drawing.Point(107, 62);
            this.txtSLNhap.Name = "txtSLNhap";
            this.txtSLNhap.Size = new System.Drawing.Size(153, 20);
            this.txtSLNhap.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Số lượng nhập";
            // 
            // txtMaHangHoa
            // 
            this.txtMaHangHoa.Location = new System.Drawing.Point(107, 23);
            this.txtMaHangHoa.Name = "txtMaHangHoa";
            this.txtMaHangHoa.Size = new System.Drawing.Size(153, 20);
            this.txtMaHangHoa.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Mã hàng hóa";
            // 
            // btnThemPKK
            // 
            this.btnThemPKK.Location = new System.Drawing.Point(362, 387);
            this.btnThemPKK.Name = "btnThemPKK";
            this.btnThemPKK.Size = new System.Drawing.Size(84, 23);
            this.btnThemPKK.TabIndex = 2;
            this.btnThemPKK.Text = "Thêm vào PKK";
            this.btnThemPKK.UseVisualStyleBackColor = true;
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(332, 108);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(84, 23);
            this.btnTaoMoi.TabIndex = 4;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã hàng hóa";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Đơn vị tính ";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số lượng nhập";
            this.Column4.Name = "Column4";
            this.Column4.Width = 130;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số lượng xuất";
            this.Column5.Name = "Column5";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Số lượng bán";
            this.Column8.Name = "Column8";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Số lượng tồn quầy";
            this.Column7.Name = "Column7";
            this.Column7.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Số lượng tồn kho";
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // mtxtNgay
            // 
            this.mtxtNgay.Location = new System.Drawing.Point(121, 54);
            this.mtxtNgay.Mask = "00/00/0000";
            this.mtxtNgay.Name = "mtxtNgay";
            this.mtxtNgay.Size = new System.Drawing.Size(120, 20);
            this.mtxtNgay.TabIndex = 1;
            this.mtxtNgay.ValidatingType = typeof(System.DateTime);
            // 
            // frmLAPPHIEUKIEMKE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 516);
            this.Controls.Add(this.btnThemPKK);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgHangHoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLAPPHIEUKIEMKE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LẬP PHIẾU KIỂM KÊ";
            ((System.ComponentModel.ISupportInitialize)(this.dgHangHoa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgHangHoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaPKK;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtSLBan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSLXuat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSLNhap;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMaHangHoa;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnThemPKK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.MaskedTextBox mtxtNgay;
    }
}