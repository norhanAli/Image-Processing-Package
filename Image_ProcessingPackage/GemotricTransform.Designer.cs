namespace Image_ProcessingPackage
{
  
    partial class GemotricTransform
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.TextForXVal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextForYval = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textforshearx = new System.Windows.Forms.TextBox();
            this.textforsheary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Reset_button = new System.Windows.Forms.Button();
            this.AccumlativeImg_button = new System.Windows.Forms.Button();
            this.buttonSacale = new System.Windows.Forms.Button();
            this.button_Rotate = new System.Windows.Forms.Button();
            this.button_Shear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Location = new System.Drawing.Point(13, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 326);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.Location = new System.Drawing.Point(548, 34);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(355, 326);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBox1.Items.AddRange(new object[] {
            "scale",
            "rotate",
            "shear"});
            this.comboBox1.Location = new System.Drawing.Point(404, 125);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 26);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "------------------";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(641, 458);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 31);
            this.button3.TabIndex = 5;
            this.button3.Text = "Apply";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TextForXVal
            // 
            this.TextForXVal.Location = new System.Drawing.Point(39, 438);
            this.TextForXVal.Margin = new System.Windows.Forms.Padding(4);
            this.TextForXVal.Name = "TextForXVal";
            this.TextForXVal.Size = new System.Drawing.Size(77, 26);
            this.TextForXVal.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 438);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "X";
            // 
            // TextForYval
            // 
            this.TextForYval.Location = new System.Drawing.Point(39, 480);
            this.TextForYval.Margin = new System.Windows.Forms.Padding(4);
            this.TextForYval.Name = "TextForYval";
            this.TextForYval.Size = new System.Drawing.Size(77, 26);
            this.TextForYval.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 488);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 464);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "rotate";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(227, 461);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(70, 26);
            this.textBox3.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 464);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "shear y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 464);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "shear x";
            // 
            // textforshearx
            // 
            this.textforshearx.Location = new System.Drawing.Point(431, 464);
            this.textforshearx.Margin = new System.Windows.Forms.Padding(4);
            this.textforshearx.Name = "textforshearx";
            this.textforshearx.Size = new System.Drawing.Size(50, 26);
            this.textforshearx.TabIndex = 14;
            // 
            // textforsheary
            // 
            this.textforsheary.Location = new System.Drawing.Point(572, 464);
            this.textforsheary.Margin = new System.Windows.Forms.Padding(4);
            this.textforsheary.Name = "textforsheary";
            this.textforsheary.Size = new System.Drawing.Size(50, 26);
            this.textforsheary.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Original Image : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(534, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "After Transform Operation: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 87);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Choose Operation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(13, 396);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "For Scaling :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(185, 396);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "For Rotating :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(363, 396);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "For Shearing :";
            // 
            // Reset_button
            // 
            this.Reset_button.BackColor = System.Drawing.Color.White;
            this.Reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset_button.Location = new System.Drawing.Point(830, 472);
            this.Reset_button.Margin = new System.Windows.Forms.Padding(4);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(81, 34);
            this.Reset_button.TabIndex = 22;
            this.Reset_button.Text = "Reset";
            this.Reset_button.UseVisualStyleBackColor = false;
            this.Reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // AccumlativeImg_button
            // 
            this.AccumlativeImg_button.BackColor = System.Drawing.Color.White;
            this.AccumlativeImg_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccumlativeImg_button.Location = new System.Drawing.Point(830, 538);
            this.AccumlativeImg_button.Margin = new System.Windows.Forms.Padding(4);
            this.AccumlativeImg_button.Name = "AccumlativeImg_button";
            this.AccumlativeImg_button.Size = new System.Drawing.Size(81, 31);
            this.AccumlativeImg_button.TabIndex = 23;
            this.AccumlativeImg_button.Text = "Ok";
            this.AccumlativeImg_button.UseVisualStyleBackColor = false;
            this.AccumlativeImg_button.Click += new System.EventHandler(this.AccumlativeImg_button_Click);
            // 
            // buttonSacale
            // 
            this.buttonSacale.BackColor = System.Drawing.Color.White;
            this.buttonSacale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSacale.Location = new System.Drawing.Point(16, 538);
            this.buttonSacale.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSacale.Name = "buttonSacale";
            this.buttonSacale.Size = new System.Drawing.Size(81, 31);
            this.buttonSacale.TabIndex = 24;
            this.buttonSacale.Text = "Scale";
            this.buttonSacale.UseVisualStyleBackColor = false;
            this.buttonSacale.Click += new System.EventHandler(this.buttonSacale_Click);
            // 
            // button_Rotate
            // 
            this.button_Rotate.BackColor = System.Drawing.Color.White;
            this.button_Rotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Rotate.Location = new System.Drawing.Point(197, 538);
            this.button_Rotate.Margin = new System.Windows.Forms.Padding(4);
            this.button_Rotate.Name = "button_Rotate";
            this.button_Rotate.Size = new System.Drawing.Size(81, 31);
            this.button_Rotate.TabIndex = 25;
            this.button_Rotate.Text = "Rotate";
            this.button_Rotate.UseVisualStyleBackColor = false;
            this.button_Rotate.Click += new System.EventHandler(this.button_Rotate_Click);
            // 
            // button_Shear
            // 
            this.button_Shear.BackColor = System.Drawing.Color.White;
            this.button_Shear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Shear.Location = new System.Drawing.Point(473, 533);
            this.button_Shear.Margin = new System.Windows.Forms.Padding(4);
            this.button_Shear.Name = "button_Shear";
            this.button_Shear.Size = new System.Drawing.Size(102, 30);
            this.button_Shear.TabIndex = 26;
            this.button_Shear.Text = "shear";
            this.button_Shear.UseVisualStyleBackColor = false;
            this.button_Shear.Click += new System.EventHandler(this.button_Shear_Click);
            // 
            // GemotricTransform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 596);
            this.Controls.Add(this.button_Shear);
            this.Controls.Add(this.button_Rotate);
            this.Controls.Add(this.buttonSacale);
            this.Controls.Add(this.AccumlativeImg_button);
            this.Controls.Add(this.Reset_button);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textforsheary);
            this.Controls.Add(this.textforshearx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextForYval);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextForXVal);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GemotricTransform";
            this.Text = "Geometric Transform";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TextForXVal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextForYval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textforshearx;
        private System.Windows.Forms.TextBox textforsheary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.Button AccumlativeImg_button;
        private System.Windows.Forms.Button buttonSacale;
        private System.Windows.Forms.Button button_Rotate;
        private System.Windows.Forms.Button button_Shear;
    }
}

