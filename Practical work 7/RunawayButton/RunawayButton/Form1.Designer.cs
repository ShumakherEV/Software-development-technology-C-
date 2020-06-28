namespace RunawayButton
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
            this.myBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myBtn
            // 
            this.myBtn.Location = new System.Drawing.Point(279, 200);
            this.myBtn.Name = "myBtn";
            this.myBtn.Size = new System.Drawing.Size(50, 50);
            this.myBtn.TabIndex = 0;
            this.myBtn.Text = "push me";
            this.myBtn.UseVisualStyleBackColor = true;
            this.myBtn.Click += new System.EventHandler(this.myBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 386);
            this.Controls.Add(this.myBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button myBtn;
    }
}

