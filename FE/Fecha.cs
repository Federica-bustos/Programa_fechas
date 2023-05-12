using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FE
{
    internal class Fecha
    {
        int dia { get; set; }
        int mes { get; set; }
        int ano { get; set; }
         

     

        public Fecha(int dia, int mes, int ano) { 
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }
        //creo un método que recibe como único parámetro una variable de tipo Fecha y devuelve
        //un string en la variable resultado
        public string MostrarFecha(Fecha fecha) {
            string resultado = "";
            string mesString = "";

            //Usamos switch cuando tenemos mas de una opción para cada valor
            //Recibimos un parámetro, y por cada valor de ese parametro va hacer algo
            //diferente para cada situación u opción
            
            switch (fecha.mes)
            {
                case 01:
                    mesString = "Enero";
                    break;
                case 02:
                    mesString = "Febrero";
                    break;
                case 03:
                    mesString = "Marzo";
                    break;
                case 04:
                    mesString = "Abril";
                    break;
                case 05:
                    mesString = "Mayo";
                    break;
                case 06:
                    mesString = "Junio";
                    break;
                case 07:
                    mesString = "Julio";
                    break;
                case 08:
                    mesString = "Agosto";
                    break;
                case 09:
                    mesString = "Septiembre";
                    break;
                case 10:
                    mesString = "Octubre";
                    break;
                case 11:
                    mesString = "Nobiembre";
                    break;
                case 12:
                    mesString = "Diciembre";
                    break;

            }
            resultado = (dia + 1) + " de " + mesString + " de " + ano;  
            return resultado;
        }
       
    }
}
