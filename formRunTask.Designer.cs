namespace TaskManager
{
    partial class formRunTask
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
            this.lblOpen = new System.Windows.Forms.Label();
            this.textOpen = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOpen
            // 
            this.lblOpen.AutoSize = true;
            this.lblOpen.Location = new System.Drawing.Point(52, 69);
            this.lblOpen.Name = "lblOpen";
            this.lblOpen.Size = new System.Drawing.Size(33, 13);
            this.lblOpen.TabIndex = 0;
            this.lblOpen.Text = "Open";
            this.lblOpen.Click += new System.EventHandler(this.label1_Click);
            // 
            // textOpen
            // 
            this.textOpen.Location = new System.Drawing.Point(113, 66);
            this.textOpen.Name = "textOpen";
            this.textOpen.Size = new System.Drawing.Size(281, 20);
            this.textOpen.TabIndex = 1;
            // 
            // btnRun
            // 
            this.btnRun.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRun.Location = new System.Drawing.Point(318, 107);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(76, 28);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // formRunTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 149);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.textOpen);
            this.Controls.Add(this.lblOpen);
            this.Name = "formRunTask";
            this.Text = "Run New Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpen;
        private System.Windows.Forms.TextBox textOpen;
        private System.Windows.Forms.Button btnRun;
    }
}