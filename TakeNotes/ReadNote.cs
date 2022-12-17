using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TakeNotes
{
    public partial class ReadNote : Form
    {
        public ReadNote()
        {
            InitializeComponent();
        }

        string path = @"../../../Notes/";
        string noteTitle = string.Empty;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            noteTitle = textBox1.Text;
            descriptionLabel.Visible = false;
            richTextBox1.Visible = false;
            saveButton.Visible = false;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(noteTitle))
                {
                    MessageBox.Show("Note name cannot be empty.");
                    return;
                }
                using (StreamReader reader = new StreamReader(path + noteTitle + ".txt"))
                {
                    descriptionLabel.Visible = true;
                    richTextBox1.Visible = true;
                    saveButton.Visible = true;
                    string text = reader.ReadToEnd();
                    richTextBox1.Text = text;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Note with this name doesn't exist.");
                textBox1.Text = "";
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(path + noteTitle + ".txt"))
            {
                writer.Write(richTextBox1.Text);
            }
            MessageBox.Show("Changes were saved.");
            textBox1.Text = "";
            descriptionLabel.Visible = false;
            richTextBox1.Visible = false;
            saveButton.Visible = false;
        }

        private void backToMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainMenuForm = new MainMenu();
            mainMenuForm.ShowDialog();
            this.Close();
        }

        private void backToMainMenuButton_MouseHover(object sender, EventArgs e)
        {
            backToMainMenuButton.ForeColor = Color.White;
        }

        private void backToMainMenuButton_MouseLeave(object sender, EventArgs e)
        {
            backToMainMenuButton.ForeColor = Color.Black;
        }

        private void openButton_MouseHover(object sender, EventArgs e)
        {
            openButton.ForeColor = Color.White;
        }

        private void openButton_MouseLeave(object sender, EventArgs e)
        {
            openButton.ForeColor = Color.Black;
        }

        private void saveButton_MouseHover(object sender, EventArgs e)
        {
            saveButton.ForeColor = Color.White;
        }

        private void saveButton_MouseLeave(object sender, EventArgs e)
        {
            saveButton.ForeColor = Color.Black;
        }
    }
}
