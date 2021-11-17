using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DespertadorNET
{
    //clase qu sirve para optimisar busquedas
    class CNodo
    {
        bool activo;
        public CNodo(string s)
        {
            dato = s;
            activo = true;
        }
        CNodo izquerdo, derecho;
        string dato;
        public bool Buscar(string s)
        {
            //verifica si ya existe la cadena
            // si no existe la agrega y regresa false
            // si existe regrea true
            if (dato == s)
            {
                if (activo == true)
                    return true;
                else
                {
                    activo = true;
                    return false;
                }
            }
            if (s.CompareTo( dato)<0)
            {
                if (izquerdo == null)
                {
                    izquerdo = new CNodo(s);
                    return false;
                }
                return izquerdo.Buscar(s);
            }
            if (derecho == null)
            {
                derecho = new CNodo(s);
                return false;
            }
            return derecho.Buscar(s);
        }
        public bool Borra(string s)
        {
            if (dato == s)
            {
                activo = false;
                return true;
            }
            if (izquerdo != null)
            {
                if (izquerdo.Borra(s) == false)
                {
                    if (derecho != null)
                    {
                        derecho.Borra(s);
                    }
                }
            }
            return false;
        }
    }

}
