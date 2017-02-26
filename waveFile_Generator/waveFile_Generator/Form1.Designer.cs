namespace waveFile_Generator
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
            this.genSinWave_btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // genSinWave_btn
            // 
            this.genSinWave_btn.Location = new System.Drawing.Point(36, 29);
            this.genSinWave_btn.Name = "genSinWave_btn";
            this.genSinWave_btn.Size = new System.Drawing.Size(216, 53);
            this.genSinWave_btn.TabIndex = 0;
            this.genSinWave_btn.Text = "Generate Sine Wave";
            this.genSinWave_btn.UseVisualStyleBackColor = true;
            this.genSinWave_btn.Click += new System.EventHandler(this.genSinWave_btn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(285, 110);
            this.Controls.Add(this.genSinWave_btn);
            this.Name = "Form1";
            this.Text = "waveGen";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button genSinWave_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

