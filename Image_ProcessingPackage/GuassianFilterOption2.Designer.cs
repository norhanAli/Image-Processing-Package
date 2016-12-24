namespace Image_ProcessingPackage
{
    partial class GuassianFilterOption2
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
            this.pictureBoxOrGImG = new System.Windows.Forms.PictureBox();
            this.pictureBoxFilteredGau = new System.Windows.Forms.PictureBox();
            this.txt_sigma = new System.Windows.Forms.TextBox();
            this.lbl_sigma = new System.Windows.Forms.Label();
            this.btn_opt2_apply_filter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Reset_button = new System.Windows.Forms.Button();
            this.Apply_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrGImG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilteredGau)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOrGImG
            // 
            this.pictureBoxOrGImG.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxOrGImG.Location = new System.Drawing.Point(8, 25);
            this.pictureBoxOrGImG.Name = "pictureBoxOrGImG";
            this.pictureBoxOrGImG.Size = new System.Drawing.Size(300, 288);
            this.pictureBoxOrGImG.TabIndex = 0;
            this.pictureBoxOrGImG.TabStop = false;
            // 
            // pictureBoxFilteredGau
            // 
            this.pictureBoxFilteredGau.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxFilteredGau.Location = new System.Drawing.Point(458, 25);
            this.pictureBoxFilteredGau.Name = "pictureBoxFilteredGau";
            this.pictureBoxFilteredGau.Size = new System.Drawing.Size(300, 288);
            this.pictureBoxFilteredGau.TabIndex = 1;
            this.pictureBoxFilteredGau.TabStop = false;
            // 
            // txt_sigma
            // 
            this.txt_sigma.Location = new System.Drawing.Point(79, 327);
            this.txt_sigma.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_sigma.Name = "txt_sigma";
            this.txt_sigma.Size = new System.Drawing.Size(76, 22);
            this.txt_sigma.TabIndex = 3;
            // 
            // lbl_sigma
            // 
            this.lbl_sigma.AutoSize = true;
            this.lbl_sigma.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lbl_sigma.Location = new System.Drawing.Point(15, 327);
            this.lbl_sigma.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_sigma.Name = "lbl_sigma";
            this.lbl_sigma.Size = new System.Drawing.Size(52, 14);
            this.lbl_sigma.TabIndex = 2;
            this.lbl_sigma.Text = "Sigma :";
            // 
            // btn_opt2_apply_filter
            // 
            this.btn_opt2_apply_filter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_opt2_apply_filter.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btn_opt2_apply_filter.Location = new System.Drawing.Point(202, 327);
            this.btn_opt2_apply_filter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_opt2_apply_filter.Name = "btn_opt2_apply_filter";
            this.btn_opt2_apply_filter.Size = new System.Drawing.Size(94, 22);
            this.btn_opt2_apply_filter.TabIndex = 4;
            this.btn_opt2_apply_filter.Text = "Apply Filter ";
            this.btn_opt2_apply_filter.UseVisualStyleBackColor = true;
            this.btn_opt2_apply_filter.Click += new System.EventHandler(this.btn_opt2_apply_filter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(5, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "BEFORE :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(424, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 14);
            this.label1.TabIndex = 16;
            this.label1.Text = "After :";
            // 
            // Reset_button
            // 
            this.Reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset_button.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.Reset_button.Location = new System.Drawing.Point(767, 135);
            this.Reset_button.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(98, 30);
            this.Reset_button.TabIndex = 18;
            this.Reset_button.Text = "Reset";
            this.Reset_button.UseVisualStyleBackColor = true;
            this.Reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // Apply_button
            // 
            this.Apply_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Apply_button.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.Apply_button.Location = new System.Drawing.Point(767, 60);
            this.Apply_button.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Apply_button.Name = "Apply_button";
            this.Apply_button.Size = new System.Drawing.Size(98, 30);
            this.Apply_button.TabIndex = 19;
            this.Apply_button.Text = "Apply";
            this.Apply_button.UseVisualStyleBackColor = true;
            this.Apply_button.Click += new System.EventHandler(this.Apply_button_Click);
            // 
            // GuassianFilterOption2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(871, 376);
            this.Controls.Add(this.Apply_button);
            this.Controls.Add(this.Reset_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_opt2_apply_filter);
            this.Controls.Add(this.txt_sigma);
            this.Controls.Add(this.lbl_sigma);
            this.Controls.Add(this.pictureBoxFilteredGau);
            this.Controls.Add(this.pictureBoxOrGImG);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GuassianFilterOption2";
            this.Text = "GuassianFilterOption2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrGImG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilteredGau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOrGImG;
        private System.Windows.Forms.PictureBox pictureBoxFilteredGau;
        private System.Windows.Forms.TextBox txt_sigma;
        private System.Windows.Forms.Label lbl_sigma;
        private System.Windows.Forms.Button btn_opt2_apply_filter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.Button Apply_button;
    }
}