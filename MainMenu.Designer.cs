namespace Password_Generator
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.IncSpecChar = new System.Windows.Forms.CheckBox();
            this.Intro = new System.Windows.Forms.TextBox();
            this.CreatePass = new System.Windows.Forms.Button();
            this.MinLengthText = new System.Windows.Forms.TextBox();
            this.MinLen = new System.Windows.Forms.TextBox();
            this.MaxLegnthText = new System.Windows.Forms.TextBox();
            this.MaxLen = new System.Windows.Forms.TextBox();
            this.OnlyLowerText = new System.Windows.Forms.CheckBox();
            this.OnlyUpperText = new System.Windows.Forms.CheckBox();
            this.BothText = new System.Windows.Forms.CheckBox();
            this.passShowBox = new System.Windows.Forms.TextBox();
            this.SaveText = new System.Windows.Forms.Button();
            this.PassSaveNameText = new System.Windows.Forms.TextBox();
            this.PassSaveName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IncSpecChar
            // 
            this.IncSpecChar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IncSpecChar.AutoSize = true;
            this.IncSpecChar.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncSpecChar.Location = new System.Drawing.Point(12, 87);
            this.IncSpecChar.Name = "IncSpecChar";
            this.IncSpecChar.Size = new System.Drawing.Size(159, 21);
            this.IncSpecChar.TabIndex = 1;
            this.IncSpecChar.Text = "Include Special Chars";
            this.IncSpecChar.UseVisualStyleBackColor = true;
            this.IncSpecChar.CheckedChanged += new System.EventHandler(this.IncSpecChar_CheckedChanged);
            // 
            // Intro
            // 
            this.Intro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Intro.BackColor = System.Drawing.Color.White;
            this.Intro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Intro.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intro.Location = new System.Drawing.Point(12, 12);
            this.Intro.Name = "Intro";
            this.Intro.ReadOnly = true;
            this.Intro.Size = new System.Drawing.Size(242, 20);
            this.Intro.TabIndex = 2;
            this.Intro.Text = "OSWIN PASSWORD GENERATOR";
            // 
            // CreatePass
            // 
            this.CreatePass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreatePass.Location = new System.Drawing.Point(12, 189);
            this.CreatePass.Name = "CreatePass";
            this.CreatePass.Size = new System.Drawing.Size(242, 46);
            this.CreatePass.TabIndex = 3;
            this.CreatePass.Text = "Create Pasword";
            this.CreatePass.UseVisualStyleBackColor = true;
            this.CreatePass.Click += new System.EventHandler(this.CreatePass_Click);
            // 
            // MinLengthText
            // 
            this.MinLengthText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MinLengthText.BackColor = System.Drawing.Color.White;
            this.MinLengthText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MinLengthText.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinLengthText.Location = new System.Drawing.Point(12, 139);
            this.MinLengthText.Name = "MinLengthText";
            this.MinLengthText.ReadOnly = true;
            this.MinLengthText.Size = new System.Drawing.Size(69, 16);
            this.MinLengthText.TabIndex = 4;
            this.MinLengthText.Text = "Min Length";
            this.MinLengthText.TextChanged += new System.EventHandler(this.MinLengthText_TextChanged);
            // 
            // MinLen
            // 
            this.MinLen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MinLen.Location = new System.Drawing.Point(87, 137);
            this.MinLen.Name = "MinLen";
            this.MinLen.Size = new System.Drawing.Size(54, 20);
            this.MinLen.TabIndex = 5;
            this.MinLen.TextChanged += new System.EventHandler(this.MinLen_TextChanged);
            // 
            // MaxLegnthText
            // 
            this.MaxLegnthText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MaxLegnthText.BackColor = System.Drawing.Color.White;
            this.MaxLegnthText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaxLegnthText.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxLegnthText.Location = new System.Drawing.Point(12, 167);
            this.MaxLegnthText.Name = "MaxLegnthText";
            this.MaxLegnthText.ReadOnly = true;
            this.MaxLegnthText.Size = new System.Drawing.Size(69, 16);
            this.MaxLegnthText.TabIndex = 6;
            this.MaxLegnthText.Text = "Max Length";
            // 
            // MaxLen
            // 
            this.MaxLen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MaxLen.Location = new System.Drawing.Point(87, 163);
            this.MaxLen.Name = "MaxLen";
            this.MaxLen.Size = new System.Drawing.Size(54, 20);
            this.MaxLen.TabIndex = 7;
            this.MaxLen.TextChanged += new System.EventHandler(this.MaxLen_TextChanged);
            // 
            // OnlyLowerText
            // 
            this.OnlyLowerText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OnlyLowerText.AutoSize = true;
            this.OnlyLowerText.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnlyLowerText.Location = new System.Drawing.Point(12, 114);
            this.OnlyLowerText.Name = "OnlyLowerText";
            this.OnlyLowerText.Size = new System.Drawing.Size(89, 19);
            this.OnlyLowerText.TabIndex = 8;
            this.OnlyLowerText.Text = "Only Lower";
            this.OnlyLowerText.UseVisualStyleBackColor = true;
            this.OnlyLowerText.CheckedChanged += new System.EventHandler(this.OnlyLowerText_CheckedChanged);
            // 
            // OnlyUpperText
            // 
            this.OnlyUpperText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OnlyUpperText.AutoSize = true;
            this.OnlyUpperText.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnlyUpperText.Location = new System.Drawing.Point(107, 114);
            this.OnlyUpperText.Name = "OnlyUpperText";
            this.OnlyUpperText.Size = new System.Drawing.Size(87, 19);
            this.OnlyUpperText.TabIndex = 9;
            this.OnlyUpperText.Text = "Only Upper";
            this.OnlyUpperText.UseVisualStyleBackColor = true;
            this.OnlyUpperText.CheckedChanged += new System.EventHandler(this.OnlyUpperText_CheckedChanged);
            // 
            // BothText
            // 
            this.BothText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BothText.AutoSize = true;
            this.BothText.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BothText.Location = new System.Drawing.Point(200, 114);
            this.BothText.Name = "BothText";
            this.BothText.Size = new System.Drawing.Size(52, 19);
            this.BothText.TabIndex = 10;
            this.BothText.Text = "Both";
            this.BothText.UseVisualStyleBackColor = true;
            this.BothText.CheckedChanged += new System.EventHandler(this.BothText_CheckedChanged);
            // 
            // passShowBox
            // 
            this.passShowBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passShowBox.Location = new System.Drawing.Point(12, 241);
            this.passShowBox.Name = "passShowBox";
            this.passShowBox.ReadOnly = true;
            this.passShowBox.Size = new System.Drawing.Size(242, 20);
            this.passShowBox.TabIndex = 12;
            this.passShowBox.TextChanged += new System.EventHandler(this.passShowBox_TextChanged);
            // 
            // SaveText
            // 
            this.SaveText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveText.Location = new System.Drawing.Point(12, 267);
            this.SaveText.Name = "SaveText";
            this.SaveText.Size = new System.Drawing.Size(242, 29);
            this.SaveText.TabIndex = 13;
            this.SaveText.Text = "Save";
            this.SaveText.UseVisualStyleBackColor = true;
            this.SaveText.Click += new System.EventHandler(this.SaveText_Click);
            // 
            // PassSaveNameText
            // 
            this.PassSaveNameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PassSaveNameText.BackColor = System.Drawing.Color.White;
            this.PassSaveNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassSaveNameText.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassSaveNameText.Location = new System.Drawing.Point(12, 38);
            this.PassSaveNameText.Name = "PassSaveNameText";
            this.PassSaveNameText.ReadOnly = true;
            this.PassSaveNameText.Size = new System.Drawing.Size(208, 17);
            this.PassSaveNameText.TabIndex = 14;
            this.PassSaveNameText.Text = "Your passwords name";
            this.PassSaveNameText.TextChanged += new System.EventHandler(this.PassSaveNameText_TextChanged);
            // 
            // PassSaveName
            // 
            this.PassSaveName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PassSaveName.Location = new System.Drawing.Point(12, 61);
            this.PassSaveName.Name = "PassSaveName";
            this.PassSaveName.Size = new System.Drawing.Size(242, 20);
            this.PassSaveName.TabIndex = 15;
            this.PassSaveName.TextChanged += new System.EventHandler(this.PassSaveName_TextChanged);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(268, 312);
            this.Controls.Add(this.PassSaveName);
            this.Controls.Add(this.PassSaveNameText);
            this.Controls.Add(this.SaveText);
            this.Controls.Add(this.passShowBox);
            this.Controls.Add(this.BothText);
            this.Controls.Add(this.OnlyUpperText);
            this.Controls.Add(this.OnlyLowerText);
            this.Controls.Add(this.MaxLen);
            this.Controls.Add(this.MaxLegnthText);
            this.Controls.Add(this.MinLen);
            this.Controls.Add(this.MinLengthText);
            this.Controls.Add(this.CreatePass);
            this.Controls.Add(this.Intro);
            this.Controls.Add(this.IncSpecChar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox IncSpecChar;
        private System.Windows.Forms.TextBox Intro;
        private System.Windows.Forms.Button CreatePass;
        private System.Windows.Forms.TextBox MinLengthText;
        private System.Windows.Forms.TextBox MinLen;
        private System.Windows.Forms.TextBox MaxLegnthText;
        private System.Windows.Forms.TextBox MaxLen;
        private System.Windows.Forms.CheckBox OnlyLowerText;
        private System.Windows.Forms.CheckBox OnlyUpperText;
        private System.Windows.Forms.CheckBox BothText;
        private System.Windows.Forms.TextBox passShowBox;
        private System.Windows.Forms.Button SaveText;
        private System.Windows.Forms.TextBox PassSaveNameText;
        private System.Windows.Forms.TextBox PassSaveName;
    }
}

