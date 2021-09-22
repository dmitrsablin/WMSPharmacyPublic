namespace WMSPharmacy.Forms
{
    partial class SettingsForm
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
            this.windowLabel = new System.Windows.Forms.Label();
            this.minimazeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.closeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.adressDBTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.nameDBTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.loginDBTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.passwordDBTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dbCards = new Bunifu.Framework.UI.BunifuCards();
            this.createDBButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.dbLabel = new System.Windows.Forms.Label();
            this.saveDBSettingsButton = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.minimazeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.dbCards.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowLabel
            // 
            this.windowLabel.AutoSize = true;
            this.windowLabel.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.windowLabel.ForeColor = System.Drawing.Color.Gray;
            this.windowLabel.Location = new System.Drawing.Point(12, 9);
            this.windowLabel.Name = "windowLabel";
            this.windowLabel.Size = new System.Drawing.Size(162, 33);
            this.windowLabel.TabIndex = 8;
            this.windowLabel.Text = "Настройки";
            // 
            // minimazeButton
            // 
            this.minimazeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimazeButton.Image = global::WMSPharmacy.Properties.Resources.HideWindow;
            this.minimazeButton.ImageActive = null;
            this.minimazeButton.Location = new System.Drawing.Point(345, 9);
            this.minimazeButton.Name = "minimazeButton";
            this.minimazeButton.Size = new System.Drawing.Size(32, 33);
            this.minimazeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimazeButton.TabIndex = 10;
            this.minimazeButton.TabStop = false;
            this.minimazeButton.Zoom = 10;
            this.minimazeButton.Click += new System.EventHandler(this.MinimizeButtonClick);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = global::WMSPharmacy.Properties.Resources.CloseWindow;
            this.closeButton.ImageActive = null;
            this.closeButton.Location = new System.Drawing.Point(383, 9);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 33);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 9;
            this.closeButton.TabStop = false;
            this.closeButton.Zoom = 10;
            this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // adressDBTextbox
            // 
            this.adressDBTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.adressDBTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.adressDBTextbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.adressDBTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adressDBTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.adressDBTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adressDBTextbox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adressDBTextbox.HintText = "IP базы данных";
            this.adressDBTextbox.isPassword = false;
            this.adressDBTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.adressDBTextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.adressDBTextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.adressDBTextbox.LineThickness = 3;
            this.adressDBTextbox.Location = new System.Drawing.Point(18, 32);
            this.adressDBTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.adressDBTextbox.MaxLength = 32767;
            this.adressDBTextbox.Name = "adressDBTextbox";
            this.adressDBTextbox.Size = new System.Drawing.Size(379, 33);
            this.adressDBTextbox.TabIndex = 11;
            this.adressDBTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameDBTextbox
            // 
            this.nameDBTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.nameDBTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.nameDBTextbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nameDBTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameDBTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.nameDBTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameDBTextbox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameDBTextbox.HintText = "База данных";
            this.nameDBTextbox.isPassword = false;
            this.nameDBTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.nameDBTextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.nameDBTextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.nameDBTextbox.LineThickness = 3;
            this.nameDBTextbox.Location = new System.Drawing.Point(18, 73);
            this.nameDBTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.nameDBTextbox.MaxLength = 32767;
            this.nameDBTextbox.Name = "nameDBTextbox";
            this.nameDBTextbox.Size = new System.Drawing.Size(379, 33);
            this.nameDBTextbox.TabIndex = 12;
            this.nameDBTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loginDBTextbox
            // 
            this.loginDBTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.loginDBTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.loginDBTextbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.loginDBTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginDBTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.loginDBTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginDBTextbox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginDBTextbox.HintText = "Логин базы данных";
            this.loginDBTextbox.isPassword = false;
            this.loginDBTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.loginDBTextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.loginDBTextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.loginDBTextbox.LineThickness = 3;
            this.loginDBTextbox.Location = new System.Drawing.Point(18, 114);
            this.loginDBTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.loginDBTextbox.MaxLength = 32767;
            this.loginDBTextbox.Name = "loginDBTextbox";
            this.loginDBTextbox.Size = new System.Drawing.Size(379, 33);
            this.loginDBTextbox.TabIndex = 13;
            this.loginDBTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordDBTextbox
            // 
            this.passwordDBTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.passwordDBTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.passwordDBTextbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordDBTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordDBTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.passwordDBTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordDBTextbox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordDBTextbox.HintText = "Пароль базы данных";
            this.passwordDBTextbox.isPassword = false;
            this.passwordDBTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.passwordDBTextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.passwordDBTextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.passwordDBTextbox.LineThickness = 3;
            this.passwordDBTextbox.Location = new System.Drawing.Point(18, 155);
            this.passwordDBTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordDBTextbox.MaxLength = 32767;
            this.passwordDBTextbox.Name = "passwordDBTextbox";
            this.passwordDBTextbox.Size = new System.Drawing.Size(379, 33);
            this.passwordDBTextbox.TabIndex = 14;
            this.passwordDBTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dbCards
            // 
            this.dbCards.BackColor = System.Drawing.Color.White;
            this.dbCards.BorderRadius = 5;
            this.dbCards.BottomSahddow = true;
            this.dbCards.color = System.Drawing.Color.Tomato;
            this.dbCards.Controls.Add(this.createDBButton);
            this.dbCards.Controls.Add(this.dbLabel);
            this.dbCards.Controls.Add(this.saveDBSettingsButton);
            this.dbCards.Controls.Add(this.passwordDBTextbox);
            this.dbCards.Controls.Add(this.loginDBTextbox);
            this.dbCards.Controls.Add(this.nameDBTextbox);
            this.dbCards.Controls.Add(this.adressDBTextbox);
            this.dbCards.LeftSahddow = false;
            this.dbCards.Location = new System.Drawing.Point(18, 63);
            this.dbCards.Name = "dbCards";
            this.dbCards.RightSahddow = true;
            this.dbCards.ShadowDepth = 20;
            this.dbCards.Size = new System.Drawing.Size(419, 257);
            this.dbCards.TabIndex = 15;
            // 
            // createDBButton
            // 
            this.createDBButton.AutoSize = true;
            this.createDBButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createDBButton.Depth = 0;
            this.createDBButton.Location = new System.Drawing.Point(18, 206);
            this.createDBButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.createDBButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.createDBButton.Name = "createDBButton";
            this.createDBButton.Primary = false;
            this.createDBButton.Size = new System.Drawing.Size(107, 36);
            this.createDBButton.TabIndex = 19;
            this.createDBButton.Text = "Создать БД";
            this.createDBButton.UseVisualStyleBackColor = true;
            this.createDBButton.Click += new System.EventHandler(this.CreateDbButtonClick);
            // 
            // dbLabel
            // 
            this.dbLabel.AutoSize = true;
            this.dbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dbLabel.ForeColor = System.Drawing.Color.Gray;
            this.dbLabel.Location = new System.Drawing.Point(14, 9);
            this.dbLabel.Name = "dbLabel";
            this.dbLabel.Size = new System.Drawing.Size(106, 20);
            this.dbLabel.TabIndex = 18;
            this.dbLabel.Text = "База данных";
            // 
            // saveDBSettingsButton
            // 
            this.saveDBSettingsButton.AutoSize = true;
            this.saveDBSettingsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveDBSettingsButton.Depth = 0;
            this.saveDBSettingsButton.Location = new System.Drawing.Point(295, 206);
            this.saveDBSettingsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveDBSettingsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveDBSettingsButton.Name = "saveDBSettingsButton";
            this.saveDBSettingsButton.Primary = false;
            this.saveDBSettingsButton.Size = new System.Drawing.Size(102, 36);
            this.saveDBSettingsButton.TabIndex = 15;
            this.saveDBSettingsButton.Text = "Сохранить";
            this.saveDBSettingsButton.UseVisualStyleBackColor = true;
            this.saveDBSettingsButton.Click += new System.EventHandler(this.SaveDbButtonClick);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 334);
            this.Controls.Add(this.windowLabel);
            this.Controls.Add(this.minimazeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.dbCards);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SettingsFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.minimazeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.dbCards.ResumeLayout(false);
            this.dbCards.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label windowLabel;
        private Bunifu.Framework.UI.BunifuImageButton minimazeButton;
        private Bunifu.Framework.UI.BunifuImageButton closeButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox adressDBTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nameDBTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox loginDBTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passwordDBTextbox;
        private Bunifu.Framework.UI.BunifuCards dbCards;
        private MaterialSkin.Controls.MaterialFlatButton saveDBSettingsButton;
        private System.Windows.Forms.Label dbLabel;
        private MaterialSkin.Controls.MaterialFlatButton createDBButton;
    }
}