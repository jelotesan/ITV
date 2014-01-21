using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomComboBox
{
    public partial class CustomComboBox : ComboBox
    {
        private String _tabla, _columna;
        private Boolean _rellenar;

        public CustomComboBox()
        {
            InitializeComponent();
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public String DBTabla
        {
            get{return _tabla;}
            set{_tabla = value;}
        }

        public String DBColumna
        {
            get{return _columna;}
            set{_columna = value;}
        }

        public Boolean AutoRellenar
        {
            get{return _rellenar;}
            set{_rellenar = value; }
        }
    }
}
