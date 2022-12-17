namespace TakeNotes
{
    partial class ReadNote
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
            this.saveButton = new System.Windows.Forms.Button();
            this.backToMainMenuButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(108, 438);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(138, 46);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            this.saveButton.MouseLeave += new System.EventHandler(this.saveButton_MouseLeave);
            this.saveButton.MouseHover += new System.EventHandler(this.saveButton_MouseHover);
            // 
            // backToMainMenuButton
            // 
            this.backToMainMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToMainMenuButton.FlatAppearance.BorderSize = 0;
            this.backToMainMenuButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.backToMainMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backToMainMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backToMainMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToMainMenuButton.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backToMainMenuButton.Location = new System.Drawing.Point(10, 8);
            this.backToMainMenuButton.Name = "backToMainMenuButton";
            this.backToMainMenuButton.Size = new System.Drawing.Size(96, 39);
            this.backToMainMenuButton.TabIndex = 10;
            this.backToMainMenuButton.Text = "BACK";
            this.backToMainMenuButton.UseVisualStyleBackColor = true;
            this.backToMainMenuButton.Click += new System.EventHandler(this.backToMainMenuButton_Click);
            this.backToMainMenuButton.MouseLeave += new System.EventHandler(this.backToMainMenuButton_MouseLeave);
            this.backToMainMenuButton.MouseHover += new System.EventHandler(this.backToMainMenuButton_MouseHover);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(66, 226);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(243, 206);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.Location = new System.Drawing.Point(97, 186);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(182, 30);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = "DESCRIPTION:";
            this.descriptionLabel.Visible = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(136, 52);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(92, 30);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "TITLE:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(66, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 29);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openButton
            // 
            this.openButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openButton.FlatAppearance.BorderSize = 0;
            this.openButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.openButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.openButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButton.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openButton.Location = new System.Drawing.Point(136, 114);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(89, 46);
            this.openButton.TabIndex = 12;
            this.openButton.Text = "OPEN";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            this.openButton.MouseLeave += new System.EventHandler(this.openButton_MouseLeave);
            this.openButton.MouseHover += new System.EventHandler(this.openButton_MouseHover);
            // 
            // ReadNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(372, 487);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.backToMainMenuButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.textBox1);
            this.Name = "ReadNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReadNote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button backToMainMenuButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button openButton;
    }
}