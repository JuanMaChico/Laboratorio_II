using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    16. Crear la clase Alumno de acuerdo al siguiente diagrama:
    Alumno
    Class
      Campos
        nota1       :byte
        nota2       :byte
        notaFinal   :float
        apellido    :string
        legajo      :int
        nombre      :string
      Metodos
        CalcularFinal():void
        Estudiar(byte notaUno, byte notaDos): void
        Mostrar():string
 */
namespace Ejercicio_16
{
    public class Alumno
    {
        private int notaUno;
        private int notaDos;
        private float notaFinal;
        
        public string nombre;
        public string apellido;
        public int legajo;

        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        public void Estudiar(int notaUno, int notaDos)
        {
            this.notaUno = notaUno;
            this.notaDos = notaDos;
        }

        public void CalcularFinal()
        {
            int rndNotaUno = new Random().Next(1,10);
            int rndNotaDos = new Random().Next(1,10);

            Estudiar(rndNotaUno, rndNotaDos);

            if(notaUno >= 4 && notaDos >= 4)
            {
                this.notaFinal = (notaUno + notaDos) / 2 ;
            }
            else
            {
                this.notaFinal = -1;
            }
        }
        public string Mostrar()
        {
            return ($"Alumno: {nombre}, {apellido}\nLegajo: {legajo}\nnota 1 :{notaUno}\nnota 2:{notaDos}\nPromedio Final:{notaFinal}");
        }
    }
}
