namespace KG_Lab2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbOriginalImage = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbNewImage = new System.Windows.Forms.PictureBox();
            this.processButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbNewColor = new System.Windows.Forms.PictureBox();
            this.chooseColorButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pbOldColor = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.sensetiveTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginalImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewImage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOldColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensetiveTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbOriginalImage
            // 
            this.pbOriginalImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbOriginalImage.Location = new System.Drawing.Point(13, 42);
            this.pbOriginalImage.Name = "pbOriginalImage";
            this.pbOriginalImage.Size = new System.Drawing.Size(426, 354);
            this.pbOriginalImage.TabIndex = 1;
            this.pbOriginalImage.TabStop = false;
            this.pbOriginalImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chooseColor);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1113, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.fileToolStripMenuItem.Text = "Image";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.openToolStripMenuItem.Text = "Load new";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openButton_Click);
            // 
            // pbNewImage
            // 
            this.pbNewImage.Location = new System.Drawing.Point(671, 42);
            this.pbNewImage.Name = "pbNewImage";
            this.pbNewImage.Size = new System.Drawing.Size(442, 354);
            this.pbNewImage.TabIndex = 3;
            this.pbNewImage.TabStop = false;
            // 
            // processButton
            // 
            this.processButton.Enabled = false;
            this.processButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.processButton.Location = new System.Drawing.Point(499, 412);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(111, 38);
            this.processButton.TabIndex = 4;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(356, 456);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(405, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.sensetiveTrackBar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pbNewColor);
            this.panel1.Controls.Add(this.chooseColorButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pbOldColor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(458, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 354);
            this.panel1.TabIndex = 6;
            // 
            // pbNewColor
            // 
            this.pbNewColor.Location = new System.Drawing.Point(29, 156);
            this.pbNewColor.Name = "pbNewColor";
            this.pbNewColor.Size = new System.Drawing.Size(141, 68);
            this.pbNewColor.TabIndex = 4;
            this.pbNewColor.TabStop = false;
            // 
            // chooseColorButton
            // 
            this.chooseColorButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseColorButton.Location = new System.Drawing.Point(29, 240);
            this.chooseColorButton.Name = "chooseColorButton";
            this.chooseColorButton.Size = new System.Drawing.Size(141, 33);
            this.chooseColorButton.TabIndex = 3;
            this.chooseColorButton.Text = "Choose new color";
            this.chooseColorButton.UseVisualStyleBackColor = true;
            this.chooseColorButton.Click += new System.EventHandler(this.ChooseColorButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "New";
            // 
            // pbOldColor
            // 
            this.pbOldColor.Location = new System.Drawing.Point(29, 45);
            this.pbOldColor.Name = "pbOldColor";
            this.pbOldColor.Size = new System.Drawing.Size(141, 66);
            this.pbOldColor.TabIndex = 1;
            this.pbOldColor.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sensetive";
            // 
            // sensetiveTrackBar
            // 
            this.sensetiveTrackBar.LargeChange = 10;
            this.sensetiveTrackBar.Location = new System.Drawing.Point(29, 307);
            this.sensetiveTrackBar.Maximum = 50;
            this.sensetiveTrackBar.Name = "sensetiveTrackBar";
            this.sensetiveTrackBar.Size = new System.Drawing.Size(141, 45);
            this.sensetiveTrackBar.TabIndex = 6;
            this.sensetiveTrackBar.TickFrequency = 5;
            this.sensetiveTrackBar.Value = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.pbNewImage);
            this.Controls.Add(this.pbOriginalImage);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change color in picture";
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginalImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOldColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensetiveTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbOriginalImage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbNewImage;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbOldColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pbNewColor;
        private System.Windows.Forms.Button chooseColorButton;
        private System.Windows.Forms.TrackBar sensetiveTrackBar;
        private System.Windows.Forms.Label label3;
    }
};

