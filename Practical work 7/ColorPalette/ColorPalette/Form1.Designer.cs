namespace ColorPalette
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
            this.components = new System.ComponentModel.Container();
            this.box = new System.Windows.Forms.GroupBox();
            this.redTrack = new System.Windows.Forms.TrackBar();
            this.greenTrack = new System.Windows.Forms.TrackBar();
            this.blueTrack = new System.Windows.Forms.TrackBar();
            this.redLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.colorTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.redTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // box
            // 
            this.box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.box.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box.Location = new System.Drawing.Point(12, 12);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(157, 157);
            this.box.TabIndex = 0;
            this.box.TabStop = false;
            this.colorTip.SetToolTip(this.box, "#CDCDCD");
            // 
            // redTrack
            // 
            this.redTrack.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.redTrack.LargeChange = 16;
            this.redTrack.Location = new System.Drawing.Point(236, 12);
            this.redTrack.Maximum = 255;
            this.redTrack.Name = "redTrack";
            this.redTrack.Size = new System.Drawing.Size(167, 45);
            this.redTrack.TabIndex = 1;
            this.redTrack.TickFrequency = 16;
            this.redTrack.Value = 125;
            this.redTrack.ValueChanged += new System.EventHandler(this.redTrack_ValueChanged);
            // 
            // greenTrack
            // 
            this.greenTrack.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.greenTrack.LargeChange = 16;
            this.greenTrack.Location = new System.Drawing.Point(236, 63);
            this.greenTrack.Maximum = 255;
            this.greenTrack.Name = "greenTrack";
            this.greenTrack.Size = new System.Drawing.Size(167, 45);
            this.greenTrack.TabIndex = 2;
            this.greenTrack.TickFrequency = 16;
            this.greenTrack.Value = 125;
            this.greenTrack.ValueChanged += new System.EventHandler(this.greenTrack_ValueChanged);
            // 
            // blueTrack
            // 
            this.blueTrack.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.blueTrack.LargeChange = 16;
            this.blueTrack.Location = new System.Drawing.Point(236, 114);
            this.blueTrack.Maximum = 255;
            this.blueTrack.Name = "blueTrack";
            this.blueTrack.Size = new System.Drawing.Size(167, 45);
            this.blueTrack.TabIndex = 3;
            this.blueTrack.TickFrequency = 16;
            this.blueTrack.Value = 125;
            this.blueTrack.ValueChanged += new System.EventHandler(this.blueTrack_ValueChanged);
            // 
            // redLabel
            // 
            this.redLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.redLabel.AutoSize = true;
            this.redLabel.Location = new System.Drawing.Point(195, 12);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(30, 13);
            this.redLabel.TabIndex = 4;
            this.redLabel.Text = "Red:";
            // 
            // greenLabel
            // 
            this.greenLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.greenLabel.AutoSize = true;
            this.greenLabel.Location = new System.Drawing.Point(195, 63);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(39, 13);
            this.greenLabel.TabIndex = 5;
            this.greenLabel.Text = "Green:";
            // 
            // blueLabel
            // 
            this.blueLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.blueLabel.AutoSize = true;
            this.blueLabel.Location = new System.Drawing.Point(195, 114);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(31, 13);
            this.blueLabel.TabIndex = 6;
            this.blueLabel.Text = "Blue:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "255";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "255";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "255";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 183);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.blueTrack);
            this.Controls.Add(this.greenTrack);
            this.Controls.Add(this.redTrack);
            this.Controls.Add(this.box);
            this.Name = "Form1";
            this.Text = "Color Palette";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.redTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox box;
        private System.Windows.Forms.TrackBar redTrack;
        private System.Windows.Forms.TrackBar greenTrack;
        private System.Windows.Forms.TrackBar blueTrack;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip colorTip;
    }
}

