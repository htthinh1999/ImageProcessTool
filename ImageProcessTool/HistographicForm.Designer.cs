namespace ImageProcessTool
{
    partial class HistographicForm
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
            this.ptxHistographic = new System.Windows.Forms.PictureBox();
            this.lblHistographic = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptxHistographic)).BeginInit();
            this.SuspendLayout();
            // 
            // ptxHistographic
            // 
            this.ptxHistographic.Location = new System.Drawing.Point(12, 25);
            this.ptxHistographic.Name = "ptxHistographic";
            this.ptxHistographic.Size = new System.Drawing.Size(450, 200);
            this.ptxHistographic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptxHistographic.TabIndex = 0;
            this.ptxHistographic.TabStop = false;
            // 
            // lblHistographic
            // 
            this.lblHistographic.AutoSize = true;
            this.lblHistographic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistographic.Location = new System.Drawing.Point(12, 9);
            this.lblHistographic.Name = "lblHistographic";
            this.lblHistographic.Size = new System.Drawing.Size(99, 13);
            this.lblHistographic.TabIndex = 1;
            this.lblHistographic.Text = "Đồ thị histogram";
            // 
            // HistographicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 236);
            this.Controls.Add(this.lblHistographic);
            this.Controls.Add(this.ptxHistographic);
            this.Name = "HistographicForm";
            this.Text = "Histographic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HistographicForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ptxHistographic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptxHistographic;
        private System.Windows.Forms.Label lblHistographic;
    }
}