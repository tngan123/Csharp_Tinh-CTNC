namespace Csharp_Tinh_tong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnTinhtong = new System.Windows.Forms.Button();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.btnTinhhieu = new System.Windows.Forms.Button();
            this.btnTinhtich = new System.Windows.Forms.Button();
            this.btnTinhthuong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số 1";
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // btnTinhtong
            // 
            this.btnTinhtong.Location = new System.Drawing.Point(103, 237);
            this.btnTinhtong.Name = "btnTinhtong";
            this.btnTinhtong.Size = new System.Drawing.Size(122, 64);
            this.btnTinhtong.TabIndex = 1;
            this.btnTinhtong.Text = "Tính tổng";
            this.btnTinhtong.UseVisualStyleBackColor = true;
            this.btnTinhtong.Click += new System.EventHandler(this.btnTinhtong_Click);
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(388, 55);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(92, 20);
            this.txtSo1.TabIndex = 2;
            this.txtSo1.Text = "1.8";
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(388, 92);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(92, 20);
            this.txtSo2.TabIndex = 4;
            this.txtSo2.Text = "9.1";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(388, 136);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(92, 20);
            this.txtKQ.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số 2";
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.Location = new System.Drawing.Point(384, 176);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(53, 23);
            this.lblKQ.TabIndex = 7;
            this.lblKQ.Text = "Tổng";
            // 
            // btnTinhhieu
            // 
            this.btnTinhhieu.Location = new System.Drawing.Point(264, 237);
            this.btnTinhhieu.Name = "btnTinhhieu";
            this.btnTinhhieu.Size = new System.Drawing.Size(122, 64);
            this.btnTinhhieu.TabIndex = 8;
            this.btnTinhhieu.Text = "Tính hiệu";
            this.btnTinhhieu.UseVisualStyleBackColor = true;
            this.btnTinhhieu.Click += new System.EventHandler(this.btnTinhhieu_Click);
            // 
            // btnTinhtich
            // 
            this.btnTinhtich.Location = new System.Drawing.Point(425, 237);
            this.btnTinhtich.Name = "btnTinhtich";
            this.btnTinhtich.Size = new System.Drawing.Size(122, 64);
            this.btnTinhtich.TabIndex = 9;
            this.btnTinhtich.Text = "Tính  tích";
            this.btnTinhtich.UseVisualStyleBackColor = true;
            this.btnTinhtich.Click += new System.EventHandler(this.btnTinhtich_Click);
            // 
            // btnTinhthuong
            // 
            this.btnTinhthuong.Location = new System.Drawing.Point(586, 237);
            this.btnTinhthuong.Name = "btnTinhthuong";
            this.btnTinhthuong.Size = new System.Drawing.Size(122, 64);
            this.btnTinhthuong.TabIndex = 10;
            this.btnTinhthuong.Text = "Tính thương";
            this.btnTinhthuong.UseVisualStyleBackColor = true;
            this.btnTinhthuong.Click += new System.EventHandler(this.btnTinhthuong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTinhthuong);
            this.Controls.Add(this.btnTinhtich);
            this.Controls.Add(this.btnTinhhieu);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.btnTinhtong);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Chương trình tính CTNC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTinhtong;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Button btnTinhhieu;
        private System.Windows.Forms.Button btnTinhtich;
        private System.Windows.Forms.Button btnTinhthuong;
    }
}

