namespace RemoteAssist
{
    partial class RemoteAssist
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtComputerName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "AskForHelp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(333, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "OfferHelp";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtComputerName
            // 
            this.txtComputerName.Location = new System.Drawing.Point(34, 88);
            this.txtComputerName.Name = "txtComputerName";
            this.txtComputerName.Size = new System.Drawing.Size(242, 22);
            this.txtComputerName.TabIndex = 2;
            this.txtComputerName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RemoteAssist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 372);
            this.Controls.Add(this.txtComputerName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "RemoteAssist";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtComputerName;
    }
}

