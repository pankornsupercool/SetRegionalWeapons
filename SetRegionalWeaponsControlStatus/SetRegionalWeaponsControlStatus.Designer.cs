
namespace SetRegionalWeaponsControlStatus
{
    partial class SetRegionalWeaponsControlStatus
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.unspecifiedRadio = new System.Windows.Forms.RadioButton();
            this.holdRadio = new System.Windows.Forms.RadioButton();
            this.tightRadio = new System.Windows.Forms.RadioButton();
            this.freeRadio = new System.Windows.Forms.RadioButton();
            this.siteIDCombobox = new System.Windows.Forms.ComboBox();
            this.batteryIdCombobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Site ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Battery ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(73, 320);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(168, 54);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(265, 320);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(155, 54);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // unspecifiedRadio
            // 
            this.unspecifiedRadio.AutoSize = true;
            this.unspecifiedRadio.Enabled = false;
            this.unspecifiedRadio.Location = new System.Drawing.Point(182, 134);
            this.unspecifiedRadio.Name = "unspecifiedRadio";
            this.unspecifiedRadio.Size = new System.Drawing.Size(114, 22);
            this.unspecifiedRadio.TabIndex = 5;
            this.unspecifiedRadio.TabStop = true;
            this.unspecifiedRadio.Text = "Unspecified";
            this.unspecifiedRadio.UseVisualStyleBackColor = true;
            // 
            // holdRadio
            // 
            this.holdRadio.AutoSize = true;
            this.holdRadio.Location = new System.Drawing.Point(182, 178);
            this.holdRadio.Name = "holdRadio";
            this.holdRadio.Size = new System.Drawing.Size(58, 22);
            this.holdRadio.TabIndex = 6;
            this.holdRadio.TabStop = true;
            this.holdRadio.Text = "Hold";
            this.holdRadio.UseVisualStyleBackColor = true;
            // 
            // tightRadio
            // 
            this.tightRadio.AutoSize = true;
            this.tightRadio.Location = new System.Drawing.Point(182, 223);
            this.tightRadio.Name = "tightRadio";
            this.tightRadio.Size = new System.Drawing.Size(66, 22);
            this.tightRadio.TabIndex = 7;
            this.tightRadio.TabStop = true;
            this.tightRadio.Text = "Tight";
            this.tightRadio.UseVisualStyleBackColor = true;
            // 
            // freeRadio
            // 
            this.freeRadio.AutoSize = true;
            this.freeRadio.Location = new System.Drawing.Point(182, 266);
            this.freeRadio.Name = "freeRadio";
            this.freeRadio.Size = new System.Drawing.Size(58, 22);
            this.freeRadio.TabIndex = 8;
            this.freeRadio.TabStop = true;
            this.freeRadio.Text = "Free";
            this.freeRadio.UseVisualStyleBackColor = true;
            // 
            // siteIDCombobox
            // 
            this.siteIDCombobox.FormattingEnabled = true;
            this.siteIDCombobox.Location = new System.Drawing.Point(132, 18);
            this.siteIDCombobox.Name = "siteIDCombobox";
            this.siteIDCombobox.Size = new System.Drawing.Size(219, 26);
            this.siteIDCombobox.TabIndex = 9;
            // 
            // batteryIdCombobox
            // 
            this.batteryIdCombobox.FormattingEnabled = true;
            this.batteryIdCombobox.Location = new System.Drawing.Point(132, 80);
            this.batteryIdCombobox.Name = "batteryIdCombobox";
            this.batteryIdCombobox.Size = new System.Drawing.Size(219, 26);
            this.batteryIdCombobox.TabIndex = 10;
            // 
            // SetRegionalWeaponsControlStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 402);
            this.Controls.Add(this.batteryIdCombobox);
            this.Controls.Add(this.siteIDCombobox);
            this.Controls.Add(this.freeRadio);
            this.Controls.Add(this.tightRadio);
            this.Controls.Add(this.holdRadio);
            this.Controls.Add(this.unspecifiedRadio);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SetRegionalWeaponsControlStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Regional Weapon Control Status";
            this.Load += new System.EventHandler(this.SetRegionalWeaponsControlStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.RadioButton unspecifiedRadio;
        private System.Windows.Forms.RadioButton holdRadio;
        private System.Windows.Forms.RadioButton tightRadio;
        private System.Windows.Forms.RadioButton freeRadio;
        private System.Windows.Forms.ComboBox siteIDCombobox;
        private System.Windows.Forms.ComboBox batteryIdCombobox;
    }
}

