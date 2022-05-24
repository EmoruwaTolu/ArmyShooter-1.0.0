namespace Army_shooter
{
    partial class Army_Shooter_Rennes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Army_Shooter_Rennes));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.start_Stage = new System.Windows.Forms.Button();
            this.next_Stage = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timerGameLoop = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.hitsLabel = new System.Windows.Forms.Label();
            this.hits1Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.missesLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalShotsLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hitPercentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 476);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 90);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 562);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(493, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // start_Stage
            // 
            this.start_Stage.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.start_Stage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_Stage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.start_Stage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_Stage.Location = new System.Drawing.Point(16, 575);
            this.start_Stage.Name = "start_Stage";
            this.start_Stage.Size = new System.Drawing.Size(73, 21);
            this.start_Stage.TabIndex = 2;
            this.start_Stage.Text = "Start Stage";
            this.start_Stage.UseVisualStyleBackColor = false;
            this.start_Stage.Click += new System.EventHandler(this.start_Stage_Click);
            // 
            // next_Stage
            // 
            this.next_Stage.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.next_Stage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next_Stage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.next_Stage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_Stage.Location = new System.Drawing.Point(16, 602);
            this.next_Stage.Name = "next_Stage";
            this.next_Stage.Size = new System.Drawing.Size(73, 21);
            this.next_Stage.TabIndex = 3;
            this.next_Stage.Text = "Next Stage";
            this.next_Stage.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(385, 585);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 34);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "On the shore of Rennes";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerGameLoop
            // 
            this.timerGameLoop.Tick += new System.EventHandler(this.timerGameLoop_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "- Clear the frontlines for the ships to land!\r\n- Maintain a shot accuracy of 80 %" +
                "\r\n";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Goldenrod;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(292, 476);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(185, 86);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // hitsLabel
            // 
            this.hitsLabel.AutoSize = true;
            this.hitsLabel.Location = new System.Drawing.Point(296, 483);
            this.hitsLabel.Name = "hitsLabel";
            this.hitsLabel.Size = new System.Drawing.Size(0, 13);
            this.hitsLabel.TabIndex = 7;
            // 
            // hits1Label
            // 
            this.hits1Label.Location = new System.Drawing.Point(334, 481);
            this.hits1Label.Name = "hits1Label";
            this.hits1Label.Size = new System.Drawing.Size(135, 15);
            this.hits1Label.TabIndex = 8;
            this.hits1Label.Click += new System.EventHandler(this.hits1Label_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(300, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hits:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(300, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Misses:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // missesLabel
            // 
            this.missesLabel.Location = new System.Drawing.Point(348, 503);
            this.missesLabel.Name = "missesLabel";
            this.missesLabel.Size = new System.Drawing.Size(121, 15);
            this.missesLabel.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(300, 525);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total Shots:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalShotsLabel
            // 
            this.totalShotsLabel.Location = new System.Drawing.Point(369, 525);
            this.totalShotsLabel.Name = "totalShotsLabel";
            this.totalShotsLabel.Size = new System.Drawing.Size(100, 15);
            this.totalShotsLabel.TabIndex = 13;
            this.totalShotsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(300, 546);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Hit Percentage:";
            // 
            // hitPercentLabel
            // 
            this.hitPercentLabel.Location = new System.Drawing.Point(387, 546);
            this.hitPercentLabel.Name = "hitPercentLabel";
            this.hitPercentLabel.Size = new System.Drawing.Size(82, 13);
            this.hitPercentLabel.TabIndex = 15;
            // 
            // Army_Shooter_Rennes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(477, 631);
            this.Controls.Add(this.hitPercentLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalShotsLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.missesLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hits1Label);
            this.Controls.Add(this.hitsLabel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.next_Stage);
            this.Controls.Add(this.start_Stage);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Army_Shooter_Rennes";
            this.Text = "Army Shooter";
            this.Load += new System.EventHandler(this.Army_Shooter_Rennes_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Army_Shooter_Rennes_MouseClick_1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Army_Shooter_Rennes_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button start_Stage;
        private System.Windows.Forms.Button next_Stage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timerGameLoop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label hitsLabel;
        private System.Windows.Forms.Label hits1Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label missesLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalShotsLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label hitPercentLabel;
    }
}