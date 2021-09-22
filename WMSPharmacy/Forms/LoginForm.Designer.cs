namespace WMSPharmacy.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.passwordTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.nameWindowLabel = new System.Windows.Forms.Label();
            this.minimazeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.closeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.viewPasswordButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.saveMeCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.authButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.authPanel = new System.Windows.Forms.Panel();
            this.showSettingsButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.adminPasswordTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.toSettingsButton = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.minimazeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPasswordButton)).BeginInit();
            this.authPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginTextbox
            // 
            this.loginTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.loginTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.loginTextbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.loginTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.loginTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginTextbox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginTextbox.HintText = "Логин";
            this.loginTextbox.isPassword = false;
            this.loginTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.loginTextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.loginTextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.loginTextbox.LineThickness = 3;
            this.loginTextbox.Location = new System.Drawing.Point(214, 95);
            this.loginTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.loginTextbox.MaxLength = 32767;
            this.loginTextbox.Name = "loginTextbox";
            this.loginTextbox.Size = new System.Drawing.Size(379, 33);
            this.loginTextbox.TabIndex = 3;
            this.loginTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.passwordTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.passwordTextbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.passwordTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordTextbox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordTextbox.HintText = "Пароль";
            this.passwordTextbox.isPassword = true;
            this.passwordTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.passwordTextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.passwordTextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.passwordTextbox.LineThickness = 3;
            this.passwordTextbox.Location = new System.Drawing.Point(214, 164);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextbox.MaxLength = 32767;
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(379, 33);
            this.passwordTextbox.TabIndex = 3;
            this.passwordTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextbox.OnValueChanged += new System.EventHandler(this.PasswordTextBoxOnValueChanged);
            // 
            // nameWindowLabel
            // 
            this.nameWindowLabel.AutoSize = true;
            this.nameWindowLabel.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameWindowLabel.ForeColor = System.Drawing.Color.Gray;
            this.nameWindowLabel.Location = new System.Drawing.Point(13, 12);
            this.nameWindowLabel.Name = "nameWindowLabel";
            this.nameWindowLabel.Size = new System.Drawing.Size(186, 33);
            this.nameWindowLabel.TabIndex = 1;
            this.nameWindowLabel.Text = "Авторизация";
            // 
            // minimazeButton
            // 
            this.minimazeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimazeButton.Image = global::WMSPharmacy.Properties.Resources.HideWindow;
            this.minimazeButton.ImageActive = null;
            this.minimazeButton.Location = new System.Drawing.Point(709, 12);
            this.minimazeButton.Name = "minimazeButton";
            this.minimazeButton.Size = new System.Drawing.Size(32, 33);
            this.minimazeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimazeButton.TabIndex = 7;
            this.minimazeButton.TabStop = false;
            this.minimazeButton.Zoom = 10;
            this.minimazeButton.Click += new System.EventHandler(this.MinimizeClick);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = global::WMSPharmacy.Properties.Resources.CloseWindow;
            this.closeButton.ImageActive = null;
            this.closeButton.Location = new System.Drawing.Point(756, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 33);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 6;
            this.closeButton.TabStop = false;
            this.closeButton.Zoom = 10;
            this.closeButton.Click += new System.EventHandler(this.CloseClick);
            // 
            // viewPasswordButton
            // 
            this.viewPasswordButton.BackColor = System.Drawing.Color.Transparent;
            this.viewPasswordButton.Image = global::WMSPharmacy.Properties.Resources.ShowPassword;
            this.viewPasswordButton.ImageActive = null;
            this.viewPasswordButton.Location = new System.Drawing.Point(566, 164);
            this.viewPasswordButton.Name = "viewPasswordButton";
            this.viewPasswordButton.Size = new System.Drawing.Size(27, 28);
            this.viewPasswordButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.viewPasswordButton.TabIndex = 9;
            this.viewPasswordButton.TabStop = false;
            this.viewPasswordButton.Zoom = 10;
            this.viewPasswordButton.Click += new System.EventHandler(this.ViewPasswordButtonClick);
            // 
            // saveMeCheckBox
            // 
            this.saveMeCheckBox.AutoSize = true;
            this.saveMeCheckBox.Checked = true;
            this.saveMeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveMeCheckBox.Depth = 0;
            this.saveMeCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.saveMeCheckBox.Location = new System.Drawing.Point(214, 211);
            this.saveMeCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.saveMeCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.saveMeCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveMeCheckBox.Name = "saveMeCheckBox";
            this.saveMeCheckBox.Ripple = true;
            this.saveMeCheckBox.Size = new System.Drawing.Size(196, 30);
            this.saveMeCheckBox.TabIndex = 13;
            this.saveMeCheckBox.Text = "Запомнить пользователя";
            this.saveMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // authButton
            // 
            this.authButton.AutoSize = true;
            this.authButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.authButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.authButton.Depth = 0;
            this.authButton.Location = new System.Drawing.Point(0, 0);
            this.authButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.authButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.authButton.Name = "authButton";
            this.authButton.Primary = false;
            this.authButton.Size = new System.Drawing.Size(121, 36);
            this.authButton.TabIndex = 17;
            this.authButton.Text = "Авторизация";
            this.authButton.UseVisualStyleBackColor = false;
            this.authButton.Click += new System.EventHandler(this.LoginClick);
            // 
            // authPanel
            // 
            this.authPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.authPanel.Controls.Add(this.authButton);
            this.authPanel.Location = new System.Drawing.Point(472, 207);
            this.authPanel.Name = "authPanel";
            this.authPanel.Size = new System.Drawing.Size(121, 36);
            this.authPanel.TabIndex = 18;
            // 
            // showSettingsButton
            // 
            this.showSettingsButton.AutoSize = true;
            this.showSettingsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.showSettingsButton.Depth = 0;
            this.showSettingsButton.Location = new System.Drawing.Point(19, 399);
            this.showSettingsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.showSettingsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.showSettingsButton.Name = "showSettingsButton";
            this.showSettingsButton.Primary = false;
            this.showSettingsButton.Size = new System.Drawing.Size(104, 36);
            this.showSettingsButton.TabIndex = 19;
            this.showSettingsButton.Text = "Настройки";
            this.showSettingsButton.UseVisualStyleBackColor = true;
            this.showSettingsButton.Click += new System.EventHandler(this.SettingsButtonClick);
            // 
            // adminPassTextbox
            // 
            this.adminPasswordTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.adminPasswordTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.adminPasswordTextbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.adminPasswordTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adminPasswordTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.adminPasswordTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adminPasswordTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.adminPasswordTextbox.HintText = "Пароль";
            this.adminPasswordTextbox.isPassword = false;
            this.adminPasswordTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.adminPasswordTextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.adminPasswordTextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.adminPasswordTextbox.LineThickness = 3;
            this.adminPasswordTextbox.Location = new System.Drawing.Point(131, 399);
            this.adminPasswordTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.adminPasswordTextbox.MaxLength = 32767;
            this.adminPasswordTextbox.Name = "adminPassTextbox";
            this.adminPasswordTextbox.Size = new System.Drawing.Size(120, 33);
            this.adminPasswordTextbox.TabIndex = 21;
            this.adminPasswordTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.adminPasswordTextbox.Visible = false;
            // 
            // toSettingsButton
            // 
            this.toSettingsButton.AutoSize = true;
            this.toSettingsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.toSettingsButton.Depth = 0;
            this.toSettingsButton.Location = new System.Drawing.Point(259, 399);
            this.toSettingsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.toSettingsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.toSettingsButton.Name = "toSettingsButton";
            this.toSettingsButton.Primary = false;
            this.toSettingsButton.Size = new System.Drawing.Size(58, 36);
            this.toSettingsButton.TabIndex = 22;
            this.toSettingsButton.Text = "Вход";
            this.toSettingsButton.UseVisualStyleBackColor = true;
            this.toSettingsButton.Visible = false;
            this.toSettingsButton.Click += new System.EventHandler(this.ToSettingsButtonClick);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toSettingsButton);
            this.Controls.Add(this.adminPasswordTextbox);
            this.Controls.Add(this.showSettingsButton);
            this.Controls.Add(this.saveMeCheckBox);
            this.Controls.Add(this.viewPasswordButton);
            this.Controls.Add(this.nameWindowLabel);
            this.Controls.Add(this.minimazeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.loginTextbox);
            this.Controls.Add(this.authPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginFormFormClosed);
            this.Load += new System.EventHandler(this.LoginFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.minimazeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPasswordButton)).EndInit();
            this.authPanel.ResumeLayout(false);
            this.authPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox loginTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passwordTextbox;
        private Bunifu.Framework.UI.BunifuImageButton closeButton;
        private Bunifu.Framework.UI.BunifuImageButton minimazeButton;
        private System.Windows.Forms.Label nameWindowLabel;
        private Bunifu.Framework.UI.BunifuImageButton viewPasswordButton;
        private MaterialSkin.Controls.MaterialCheckBox saveMeCheckBox;
        private MaterialSkin.Controls.MaterialFlatButton authButton;
        private System.Windows.Forms.Panel authPanel;
        private MaterialSkin.Controls.MaterialFlatButton showSettingsButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox adminPasswordTextbox;
        private MaterialSkin.Controls.MaterialFlatButton toSettingsButton;
    }
}

