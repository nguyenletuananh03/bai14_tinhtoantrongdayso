namespace bai14_tinhtoantrongdayso
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
            this.btntinh = new System.Windows.Forms.Button();
            this.txtso1 = new System.Windows.Forms.TextBox();
            this.txtso2 = new System.Windows.Forms.TextBox();
            this.txtle = new System.Windows.Forms.TextBox();
            this.txtchan = new System.Windows.Forms.TextBox();
            this.txttong = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(246, 170);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(105, 23);
            this.btntinh.TabIndex = 0;
            this.btntinh.Text = "tính ";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // txtso1
            // 
            this.txtso1.Location = new System.Drawing.Point(246, 50);
            this.txtso1.Name = "txtso1";
            this.txtso1.Size = new System.Drawing.Size(105, 20);
            this.txtso1.TabIndex = 1;
            // 
            // txtso2
            // 
            this.txtso2.Location = new System.Drawing.Point(246, 109);
            this.txtso2.Name = "txtso2";
            this.txtso2.Size = new System.Drawing.Size(105, 20);
            this.txtso2.TabIndex = 1;
            // 
            // txtle
            // 
            this.txtle.Location = new System.Drawing.Point(383, 109);
            this.txtle.Name = "txtle";
            this.txtle.Size = new System.Drawing.Size(105, 20);
            this.txtle.TabIndex = 1;
            // 
            // txtchan
            // 
            this.txtchan.Location = new System.Drawing.Point(383, 50);
            this.txtchan.Name = "txtchan";
            this.txtchan.Size = new System.Drawing.Size(105, 20);
            this.txtchan.TabIndex = 1;
            // 
            // txttong
            // 
            this.txttong.Location = new System.Drawing.Point(383, 170);
            this.txttong.Name = "txttong";
            this.txttong.Size = new System.Drawing.Size(105, 20);
            this.txttong.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttong);
            this.Controls.Add(this.txtchan);
            this.Controls.Add(this.txtle);
            this.Controls.Add(this.txtso2);
            this.Controls.Add(this.txtso1);
            this.Controls.Add(this.btntinh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.TextBox txtso1;
        private System.Windows.Forms.TextBox txtso2;
        private System.Windows.Forms.TextBox txtle;
        private System.Windows.Forms.TextBox txtchan;
        private System.Windows.Forms.TextBox txttong;
    }
}

