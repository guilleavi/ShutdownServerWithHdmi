namespace ShutdownServerWithHdmi
{
    partial class DisplayForm
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
            this.display1 = new System.Windows.Forms.Label();
            this.display2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // display1
            // 
            this.display1.AutoSize = true;
            this.display1.Location = new System.Drawing.Point(37, 96);
            this.display1.Name = "display1";
            this.display1.Size = new System.Drawing.Size(59, 16);
            this.display1.TabIndex = 0;
            this.display1.Text = "display1";
            // 
            // display2
            // 
            this.display2.AutoSize = true;
            this.display2.Location = new System.Drawing.Point(37, 140);
            this.display2.Name = "display2";
            this.display2.Size = new System.Drawing.Size(0, 16);
            this.display2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 244);
            this.Controls.Add(this.display2);
            this.Controls.Add(this.display1);
            this.Name = "Form1";
            this.Text = "ShowDisplays";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label display1;
        private System.Windows.Forms.Label display2;
    }
}

