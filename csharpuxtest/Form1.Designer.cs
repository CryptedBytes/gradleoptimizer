namespace csharpuxtest
{
    partial class Form1
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusText = new System.Windows.Forms.Label();
            this.chkbx_onebyone = new System.Windows.Forms.CheckBox();
            this.chkbx_hidecmd = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Location = new System.Drawing.Point(8, 103);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(303, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Android Projects folder location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gradle optimizer for Android Studio";
            // 
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusText.Location = new System.Drawing.Point(5, 189);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(35, 13);
            this.statusText.TabIndex = 4;
            this.statusText.Text = "IDLE";
            // 
            // chkbx_onebyone
            // 
            this.chkbx_onebyone.AutoSize = true;
            this.chkbx_onebyone.Checked = true;
            this.chkbx_onebyone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbx_onebyone.Location = new System.Drawing.Point(8, 133);
            this.chkbx_onebyone.Name = "chkbx_onebyone";
            this.chkbx_onebyone.Size = new System.Drawing.Size(122, 17);
            this.chkbx_onebyone.TabIndex = 5;
            this.chkbx_onebyone.Text = "Optimize one by one";
            this.chkbx_onebyone.UseVisualStyleBackColor = true;
            // 
            // chkbx_hidecmd
            // 
            this.chkbx_hidecmd.AutoSize = true;
            this.chkbx_hidecmd.Checked = true;
            this.chkbx_hidecmd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbx_hidecmd.Location = new System.Drawing.Point(8, 156);
            this.chkbx_hidecmd.Name = "chkbx_hidecmd";
            this.chkbx_hidecmd.Size = new System.Drawing.Size(132, 17);
            this.chkbx_hidecmd.TabIndex = 6;
            this.chkbx_hidecmd.Text = "Hide console windows";
            this.chkbx_hidecmd.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Run gradle clean on all projects at once!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(317, 209);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkbx_hidecmd);
            this.Controls.Add(this.chkbx_onebyone);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gradle optimizer by CB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statusText;
        private System.Windows.Forms.CheckBox chkbx_onebyone;
        private System.Windows.Forms.CheckBox chkbx_hidecmd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

