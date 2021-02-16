
namespace egeEren
{
    partial class liderlik
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
            this.baslikLabel = new System.Windows.Forms.Label();
            this.siralamaLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // baslikLabel
            // 
            this.baslikLabel.BackColor = System.Drawing.Color.Transparent;
            this.baslikLabel.Font = new System.Drawing.Font("Corbel Light", 48F, System.Drawing.FontStyle.Bold);
            this.baslikLabel.ForeColor = System.Drawing.Color.White;
            this.baslikLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.baslikLabel.Location = new System.Drawing.Point(-4, 9);
            this.baslikLabel.Name = "baslikLabel";
            this.baslikLabel.Size = new System.Drawing.Size(1056, 78);
            this.baslikLabel.TabIndex = 1;
            this.baslikLabel.Text = "Liderlik Tablosu";
            this.baslikLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siralamaLbl
            // 
            this.siralamaLbl.BackColor = System.Drawing.Color.Transparent;
            this.siralamaLbl.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siralamaLbl.ForeColor = System.Drawing.Color.White;
            this.siralamaLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.siralamaLbl.Location = new System.Drawing.Point(-4, 116);
            this.siralamaLbl.Name = "siralamaLbl";
            this.siralamaLbl.Size = new System.Drawing.Size(1056, 454);
            this.siralamaLbl.TabIndex = 2;
            this.siralamaLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // liderlik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::egeEren.Properties.Resources.anamenu;
            this.ClientSize = new System.Drawing.Size(1054, 566);
            this.Controls.Add(this.siralamaLbl);
            this.Controls.Add(this.baslikLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "liderlik";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.liderlik_FormClosing);
            this.Load += new System.EventHandler(this.liderlik_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label baslikLabel;
        private System.Windows.Forms.Label siralamaLbl;
    }
}