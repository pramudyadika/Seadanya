namespace Seadanya_testing
{
    partial class EditRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRecipe));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtb_Bahan = new System.Windows.Forms.RichTextBox();
            this.rtb_Langkah = new System.Windows.Forms.RichTextBox();
            this.tb_Link = new System.Windows.Forms.TextBox();
            this.tb_NamaResep = new System.Windows.Forms.TextBox();
            this.btn_Batal = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_Submit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Resep";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 72);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Link Foto :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama Resep :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bahan :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Langkah :";
            // 
            // rtb_Bahan
            // 
            this.rtb_Bahan.Location = new System.Drawing.Point(38, 326);
            this.rtb_Bahan.Name = "rtb_Bahan";
            this.rtb_Bahan.Size = new System.Drawing.Size(444, 113);
            this.rtb_Bahan.TabIndex = 10;
            this.rtb_Bahan.Text = "";
            // 
            // rtb_Langkah
            // 
            this.rtb_Langkah.Location = new System.Drawing.Point(37, 495);
            this.rtb_Langkah.Name = "rtb_Langkah";
            this.rtb_Langkah.Size = new System.Drawing.Size(444, 113);
            this.rtb_Langkah.TabIndex = 11;
            this.rtb_Langkah.Text = "";
            // 
            // tb_Link
            // 
            this.tb_Link.Location = new System.Drawing.Point(37, 142);
            this.tb_Link.Multiline = true;
            this.tb_Link.Name = "tb_Link";
            this.tb_Link.Size = new System.Drawing.Size(444, 40);
            this.tb_Link.TabIndex = 12;
            // 
            // tb_NamaResep
            // 
            this.tb_NamaResep.Location = new System.Drawing.Point(37, 231);
            this.tb_NamaResep.Multiline = true;
            this.tb_NamaResep.Name = "tb_NamaResep";
            this.tb_NamaResep.Size = new System.Drawing.Size(444, 40);
            this.tb_NamaResep.TabIndex = 13;
            // 
            // btn_Batal
            // 
            this.btn_Batal.AllowAnimations = true;
            this.btn_Batal.AllowMouseEffects = true;
            this.btn_Batal.AllowToggling = false;
            this.btn_Batal.AnimationSpeed = 200;
            this.btn_Batal.AutoGenerateColors = false;
            this.btn_Batal.AutoRoundBorders = false;
            this.btn_Batal.AutoSizeLeftIcon = true;
            this.btn_Batal.AutoSizeRightIcon = true;
            this.btn_Batal.BackColor = System.Drawing.Color.Transparent;
            this.btn_Batal.BackColor1 = System.Drawing.Color.Transparent;
            this.btn_Batal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Batal.BackgroundImage")));
            this.btn_Batal.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Batal.ButtonText = "BATAL";
            this.btn_Batal.ButtonTextMarginLeft = 0;
            this.btn_Batal.ColorContrastOnClick = 45;
            this.btn_Batal.ColorContrastOnHover = 45;
            this.btn_Batal.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_Batal.CustomizableEdges = borderEdges1;
            this.btn_Batal.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Batal.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Batal.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Batal.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Batal.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Batal.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Batal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(174)))), ((int)(((byte)(24)))));
            this.btn_Batal.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Batal.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Batal.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_Batal.IconMarginLeft = 11;
            this.btn_Batal.IconPadding = 10;
            this.btn_Batal.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Batal.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Batal.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Batal.IconSize = 25;
            this.btn_Batal.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(174)))), ((int)(((byte)(24)))));
            this.btn_Batal.IdleBorderRadius = 15;
            this.btn_Batal.IdleBorderThickness = 2;
            this.btn_Batal.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_Batal.IdleIconLeftImage = null;
            this.btn_Batal.IdleIconRightImage = null;
            this.btn_Batal.IndicateFocus = false;
            this.btn_Batal.Location = new System.Drawing.Point(37, 633);
            this.btn_Batal.Name = "btn_Batal";
            this.btn_Batal.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Batal.OnDisabledState.BorderRadius = 15;
            this.btn_Batal.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Batal.OnDisabledState.BorderThickness = 2;
            this.btn_Batal.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Batal.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Batal.OnDisabledState.IconLeftImage = null;
            this.btn_Batal.OnDisabledState.IconRightImage = null;
            this.btn_Batal.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(174)))), ((int)(((byte)(24)))));
            this.btn_Batal.onHoverState.BorderRadius = 15;
            this.btn_Batal.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Batal.onHoverState.BorderThickness = 2;
            this.btn_Batal.onHoverState.FillColor = System.Drawing.Color.Empty;
            this.btn_Batal.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(174)))), ((int)(((byte)(24)))));
            this.btn_Batal.onHoverState.IconLeftImage = null;
            this.btn_Batal.onHoverState.IconRightImage = null;
            this.btn_Batal.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(174)))), ((int)(((byte)(24)))));
            this.btn_Batal.OnIdleState.BorderRadius = 15;
            this.btn_Batal.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Batal.OnIdleState.BorderThickness = 2;
            this.btn_Batal.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btn_Batal.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(174)))), ((int)(((byte)(24)))));
            this.btn_Batal.OnIdleState.IconLeftImage = null;
            this.btn_Batal.OnIdleState.IconRightImage = null;
            this.btn_Batal.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(174)))), ((int)(((byte)(24)))));
            this.btn_Batal.OnPressedState.BorderRadius = 15;
            this.btn_Batal.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Batal.OnPressedState.BorderThickness = 2;
            this.btn_Batal.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(154)))), ((int)(((byte)(24)))));
            this.btn_Batal.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(174)))), ((int)(((byte)(24)))));
            this.btn_Batal.OnPressedState.IconLeftImage = null;
            this.btn_Batal.OnPressedState.IconRightImage = null;
            this.btn_Batal.Size = new System.Drawing.Size(150, 45);
            this.btn_Batal.TabIndex = 14;
            this.btn_Batal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Batal.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Batal.TextMarginLeft = 0;
            this.btn_Batal.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Batal.UseDefaultRadiusAndThickness = true;
            this.btn_Batal.Click += new System.EventHandler(this.btn_Batal_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.AllowAnimations = true;
            this.btn_Submit.AllowMouseEffects = true;
            this.btn_Submit.AllowToggling = false;
            this.btn_Submit.AnimationSpeed = 200;
            this.btn_Submit.AutoGenerateColors = false;
            this.btn_Submit.AutoRoundBorders = false;
            this.btn_Submit.AutoSizeLeftIcon = true;
            this.btn_Submit.AutoSizeRightIcon = true;
            this.btn_Submit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Submit.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(174)))), ((int)(((byte)(24)))));
            this.btn_Submit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Submit.BackgroundImage")));
            this.btn_Submit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Submit.ButtonText = "SUBMIT";
            this.btn_Submit.ButtonTextMarginLeft = 0;
            this.btn_Submit.ColorContrastOnClick = 45;
            this.btn_Submit.ColorContrastOnHover = 45;
            this.btn_Submit.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_Submit.CustomizableEdges = borderEdges2;
            this.btn_Submit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Submit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Submit.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Submit.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Submit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Submit.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.White;
            this.btn_Submit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Submit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Submit.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_Submit.IconMarginLeft = 11;
            this.btn_Submit.IconPadding = 10;
            this.btn_Submit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Submit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Submit.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Submit.IconSize = 25;
            this.btn_Submit.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(174)))), ((int)(((byte)(24)))));
            this.btn_Submit.IdleBorderRadius = 15;
            this.btn_Submit.IdleBorderThickness = 1;
            this.btn_Submit.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(174)))), ((int)(((byte)(24)))));
            this.btn_Submit.IdleIconLeftImage = null;
            this.btn_Submit.IdleIconRightImage = null;
            this.btn_Submit.IndicateFocus = false;
            this.btn_Submit.Location = new System.Drawing.Point(331, 633);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Submit.OnDisabledState.BorderRadius = 15;
            this.btn_Submit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Submit.OnDisabledState.BorderThickness = 1;
            this.btn_Submit.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Submit.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Submit.OnDisabledState.IconLeftImage = null;
            this.btn_Submit.OnDisabledState.IconRightImage = null;
            this.btn_Submit.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(174)))), ((int)(((byte)(24)))));
            this.btn_Submit.onHoverState.BorderRadius = 15;
            this.btn_Submit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Submit.onHoverState.BorderThickness = 1;
            this.btn_Submit.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(174)))), ((int)(((byte)(24)))));
            this.btn_Submit.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Submit.onHoverState.IconLeftImage = null;
            this.btn_Submit.onHoverState.IconRightImage = null;
            this.btn_Submit.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(174)))), ((int)(((byte)(24)))));
            this.btn_Submit.OnIdleState.BorderRadius = 15;
            this.btn_Submit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Submit.OnIdleState.BorderThickness = 1;
            this.btn_Submit.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(174)))), ((int)(((byte)(24)))));
            this.btn_Submit.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Submit.OnIdleState.IconLeftImage = null;
            this.btn_Submit.OnIdleState.IconRightImage = null;
            this.btn_Submit.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(154)))), ((int)(((byte)(24)))));
            this.btn_Submit.OnPressedState.BorderRadius = 15;
            this.btn_Submit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Submit.OnPressedState.BorderThickness = 1;
            this.btn_Submit.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(154)))), ((int)(((byte)(24)))));
            this.btn_Submit.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Submit.OnPressedState.IconLeftImage = null;
            this.btn_Submit.OnPressedState.IconRightImage = null;
            this.btn_Submit.Size = new System.Drawing.Size(150, 45);
            this.btn_Submit.TabIndex = 15;
            this.btn_Submit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Submit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Submit.TextMarginLeft = 0;
            this.btn_Submit.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Submit.UseDefaultRadiusAndThickness = true;
            // 
            // AddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(518, 712);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Batal);
            this.Controls.Add(this.tb_NamaResep);
            this.Controls.Add(this.tb_Link);
            this.Controls.Add(this.rtb_Langkah);
            this.Controls.Add(this.rtb_Bahan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRecipe";
            this.Load += new System.EventHandler(this.AddRecipe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtb_Bahan;
        private System.Windows.Forms.RichTextBox rtb_Langkah;
        private System.Windows.Forms.TextBox tb_Link;
        private System.Windows.Forms.TextBox tb_NamaResep;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Batal;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Submit;
    }
}