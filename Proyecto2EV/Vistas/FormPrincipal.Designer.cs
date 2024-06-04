namespace Proyecto2EV.Vistas
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.catalogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reseñasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verReseñasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.linkLabelSteam = new System.Windows.Forms.LinkLabel();
            this.pictureBoxSteam = new System.Windows.Forms.PictureBox();
            this.pictureBoxSwitch = new System.Windows.Forms.PictureBox();
            this.linkLabelSwitch = new System.Windows.Forms.LinkLabel();
            this.pictureBoxXbox = new System.Windows.Forms.PictureBox();
            this.linkLabelXbox = new System.Windows.Forms.LinkLabel();
            this.pictureBoxPs5 = new System.Windows.Forms.PictureBox();
            this.linkLabelPs5 = new System.Windows.Forms.LinkLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSteam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxXbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPs5)).BeginInit();
            this.contextMenuNotifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogoToolStripMenuItem,
            this.carritoToolStripMenuItem,
            this.reseñasToolStripMenuItem,
            this.verLogsToolStripMenuItem});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Size = new System.Drawing.Size(749, 24);
            this.menuStripPrincipal.TabIndex = 0;
            this.menuStripPrincipal.Text = "menuStrip1";
            // 
            // catalogoToolStripMenuItem
            // 
            this.catalogoToolStripMenuItem.Name = "catalogoToolStripMenuItem";
            this.catalogoToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.catalogoToolStripMenuItem.Text = "Catalogo";
            this.catalogoToolStripMenuItem.Click += new System.EventHandler(this.catalogoToolStripMenuItem_Click);
            // 
            // carritoToolStripMenuItem
            // 
            this.carritoToolStripMenuItem.Name = "carritoToolStripMenuItem";
            this.carritoToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.carritoToolStripMenuItem.Text = "Carrito";
            this.carritoToolStripMenuItem.Click += new System.EventHandler(this.carritoToolStripMenuItem_Click);
            // 
            // reseñasToolStripMenuItem
            // 
            this.reseñasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.publicarToolStripMenuItem,
            this.verReseñasToolStripMenuItem});
            this.reseñasToolStripMenuItem.Name = "reseñasToolStripMenuItem";
            this.reseñasToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.reseñasToolStripMenuItem.Text = "Reseñas";
            // 
            // publicarToolStripMenuItem
            // 
            this.publicarToolStripMenuItem.Name = "publicarToolStripMenuItem";
            this.publicarToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.publicarToolStripMenuItem.Text = "Publicar reseña";
            this.publicarToolStripMenuItem.Click += new System.EventHandler(this.publicarToolStripMenuItem_Click);
            // 
            // verReseñasToolStripMenuItem
            // 
            this.verReseñasToolStripMenuItem.Name = "verReseñasToolStripMenuItem";
            this.verReseñasToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.verReseñasToolStripMenuItem.Text = "Ver reseñas";
            this.verReseñasToolStripMenuItem.Click += new System.EventHandler(this.verReseñasToolStripMenuItem_Click);
            // 
            // verLogsToolStripMenuItem
            // 
            this.verLogsToolStripMenuItem.Name = "verLogsToolStripMenuItem";
            this.verLogsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.verLogsToolStripMenuItem.Text = "Ver Logs";
            this.verLogsToolStripMenuItem.Click += new System.EventHandler(this.verLogsToolStripMenuItem_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(12, 24);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(520, 65);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Cuando compres un juego podras canjear tu clave en alguna de las siguientes plata" +
    "formas:\r\n";
            // 
            // linkLabelSteam
            // 
            this.linkLabelSteam.AutoSize = true;
            this.linkLabelSteam.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelSteam.Location = new System.Drawing.Point(55, 98);
            this.linkLabelSteam.Name = "linkLabelSteam";
            this.linkLabelSteam.Size = new System.Drawing.Size(70, 25);
            this.linkLabelSteam.TabIndex = 0;
            this.linkLabelSteam.TabStop = true;
            this.linkLabelSteam.Text = "Steam";
            this.linkLabelSteam.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSteam_LinkClicked);
            // 
            // pictureBoxSteam
            // 
            this.pictureBoxSteam.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSteam.Image")));
            this.pictureBoxSteam.Location = new System.Drawing.Point(17, 92);
            this.pictureBoxSteam.Name = "pictureBoxSteam";
            this.pictureBoxSteam.Size = new System.Drawing.Size(32, 31);
            this.pictureBoxSteam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSteam.TabIndex = 3;
            this.pictureBoxSteam.TabStop = false;
            // 
            // pictureBoxSwitch
            // 
            this.pictureBoxSwitch.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSwitch.Image")));
            this.pictureBoxSwitch.Location = new System.Drawing.Point(17, 129);
            this.pictureBoxSwitch.Name = "pictureBoxSwitch";
            this.pictureBoxSwitch.Size = new System.Drawing.Size(32, 31);
            this.pictureBoxSwitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSwitch.TabIndex = 5;
            this.pictureBoxSwitch.TabStop = false;
            // 
            // linkLabelSwitch
            // 
            this.linkLabelSwitch.AutoSize = true;
            this.linkLabelSwitch.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelSwitch.Location = new System.Drawing.Point(55, 135);
            this.linkLabelSwitch.Name = "linkLabelSwitch";
            this.linkLabelSwitch.Size = new System.Drawing.Size(162, 25);
            this.linkLabelSwitch.TabIndex = 1;
            this.linkLabelSwitch.TabStop = true;
            this.linkLabelSwitch.Text = "Nintendo eShop";
            this.linkLabelSwitch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSwitch_LinkClicked);
            // 
            // pictureBoxXbox
            // 
            this.pictureBoxXbox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxXbox.Image")));
            this.pictureBoxXbox.Location = new System.Drawing.Point(17, 166);
            this.pictureBoxXbox.Name = "pictureBoxXbox";
            this.pictureBoxXbox.Size = new System.Drawing.Size(32, 31);
            this.pictureBoxXbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxXbox.TabIndex = 7;
            this.pictureBoxXbox.TabStop = false;
            // 
            // linkLabelXbox
            // 
            this.linkLabelXbox.AutoSize = true;
            this.linkLabelXbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelXbox.Location = new System.Drawing.Point(55, 172);
            this.linkLabelXbox.Name = "linkLabelXbox";
            this.linkLabelXbox.Size = new System.Drawing.Size(154, 25);
            this.linkLabelXbox.TabIndex = 2;
            this.linkLabelXbox.TabStop = true;
            this.linkLabelXbox.Text = "Micorsoft Store";
            this.linkLabelXbox.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelXbox_LinkClicked);
            // 
            // pictureBoxPs5
            // 
            this.pictureBoxPs5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPs5.Image")));
            this.pictureBoxPs5.Location = new System.Drawing.Point(17, 203);
            this.pictureBoxPs5.Name = "pictureBoxPs5";
            this.pictureBoxPs5.Size = new System.Drawing.Size(32, 31);
            this.pictureBoxPs5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPs5.TabIndex = 9;
            this.pictureBoxPs5.TabStop = false;
            // 
            // linkLabelPs5
            // 
            this.linkLabelPs5.AutoSize = true;
            this.linkLabelPs5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelPs5.Location = new System.Drawing.Point(55, 209);
            this.linkLabelPs5.Name = "linkLabelPs5";
            this.linkLabelPs5.Size = new System.Drawing.Size(169, 25);
            this.linkLabelPs5.TabIndex = 3;
            this.linkLabelPs5.TabStop = true;
            this.linkLabelPs5.Text = "PlayStation Store";
            this.linkLabelPs5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPs5_LinkClicked);
            // 
            // contextMenuNotifyIcon
            // 
            this.contextMenuNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.contextMenuNotifyIcon.Name = "contextMenuNotifyIcon";
            this.contextMenuNotifyIcon.Size = new System.Drawing.Size(171, 26);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.salirToolStripMenuItem.Text = "Salir del programa";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.pictureBoxPs5);
            this.Controls.Add(this.linkLabelPs5);
            this.Controls.Add(this.pictureBoxXbox);
            this.Controls.Add(this.linkLabelXbox);
            this.Controls.Add(this.pictureBoxSwitch);
            this.Controls.Add(this.linkLabelSwitch);
            this.Controls.Add(this.pictureBoxSteam);
            this.Controls.Add(this.linkLabelSteam);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.menuStripPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda de Videojuegos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSteam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxXbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPs5)).EndInit();
            this.contextMenuNotifyIcon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem catalogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carritoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reseñasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verReseñasToolStripMenuItem;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.LinkLabel linkLabelSteam;
        private System.Windows.Forms.PictureBox pictureBoxSteam;
        private System.Windows.Forms.PictureBox pictureBoxSwitch;
        private System.Windows.Forms.LinkLabel linkLabelSwitch;
        private System.Windows.Forms.PictureBox pictureBoxXbox;
        private System.Windows.Forms.LinkLabel linkLabelXbox;
        private System.Windows.Forms.PictureBox pictureBoxPs5;
        private System.Windows.Forms.LinkLabel linkLabelPs5;
        private System.Windows.Forms.ToolStripMenuItem verLogsToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ContextMenuStrip contextMenuNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}