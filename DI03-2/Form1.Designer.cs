﻿namespace DI03_2
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
            this.randomProductView1 = new RandomProductView.RandomProductView();
            this.SuspendLayout();
            // 
            // randomProductView1
            // 
            this.randomProductView1.CnnString = "Server=(localdb)\\MSSQLLocalDB;Database=AdventureWorks2016;Trusted_Connection=True" +
    ";";
            this.randomProductView1.Location = new System.Drawing.Point(13, 13);
            this.randomProductView1.Name = "randomProductView1";
            this.randomProductView1.Size = new System.Drawing.Size(403, 439);
            this.randomProductView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 495);
            this.Controls.Add(this.randomProductView1);
            this.Name = "Form1";
            this.Text = "ProductModel";
            this.ResumeLayout(false);

        }

        #endregion

        private RandomProductView.RandomProductView randomProductView1;
    }
}

