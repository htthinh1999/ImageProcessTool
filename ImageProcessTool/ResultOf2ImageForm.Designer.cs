namespace ImageProcessTool
{
    partial class ResultOf2ImageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultOf2ImageForm));
            this.picResultOf2Image = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnCLose = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.picResultOf2Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCLose)).BeginInit();
            this.SuspendLayout();
            // 
            // picResultOf2Image
            // 
            this.picResultOf2Image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picResultOf2Image.Location = new System.Drawing.Point(12, 37);
            this.picResultOf2Image.Name = "picResultOf2Image";
            this.picResultOf2Image.Size = new System.Drawing.Size(400, 400);
            this.picResultOf2Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picResultOf2Image.TabIndex = 0;
            this.picResultOf2Image.TabStop = false;
            this.picResultOf2Image.Click += new System.EventHandler(this.picResultOf2Image_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DimGray;
            this.label20.Location = new System.Drawing.Point(7, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(136, 25);
            this.label20.TabIndex = 40;
            this.label20.Text = "ẢNH KẾT QUẢ";
            // 
            // btnCLose
            // 
            this.btnCLose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCLose.Image = ((System.Drawing.Image)(resources.GetObject("btnCLose.Image")));
            this.btnCLose.ImageActive = null;
            this.btnCLose.Location = new System.Drawing.Point(390, 4);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(30, 30);
            this.btnCLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCLose.TabIndex = 41;
            this.btnCLose.TabStop = false;
            this.btnCLose.Zoom = 10;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // ResultOf2ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 440);
            this.Controls.Add(this.btnCLose);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.picResultOf2Image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResultOf2ImageForm";
            this.Text = "ẢNH KẾT QUẢ";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResultOf2ImageForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picResultOf2Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCLose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picResultOf2Image;
        private System.Windows.Forms.Label label20;
        private Bunifu.Framework.UI.BunifuImageButton btnCLose;
    }
}