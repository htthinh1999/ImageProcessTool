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
            this.picResultOf2Image = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picResultOf2Image)).BeginInit();
            this.SuspendLayout();
            // 
            // picResultOf2Image
            // 
            this.picResultOf2Image.Location = new System.Drawing.Point(12, 37);
            this.picResultOf2Image.Name = "picResultOf2Image";
            this.picResultOf2Image.Size = new System.Drawing.Size(500, 500);
            this.picResultOf2Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picResultOf2Image.TabIndex = 0;
            this.picResultOf2Image.TabStop = false;
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
            // ResultOf2ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 551);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.picResultOf2Image);
            this.Name = "ResultOf2ImageForm";
            this.Text = "ẢNH KẾT QUẢ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResultOf2ImageForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picResultOf2Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picResultOf2Image;
        private System.Windows.Forms.Label label20;
    }
}