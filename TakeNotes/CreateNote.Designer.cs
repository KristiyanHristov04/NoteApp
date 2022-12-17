namespace TakeNotes
{
    partial class CreateNote
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.backToMainMenuButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(66, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(136, 52);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(92, 30);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "TITLE:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.Location = new System.Drawing.Point(97, 186);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(182, 30);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "DESCRIPTION:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(66, 226);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(243, 206);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // backToMainMenuButton
            // 
            this.backToMainMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToMainMenuButton.FlatAppearance.BorderSize = 0;
            this.backToMainMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backToMainMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backToMainMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToMainMenuButton.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backToMainMenuButton.Location = new System.Drawing.Point(10, 8);
            this.backToMainMenuButton.Name = "backToMainMenuButton";
            this.backToMainMenuButton.Size = new System.Drawing.Size(96, 39);
            this.backToMainMenuButton.TabIndex = 4;
            this.backToMainMenuButton.Text = "BACK";
            this.backToMainMenuButton.UseVisualStyleBackColor = true;
            this.backToMainMenuButton.Click += new System.EventHandler(this.backToMainMenuButton_Click);
            this.backToMainMenuButton.MouseLeave += new System.EventHandler(this.backToMainMenuButton_MouseLeave);
            this.backToMainMenuButton.MouseHover += new System.EventHandler(this.backToMainMenuButton_MouseHover);
            // 
            // saveButton
            // 
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(108, 438);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(138, 46);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            this.saveButton.MouseLeave += new System.EventHandler(this.saveButton_MouseLeave);
            this.saveButton.MouseHover += new System.EventHandler(this.saveButton_MouseHover);
            // 
            // CreateNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(372, 487);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.backToMainMenuButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.textBox1);
            this.Name = "CreateNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateNote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button backToMainMenuButton;
        private System.Windows.Forms.Button saveButton;
    }
}