﻿
namespace Seadanya_testing
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeaderDesc = new System.Windows.Forms.Panel();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelSearchTags = new System.Windows.Forms.Panel();
            this.btn_Search = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtBoxSearchBar = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHeaderDesc.SuspendLayout();
            this.panelSearchTags.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelHeaderDesc
            // 
            this.panelHeaderDesc.BackColor = System.Drawing.Color.Transparent;
            this.panelHeaderDesc.Controls.Add(this.lblDesc);
            this.panelHeaderDesc.Controls.Add(this.lblHeader);
            this.panelHeaderDesc.Location = new System.Drawing.Point(9, 160);
            this.panelHeaderDesc.Margin = new System.Windows.Forms.Padding(0, 0, 0, 38);
            this.panelHeaderDesc.Name = "panelHeaderDesc";
            this.panelHeaderDesc.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.panelHeaderDesc.Size = new System.Drawing.Size(1040, 125);
            this.panelHeaderDesc.TabIndex = 2;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.Black;
            this.lblDesc.Location = new System.Drawing.Point(327, 94);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(405, 31);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Berbagai varian menu simpel ala anak kost";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Poppins", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(216, 14);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(626, 74);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Temukan Resep Sederhana";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelSearchTags
            // 
            this.panelSearchTags.BackColor = System.Drawing.Color.Transparent;
            this.panelSearchTags.Controls.Add(this.btn_Search);
            this.panelSearchTags.Controls.Add(this.txtBoxSearchBar);
            this.panelSearchTags.Location = new System.Drawing.Point(9, 314);
            this.panelSearchTags.Margin = new System.Windows.Forms.Padding(0, 0, 0, 38);
            this.panelSearchTags.Name = "panelSearchTags";
            this.panelSearchTags.Padding = new System.Windows.Forms.Padding(112, 4, 112, 4);
            this.panelSearchTags.Size = new System.Drawing.Size(1040, 81);
            this.panelSearchTags.TabIndex = 2;
            this.panelSearchTags.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSearchTags_Paint);
            // 
            // btn_Search
            // 
            this.btn_Search.AllowAnimations = true;
            this.btn_Search.AllowMouseEffects = true;
            this.btn_Search.AllowToggling = false;
            this.btn_Search.AnimationSpeed = 200;
            this.btn_Search.AutoGenerateColors = false;
            this.btn_Search.AutoRoundBorders = false;
            this.btn_Search.AutoSizeLeftIcon = true;
            this.btn_Search.AutoSizeRightIcon = true;
            this.btn_Search.BackColor = System.Drawing.Color.Transparent;
            this.btn_Search.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(112)))), ((int)(((byte)(80)))));
            this.btn_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Search.BackgroundImage")));
            this.btn_Search.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Search.ButtonText = "Search";
            this.btn_Search.ButtonTextMarginLeft = 0;
            this.btn_Search.ColorContrastOnClick = 45;
            this.btn_Search.ColorContrastOnHover = 45;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_Search.CustomizableEdges = borderEdges1;
            this.btn_Search.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Search.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Search.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Search.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Search.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Search.Font = new System.Drawing.Font("Poppins SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Search.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_Search.IconMarginLeft = 11;
            this.btn_Search.IconPadding = 10;
            this.btn_Search.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Search.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Search.IconSize = 25;
            this.btn_Search.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(112)))), ((int)(((byte)(80)))));
            this.btn_Search.IdleBorderRadius = 20;
            this.btn_Search.IdleBorderThickness = 1;
            this.btn_Search.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(112)))), ((int)(((byte)(80)))));
            this.btn_Search.IdleIconLeftImage = null;
            this.btn_Search.IdleIconRightImage = null;
            this.btn_Search.IndicateFocus = false;
            this.btn_Search.Location = new System.Drawing.Point(823, 12);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Search.OnDisabledState.BorderRadius = 20;
            this.btn_Search.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Search.OnDisabledState.BorderThickness = 1;
            this.btn_Search.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Search.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Search.OnDisabledState.IconLeftImage = null;
            this.btn_Search.OnDisabledState.IconRightImage = null;
            this.btn_Search.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(144)))), ((int)(((byte)(80)))));
            this.btn_Search.onHoverState.BorderRadius = 20;
            this.btn_Search.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Search.onHoverState.BorderThickness = 1;
            this.btn_Search.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(144)))), ((int)(((byte)(80)))));
            this.btn_Search.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Search.onHoverState.IconLeftImage = null;
            this.btn_Search.onHoverState.IconRightImage = null;
            this.btn_Search.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(112)))), ((int)(((byte)(80)))));
            this.btn_Search.OnIdleState.BorderRadius = 20;
            this.btn_Search.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Search.OnIdleState.BorderThickness = 1;
            this.btn_Search.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(112)))), ((int)(((byte)(80)))));
            this.btn_Search.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Search.OnIdleState.IconLeftImage = null;
            this.btn_Search.OnIdleState.IconRightImage = null;
            this.btn_Search.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(112)))), ((int)(((byte)(80)))));
            this.btn_Search.OnPressedState.BorderRadius = 20;
            this.btn_Search.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Search.OnPressedState.BorderThickness = 1;
            this.btn_Search.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(112)))), ((int)(((byte)(80)))));
            this.btn_Search.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Search.OnPressedState.IconLeftImage = null;
            this.btn_Search.OnPressedState.IconRightImage = null;
            this.btn_Search.Size = new System.Drawing.Size(120, 55);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Search.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Search.TextMarginLeft = 0;
            this.btn_Search.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Search.UseDefaultRadiusAndThickness = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txtBoxSearchBar
            // 
            this.txtBoxSearchBar.AcceptsReturn = false;
            this.txtBoxSearchBar.AcceptsTab = false;
            this.txtBoxSearchBar.AnimationSpeed = 200;
            this.txtBoxSearchBar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBoxSearchBar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBoxSearchBar.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxSearchBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBoxSearchBar.BackgroundImage")));
            this.txtBoxSearchBar.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtBoxSearchBar.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtBoxSearchBar.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtBoxSearchBar.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(112)))), ((int)(((byte)(80)))));
            this.txtBoxSearchBar.BorderRadius = 20;
            this.txtBoxSearchBar.BorderThickness = 3;
            this.txtBoxSearchBar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxSearchBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxSearchBar.DefaultFont = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearchBar.DefaultText = "";
            this.txtBoxSearchBar.FillColor = System.Drawing.Color.White;
            this.txtBoxSearchBar.ForeColor = System.Drawing.Color.Black;
            this.txtBoxSearchBar.HideSelection = true;
            this.txtBoxSearchBar.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtBoxSearchBar.IconLeft")));
            this.txtBoxSearchBar.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxSearchBar.IconPadding = 12;
            this.txtBoxSearchBar.IconRight = null;
            this.txtBoxSearchBar.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxSearchBar.Lines = new string[0];
            this.txtBoxSearchBar.Location = new System.Drawing.Point(116, 13);
            this.txtBoxSearchBar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSearchBar.MaxLength = 32767;
            this.txtBoxSearchBar.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtBoxSearchBar.Modified = false;
            this.txtBoxSearchBar.Multiline = false;
            this.txtBoxSearchBar.Name = "txtBoxSearchBar";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(112)))), ((int)(((byte)(80)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBoxSearchBar.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(112)))), ((int)(((byte)(80)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxSearchBar.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(112)))), ((int)(((byte)(80)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBoxSearchBar.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(112)))), ((int)(((byte)(80)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Black;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBoxSearchBar.OnIdleState = stateProperties4;
            this.txtBoxSearchBar.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxSearchBar.PasswordChar = '\0';
            this.txtBoxSearchBar.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtBoxSearchBar.PlaceholderText = "Cari bahan atau resep";
            this.txtBoxSearchBar.ReadOnly = false;
            this.txtBoxSearchBar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxSearchBar.SelectedText = "";
            this.txtBoxSearchBar.SelectionLength = 0;
            this.txtBoxSearchBar.SelectionStart = 0;
            this.txtBoxSearchBar.ShortcutsEnabled = true;
            this.txtBoxSearchBar.Size = new System.Drawing.Size(700, 55);
            this.txtBoxSearchBar.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtBoxSearchBar.TabIndex = 0;
            this.txtBoxSearchBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxSearchBar.TextMarginBottom = 0;
            this.txtBoxSearchBar.TextMarginLeft = 10;
            this.txtBoxSearchBar.TextMarginTop = 0;
            this.txtBoxSearchBar.TextPlaceholder = "Cari bahan atau resep";
            this.txtBoxSearchBar.UseSystemPasswordChar = false;
            this.txtBoxSearchBar.WordWrap = true;
            this.txtBoxSearchBar.TextChanged += new System.EventHandler(this.txtBoxSearchBar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(399, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rekomendasi resep minggu ini";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(786, 488);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(204, 133);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(327, 488);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(206, 133);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(554, 488);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(211, 133);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(96, 488);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(210, 133);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1058, 712);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelSearchTags);
            this.Controls.Add(this.panelHeaderDesc);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHeaderDesc.ResumeLayout(false);
            this.panelHeaderDesc.PerformLayout();
            this.panelSearchTags.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelHeaderDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panelSearchTags;
        private Bunifu.UI.WinForms.BunifuTextBox txtBoxSearchBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Search;
    }
}