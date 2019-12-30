namespace TinyCompiler
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rtxInput = new System.Windows.Forms.RichTextBox();
            this.rtxOutput = new System.Windows.Forms.RichTextBox();
            this.btnCompile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCompile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 38);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rtxInput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtxOutput);
            this.splitContainer1.Size = new System.Drawing.Size(800, 412);
            this.splitContainer1.SplitterDistance = 379;
            this.splitContainer1.TabIndex = 1;
            // 
            // rtxInput
            // 
            this.rtxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxInput.Location = new System.Drawing.Point(0, 0);
            this.rtxInput.Name = "rtxInput";
            this.rtxInput.Size = new System.Drawing.Size(379, 412);
            this.rtxInput.TabIndex = 0;
            this.rtxInput.Text = "";
            // 
            // rtxOutput
            // 
            this.rtxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxOutput.Location = new System.Drawing.Point(0, 0);
            this.rtxOutput.Name = "rtxOutput";
            this.rtxOutput.ReadOnly = true;
            this.rtxOutput.Size = new System.Drawing.Size(417, 412);
            this.rtxOutput.TabIndex = 0;
            this.rtxOutput.Text = "";
            // 
            // btnCompile
            // 
            this.btnCompile.Location = new System.Drawing.Point(713, 6);
            this.btnCompile.Name = "btnCompile";
            this.btnCompile.Size = new System.Drawing.Size(75, 23);
            this.btnCompile.TabIndex = 0;
            this.btnCompile.Text = "&Compile";
            this.btnCompile.UseVisualStyleBackColor = true;
            this.btnCompile.Click += new System.EventHandler(this.btnCompile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Tiny Compiler";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox rtxInput;
        private System.Windows.Forms.RichTextBox rtxOutput;
        private System.Windows.Forms.Button btnCompile;
    }
}

