namespace Bioquimica.Forms.Principal
{
    partial class mdiPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiPrincipal));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsbOrdenes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbPrepagas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbPracticas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbConfiguraciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.mdiTabStrip1 = new MdiTabStrip.MdiTabStrip();
            this.tspMenu = new System.Windows.Forms.ToolStrip();
            this.tsbOrden = new System.Windows.Forms.ToolStripButton();
            this.tsbFacturación = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdiTabStrip1)).BeginInit();
            this.tspMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOrdenes,
            this.tsbPrepagas,
            this.tsbPracticas,
            this.tsbConfiguraciones,
            this.tsbAcercaDe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(811, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsbOrdenes
            // 
            this.tsbOrdenes.Name = "tsbOrdenes";
            this.tsbOrdenes.Size = new System.Drawing.Size(63, 20);
            this.tsbOrdenes.Text = "Ordenes";
            this.tsbOrdenes.Click += new System.EventHandler(this.tsbOrdenes_Click);
            // 
            // tsbPrepagas
            // 
            this.tsbPrepagas.Name = "tsbPrepagas";
            this.tsbPrepagas.Size = new System.Drawing.Size(67, 20);
            this.tsbPrepagas.Text = "Prepagas";
            this.tsbPrepagas.Click += new System.EventHandler(this.tsbPrepagas_Click);
            // 
            // tsbPracticas
            // 
            this.tsbPracticas.Name = "tsbPracticas";
            this.tsbPracticas.Size = new System.Drawing.Size(66, 20);
            this.tsbPracticas.Text = "Prácticas";
            this.tsbPracticas.Click += new System.EventHandler(this.tsbPracticas_Click);
            // 
            // tsbConfiguraciones
            // 
            this.tsbConfiguraciones.Name = "tsbConfiguraciones";
            this.tsbConfiguraciones.Size = new System.Drawing.Size(95, 20);
            this.tsbConfiguraciones.Text = "Configuración";
            this.tsbConfiguraciones.Click += new System.EventHandler(this.tsbConfiguraciones_Click);
            // 
            // tsbAcercaDe
            // 
            this.tsbAcercaDe.Name = "tsbAcercaDe";
            this.tsbAcercaDe.Size = new System.Drawing.Size(77, 20);
            this.tsbAcercaDe.Text = "Acerca de..";
            this.tsbAcercaDe.Click += new System.EventHandler(this.tsbAcercaDe_Click);
            // 
            // mdiTabStrip1
            // 
            this.mdiTabStrip1.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdiTabStrip1.AllowDrop = true;
            this.mdiTabStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.mdiTabStrip1.InactiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdiTabStrip1.Location = new System.Drawing.Point(96, 24);
            this.mdiTabStrip1.MdiNewTabImage = null;
            this.mdiTabStrip1.MinimumSize = new System.Drawing.Size(50, 33);
            this.mdiTabStrip1.MouseOverTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdiTabStrip1.Name = "mdiTabStrip1";
            this.mdiTabStrip1.NewTabToolTipText = "New Tab";
            this.mdiTabStrip1.Padding = new System.Windows.Forms.Padding(5, 3, 20, 5);
            this.mdiTabStrip1.Size = new System.Drawing.Size(715, 35);
            this.mdiTabStrip1.TabIndex = 7;
            this.mdiTabStrip1.Text = "mdiTabStrip1";
            // 
            // tspMenu
            // 
            this.tspMenu.AllowMerge = false;
            this.tspMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.tspMenu.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tspMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOrden,
            this.tsbFacturación});
            this.tspMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.tspMenu.Location = new System.Drawing.Point(0, 24);
            this.tspMenu.Name = "tspMenu";
            this.tspMenu.Size = new System.Drawing.Size(96, 529);
            this.tspMenu.TabIndex = 6;
            this.tspMenu.Text = "toolStrip1";
            // 
            // tsbOrden
            // 
            this.tsbOrden.AutoSize = false;
            this.tsbOrden.Image = ((System.Drawing.Image)(resources.GetObject("tsbOrden.Image")));
            this.tsbOrden.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbOrden.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOrden.Margin = new System.Windows.Forms.Padding(0, 34, 0, 2);
            this.tsbOrden.Name = "tsbOrden";
            this.tsbOrden.Size = new System.Drawing.Size(95, 95);
            this.tsbOrden.Text = "Ordenes";
            this.tsbOrden.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbOrden.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsbOrden.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbOrden.Click += new System.EventHandler(this.tsbOrden_Click);
            // 
            // tsbFacturación
            // 
            this.tsbFacturación.AutoSize = false;
            this.tsbFacturación.Image = global::Bioquimica.Properties.Resources.Caja;
            this.tsbFacturación.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbFacturación.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFacturación.Name = "tsbFacturación";
            this.tsbFacturación.Size = new System.Drawing.Size(95, 95);
            this.tsbFacturación.Text = "Facturación";
            this.tsbFacturación.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbFacturación.Click += new System.EventHandler(this.tsbFacturación_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // mdiPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 553);
            this.Controls.Add(this.mdiTabStrip1);
            this.Controls.Add(this.tspMenu);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mdiPrincipal";
            this.Text = "Bioquimica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdiTabStrip1)).EndInit();
            this.tspMenu.ResumeLayout(false);
            this.tspMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsbOrdenes;
        private System.Windows.Forms.ToolStripMenuItem tsbPrepagas;
        private System.Windows.Forms.ToolStripMenuItem tsbPracticas;
        private System.Windows.Forms.ToolStripMenuItem tsbConfiguraciones;
        private System.Windows.Forms.ToolStripMenuItem tsbAcercaDe;
        private MdiTabStrip.MdiTabStrip mdiTabStrip1;
        private System.Windows.Forms.ToolStrip tspMenu;
        private System.Windows.Forms.ToolStripButton tsbOrden;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbFacturación;
    }
}



