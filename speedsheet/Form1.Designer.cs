﻿namespace speedsheet
{
    partial class ParamMapForm
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
            this.cancel = new System.Windows.Forms.Button();
            this.gobtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(177, 314);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(109, 23);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // gobtn
            // 
            this.gobtn.Location = new System.Drawing.Point(57, 314);
            this.gobtn.Name = "gobtn";
            this.gobtn.Size = new System.Drawing.Size(75, 23);
            this.gobtn.TabIndex = 1;
            this.gobtn.Text = "stream";
            this.gobtn.UseVisualStyleBackColor = true;
            this.gobtn.Click += new System.EventHandler(this.gobtn_click);
            // 
            // ParamMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 363);
            this.Controls.Add(this.gobtn);
            this.Controls.Add(this.cancel);
            this.Name = "ParamMapForm";
            this.Text = "Stream Properties";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button gobtn;
    }
}