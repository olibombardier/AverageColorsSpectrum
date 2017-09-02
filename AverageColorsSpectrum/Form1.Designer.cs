namespace AverageColorsSpectrum
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
            this.openFileDialog_imageSelector = new System.Windows.Forms.OpenFileDialog();
            this.label_numberOfFilesSelected = new System.Windows.Forms.Label();
            this.button_imageSelector = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_widthOfStripes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_heightOfSpectrum = new System.Windows.Forms.NumericUpDown();
            this.button_generate = new System.Windows.Forms.Button();
            this.progressBar_completion = new System.Windows.Forms.ProgressBar();
            this.saveFileDialog_saveLocation = new System.Windows.Forms.SaveFileDialog();
            this.button_saveLocation = new System.Windows.Forms.Button();
            this.label_saveLocation = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_widthOfStripes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_heightOfSpectrum)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog_imageSelector
            // 
            this.openFileDialog_imageSelector.Multiselect = true;
            // 
            // label_numberOfFilesSelected
            // 
            this.label_numberOfFilesSelected.AutoSize = true;
            this.label_numberOfFilesSelected.Location = new System.Drawing.Point(93, 24);
            this.label_numberOfFilesSelected.Name = "label_numberOfFilesSelected";
            this.label_numberOfFilesSelected.Size = new System.Drawing.Size(83, 13);
            this.label_numberOfFilesSelected.TabIndex = 1;
            this.label_numberOfFilesSelected.Text = "0 file(s) selected";
            // 
            // button_imageSelector
            // 
            this.button_imageSelector.Location = new System.Drawing.Point(6, 19);
            this.button_imageSelector.Name = "button_imageSelector";
            this.button_imageSelector.Size = new System.Drawing.Size(81, 23);
            this.button_imageSelector.TabIndex = 0;
            this.button_imageSelector.Text = "Choose files...";
            this.button_imageSelector.UseVisualStyleBackColor = true;
            this.button_imageSelector.Click += new System.EventHandler(this.button_imageSelector_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label_numberOfFilesSelected);
            this.groupBox1.Controls.Add(this.button_imageSelector);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 53);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numericUpDown_widthOfStripes);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numericUpDown_heightOfSpectrum);
            this.groupBox2.Location = new System.Drawing.Point(12, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 69);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "pixels";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "pixels";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Width of stripes:";
            // 
            // numericUpDown_widthOfStripes
            // 
            this.numericUpDown_widthOfStripes.Location = new System.Drawing.Point(114, 41);
            this.numericUpDown_widthOfStripes.Name = "numericUpDown_widthOfStripes";
            this.numericUpDown_widthOfStripes.Size = new System.Drawing.Size(101, 20);
            this.numericUpDown_widthOfStripes.TabIndex = 2;
            this.numericUpDown_widthOfStripes.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Height of spectrum: ";
            // 
            // numericUpDown_heightOfSpectrum
            // 
            this.numericUpDown_heightOfSpectrum.Location = new System.Drawing.Point(114, 14);
            this.numericUpDown_heightOfSpectrum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_heightOfSpectrum.Name = "numericUpDown_heightOfSpectrum";
            this.numericUpDown_heightOfSpectrum.Size = new System.Drawing.Size(101, 20);
            this.numericUpDown_heightOfSpectrum.TabIndex = 0;
            this.numericUpDown_heightOfSpectrum.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // button_generate
            // 
            this.button_generate.Location = new System.Drawing.Point(12, 231);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(260, 38);
            this.button_generate.TabIndex = 4;
            this.button_generate.Text = "Generate!";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // progressBar_completion
            // 
            this.progressBar_completion.Location = new System.Drawing.Point(12, 202);
            this.progressBar_completion.Name = "progressBar_completion";
            this.progressBar_completion.Size = new System.Drawing.Size(260, 23);
            this.progressBar_completion.TabIndex = 5;
            // 
            // saveFileDialog_saveLocation
            // 
            this.saveFileDialog_saveLocation.DefaultExt = "png";
            this.saveFileDialog_saveLocation.Filter = "PNG files|*.png";
            // 
            // button_saveLocation
            // 
            this.button_saveLocation.Location = new System.Drawing.Point(6, 19);
            this.button_saveLocation.Name = "button_saveLocation";
            this.button_saveLocation.Size = new System.Drawing.Size(102, 23);
            this.button_saveLocation.TabIndex = 6;
            this.button_saveLocation.Text = "Choose location...";
            this.button_saveLocation.UseVisualStyleBackColor = true;
            this.button_saveLocation.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_saveLocation
            // 
            this.label_saveLocation.AutoSize = true;
            this.label_saveLocation.Location = new System.Drawing.Point(114, 24);
            this.label_saveLocation.Name = "label_saveLocation";
            this.label_saveLocation.Size = new System.Drawing.Size(126, 13);
            this.label_saveLocation.TabIndex = 7;
            this.label_saveLocation.Text = "No location was selected";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_saveLocation);
            this.groupBox3.Controls.Add(this.button_saveLocation);
            this.groupBox3.Location = new System.Drawing.Point(12, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 50);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 277);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.progressBar_completion);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Average Colors Spectrum";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_widthOfStripes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_heightOfSpectrum)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog_imageSelector;
        private System.Windows.Forms.Label label_numberOfFilesSelected;
        private System.Windows.Forms.Button button_imageSelector;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_widthOfStripes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_heightOfSpectrum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar_completion;
        private System.Windows.Forms.Button button_saveLocation;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_saveLocation;
        private System.Windows.Forms.Label label_saveLocation;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

