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
            this.lblNroDisplays = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display1
            // 
            this.display1.AutoSize = true;
            this.display1.Location = new System.Drawing.Point(37, 50);
            this.display1.Name = "display1";
            this.display1.Size = new System.Drawing.Size(60, 17);
            this.display1.TabIndex = 0;
            this.display1.Text = "display1";
            // 
            // display2
            // 
            this.display2.AutoSize = true;
            this.display2.Location = new System.Drawing.Point(37, 140);
            this.display2.Name = "display2";
            this.display2.Size = new System.Drawing.Size(0, 17);
            this.display2.TabIndex = 1;
            // 
            // lblNroDisplays
            // 
            this.lblNroDisplays.AutoSize = true;
            this.lblNroDisplays.Location = new System.Drawing.Point(243, 112);
            this.lblNroDisplays.Name = "lblNroDisplays";
            this.lblNroDisplays.Size = new System.Drawing.Size(46, 17);
            this.lblNroDisplays.TabIndex = 2;
            this.lblNroDisplays.Text = "label1";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(185, 227);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(163, 37);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 303);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblNroDisplays);
            this.Controls.Add(this.display2);
            this.Controls.Add(this.display1);
            this.Name = "DisplayForm";
            this.Text = "ShowDisplays";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label display1;
        private System.Windows.Forms.Label display2;
        private System.Windows.Forms.Label lblNroDisplays;
        private System.Windows.Forms.Button btnCancel;
    }
}

