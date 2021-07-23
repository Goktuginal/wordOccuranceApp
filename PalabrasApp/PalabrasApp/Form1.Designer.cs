
namespace PalabrasApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.readBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnParse = new System.Windows.Forms.Button();
            this.parsedBox = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.dispOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please choose your file";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(357, 120);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(150, 46);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // readBox
            // 
            this.readBox.Location = new System.Drawing.Point(45, 202);
            this.readBox.Multiline = true;
            this.readBox.Name = "readBox";
            this.readBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.readBox.Size = new System.Drawing.Size(462, 544);
            this.readBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(963, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parse the chosen file";
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(1257, 127);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(150, 46);
            this.btnParse.TabIndex = 4;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // parsedBox
            // 
            this.parsedBox.HideSelection = false;
            this.parsedBox.Location = new System.Drawing.Point(963, 202);
            this.parsedBox.Name = "parsedBox";
            this.parsedBox.Size = new System.Drawing.Size(444, 544);
            this.parsedBox.TabIndex = 5;
            this.parsedBox.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(647, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "------->>>>>";
            // 
            // dispOutput
            // 
            this.dispOutput.AutoSize = true;
            this.dispOutput.ForeColor = System.Drawing.SystemColors.Highlight;
            this.dispOutput.Location = new System.Drawing.Point(537, 574);
            this.dispOutput.MinimumSize = new System.Drawing.Size(410, 0);
            this.dispOutput.Name = "dispOutput";
            this.dispOutput.Size = new System.Drawing.Size(410, 32);
            this.dispOutput.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 758);
            this.Controls.Add(this.dispOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.parsedBox);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.readBox);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox readBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.ListView parsedBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dispOutput;
    }
}

