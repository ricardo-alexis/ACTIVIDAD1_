using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema01
{
    class VIewModel
    {
        public static string NombrePasado;
        public static string ApellidoPasado;
        public static string FechaPasado;
        public static string EdadPasado;
        public static string SexoPasado;
        public static string TelefonoPasado;
        public static string CorreoPasado;
        public static string EstadoPasado;
        public static string MunicipioPasado;
        

        public static void DisparaConsultaDato()
        {
            Model.ConsultaDato();
            NombrePasado = Model.Nombre;
            ApellidoPasado = Model.Apellido;
            FechaPasado = Model.Fecha;
            EdadPasado = Model.Edad;
            SexoPasado = Model.Sexo;
            TelefonoPasado = Model.Telefono;
            CorreoPasado = Model.Correo;
            EstadoPasado = Model.Estado;
            MunicipioPasado = Model.Municipio;


        }
    }
}
