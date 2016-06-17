using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pg431ExcuseManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            currentExcuse.LastUsed = lastUsed.Value;
        }

        bool formChanged;
        Excuse currentExcuse = new Excuse();
        string selectedPath = "";
        Random rand = new Random();

        // trying new-fangled expression-bodied syntax for one line methods
        private void description_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Description = description.Text;
            UpdateForm(true);
        }

        private void results_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Results = results.Text;
            UpdateForm(true);
        }

        private void lastUsed_ValueChanged(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = lastUsed.Value;
            UpdateForm(true);
        }

        // why does the provided code have 'this' ... does it not belong in the form?
        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                this.description.Text = currentExcuse.Description;
                this.results.Text = currentExcuse.Results;
                this.lastUsed.Value = currentExcuse.LastUsed;
                if (!string.IsNullOrEmpty(currentExcuse.ExcusePath))
                {
                    fileDate.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                    this.Text = "Execuse Manager";
                }
                else
                {
                    this.Text = "Execuse Manager*";
                }
                
                // wtf is this?
                this.formChanged = changed;
            }
        }

        private void folder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedPath = folderBrowserDialog1.SelectedPath;
                open.Enabled = true;
                save.Enabled = true;
                random.Enabled = true;
            }
        }

        // call the Excuse object methods to open and save, somehow?
        private void open_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = selectedPath;
            Excuse excuse = new Excuse(selectedPath);

        }

        private void save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = selectedPath;
            // stuff
            MessageBox.Show("Excuse file written");
        }

        private void random_Click(object sender, EventArgs e)
        {
            Excuse excuse = new Excuse(rand.Next());
        }
    }
}