namespace ConsumeWCF
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbToConvert = new System.Windows.Forms.TextBox();
            this.btCnv = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Put the number here";
            // 
            // tbToConvert
            // 
            this.tbToConvert.Location = new System.Drawing.Point(24, 38);
            this.tbToConvert.Name = "tbToConvert";
            this.tbToConvert.Size = new System.Drawing.Size(100, 22);
            this.tbToConvert.TabIndex = 1;
            // 
            // btCnv
            // 
            this.btCnv.Location = new System.Drawing.Point(153, 38);
            this.btCnv.Name = "btCnv";
            this.btCnv.Size = new System.Drawing.Size(75, 23);
            this.btCnv.TabIndex = 2;
            this.btCnv.Text = "Convert";
            this.btCnv.UseVisualStyleBackColor = true;
            this.btCnv.Click += new System.EventHandler(this.btCnv_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(272, 38);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(320, 22);
            this.tbResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btCnv);
            this.Controls.Add(this.tbToConvert);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbToConvert;
        private System.Windows.Forms.Button btCnv;
        private System.Windows.Forms.TextBox tbResult;
    }
}

