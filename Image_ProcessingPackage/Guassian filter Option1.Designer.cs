namespace Image_ProcessingPackage
{
    partial class Guassian_filter
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
            this.OringnalImg_pictureBox = new System.Windows.Forms.PictureBox();
            this.Filteredimg_pictureBox = new System.Windows.Forms.PictureBox();
            this.lbl_by = new System.Windows.Forms.Label();
            this.txt_mask_height = new System.Windows.Forms.TextBox();
            this.lbl_mask_size = new System.Windows.Forms.Label();
            this.txt_mask_width = new System.Windows.Forms.TextBox();
            this.txt_sigma = new System.Windows.Forms.TextBox();
            this.btn_opt1_apply_filter = new System.Windows.Forms.Button();
            this.lbl_sigma = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UnDo_button = new System.Windows.Forms.Button();
            this.label_def = new System.Windows.Forms.Label();
            this.label2_def = new System.Windows.Forms.Label();
            this.Applay_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OringnalImg_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Filteredimg_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OringnalImg_pictureBox
            // 
            this.OringnalImg_pictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OringnalImg_pictureBox.Location = new System.Drawing.Point(14, 24);
            this.OringnalImg_pictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OringnalImg_pictureBox.Name = "OringnalImg_pictureBox";
            this.OringnalImg_pictureBox.Size = new System.Drawing.Size(325, 271);
            this.OringnalImg_pictureBox.TabIndex = 0;
            this.OringnalImg_pictureBox.TabStop = false;
            // 
            // Filteredimg_pictureBox
            // 
            this.Filteredimg_pictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Filteredimg_pictureBox.Location = new System.Drawing.Point(503, 24);
            this.Filteredimg_pictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Filteredimg_pictureBox.Name = "Filteredimg_pictureBox";
            this.Filteredimg_pictureBox.Size = new System.Drawing.Size(320, 271);
            this.Filteredimg_pictureBox.TabIndex = 1;
            this.Filteredimg_pictureBox.TabStop = false;
            // 
            // lbl_by
            // 
            this.lbl_by.AutoSize = true;
            this.lbl_by.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_by.Location = new System.Drawing.Point(152, 359);
            this.lbl_by.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_by.Name = "lbl_by";
            this.lbl_by.Size = new System.Drawing.Size(14, 13);
            this.lbl_by.TabIndex = 9;
            this.lbl_by.Text = "*";
            // 
            // txt_mask_height
            // 
            this.txt_mask_height.Location = new System.Drawing.Point(81, 351);
            this.txt_mask_height.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mask_height.Name = "txt_mask_height";
            this.txt_mask_height.Size = new System.Drawing.Size(63, 21);
            this.txt_mask_height.TabIndex = 8;
            // 
            // lbl_mask_size
            // 
            this.lbl_mask_size.AutoSize = true;
            this.lbl_mask_size.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lbl_mask_size.Location = new System.Drawing.Point(17, 322);
            this.lbl_mask_size.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_mask_size.Name = "lbl_mask_size";
            this.lbl_mask_size.Size = new System.Drawing.Size(113, 13);
            this.lbl_mask_size.TabIndex = 7;
            this.lbl_mask_size.Text = "Mask size (H * W) :";
            // 
            // txt_mask_width
            // 
            this.txt_mask_width.Location = new System.Drawing.Point(174, 351);
            this.txt_mask_width.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mask_width.Name = "txt_mask_width";
            this.txt_mask_width.Size = new System.Drawing.Size(63, 21);
            this.txt_mask_width.TabIndex = 10;
            // 
            // txt_sigma
            // 
            this.txt_sigma.Location = new System.Drawing.Point(81, 416);
            this.txt_sigma.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sigma.Name = "txt_sigma";
            this.txt_sigma.Size = new System.Drawing.Size(63, 21);
            this.txt_sigma.TabIndex = 13;
            // 
            // btn_opt1_apply_filter
            // 
            this.btn_opt1_apply_filter.BackColor = System.Drawing.Color.White;
            this.btn_opt1_apply_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_opt1_apply_filter.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btn_opt1_apply_filter.Location = new System.Drawing.Point(192, 416);
            this.btn_opt1_apply_filter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_opt1_apply_filter.Name = "btn_opt1_apply_filter";
            this.btn_opt1_apply_filter.Size = new System.Drawing.Size(82, 26);
            this.btn_opt1_apply_filter.TabIndex = 12;
            this.btn_opt1_apply_filter.Text = "Apply Filter";
            this.btn_opt1_apply_filter.UseVisualStyleBackColor = false;
            this.btn_opt1_apply_filter.Click += new System.EventHandler(this.btn_opt1_apply_filter_Click);
            // 
            // lbl_sigma
            // 
            this.lbl_sigma.AutoSize = true;
            this.lbl_sigma.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lbl_sigma.Location = new System.Drawing.Point(23, 416);
            this.lbl_sigma.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_sigma.Name = "lbl_sigma";
            this.lbl_sigma.Size = new System.Drawing.Size(48, 13);
            this.lbl_sigma.TabIndex = 11;
            this.lbl_sigma.Text = "Sigma :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(468, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "After :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(8, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "BEFORE :";
            // 
            // UnDo_button
            // 
            this.UnDo_button.BackColor = System.Drawing.Color.White;
            this.UnDo_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnDo_button.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.UnDo_button.Location = new System.Drawing.Point(691, 311);
            this.UnDo_button.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.UnDo_button.Name = "UnDo_button";
            this.UnDo_button.Size = new System.Drawing.Size(97, 34);
            this.UnDo_button.TabIndex = 16;
            this.UnDo_button.Text = "Reset";
            this.UnDo_button.UseVisualStyleBackColor = false;
            this.UnDo_button.Click += new System.EventHandler(this.UnDo_button_Click);
            // 
            // label_def
            // 
            this.label_def.AutoSize = true;
            this.label_def.Location = new System.Drawing.Point(346, 126);
            this.label_def.Name = "label_def";
            this.label_def.Size = new System.Drawing.Size(69, 13);
            this.label_def.TabIndex = 17;
            this.label_def.Text = "Mask Size :";
            // 
            // label2_def
            // 
            this.label2_def.AutoSize = true;
            this.label2_def.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2_def.Location = new System.Drawing.Point(356, 154);
            this.label2_def.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2_def.Name = "label2_def";
            this.label2_def.Size = new System.Drawing.Size(48, 13);
            this.label2_def.TabIndex = 18;
            this.label2_def.Text = "Sigma :";
            // 
            // Applay_button
            // 
            this.Applay_button.BackColor = System.Drawing.Color.White;
            this.Applay_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Applay_button.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.Applay_button.Location = new System.Drawing.Point(691, 355);
            this.Applay_button.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Applay_button.Name = "Applay_button";
            this.Applay_button.Size = new System.Drawing.Size(97, 34);
            this.Applay_button.TabIndex = 19;
            this.Applay_button.Text = "Apply";
            this.Applay_button.UseVisualStyleBackColor = false;
            this.Applay_button.Click += new System.EventHandler(this.Applay_button_Click);
            // 
            // Guassian_filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 468);
            this.Controls.Add(this.Applay_button);
            this.Controls.Add(this.label2_def);
            this.Controls.Add(this.label_def);
            this.Controls.Add(this.UnDo_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sigma);
            this.Controls.Add(this.btn_opt1_apply_filter);
            this.Controls.Add(this.lbl_sigma);
            this.Controls.Add(this.txt_mask_width);
            this.Controls.Add(this.lbl_by);
            this.Controls.Add(this.txt_mask_height);
            this.Controls.Add(this.lbl_mask_size);
            this.Controls.Add(this.Filteredimg_pictureBox);
            this.Controls.Add(this.OringnalImg_pictureBox);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Guassian_filter";
            this.Text = "User Input Guassian Filter";
            ((System.ComponentModel.ISupportInitialize)(this.OringnalImg_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Filteredimg_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox OringnalImg_pictureBox;
        private System.Windows.Forms.PictureBox Filteredimg_pictureBox;
        private System.Windows.Forms.Label lbl_by;
        private System.Windows.Forms.TextBox txt_mask_height;
        private System.Windows.Forms.Label lbl_mask_size;
        private System.Windows.Forms.TextBox txt_mask_width;
        private System.Windows.Forms.TextBox txt_sigma;
        private System.Windows.Forms.Button btn_opt1_apply_filter;
        private System.Windows.Forms.Label lbl_sigma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UnDo_button;
        private System.Windows.Forms.Label label_def;
        private System.Windows.Forms.Label label2_def;
        private System.Windows.Forms.Button Applay_button;
    }
}