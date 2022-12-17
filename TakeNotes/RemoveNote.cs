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
    public partial class RemoveNote : Form
    {
        public RemoveNote()
        {
            InitializeComponent();
        }

        string path = @"../../../Notes/";
        string noteTitle = string.Empty;

        private void backToMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainMenuForm = new MainMenu();
            mainMenuForm.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            noteTitle = textBox1.Text;
        }

        private void deleteButton_Click(object sender, EventArgs e)
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

                }
                File.Delete(path + noteTitle + ".txt");
                MessageBox.Show("Successfully deleted note.");
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't find a note with such name.");
            }
            textBox1.Text = "";
        }

        private void backToMainMenuButton_MouseHover(object sender, EventArgs e)
        {
            backToMainMenuButton.ForeColor = Color.White;
        }

        private void backToMainMenuButton_MouseLeave(object sender, EventArgs e)
        {
            backToMainMenuButton.ForeColor = Color.Black;
        }

        private void deleteButton_MouseHover(object sender, EventArgs e)
        {
            deleteButton.ForeColor = Color.White;
        }

        private void deleteButton_MouseLeave(object sender, EventArgs e)
        {
            deleteButton.ForeColor = Color.Black;
        }
    }
}
