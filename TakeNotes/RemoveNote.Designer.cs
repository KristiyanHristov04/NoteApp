namespace TakeNotes
{
    partial class RemoveNote
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.backToMainMenuButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(110, 116);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(138, 46);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            this.deleteButton.MouseLeave += new System.EventHandler(this.deleteButton_MouseLeave);
            this.deleteButton.MouseHover += new System.EventHandler(this.deleteButton_MouseHover);
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
            this.backToMainMenuButton.TabIndex = 15;
            this.backToMainMenuButton.Text = "BACK";
            this.backToMainMenuButton.UseVisualStyleBackColor = true;
            this.backToMainMenuButton.Click += new System.EventHandler(this.backToMainMenuButton_Click);
            this.backToMainMenuButton.MouseLeave += new System.EventHandler(this.backToMainMenuButton_MouseLeave);
            this.backToMainMenuButton.MouseHover += new System.EventHandler(this.backToMainMenuButton_MouseHover);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(136, 52);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(92, 30);
            this.titleLabel.TabIndex = 14;
            this.titleLabel.Text = "TITLE:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(66, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 29);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RemoveNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(372, 487);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.backToMainMenuButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.textBox1);
            this.Name = "RemoveNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveNote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button backToMainMenuButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}