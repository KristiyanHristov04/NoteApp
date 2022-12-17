using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeNotes
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            if (!Directory.Exists(@"../../../Notes"))
            {
                DirectoryInfo folder = Directory.CreateDirectory(@"../../../Notes");
            }
        }

        private void createNoteButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var createNoteForm = new CreateNote();
            createNoteForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var readNoteForm = new ReadNote();
            readNoteForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var removeNoteForm = new RemoveNote();
            removeNoteForm.ShowDialog();
            this.Close();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void createNoteButton_MouseHover(object sender, EventArgs e)
        {
            createNoteButton.ForeColor = Color.White;
        }

        private void createNoteButton_MouseLeave(object sender, EventArgs e)
        {
            createNoteButton.ForeColor = Color.Black;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
        }
    }
}
