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

        private void UpdateForm(bool changed)
        {
            if (!changed && !string.IsNullOrEmpty(currentExcuse.Description))
            {
                this.description.Text = currentExcuse.Description;
                this.results.Text = currentExcuse.Results;
                this.lastUsed.Value = currentExcuse.LastUsed;
                if (!string.IsNullOrEmpty(currentExcuse.ExcusePath))
                {
                    fileDate.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();

                }
                this.Text = "Execuse Manager";
            }
            else
            {
                this.Text = "Execuse Manager*";
            }
            this.formChanged = changed;
        }

        private void folder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedPath = folderBrowserDialog1.SelectedPath;
                open.Enabled = true;
                save.Enabled = true;
                random.Enabled = true;
                description.Enabled = true;
                results.Enabled = true;
                lastUsed.Enabled = true;
            }
        }

        // call the Excuse object methods to open and save, somehow?
        private void open_Click(object sender, EventArgs e)
        {
            if (promptUnsaved())
            {
                openFileDialog1.InitialDirectory = selectedPath;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    currentExcuse = new Excuse(openFileDialog1.FileName);
                    currentExcuse.OpenFile(currentExcuse.ExcusePath);
                    UpdateForm(false);
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentExcuse.Description) && !string.IsNullOrEmpty(currentExcuse.Results))
            {
                saveFileDialog1.InitialDirectory = selectedPath;
                saveFileDialog1.FileName = $"{currentExcuse.Description}.excuse";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    currentExcuse.ExcusePath = saveFileDialog1.FileName;
                    currentExcuse.Save(currentExcuse.ExcusePath);
                    UpdateForm(false);
                    MessageBox.Show("Excuse file written");
                }
            }
            else
            {
                MessageBox.Show("You have to enter an excuse description and result before saving", "Form incomplete");
            }
        }
        private void random_Click(object sender, EventArgs e)
        {
            if (promptUnsaved())
            {
                currentExcuse = new Excuse(selectedPath, rand);
                UpdateForm(false);
            }
        }

        private bool promptUnsaved()
        {
            if (formChanged == false)
            {
                return true;
            }
            if (MessageBox.Show("The current excuse has not been saved, discard changes?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
    }
} 