namespace TaskManager
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
            this.btnEndTask = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runNewTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTaskManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.ProcessesList = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.lblCPUpercent = new MetroFramework.Controls.MetroLabel();
            this.CPUbar = new MetroFramework.Controls.MetroProgressBar();
            this.lblRAMpercent = new MetroFramework.Controls.MetroLabel();
            this.RAMbar = new MetroFramework.Controls.MetroProgressBar();
            this.lblRAM = new MetroFramework.Controls.MetroLabel();
            this.lblCPU = new MetroFramework.Controls.MetroLabel();
            this.Services = new MetroFramework.Controls.MetroTabPage();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEndTask
            // 
            this.btnEndTask.Location = new System.Drawing.Point(365, 375);
            this.btnEndTask.Name = "btnEndTask";
            this.btnEndTask.Size = new System.Drawing.Size(75, 23);
            this.btnEndTask.TabIndex = 2;
            this.btnEndTask.Text = "End Task";
            this.btnEndTask.UseVisualStyleBackColor = true;
            this.btnEndTask.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(458, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runNewTaskToolStripMenuItem,
            this.exitTaskManagerToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // runNewTaskToolStripMenuItem
            // 
            this.runNewTaskToolStripMenuItem.Name = "runNewTaskToolStripMenuItem";
            this.runNewTaskToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.runNewTaskToolStripMenuItem.Text = "Run new task";
            this.runNewTaskToolStripMenuItem.Click += new System.EventHandler(this.runNewTaskToolStripMenuItem_Click);
            // 
            // exitTaskManagerToolStripMenuItem
            // 
            this.exitTaskManagerToolStripMenuItem.Name = "exitTaskManagerToolStripMenuItem";
            this.exitTaskManagerToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exitTaskManagerToolStripMenuItem.Text = "Exit Task Manager";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.metroTabPage1);
            this.TabControl.Controls.Add(this.metroTabPage2);
            this.TabControl.Controls.Add(this.Services);
            this.TabControl.Location = new System.Drawing.Point(24, 88);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(451, 443);
            this.TabControl.TabIndex = 4;
            this.TabControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TabControl.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.AllowDrop = true;
            this.metroTabPage1.Controls.Add(this.ProcessesList);
            this.metroTabPage1.Controls.Add(this.btnEndTask);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.metroTabPage1.Size = new System.Drawing.Size(443, 401);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Processes";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // ProcessesList
            // 
            this.ProcessesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.ProcessesList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProcessesList.FullRowSelect = true;
            this.ProcessesList.Location = new System.Drawing.Point(0, 3);
            this.ProcessesList.Name = "ProcessesList";
            this.ProcessesList.OwnerDraw = true;
            this.ProcessesList.Size = new System.Drawing.Size(440, 369);
            this.ProcessesList.TabIndex = 3;
            this.ProcessesList.UseCompatibleStateImageBehavior = false;
            this.ProcessesList.UseSelectable = true;
            this.ProcessesList.View = System.Windows.Forms.View.Details;
           
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CPU";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Memory";
            this.columnHeader3.Width = 83;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Network";
            this.columnHeader4.Width = 85;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "GPU";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Power Usage";
            this.columnHeader6.Width = 88;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.lblCPUpercent);
            this.metroTabPage2.Controls.Add(this.CPUbar);
            this.metroTabPage2.Controls.Add(this.lblRAMpercent);
            this.metroTabPage2.Controls.Add(this.RAMbar);
            this.metroTabPage2.Controls.Add(this.lblRAM);
            this.metroTabPage2.Controls.Add(this.lblCPU);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(443, 401);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Performance";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // lblCPUpercent
            // 
            this.lblCPUpercent.AutoSize = true;
            this.lblCPUpercent.Location = new System.Drawing.Point(393, 33);
            this.lblCPUpercent.Name = "lblCPUpercent";
            this.lblCPUpercent.Size = new System.Drawing.Size(27, 19);
            this.lblCPUpercent.TabIndex = 9;
            this.lblCPUpercent.Text = "0%";
            // 
            // CPUbar
            // 
            this.CPUbar.Location = new System.Drawing.Point(69, 29);
            this.CPUbar.Name = "CPUbar";
            this.CPUbar.Size = new System.Drawing.Size(303, 23);
            this.CPUbar.TabIndex = 8;
            // 
            // lblRAMpercent
            // 
            this.lblRAMpercent.AutoSize = true;
            this.lblRAMpercent.Location = new System.Drawing.Point(393, 92);
            this.lblRAMpercent.Name = "lblRAMpercent";
            this.lblRAMpercent.Size = new System.Drawing.Size(27, 19);
            this.lblRAMpercent.TabIndex = 7;
            this.lblRAMpercent.Text = "0%";
            // 
            // RAMbar
            // 
            this.RAMbar.Location = new System.Drawing.Point(69, 88);
            this.RAMbar.Name = "RAMbar";
            this.RAMbar.Size = new System.Drawing.Size(303, 23);
            this.RAMbar.TabIndex = 6;
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Location = new System.Drawing.Point(13, 92);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(41, 19);
            this.lblRAM.TabIndex = 5;
            this.lblRAM.Text = "RAM:";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Location = new System.Drawing.Point(16, 29);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(38, 19);
            this.lblCPU.TabIndex = 2;
            this.lblCPU.Text = "CPU:";
            // 
            // Services
            // 
            this.Services.HorizontalScrollbarBarColor = true;
            this.Services.HorizontalScrollbarHighlightOnWheel = false;
            this.Services.HorizontalScrollbarSize = 10;
            this.Services.Location = new System.Drawing.Point(4, 38);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(443, 401);
            this.Services.TabIndex = 2;
            this.Services.Text = "Services";
            this.Services.VerticalScrollbarBarColor = true;
            this.Services.VerticalScrollbarHighlightOnWheel = false;
            this.Services.VerticalScrollbarSize = 10;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 545);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEndTask;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runNewTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitTaskManagerToolStripMenuItem;
        private MetroFramework.Controls.MetroTabControl TabControl;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroLabel lblRAMpercent;
        private MetroFramework.Controls.MetroProgressBar RAMbar;
        private MetroFramework.Controls.MetroLabel lblRAM;
        private MetroFramework.Controls.MetroLabel lblCPU;
        private MetroFramework.Controls.MetroLabel lblCPUpercent;
        private MetroFramework.Controls.MetroProgressBar CPUbar;
        private MetroFramework.Controls.MetroTabPage Services;
        private MetroFramework.Controls.MetroListView ProcessesList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

