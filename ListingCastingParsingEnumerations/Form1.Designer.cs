﻿namespace ListingCastingParsingEnumerations
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnFromString = new System.Windows.Forms.Button();
            this.btnFromInt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(248, 147);
            this.listBox1.TabIndex = 0;
            // 
            // btnFromString
            // 
            this.btnFromString.Location = new System.Drawing.Point(12, 194);
            this.btnFromString.Name = "btnFromString";
            this.btnFromString.Size = new System.Drawing.Size(75, 23);
            this.btnFromString.TabIndex = 1;
            this.btnFromString.Text = "String";
            this.btnFromString.UseVisualStyleBackColor = true;
            this.btnFromString.Click += new System.EventHandler(this.btnFromString_Click);
            // 
            // btnFromInt
            // 
            this.btnFromInt.Location = new System.Drawing.Point(118, 194);
            this.btnFromInt.Name = "btnFromInt";
            this.btnFromInt.Size = new System.Drawing.Size(75, 23);
            this.btnFromInt.TabIndex = 2;
            this.btnFromInt.Text = "Int";
            this.btnFromInt.UseVisualStyleBackColor = true;
            this.btnFromInt.Click += new System.EventHandler(this.btnFromInt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 314);
            this.Controls.Add(this.btnFromInt);
            this.Controls.Add(this.btnFromString);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnFromString;
        private System.Windows.Forms.Button btnFromInt;
    }
}

