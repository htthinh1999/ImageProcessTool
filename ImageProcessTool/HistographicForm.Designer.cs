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
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptxHistographic)).BeginInit();
            this.SuspendLayout();
            // 
            // ptxHistographic
            // 
            this.ptxHistographic.Location = new System.Drawing.Point(12, 37);
            this.ptxHistographic.Name = "ptxHistographic";
            this.ptxHistographic.Size = new System.Drawing.Size(450, 200);
            this.ptxHistographic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptxHistographic.TabIndex = 0;
            this.ptxHistographic.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DimGray;
            this.label20.Location = new System.Drawing.Point(7, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(143, 25);
            this.label20.TabIndex = 40;
            this.label20.Text = "LƯỢC ĐỒ XÁM";
            // 
            // HistographicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 251);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.ptxHistographic);
            this.Name = "HistographicForm";
            this.Text = "LƯỢC ĐỒ XÁM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HistographicForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ptxHistographic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptxHistographic;
        private System.Windows.Forms.Label label20;
    }
}