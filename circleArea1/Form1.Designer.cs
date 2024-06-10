namespace circleArea1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tRadius = new System.Windows.Forms.TextBox();
            this.laCircum = new System.Windows.Forms.Label();
            this.laArea = new System.Windows.Forms.Label();
            this.bCircum = new System.Windows.Forms.Button();
            this.barea = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::circleArea1.Properties.Resources.วงกลม;
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "รัศมี";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(444, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "เส้นรอบวง";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(444, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "พื้นที่";
            // 
            // tRadius
            // 
            this.tRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tRadius.Location = new System.Drawing.Point(633, 46);
            this.tRadius.Name = "tRadius";
            this.tRadius.Size = new System.Drawing.Size(136, 38);
            this.tRadius.TabIndex = 4;
            // 
            // laCircum
            // 
            this.laCircum.AutoSize = true;
            this.laCircum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laCircum.Location = new System.Drawing.Point(617, 127);
            this.laCircum.Name = "laCircum";
            this.laCircum.Size = new System.Drawing.Size(174, 31);
            this.laCircum.TabIndex = 7;
            this.laCircum.Text = "....................";
            // 
            // laArea
            // 
            this.laArea.AutoSize = true;
            this.laArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laArea.Location = new System.Drawing.Point(617, 199);
            this.laArea.Name = "laArea";
            this.laArea.Size = new System.Drawing.Size(174, 31);
            this.laArea.TabIndex = 8;
            this.laArea.Text = "....................";
            this.laArea.Click += new System.EventHandler(this.label5_Click);
            // 
            // bCircum
            // 
            this.bCircum.Location = new System.Drawing.Point(838, 135);
            this.bCircum.Name = "bCircum";
            this.bCircum.Size = new System.Drawing.Size(75, 23);
            this.bCircum.TabIndex = 9;
            this.bCircum.Text = "คำนวณ";
            this.bCircum.UseVisualStyleBackColor = true;
            this.bCircum.Click += new System.EventHandler(this.bCircum_Click);
            // 
            // barea
            // 
            this.barea.Location = new System.Drawing.Point(838, 209);
            this.barea.Name = "barea";
            this.barea.Size = new System.Drawing.Size(75, 23);
            this.barea.TabIndex = 10;
            this.barea.Text = "คำนวณ";
            this.barea.UseVisualStyleBackColor = true;
            this.barea.Click += new System.EventHandler(this.barea_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 450);
            this.Controls.Add(this.barea);
            this.Controls.Add(this.bCircum);
            this.Controls.Add(this.laArea);
            this.Controls.Add(this.laCircum);
            this.Controls.Add(this.tRadius);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "cirleArea";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tRadius;
        private System.Windows.Forms.Label laCircum;
        private System.Windows.Forms.Label laArea;
        private System.Windows.Forms.Button bCircum;
        private System.Windows.Forms.Button barea;
    }
}

