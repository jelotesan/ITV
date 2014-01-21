using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomTextbox.Textbox
{
    public partial class CustomTextbox : TextBox
    {
        public CustomTextbox()
        {
            InitializeComponent();
            this.GotFocus += new System.EventHandler(this.CustomTextbox_GotFocus);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomTextbox_KeyPress);
            _maxLong = 255;
        }

        public enum tipo_caracteres { Entero, Decimal, Texto, Fecha};
        public enum colores { Amarillo, Verde, Azul, Rojo, Morado };

        private tipo_caracteres _tipoC;
        private String _columna, _tabla;
        private Boolean _cambioColor;
        private colores _color;
        private int _maxLong;

        public colores SeleccionarColorFocus { // Selecciona el color que adoptara
            get {return _color;}
            set {_color = value;}
        }

        public Boolean ModificarColorFocus { // Activa o desactiva la funcion de cambiar de color
            get {return _cambioColor;}
            set {_cambioColor = value;}
        }

        public tipo_caracteres CaracterPermitido { // Tipo de caracter que perimite el textbox
            get {return _tipoC;} 
            set {_tipoC = value;} 
        }

        public String DBColumna { // Columna de la base de datos al que hace referencia
            get {return _columna;}
            set {_columna = value;}
        }

        public String DBTabla { // Tabla de la base de datos al que hace referencia
            get {return _tabla;}
            set {_tabla = value;}
        }

        public int LongitudMaxima { // Indicamos la longitud maxima que tendra el textbox
            get { return _maxLong; }
            set { _maxLong = value; }
        }

        private void CustomTextbox_GotFocus(Object sender, EventArgs e) { // Colores: Amarillo, Verde, Azul, Rojo, Morado
            if (_cambioColor == true)
            {
                if (_color == colores.Azul) this.BackColor = Color.Aqua; //Color Azul
                else if (_color == colores.Amarillo) this.BackColor = Color.LightYellow; // Color Amarilo
                else if (_color == colores.Morado) this.BackColor = Color.LightPink;// Color Morado
                else if (_color == colores.Rojo) this.BackColor = Color.Salmon;// Color Rojo
                else if (_color == colores.Verde) this.BackColor = Color.LightGreen;// Color Verde
            }
        }

        private void CustomTextbox_KeyPress(Object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (this.Text.Length < _maxLong)
            {
                switch (this._tipoC){
                    case tipo_caracteres.Entero:
                        if ((Char.IsNumber(e.KeyChar)) || (Asc((e.KeyChar).ToString()) == 8)) e.Handled = false; else e.Handled = true;
                        break;
                    case tipo_caracteres.Decimal:
                        char caracter = e.KeyChar;
                        if (Validar(ref caracter)){
                            e.KeyChar = caracter;
                            e.Handled = false;
                        }else{
                            e.KeyChar = caracter;
                            e.Handled = true;
                        }
                        break;
                    case tipo_caracteres.Texto:
                        e.Handled = false;
                        break;
                }
            }else{
                if ((Asc((e.KeyChar).ToString()) == 8)) e.Handled = false;
                else e.Handled = true;
            }
        }

        private Boolean Validar(ref char caracter)
        {
            if (InStr("0123456789", caracter)) return true;
            if ((caracter.Equals(',')) && (!InStr(this.Text, ',')) && (this.Text.Length > 0) && !(this.SelectionStart == 0)) return true;
            if ((caracter.Equals('.')) && (!InStr(this.Text, ',')) && (this.Text.Length > 0) && !(this.SelectionStart == 0))
            {
                caracter = ',';
                return true;
            }
            if (Asc(caracter.ToString()) == 8) return true;
            return false;
        }        

       public Boolean InStr(String cadena, char perTrobar)
       {
           if (cadena.IndexOf(perTrobar) < 0) return false;
           else return true;
       }

        private int Asc(string s) { return Encoding.ASCII.GetBytes(s)[0]; }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
