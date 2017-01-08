namespace Bassify
{
    partial class TabViewingForm
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
            this.tabController = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cleanGuitarTabTextBox = new System.Windows.Forms.RichTextBox();
            this.bassTabTextBox = new System.Windows.Forms.RichTextBox();
            this.tabController.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.tabPage1);
            this.tabController.Controls.Add(this.tabPage2);
            this.tabController.Location = new System.Drawing.Point(12, 1);
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(1206, 634);
            this.tabController.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bassTabTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1198, 608);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bass Tab";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cleanGuitarTabTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1198, 608);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cleaned Guitar Tab";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CleanGuitarTabTextBox
            // 
            this.cleanGuitarTabTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleanGuitarTabTextBox.Location = new System.Drawing.Point(6, 6);
            this.cleanGuitarTabTextBox.Name = "CleanGuitarTabTextBox";
            this.cleanGuitarTabTextBox.ReadOnly = true;
            this.cleanGuitarTabTextBox.Size = new System.Drawing.Size(1186, 596);
            this.cleanGuitarTabTextBox.TabIndex = 1;
            this.cleanGuitarTabTextBox.Text = "";
            // 
            // bassTabTextBox
            // 
            this.bassTabTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bassTabTextBox.Location = new System.Drawing.Point(7, 7);
            this.bassTabTextBox.Name = "bassTabTextBox";
            this.bassTabTextBox.ReadOnly = true;
            this.bassTabTextBox.Size = new System.Drawing.Size(1185, 595);
            this.bassTabTextBox.TabIndex = 0;
            this.bassTabTextBox.Text = "";
            // 
            // TabViewingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 647);
            this.Controls.Add(this.tabController);
            this.Name = "TabViewingForm";
            this.Text = "View Tab";
            this.tabController.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabController;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox cleanGuitarTabTextBox;
        private System.Windows.Forms.RichTextBox bassTabTextBox;

    }
}