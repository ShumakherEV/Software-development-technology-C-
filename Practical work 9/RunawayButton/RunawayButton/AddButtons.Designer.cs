namespace RunawayButton
{
    partial class AddButtons
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
            this.numberButtonsBtn = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.addButtonsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberButtonsBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // numberButtonsBtn
            // 
            this.numberButtonsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberButtonsBtn.Location = new System.Drawing.Point(12, 62);
            this.numberButtonsBtn.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numberButtonsBtn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberButtonsBtn.Name = "numberButtonsBtn";
            this.numberButtonsBtn.Size = new System.Drawing.Size(120, 23);
            this.numberButtonsBtn.TabIndex = 0;
            this.numberButtonsBtn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество кнопок на экране:";
            // 
            // addButtonsBtn
            // 
            this.addButtonsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButtonsBtn.Location = new System.Drawing.Point(12, 101);
            this.addButtonsBtn.Name = "addButtonsBtn";
            this.addButtonsBtn.Size = new System.Drawing.Size(75, 23);
            this.addButtonsBtn.TabIndex = 2;
            this.addButtonsBtn.Text = "Ок";
            this.addButtonsBtn.UseVisualStyleBackColor = true;
            this.addButtonsBtn.Click += new System.EventHandler(this.addButtonsBtn_Click);
            // 
            // AddButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 166);
            this.Controls.Add(this.addButtonsBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberButtonsBtn);
            this.Name = "AddButtons";
            this.Text = "AddButtons";
            ((System.ComponentModel.ISupportInitialize)(this.numberButtonsBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numberButtonsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButtonsBtn;
    }
}