namespace Image_ProcessingPackage
{
    partial class Image_Enhancement
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
            this.Image_befor_picbox = new System.Windows.Forms.PictureBox();
            this.image_afterpicbpx = new System.Windows.Forms.PictureBox();
            this.BeforeLabel = new System.Windows.Forms.Label();
            this.afterlabel = new System.Windows.Forms.Label();
            this.ContrastLabel = new System.Windows.Forms.Label();
            this.contrast_bar_label = new System.Windows.Forms.Label();
            this.gamma_bar_label = new System.Windows.Forms.Label();
            this.Brightnesslabel = new System.Windows.Forms.Label();
            this.Gammalabel = new System.Windows.Forms.Label();
            this.Grayscalebutton = new System.Windows.Forms.Button();
            this.Red_button_histo = new System.Windows.Forms.Button();
            this.Blue_butto_histo = new System.Windows.Forms.Button();
            this.Green_button_histo = new System.Windows.Forms.Button();
            this.Brightness_label = new System.Windows.Forms.Label();
            this.trackBar_Birghtness = new System.Windows.Forms.TrackBar();
            this.trackBar_Contrast = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.timer_Enhancement = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.Apply_Button = new System.Windows.Forms.Button();
            this.histogrampic_box = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Image_befor_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_afterpicbpx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Birghtness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogrampic_box)).BeginInit();
            this.SuspendLayout();
            // 
            // Image_befor_picbox
            // 
            this.Image_befor_picbox.Location = new System.Drawing.Point(12, 36);
            this.Image_befor_picbox.Name = "Image_befor_picbox";
            this.Image_befor_picbox.Size = new System.Drawing.Size(351, 284);
            this.Image_befor_picbox.TabIndex = 0;
            this.Image_befor_picbox.TabStop = false;
            // 
            // image_afterpicbpx
            // 
            this.image_afterpicbpx.Location = new System.Drawing.Point(12, 362);
            this.image_afterpicbpx.Name = "image_afterpicbpx";
            this.image_afterpicbpx.Size = new System.Drawing.Size(351, 284);
            this.image_afterpicbpx.TabIndex = 1;
            this.image_afterpicbpx.TabStop = false;
            // 
            // BeforeLabel
            // 
            this.BeforeLabel.AutoSize = true;
            this.BeforeLabel.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeforeLabel.Location = new System.Drawing.Point(9, 9);
            this.BeforeLabel.Name = "BeforeLabel";
            this.BeforeLabel.Size = new System.Drawing.Size(82, 23);
            this.BeforeLabel.TabIndex = 2;
            this.BeforeLabel.Text = "Before :";
            // 
            // afterlabel
            // 
            this.afterlabel.AutoSize = true;
            this.afterlabel.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afterlabel.Location = new System.Drawing.Point(12, 335);
            this.afterlabel.Name = "afterlabel";
            this.afterlabel.Size = new System.Drawing.Size(78, 24);
            this.afterlabel.TabIndex = 3;
            this.afterlabel.Text = "After : ";
            // 
            // ContrastLabel
            // 
            this.ContrastLabel.AutoSize = true;
            this.ContrastLabel.Location = new System.Drawing.Point(528, 146);
            this.ContrastLabel.Name = "ContrastLabel";
            this.ContrastLabel.Size = new System.Drawing.Size(93, 15);
            this.ContrastLabel.TabIndex = 12;
            this.ContrastLabel.Text = "Contrast Value";
            // 
            // contrast_bar_label
            // 
            this.contrast_bar_label.AutoSize = true;
            this.contrast_bar_label.Location = new System.Drawing.Point(925, 146);
            this.contrast_bar_label.Name = "contrast_bar_label";
            this.contrast_bar_label.Size = new System.Drawing.Size(14, 15);
            this.contrast_bar_label.TabIndex = 17;
            this.contrast_bar_label.Text = "0";
            // 
            // gamma_bar_label
            // 
            this.gamma_bar_label.AutoSize = true;
            this.gamma_bar_label.Location = new System.Drawing.Point(925, 257);
            this.gamma_bar_label.Name = "gamma_bar_label";
            this.gamma_bar_label.Size = new System.Drawing.Size(14, 15);
            this.gamma_bar_label.TabIndex = 18;
            this.gamma_bar_label.Text = "0";
            // 
            // Brightnesslabel
            // 
            this.Brightnesslabel.AutoSize = true;
            this.Brightnesslabel.Location = new System.Drawing.Point(533, 55);
            this.Brightnesslabel.Name = "Brightnesslabel";
            this.Brightnesslabel.Size = new System.Drawing.Size(69, 15);
            this.Brightnesslabel.TabIndex = 22;
            this.Brightnesslabel.Text = "Brightness";
            // 
            // Gammalabel
            // 
            this.Gammalabel.AutoSize = true;
            this.Gammalabel.Location = new System.Drawing.Point(528, 257);
            this.Gammalabel.Name = "Gammalabel";
            this.Gammalabel.Size = new System.Drawing.Size(88, 15);
            this.Gammalabel.TabIndex = 23;
            this.Gammalabel.Text = "Gamma Value";
            // 
            // Grayscalebutton
            // 
            this.Grayscalebutton.BackColor = System.Drawing.Color.DimGray;
            this.Grayscalebutton.ForeColor = System.Drawing.Color.White;
            this.Grayscalebutton.Location = new System.Drawing.Point(696, 309);
            this.Grayscalebutton.Name = "Grayscalebutton";
            this.Grayscalebutton.Size = new System.Drawing.Size(126, 33);
            this.Grayscalebutton.TabIndex = 24;
            this.Grayscalebutton.Text = "To Gray Scale";
            this.Grayscalebutton.UseVisualStyleBackColor = false;
            this.Grayscalebutton.Click += new System.EventHandler(this.Grayscalebutton_Click);
            // 
            // Red_button_histo
            // 
            this.Red_button_histo.ForeColor = System.Drawing.Color.Red;
            this.Red_button_histo.Location = new System.Drawing.Point(627, 652);
            this.Red_button_histo.Name = "Red_button_histo";
            this.Red_button_histo.Size = new System.Drawing.Size(87, 33);
            this.Red_button_histo.TabIndex = 26;
            this.Red_button_histo.Text = "Red";
            this.Red_button_histo.UseVisualStyleBackColor = true;
            this.Red_button_histo.Click += new System.EventHandler(this.Red_button_histo_Click);
            // 
            // Blue_butto_histo
            // 
            this.Blue_butto_histo.ForeColor = System.Drawing.Color.Blue;
            this.Blue_butto_histo.Location = new System.Drawing.Point(852, 652);
            this.Blue_butto_histo.Name = "Blue_butto_histo";
            this.Blue_butto_histo.Size = new System.Drawing.Size(87, 33);
            this.Blue_butto_histo.TabIndex = 27;
            this.Blue_butto_histo.Text = "Blue";
            this.Blue_butto_histo.UseVisualStyleBackColor = true;
            this.Blue_butto_histo.Click += new System.EventHandler(this.Blue_butto_histo_Click);
            // 
            // Green_button_histo
            // 
            this.Green_button_histo.ForeColor = System.Drawing.Color.Green;
            this.Green_button_histo.Location = new System.Drawing.Point(750, 652);
            this.Green_button_histo.Name = "Green_button_histo";
            this.Green_button_histo.Size = new System.Drawing.Size(87, 33);
            this.Green_button_histo.TabIndex = 28;
            this.Green_button_histo.Text = "Green";
            this.Green_button_histo.UseVisualStyleBackColor = true;
            this.Green_button_histo.Click += new System.EventHandler(this.Green_button_histo_Click);
            // 
            // Brightness_label
            // 
            this.Brightness_label.AutoSize = true;
            this.Brightness_label.Location = new System.Drawing.Point(925, 55);
            this.Brightness_label.Name = "Brightness_label";
            this.Brightness_label.Size = new System.Drawing.Size(14, 15);
            this.Brightness_label.TabIndex = 30;
            this.Brightness_label.Text = "0";
            // 
            // trackBar_Birghtness
            // 
            this.trackBar_Birghtness.Location = new System.Drawing.Point(627, 55);
            this.trackBar_Birghtness.Maximum = 50;
            this.trackBar_Birghtness.Minimum = -50;
            this.trackBar_Birghtness.Name = "trackBar_Birghtness";
            this.trackBar_Birghtness.Size = new System.Drawing.Size(292, 45);
            this.trackBar_Birghtness.TabIndex = 31;
            this.trackBar_Birghtness.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar_Contrast
            // 
            this.trackBar_Contrast.Location = new System.Drawing.Point(627, 146);
            this.trackBar_Contrast.Maximum = 255;
            this.trackBar_Contrast.Name = "trackBar_Contrast";
            this.trackBar_Contrast.Size = new System.Drawing.Size(292, 45);
            this.trackBar_Contrast.TabIndex = 32;
            this.trackBar_Contrast.Scroll += new System.EventHandler(this.trackBar_Contrast_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(627, 249);
            this.trackBar1.Maximum = 3000;
            this.trackBar1.Minimum = 200;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(292, 45);
            this.trackBar1.TabIndex = 33;
            this.trackBar1.Value = 1000;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(513, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 34;
            this.label1.Text = "Histogram";
            // 
            // Reset_Button
            // 
            this.Reset_Button.Location = new System.Drawing.Point(998, 55);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(97, 33);
            this.Reset_Button.TabIndex = 19;
            this.Reset_Button.Text = "Reset";
            this.Reset_Button.UseVisualStyleBackColor = true;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // Apply_Button
            // 
            this.Apply_Button.Location = new System.Drawing.Point(998, 119);
            this.Apply_Button.Name = "Apply_Button";
            this.Apply_Button.Size = new System.Drawing.Size(97, 33);
            this.Apply_Button.TabIndex = 21;
            this.Apply_Button.Text = "Apply";
            this.Apply_Button.UseVisualStyleBackColor = true;
            this.Apply_Button.Click += new System.EventHandler(this.Apply_Button_Click);
            // 
            // histogrampic_box
            // 
            this.histogrampic_box.BackColor = System.Drawing.Color.LightGray;
            this.histogrampic_box.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.histogrampic_box.Location = new System.Drawing.Point(626, 392);
            this.histogrampic_box.Name = "histogrampic_box";
            this.histogrampic_box.Size = new System.Drawing.Size(313, 254);
            this.histogrampic_box.TabIndex = 25;
            this.histogrampic_box.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(474, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 35;
            this.label2.Text = "Operations :";
            // 
            // Image_Enhancement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1113, 708);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.trackBar_Contrast);
            this.Controls.Add(this.trackBar_Birghtness);
            this.Controls.Add(this.Brightness_label);
            this.Controls.Add(this.Green_button_histo);
            this.Controls.Add(this.Blue_butto_histo);
            this.Controls.Add(this.Red_button_histo);
            this.Controls.Add(this.histogrampic_box);
            this.Controls.Add(this.Grayscalebutton);
            this.Controls.Add(this.Gammalabel);
            this.Controls.Add(this.Brightnesslabel);
            this.Controls.Add(this.Apply_Button);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.gamma_bar_label);
            this.Controls.Add(this.contrast_bar_label);
            this.Controls.Add(this.ContrastLabel);
            this.Controls.Add(this.afterlabel);
            this.Controls.Add(this.BeforeLabel);
            this.Controls.Add(this.image_afterpicbpx);
            this.Controls.Add(this.Image_befor_picbox);
            this.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DeepPink;
            this.Name = "Image_Enhancement";
            this.Text = "Image_Enhancement";
            this.Load += new System.EventHandler(this.Image_Enhancement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Image_befor_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_afterpicbpx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Birghtness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogrampic_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox Image_befor_picbox;
        public System.Windows.Forms.PictureBox image_afterpicbpx;
        private System.Windows.Forms.Label BeforeLabel;
        private System.Windows.Forms.Label afterlabel;
        private System.Windows.Forms.Label ContrastLabel;
        private System.Windows.Forms.Label contrast_bar_label;
        private System.Windows.Forms.Label gamma_bar_label;
        private System.Windows.Forms.Label Brightnesslabel;
        private System.Windows.Forms.Label Gammalabel;
        private System.Windows.Forms.Button Grayscalebutton;
        private System.Windows.Forms.Button Red_button_histo;
        private System.Windows.Forms.Button Blue_butto_histo;
        private System.Windows.Forms.Button Green_button_histo;
        private System.Windows.Forms.Label Brightness_label;
        private System.Windows.Forms.TrackBar trackBar_Birghtness;
        private System.Windows.Forms.TrackBar trackBar_Contrast;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Timer timer_Enhancement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.Button Apply_Button;
        private System.Windows.Forms.PictureBox histogrampic_box;
        private System.Windows.Forms.Label label2;
    }
}