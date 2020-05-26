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
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picResultOf2Image)).BeginInit();
            this.SuspendLayout();
            // 
            // picResultOf2Image
            // 
            this.picResultOf2Image.Location = new System.Drawing.Point(12, 25);
            this.picResultOf2Image.Name = "picResultOf2Image";
            this.picResultOf2Image.Size = new System.Drawing.Size(500, 500);
            this.picResultOf2Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picResultOf2Image.TabIndex = 0;
            this.picResultOf2Image.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(9, 9);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(76, 13);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Ảnh kết quả";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultOf2ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 536);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.picResultOf2Image);
            this.Name = "ResultOf2ImageForm";
            this.Text = "ResultOf2ImageForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResultOf2ImageForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picResultOf2Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picResultOf2Image;
        private System.Windows.Forms.Label lblResult;
    }
}