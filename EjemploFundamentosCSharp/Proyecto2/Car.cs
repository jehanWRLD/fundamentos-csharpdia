using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace Proyecto2
{
    public class Car
    {
        //Atributos del carro
        string color;
        int cilidraje;
        int modelo;

        //Metodo
        public string stop()
        {
            string msj = "El carro esta detenido";
            return msj;
        }
    }
}