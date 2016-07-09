using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Util.Controles
{
    public partial class ucDropDownList : UserControl
    {
        public ucDropDownList()
        {
            InvalidateChar = null;
            InitializeComponent();
            combo.SelectedIndexChanged += this.HandleSelectedIndexChanged;
            combo.TabIndex = this.TabIndex;
        }

        private string MsjError = "";
        private bool Obligatorio = true;

        public delegate void TeclaApretadaEventHandler(Keys tecla);
        private TeclaApretadaEventHandler TeclaApretadaEvent;

        public event TeclaApretadaEventHandler TeclaApretada
        {
            add
            {
                TeclaApretadaEvent = (TeclaApretadaEventHandler)System.Delegate.Combine(TeclaApretadaEvent, value);
            }
            remove
            {
                TeclaApretadaEvent = (TeclaApretadaEventHandler)System.Delegate.Remove(TeclaApretadaEvent, value);
            }
        }

        public ComboBox InnerCombo
        {
            get { return combo; }
        }


        public string InvalidateChar { get; set; }

        /// <summary>
        /// Esto hace referencia al atributo o etiqueta ej. Domicilio -> Referencia
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string Referencia { get; set; }

        public int MaxDroppItems
        {
            get { return combo.MaxDropDownItems;}
            set { combo.MaxDropDownItems=value; }
        }
        
        public AutoCompleteMode AutoCompletar
        {
            get
            {
                return combo.AutoCompleteMode;
            }
            set
            {
                combo.AutoCompleteMode = value;
            }
        }

        public int Alto
        {
            get
            {
                return this.Height;
            }
            set
            {
                this.Height = value;
            }
        }

        public event EventHandler ComboSelectedIndexChanged;
        private void HandleSelectedIndexChanged(object sender, EventArgs e)
        {
            this.OnSelectedIndexChanged(EventArgs.Empty);
        }

        protected virtual void OnSelectedIndexChanged(EventArgs e)
        {
            EventHandler handler = this.ComboSelectedIndexChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }


        public int Ancho
        {
            get
            {
                return this.Width;
            }
            set
            {
                this.Width = value;
            }
        }

        public int Valor
        {
            get
            {
                if (combo.DropDownStyle == ComboBoxStyle.DropDown)
                {
                    if (combo.SelectedValue == null && !string.IsNullOrEmpty(combo.Text))
                    {
                        var listado = combo.Items.Cast<IComboBoxDataSourceItem>().ToList();
                        var item = listado.FirstOrDefault(i => i.GetText() == combo.Text);
                        if (item != null)
                        {
                            combo.SelectedValue = item.GetValue();
                        }
                    }
                }
                if (combo.SelectedValue == null)
                    return 0;
                int result = 0;
                int.TryParse(combo.SelectedValue.ToString(), out result);
                return result;
            }
            set
            {
                combo.SelectedValue = value;
            }
        }

        public bool EsObligatorio
        {
            get
            {
                return Obligatorio;
            }
            set
            {
                Obligatorio = value;
            }
        }
       
        public string ErrorMessage
        {
            get
            {
                return MsjError;
            }
            set
            {
                MsjError = value;
            }
        }

        public string DisplayMember
        {
            get
            {
                return combo.DisplayMember;
            }
            set
            {
                combo.DisplayMember = value;
            }
        }

        public string ValueMember
        {
            get
            {
                return combo.ValueMember;
            }
            set
            {
                combo.ValueMember = value;
            }
        }

        public object DataSource
        {
            get
            {
                return combo.DataSource;
            }
            set
            {
                combo.DataSource = value;
            }
        }

        public ComboBoxStyle DropDownStyle
        {
            get { return combo.DropDownStyle; }
            set { combo.DropDownStyle = value; }
        }

        public int DropDownHeight
        {
            get { return combo.DropDownHeight; }
            set { combo.DropDownHeight = value; }
        }

        new public void Focus()
        {
            combo.Focus();
            combo.Select();
        }

        public void Reiniciar()
        {
            combo.SelectedValue = null;
        }

        /// <summary>
        /// Esta funcion verifica que sea valido los datso del control
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool Valido()
        {
            if (EsObligatorio && Valor == 0)
            {
               ErrorMessage = "Este campo es requerido";
               return false;
            }
            return true;
        }

        private void ucDropDownList_Enter(object sender, EventArgs e)
        {
            if (combo.DropDownStyle == ComboBoxStyle.DropDown)
            {
                combo.DroppedDown = false;
            }
        }

        private void combo_KeyDown(object sender, KeyEventArgs e)
        {
            if (TeclaApretadaEvent != null)
                TeclaApretadaEvent(e.KeyCode);
        }
    }
}
