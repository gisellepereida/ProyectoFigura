namespace ProyectoFigura
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
            this.circuloToolStripMenuItem = new System.Windows.Forms.ToolStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rectanguloToolStripMenuItem = new System.Windows.Forms.ToolStrip();
            this.rectaToolStripMenuItem = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // circuloToolStripMenuItem
            // 
            this.circuloToolStripMenuItem.Location = new System.Drawing.Point(0, 24);
            this.circuloToolStripMenuItem.Name = "circuloToolStripMenuItem";
            this.circuloToolStripMenuItem.Size = new System.Drawing.Size(284, 25);
            this.circuloToolStripMenuItem.TabIndex = 0;
            this.circuloToolStripMenuItem.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.circuloToolStripMenuItem_ItemClicked);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // rectanguloToolStripMenuItem
            // 
            this.rectanguloToolStripMenuItem.Location = new System.Drawing.Point(0, 49);
            this.rectanguloToolStripMenuItem.Name = "rectanguloToolStripMenuItem";
            this.rectanguloToolStripMenuItem.Size = new System.Drawing.Size(284, 25);
            this.rectanguloToolStripMenuItem.TabIndex = 1;
            this.rectanguloToolStripMenuItem.Text = "toolStrip1";
            this.rectanguloToolStripMenuItem.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.rectanguloToolStripMenuItem_ItemClicked);
            // 
            // rectaToolStripMenuItem
            // 
            this.rectaToolStripMenuItem.Location = new System.Drawing.Point(0, 0);
            this.rectaToolStripMenuItem.Name = "rectaToolStripMenuItem";
            this.rectaToolStripMenuItem.Size = new System.Drawing.Size(284, 24);
            this.rectaToolStripMenuItem.TabIndex = 2;
            this.rectaToolStripMenuItem.Text = "menuStrip1";
            this.rectaToolStripMenuItem.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.rectaToolStripMenuItem_ItemClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rectanguloToolStripMenuItem);
            this.Controls.Add(this.circuloToolStripMenuItem);
            this.Controls.Add(this.rectaToolStripMenuItem);
            this.MainMenuStrip = this.rectaToolStripMenuItem;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip circuloToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStrip rectanguloToolStripMenuItem;
        private System.Windows.Forms.MenuStrip rectaToolStripMenuItem;
    }
}

