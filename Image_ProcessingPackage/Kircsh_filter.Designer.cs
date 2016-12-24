namespace Image_ProcessingPackage
{
    partial class Kircsh_filter
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
            this.Diagonal2_button = new System.Windows.Forms.Button();
            this.Digonal1_button = new System.Windows.Forms.Button();
            this.VerticalMatrix_button = new System.Windows.Forms.Button();
            this.HorizontalMatrix_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.afterKircsh_pictureBox = new System.Windows.Forms.PictureBox();
            this.before_kircsh_pictureBox = new System.Windows.Forms.PictureBox();
            this.undo_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Applay_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.afterKircsh_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.before_kircsh_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Diagonal2_button
            // 
            this.Diagonal2_button.Location = new System.Drawing.Point(52, 469);
            this.Diagonal2_button.Name = "Diagonal2_button";
            this.Diagonal2_button.Size = new System.Drawing.Size(208, 34);
            this.Diagonal2_button.TabIndex = 21;
            this.Diagonal2_button.Text = "Show Diagonal\\ Effect";
            this.Diagonal2_button.UseVisualStyleBackColor = true;
            this.Diagonal2_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // Digonal1_button
            // 
            this.Digonal1_button.Location = new System.Drawing.Point(52, 426);
            this.Digonal1_button.Name = "Digonal1_button";
            this.Digonal1_button.Size = new System.Drawing.Size(208, 36);
            this.Digonal1_button.TabIndex = 20;
            this.Digonal1_button.Text = "Show  Diagonal/ Effect ";
            this.Digonal1_button.UseVisualStyleBackColor = true;
            this.Digonal1_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // VerticalMatrix_button
            // 
            this.VerticalMatrix_button.Location = new System.Drawing.Point(52, 386);
            this.VerticalMatrix_button.Name = "VerticalMatrix_button";
            this.VerticalMatrix_button.Size = new System.Drawing.Size(208, 34);
            this.VerticalMatrix_button.TabIndex = 19;
            this.VerticalMatrix_button.Text = "Show vertical Effect";
            this.VerticalMatrix_button.UseVisualStyleBackColor = true;
            this.VerticalMatrix_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // HorizontalMatrix_button
            // 
            this.HorizontalMatrix_button.Location = new System.Drawing.Point(52, 342);
            this.HorizontalMatrix_button.Name = "HorizontalMatrix_button";
            this.HorizontalMatrix_button.Size = new System.Drawing.Size(208, 40);
            this.HorizontalMatrix_button.TabIndex = 18;
            this.HorizontalMatrix_button.Text = "Show  horizontal Effect";
            this.HorizontalMatrix_button.UseVisualStyleBackColor = true;
            this.HorizontalMatrix_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "After Kircsh filter";
            // 
            // afterKircsh_pictureBox
            // 
            this.afterKircsh_pictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.afterKircsh_pictureBox.Location = new System.Drawing.Point(451, 29);
            this.afterKircsh_pictureBox.Name = "afterKircsh_pictureBox";
            this.afterKircsh_pictureBox.Size = new System.Drawing.Size(381, 264);
            this.afterKircsh_pictureBox.TabIndex = 16;
            this.afterKircsh_pictureBox.TabStop = false;
            // 
            // before_kircsh_pictureBox
            // 
            this.before_kircsh_pictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.before_kircsh_pictureBox.Location = new System.Drawing.Point(12, 29);
            this.before_kircsh_pictureBox.Name = "before_kircsh_pictureBox";
            this.before_kircsh_pictureBox.Size = new System.Drawing.Size(363, 268);
            this.before_kircsh_pictureBox.TabIndex = 15;
            this.before_kircsh_pictureBox.TabStop = false;
            // 
            // undo_button
            // 
            this.undo_button.Location = new System.Drawing.Point(567, 316);
            this.undo_button.Name = "undo_button";
            this.undo_button.Size = new System.Drawing.Size(136, 40);
            this.undo_button.TabIndex = 22;
            this.undo_button.Text = "Reset";
            this.undo_button.UseVisualStyleBackColor = true;
            this.undo_button.Click += new System.EventHandler(this.undo_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Kircsh Options :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Before Kircsh filter";
            // 
            // Applay_button
            // 
            this.Applay_button.Location = new System.Drawing.Point(567, 383);
            this.Applay_button.Name = "Applay_button";
            this.Applay_button.Size = new System.Drawing.Size(136, 40);
            this.Applay_button.TabIndex = 25;
            this.Applay_button.Text = "Apply";
            this.Applay_button.UseVisualStyleBackColor = true;
            this.Applay_button.Click += new System.EventHandler(this.Applay_button_Click);
            // 
            // Kircsh_filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(846, 511);
            this.Controls.Add(this.Applay_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.undo_button);
            this.Controls.Add(this.Diagonal2_button);
            this.Controls.Add(this.Digonal1_button);
            this.Controls.Add(this.VerticalMatrix_button);
            this.Controls.Add(this.HorizontalMatrix_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.afterKircsh_pictureBox);
            this.Controls.Add(this.before_kircsh_pictureBox);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DeepPink;
            this.Name = "Kircsh_filter";
            this.Text = "Kircsh_filter";
            ((System.ComponentModel.ISupportInitialize)(this.afterKircsh_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.before_kircsh_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Diagonal2_button;
        private System.Windows.Forms.Button Digonal1_button;
        private System.Windows.Forms.Button VerticalMatrix_button;
        private System.Windows.Forms.Button HorizontalMatrix_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox afterKircsh_pictureBox;
        private System.Windows.Forms.PictureBox before_kircsh_pictureBox;
        private System.Windows.Forms.Button undo_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Applay_button;
    }
}