
namespace Krabber_3._3
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
            this.button1 = new System.Windows.Forms.Button();
            this.linktxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.starttxt = new System.Windows.Forms.TextBox();
            this.stoptxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.filelocal = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 171);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(362, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Download";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linktxt
            // 
            this.linktxt.Location = new System.Drawing.Point(96, 20);
            this.linktxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.linktxt.Name = "linktxt";
            this.linktxt.Size = new System.Drawing.Size(303, 23);
            this.linktxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "LINK:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // starttxt
            // 
            this.starttxt.Location = new System.Drawing.Point(96, 123);
            this.starttxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.starttxt.Name = "starttxt";
            this.starttxt.Size = new System.Drawing.Size(73, 23);
            this.starttxt.TabIndex = 1;
            // 
            // stoptxt
            // 
            this.stoptxt.Location = new System.Drawing.Point(326, 123);
            this.stoptxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stoptxt.Name = "stoptxt";
            this.stoptxt.Size = new System.Drawing.Size(73, 23);
            this.stoptxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "STOP:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "START:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Save to:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // filelocal
            // 
            this.filelocal.Location = new System.Drawing.Point(96, 64);
            this.filelocal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filelocal.Name = "filelocal";
            this.filelocal.Size = new System.Drawing.Size(216, 23);
            this.filelocal.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 64);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 22);
            this.button2.TabIndex = 6;
            this.button2.Text = "Browse:";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(434, 227);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stoptxt);
            this.Controls.Add(this.starttxt);
            this.Controls.Add(this.filelocal);
            this.Controls.Add(this.linktxt);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Krabber v 3.3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox linktxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox starttxt;
        private System.Windows.Forms.TextBox stoptxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox filelocal;
        private System.Windows.Forms.Button button2;
    }
}

