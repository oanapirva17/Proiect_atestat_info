﻿
namespace Proiect_atestat_info
{
    partial class Poze
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.poza = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.poza)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Imaginea anterioara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(666, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Imaginea urmatoare";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // poza
            // 
            this.poza.Location = new System.Drawing.Point(12, 12);
            this.poza.Name = "poza";
            this.poza.Size = new System.Drawing.Size(776, 397);
            this.poza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.poza.TabIndex = 2;
            this.poza.TabStop = false;
            // 
            // Poze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 460);
            this.Controls.Add(this.poza);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Poze";
            this.Text = "Poze";
            ((System.ComponentModel.ISupportInitialize)(this.poza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}