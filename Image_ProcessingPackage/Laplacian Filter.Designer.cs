namespace Image_ProcessingPackage
{
    partial class Laplacian_Filter
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
            this.label3 = new System.Windows.Forms.Label();
            this.undo_button = new System.Windows.Forms.Button();
            this.Diagonal2_button = new System.Windows.Forms.Button();
            this.Sharp_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.After_pictureBox = new System.Windows.Forms.PictureBox();
            this.before_pictureBox = new System.Windows.Forms.PictureBox();
            this.Applay_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.After_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.before_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Before Sharping :";
            // 
            // undo_button
            // 
            this.undo_button.BackColor = System.Drawing.Color.White;
            this.undo_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undo_button.Location = new System.Drawing.Point(765, 398);
            this.undo_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.undo_button.Name = "undo_button";
            this.undo_button.Size = new System.Drawing.Size(97, 32);
            this.undo_button.TabIndex = 32;
            this.undo_button.Text = "Reset";
            this.undo_button.UseVisualStyleBackColor = false;
            this.undo_button.Click += new System.EventHandler(this.undo_button_Click);
            // 
            // Diagonal2_button
            // 
            this.Diagonal2_button.Location = new System.Drawing.Point(75, 658);
            this.Diagonal2_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Diagonal2_button.Name = "Diagonal2_button";
            this.Diagonal2_button.Size = new System.Drawing.Size(278, 47);
            this.Diagonal2_button.TabIndex = 31;
            this.Diagonal2_button.Text = "Show Diagonal\\ Effect";
            this.Diagonal2_button.UseVisualStyleBackColor = true;
            // 
            // Sharp_Button
            // 
            this.Sharp_Button.BackColor = System.Drawing.Color.White;
            this.Sharp_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sharp_Button.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.Sharp_Button.Location = new System.Drawing.Point(367, 398);
            this.Sharp_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Sharp_Button.Name = "Sharp_Button";
            this.Sharp_Button.Size = new System.Drawing.Size(127, 32);
            this.Sharp_Button.TabIndex = 30;
            this.Sharp_Button.Text = "Sharp";
            this.Sharp_Button.UseVisualStyleBackColor = false;
            this.Sharp_Button.Click += new System.EventHandler(this.Sharp_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "After Sharpning";
            // 
            // After_pictureBox
            // 
            this.After_pictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.After_pictureBox.Location = new System.Drawing.Point(495, 40);
            this.After_pictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.After_pictureBox.Name = "After_pictureBox";
            this.After_pictureBox.Size = new System.Drawing.Size(367, 335);
            this.After_pictureBox.TabIndex = 26;
            this.After_pictureBox.TabStop = false;
            // 
            // before_pictureBox
            // 
            this.before_pictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.before_pictureBox.Location = new System.Drawing.Point(12, 40);
            this.before_pictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.before_pictureBox.Name = "before_pictureBox";
            this.before_pictureBox.Size = new System.Drawing.Size(353, 335);
            this.before_pictureBox.TabIndex = 25;
            this.before_pictureBox.TabStop = false;
            // 
            // Applay_button
            // 
            this.Applay_button.BackColor = System.Drawing.Color.White;
            this.Applay_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Applay_button.Location = new System.Drawing.Point(765, 455);
            this.Applay_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Applay_button.Name = "Applay_button";
            this.Applay_button.Size = new System.Drawing.Size(97, 29);
            this.Applay_button.TabIndex = 35;
            this.Applay_button.Text = "Apply";
            this.Applay_button.UseVisualStyleBackColor = false;
            this.Applay_button.Click += new System.EventHandler(this.Applay_button_Click);
            // 
            // Laplacian_Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 542);
            this.Controls.Add(this.Applay_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.undo_button);
            this.Controls.Add(this.Diagonal2_button);
            this.Controls.Add(this.Sharp_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.After_pictureBox);
            this.Controls.Add(this.before_pictureBox);
            this.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Laplacian_Filter";
            this.Text = "Laplacian_Filter";
            ((System.ComponentModel.ISupportInitialize)(this.After_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.before_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button undo_button;
        private System.Windows.Forms.Button Diagonal2_button;
        private System.Windows.Forms.Button Sharp_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox After_pictureBox;
        private System.Windows.Forms.PictureBox before_pictureBox;
        private System.Windows.Forms.Button Applay_button;
    }
}