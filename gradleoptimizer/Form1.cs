using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace csharpuxtest
{
    public partial class Form1 : Form
    {
        private String androidStudioProjectsFolderLocation;
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            var timer = new Stopwatch();
            timer.Start();

            androidStudioProjectsFolderLocation = workingDirEntryTextBox.Text.Replace("\"","");
            workingDirEntryTextBox.Text = androidStudioProjectsFolderLocation;
            List<String> directoryList = new List<String>();
            String[] directoryArray;
            directoryArray = Directory.GetDirectories(androidStudioProjectsFolderLocation);


            


            for (int i = 0; i < directoryArray.Length; i++){

                String cmdCommandString;
                cmdCommandString = String.Format("/c cd {0} && gradlew clean", directoryArray[i]);

                

                if (chkbx_onebyone.Checked)
                {
                    Process cmdproc = new Process();
                    cmdproc.StartInfo.UseShellExecute = true;
                    if(chkbx_hidecmd.Checked) cmdproc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    cmdproc.StartInfo.FileName = "cmd.exe";
                    cmdproc.StartInfo.Arguments = cmdCommandString;
                    cmdproc.Start();
                    cmdproc.WaitForExit();
                  
                }
                else
                {
                    Process cmdproc = new Process();
                    cmdproc.StartInfo.UseShellExecute = true;
                    if (chkbx_hidecmd.Checked) cmdproc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    cmdproc.StartInfo.FileName = "cmd.exe";
                    cmdproc.StartInfo.Arguments = cmdCommandString;
                    cmdproc.Start();
                }


                //System.Diagnostics.Process.Start("CMD.exe", cmdCommandString); //creates dozens of windows...

                statusText.Text = "Processing project: " + directoryArray[i].Replace(androidStudioProjectsFolderLocation, "").Substring(1);
                
              
            }


            timer.Stop();
            statusText.Text = "Done. Took " + timer.Elapsed.ToString(@"m\:ss\.fff");




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
              
            }
            else e.Effect = DragDropEffects.None;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] draggedItems = (string[]) e.Data.GetData(DataFormats.FileDrop);
            FileAttributes attr = File.GetAttributes(draggedItems[0]);

            if (draggedItems.Length > 1) {
                MessageBox.Show("Please drag and drop exactly one folder that contains your Android Studio projects.", "Gradle Cleaner - Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (Directory.Exists(draggedItems[0]) && attr.HasFlag(FileAttributes.Directory))
            {
                workingDirEntryTextBox.Text = draggedItems[0];

            }
            else if(!Directory.Exists(draggedItems[0]) || !attr.HasFlag(FileAttributes.Directory))
            {
                MessageBox.Show("Directory does not exists or is a file. Please drag and drop a folder.", "Gradle Cleaner - Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           

        }

        private void workingDirEntryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(workingDirEntryTextBox.Text))
                {
                    buttonStart.Enabled = true;
                }
                else
                {
                    buttonStart.Enabled = false;
                }
            }
            catch
            {

            }
        }
    }
}
