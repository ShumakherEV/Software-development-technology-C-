namespace XMLGUI.Forms
{
    partial class FilterProperties
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
            this.btnApply = new System.Windows.Forms.Button();
            this.procTypeChb = new System.Windows.Forms.CheckBox();
            this.RAMSizeChb = new System.Windows.Forms.CheckBox();
            this.videoMemChb = new System.Windows.Forms.CheckBox();
            this.hardMemChb = new System.Windows.Forms.CheckBox();
            this.procTypeCmb = new System.Windows.Forms.ComboBox();
            this.RAMSizeCmb = new System.Windows.Forms.ComboBox();
            this.videoMemCmb = new System.Windows.Forms.ComboBox();
            this.hardMemCmb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(131, 107);
            this.btnApply.Margin = new System.Windows.Forms.Padding(2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(73, 20);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.OnBtnApplyClick);
            // 
            // procTypeChb
            // 
            this.procTypeChb.AutoSize = true;
            this.procTypeChb.Location = new System.Drawing.Point(12, 16);
            this.procTypeChb.Name = "procTypeChb";
            this.procTypeChb.Size = new System.Drawing.Size(108, 17);
            this.procTypeChb.TabIndex = 2;
            this.procTypeChb.Text = "Тип процессора";
            this.procTypeChb.UseVisualStyleBackColor = true;
            this.procTypeChb.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // RAMSizeChb
            // 
            this.RAMSizeChb.AutoSize = true;
            this.RAMSizeChb.Location = new System.Drawing.Point(12, 39);
            this.RAMSizeChb.Name = "RAMSizeChb";
            this.RAMSizeChb.Size = new System.Drawing.Size(87, 17);
            this.RAMSizeChb.TabIndex = 3;
            this.RAMSizeChb.Text = "Объём ОЗУ";
            this.RAMSizeChb.UseVisualStyleBackColor = true;
            // 
            // videoMemChb
            // 
            this.videoMemChb.AutoSize = true;
            this.videoMemChb.Location = new System.Drawing.Point(12, 62);
            this.videoMemChb.Name = "videoMemChb";
            this.videoMemChb.Size = new System.Drawing.Size(129, 17);
            this.videoMemChb.TabIndex = 4;
            this.videoMemChb.Text = "Память видеокарты";
            this.videoMemChb.UseVisualStyleBackColor = true;
            // 
            // hardMemChb
            // 
            this.hardMemChb.AutoSize = true;
            this.hardMemChb.Location = new System.Drawing.Point(12, 85);
            this.hardMemChb.Name = "hardMemChb";
            this.hardMemChb.Size = new System.Drawing.Size(149, 17);
            this.hardMemChb.TabIndex = 5;
            this.hardMemChb.Text = "Память жёсткого диска";
            this.hardMemChb.UseVisualStyleBackColor = true;
            // 
            // procTypeCmb
            // 
            this.procTypeCmb.FormattingEnabled = true;
            this.procTypeCmb.Items.AddRange(new object[] {
            "Intel Core i3",
            "Intel Core i5",
            "Intel Core i7"});
            this.procTypeCmb.Location = new System.Drawing.Point(172, 12);
            this.procTypeCmb.Name = "procTypeCmb";
            this.procTypeCmb.Size = new System.Drawing.Size(166, 21);
            this.procTypeCmb.TabIndex = 6;
            // 
            // RAMSizeCmb
            // 
            this.RAMSizeCmb.FormattingEnabled = true;
            this.RAMSizeCmb.Items.AddRange(new object[] {
            "4",
            "8",
            "16",
            "32",
            "64"});
            this.RAMSizeCmb.Location = new System.Drawing.Point(172, 35);
            this.RAMSizeCmb.Name = "RAMSizeCmb";
            this.RAMSizeCmb.Size = new System.Drawing.Size(166, 21);
            this.RAMSizeCmb.TabIndex = 7;
            // 
            // videoMemCmb
            // 
            this.videoMemCmb.FormattingEnabled = true;
            this.videoMemCmb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "8"});
            this.videoMemCmb.Location = new System.Drawing.Point(172, 58);
            this.videoMemCmb.Name = "videoMemCmb";
            this.videoMemCmb.Size = new System.Drawing.Size(166, 21);
            this.videoMemCmb.TabIndex = 8;
            // 
            // hardMemCmb
            // 
            this.hardMemCmb.FormattingEnabled = true;
            this.hardMemCmb.Items.AddRange(new object[] {
            "256",
            "512",
            "1024",
            "2048"});
            this.hardMemCmb.Location = new System.Drawing.Point(172, 81);
            this.hardMemCmb.Name = "hardMemCmb";
            this.hardMemCmb.Size = new System.Drawing.Size(166, 21);
            this.hardMemCmb.TabIndex = 9;
            // 
            // FilterProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 136);
            this.Controls.Add(this.hardMemCmb);
            this.Controls.Add(this.videoMemCmb);
            this.Controls.Add(this.RAMSizeCmb);
            this.Controls.Add(this.procTypeCmb);
            this.Controls.Add(this.hardMemChb);
            this.Controls.Add(this.videoMemChb);
            this.Controls.Add(this.RAMSizeChb);
            this.Controls.Add(this.procTypeChb);
            this.Controls.Add(this.btnApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FilterProperties";
            this.Text = "Filter properties";
            this.Load += new System.EventHandler(this.FilterProperties_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.CheckBox procTypeChb;
        private System.Windows.Forms.CheckBox RAMSizeChb;
        private System.Windows.Forms.CheckBox videoMemChb;
        private System.Windows.Forms.CheckBox hardMemChb;
        private System.Windows.Forms.ComboBox procTypeCmb;
        private System.Windows.Forms.ComboBox RAMSizeCmb;
        private System.Windows.Forms.ComboBox videoMemCmb;
        private System.Windows.Forms.ComboBox hardMemCmb;
    }
}