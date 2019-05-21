//Librerías.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing; //Se agrego la librería "System.Drawing".

namespace BolicheStar
{
    class HerramientasExtras
    {
        //Constructor.
        public HerramientasExtras()
        { }

        //Atributo.
        public Color Cola2; //Public: Porque se va a llamar en la forma principal; Color: Porque va a guardar un color puro.

        //Métodos.
        public void AveriguarColor(string color)
        {//Procedimiento que averigua el color que ingreso el usuario y colorea el panel.
         //Necesita 1 parámetro "color".
            switch (color)
            {
                case "Amarillo":
                    Cola2 = Color.Yellow;
                    break;
                case "Anaranjado":
                    Cola2 = Color.Orange;
                    break;
                case "Azul":
                    Cola2 = Color.Blue;
                    break;
                case "Blanco":
                    Cola2 = Color.White;
                    break;
                case "Café":
                    Cola2 = Color.Brown;
                    break;
                case "Celeste":
                    Cola2 = Color.DeepSkyBlue;
                    break;
                case "Dorado":
                    Cola2 = Color.Gold;
                    break;
                case "Gris":
                    Cola2 = Color.Gray;
                    break;
                case "Indigo":
                    Cola2 = Color.MediumSlateBlue;
                    break;
                case "Plateado":
                    Cola2 = Color.Gainsboro;
                    break;
                case "Purpura":
                    Cola2 = Color.Purple;
                    break;
                case "Rojo":
                    Cola2 = Color.Red;
                    break;
                case "Rosado":
                    Cola2 = Color.Pink;
                    break;
                case "Turquesa":
                    Cola2 = Color.Aqua;
                    break;
                case "Verde":
                    Cola2 = Color.Green;
                    break;
                case "Verde Claro":
                    Cola2 = Color.YellowGreen;
                    break;
                case "Violeta":
                    Cola2 = Color.Plum;
                    break;
            }
        }
    }
}