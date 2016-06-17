namespace EscapistsMapTools {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.inputFileButton = new System.Windows.Forms.Button();
            this.inputFileText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.outputFileText = new System.Windows.Forms.TextBox();
            this.outputFileButton = new System.Windows.Forms.Button();
            this.inputFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.outputFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.encryptionKey = new System.Windows.Forms.TextBox();
            this.decompileButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.encryptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputFileButton
            // 
            this.inputFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputFileButton.Location = new System.Drawing.Point(197, 23);
            this.inputFileButton.Name = "inputFileButton";
            this.inputFileButton.Size = new System.Drawing.Size(75, 23);
            this.inputFileButton.TabIndex = 0;
            this.inputFileButton.Text = "Browse";
            this.inputFileButton.UseVisualStyleBackColor = true;
            this.inputFileButton.Click += new System.EventHandler(this.inputFileButton_Click);
            // 
            // inputFileText
            // 
            this.inputFileText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputFileText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.inputFileText.Location = new System.Drawing.Point(12, 25);
            this.inputFileText.Name = "inputFileText";
            this.inputFileText.ReadOnly = true;
            this.inputFileText.Size = new System.Drawing.Size(179, 20);
            this.inputFileText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input File";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Output File";
            // 
            // outputFileText
            // 
            this.outputFileText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputFileText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.outputFileText.Location = new System.Drawing.Point(12, 77);
            this.outputFileText.Name = "outputFileText";
            this.outputFileText.ReadOnly = true;
            this.outputFileText.Size = new System.Drawing.Size(179, 20);
            this.outputFileText.TabIndex = 4;
            // 
            // outputFileButton
            // 
            this.outputFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outputFileButton.Location = new System.Drawing.Point(197, 75);
            this.outputFileButton.Name = "outputFileButton";
            this.outputFileButton.Size = new System.Drawing.Size(75, 23);
            this.outputFileButton.TabIndex = 3;
            this.outputFileButton.Text = "Browse";
            this.outputFileButton.UseVisualStyleBackColor = true;
            this.outputFileButton.Click += new System.EventHandler(this.outputFileButton_Click);
            // 
            // inputFileDialog
            // 
            this.inputFileDialog.Title = "Browse for map file";
            // 
            // outputFileDialog
            // 
            this.outputFileDialog.Title = "Save map file...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Encryption Key (Default => \"mothking\")";
            // 
            // encryptionKey
            // 
            this.encryptionKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.encryptionKey.Location = new System.Drawing.Point(12, 129);
            this.encryptionKey.Name = "encryptionKey";
            this.encryptionKey.Size = new System.Drawing.Size(257, 20);
            this.encryptionKey.TabIndex = 7;
            this.encryptionKey.Text = "mothking";
            // 
            // decompileButton
            // 
            this.decompileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.decompileButton.Location = new System.Drawing.Point(13, 176);
            this.decompileButton.Name = "decompileButton";
            this.decompileButton.Size = new System.Drawing.Size(75, 23);
            this.decompileButton.TabIndex = 8;
            this.decompileButton.Text = "Decompile";
            this.decompileButton.UseVisualStyleBackColor = true;
            this.decompileButton.Click += new System.EventHandler(this.decompileButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.decryptButton.Location = new System.Drawing.Point(105, 176);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(75, 23);
            this.decryptButton.TabIndex = 9;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.encryptButton.Location = new System.Drawing.Point(197, 176);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(75, 23);
            this.encryptButton.TabIndex = 10;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.decompileButton);
            this.Controls.Add(this.encryptionKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputFileText);
            this.Controls.Add(this.outputFileButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputFileText);
            this.Controls.Add(this.inputFileButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 250);
            this.Name = "MainForm";
            this.Text = "Escapists Map Tools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button inputFileButton;
        private System.Windows.Forms.TextBox inputFileText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox outputFileText;
        private System.Windows.Forms.Button outputFileButton;
        private System.Windows.Forms.OpenFileDialog inputFileDialog;
        private System.Windows.Forms.SaveFileDialog outputFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox encryptionKey;
        private System.Windows.Forms.Button decompileButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Button encryptButton;
    }
}

