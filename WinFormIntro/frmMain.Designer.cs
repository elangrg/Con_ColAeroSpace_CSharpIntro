namespace WinFormIntro
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.demosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniBasicControlsUsingContactFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDataBindingSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBindingObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBindingADOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.demosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1400, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // demosToolStripMenuItem
            // 
            this.demosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniBasicControlsUsingContactFormToolStripMenuItem,
            this.mniDataBindingSimpleToolStripMenuItem,
            this.dataBindingObjectToolStripMenuItem,
            this.dataBindingADOToolStripMenuItem});
            this.demosToolStripMenuItem.Name = "demosToolStripMenuItem";
            this.demosToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.demosToolStripMenuItem.Text = "Demos";
            // 
            // mniBasicControlsUsingContactFormToolStripMenuItem
            // 
            this.mniBasicControlsUsingContactFormToolStripMenuItem.Name = "mniBasicControlsUsingContactFormToolStripMenuItem";
            this.mniBasicControlsUsingContactFormToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.mniBasicControlsUsingContactFormToolStripMenuItem.Text = "Basic Controls using Contact form";
            this.mniBasicControlsUsingContactFormToolStripMenuItem.Click += new System.EventHandler(this.mniBasicControlsUsingContactFormToolStripMenuItem_Click);
            // 
            // mniDataBindingSimpleToolStripMenuItem
            // 
            this.mniDataBindingSimpleToolStripMenuItem.Name = "mniDataBindingSimpleToolStripMenuItem";
            this.mniDataBindingSimpleToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.mniDataBindingSimpleToolStripMenuItem.Text = "Data binding Database";
            this.mniDataBindingSimpleToolStripMenuItem.Click += new System.EventHandler(this.mniDataBindingSimpleToolStripMenuItem_Click);
            // 
            // dataBindingObjectToolStripMenuItem
            // 
            this.dataBindingObjectToolStripMenuItem.Name = "dataBindingObjectToolStripMenuItem";
            this.dataBindingObjectToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.dataBindingObjectToolStripMenuItem.Text = "Data Binding object";
            // 
            // dataBindingADOToolStripMenuItem
            // 
            this.dataBindingADOToolStripMenuItem.Name = "dataBindingADOToolStripMenuItem";
            this.dataBindingADOToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.dataBindingADOToolStripMenuItem.Text = "Data binding ADO";
            this.dataBindingADOToolStripMenuItem.Click += new System.EventHandler(this.dataBindingADOToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 760);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("MS Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "frmMain";
            this.Text = "Windows Form Application Intro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem demosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniBasicControlsUsingContactFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniDataBindingSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBindingObjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBindingADOToolStripMenuItem;
    }
}

