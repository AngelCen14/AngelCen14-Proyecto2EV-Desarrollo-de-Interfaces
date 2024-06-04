namespace Proyecto2EV.Vistas {
    partial class FormLogs {
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
            this.components = new System.ComponentModel.Container();
            this.richTextBoxLogs = new System.Windows.Forms.RichTextBox();
            this.contextMenuRichTextBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDelFondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.contextMenuRichTextBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxLogs
            // 
            this.richTextBoxLogs.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBoxLogs.ContextMenuStrip = this.contextMenuRichTextBox;
            this.richTextBoxLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLogs.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxLogs.ForeColor = System.Drawing.Color.LimeGreen;
            this.richTextBoxLogs.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxLogs.Name = "richTextBoxLogs";
            this.richTextBoxLogs.ReadOnly = true;
            this.richTextBoxLogs.Size = new System.Drawing.Size(1072, 558);
            this.richTextBoxLogs.TabIndex = 0;
            this.richTextBoxLogs.Text = "";
            this.richTextBoxLogs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBoxLogs_KeyDown);
            // 
            // contextMenuRichTextBox
            // 
            this.contextMenuRichTextBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textoToolStripMenuItem,
            this.colorDelFondoToolStripMenuItem});
            this.contextMenuRichTextBox.Name = "contextMenuRichTextBox";
            this.contextMenuRichTextBox.Size = new System.Drawing.Size(158, 48);
            // 
            // textoToolStripMenuItem
            // 
            this.textoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fuenteToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.textoToolStripMenuItem.Name = "textoToolStripMenuItem";
            this.textoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.textoToolStripMenuItem.Text = "Texto";
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.fuenteToolStripMenuItem.Text = "Fuente";
            this.fuenteToolStripMenuItem.Click += new System.EventHandler(this.fuenteToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // colorDelFondoToolStripMenuItem
            // 
            this.colorDelFondoToolStripMenuItem.Name = "colorDelFondoToolStripMenuItem";
            this.colorDelFondoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.colorDelFondoToolStripMenuItem.Text = "Color del fondo";
            this.colorDelFondoToolStripMenuItem.Click += new System.EventHandler(this.colorDelFondoToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 558);
            this.Controls.Add(this.richTextBoxLogs);
            this.Name = "FormLogs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logs";
            this.Load += new System.EventHandler(this.FormLogs_Load);
            this.contextMenuRichTextBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxLogs;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ContextMenuStrip contextMenuRichTextBox;
        private System.Windows.Forms.ToolStripMenuItem textoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorDelFondoToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FontDialog fontDialog;
    }
}