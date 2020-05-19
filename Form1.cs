using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class Form1 :MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        PerformanceCounter pRAM = new PerformanceCounter("Memory", "% Committed Bytes In Use");
        PerformanceCounter pCPU = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        

        Process[] proc;

        void getAllProcess()
        {
            proc = System.Diagnostics.Process.GetProcesses();

            foreach (Process p in proc)
            {
                ListViewItem newProc = new ListViewItem() { Text = p.ProcessName };
                newProc.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = p.PagedMemorySize64.ToString()});
                ProcessesList.Items.Add(newProc);
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            getAllProcess();
            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProcessesList.SelectedItems.Count > 0)
                {
                    proc[ProcessesList.SelectedIndices[0]].Kill();
                    getAllProcess();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void runNewTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (formRunTask frm = new formRunTask())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    getAllProcess();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();
           
            CPUbar.Value = (int)fcpu;
            RAMbar.Value = (int)fram;
            lblCPUpercent.Text = string.Format("{0:0.00}%", fcpu);
            lblRAMpercent.Text = string.Format("{0:0.00}%", fram);

            if (proc.Length != Process.GetProcesses().Length)
            {
                getAllProcess();
            }
                
        }

        
    }
}
