namespace _4_3_1_itec_111_activity_3
{
    partial class SimpleCipher
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cipher = new System.Windows.Forms.ComboBox();
            this.parameters = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.transfer = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.encrypt = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.Button();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.copy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cipher
            // 
            this.cipher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cipher.FormattingEnabled = true;
            this.cipher.Location = new System.Drawing.Point(12, 12);
            this.cipher.Name = "cipher";
            this.cipher.Size = new System.Drawing.Size(679, 23);
            this.cipher.TabIndex = 0;
            // 
            // parameters
            // 
            this.parameters.Location = new System.Drawing.Point(697, 12);
            this.parameters.Name = "parameters";
            this.parameters.Size = new System.Drawing.Size(75, 23);
            this.parameters.TabIndex = 1;
            this.parameters.Text = "Parameters";
            this.parameters.UseVisualStyleBackColor = true;
            this.parameters.Click += new System.EventHandler(this.LaunchParameters);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(76, 56);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.input.Size = new System.Drawing.Size(345, 295);
            this.input.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(427, 56);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output.Size = new System.Drawing.Size(345, 295);
            this.output.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output";
            // 
            // transfer
            // 
            this.transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transfer.Location = new System.Drawing.Point(8, 68);
            this.transfer.Name = "transfer";
            this.transfer.Size = new System.Drawing.Size(44, 40);
            this.transfer.TabIndex = 7;
            this.transfer.Text = "↶";
            this.tooltip.SetToolTip(this.transfer, "Transfer the Output\'s contents to the Input.");
            this.transfer.UseVisualStyleBackColor = true;
            this.transfer.Click += new System.EventHandler(this.Transfer);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clear.Location = new System.Drawing.Point(8, 22);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(44, 40);
            this.clear.TabIndex = 8;
            this.clear.Text = "x";
            this.tooltip.SetToolTip(this.clear, "Clear the Input and Output.");
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear);
            // 
            // encrypt
            // 
            this.encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.encrypt.Location = new System.Drawing.Point(8, 114);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(44, 40);
            this.encrypt.TabIndex = 9;
            this.encrypt.Text = "🔒";
            this.tooltip.SetToolTip(this.encrypt, "Encrypt the Input.");
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.Encrypt);
            // 
            // decrypt
            // 
            this.decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.decrypt.Location = new System.Drawing.Point(8, 160);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(44, 40);
            this.decrypt.TabIndex = 10;
            this.decrypt.Text = "🔓";
            this.tooltip.SetToolTip(this.decrypt, "Decrypt the Input.");
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.Decrypt);
            // 
            // copy
            // 
            this.copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copy.Location = new System.Drawing.Point(8, 206);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(44, 40);
            this.copy.TabIndex = 11;
            this.copy.Text = "📋";
            this.tooltip.SetToolTip(this.copy, "Copy the Output.");
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.Copy);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.copy);
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.encrypt);
            this.groupBox1.Controls.Add(this.decrypt);
            this.groupBox1.Controls.Add(this.transfer);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(58, 311);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // SimpleCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input);
            this.Controls.Add(this.parameters);
            this.Controls.Add(this.cipher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SimpleCipher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Cipher";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cipher;
        private Button parameters;
        private TextBox input;
        private Label label1;
        private TextBox output;
        private Label label2;
        private Button transfer;
        private Button clear;
        private Button encrypt;
        private Button decrypt;
        private ToolTip tooltip;
        private GroupBox groupBox1;
        private Button copy;
    }
}