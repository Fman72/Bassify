namespace Bassify
{
    partial class ErrorMessageBox
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
            this.exceptionMessageLabel = new System.Windows.Forms.Label();
            this.exceptionStackTraceLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exceptionMessageLabel
            // 
            this.exceptionMessageLabel.AutoSize = true;
            this.exceptionMessageLabel.Location = new System.Drawing.Point(25, 13);
            this.exceptionMessageLabel.Name = "exceptionMessageLabel";
            this.exceptionMessageLabel.Size = new System.Drawing.Size(50, 13);
            this.exceptionMessageLabel.TabIndex = 0;
            this.exceptionMessageLabel.Text = "Message";
            // 
            // exceptionStackTraceLabel
            // 
            this.exceptionStackTraceLabel.AutoSize = true;
            this.exceptionStackTraceLabel.Location = new System.Drawing.Point(25, 37);
            this.exceptionStackTraceLabel.Name = "exceptionStackTraceLabel";
            this.exceptionStackTraceLabel.Size = new System.Drawing.Size(63, 13);
            this.exceptionStackTraceLabel.TabIndex = 2;
            this.exceptionStackTraceLabel.Text = "StackTrace";
            this.exceptionStackTraceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(217, 210);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ErrorMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 273);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.exceptionStackTraceLabel);
            this.Controls.Add(this.exceptionMessageLabel);
            this.Name = "ErrorMessageBox";
            this.Text = "Oops! Looks Like Something Went Wrong!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exceptionMessageLabel;
        private System.Windows.Forms.Label exceptionStackTraceLabel;
        private System.Windows.Forms.Button closeButton;
    }
}