﻿
namespace egeEren
{
    partial class kayitOl
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
            this.components = new System.ComponentModel.Container();
            this.kayitBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kullaniciTxt = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cikisLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // kayitBtn
            // 
            this.kayitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitBtn.Location = new System.Drawing.Point(50, 158);
            this.kayitBtn.Name = "kayitBtn";
            this.kayitBtn.Size = new System.Drawing.Size(138, 36);
            this.kayitBtn.TabIndex = 9;
            this.kayitBtn.Text = "Kayıt Ol";
            this.kayitBtn.UseVisualStyleBackColor = true;
            this.kayitBtn.Click += new System.EventHandler(this.kayitBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifre";
            // 
            // sifreTxt
            // 
            this.sifreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTxt.Location = new System.Drawing.Point(50, 118);
            this.sifreTxt.MaxLength = 128;
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.PasswordChar = '*';
            this.sifreTxt.Size = new System.Drawing.Size(138, 24);
            this.sifreTxt.TabIndex = 7;
            this.sifreTxt.Validating += new System.ComponentModel.CancelEventHandler(this.sifreTxt_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // kullaniciTxt
            // 
            this.kullaniciTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciTxt.Location = new System.Drawing.Point(50, 57);
            this.kullaniciTxt.MaxLength = 32;
            this.kullaniciTxt.Name = "kullaniciTxt";
            this.kullaniciTxt.Size = new System.Drawing.Size(138, 24);
            this.kullaniciTxt.TabIndex = 5;
            this.kullaniciTxt.Validating += new System.ComponentModel.CancelEventHandler(this.kullaniciTxt_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // cikisLbl
            // 
            this.cikisLbl.AutoSize = true;
            this.cikisLbl.BackColor = System.Drawing.Color.Transparent;
            this.cikisLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikisLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisLbl.ForeColor = System.Drawing.Color.White;
            this.cikisLbl.Location = new System.Drawing.Point(200, -2);
            this.cikisLbl.Name = "cikisLbl";
            this.cikisLbl.Size = new System.Drawing.Size(35, 39);
            this.cikisLbl.TabIndex = 10;
            this.cikisLbl.Text = "x";
            this.cikisLbl.Click += new System.EventHandler(this.cikisLbl_Click);
            // 
            // kayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::egeEren.Properties.Resources.bg_panel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(235, 231);
            this.Controls.Add(this.cikisLbl);
            this.Controls.Add(this.kayitBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kullaniciTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kayitOl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kayitOl";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kayitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sifreTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kullaniciTxt;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label cikisLbl;
    }
}