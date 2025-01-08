using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{

    
    public enum TipoGenero { Masculino = 0, Femenino = 1}
    public enum Paises { España, Suiza, Inglaterra, Italia, Grecia}
    public class Persona
    {
        public Persona()
        {
            Debug.WriteLine("Constructor vacío Persona");
            this.Domicilio = new Direccion();
        }

        public Persona(string nombre, string apellido) 
        {
            Debug.WriteLine("Constructor PERSONA 2 parámetros");
            this.Nombre = nombre;
            this.Apellidos = apellido;
        }
        #region PROPIEDADES

        private string _DescripcionThis;
        public string this[int indice]
        {
            get { return this._DescripcionThis; }
            set {
                Random random = new Random();
                int aleat = random.Next(1, 20);
                this._DescripcionThis = "Descripcion " + aleat;
            }
        }
        public Direccion Domicilio { get; set; }
        public Direccion DomicilioVacaciones { get; set; }

        private TipoGenero _Genero;
        public TipoGenero Genero
        {
            get { return this._Genero; }
            set
            {
                if (value != TipoGenero.Masculino &&
                    value != TipoGenero.Femenino)
                {
                    throw new Exception("Valor de género incorrecto");
                }
                else
                {
                    this._Genero = value;
                }
            }
        }
        public Paises Nacionalidad { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        private int _Edad;

        public int Edad
        {
            get { return this._Edad; }
            set
            {
                if (value < 0)
                {
                    this._Edad = 0;
                    //throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    this._Edad = value;
                }
            }
        }


        #endregion

        #region METODOS
        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }
        public string GetNombreCompleto(int order)
        {
            return this.Apellidos + " " + this.Nombre;
        }

        public string GetNombreCompleto(bool mayusculas)
        {
            if(mayusculas == true)
            {
                return this.Nombre.ToUpper() + " " + this.Apellidos.ToUpper();
            }
            else
            {
                return (this.Nombre + " " + this.Apellidos).ToLower();
            }
            
        }

        #endregion
    }

}
