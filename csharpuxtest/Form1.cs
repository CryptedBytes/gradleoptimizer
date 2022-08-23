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

            androidStudioProjectsFolderLocation = textBox1.Text.Replace("\"","");
            textBox1.Text = androidStudioProjectsFolderLocation;
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
    }
}
