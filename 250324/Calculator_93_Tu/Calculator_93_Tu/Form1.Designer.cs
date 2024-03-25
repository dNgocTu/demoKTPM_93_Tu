
namespace Calculator_93_Tu
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
            this.lbSo1 = new System.Windows.Forms.Label();
            this.lbSo2 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.bntTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSo1
            // 
            this.lbSo1.AutoSize = true;
            this.lbSo1.Location = new System.Drawing.Point(131, 45);
            this.lbSo1.Name = "lbSo1";
            this.lbSo1.Size = new System.Drawing.Size(29, 13);
            this.lbSo1.TabIndex = 0;
            this.lbSo1.Text = "So 1";
            // 
            // lbSo2
            // 
            this.lbSo2.AutoSize = true;
            this.lbSo2.Location = new System.Drawing.Point(131, 105);
            this.lbSo2.Name = "lbSo2";
            this.lbSo2.Size = new System.Drawing.Size(29, 13);
            this.lbSo2.TabIndex = 0;
            this.lbSo2.Text = "So 2";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(131, 164);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(22, 13);
            this.lbResult.TabIndex = 0;
            this.lbResult.Text = "KQ";
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(276, 45);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(100, 20);
            this.txtSo1.TabIndex = 1;
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(276, 102);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(100, 20);
            this.txtSo2.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(276, 157);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 1;
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(86, 289);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(75, 23);
            this.btnCong.TabIndex = 2;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // bntTru
            // 
            this.bntTru.Location = new System.Drawing.Point(216, 289);
            this.bntTru.Name = "bntTru";
            this.bntTru.Size = new System.Drawing.Size(75, 23);
            this.bntTru.TabIndex = 2;
            this.bntTru.Text = "Trừ";
            this.bntTru.UseVisualStyleBackColor = true;
            this.bntTru.Click += new System.EventHandler(this.bntTru_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(353, 289);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(75, 23);
            this.btnNhan.TabIndex = 2;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(488, 289);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(75, 23);
            this.btnChia.TabIndex = 2;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.bntTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbSo2);
            this.Controls.Add(this.lbSo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSo1;
        private System.Windows.Forms.Label lbSo2;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button bntTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
    }
}

