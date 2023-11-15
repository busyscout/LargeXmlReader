
namespace LargeXmlReader
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numElementsCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtElementName = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.btnReadSample = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numSampleOffset = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numSampleBytes = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numElementsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSampleOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSampleBytes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "File";
            // 
            // txtFile
            // 
            this.txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFile.Location = new System.Drawing.Point(66, 10);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(671, 23);
            this.txtFile.TabIndex = 1;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseFile.Location = new System.Drawing.Point(743, 10);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(54, 23);
            this.btnChooseFile.TabIndex = 2;
            this.btnChooseFile.Text = "...";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Count";
            // 
            // numElementsCount
            // 
            this.numElementsCount.Location = new System.Drawing.Point(66, 39);
            this.numElementsCount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numElementsCount.Name = "numElementsCount";
            this.numElementsCount.Size = new System.Drawing.Size(121, 23);
            this.numElementsCount.TabIndex = 3;
            this.numElementsCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Element";
            // 
            // txtElementName
            // 
            this.txtElementName.Location = new System.Drawing.Point(278, 39);
            this.txtElementName.Name = "txtElementName";
            this.txtElementName.Size = new System.Drawing.Size(213, 23);
            this.txtElementName.TabIndex = 4;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(12, 68);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(94, 29);
            this.btnRead.TabIndex = 5;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(12, 103);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(776, 335);
            this.txtResult.TabIndex = 6;
            this.txtResult.Text = "";
            // 
            // btnReadSample
            // 
            this.btnReadSample.Location = new System.Drawing.Point(188, 68);
            this.btnReadSample.Name = "btnReadSample";
            this.btnReadSample.Size = new System.Drawing.Size(113, 29);
            this.btnReadSample.TabIndex = 7;
            this.btnReadSample.Text = "Read sample";
            this.btnReadSample.UseVisualStyleBackColor = true;
            this.btnReadSample.Click += new System.EventHandler(this.btnReadSample_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Offset";
            // 
            // numSampleOffset
            // 
            this.numSampleOffset.Location = new System.Drawing.Point(370, 72);
            this.numSampleOffset.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numSampleOffset.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.numSampleOffset.Name = "numSampleOffset";
            this.numSampleOffset.Size = new System.Drawing.Size(121, 23);
            this.numSampleOffset.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(497, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bytes";
            // 
            // numSampleBytes
            // 
            this.numSampleBytes.Location = new System.Drawing.Point(549, 72);
            this.numSampleBytes.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numSampleBytes.Name = "numSampleBytes";
            this.numSampleBytes.Size = new System.Drawing.Size(121, 23);
            this.numSampleBytes.TabIndex = 3;
            this.numSampleBytes.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Filter";
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Location = new System.Drawing.Point(549, 39);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(239, 23);
            this.txtFilter.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReadSample);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.txtElementName);
            this.Controls.Add(this.numSampleBytes);
            this.Controls.Add(this.numSampleOffset);
            this.Controls.Add(this.numElementsCount);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.Name = "MainForm";
            this.Text = "LargeXmlReader";
            ((System.ComponentModel.ISupportInitialize)(this.numElementsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSampleOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSampleBytes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numElementsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtElementName;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Button btnReadSample;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numSampleOffset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numSampleBytes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFilter;
    }
}

