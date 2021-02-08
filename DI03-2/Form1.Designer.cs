namespace DI03_2
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.modelID = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.productID = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.priceTitleLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(12, 217);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(57, 20);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            // 
            // modelID
            // 
            this.modelID.AutoSize = true;
            this.modelID.Location = new System.Drawing.Point(13, 237);
            this.modelID.Name = "modelID";
            this.modelID.Size = new System.Drawing.Size(21, 17);
            this.modelID.TabIndex = 2;
            this.modelID.Text = "ID";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 275);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(358, 100);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // productID
            // 
            this.productID.AutoSize = true;
            this.productID.Location = new System.Drawing.Point(283, 220);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(70, 17);
            this.productID.TabIndex = 4;
            this.productID.Text = "ProductID";
            // 
            // priceTitleLabel
            // 
            this.priceTitleLabel.AutoSize = true;
            this.priceTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTitleLabel.Location = new System.Drawing.Point(16, 382);
            this.priceTitleLabel.Name = "priceTitleLabel";
            this.priceTitleLabel.Size = new System.Drawing.Size(50, 17);
            this.priceTitleLabel.TabIndex = 5;
            this.priceTitleLabel.Text = "Price:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(73, 382);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(39, 17);
            this.priceLabel.TabIndex = 6;
            this.priceLabel.Text = "price";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 495);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.priceTitleLabel);
            this.Controls.Add(this.productID);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.modelID);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "ProductModel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label modelID;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label productID;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label priceTitleLabel;
        private System.Windows.Forms.Label priceLabel;
    }
}

