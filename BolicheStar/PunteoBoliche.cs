//Librerias.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BolicheStar
{
    class PunteoBoliche
    {
        //Contructor.
        public PunteoBoliche()
        { }

        //Atributos. (Publicos porque se van a utilizar en la forma principal)
        public int GI_punteo = 0;
        //Banderas del 0, del 1 y de la chuza.
        public bool LB_bandera0 = false, LB_bandera1 = false, GB_banderaChuza = false, GB_banderaCastigo = false;

        //Métodos.
        public void cuantosPuntos(int pinos1, int pinos2) //Procedimiento que averigua cuantos pinos se tiraron y calcula el punteo; Necesita 2 parámetro "pinos1" y "pinos2".
        {   //Resetea las banderas.
            LB_bandera0 = false; LB_bandera1 = false; GB_banderaChuza = false; GB_banderaCastigo = false;
            switch (pinos1) //Evalua el primer tiro.
            {
                case 0:
                    {
                        LB_bandera0 = true;
                    }
                    break;
                case 1:
                    {
                        LB_bandera1 = true;
                        GI_punteo += 1;
                    }
                    break;

                case 2:
                    {
                        GI_punteo += 2;
                    }
                    break;

                case 3:
                    {
                        GI_punteo += 3;
                    }
                    break;
                case 4:
                    {
                        GI_punteo += 4;
                    }
                    break;
                case 5:
                    {
                        GI_punteo += 5;
                    }
                    break;
                case 6:
                    {
                        GI_punteo += 6;
                    }
                    break;
                case 7:
                    {
                        GI_punteo += 7;
                    }
                    break;
                case 8:
                    {
                        GI_punteo += 8;
                    }
                    break;
                case 9:
                    {
                        GI_punteo += 9;
                    }
                    break;
                case 10:
                    {
                        GI_punteo += 10;
                        //Activa el punto extra; Activa la bandera de la chuza.
                        GB_banderaChuza = true;
                    }
                    break;
            }
            switch (pinos2) //Evalua el segundo tiro.
            {
                case 0:
                    {
                        if (LB_bandera0 == true || LB_bandera1 == true) //Verifica la bandera del 0 y del 1.
                        {//Significa que como en el segundo tiro no derrivo ninguno, tiene castigo.
                            GB_banderaCastigo = true;
                        }
                    }
                    break;
                case 1:
                    {
                        if (LB_bandera0 == true) //Verifica la bandera del 0.
                        {//Significa que como en primer tiro no derrivo ninguno y en el segundo tiro solo derrivo uno, tiene castigo.
                            GB_banderaCastigo = true;
                        }
                        GI_punteo += 1;
                    }
                    break;

                case 2:
                    {
                        GI_punteo += 2;
                    }
                    break;

                case 3:
                    {
                        GI_punteo += 3;
                    }
                    break;
                case 4:
                    {
                        GI_punteo += 4;
                    }
                    break;
                case 5:
                    {
                        GI_punteo += 5;
                    }
                    break;
                case 6:
                    {
                        GI_punteo += 6;
                    }
                    break;
                case 7:
                    {
                        GI_punteo += 7;
                    }
                    break;
                case 8:
                    {
                        GI_punteo += 8;
                    }
                    break;
                case 9:
                    {
                        GI_punteo += 9;
                    }
                    break;
                case 10:
                    {
                        GI_punteo += 10;
                    }
                    break;
            }
        }

        public void cuantosExtra(int pinos) //Procedimiento que averigua cuantos pinos se tiraron en el tiro extra y calcula el punteo.
        {
            switch (pinos)
            {
                case 1:
                    {
                        GI_punteo += 1;
                    }
                    break;

                case 2:
                    {
                        GI_punteo += 2;
                    }
                    break;

                case 3:
                    {
                        GI_punteo += 3;
                    }
                    break;
                case 4:
                    {
                        GI_punteo += 4;
                    }
                    break;
                case 5:
                    {
                        GI_punteo += 5;
                    }
                    break;
                case 6:
                    {
                        GI_punteo += 6;
                    }
                    break;
                case 7:
                    {
                        GI_punteo += 7;
                    }
                    break;
                case 8:
                    {
                        GI_punteo += 8;
                    }
                    break;
                case 9:
                    {
                        GI_punteo += 9;
                    }
                    break;
                case 10:
                    {
                        GI_punteo += 10;
                    }
                    break;
            }
        }
    }
}