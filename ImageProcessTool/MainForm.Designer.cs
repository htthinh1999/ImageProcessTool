namespace ImageProcessTool
{
    partial class MainForm
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
            this.picOriginal = new System.Windows.Forms.PictureBox();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnGray = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnBinary = new System.Windows.Forms.Button();
            this.txtBand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHistogramGray = new System.Windows.Forms.Button();
            this.gbxHistogram = new System.Windows.Forms.GroupBox();
            this.btnEqualization = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.lblStretch = new System.Windows.Forms.Label();
            this.txtStretch = new System.Windows.Forms.TextBox();
            this.btnStretch = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxBinary = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAND = new System.Windows.Forms.Button();
            this.btnOpenPB2 = new System.Windows.Forms.Button();
            this.btnOpenPB1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOR = new System.Windows.Forms.Button();
            this.btnXOR = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.gbxHistogram.SuspendLayout();
            this.gbxBinary.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picOriginal
            // 
            this.picOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOriginal.Location = new System.Drawing.Point(8, 77);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(500, 500);
            this.picOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOriginal.TabIndex = 0;
            this.picOriginal.TabStop = false;
            // 
            // lblOriginal
            // 
            this.lblOriginal.AutoSize = true;
            this.lblOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginal.Location = new System.Drawing.Point(8, 58);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(64, 16);
            this.lblOriginal.TabIndex = 1;
            this.lblOriginal.Text = "Ảnh gốc";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(655, 58);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(89, 16);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Ảnh kết quả";
            // 
            // picResult
            // 
            this.picResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picResult.Location = new System.Drawing.Point(658, 77);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(500, 500);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picResult.TabIndex = 2;
            this.picResult.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(368, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(399, 37);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "THAO TÁC TRÊN 1 ẢNH";
            // 
            // btnGray
            // 
            this.btnGray.Location = new System.Drawing.Point(546, 129);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(75, 23);
            this.btnGray.TabIndex = 2;
            this.btnGray.Text = "Ảnh xám";
            this.btnGray.UseVisualStyleBackColor = true;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(546, 90);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Chọn ảnh";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnBinary
            // 
            this.btnBinary.Location = new System.Drawing.Point(17, 58);
            this.btnBinary.Name = "btnBinary";
            this.btnBinary.Size = new System.Drawing.Size(75, 40);
            this.btnBinary.TabIndex = 5;
            this.btnBinary.Text = "Ảnh nhị phân";
            this.btnBinary.UseVisualStyleBackColor = true;
            this.btnBinary.Click += new System.EventHandler(this.btnBinary_Click);
            // 
            // txtBand
            // 
            this.txtBand.Location = new System.Drawing.Point(17, 32);
            this.txtBand.Name = "txtBand";
            this.txtBand.Size = new System.Drawing.Size(75, 20);
            this.txtBand.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhập band";
            // 
            // btnHistogramGray
            // 
            this.btnHistogramGray.Location = new System.Drawing.Point(15, 20);
            this.btnHistogramGray.Name = "btnHistogramGray";
            this.btnHistogramGray.Size = new System.Drawing.Size(75, 23);
            this.btnHistogramGray.TabIndex = 8;
            this.btnHistogramGray.Text = "Histographic";
            this.btnHistogramGray.UseVisualStyleBackColor = true;
            this.btnHistogramGray.Click += new System.EventHandler(this.btnHistogramGray_Click);
            // 
            // gbxHistogram
            // 
            this.gbxHistogram.Controls.Add(this.btnEqualization);
            this.gbxHistogram.Controls.Add(this.btnFix);
            this.gbxHistogram.Controls.Add(this.lblStretch);
            this.gbxHistogram.Controls.Add(this.txtStretch);
            this.gbxHistogram.Controls.Add(this.btnStretch);
            this.gbxHistogram.Controls.Add(this.btnSub);
            this.gbxHistogram.Controls.Add(this.btnAdd);
            this.gbxHistogram.Controls.Add(this.btnHistogramGray);
            this.gbxHistogram.Location = new System.Drawing.Point(529, 302);
            this.gbxHistogram.Name = "gbxHistogram";
            this.gbxHistogram.Size = new System.Drawing.Size(107, 256);
            this.gbxHistogram.TabIndex = 9;
            this.gbxHistogram.TabStop = false;
            this.gbxHistogram.Text = "Histogram";
            // 
            // btnEqualization
            // 
            this.btnEqualization.Location = new System.Drawing.Point(15, 215);
            this.btnEqualization.Name = "btnEqualization";
            this.btnEqualization.Size = new System.Drawing.Size(75, 23);
            this.btnEqualization.TabIndex = 13;
            this.btnEqualization.Text = "Equalization";
            this.btnEqualization.UseVisualStyleBackColor = true;
            this.btnEqualization.Click += new System.EventHandler(this.btnEqualization_Click);
            // 
            // btnFix
            // 
            this.btnFix.Location = new System.Drawing.Point(15, 175);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(75, 23);
            this.btnFix.TabIndex = 12;
            this.btnFix.Text = "Fix";
            this.btnFix.UseVisualStyleBackColor = true;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // lblStretch
            // 
            this.lblStretch.AutoSize = true;
            this.lblStretch.Location = new System.Drawing.Point(12, 90);
            this.lblStretch.Name = "lblStretch";
            this.lblStretch.Size = new System.Drawing.Size(68, 13);
            this.lblStretch.TabIndex = 8;
            this.lblStretch.Text = "Nhập stretch";
            // 
            // txtStretch
            // 
            this.txtStretch.Location = new System.Drawing.Point(15, 110);
            this.txtStretch.Name = "txtStretch";
            this.txtStretch.Size = new System.Drawing.Size(75, 20);
            this.txtStretch.TabIndex = 8;
            // 
            // btnStretch
            // 
            this.btnStretch.Location = new System.Drawing.Point(15, 136);
            this.btnStretch.Name = "btnStretch";
            this.btnStretch.Size = new System.Drawing.Size(75, 23);
            this.btnStretch.TabIndex = 11;
            this.btnStretch.Text = "Stretch";
            this.btnStretch.UseVisualStyleBackColor = true;
            this.btnStretch.Click += new System.EventHandler(this.btnStretch_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(24, 49);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(25, 25);
            this.btnSub.TabIndex = 10;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(55, 49);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 25);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxBinary
            // 
            this.gbxBinary.Controls.Add(this.btnBinary);
            this.gbxBinary.Controls.Add(this.txtBand);
            this.gbxBinary.Controls.Add(this.label1);
            this.gbxBinary.Location = new System.Drawing.Point(529, 171);
            this.gbxBinary.Name = "gbxBinary";
            this.gbxBinary.Size = new System.Drawing.Size(107, 111);
            this.gbxBinary.TabIndex = 10;
            this.gbxBinary.TabStop = false;
            this.gbxBinary.Text = "Binary";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1180, 620);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTitle);
            this.tabPage1.Controls.Add(this.lblOriginal);
            this.tabPage1.Controls.Add(this.gbxBinary);
            this.tabPage1.Controls.Add(this.picOriginal);
            this.tabPage1.Controls.Add(this.gbxHistogram);
            this.tabPage1.Controls.Add(this.picResult);
            this.tabPage1.Controls.Add(this.btnOpen);
            this.tabPage1.Controls.Add(this.lblResult);
            this.tabPage1.Controls.Add(this.btnGray);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1172, 594);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thao tác trên 1 ảnh";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnOpenPB2);
            this.tabPage2.Controls.Add(this.btnOpenPB1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.pic1);
            this.tabPage2.Controls.Add(this.pic2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1172, 594);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thao tác trên 2 ảnh";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAND
            // 
            this.btnAND.Location = new System.Drawing.Point(11, 19);
            this.btnAND.Name = "btnAND";
            this.btnAND.Size = new System.Drawing.Size(75, 23);
            this.btnAND.TabIndex = 11;
            this.btnAND.Text = "AND";
            this.btnAND.UseVisualStyleBackColor = true;
            this.btnAND.Click += new System.EventHandler(this.btnAND_Click);
            // 
            // btnOpenPB2
            // 
            this.btnOpenPB2.Location = new System.Drawing.Point(546, 129);
            this.btnOpenPB2.Name = "btnOpenPB2";
            this.btnOpenPB2.Size = new System.Drawing.Size(75, 23);
            this.btnOpenPB2.TabIndex = 10;
            this.btnOpenPB2.Text = "Chọn ảnh 2";
            this.btnOpenPB2.UseVisualStyleBackColor = true;
            this.btnOpenPB2.Click += new System.EventHandler(this.btnOpenPB2_Click);
            // 
            // btnOpenPB1
            // 
            this.btnOpenPB1.Location = new System.Drawing.Point(546, 90);
            this.btnOpenPB1.Name = "btnOpenPB1";
            this.btnOpenPB1.Size = new System.Drawing.Size(75, 23);
            this.btnOpenPB1.TabIndex = 9;
            this.btnOpenPB1.Text = "Chọn ảnh 1";
            this.btnOpenPB1.UseVisualStyleBackColor = true;
            this.btnOpenPB1.Click += new System.EventHandler(this.btnOpenPB1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(368, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(401, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "THAO TÁC TRÊN 2 ẢNH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ảnh 1";
            // 
            // pic1
            // 
            this.pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic1.Location = new System.Drawing.Point(8, 77);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(500, 500);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 4;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic2.Location = new System.Drawing.Point(658, 77);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(500, 500);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic2.TabIndex = 6;
            this.pic2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(655, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ảnh 2";
            // 
            // btnOR
            // 
            this.btnOR.Location = new System.Drawing.Point(11, 59);
            this.btnOR.Name = "btnOR";
            this.btnOR.Size = new System.Drawing.Size(75, 23);
            this.btnOR.TabIndex = 12;
            this.btnOR.Text = "OR";
            this.btnOR.UseVisualStyleBackColor = true;
            this.btnOR.Click += new System.EventHandler(this.btnOR_Click);
            // 
            // btnXOR
            // 
            this.btnXOR.Location = new System.Drawing.Point(11, 98);
            this.btnXOR.Name = "btnXOR";
            this.btnXOR.Size = new System.Drawing.Size(75, 23);
            this.btnXOR.TabIndex = 13;
            this.btnXOR.Text = "XOR";
            this.btnXOR.UseVisualStyleBackColor = true;
            this.btnXOR.Click += new System.EventHandler(this.btnXOR_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAND);
            this.groupBox1.Controls.Add(this.btnXOR);
            this.groupBox1.Controls.Add(this.btnOR);
            this.groupBox1.Location = new System.Drawing.Point(533, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 136);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xử lý";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 611);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BIẾN ĐỔI ẢNH";
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.gbxHistogram.ResumeLayout(false);
            this.gbxHistogram.PerformLayout();
            this.gbxBinary.ResumeLayout(false);
            this.gbxBinary.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picOriginal;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnBinary;
        private System.Windows.Forms.TextBox txtBand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHistogramGray;
        private System.Windows.Forms.GroupBox gbxHistogram;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxBinary;
        private System.Windows.Forms.Button btnStretch;
        private System.Windows.Forms.Label lblStretch;
        private System.Windows.Forms.TextBox txtStretch;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnEqualization;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOpenPB2;
        private System.Windows.Forms.Button btnOpenPB1;
        private System.Windows.Forms.Button btnAND;
        private System.Windows.Forms.Button btnOR;
        private System.Windows.Forms.Button btnXOR;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

