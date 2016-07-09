namespace Bioquimica.Forms.Practicas
{
    partial class frmDetallePractica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetallePractica));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.txtCodigo = new Util.Controles.ucSoloNumero();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUB = new Util.Controles.ucDecimal();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNomenclador = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.pnlControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.pnlControles);
            this.groupBox1.Controls.Add(this.lblTitulo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 334);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.Location = new System.Drawing.Point(265, 289);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(139, 33);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // pnlControles
            // 
            this.pnlControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControles.Controls.Add(this.txtCodigo);
            this.pnlControles.Controls.Add(this.label1);
            this.pnlControles.Controls.Add(this.txtUB);
            this.pnlControles.Controls.Add(this.txtDescripcion);
            this.pnlControles.Controls.Add(this.txtNomenclador);
            this.pnlControles.Controls.Add(this.label26);
            this.pnlControles.Controls.Add(this.label25);
            this.pnlControles.Controls.Add(this.label17);
            this.pnlControles.Location = new System.Drawing.Point(-2, 48);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(414, 227);
            this.pnlControles.TabIndex = 15;
            // 
            // txtCodigo
            // 
            this.txtCodigo.AceptaDecimales = false;
            this.txtCodigo.Disabled = false;
            this.txtCodigo.ErrorMessage = "";
            this.txtCodigo.EsObligatorio = true;
            this.txtCodigo.Location = new System.Drawing.Point(20, 34);
            this.txtCodigo.LongMax = 8;
            this.txtCodigo.LongMin = 0;
            this.txtCodigo.MaximoValor = null;
            this.txtCodigo.MinimoValor = null;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PosicionText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigo.Size = new System.Drawing.Size(145, 25);
            this.txtCodigo.TabIndex = 34;
            this.txtCodigo.Valor = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Código";
            // 
            // txtUB
            // 
            this.txtUB.Disabled = false;
            this.txtUB.ErrorMessage = "";
            this.txtUB.EsObligatorio = true;
            this.txtUB.Location = new System.Drawing.Point(20, 188);
            this.txtUB.LongMax = 32767;
            this.txtUB.LongMin = 0;
            this.txtUB.MaxValue = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.txtUB.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtUB.Name = "txtUB";
            this.txtUB.PosicionText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUB.ReadOnly = false;
            this.txtUB.Size = new System.Drawing.Size(129, 26);
            this.txtUB.TabIndex = 32;
            this.txtUB.TextboxTabIndex = 0;
            this.txtUB.Valor = null;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(20, 85);
            this.txtDescripcion.MaxLength = 250;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(353, 25);
            this.txtDescripcion.TabIndex = 1;
            // 
            // txtNomenclador
            // 
            this.txtNomenclador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomenclador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomenclador.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomenclador.Location = new System.Drawing.Point(20, 138);
            this.txtNomenclador.MaxLength = 250;
            this.txtNomenclador.Multiline = true;
            this.txtNomenclador.Name = "txtNomenclador";
            this.txtNomenclador.Size = new System.Drawing.Size(353, 25);
            this.txtNomenclador.TabIndex = 2;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(16, 112);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(91, 20);
            this.label26.TabIndex = 31;
            this.label26.Text = "Nomenclador";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(16, 164);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(27, 20);
            this.label25.TabIndex = 30;
            this.label25.Text = "UB";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(16, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 20);
            this.label17.TabIndex = 28;
            this.label17.Text = "Descripción";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitulo.Location = new System.Drawing.Point(6, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(84, 29);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Práctica";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDetallePractica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 334);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDetallePractica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle Práctica";
            this.Load += new System.EventHandler(this.frmDetallePrepaga_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlControles.ResumeLayout(false);
            this.pnlControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel pnlControles;
        private Util.Controles.ucDecimal txtUB;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNomenclador;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Util.Controles.ucSoloNumero txtCodigo;
        private System.Windows.Forms.Label label1;
    }
}