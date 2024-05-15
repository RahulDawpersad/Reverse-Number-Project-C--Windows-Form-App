
namespace ReverseNumbersProject
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
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblNum3 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.btnReverseNumbers = new System.Windows.Forms.Button();
            this.reversedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(162, 95);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(56, 13);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Number 1:";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(263, 95);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(56, 13);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "Number 2:";
            // 
            // lblNum3
            // 
            this.lblNum3.AutoSize = true;
            this.lblNum3.Location = new System.Drawing.Point(370, 95);
            this.lblNum3.Name = "lblNum3";
            this.lblNum3.Size = new System.Drawing.Size(56, 13);
            this.lblNum3.TabIndex = 2;
            this.lblNum3.Text = "Number 3:";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(137, 128);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 3;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(243, 128);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 4;
            // 
            // txtNum3
            // 
            this.txtNum3.Location = new System.Drawing.Point(349, 128);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(100, 20);
            this.txtNum3.TabIndex = 5;
            // 
            // btnReverseNumbers
            // 
            this.btnReverseNumbers.Location = new System.Drawing.Point(205, 247);
            this.btnReverseNumbers.Name = "btnReverseNumbers";
            this.btnReverseNumbers.Size = new System.Drawing.Size(157, 41);
            this.btnReverseNumbers.TabIndex = 6;
            this.btnReverseNumbers.Text = "Reverse Numbers";
            this.btnReverseNumbers.UseVisualStyleBackColor = true;
            this.btnReverseNumbers.Click += new System.EventHandler(this.btnReverseNumbers_Click);
            // 
            // reversedLabel
            // 
            this.reversedLabel.AutoSize = true;
            this.reversedLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reversedLabel.Location = new System.Drawing.Point(226, 195);
            this.reversedLabel.Name = "reversedLabel";
            this.reversedLabel.Size = new System.Drawing.Size(93, 13);
            this.reversedLabel.TabIndex = 7;
            this.reversedLabel.Text = "The numbers are :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.reversedLabel);
            this.Controls.Add(this.btnReverseNumbers);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblNum3);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reverse Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblNum3;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.Button btnReverseNumbers;
        private System.Windows.Forms.Label reversedLabel;
    }
}

