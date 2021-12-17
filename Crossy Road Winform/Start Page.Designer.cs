
namespace Crossy_Road_Winform
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
            this.judul = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // judul
            // 
            this.judul.AutoSize = true;
            this.judul.Font = new System.Drawing.Font("News706 BT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judul.Location = new System.Drawing.Point(275, 43);
            this.judul.Name = "judul";
            this.judul.Size = new System.Drawing.Size(493, 72);
            this.judul.TabIndex = 0;
            this.judul.Text = "CROSSY ROAD";
            this.judul.Click += new System.EventHandler(this.judul_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Chartreuse;
            this.StartButton.Font = new System.Drawing.Font("Ravie", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(374, 287);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(280, 145);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "START !";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Crossy_Road_Winform.Properties.Resources.Sea_Otter__Enhydra_lutris___25169790524__crop;
            this.pictureBox1.Location = new System.Drawing.Point(53, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(918, 483);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(1008, 483);
            this.Controls.Add(this.judul);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label judul;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

