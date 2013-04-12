namespace httpDownloader
{
    partial class VSWGet
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.dlbt = new System.Windows.Forms.Button();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 40);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(492, 19);
            this.progressBar.TabIndex = 0;
            // 
            // dlbt
            // 
            this.dlbt.Location = new System.Drawing.Point(393, 12);
            this.dlbt.Name = "dlbt";
            this.dlbt.Size = new System.Drawing.Size(111, 23);
            this.dlbt.TabIndex = 1;
            this.dlbt.Text = "Download";
            this.dlbt.UseVisualStyleBackColor = true;
            this.dlbt.Click += new System.EventHandler(this.button1_Click);
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(12, 12);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(375, 22);
            this.urlBox.TabIndex = 2;
            // 
            // VSWGet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 78);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.dlbt);
            this.Controls.Add(this.progressBar);
            this.Name = "VSWGet";
            this.Text = "VerySimpleWGet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button dlbt;
        private System.Windows.Forms.TextBox urlBox;
    }
}

