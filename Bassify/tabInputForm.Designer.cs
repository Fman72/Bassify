namespace Bassify
{
    partial class TabInputForm
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
            this.bassifyButton = new System.Windows.Forms.Button();
            this.tabInputTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // bassifyButton
            // 
            this.bassifyButton.Location = new System.Drawing.Point(568, 608);
            this.bassifyButton.Name = "bassifyButton";
            this.bassifyButton.Size = new System.Drawing.Size(75, 23);
            this.bassifyButton.TabIndex = 0;
            this.bassifyButton.Text = "Bassify!";
            this.bassifyButton.UseVisualStyleBackColor = true;
            this.bassifyButton.Click += new System.EventHandler(this.bassifyButton_Click);
            // 
            // tabInputTextBox
            // 
            this.tabInputTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabInputTextBox.Location = new System.Drawing.Point(12, 12);
            this.tabInputTextBox.Name = "tabInputTextBox";
            this.tabInputTextBox.Size = new System.Drawing.Size(1173, 590);
            this.tabInputTextBox.TabIndex = 1;
            this.tabInputTextBox.Text = "";
            this.tabInputTextBox.TextChanged += new System.EventHandler(this.tabInputTextBox_TextChanged);
            // 
            // tabInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 643);
            this.Controls.Add(this.tabInputTextBox);
            this.Controls.Add(this.bassifyButton);
            this.Name = "tabInputForm";
            this.Text = "Tab Input Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bassifyButton;
        private System.Windows.Forms.RichTextBox tabInputTextBox;
    }
}

