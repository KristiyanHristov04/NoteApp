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
    public partial class CreateNote : Form
    {
        public CreateNote()
        {
            InitializeComponent();
        }

        string path = @"../../../Notes/";
        string noteTitle = string.Empty;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            noteTitle = textBox1.Text;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(noteTitle))
            {
                MessageBox.Show("Note name cannot be empty.");
                richTextBox1.Text = "";
                return;
            }
            try
            {
                using (StreamReader reader = new StreamReader(path + noteTitle + ".txt"))
                {
                    MessageBox.Show("Note with this name already exists.");
                }
            }
            catch (Exception)
            {
                using (StreamWriter writer = new StreamWriter(path + noteTitle + ".txt"))
                {
                    writer.Write(richTextBox1.Text);
                    MessageBox.Show($"Successfully created note with name: {noteTitle}");
                }
            }
            textBox1.Text = string.Empty;
            richTextBox1.Text = string.Empty;
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
