namespace _4_3_1_itec_111_activity_3
{
    partial class CaesarParameters
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
            this.keySlider = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.keyInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.keySlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyInput)).BeginInit();
            this.SuspendLayout();
            // 
            // keySlider
            // 
            this.keySlider.LargeChange = 2;
            this.keySlider.Location = new System.Drawing.Point(12, 27);
            this.keySlider.Maximum = 25;
            this.keySlider.Name = "keySlider";
            this.keySlider.Size = new System.Drawing.Size(210, 45);
            this.keySlider.TabIndex = 0;
            this.keySlider.ValueChanged += new System.EventHandler(this.ChangeKey);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Key (Shift Amount)";
            // 
            // keyInput
            // 
            this.keyInput.Location = new System.Drawing.Point(228, 27);
            this.keyInput.Name = "keyInput";
            this.keyInput.Size = new System.Drawing.Size(44, 23);
            this.keyInput.TabIndex = 2;
            this.keyInput.ValueChanged += new System.EventHandler(this.ChangeKey);
            // 
            // CaesarParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 81);
            this.Controls.Add(this.keyInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keySlider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CaesarParameters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parameters";
            ((System.ComponentModel.ISupportInitialize)(this.keySlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TrackBar keySlider;
        private Label label1;
        private NumericUpDown keyInput;
    }
}