namespace Image_ProcessingPackage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openP3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageEnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geometryOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guassianToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.option1UserInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.option2computedMaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplacianSharpeningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compassEdgeDetectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kirschToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxInputImage = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInputImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItem,
            this.operationsToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1,
            this.exitToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(685, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openP3ToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.imageToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageToolStripMenuItem.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openP3ToolStripMenuItem
            // 
            this.openP3ToolStripMenuItem.Name = "openP3ToolStripMenuItem";
            this.openP3ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.openP3ToolStripMenuItem.Text = "Open PPM";
            this.openP3ToolStripMenuItem.Click += new System.EventHandler(this.openP3ToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.saveToolStripMenuItem.Text = "Save ";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageEnToolStripMenuItem,
            this.geometryOperationsToolStripMenuItem});
            this.operationsToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationsToolStripMenuItem.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // imageEnToolStripMenuItem
            // 
            this.imageEnToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageEnToolStripMenuItem.Name = "imageEnToolStripMenuItem";
            this.imageEnToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.imageEnToolStripMenuItem.Text = "Image Enhancement";
            this.imageEnToolStripMenuItem.Click += new System.EventHandler(this.imageEnToolStripMenuItem_Click);
            // 
            // geometryOperationsToolStripMenuItem
            // 
            this.geometryOperationsToolStripMenuItem.Name = "geometryOperationsToolStripMenuItem";
            this.geometryOperationsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.geometryOperationsToolStripMenuItem.Text = " Geometry Operations";
            this.geometryOperationsToolStripMenuItem.Click += new System.EventHandler(this.geometryOperationsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guassianToolStripMenuItem1,
            this.meanToolStripMenuItem,
            this.laplacianSharpeningToolStripMenuItem,
            this.compassEdgeDetectToolStripMenuItem});
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(54, 21);
            this.exitToolStripMenuItem.Text = "Filters";
            // 
            // guassianToolStripMenuItem1
            // 
            this.guassianToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.option1UserInputToolStripMenuItem,
            this.option2computedMaskToolStripMenuItem});
            this.guassianToolStripMenuItem1.Name = "guassianToolStripMenuItem1";
            this.guassianToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.guassianToolStripMenuItem1.Text = "Guassian";
            // 
            // option1UserInputToolStripMenuItem
            // 
            this.option1UserInputToolStripMenuItem.Name = "option1UserInputToolStripMenuItem";
            this.option1UserInputToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.option1UserInputToolStripMenuItem.Text = "Option1(UserInput)";
            this.option1UserInputToolStripMenuItem.Click += new System.EventHandler(this.option1UserInputToolStripMenuItem_Click);
            // 
            // option2computedMaskToolStripMenuItem
            // 
            this.option2computedMaskToolStripMenuItem.Name = "option2computedMaskToolStripMenuItem";
            this.option2computedMaskToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.option2computedMaskToolStripMenuItem.Text = "Option2(computed Mask)";
            this.option2computedMaskToolStripMenuItem.Click += new System.EventHandler(this.option2computedMaskToolStripMenuItem_Click);
            // 
            // meanToolStripMenuItem
            // 
            this.meanToolStripMenuItem.Name = "meanToolStripMenuItem";
            this.meanToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.meanToolStripMenuItem.Text = "Mean ";
            this.meanToolStripMenuItem.Click += new System.EventHandler(this.meanToolStripMenuItem_Click);
            // 
            // laplacianSharpeningToolStripMenuItem
            // 
            this.laplacianSharpeningToolStripMenuItem.Name = "laplacianSharpeningToolStripMenuItem";
            this.laplacianSharpeningToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.laplacianSharpeningToolStripMenuItem.Text = " \tLaplacian Sharpening";
            this.laplacianSharpeningToolStripMenuItem.Click += new System.EventHandler(this.laplacianSharpeningToolStripMenuItem_Click);
            // 
            // compassEdgeDetectToolStripMenuItem
            // 
            this.compassEdgeDetectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kirschToolStripMenuItem});
            this.compassEdgeDetectToolStripMenuItem.Name = "compassEdgeDetectToolStripMenuItem";
            this.compassEdgeDetectToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.compassEdgeDetectToolStripMenuItem.Text = "Compass Edge Detect";
            // 
            // kirschToolStripMenuItem
            // 
            this.kirschToolStripMenuItem.Name = "kirschToolStripMenuItem";
            this.kirschToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.kirschToolStripMenuItem.Text = "4 Kirsch Filters";
            this.kirschToolStripMenuItem.Click += new System.EventHandler(this.kirschToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(101, 21);
            this.exitToolStripMenuItem1.Text = "Image Algebra";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(40, 21);
            this.exitToolStripMenuItem2.Text = "Exit";
            this.exitToolStripMenuItem2.Click += new System.EventHandler(this.exitToolStripMenuItem2_Click);
            // 
            // pictureBoxInputImage
            // 
            this.pictureBoxInputImage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxInputImage.Location = new System.Drawing.Point(48, 58);
            this.pictureBoxInputImage.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxInputImage.Name = "pictureBoxInputImage";
            this.pictureBoxInputImage.Size = new System.Drawing.Size(573, 478);
            this.pictureBoxInputImage.TabIndex = 2;
            this.pictureBoxInputImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(685, 549);
            this.Controls.Add(this.pictureBoxInputImage);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DeepPink;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Image Processing ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInputImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openP3ToolStripMenuItem;
        public System.Windows.Forms.PictureBox pictureBoxInputImage;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageEnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem guassianToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem option1UserInputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem option2computedMaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geometryOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem meanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplacianSharpeningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compassEdgeDetectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kirschToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}