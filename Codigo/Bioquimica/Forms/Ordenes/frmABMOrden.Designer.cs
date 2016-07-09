namespace Bioquimica.Forms.Ordenes
{
    partial class frmABMOrden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABMOrden));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbxPracticas = new System.Windows.Forms.GroupBox();
            this.cboCodigos = new System.Windows.Forms.ComboBox();
            this.cboPracticas = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.PracticaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Practica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExcEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.chxDiscriminaIVA = new Telerik.WinControls.UI.RadCheckBox();
            this.cboPrepaga = new Util.Controles.ucDropDownList();
            this.dtpFechaAtencion = new Util.Controles.ucDatePicker();
            this.dtpFechaNacimiento = new Util.Controles.ucDatePicker();
            this.txtNroOrden = new Util.Controles.ucSoloNumero();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDNI = new Util.Controles.ucSoloNumero();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.prepagaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.gbxPracticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.pnlControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chxDiscriminaIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepagaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(633, 769);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(184, 41);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.gbxPracticas);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.pnlControles);
            this.groupBox1.Controls.Add(this.lblTitulo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(833, 827);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // gbxPracticas
            // 
            this.gbxPracticas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxPracticas.Controls.Add(this.cboCodigos);
            this.gbxPracticas.Controls.Add(this.cboPracticas);
            this.gbxPracticas.Controls.Add(this.lblTotal);
            this.gbxPracticas.Controls.Add(this.label4);
            this.gbxPracticas.Controls.Add(this.btnAgregar);
            this.gbxPracticas.Controls.Add(this.dgvListado);
            this.gbxPracticas.Enabled = false;
            this.gbxPracticas.Location = new System.Drawing.Point(0, 376);
            this.gbxPracticas.Margin = new System.Windows.Forms.Padding(4);
            this.gbxPracticas.Name = "gbxPracticas";
            this.gbxPracticas.Padding = new System.Windows.Forms.Padding(4);
            this.gbxPracticas.Size = new System.Drawing.Size(828, 374);
            this.gbxPracticas.TabIndex = 16;
            this.gbxPracticas.TabStop = false;
            this.gbxPracticas.Text = "Prácticas";
            // 
            // cboCodigos
            // 
            this.cboCodigos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCodigos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCodigos.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCodigos.FormattingEnabled = true;
            this.cboCodigos.Location = new System.Drawing.Point(23, 45);
            this.cboCodigos.Margin = new System.Windows.Forms.Padding(4);
            this.cboCodigos.Name = "cboCodigos";
            this.cboCodigos.Size = new System.Drawing.Size(143, 31);
            this.cboCodigos.TabIndex = 8;
            this.cboCodigos.SelectedIndexChanged += new System.EventHandler(this.cboCodigos_SelectedIndexChanged);
            this.cboCodigos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboCodigos_KeyUp);
            // 
            // cboPracticas
            // 
            this.cboPracticas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboPracticas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboPracticas.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPracticas.FormattingEnabled = true;
            this.cboPracticas.Location = new System.Drawing.Point(175, 45);
            this.cboPracticas.Margin = new System.Windows.Forms.Padding(4);
            this.cboPracticas.Name = "cboPracticas";
            this.cboPracticas.Size = new System.Drawing.Size(484, 31);
            this.cboPracticas.TabIndex = 9;
            this.cboPracticas.SelectedIndexChanged += new System.EventHandler(this.cboPracticas_SelectedIndexChanged);
            this.cboPracticas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboPracticas_KeyUp);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(653, 326);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(125, 33);
            this.lblTotal.TabIndex = 42;
            this.lblTotal.Text = "$0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(555, 326);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 29);
            this.label4.TabIndex = 41;
            this.label4.Text = "TOTAL:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::Bioquimica.Properties.Resources.add1;
            this.btnAgregar.Location = new System.Drawing.Point(702, 45);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 34);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.AllowUserToOrderColumns = true;
            this.dgvListado.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListado.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListado.ColumnHeadersHeight = 31;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PracticaId,
            this.Codigo,
            this.Practica,
            this.UB,
            this.SubTotal,
            this.ExcEliminar});
            this.dgvListado.Location = new System.Drawing.Point(21, 98);
            this.dgvListado.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListado.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListado.RowTemplate.Height = 30;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(796, 210);
            this.dgvListado.TabIndex = 9;
            this.dgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellContentClick);
            this.dgvListado.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvListado_CellPainting);
            // 
            // PracticaId
            // 
            this.PracticaId.HeaderText = "PracticaId";
            this.PracticaId.Name = "PracticaId";
            this.PracticaId.ReadOnly = true;
            this.PracticaId.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 70;
            // 
            // Practica
            // 
            this.Practica.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Practica.HeaderText = "Descripción";
            this.Practica.Name = "Practica";
            this.Practica.ReadOnly = true;
            // 
            // UB
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.UB.DefaultCellStyle = dataGridViewCellStyle3;
            this.UB.HeaderText = "UB";
            this.UB.Name = "UB";
            this.UB.ReadOnly = true;
            this.UB.Width = 75;
            // 
            // SubTotal
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.SubTotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
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
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.Location = new System.Drawing.Point(427, 769);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(185, 41);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // pnlControles
            // 
            this.pnlControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControles.Controls.Add(this.chxDiscriminaIVA);
            this.pnlControles.Controls.Add(this.cboPrepaga);
            this.pnlControles.Controls.Add(this.dtpFechaAtencion);
            this.pnlControles.Controls.Add(this.dtpFechaNacimiento);
            this.pnlControles.Controls.Add(this.txtNroOrden);
            this.pnlControles.Controls.Add(this.label5);
            this.pnlControles.Controls.Add(this.label3);
            this.pnlControles.Controls.Add(this.label2);
            this.pnlControles.Controls.Add(this.label1);
            this.pnlControles.Controls.Add(this.txtDNI);
            this.pnlControles.Controls.Add(this.txtNombre);
            this.pnlControles.Controls.Add(this.label26);
            this.pnlControles.Controls.Add(this.label17);
            this.pnlControles.Location = new System.Drawing.Point(-3, 59);
            this.pnlControles.Margin = new System.Windows.Forms.Padding(4);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(835, 291);
            this.pnlControles.TabIndex = 15;
            // 
            // chxDiscriminaIVA
            // 
            this.chxDiscriminaIVA.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.chxDiscriminaIVA.Location = new System.Drawing.Point(420, 235);
            this.chxDiscriminaIVA.Name = "chxDiscriminaIVA";
            this.chxDiscriminaIVA.Size = new System.Drawing.Size(135, 26);
            this.chxDiscriminaIVA.TabIndex = 7;
            this.chxDiscriminaIVA.Text = "Discrimina IVA";
            this.chxDiscriminaIVA.Visible = false;
            // 
            // cboPrepaga
            // 
            this.cboPrepaga.Alto = 34;
            this.cboPrepaga.Ancho = 285;
            this.cboPrepaga.AutoCompletar = System.Windows.Forms.AutoCompleteMode.None;
            this.cboPrepaga.DataSource = null;
            this.cboPrepaga.DisplayMember = "Nombre";
            this.cboPrepaga.DropDownHeight = 106;
            this.cboPrepaga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrepaga.ErrorMessage = "";
            this.cboPrepaga.EsObligatorio = true;
            this.cboPrepaga.InvalidateChar = null;
            this.cboPrepaga.Location = new System.Drawing.Point(421, 183);
            this.cboPrepaga.Margin = new System.Windows.Forms.Padding(5);
            this.cboPrepaga.MaxDroppItems = 8;
            this.cboPrepaga.Name = "cboPrepaga";
            this.cboPrepaga.Referencia = null;
            this.cboPrepaga.Size = new System.Drawing.Size(285, 34);
            this.cboPrepaga.TabIndex = 6;
            this.cboPrepaga.Valor = 0;
            this.cboPrepaga.ValueMember = "PrepagaId";
            this.cboPrepaga.ComboSelectedIndexChanged += new System.EventHandler(this.cboPrepaga_ComboSelectedIndexChanged);
            // 
            // dtpFechaAtencion
            // 
            this.dtpFechaAtencion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtpFechaAtencion.Fecha = new System.DateTime(2016, 7, 6, 0, 0, 0, 0);
            this.dtpFechaAtencion.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaAtencion.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaAtencion.Location = new System.Drawing.Point(421, 110);
            this.dtpFechaAtencion.Margin = new System.Windows.Forms.Padding(5);
            this.dtpFechaAtencion.Name = "dtpFechaAtencion";
            this.dtpFechaAtencion.Size = new System.Drawing.Size(285, 33);
            this.dtpFechaAtencion.TabIndex = 5;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtpFechaNacimiento.Fecha = new System.DateTime(2016, 7, 6, 0, 0, 0, 0);
            this.dtpFechaNacimiento.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaNacimiento.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(421, 37);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(5);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(285, 33);
            this.dtpFechaNacimiento.TabIndex = 4;
            // 
            // txtNroOrden
            // 
            this.txtNroOrden.AceptaDecimales = false;
            this.txtNroOrden.Disabled = false;
            this.txtNroOrden.ErrorMessage = "";
            this.txtNroOrden.EsObligatorio = true;
            this.txtNroOrden.Location = new System.Drawing.Point(23, 37);
            this.txtNroOrden.LongMax = 8;
            this.txtNroOrden.LongMin = 0;
            this.txtNroOrden.Margin = new System.Windows.Forms.Padding(5);
            this.txtNroOrden.MaximoValor = null;
            this.txtNroOrden.MinimoValor = null;
            this.txtNroOrden.Name = "txtNroOrden";
            this.txtNroOrden.PosicionText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNroOrden.Size = new System.Drawing.Size(317, 31);
            this.txtNroOrden.TabIndex = 1;
            this.txtNroOrden.Valor = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(17, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 23);
            this.label5.TabIndex = 40;
            this.label5.Text = "Nro. de Orden";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(416, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 38;
            this.label3.Text = "Prepaga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(416, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 23);
            this.label2.TabIndex = 36;
            this.label2.Text = "Fecha de atención";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(416, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 34;
            this.label1.Text = "Fecha de nacimiento";
            // 
            // txtDNI
            // 
            this.txtDNI.AceptaDecimales = false;
            this.txtDNI.Disabled = false;
            this.txtDNI.ErrorMessage = "";
            this.txtDNI.EsObligatorio = true;
            this.txtDNI.Location = new System.Drawing.Point(23, 183);
            this.txtDNI.LongMax = 8;
            this.txtDNI.LongMin = 0;
            this.txtDNI.Margin = new System.Windows.Forms.Padding(5);
            this.txtDNI.MaximoValor = null;
            this.txtDNI.MinimoValor = null;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.PosicionText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDNI.Size = new System.Drawing.Size(317, 31);
            this.txtDNI.TabIndex = 3;
            this.txtDNI.Valor = "";
            this.txtDNI.Cambio += new Util.Controles.ucSoloNumero.CambioEventHandler(this.txtDNI_Cambio);
            // 
            // txtNombre
            // 
            this.txtNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(23, 110);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MaxLength = 250;
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(317, 30);
            this.txtNombre.TabIndex = 2;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(19, 156);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(36, 23);
            this.label26.TabIndex = 31;
            this.label26.Text = "DNI";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(17, 81);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(149, 23);
            this.label17.TabIndex = 28;
            this.label17.Text = "Apellido y Nombre";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitulo.Location = new System.Drawing.Point(8, 20);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(84, 35);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Orden";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // prepagaBindingSource
            // 
            this.prepagaBindingSource.DataSource = typeof(Bioquimica.Entidades.Prepaga);
            // 
            // frmABMOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 827);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmABMOrden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenes";
            this.Load += new System.EventHandler(this.frmABMOrden_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxPracticas.ResumeLayout(false);
            this.gbxPracticas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.pnlControles.ResumeLayout(false);
            this.pnlControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chxDiscriminaIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepagaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.BindingSource prepagaBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Util.Controles.ucSoloNumero txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gbxPracticas;
        private System.Windows.Forms.DataGridView dgvListado;
        private Util.Controles.ucSoloNumero txtNroOrden;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregar;
        private Util.Controles.ucDropDownList cboPrepaga;
        private Util.Controles.ucDatePicker dtpFechaAtencion;
        private Util.Controles.ucDatePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboPracticas;
        private System.Windows.Forms.ComboBox cboCodigos;
        private System.Windows.Forms.DataGridViewTextBoxColumn PracticaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Practica;
        private System.Windows.Forms.DataGridViewTextBoxColumn UB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn ExcEliminar;
        private Telerik.WinControls.UI.RadCheckBox chxDiscriminaIVA;
    }
}