namespace Bioquimica.Forms.Ordenes
{
    partial class frmGestionOrdenes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionOrdenes));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPrepagas = new System.Windows.Forms.ComboBox();
            this.txtNroOrden = new Util.Controles.ucSoloNumero();
            this.dtpFechaAtencion = new Util.Controles.ucDatePicker();
            this.txtPaciente = new Util.Controles.ucTexto();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbFecha = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ucPaginador = new Util.Controles.UcPaginador();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.prepagaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroOrdenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAtencionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prepagaNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteDNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteFechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discriminaIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prepagasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.practicasOrdenesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prepagaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prepagaStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExcDetalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ExcEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ExcEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboDiscriminaIVA = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepagaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1249, 537);
            this.splitContainer1.SplitterDistance = 160;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 123);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 391F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 303F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 258F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboPrepagas, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNroOrden, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpFechaAtencion, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPaciente, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ckbFecha, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboDiscriminaIVA, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBuscar, 5, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1249, 123);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prepaga";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro. de Orden";
            // 
            // cboPrepagas
            // 
            this.cboPrepagas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboPrepagas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboPrepagas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboPrepagas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrepagas.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPrepagas.FormattingEnabled = true;
            this.cboPrepagas.Location = new System.Drawing.Point(124, 77);
            this.cboPrepagas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboPrepagas.Name = "cboPrepagas";
            this.cboPrepagas.Size = new System.Drawing.Size(331, 31);
            this.cboPrepagas.TabIndex = 2;
            // 
            // txtNroOrden
            // 
            this.txtNroOrden.AceptaDecimales = false;
            this.txtNroOrden.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNroOrden.Disabled = false;
            this.txtNroOrden.ErrorMessage = "";
            this.txtNroOrden.EsObligatorio = true;
            this.txtNroOrden.Location = new System.Drawing.Point(125, 15);
            this.txtNroOrden.LongMax = 8;
            this.txtNroOrden.LongMin = 0;
            this.txtNroOrden.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNroOrden.MaximoValor = null;
            this.txtNroOrden.MinimoValor = null;
            this.txtNroOrden.Name = "txtNroOrden";
            this.txtNroOrden.PosicionText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNroOrden.Size = new System.Drawing.Size(193, 31);
            this.txtNroOrden.TabIndex = 1;
            this.txtNroOrden.Valor = "";
            this.txtNroOrden.TeclaApretada += new Util.Controles.ucSoloNumero.TeclaApretadaEventHandler(this.txtNroOrden_TeclaApretada);
            // 
            // dtpFechaAtencion
            // 
            this.dtpFechaAtencion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpFechaAtencion.Fecha = new System.DateTime(2016, 7, 6, 0, 0, 0, 0);
            this.dtpFechaAtencion.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaAtencion.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaAtencion.Location = new System.Drawing.Point(693, 14);
            this.dtpFechaAtencion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtpFechaAtencion.Name = "dtpFechaAtencion";
            this.dtpFechaAtencion.Size = new System.Drawing.Size(245, 33);
            this.dtpFechaAtencion.TabIndex = 10;
            // 
            // txtPaciente
            // 
            this.txtPaciente.Alto = 31;
            this.txtPaciente.Ancho = 245;
            this.txtPaciente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPaciente.BarraScroll = System.Windows.Forms.ScrollBars.None;
            this.txtPaciente.CharCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPaciente.Disabled = false;
            this.txtPaciente.ErrorMessage = "";
            this.txtPaciente.EsObligatorio = true;
            this.txtPaciente.InvalidateChar = null;
            this.txtPaciente.Location = new System.Drawing.Point(693, 77);
            this.txtPaciente.LongMax = 50;
            this.txtPaciente.LongMin = 0;
            this.txtPaciente.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPaciente.MultiLineas = false;
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Referencia = null;
            this.txtPaciente.Size = new System.Drawing.Size(245, 31);
            this.txtPaciente.TabIndex = 9;
            this.txtPaciente.Valor = "";
            this.txtPaciente.TeclaApretada += new Util.Controles.ucTexto.TeclaApretadaEventHandler(this.txtNroOrden_TeclaApretada);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(621, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Paciente";
            // 
            // ckbFecha
            // 
            this.ckbFecha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ckbFecha.AutoSize = true;
            this.ckbFecha.ForeColor = System.Drawing.Color.White;
            this.ckbFecha.Location = new System.Drawing.Point(536, 20);
            this.ckbFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbFecha.Name = "ckbFecha";
            this.ckbFecha.Size = new System.Drawing.Size(148, 21);
            this.ckbFecha.TabIndex = 6;
            this.ckbFecha.Text = "Fecha de Atención";
            this.ckbFecha.UseVisualStyleBackColor = true;
            this.ckbFecha.CheckedChanged += new System.EventHandler(this.ckbFecha_CheckedChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ucPaginador);
            this.groupBox2.Controls.Add(this.btnActualizar);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 86);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1249, 74);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // ucPaginador
            // 
            this.ucPaginador.CurrentPage = 1;
            this.ucPaginador.Location = new System.Drawing.Point(13, 15);
            this.ucPaginador.Margin = new System.Windows.Forms.Padding(0);
            this.ucPaginador.Name = "ucPaginador";
            this.ucPaginador.PageSize = 10;
            this.ucPaginador.PageTotal = null;
            this.ucPaginador.Size = new System.Drawing.Size(653, 49);
            this.ucPaginador.TabIndex = 4;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Image = global::Bioquimica.Properties.Resources.refresh_small;
            this.btnActualizar.Location = new System.Drawing.Point(1139, 31);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 28);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Image = global::Bioquimica.Properties.Resources.add1;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(1012, 31);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvListado);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1249, 372);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenes";
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
            this.ordenId,
            this.nroOrdenDataGridViewTextBoxColumn,
            this.fechaAtencionDataGridViewTextBoxColumn,
            this.prepagaNombreDataGridViewTextBoxColumn,
            this.pacienteNombreDataGridViewTextBoxColumn,
            this.pacienteDNIDataGridViewTextBoxColumn,
            this.pacienteFechaNacimientoDataGridViewTextBoxColumn,
            this.discriminaIVA,
            this.prepagasDataGridViewTextBoxColumn,
            this.practicasOrdenesDataGridViewTextBoxColumn,
            this.prepagaIdDataGridViewTextBoxColumn,
            this.prepagaStringDataGridViewTextBoxColumn,
            this.ExcDetalle,
            this.ExcEditar,
            this.ExcEliminar});
            this.dgvListado.DataSource = this.ordenBindingSource;
            this.dgvListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListado.Location = new System.Drawing.Point(4, 19);
            this.dgvListado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListado.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListado.RowTemplate.Height = 30;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(1241, 349);
            this.dgvListado.TabIndex = 8;
            this.dgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellContentClick);
            this.dgvListado.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListado_CellFormatting);
            this.dgvListado.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvListado_CellPainting);
            // 
            // prepagaBindingSource
            // 
            this.prepagaBindingSource.DataSource = typeof(Bioquimica.Entidades.Prepaga);
            // 
            // ordenBindingSource
            // 
            this.ordenBindingSource.DataSource = typeof(Bioquimica.Entidades.Orden);
            // 
            // ordenId
            // 
            this.ordenId.DataPropertyName = "OrdenId";
            this.ordenId.HeaderText = "OrdenId";
            this.ordenId.Name = "ordenId";
            this.ordenId.ReadOnly = true;
            this.ordenId.Visible = false;
            // 
            // nroOrdenDataGridViewTextBoxColumn
            // 
            this.nroOrdenDataGridViewTextBoxColumn.DataPropertyName = "NroOrden";
            this.nroOrdenDataGridViewTextBoxColumn.HeaderText = "Nro. Orden";
            this.nroOrdenDataGridViewTextBoxColumn.Name = "nroOrdenDataGridViewTextBoxColumn";
            this.nroOrdenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaAtencionDataGridViewTextBoxColumn
            // 
            this.fechaAtencionDataGridViewTextBoxColumn.DataPropertyName = "FechaAtencion";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.fechaAtencionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.fechaAtencionDataGridViewTextBoxColumn.HeaderText = "Fecha Atención";
            this.fechaAtencionDataGridViewTextBoxColumn.Name = "fechaAtencionDataGridViewTextBoxColumn";
            this.fechaAtencionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prepagaNombreDataGridViewTextBoxColumn
            // 
            this.prepagaNombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prepagaNombreDataGridViewTextBoxColumn.DataPropertyName = "PrepagaNombre";
            this.prepagaNombreDataGridViewTextBoxColumn.HeaderText = "Prepaga";
            this.prepagaNombreDataGridViewTextBoxColumn.Name = "prepagaNombreDataGridViewTextBoxColumn";
            this.prepagaNombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pacienteNombreDataGridViewTextBoxColumn
            // 
            this.pacienteNombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pacienteNombreDataGridViewTextBoxColumn.DataPropertyName = "PacienteNombre";
            this.pacienteNombreDataGridViewTextBoxColumn.HeaderText = "Paciente";
            this.pacienteNombreDataGridViewTextBoxColumn.Name = "pacienteNombreDataGridViewTextBoxColumn";
            this.pacienteNombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pacienteDNIDataGridViewTextBoxColumn
            // 
            this.pacienteDNIDataGridViewTextBoxColumn.DataPropertyName = "PacienteDNI";
            this.pacienteDNIDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.pacienteDNIDataGridViewTextBoxColumn.Name = "pacienteDNIDataGridViewTextBoxColumn";
            this.pacienteDNIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pacienteFechaNacimientoDataGridViewTextBoxColumn
            // 
            this.pacienteFechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "PacienteFechaNacimiento";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.pacienteFechaNacimientoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.pacienteFechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha Nac.";
            this.pacienteFechaNacimientoDataGridViewTextBoxColumn.Name = "pacienteFechaNacimientoDataGridViewTextBoxColumn";
            this.pacienteFechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discriminaIVA
            // 
            this.discriminaIVA.DataPropertyName = "DiscriminaIVA";
            this.discriminaIVA.HeaderText = "Discrimina IVA";
            this.discriminaIVA.Name = "discriminaIVA";
            this.discriminaIVA.ReadOnly = true;
            this.discriminaIVA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.discriminaIVA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // prepagasDataGridViewTextBoxColumn
            // 
            this.prepagasDataGridViewTextBoxColumn.DataPropertyName = "Prepagas";
            this.prepagasDataGridViewTextBoxColumn.HeaderText = "Prepagas";
            this.prepagasDataGridViewTextBoxColumn.Name = "prepagasDataGridViewTextBoxColumn";
            this.prepagasDataGridViewTextBoxColumn.ReadOnly = true;
            this.prepagasDataGridViewTextBoxColumn.Visible = false;
            // 
            // practicasOrdenesDataGridViewTextBoxColumn
            // 
            this.practicasOrdenesDataGridViewTextBoxColumn.DataPropertyName = "PracticasOrdenes";
            this.practicasOrdenesDataGridViewTextBoxColumn.HeaderText = "PracticasOrdenes";
            this.practicasOrdenesDataGridViewTextBoxColumn.Name = "practicasOrdenesDataGridViewTextBoxColumn";
            this.practicasOrdenesDataGridViewTextBoxColumn.ReadOnly = true;
            this.practicasOrdenesDataGridViewTextBoxColumn.Visible = false;
            // 
            // prepagaIdDataGridViewTextBoxColumn
            // 
            this.prepagaIdDataGridViewTextBoxColumn.DataPropertyName = "PrepagaId";
            this.prepagaIdDataGridViewTextBoxColumn.HeaderText = "PrepagaId";
            this.prepagaIdDataGridViewTextBoxColumn.Name = "prepagaIdDataGridViewTextBoxColumn";
            this.prepagaIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.prepagaIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // prepagaStringDataGridViewTextBoxColumn
            // 
            this.prepagaStringDataGridViewTextBoxColumn.DataPropertyName = "PrepagaString";
            this.prepagaStringDataGridViewTextBoxColumn.HeaderText = "PrepagaString";
            this.prepagaStringDataGridViewTextBoxColumn.Name = "prepagaStringDataGridViewTextBoxColumn";
            this.prepagaStringDataGridViewTextBoxColumn.ReadOnly = true;
            this.prepagaStringDataGridViewTextBoxColumn.Visible = false;
            // 
            // ExcDetalle
            // 
            this.ExcDetalle.FillWeight = 92.71886F;
            this.ExcDetalle.HeaderText = "";
            this.ExcDetalle.Name = "ExcDetalle";
            this.ExcDetalle.ReadOnly = true;
            this.ExcDetalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ExcDetalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ExcDetalle.Width = 22;
            // 
            // ExcEditar
            // 
            this.ExcEditar.FillWeight = 91.12937F;
            this.ExcEditar.HeaderText = "";
            this.ExcEditar.Name = "ExcEditar";
            this.ExcEditar.ReadOnly = true;
            this.ExcEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ExcEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ExcEditar.Width = 22;
            // 
            // ExcEliminar
            // 
            this.ExcEliminar.FillWeight = 89.3401F;
            this.ExcEliminar.HeaderText = "";
            this.ExcEliminar.Name = "ExcEliminar";
            this.ExcEliminar.ReadOnly = true;
            this.ExcEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ExcEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ExcEliminar.Width = 22;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBuscar.Image = global::Bioquimica.Properties.Resources.lupa_chica;
            this.btnBuscar.Location = new System.Drawing.Point(1101, 76);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(132, 34);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(995, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Discrimina IVA";
            // 
            // cboDiscriminaIVA
            // 
            this.cboDiscriminaIVA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboDiscriminaIVA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboDiscriminaIVA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboDiscriminaIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiscriminaIVA.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDiscriminaIVA.FormattingEnabled = true;
            this.cboDiscriminaIVA.Location = new System.Drawing.Point(1101, 15);
            this.cboDiscriminaIVA.Margin = new System.Windows.Forms.Padding(4);
            this.cboDiscriminaIVA.Name = "cboDiscriminaIVA";
            this.cboDiscriminaIVA.Size = new System.Drawing.Size(132, 31);
            this.cboDiscriminaIVA.TabIndex = 14;
            // 
            // frmGestionOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 537);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGestionOrdenes";
            this.Text = "Gestión de Ordenes";
            this.Load += new System.EventHandler(this.frmGestionOrdenes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGestionOrdenes_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepagaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvListado;
        private Util.Controles.UcPaginador ucPaginador;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPrepagas;
        private Util.Controles.ucSoloNumero txtNroOrden;
        private System.Windows.Forms.CheckBox ckbFecha;
        private System.Windows.Forms.Label label3;
        private Util.Controles.ucTexto txtPaciente;
        private System.Windows.Forms.BindingSource prepagaBindingSource;
        private Util.Controles.ucDatePicker dtpFechaAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordenId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroOrdenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAtencionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prepagaNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteDNIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteFechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discriminaIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn prepagasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn practicasOrdenesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prepagaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prepagaStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ExcDetalle;
        private System.Windows.Forms.DataGridViewButtonColumn ExcEditar;
        private System.Windows.Forms.DataGridViewButtonColumn ExcEliminar;
        private System.Windows.Forms.BindingSource ordenBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboDiscriminaIVA;
        private System.Windows.Forms.Button btnBuscar;

    }
}