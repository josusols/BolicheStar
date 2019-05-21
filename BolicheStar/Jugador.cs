//Librerias.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing; //Se agrego la librería "System.Drawing".

namespace BolicheStar
{
    class Jugador
    {
        //Constructor.
        public Jugador()
        { }

        //Atributos. (Publicos porque se van a utilizar en la forma principal)
        public string GS_Nombre = ""; //Almacena el nombre del jugador.
        public string GS_Color = ""; //Almacena el nombre del color del jugador.
        public Color GC_ColorPuro = Color.Empty; //Almacena el color puro del jugador.
        public int GI_Turnos = 0; //Contador de los turnos realizados por el jugador.
        public int GI_turnosRestantes = 10; //Contador de los turnos restantes del jugador.
        public int GI_Limite = 10; //Limite de turnos, por default son 10.
        public int GI_PuntosFinales = 0; //Es la puntuación final del jugador.
        public int GI_ChuzasTotales = 0; //Total de chuzas realizadas.
        public int GI_SparesTotales = 0; //Total de spares realizados.
        public int GI_CastigosTotales = 0; //Total de castigos realizados.
    }
}
