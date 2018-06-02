namespace FiveColors2
{
    partial class FiveColors2
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
            this.optRed = new System.Windows.Forms.RadioButton();
            this.optOrange = new System.Windows.Forms.RadioButton();
            this.optGreen = new System.Windows.Forms.RadioButton();
            this.optBlue = new System.Windows.Forms.RadioButton();
            this.optPurple = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // optRed
            // 
            this.optRed.AutoSize = true;
            this.optRed.Location = new System.Drawing.Point(41, 36);
            this.optRed.Name = "optRed";
            this.optRed.Size = new System.Drawing.Size(82, 29);
            this.optRed.TabIndex = 0;
            this.optRed.TabStop = true;
            this.optRed.Text = "Red";
            this.optRed.UseVisualStyleBackColor = true;
            // 
            // optOrange
            // 
            this.optOrange.AutoSize = true;
            this.optOrange.Location = new System.Drawing.Point(142, 36);
            this.optOrange.Name = "optOrange";
            this.optOrange.Size = new System.Drawing.Size(114, 29);
            this.optOrange.TabIndex = 1;
            this.optOrange.TabStop = true;
            this.optOrange.Text = "Orange";
            this.optOrange.UseVisualStyleBackColor = true;
            // 
            // optGreen
            // 
            this.optGreen.AutoSize = true;
            this.optGreen.Location = new System.Drawing.Point(274, 36);
            this.optGreen.Name = "optGreen";
            this.optGreen.Size = new System.Drawing.Size(102, 29);
            this.optGreen.TabIndex = 2;
            this.optGreen.TabStop = true;
            this.optGreen.Text = "Green";
            this.optGreen.UseVisualStyleBackColor = true;
            // 
            // optBlue
            // 
            this.optBlue.AutoSize = true;
            this.optBlue.Location = new System.Drawing.Point(391, 36);
            this.optBlue.Name = "optBlue";
            this.optBlue.Size = new System.Drawing.Size(86, 29);
            this.optBlue.TabIndex = 3;
            this.optBlue.TabStop = true;
            this.optBlue.Text = "Blue";
            this.optBlue.UseVisualStyleBackColor = true;
            // 
            // optPurple
            // 
            this.optPurple.AutoSize = true;
            this.optPurple.Location = new System.Drawing.Point(493, 36);
            this.optPurple.Name = "optPurple";
            this.optPurple.Size = new System.Drawing.Size(105, 29);
            this.optPurple.TabIndex = 4;
            this.optPurple.TabStop = true;
            this.optPurple.Text = "Purple";
            this.optPurple.UseVisualStyleBackColor = true;
            // 
            // FiveColors2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 114);
            this.Controls.Add(this.optPurple);
            this.Controls.Add(this.optBlue);
            this.Controls.Add(this.optGreen);
            this.Controls.Add(this.optOrange);
            this.Controls.Add(this.optRed);
            this.Name = "FiveColors2";
            this.Text = "FiveColors2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton optRed;
        private System.Windows.Forms.RadioButton optOrange;
        private System.Windows.Forms.RadioButton optGreen;
        private System.Windows.Forms.RadioButton optBlue;
        private System.Windows.Forms.RadioButton optPurple;
    }
}

