namespace Seadanya_testing
{
    partial class cardResep
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cardResep));
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.cardImage = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.cardDesc = new System.Windows.Forms.Label();
            this.cardTitle = new System.Windows.Forms.Label();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardImage)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 20;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.cardImage);
            this.bunifuPanel1.Controls.Add(this.cardDesc);
            this.bunifuPanel1.Controls.Add(this.cardTitle);
            this.bunifuPanel1.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(960, 192);
            this.bunifuPanel1.TabIndex = 14;
            this.bunifuPanel1.Click += new System.EventHandler(this.bunifuPanel1_Click);
            // 
            // cardImage
            // 
            this.cardImage.AllowFocused = false;
            this.cardImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardImage.AutoSizeHeight = false;
            this.cardImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cardImage.BackgroundImage")));
            this.cardImage.BorderRadius = 10;
            this.cardImage.Image = ((System.Drawing.Image)(resources.GetObject("cardImage.Image")));
            this.cardImage.IsCircle = false;
            this.cardImage.Location = new System.Drawing.Point(30, 21);
            this.cardImage.Name = "cardImage";
            this.cardImage.Size = new System.Drawing.Size(208, 151);
            this.cardImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardImage.TabIndex = 9;
            this.cardImage.TabStop = false;
            this.cardImage.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            // 
            // cardDesc
            // 
            this.cardDesc.BackColor = System.Drawing.Color.Transparent;
            this.cardDesc.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardDesc.ForeColor = System.Drawing.Color.Black;
            this.cardDesc.Location = new System.Drawing.Point(267, 79);
            this.cardDesc.MinimumSize = new System.Drawing.Size(640, 84);
            this.cardDesc.Name = "cardDesc";
            this.cardDesc.Size = new System.Drawing.Size(640, 93);
            this.cardDesc.TabIndex = 8;
            this.cardDesc.Text = "deskripsi";
            // 
            // cardTitle
            // 
            this.cardTitle.BackColor = System.Drawing.Color.Transparent;
            this.cardTitle.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardTitle.ForeColor = System.Drawing.Color.Black;
            this.cardTitle.Location = new System.Drawing.Point(265, 21);
            this.cardTitle.MinimumSize = new System.Drawing.Size(640, 36);
            this.cardTitle.Name = "cardTitle";
            this.cardTitle.Size = new System.Drawing.Size(640, 36);
            this.cardTitle.TabIndex = 7;
            this.cardTitle.Text = "Title";
            // 
            // cardResep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuPanel1);
            this.MaximumSize = new System.Drawing.Size(960, 192);
            this.Name = "cardResep";
            this.Size = new System.Drawing.Size(960, 192);
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cardImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label cardDesc;
        private System.Windows.Forms.Label cardTitle;
        private Bunifu.UI.WinForms.BunifuPictureBox cardImage;
    }
}
