namespace Image_ProcessingPackage
{
    partial class Image_Algebra
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
            this.SecondImage = new System.Windows.Forms.Button();
            this.Apply_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.FirstImage = new System.Windows.Forms.Button();
            this.ImageRes_PictureBox = new System.Windows.Forms.PictureBox();
            this.Image2_PictureBox = new System.Windows.Forms.PictureBox();
            this.Image1_PictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AddLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar_add = new System.Windows.Forms.TrackBar();
            this.ComboBoxOpe = new System.Windows.Forms.ComboBox();
            this.labeladd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImageRes_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image2_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image1_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_add)).BeginInit();
            this.SuspendLayout();
            // 
            // SecondImage
            // 
            this.SecondImage.BackColor = System.Drawing.Color.White;
            this.SecondImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SecondImage.Font = new System.Drawing.Font("Corbel", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondImage.Location = new System.Drawing.Point(667, 8);
            this.SecondImage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SecondImage.Name = "SecondImage";
            this.SecondImage.Size = new System.Drawing.Size(168, 28);
            this.SecondImage.TabIndex = 23;
            this.SecondImage.Text = "Load  Image2";
            this.SecondImage.UseVisualStyleBackColor = false;
            this.SecondImage.Click += new System.EventHandler(this.SecondImage_Click);
            // 
            // Apply_Button
            // 
            this.Apply_Button.BackColor = System.Drawing.Color.White;
            this.Apply_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Apply_Button.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apply_Button.Location = new System.Drawing.Point(692, 606);
            this.Apply_Button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Apply_Button.Name = "Apply_Button";
            this.Apply_Button.Size = new System.Drawing.Size(124, 34);
            this.Apply_Button.TabIndex = 22;
            this.Apply_Button.Text = "Apply";
            this.Apply_Button.UseVisualStyleBackColor = false;
            this.Apply_Button.Click += new System.EventHandler(this.Apply_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.BackColor = System.Drawing.Color.White;
            this.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_Button.Font = new System.Drawing.Font("Corbel", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Button.Location = new System.Drawing.Point(820, 605);
            this.Cancel_Button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(110, 37);
            this.Cancel_Button.TabIndex = 20;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = false;
            this.Cancel_Button.Click += new System.EventHandler(this.F3_CancelButton_Click_1);
            // 
            // FirstImage
            // 
            this.FirstImage.BackColor = System.Drawing.Color.White;
            this.FirstImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FirstImage.Font = new System.Drawing.Font("Corbel", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstImage.Location = new System.Drawing.Point(148, 5);
            this.FirstImage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FirstImage.Name = "FirstImage";
            this.FirstImage.Size = new System.Drawing.Size(158, 31);
            this.FirstImage.TabIndex = 19;
            this.FirstImage.Text = "Load  Image1 ";
            this.FirstImage.UseVisualStyleBackColor = false;
            this.FirstImage.Click += new System.EventHandler(this.FirstImage_Click);
            // 
            // ImageRes_PictureBox
            // 
            this.ImageRes_PictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ImageRes_PictureBox.Location = new System.Drawing.Point(297, 360);
            this.ImageRes_PictureBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ImageRes_PictureBox.Name = "ImageRes_PictureBox";
            this.ImageRes_PictureBox.Size = new System.Drawing.Size(377, 282);
            this.ImageRes_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageRes_PictureBox.TabIndex = 18;
            this.ImageRes_PictureBox.TabStop = false;
            // 
            // Image2_PictureBox
            // 
            this.Image2_PictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Image2_PictureBox.Location = new System.Drawing.Point(607, 42);
            this.Image2_PictureBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Image2_PictureBox.Name = "Image2_PictureBox";
            this.Image2_PictureBox.Size = new System.Drawing.Size(320, 312);
            this.Image2_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Image2_PictureBox.TabIndex = 17;
            this.Image2_PictureBox.TabStop = false;
            // 
            // Image1_PictureBox
            // 
            this.Image1_PictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Image1_PictureBox.Location = new System.Drawing.Point(14, 42);
            this.Image1_PictureBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Image1_PictureBox.Name = "Image1_PictureBox";
            this.Image1_PictureBox.Size = new System.Drawing.Size(320, 312);
            this.Image1_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Image1_PictureBox.TabIndex = 16;
            this.Image1_PictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(419, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Operations";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, -27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Result";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // AddLabel
            // 
            this.AddLabel.AutoSize = true;
            this.AddLabel.Location = new System.Drawing.Point(557, 233);
            this.AddLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(16, 16);
            this.AddLabel.TabIndex = 28;
            this.AddLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Image(1) :)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(549, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Image(2) :)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(408, 331);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Result Image";
            // 
            // trackBar_add
            // 
            this.trackBar_add.Location = new System.Drawing.Point(400, 233);
            this.trackBar_add.Maximum = 100;
            this.trackBar_add.Name = "trackBar_add";
            this.trackBar_add.Size = new System.Drawing.Size(152, 45);
            this.trackBar_add.TabIndex = 32;
            this.trackBar_add.Scroll += new System.EventHandler(this.trackBar_add_Scroll);
            // 
            // ComboBoxOpe
            // 
            this.ComboBoxOpe.BackColor = System.Drawing.SystemColors.Menu;
            this.ComboBoxOpe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxOpe.FormattingEnabled = true;
            this.ComboBoxOpe.Location = new System.Drawing.Point(412, 131);
            this.ComboBoxOpe.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ComboBoxOpe.Name = "ComboBoxOpe";
            this.ComboBoxOpe.Size = new System.Drawing.Size(122, 24);
            this.ComboBoxOpe.TabIndex = 21;
            // 
            // labeladd
            // 
            this.labeladd.AutoSize = true;
            this.labeladd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labeladd.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeladd.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.labeladd.Location = new System.Drawing.Point(357, 199);
            this.labeladd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeladd.Name = "labeladd";
            this.labeladd.Size = new System.Drawing.Size(182, 21);
            this.labeladd.TabIndex = 33;
            this.labeladd.Text = "choose Value adding";
            // 
            // Image_Algebra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(941, 658);
            this.Controls.Add(this.labeladd);
            this.Controls.Add(this.trackBar_add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SecondImage);
            this.Controls.Add(this.Apply_Button);
            this.Controls.Add(this.ComboBoxOpe);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.FirstImage);
            this.Controls.Add(this.ImageRes_PictureBox);
            this.Controls.Add(this.Image2_PictureBox);
            this.Controls.Add(this.Image1_PictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddLabel);
            this.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Image_Algebra";
            this.Text = "Image_Algebra";
            ((System.ComponentModel.ISupportInitialize)(this.ImageRes_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image2_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image1_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_add)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SecondImage;
        private System.Windows.Forms.Button Apply_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button FirstImage;
        public System.Windows.Forms.PictureBox ImageRes_PictureBox;
        private System.Windows.Forms.PictureBox Image2_PictureBox;
        private System.Windows.Forms.PictureBox Image1_PictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label AddLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar_add;
        private System.Windows.Forms.ComboBox ComboBoxOpe;
        private System.Windows.Forms.Label labeladd;
    }
}