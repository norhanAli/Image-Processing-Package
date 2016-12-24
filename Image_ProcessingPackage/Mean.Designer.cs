namespace Image_ProcessingPackage
{
    partial class Mean
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
            this.picturebox_Beforefilter = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_OrgX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_OrgY = new System.Windows.Forms.TextBox();
            this.Blur_Button = new System.Windows.Forms.Button();
            this.pictureBox_Afterpic = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Reset_button = new System.Windows.Forms.Button();
            this.Applay_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_Beforefilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Afterpic)).BeginInit();
            this.SuspendLayout();
            // 
            // picturebox_Beforefilter
            // 
            this.picturebox_Beforefilter.Location = new System.Drawing.Point(3, 36);
            this.picturebox_Beforefilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picturebox_Beforefilter.Name = "picturebox_Beforefilter";
            this.picturebox_Beforefilter.Size = new System.Drawing.Size(308, 315);
            this.picturebox_Beforefilter.TabIndex = 13;
            this.picturebox_Beforefilter.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mean Filter Options:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mask Size:";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(349, 94);
            this.textBoxWidth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(91, 22);
            this.textBoxWidth.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(464, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "x";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(507, 91);
            this.textBoxHeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(92, 22);
            this.textBoxHeight.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Origin X-position";
            // 
            // textBox_OrgX
            // 
            this.textBox_OrgX.Location = new System.Drawing.Point(468, 146);
            this.textBox_OrgX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_OrgX.Name = "textBox_OrgX";
            this.textBox_OrgX.Size = new System.Drawing.Size(132, 22);
            this.textBox_OrgX.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Origin Y-position";
            // 
            // textBox_OrgY
            // 
            this.textBox_OrgY.Location = new System.Drawing.Point(467, 187);
            this.textBox_OrgY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_OrgY.Name = "textBox_OrgY";
            this.textBox_OrgY.Size = new System.Drawing.Size(132, 22);
            this.textBox_OrgY.TabIndex = 22;
            // 
            // Blur_Button
            // 
            this.Blur_Button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Blur_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Blur_Button.Location = new System.Drawing.Point(427, 271);
            this.Blur_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Blur_Button.Name = "Blur_Button";
            this.Blur_Button.Size = new System.Drawing.Size(103, 26);
            this.Blur_Button.TabIndex = 23;
            this.Blur_Button.Text = "BLUR";
            this.Blur_Button.UseVisualStyleBackColor = false;
            this.Blur_Button.Click += new System.EventHandler(this.Blur_Button_Click);
            // 
            // pictureBox_Afterpic
            // 
            this.pictureBox_Afterpic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox_Afterpic.Location = new System.Drawing.Point(608, 36);
            this.pictureBox_Afterpic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox_Afterpic.Name = "pictureBox_Afterpic";
            this.pictureBox_Afterpic.Size = new System.Drawing.Size(324, 315);
            this.pictureBox_Afterpic.TabIndex = 24;
            this.pictureBox_Afterpic.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 22);
            this.label6.TabIndex = 26;
            this.label6.Text = "Before Mean Filter";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(591, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 22);
            this.label7.TabIndex = 25;
            this.label7.Text = "After Mean filter";
            // 
            // Reset_button
            // 
            this.Reset_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Reset_button.Location = new System.Drawing.Point(940, 288);
            this.Reset_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(83, 34);
            this.Reset_button.TabIndex = 27;
            this.Reset_button.Text = "Reset";
            this.Reset_button.UseVisualStyleBackColor = false;
            this.Reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // Applay_button
            // 
            this.Applay_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Applay_button.Location = new System.Drawing.Point(940, 328);
            this.Applay_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Applay_button.Name = "Applay_button";
            this.Applay_button.Size = new System.Drawing.Size(83, 34);
            this.Applay_button.TabIndex = 28;
            this.Applay_button.Text = "Apply";
            this.Applay_button.UseVisualStyleBackColor = false;
            this.Applay_button.Click += new System.EventHandler(this.Applay_button_Click);
            // 
            // Mean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1036, 364);
            this.Controls.Add(this.Applay_button);
            this.Controls.Add(this.Reset_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox_Afterpic);
            this.Controls.Add(this.Blur_Button);
            this.Controls.Add(this.textBox_OrgY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_OrgX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picturebox_Beforefilter);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Mean";
            this.Text = "Mean Filter";
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_Beforefilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Afterpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picturebox_Beforefilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_OrgX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_OrgY;
        private System.Windows.Forms.Button Blur_Button;
        private System.Windows.Forms.PictureBox pictureBox_Afterpic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.Button Applay_button;

    }
}