
namespace SeleniumWebDriver_93_Tu
{
    partial class Form1
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
            this.btnOpenUrl_93_Tu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOpenBrowser_93_Tu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenUrl_93_Tu
            // 
            this.btnOpenUrl_93_Tu.Location = new System.Drawing.Point(217, 110);
            this.btnOpenUrl_93_Tu.Name = "btnOpenUrl_93_Tu";
            this.btnOpenUrl_93_Tu.Size = new System.Drawing.Size(116, 36);
            this.btnOpenUrl_93_Tu.TabIndex = 0;
            this.btnOpenUrl_93_Tu.Text = "OpenUrl";
            this.btnOpenUrl_93_Tu.UseVisualStyleBackColor = true;
            this.btnOpenUrl_93_Tu.Click += new System.EventHandler(this.btnOpenUrl_93_Tu_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(91, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnOpenBrowser_93_Tu
            // 
            this.btnOpenBrowser_93_Tu.Location = new System.Drawing.Point(566, 57);
            this.btnOpenBrowser_93_Tu.Name = "btnOpenBrowser_93_Tu";
            this.btnOpenBrowser_93_Tu.Size = new System.Drawing.Size(151, 57);
            this.btnOpenBrowser_93_Tu.TabIndex = 3;
            this.btnOpenBrowser_93_Tu.Text = "OpenBrowser";
            this.btnOpenBrowser_93_Tu.UseVisualStyleBackColor = true;
            this.btnOpenBrowser_93_Tu.Click += new System.EventHandler(this.btnOpenBrowser_93_Tu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenBrowser_93_Tu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenUrl_93_Tu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenUrl_93_Tu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOpenBrowser_93_Tu;
    }
}

