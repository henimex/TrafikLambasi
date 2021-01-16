namespace TrafikLambasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2y = new System.Windows.Forms.PictureBox();
            this.pictureBox3s = new System.Windows.Forms.PictureBox();
            this.pictureBox4k = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2kg = new System.Windows.Forms.Label();
            this.label3yg = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3s)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4k)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 352);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2y
            // 
            this.pictureBox2y.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2y.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2y.Image")));
            this.pictureBox2y.Location = new System.Drawing.Point(56, 217);
            this.pictureBox2y.Name = "pictureBox2y";
            this.pictureBox2y.Size = new System.Drawing.Size(96, 93);
            this.pictureBox2y.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2y.TabIndex = 2;
            this.pictureBox2y.TabStop = false;
            // 
            // pictureBox3s
            // 
            this.pictureBox3s.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3s.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3s.Image")));
            this.pictureBox3s.Location = new System.Drawing.Point(56, 118);
            this.pictureBox3s.Name = "pictureBox3s";
            this.pictureBox3s.Size = new System.Drawing.Size(96, 93);
            this.pictureBox3s.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3s.TabIndex = 2;
            this.pictureBox3s.TabStop = false;
            // 
            // pictureBox4k
            // 
            this.pictureBox4k.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4k.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4k.Image")));
            this.pictureBox4k.Location = new System.Drawing.Point(56, 19);
            this.pictureBox4k.Name = "pictureBox4k";
            this.pictureBox4k.Size = new System.Drawing.Size(96, 93);
            this.pictureBox4k.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4k.TabIndex = 2;
            this.pictureBox4k.TabStop = false;
            this.pictureBox4k.Click += new System.EventHandler(this.pictureBox4k_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(212, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2kg
            // 
            this.label2kg.AutoSize = true;
            this.label2kg.BackColor = System.Drawing.Color.Transparent;
            this.label2kg.Font = new System.Drawing.Font("UniDreamLED", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2kg.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2kg.Location = new System.Drawing.Point(71, 39);
            this.label2kg.Name = "label2kg";
            this.label2kg.Size = new System.Drawing.Size(67, 53);
            this.label2kg.TabIndex = 4;
            this.label2kg.Text = "40";
            this.label2kg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3yg
            // 
            this.label3yg.AutoSize = true;
            this.label3yg.Font = new System.Drawing.Font("UniDreamLED", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3yg.ForeColor = System.Drawing.Color.PaleGreen;
            this.label3yg.Location = new System.Drawing.Point(71, 236);
            this.label3yg.Name = "label3yg";
            this.label3yg.Size = new System.Drawing.Size(67, 53);
            this.label3yg.TabIndex = 5;
            this.label3yg.Text = "30";
            this.label3yg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 356);
            this.Controls.Add(this.label2kg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4k);
            this.Controls.Add(this.pictureBox3s);
            this.Controls.Add(this.pictureBox2y);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3yg);
            this.Name = "Form1";
            this.Text = "Trola";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3s)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4k)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2y;
        private System.Windows.Forms.PictureBox pictureBox3s;
        private System.Windows.Forms.PictureBox pictureBox4k;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2kg;
        private System.Windows.Forms.Label label3yg;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

