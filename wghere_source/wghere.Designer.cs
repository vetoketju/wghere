namespace httpDownloader
{
    partial class wghere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wghere));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.dlbt = new System.Windows.Forms.Button();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(9, 34);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(558, 18);
            this.progressBar.TabIndex = 0;
            // 
            // dlbt
            // 
            this.dlbt.Location = new System.Drawing.Point(484, 10);
            this.dlbt.Margin = new System.Windows.Forms.Padding(2);
            this.dlbt.Name = "dlbt";
            this.dlbt.Size = new System.Drawing.Size(83, 22);
            this.dlbt.TabIndex = 1;
            this.dlbt.Text = "Download";
            this.dlbt.UseVisualStyleBackColor = true;
            this.dlbt.Click += new System.EventHandler(this.button1_Click);
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(9, 11);
            this.urlBox.Margin = new System.Windows.Forms.Padding(2);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(471, 20);
            this.urlBox.TabIndex = 2;
            // 
            // wghere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 64);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.dlbt);
            this.Controls.Add(this.progressBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "wghere";
            this.Text = "wghere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button dlbt;
        private System.Windows.Forms.TextBox urlBox;
    }
}

