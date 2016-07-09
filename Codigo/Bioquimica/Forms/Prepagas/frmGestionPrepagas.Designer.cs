namespace Bioquimica.Forms.Prepagas
{
    partial class frmGestionPrepagas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionPrepagas));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ucPaginador = new Util.Controles.UcPaginador();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDescripcion = new Util.Controles.ucTexto();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.prepagaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prepagaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nBUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discriminaIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeIVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordensDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExcDetalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ExcEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepagaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Size = new System.Drawing.Size(957, 594);
            this.splitContainer2.SplitterDistance = 110;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ucPaginador);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.btnActualizar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(957, 60);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // ucPaginador
            // 
            this.ucPaginador.CurrentPage = 1;
            this.ucPaginador.Location = new System.Drawing.Point(6, 11);
            this.ucPaginador.Margin = new System.Windows.Forms.Padding(0);
            this.ucPaginador.Name = "ucPaginador";
            this.ucPaginador.PageSize = 10;
            this.ucPaginador.PageTotal = null;
            this.ucPaginador.Size = new System.Drawing.Size(490, 42);
            this.ucPaginador.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAgregar.Image = global::Bioquimica.Properties.Resources.add1;
            this.btnAgregar.Location = new System.Drawing.Point(776, 24);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnActualizar.Image = global::Bioquimica.Properties.Resources.refresh_small;
            this.btnActualizar.Location = new System.Drawing.Point(876, 24);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 50);
            this.panel1.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            this.tableLayoutPanel1.Controls.Add(this.txtDescripcion, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBuscar, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(957, 50);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Alto = 25;
            this.txtDescripcion.Ancho = 236;
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDescripcion.BarraScroll = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcion.CharCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Disabled = false;
            this.txtDescripcion.ErrorMessage = "";
            this.txtDescripcion.EsObligatorio = true;
            this.txtDescripcion.InvalidateChar = null;
            this.txtDescripcion.Location = new System.Drawing.Point(4, 12);
            this.txtDescripcion.LongMax = 50;
            this.txtDescripcion.LongMin = 0;
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.MultiLineas = false;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Referencia = null;
            this.txtDescripcion.Size = new System.Drawing.Size(236, 25);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.Valor = "";
            this.txtDescripcion.TeclaApretada += new Util.Controles.ucTexto.TeclaApretadaEventHandler(this.txtDescripcion_TeclaApretada);
            this.txtDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcion_KeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBuscar.Image = global::Bioquimica.Properties.Resources.lupa_chica;
            this.btnBuscar.Location = new System.Drawing.Point(253, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(99, 28);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvListado);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(957, 480);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prepagas";
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.AllowUserToOrderColumns = true;
            this.dgvListado.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListado.AutoGenerateColumns = false;
            this.dgvListado.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListado.ColumnHeadersHeight = 31;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prepagaId,
            this.nombreDataGridViewTextBoxColumn,
            this.domicilioDataGridViewTextBoxColumn,
            this.nBUDataGridViewTextBoxColumn,
            this.discriminaIVA,
            this.porcentajeIVADataGridViewTextBoxColumn,
            this.ordensDataGridViewTextBoxColumn,
            this.ExcDetalle,
            this.ExcEditar,
            this.Eliminar});
            this.dgvListado.DataSource = this.prepagaBindingSource;
            this.dgvListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListado.Location = new System.Drawing.Point(3, 18);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListado.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListado.RowTemplate.Height = 30;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(951, 459);
            this.dgvListado.TabIndex = 6;
            this.dgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellContentClick);
            this.dgvListado.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListado_CellFormatting);
            this.dgvListado.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvListado_CellPainting);
            // 
            // prepagaBindingSource
            // 
            this.prepagaBindingSource.DataSource = typeof(Bioquimica.Entidades.Prepaga);
            // 
            // prepagaId
            // 
            this.prepagaId.DataPropertyName = "PrepagaId";
            this.prepagaId.HeaderText = "PrepagaId";
            this.prepagaId.Name = "prepagaId";
            this.prepagaId.ReadOnly = true;
            this.prepagaId.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // domicilioDataGridViewTextBoxColumn
            // 
            this.domicilioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.domicilioDataGridViewTextBoxColumn.DataPropertyName = "Domicilio";
            this.domicilioDataGridViewTextBoxColumn.HeaderText = "Domicilio";
            this.domicilioDataGridViewTextBoxColumn.Name = "domicilioDataGridViewTextBoxColumn";
            this.domicilioDataGridViewTextBoxColumn.ReadOnly = true;
            this.domicilioDataGridViewTextBoxColumn.Width = 250;
            // 
            // nBUDataGridViewTextBoxColumn
            // 
            this.nBUDataGridViewTextBoxColumn.DataPropertyName = "NBU";
            this.nBUDataGridViewTextBoxColumn.HeaderText = "NBU";
            this.nBUDataGridViewTextBoxColumn.Name = "nBUDataGridViewTextBoxColumn";
            this.nBUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discriminaIVA
            // 
            this.discriminaIVA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.discriminaIVA.DataPropertyName = "DiscriminaIVA";
            this.discriminaIVA.HeaderText = "Discrimina IVA";
            this.discriminaIVA.Name = "discriminaIVA";
            this.discriminaIVA.ReadOnly = true;
            this.discriminaIVA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.discriminaIVA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.discriminaIVA.Width = 130;
            // 
            // porcentajeIVADataGridViewTextBoxColumn
            // 
            this.porcentajeIVADataGridViewTextBoxColumn.DataPropertyName = "PorcentajeIVA";
            this.porcentajeIVADataGridViewTextBoxColumn.HeaderText = "% IVA";
            this.porcentajeIVADataGridViewTextBoxColumn.Name = "porcentajeIVADataGridViewTextBoxColumn";
            this.porcentajeIVADataGridViewTextBoxColumn.ReadOnly = true;
            this.porcentajeIVADataGridViewTextBoxColumn.Width = 140;
            // 
            // ordensDataGridViewTextBoxColumn
            // 
            this.ordensDataGridViewTextBoxColumn.DataPropertyName = "Ordens";
            this.ordensDataGridViewTextBoxColumn.HeaderText = "Ordens";
            this.ordensDataGridViewTextBoxColumn.Name = "ordensDataGridViewTextBoxColumn";
            this.ordensDataGridViewTextBoxColumn.ReadOnly = true;
            this.ordensDataGridViewTextBoxColumn.Visible = false;
            // 
            // ExcDetalle
            // 
            this.ExcDetalle.FillWeight = 52.88057F;
            this.ExcDetalle.HeaderText = "";
            this.ExcDetalle.Name = "ExcDetalle";
            this.ExcDetalle.ReadOnly = true;
            this.ExcDetalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ExcDetalle.Width = 22;
            // 
            // ExcEditar
            // 
            this.ExcEditar.HeaderText = "";
            this.ExcEditar.Name = "ExcEditar";
            this.ExcEditar.ReadOnly = true;
            this.ExcEditar.Width = 22;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 22;
            // 
            // frmGestionPrepagas
            // 
            this.ClientSize = new System.Drawing.Size(957, 594);
            this.Controls.Add(this.splitContainer2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmGestionPrepagas";
            this.Text = "Gestión de Prepagas";
            this.Load += new System.EventHandler(this.frmGestionPrepagas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGestionPrepagas_KeyDown);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepagaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordenesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Util.Controles.ucTexto txtDescripcion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private Util.Controles.UcPaginador ucPaginador;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.BindingSource prepagaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn prepagaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nBUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discriminaIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajeIVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordensDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ExcDetalle;
        private System.Windows.Forms.DataGridViewButtonColumn ExcEditar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}