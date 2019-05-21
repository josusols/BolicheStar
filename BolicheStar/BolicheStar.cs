//Librerías.
//Se agrego a la solución, referencias: "System.Speech".
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Recognition; //Se agrego la librería "System.Speech.Recognition".


namespace BolicheStar
{
    public partial class BolicheStar : Form
    {
        public BolicheStar()
        {
            InitializeComponent();
        }

        //Form, Clases y Objetos Inicializados.
        ChuzaTiroExtra Tirar = new ChuzaTiroExtra();
        HerramientasExtras H_extra = new HerramientasExtras();
        PunteoBoliche Puntos = new PunteoBoliche();
        SpeechRecognitionEngine escucha = new SpeechRecognitionEngine(); //Objeto con el que la computadora podra reconocer lo que decimos.

        //MÉTODOS. (INICIO)
        public void LimpiarAfterAgregar() //Método que limpia el TextBox y el ComboBox despues de ingresar a un jugador.
        {
            TB_nombre.Text = "";
            CB_color.Text = "";
        }

        public void RegistroJugador1() //Método que hace el registro del jugador 1.
        {
            //Guarda la información del Form en el objeto J1.
            Program.J1.GS_Nombre = TB_nombre.Text;
            Program.J1.GS_Color = CB_color.SelectedItem.ToString();
            Program.J1.GC_ColorPuro = H_extra.Cola2;
            //Muestra el mensaje de registro correcto y limpia el registro.
            MessageBox.Show("-> Nombre Completo: " + Program.J1.GS_Nombre + ". \n-> Color: " + Program.J1.GS_Color + ".", ".::REGISTRO EXITOSO - JUGADOR 1::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarAfterAgregar(); //Método que limpia los campos del registro.
            //Regresa la información ingresada en el panel del jugador 1.
            L_nombre1.Text = Program.J1.GS_Nombre;
            L_color1.Text = Program.J1.GS_Color;
            PAN_jugador1.BackColor = Program.J1.GC_ColorPuro;
            PAN_jugador1.Visible = true;
        }

        public void RegistroJugador2() //Método que hace el registro del jugador 2.
        {
            //Guarda la información del Form en el objeto J2.
            Program.J2.GS_Nombre = TB_nombre.Text;
            Program.J2.GS_Color = CB_color.SelectedItem.ToString();
            Program.J2.GC_ColorPuro = H_extra.Cola2;
            //Muestra el mensaje de registro correcto y limpia el registro.
            MessageBox.Show("-> Nombre Completo: " + Program.J2.GS_Nombre + ". \n-> Color: " + Program.J2.GS_Color + ".", ".::REGISTRO EXITOSO - JUGADOR 2::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarAfterAgregar(); //Método que limpia los campos del registro.
            //Regresa la información ingresada en el panel del jugador 2.
            L_nombre2.Text = Program.J2.GS_Nombre;
            L_color2.Text = Program.J2.GS_Color;
            PAN_jugador2.BackColor = Program.J2.GC_ColorPuro;
            PAN_jugador2.Visible = true;
            //Como ya ingreso el mínimo de jugadores ya puede simular el juego.
            simularToolStripMenuItem.Enabled = true;
        }

        public void RegistroJugador3() //Método que hace el registro del jugador 3.
        {
            //Guarda la información del Form en el objeto J3.
            Program.J3.GS_Nombre = TB_nombre.Text;
            Program.J3.GS_Color = CB_color.SelectedItem.ToString();
            Program.J3.GC_ColorPuro = H_extra.Cola2;
            //Muestra el mensaje de registro correcto y limpia el registro.
            MessageBox.Show("-> Nombre Completo: " + Program.J3.GS_Nombre + ". \n-> Color: " + Program.J3.GS_Color + ".", ".::REGISTRO EXITOSO - JUGADOR 3::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarAfterAgregar(); //Método que limpia los campos del registro.
            //Regresa la información ingresada en el panel del jugador 3.
            L_nombre3.Text = Program.J3.GS_Nombre;
            L_color3.Text = Program.J3.GS_Color;
            PAN_jugador3.BackColor = Program.J3.GC_ColorPuro;
            PAN_jugador3.Visible = true;
        }

        public void RegistroJugador4() //Método que hace el registro del jugador 4.
        {
            //Guarda la información del Form en el objeto J4.
            Program.J4.GS_Nombre = TB_nombre.Text;
            Program.J4.GS_Color = CB_color.SelectedItem.ToString();
            Program.J4.GC_ColorPuro = H_extra.Cola2;
            //Muestra el mensaje de registro correcto y limpia el registro.
            MessageBox.Show("-> Nombre Completo: " + Program.J4.GS_Nombre + ". \n-> Color: " + Program.J4.GS_Color + ".", ".::REGISTRO EXITOSO - JUGADOR 1::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarAfterAgregar(); //Método que limpia los campos del registro.
            //Regresa la información ingresada en el panel del jugador 4.
            L_nombre4.Text = Program.J4.GS_Nombre;
            L_color4.Text = Program.J4.GS_Color;
            PAN_jugador4.BackColor = Program.J4.GC_ColorPuro;
            PAN_jugador4.Visible = true;
        }

        public void RegistroJugador5() //Método que hace el registro del jugador 5.
        {
            //Guarda la información del Form en el objeto J5.
            Program.J5.GS_Nombre = TB_nombre.Text;
            Program.J5.GS_Color = CB_color.SelectedItem.ToString();
            Program.J5.GC_ColorPuro = H_extra.Cola2;
            //Muestra el mensaje de registro correcto y limpia el registro.
            MessageBox.Show("-> Nombre Completo: " + Program.J5.GS_Nombre + ". \n-> Color: " + Program.J5.GS_Color + ".", ".::REGISTRO EXITOSO - JUGADOR 1::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarAfterAgregar(); //Método que limpia los campos del registro.
            //Regresa la información ingresada en el panel del jugador 5.
            L_nombre5.Text = Program.J5.GS_Nombre;
            L_color5.Text = Program.J5.GS_Color;
            PAN_jugador5.BackColor = Program.J5.GC_ColorPuro;
            PAN_jugador5.Visible = true;
        }

        public void RegistroJugador6() //Método que hace el registro del jugador 6.
        {
            //Guarda la información del Form en el objeto J6.
            Program.J6.GS_Nombre = TB_nombre.Text;
            Program.J6.GS_Color = CB_color.SelectedItem.ToString();
            Program.J6.GC_ColorPuro = H_extra.Cola2;
            //Muestra el mensaje de registro correcto y limpia el registro.
            MessageBox.Show("-> Nombre Completo: " + Program.J6.GS_Nombre + ". \n-> Color: " + Program.J6.GS_Color + ".", ".::REGISTRO EXITOSO - JUGADOR 1::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarAfterAgregar(); //Método que limpia los campos del registro.
            //Regresa la información ingresada en el panel del jugador 6.
            L_nombre6.Text = Program.J6.GS_Nombre;
            L_color6.Text = Program.J6.GS_Color;
            PAN_jugador6.BackColor = Program.J6.GC_ColorPuro;
            PAN_jugador6.Visible = true;
        }

        public void OFF_Jugador1() //Método que apaga el panel del jugador 1.
        {
            PAN_jugador1.BackColor = Color.DarkGray;
            TB_J1tirar1.Enabled = false;
            TB_J1tirar2.Enabled = false;
            BTN_tirar1.Enabled = false;
        }

        public void OFF_Jugador2() //Método que apaga el panel del jugador 2.
        {
            PAN_jugador2.BackColor = Color.DarkGray;
            TB_J2tirar1.Enabled = false;
            TB_J2tirar2.Enabled = false;
            BTN_tirar2.Enabled = false;
        }

        public void OFF_Jugador3() //Método que apaga el panel del jugador 3.
        {
            PAN_jugador3.BackColor = Color.DarkGray;
            TB_J3tirar1.Enabled = false;
            TB_J3tirar2.Enabled = false;
            BTN_tirar3.Enabled = false;
        }

        public void OFF_Jugador4() //Método que apaga el panel del jugador 4.
        {
            PAN_jugador4.BackColor = Color.DarkGray;
            TB_J4tirar1.Enabled = false;
            TB_J4tirar2.Enabled = false;
            BTN_tirar4.Enabled = false;
        }

        public void OFF_Jugador5() //Método que apaga el panel del jugador 5 .
        {
            PAN_jugador5.BackColor = Color.DarkGray;
            TB_J5tirar1.Enabled = false;
            TB_J5tirar2.Enabled = false;
            BTN_tirar5.Enabled = false;
        }

        public void OFF_Jugador6() //Método que apaga el panel del jugador 6.
        {
            PAN_jugador6.BackColor = Color.DarkGray;
            TB_J6tirar1.Enabled = false;
            TB_J6tirar2.Enabled = false;
            BTN_tirar6.Enabled = false;
        }

        public void escuchaJugador(object sender, EventArgs e) //Método que hace una verificación para determinar si la pestaña Agregar, "JUGADOR" esta habilitada o no.
        {
            if (agregarToolStripMenuItem.Enabled == true)
            {
                jugadorToolStripMenuItem_Click(sender, e); //Hace el evento de la pestaña Agregar, "JUGADOR".
            }
            else
            {
                MessageBox.Show("La pestaña Agregar, 'JUGADOR' esta deshabilitada!", ".::INFO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void escuchaAgregar(object sender, EventArgs e) //Método que hace una verificación para determinar si el panel para agregar jugadores esta visible o no.
        {
            if (PAN_agregar.Visible == true || BTN_agregar.Enabled == true)
            {
                BTN_agregar_Click(sender, e); //Hace el evento del botón "BTN_agregar".
            }
            else
            {
                MessageBox.Show("Esta opción aún no esta disponible!", ".::INFO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void escuchaSimular(object sender, EventArgs e) //Método que hace una verificación para determinar si la pestaña Simular, "JUEGO" esta habilitada o no.
        {
            if (simularToolStripMenuItem.Enabled == true)
            {
                juegoToolStripMenuItem_Click(sender, e); //Hace el evento de la pestaña Simular, "JUEGO".
            }
            else
            {
                MessageBox.Show("La pestaña Simular, 'JUEGO' esta deshabilitada!", ".::INFO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void escuchaTirar(object sender, EventArgs e) //Método que hace una verificación para determinar si los botones "Tirar" del J1 al J6 están habilitados o no.
        {
            if (BTN_tirar1.Enabled == true)
            {
                BTN_tirar1_Click(sender, e);
            }
            else if (BTN_tirar2.Enabled == true)
            {
                BTN_tirar2_Click(sender, e);
            }
            else if (BTN_tirar3.Enabled == true)
            {
                BTN_tirar3_Click(sender, e);
            }
            else if (BTN_tirar4.Enabled == true)
            {
                BTN_tirar4_Click(sender, e);
            }
            else if (BTN_tirar5.Enabled == true)
            {
                BTN_tirar5_Click(sender, e);
            }
            else if (BTN_tirar6.Enabled == true)
            {
                BTN_tirar6_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Esta opción no esta disponible!", ".::INFO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void lector(object sender, SpeechRecognizedEventArgs e) //Método que se llamará en "escucha.SpeechRecognized".
        {//Los parámetros son similares a los de un botón; "SpeechRecognitionRejectedEventArgs" en lugar de "EventArgs".
            foreach (RecognizedWordUnit palabra in e.Result.Words) //Foreach porque vamos a recorrer un como "arreglo" de palabras que vamos diciendo.
            {//Tipo de dato: "RecognizedWordUnit" en Colección: "e.Result.Words".
                //Las palabras captadas son la "Colección".
                L_palabra.Text = palabra.Text; //Escribe en la Label "L_palabra" lo que intepreta de nuestra voz.
                switch (palabra.Text)
                {//Switch para que llame los métodos correspondientes cuando escuche las palabras: "Jugador, Agregar, Simular, Tirar".
                    case "jugador":
                        {
                            escuchaJugador(sender, e); //Llama al método "escuchaJugador".
                        }
                        break;
                    case "agregar":
                        {
                            escuchaAgregar(sender, e); //Llama al método "escuchaAgregar".
                        }
                        break;
                    case "simular":
                        {
                            escuchaSimular(sender, e); //Llama al método "escucharSimular".
                        }
                        break;
                    case "tirar":
                        {
                            escuchaTirar(sender, e); //Llama al método "escuchaTirar".
                        }
                        break;
                }
            }
        }
        //MÉTODOS. (FIN)

        //DISEÑO. (INICIO)
        //Contador que llevará el control de los jugadores ingresados.
        int LI_jugadorIngresado = 0;
        //Bandera que lleva el control si se dio click en la pestaña "Agregar, Jugador" por defecto esta en falso.
        bool LB_banderaPestañaJugador = false;

        private void jugadorToolStripMenuItem_Click(object sender, EventArgs e) //Al hacer click en la pestaña Agregar, "JUGADOR".
        {
            if (LB_banderaPestañaJugador == false) //La primera vez que se le da click.
            {
                PAN_agregar.Visible = true;
                TAB_boliche.Visible = true;
                GB_jugadores.Visible = true;
                agregarToolStripMenuItem.Enabled = false;
            }
            else //El resto de veces que le da click.
            {
                //Activa de nuevo el panel de "Agregar, Jugador"
                TB_nombre.BackColor = Color.Khaki;
                CB_color.BackColor = Color.White;
                PAN_agregar.BackColor = Color.Coral;
                BTN_agregar.BackColor = SystemColors.Control;
                PAN_agregar.Enabled = true;
                //Descativa el botón del jugador 1 "Tirar"
                BTN_tirar1.Enabled = false;
                TB_J1tirar1.Enabled = false;
                //Desactiva la pestaña "Agregar, Jugador"
                agregarToolStripMenuItem.Enabled = false;
                //Activa la pestaña "Simular, Juego"
                simularToolStripMenuItem.Enabled = true;
            }
            LB_banderaPestañaJugador = true;
        }

        private void juegoToolStripMenuItem_Click(object sender, EventArgs e) //Al hacer click en la pestaña Simular, "JUEGO".
        {
            //Desactiva todas las funciones del panel "Agregar Jugador"
            TB_nombre.BackColor = Color.DarkGray;
            CB_color.BackColor = Color.DarkGray;
            PAN_agregar.BackColor = Color.DarkGray;
            BTN_agregar.BackColor = Color.DarkGray;
            PAN_agregar.Enabled = false;
            //Desactiva la pestaña "Simular, Juego"
            simularToolStripMenuItem.Enabled = false;
            //Activa la pestaña "Agregar, Jugador" por si olvido agregar un jugador.
            agregarToolStripMenuItem.Enabled = true;
            //Activa el bóton "Tirar" del jugador 1 si desea empezar el juego.
            BTN_tirar1.Enabled = true;
            TB_J1tirar1.Enabled = true;
            //Muestra los pinos de todos los jugadores.
            PB_pinosJ1.Load("../../Resources/Boliche.png");
            PB_pinosJ2.Load("../../Resources/Boliche.png");
            PB_pinosJ3.Load("../../Resources/Boliche.png");
            PB_pinosJ4.Load("../../Resources/Boliche.png");
            PB_pinosJ5.Load("../../Resources/Boliche.png");
            PB_pinosJ6.Load("../../Resources/Boliche.png");
            //Muestra las bolas de todos los jugadores.
            PB_bolaJ1.Load("../../Resources/bola.png");
            PB_bolaJ2.Load("../../Resources/bola.png");
            PB_bolaJ3.Load("../../Resources/bola.png");
            PB_bolaJ4.Load("../../Resources/bola.png");
            PB_bolaJ5.Load("../../Resources/bola.png");
            PB_bolaJ6.Load("../../Resources/bola.png");
            //Desactiva permanentemente la pestaña de "Agregar, Jugador" cuando el contador de ingreso llega a los 6 jugadores.
            if (LI_jugadorIngresado == 6)
            {
                agregarToolStripMenuItem.Enabled = false;
            }
        }

        public void BTN_agregar_Click(object sender, EventArgs e) //Al hacer click en el botón: Agregar, "BTN_agregar".
        {
            LI_jugadorIngresado += 1; //Contador que lleva la cuenta de los jugadores ingresados.

            if (TB_nombre.Text != "" && CB_color.Text != "") //Condicional que analiza si los 2 campos están llenos.
            {
                //Método AveriguarColor de la Clase Herramientas_Extras, pide un parametro; El parametro que le llegara será el color que el usuario selecciono en el ComboBox "CB_color".
                H_extra.AveriguarColor(CB_color.SelectedItem.ToString());
                switch (LI_jugadorIngresado) //Según sea el caso del contador 1 al 6 guardar la información para cada jugador.
                {
                    case 1:
                        RegistroJugador1(); //Manda a llamar al método que registra al jugador 1.
                        TB_nombre.Focus();
                        break;
                    case 2:
                        RegistroJugador2(); //Manda a llamar al método que registra al jugador 2.
                        TB_nombre.Focus();
                        break;
                    case 3:
                        RegistroJugador3(); //Manda a llamar al método que registra al jugador 3.
                        TB_nombre.Focus();
                        break;
                    case 4:
                        RegistroJugador4(); //Manda a llamar al método que registra al jugador 4.
                        TB_nombre.Focus();
                        break;
                    case 5:
                        RegistroJugador5(); //Manda a llamar al método que registra al jugador 5.
                        TB_nombre.Focus();
                        break;
                    case 6:
                        RegistroJugador6(); //Manda a llamar al método que registra al jugador 6.
                        TB_nombre.Focus();
                        break;
                    default:
                        //Muestra el mensaje de registros completos y limpia los campos.
                        MessageBox.Show("El Número Máximo de Jugadores Permitidos es de 6", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LimpiarAfterAgregar();
                        break;
                }
                CB_color.Items.Remove(CB_color.SelectedItem); //Elimina el color seleccionado de la lista para que no vuelvan a elegir.
            }
            else //Si 1 o los 2 campos: "Nombre, Color" estan vacios.
            {
                LI_jugadorIngresado -= 1;
                MessageBox.Show("¡Ambos Datos son Obligatorios!", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //DISEÑO. (FIN)

        //¡EXTRAS! (INICIO)
        private void CB_color_TextUpdate(object sender, EventArgs e) //Mensaje que se despliega si se actualiza el texto del ComboBox "CB_color", en lugar de seleccionar un Item de la lista.
        {
            MessageBox.Show("¡Seleccione 1 Color de la Lista!", ".::INFORMACIÓN::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BTN_agregar.Enabled = false;
        }

        private void CB_color_SelectedIndexChanged(object sender, EventArgs e) //Activa el botón "BTN_agregar" cuando se selecciona algo de la lista.
        {
            BTN_agregar.Enabled = true;
        }

        private void TB_nombre_KeyPress(object sender, KeyPressEventArgs e) //Hace la acción del botón "BTN_agregar" si presiona "Enter" en el TextBox "TB_nombre".
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BTN_agregar_Click(sender, e);
            }
        }

        private void CB_color_KeyPress(object sender, KeyPressEventArgs e) //Hace la acción del botón "BTN_agregar" si presiona "Enter" en el ComboBox "CB_color".
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BTN_agregar_Click(sender, e);
            }
        }

        private void BTN_voz_Click(object sender, EventArgs e) //Botón que activa el reconocimiento de voz.
        {
            try //Try & Catch en caso de que el canal de audio se abra más de 1 vez.
            {
                /*Primero realiza una condicional para ver que simbolo esta en el botón, por default es 📢, si el
         simbolo es 📢 entonces enciente el reconocimiento de voz y cambia el texto del botón al 🔇, y si
         el simbolo es 🔇 entonces apaga el reconocimiento de voz y cambia el texto del botón al 📢.*/
                if (BTN_voz.Text == "📢")
                {
                    BTN_voz.Text = "🔇";
                    L_palabra.Text = "...";
                    escucha.SetInputToDefaultAudioDevice(); //Abre el puerto. (El canal de audio)
                    escucha.LoadGrammar(new DictationGrammar()); //Lee la gramática para captar las palabras. (Decide cual palabra es, como un diccionario)
                    escucha.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(lector);
                    //+=: Para que agregue las palabras que va escuchando.
                    //EventHandler<SpeechRecognizedEventArgs>: Envia como parametro lo que escucha al método "lector".
                    escucha.RecognizeAsync(RecognizeMode.Multiple); //Para que detecte no solo una palabra, si no varias.
                }
                else if (BTN_voz.Text == "🔇")
                {
                    escucha.RecognizeAsyncStop();
                    escucha.RecognizeAsyncCancel();
                    BTN_voz.Text = "📢";
                    L_palabra.Text = "___";
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("No se puede abrir el canal más de una vez", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TB_J1tirar1_TextChanged(object sender, EventArgs e) //Verificación que hace al modificar el texto del TextBox "TB_J1tirar1".
        {
            if (TB_J1tirar1.Text != "") //Si el TextBox no esta vacio.
            {
                TB_J1tirar2.Enabled = true; //El TextBox "TB_J1tirar2" se activa.
                if (TB_J1tirar1.Text == "10") //Si se ingreso el número "10".
                {
                    TB_J1tirar2.Text = "0"; //El TextBox "TB_J1tirar2" olbigatoriamente se rellena con "10" y se desactiva.
                    TB_J1tirar2.Enabled = false;
                }
                else //Si no se ingreso el número "10".
                {
                    TB_J1tirar2.Text = ""; //El TextBox "TB_J1tirar2" se limpia.
                }
            }
            else //Si el TextBox esta vacio.
            {
                TB_J1tirar2.Enabled = false; //El TextBox "TB_J1tirar2" permanece desactivado.
            }
        }

        private void TB_J1tirar1_KeyPress(object sender, KeyPressEventArgs e) //Hace la acción del botón "BTN_tirar1" si presiona "Enter" en el TextBox "TB_J1tirar1".
        {
            if (BTN_tirar1.Enabled == true)
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    BTN_tirar1_Click(sender, e);
                }
            }
        }

        private void TB_J1tirar2_KeyPress(object sender, KeyPressEventArgs e) //Hace la acción del botón "BTN_tirar1" si presiona "Enter" en el TextBox "TB_J1tirar2".
        {
            if (BTN_tirar1.Enabled == true)
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    BTN_tirar1_Click(sender, e);
                }
            }
        }

        private void TB_J2tirar1_TextChanged(object sender, EventArgs e) //Verificación que hace al modificar el texto del TextBox "TB_J2tirar1".
        {
            if (TB_J2tirar1.Text != "") //Si el TextBox no esta vacio.
            {
                TB_J2tirar2.Enabled = true; //El TextBox "TB_J2tirar2" se activa.
                if (TB_J2tirar1.Text == "10") //Si se ingreso el número "10".
                {
                    TB_J2tirar2.Text = "0"; //El TextBox "TB_J2tirar2" olbigatoriamente se rellena con "10" y se desactiva.
                    TB_J2tirar2.Enabled = false;
                }
                else //Si no se ingreso el número "10".
                {
                    TB_J2tirar2.Text = ""; //El TextBox "TB_J2tirar2" se limpia.
                }
            }
            else //Si el TextBox esta vacio.
            {
                TB_J2tirar2.Enabled = false; //El TextBox "TB_J1tirar2" permanece desactivado.
            }
        }

        private void TB_J2tirar1_KeyPress(object sender, KeyPressEventArgs e) //Hace la acción del botón "BTN_tirar2" si presiona "Enter" en el TextBox "TB_J2tirar1".
        {
            if (BTN_tirar2.Enabled == true)
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    BTN_tirar2_Click(sender, e);
                }
            }
        }

        private void TB_J2tirar2_KeyPress(object sender, KeyPressEventArgs e) //Hace la acción del botón "BTN_tirar2" si presiona "Enter" en el TextBox "TB_J2tirar2".
        {
            if (BTN_tirar2.Enabled == true)
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    BTN_tirar2_Click(sender, e);
                }
            }
        }

        private void TB_J3tirar1_TextChanged(object sender, EventArgs e) //Verificación que hace al modificar el texto del TextBox "TB_J3tirar1".
        {
            if (TB_J3tirar1.Text != "") //Si el TextBox no esta vacio.
            {
                TB_J3tirar2.Enabled = true; //El TextBox "TB_J3tirar2" se activa.
                if (TB_J3tirar1.Text == "10") //Si se ingreso el número "10".
                {
                    TB_J3tirar2.Text = "0"; //El TextBox "TB_J3tirar2" olbigatoriamente se rellena con "10" y se desactiva.
                    TB_J3tirar2.Enabled = false;
                }
                else //Si no se ingreso el número "10".
                {
                    TB_J3tirar2.Text = ""; //El TextBox "TB_J3tirar2" se limpia.
                }
            }
            else //Si el TextBox esta vacio.
            {
                TB_J3tirar2.Enabled = false; //El TextBox "TB_J1tirar2" permanece desactivado.
            }
        }

        private void TB_J3tirar1_KeyPress(object sender, KeyPressEventArgs e) //Hace la acción del botón "BTN_tirar3" si presiona "Enter" en el TextBox "TB_J3tirar1".
        {
            if (BTN_tirar3.Enabled == true)
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    BTN_tirar3_Click(sender, e);
                }
            }
        }

        private void TB_J3tirar2_KeyPress(object sender, KeyPressEventArgs e) //Hace la acción del botón "BTN_tirar3" si presiona "Enter" en el TextBox "TB_J3tirar2".
        {
            if (BTN_tirar3.Enabled == true)
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    BTN_tirar3_Click(sender, e);
                }
            }
        }

        private void TB_J4tirar1_TextChanged(object sender, EventArgs e) //Verificación que hace al modificar el texto del TextBox "TB_J4tirar1".
        {
            if (TB_J4tirar1.Text != "") //Si el TextBox no esta vacio.
            {
                TB_J4tirar2.Enabled = true; //El TextBox "TB_J4tirar2" se activa.
                if (TB_J4tirar1.Text == "10") //Si se ingreso el número "10".
                {
                    TB_J4tirar2.Text = "0"; //El TextBox "TB_J4tirar2" olbigatoriamente se rellena con "10" y se desactiva.
                    TB_J4tirar2.Enabled = false;
                }
                else //Si no se ingreso el número "10".
                {
                    TB_J4tirar2.Text = ""; //El TextBox "TB_J4tirar2" se limpia.
                }
            }
            else //Si el TextBox esta vacio.
            {
                TB_J4tirar2.Enabled = false; //El TextBox "TB_J4tirar2" permanece desactivado.
            }
        }

        private void TB_J4tirar1_KeyPress(object sender, KeyPressEventArgs e) //Hace la acción del botón "BTN_tirar4" si presiona "Enter" en el TextBox "TB_J4tirar1".
        {
            if (BTN_tirar4.Enabled == true)
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    BTN_tirar4_Click(sender, e);
                }
            }
        }

        private void TB_J4tirar2_KeyPress(object sender, KeyPressEventArgs e) //Hace la acción del botón "BTN_tirar4" si presiona "Enter" en el TextBox "TB_J4tirar2".
        {
            if (BTN_tirar4.Enabled == true)
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    BTN_tirar4_Click(sender, e);
                }
            }
        }

        private void TB_J5tirar1_TextChanged(object sender, EventArgs e) //Verificación que hace al modificar el texto del TextBox "TB_J5tirar1".
        {
            if (TB_J5tirar1.Text != "") //Si el TextBox no esta vacio.
            {
                TB_J5tirar2.Enabled = true; //El TextBox "TB_J5tirar2" se activa.
                if (TB_J5tirar1.Text == "10") //Si se ingreso el número "10".
                {
                    TB_J5tirar2.Text = "0"; //El TextBox "TB_J5tirar2" olbigatoriamente se rellena con "10" y se desactiva.
                    TB_J5tirar2.Enabled = false;
                }
                else //Si no se ingreso el número "10".
                {
                    TB_J5tirar2.Text = ""; //El TextBox "TB_J5tirar2" se limpia.
                }
            }
            else //Si el TextBox esta vacio.
            {
                TB_J5tirar2.Enabled = false; //El TextBox "TB_J5tirar2" permanece desactivado.
            }
        }

        private void TB_J5tirar1_KeyPress(object sender, KeyPressEventArgs e) //Hace la acción del botón "BTN_tirar5" si presiona "Enter" en el TextBox "TB_J5tirar1".
        {
            if (BTN_tirar5.Enabled == true)
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    BTN_tirar5_Click(sender, e);
                }
            }
        }

        private void TB_J5tirar2_KeyPress(object sender, KeyPressEventArgs e) //Hace la acción del botón "BTN_tirar5" si presiona "Enter" en el TextBox "TB_J5tirar2".
        {
            if (BTN_tirar5.Enabled == true)
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    BTN_tirar5_Click(sender, e);
                }
            }
        }

        private void TB_J6tirar1_TextChanged(object sender, EventArgs e) //Verificación que hace al modificar el texto del TextBox "TB_J6tirar1".  
        {
            if (TB_J6tirar1.Text != "") //Si el TextBox no esta vacio.
            {
                TB_J6tirar2.Enabled = true; //El TextBox "TB_J6tirar2" se activa.
                if (TB_J6tirar1.Text == "10") //Si se ingreso el número "10".
                {
                    TB_J6tirar2.Text = "0"; //El TextBox "TB_J6tirar2" olbigatoriamente se rellena con "10" y se desactiva.
                    TB_J6tirar2.Enabled = false;
                }
                else //Si no se ingreso el número "10".
                {
                    TB_J6tirar2.Text = ""; //El TextBox "TB_J6tirar2" se limpia.
                }
            }
            else //Si el TextBox esta vacio.
            {
                TB_J6tirar2.Enabled = false; //El TextBox "TB_J6tirar2" permanece desactivado.
            }
        }

        private void TB_J6tirar1_KeyPress(object sender, KeyPressEventArgs e) //Hace la acción del botón "BTN_tirar6" si presiona "Enter" en el TextBox "TB_J6tirar1".
        {
            if (BTN_tirar6.Enabled == true)
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    BTN_tirar6_Click(sender, e);
                }
            }
        }

        private void TB_J6tirar2_KeyPress(object sender, KeyPressEventArgs e) //Hace la acción del botón "BTN_tirar6" si presiona "Enter" en el TextBox "TB_J6tirar2".
        {
            if (BTN_tirar6.Enabled == true)
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    BTN_tirar6_Click(sender, e);
                }
            }
        }
        //¡EXTRAS! (FIN)

        //JUEGO. (INICIO)
        //Almacena los pinos que derrivo en el tiro extra.
        int Extraaa;
        //Sumador que mueve la imagen a la derecha, su posición original es 180.
        int X = 180;

        private void BTN_tirar1_Click(object sender, EventArgs e) //Jugador 1.
        {
            //Desactiva la pestaña "Agregar, Jugador" e inicia el juego.
            agregarToolStripMenuItem.Enabled = false;
            //Contador de turnos del jugador 1.
            Program.J1.GI_Turnos += 1;
            try //Try & Catch por si el usuario ingresa una cadena en lugar de un entero en el TextBox "TB_J1tirar1".
            {
                //Condicional que permite que el jugador siga haciendo turnos hasta que alcance el límite.
                if (Program.J1.GI_Turnos <= Program.J1.GI_Limite)
                {
                    //Le indica al jugador el turno en el que va.
                    L_tiroJ1.Text = "Turno #" + Program.J1.GI_Turnos.ToString();
                    //Variable que indica cuantos turnos le quedan.
                    Program.J1.GI_turnosRestantes -= 1;
                    //Condicional que verifica si las cantidades ingresadas en "TB_J1tirar1" y "TB_J1tirar2" son menores o iguales a 10.
                    if (Convert.ToInt32(TB_J1tirar1.Text) <= 10 && Convert.ToInt32(TB_J1tirar2.Text) <= 10)
                    {
                        //Verifica su la suma de los 2 tiros es exactamente 10. Significa que es chuza o spare.
                        if (Convert.ToInt32(TB_J1tirar1.Text) + Convert.ToInt32(TB_J1tirar2.Text) == 10)
                        {
                            //Método cuantosPuntos de la Clase Punteo_Boliche, pide dos parametros.
                            //Los parametros que le llegaran serán los número que el usuario ingresó en los TextBox "TB_J1tirar1" y "TB_J1tirar2".
                            Puntos.cuantosPuntos(Convert.ToInt32(TB_J1tirar1.Text), Convert.ToInt32(TB_J1tirar2.Text));
                            //¡ANIMACIÓN!
                            //Se resetean los pinos, la ubicación de la bola y el Timer.
                            PB_pinosJ1.Load("../../Resources/Boliche.png");
                            X = 180;
                            PB_bolaJ1.Location = new Point(X, 20);
                            PB_bolaJ1.Visible = true;
                            //Inicia el Timer del caso en el que se derrivan exactamente 10 pinos.
                            BTN_tirar1.Enabled = false;
                            TIME_J1bola10.Start();
                        }
                        if (Convert.ToInt32(TB_J1tirar1.Text) + Convert.ToInt32(TB_J1tirar2.Text) < 10) //Si la suma de los 2 tiros es menor a 10.
                        {
                            //Método cuantosPuntos de la Clase Punteo_Boliche, pide dos parametros.
                            //Los parametros que le llegaran serán los número que el usuario ingresó en los TextBox "TB_J1tirar1" y "TB_J1tirar2".
                            Puntos.cuantosPuntos(Convert.ToInt32(TB_J1tirar1.Text), Convert.ToInt32(TB_J1tirar2.Text));
                            //¡ANIMACIÓN!
                            //Se resetean los pinos, la ubicación de la bola y el Timer.
                            PB_pinosJ1.Load("../../Resources/Boliche.png");
                            X = 180;
                            PB_bolaJ1.Location = new Point(180, 20);
                            PB_bolaJ1.Visible = true;
                            //Inicia el Timer del caso en el que se derrivan menos de 10 pinos.
                            BTN_tirar1.Enabled = false;
                            TIME_J1bola1a9.Start();
                        }

                        if (Convert.ToInt32(TB_J1tirar1.Text) + Convert.ToInt32(TB_J1tirar2.Text) > 10)
                        {
                            //Quita el tiro que se conto.
                            Program.J1.GI_Turnos -= 1;
                            //Actualiza el texto que indica el tiro en el que el jugador va.
                            L_tiroJ1.Text = "Turno #" + Program.J1.GI_Turnos.ToString();
                            //Repone el turno que se desconto.
                            Program.J1.GI_turnosRestantes += 1;
                            //Mensaje que indica como funcionan los tiros y los turnos.
                            MessageBox.Show("¡El máximo número de pines que puedes derrivar por turno, entre los 2 tiros son 10!", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        //Quita el tiro que se conto.
                        Program.J1.GI_Turnos -= 1;
                        //Actualiza el texto que indica el tiro en el que el jugador va.
                        L_tiroJ1.Text = "Turno #" + Program.J1.GI_Turnos.ToString();
                        //Repone el turno que se desconto.
                        Program.J1.GI_turnosRestantes += 1;
                        //Mensaje que indica que el máximo de pines a derrivar son 10.
                        MessageBox.Show("¡El máximo número de pines que puedes derrivar son 10!", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("¡Llegaste al límite de tiros!", ".::INFO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Guarda el punteo total en una variable para el J1.
                    Program.J1.GI_PuntosFinales = Puntos.GI_punteo;
                    MessageBox.Show("Puntaje del Jugador 1: " + Convert.ToString(Program.J1.GI_PuntosFinales) + "\n*Total de Chuzas: " + Convert.ToString(Program.J1.GI_ChuzasTotales) + "\n*Total de Spare: " + Convert.ToString(Program.J1.GI_SparesTotales) + "\n*Total de Castigos: " + Convert.ToString(Program.J1.GI_CastigosTotales), ".::TOTAL::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpia los campos.
                    TB_J1tirar1.Text = "";
                    TB_J1tirar2.Text = "";
                    Puntos.GI_punteo = 0;
                    //Llama al método que apaga el panel del jugador 1.
                    OFF_Jugador1();
                    //Activa el turno del jugador 2.
                    TB_J2tirar1.Enabled = true;
                    BTN_tirar2.Enabled = true;
                }
            }
            catch
            {
                //Quita el tiro que se conto.
                Program.J1.GI_Turnos -= 1;
                //Actualiza el texto que indica el tiro en el que el jugador va.
                L_tiroJ1.Text = "Turno #" + Program.J1.GI_Turnos.ToString();
                //Repone el turno que se desconto.
                Program.J1.GI_turnosRestantes += 1;
                //Muestra el mensaje de error al usuario.
                MessageBox.Show("¡Ingresa una cantidad de pinos derrivados!", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TIME_J1bola10_Tick(object sender, EventArgs e) //Timer del caso en el que se derrivan los 10 pinos. (Jugador 1).
        {
            if (X < 196) //Verifica si la imagen ya llego a la posición 196.
            {
                X++;
                PB_bolaJ1.Location = new Point(X, 20);
            }
            else
            {
                TIME_J1bola10.Stop(); //Cuando pasa de la posición 196 apaga el Timer.
                PB_bolaJ1.Visible = false; //Hace invisible la imagen.
                //Muestra en el PictureBox los pinos que tiro en total.
                PB_pinosJ1.Load("../../Resources/" + Convert.ToString(Convert.ToInt32(TB_J1tirar1.Text) + Convert.ToInt32(TB_J1tirar2.Text)) + "Pinos.png");
                //Suma 10 puntos por la chuza o por el spare.
                Puntos.GI_punteo += 10;
                if (TB_J1tirar1.Text != "10")
                {
                    Program.J1.GI_SparesTotales++;
                }
                //Si la bandera es True, es porque hizo una chuza.
                if (Puntos.GB_banderaChuza == true)
                {
                    //Suma 1 al contador de las ChuzasTotales.
                    Program.J1.GI_ChuzasTotales++;
                    //Abre el Form de la chuza.
                    Tirar.ShowDialog();
                    //Guarda en una variable el resultado del tiro de la chuza.
                    Extraaa = Tirar.tiroEx;
                    //Calcula los puntos por ese punto.
                    Puntos.cuantosExtra(Extraaa);
                }
                //Le indica al jugador cuantos puntos lleva.
                MessageBox.Show("Tienes: " + Puntos.GI_punteo + " puntos. \nTe quedan: " + Program.J1.GI_turnosRestantes + " turnos.");
                TB_J1tirar1.Text = "";
                TB_J1tirar2.Text = "";
                TB_J1tirar1.Focus();
                BTN_tirar1.Enabled = true;
            }
        }

        private void TIME_J1bola1a9_Tick(object sender, EventArgs e) //Timer del caso en el que se derrivan menos de 10 pinos. (Jugador 1).
        {
            if (X < 196) //Verifica si la imagen ya llego a la posición 196.
            {
                X++;
                PB_bolaJ1.Location = new Point(X, 20);
            }
            else
            {
                TIME_J1bola1a9.Stop(); //Cuando pasa de la posición 196 apaga el Timer.
                PB_bolaJ1.Visible = false; //Hace invisible la imagen.
                //Muestra en el PictureBox los pinos que tiro en total.
                PB_pinosJ1.Load("../../Resources/" + Convert.ToString(Convert.ToInt32(TB_J1tirar1.Text) + Convert.ToInt32(TB_J1tirar2.Text)) + "Pinos.png");
                //Si la bandera es True, es porque tiene un castigo.
                if (Puntos.GB_banderaCastigo == true)
                {
                    if (Program.J1.GI_turnosRestantes <= 0) //Por defecto si solo le queda 1 turno y comete un castigo. Regresa que le quedan 0 turnos y no un número negativo.
                    {
                        //Le indica al jugador cuantos puntos lleva.
                        MessageBox.Show("Tienes: " + Puntos.GI_punteo + " puntos. \nTe quedan: 0 turnos.");
                        TB_J1tirar1.Text = "";
                        TB_J1tirar2.Text = "";
                        TB_J1tirar1.Focus();
                        BTN_tirar1.Enabled = true;
                    }
                    else
                    {
                        //Suma 1 al contador de los CastigosTotales.
                        Program.J1.GI_CastigosTotales++;
                        //Disminuye el limite de tiros.
                        Program.J1.GI_Limite -= 1;
                        //Disminuye los turnos que le quedan.
                        Program.J1.GI_turnosRestantes -= 1;
                        //Le indica al jugador cuantos puntos lleva.
                        MessageBox.Show("Tienes: " + Puntos.GI_punteo + " puntos. \nTe quedan: " + Program.J1.GI_turnosRestantes + " turnos.");
                        TB_J1tirar1.Text = "";
                        TB_J1tirar2.Text = "";
                        TB_J1tirar1.Focus();
                        BTN_tirar1.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Tienes: " + Puntos.GI_punteo + " puntos. \nTe quedan: " + Program.J1.GI_turnosRestantes + " turnos.");
                    TB_J1tirar1.Text = "";
                    TB_J1tirar2.Text = "";
                    TB_J1tirar1.Focus();
                    BTN_tirar1.Enabled = true;
                }
            }
        }

        private void BTN_tirar2_Click(object sender, EventArgs e) //Jugador 2.
        {
            //Contador de turnos del jugador 2.
            Program.J2.GI_Turnos += 1;
            try //Try & Catch por si el usuario ingresa una cadena en lugar de un entero en el TextBox "TB_J2tirar1".
            {
                //Condicional que permite que el jugador siga haciendo turnos hasta que alcance el límite.
                if (Program.J2.GI_Turnos <= Program.J2.GI_Limite)
                {
                    //Le indica al jugador el turno en el que va.
                    L_tiroJ2.Text = "Turno #" + Program.J2.GI_Turnos.ToString();
                    //Variable que indica cuantos turnos le quedan.
                    Program.J2.GI_turnosRestantes -= 1;
                    //Condicional que verifica si las cantidades ingresadas en "TB_J2tirar1" y "TB_J2tirar2" son menores o iguales a 10.
                    if (Convert.ToInt32(TB_J2tirar1.Text) <= 10 && Convert.ToInt32(TB_J2tirar2.Text) <= 10)
                    {
                        //Verifica su la suma de los 2 tiros es exactamente 10. Significa que es chuza o spare.
                        if (Convert.ToInt32(TB_J2tirar1.Text) + Convert.ToInt32(TB_J2tirar2.Text) == 10)
                        {
                            //Método cuantosPuntos de la Clase Punteo_Boliche, pide dos parametros.
                            //Los parametros que le llegaran serán los número que el usuario ingresó en los TextBox "TB_J2tirar1" y "TB_J2tirar2".
                            Puntos.cuantosPuntos(Convert.ToInt32(TB_J2tirar1.Text), Convert.ToInt32(TB_J2tirar2.Text));
                            //¡ANIMACIÓN!
                            //Se resetean los pinos, la ubicación de la bola y el Timer.
                            PB_pinosJ2.Load("../../Resources/Boliche.png");
                            X = 180;
                            PB_bolaJ2.Location = new Point(X, 20);
                            PB_bolaJ2.Visible = true;
                            //Inicia el Timer del caso en el que se derrivan exactamente 10 pinos.
                            BTN_tirar2.Enabled = false;
                            TIME_J2bola10.Start();
                        }
                        if (Convert.ToInt32(TB_J2tirar1.Text) + Convert.ToInt32(TB_J2tirar2.Text) < 10) //Si la suma de los 2 tiros es menor a 10.
                        {
                            //Método cuantosPuntos de la Clase Punteo_Boliche, pide dos parametros.
                            //Los parametros que le llegaran serán los número que el usuario ingresó en los TextBox "TB_J2tirar1" y "TB_J2tirar2".
                            Puntos.cuantosPuntos(Convert.ToInt32(TB_J2tirar1.Text), Convert.ToInt32(TB_J2tirar2.Text));
                            //¡ANIMACIÓN!
                            //Se resetean los pinos, la ubicación de la bola y el Timer.
                            PB_pinosJ2.Load("../../Resources/Boliche.png");
                            X = 180;
                            PB_bolaJ2.Location = new Point(180, 20);
                            PB_bolaJ2.Visible = true;
                            //Inicia el Timer del caso en el que se derrivan menos de 10 pinos.
                            BTN_tirar2.Enabled = false;
                            TIME_J2bola1a9.Start();
                        }

                        if (Convert.ToInt32(TB_J2tirar1.Text) + Convert.ToInt32(TB_J2tirar2.Text) > 10)
                        {
                            //Quita el tiro que se conto.
                            Program.J2.GI_Turnos -= 1;
                            //Actualiza el texto que indica el tiro en el que el jugador va.
                            L_tiroJ2.Text = "Turno #" + Program.J2.GI_Turnos.ToString();
                            //Repone el turno que se desconto.
                            Program.J2.GI_turnosRestantes += 1;
                            //Mensaje que indica como funcionan los tiros y los turnos.
                            MessageBox.Show("¡El máximo número de pines que puedes derrivar por turno, entre los 2 tiros son 10!", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        //Quita el tiro que se conto.
                        Program.J2.GI_Turnos -= 1;
                        //Actualiza el texto que indica el tiro en el que el jugador va.
                        L_tiroJ2.Text = "Turno #" + Program.J2.GI_Turnos.ToString();
                        //Repone el turno que se desconto.
                        Program.J2.GI_turnosRestantes += 1;
                        //Mensaje que indica que el máximo de pines a derrivar son 10.
                        MessageBox.Show("¡El máximo número de pines que puedes derrivar son 10!", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("¡Llegaste al límite de tiros!", ".::INFO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Guarda el punteo total en una variable para el J2.
                    Program.J2.GI_PuntosFinales = Puntos.GI_punteo;
                    MessageBox.Show("Puntaje del Jugador 2: " + Convert.ToString(Program.J2.GI_PuntosFinales) + "\n*Total de Chuzas: " + Convert.ToString(Program.J2.GI_ChuzasTotales) + "\n*Total de Spare: " + Convert.ToString(Program.J2.GI_SparesTotales) + "\n*Total de Castigos: " + Convert.ToString(Program.J2.GI_CastigosTotales), ".::TOTAL::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpia los campos.
                    TB_J2tirar1.Text = "";
                    TB_J2tirar2.Text = "";
                    Puntos.GI_punteo = 0;
                    //Llama al método que apaga el panel del jugador 2.
                    OFF_Jugador2();
                    //Verifica si el siguiente panel esta visible.
                    if (PAN_jugador3.Visible == false)
                    {
                        this.Size = new Size(964, 655);
                        GB_resultado.Visible = true;
                        DGV_resultadoJuego.Rows.Add(2);
                        //Primer Jugador.
                        DGV_resultadoJuego[1, 0].Value = (Program.J1.GS_Nombre);
                        DGV_resultadoJuego[2, 0].Value = (Program.J1.GI_PuntosFinales);
                        DGV_resultadoJuego[3, 0].Value = (Program.J1.GI_ChuzasTotales);
                        DGV_resultadoJuego[4, 0].Value = (Program.J1.GI_SparesTotales);
                        DGV_resultadoJuego[5, 0].Value = (Program.J1.GI_CastigosTotales);
                        DGV_resultadoJuego.Rows[0].DefaultCellStyle.BackColor = Program.J1.GC_ColorPuro;
                        //Segundo Jugador.
                        DGV_resultadoJuego[1, 1].Value = (Program.J2.GS_Nombre);
                        DGV_resultadoJuego[2, 1].Value = (Program.J2.GI_PuntosFinales);
                        DGV_resultadoJuego[3, 1].Value = (Program.J2.GI_ChuzasTotales);
                        DGV_resultadoJuego[4, 1].Value = (Program.J2.GI_SparesTotales);
                        DGV_resultadoJuego[5, 1].Value = (Program.J2.GI_CastigosTotales);
                        DGV_resultadoJuego.Rows[1].DefaultCellStyle.BackColor = Program.J2.GC_ColorPuro;
                        //Ordenar.
                        DGV_resultadoJuego.Sort(DGV_resultadoJuego.Columns["Punto"], ListSortDirection.Descending);
                        DGV_resultadoJuego[0, 0].Value = 1;
                        DGV_resultadoJuego[0, 1].Value = 2;
                    }
                    //Activa el turno del jugador 3.
                    TB_J3tirar1.Enabled = true;
                    BTN_tirar3.Enabled = true;
                }
            }
            catch
            {
                //Quita el tiro que se conto.
                Program.J2.GI_Turnos -= 1;
                //Actualiza el texto que indica el tiro en el que el jugador va.
                L_tiroJ2.Text = "Turno #" + Program.J2.GI_Turnos.ToString();
                //Repone el turno que se desconto.
                Program.J2.GI_turnosRestantes += 1;
                //Muestra el mensaje de error al usuario.
                MessageBox.Show("¡Ingresa una cantidad de pinos derrivados!", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TIME_J2bola10_Tick(object sender, EventArgs e) //Timer del caso en el que se derrivan los 10 pinos. (Jugador 2).
        {
            if (X < 196) //Verifica si la imagen ya llego a la posición 196.
            {
                X++;
                PB_bolaJ2.Location = new Point(X, 20);
            }
            else
            {
                TIME_J2bola10.Stop(); //Cuando pasa de la posición 196 apaga el Timer.
                PB_bolaJ2.Visible = false; //Hace invisible la imagen.
                //Muestra en el PictureBox los pinos que tiro en total.
                PB_pinosJ2.Load("../../Resources/" + Convert.ToString(Convert.ToInt32(TB_J2tirar1.Text) + Convert.ToInt32(TB_J2tirar2.Text)) + "Pinos.png");
                //Suma 10 puntos por la chuza o por el spare.
                Puntos.GI_punteo += 10;
                if (TB_J2tirar1.Text != "10")
                {
                    Program.J2.GI_SparesTotales++;
                }
                //Si la bandera es True, es porque hizo una chuza.
                if (Puntos.GB_banderaChuza == true)
                {
                    //Suma 1 al contador de las ChuzasTotales.
                    Program.J2.GI_ChuzasTotales++;
                    //Abre el Form de la chuza.
                    Tirar.ShowDialog();
                    //Guarda en una variable el resultado del tiro de la chuza.
                    Extraaa = Tirar.tiroEx;
                    //Calcula los puntos por ese punto.
                    Puntos.cuantosExtra(Extraaa);
                }
                //Le indica al jugador cuantos puntos lleva.
                MessageBox.Show("Tienes: " + Puntos.GI_punteo + " puntos. \nTe quedan: " + Program.J2.GI_turnosRestantes + " turnos.");
                TB_J2tirar1.Text = "";
                TB_J2tirar2.Text = "";
                TB_J2tirar1.Focus();
                BTN_tirar2.Enabled = true;
            }
        }

        private void TIME_J2bola1a9_Tick(object sender, EventArgs e) //Timer del caso en el que se derrivan menos de 10 pinos. (Jugador 2).
        {
            if (X < 196) //Verifica si la imagen ya llego a la posición 196.
            {
                X++;
                PB_bolaJ2.Location = new Point(X, 20);
            }
            else
            {
                TIME_J2bola1a9.Stop(); //Cuando pasa de la posición 196 apaga el Timer.
                PB_bolaJ2.Visible = false; //Hace invisible la imagen.
                //Muestra en el PictureBox los pinos que tiro en total.
                PB_pinosJ2.Load("../../Resources/" + Convert.ToString(Convert.ToInt32(TB_J2tirar1.Text) + Convert.ToInt32(TB_J2tirar2.Text)) + "Pinos.png");
                //Si la bandera es True, es porque tiene un castigo.
                if (Puntos.GB_banderaCastigo == true)
                {
                    if (Program.J2.GI_turnosRestantes <= 0) //Por defecto si solo le queda 1 turno y comete un castigo. Regresa que le quedan 0 turnos y no un número negativo.
                    {
                        //Le indica al jugador cuantos puntos lleva.
                        MessageBox.Show("Tienes: " + Puntos.GI_punteo + " puntos. \nTe quedan: 0 turnos.");
                        TB_J2tirar1.Text = "";
                        TB_J2tirar2.Text = "";
                        TB_J2tirar1.Focus();
                        BTN_tirar2.Enabled = true;
                    }
                    else
                    {
                        //Suma 1 al contador de los CastigosTotales.
                        Program.J2.GI_CastigosTotales++;
                        //Disminuye el limite de tiros.
                        Program.J2.GI_Limite -= 1;
                        //Disminuye los turnos que le quedan.
                        Program.J2.GI_turnosRestantes -= 1;
                        //Le indica al jugador cuantos puntos lleva.
                        MessageBox.Show("Tienes: " + Puntos.GI_punteo + " puntos. \nTe quedan: " + Program.J2.GI_turnosRestantes + " turnos.");
                        TB_J2tirar1.Text = "";
                        TB_J2tirar2.Text = "";
                        TB_J2tirar1.Focus();
                        BTN_tirar2.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Tienes: " + Puntos.GI_punteo + " puntos. \nTe quedan: " + Program.J2.GI_turnosRestantes + " turnos.");
                    TB_J2tirar1.Text = "";
                    TB_J2tirar2.Text = "";
                    TB_J2tirar1.Focus();
                    BTN_tirar2.Enabled = true;
                }
            }
        }

        private void BTN_tirar3_Click(object sender, EventArgs e) //Jugador 3.
        {
            //Contador de turnos del jugador 3.
            Program.J3.GI_Turnos += 1;
            try //Try & Catch por si el usuario ingresa una cadena en lugar de un entero en el TextBox "TB_J3tirar1".
            {
                //Condicional que permite que el jugador siga haciendo turnos hasta que alcance el límite.
                if (Program.J3.GI_Turnos <= Program.J3.GI_Limite)
                {
                    //Le indica al jugador el turno en el que va.
                    L_tiroJ3.Text = "Turno #" + Program.J3.GI_Turnos.ToString();
                    //Variable que indica cuantos turnos le quedan.
                    Program.J3.GI_turnosRestantes -= 1;
                    //Condicional que verifica si las cantidades ingresadas en "TB_J3tirar1" y "TB_J3tirar2" son menores o iguales a 10.
                    if (Convert.ToInt32(TB_J3tirar1.Text) <= 10 && Convert.ToInt32(TB_J3tirar2.Text) <= 10)
                    {
                        //Verifica su la suma de los 2 tiros es exactamente 10. Significa que es chuza o spare.
                        if (Convert.ToInt32(TB_J3tirar1.Text) + Convert.ToInt32(TB_J3tirar2.Text) == 10)
                        {
                            //Método cuantosPuntos de la Clase Punteo_Boliche, pide dos parametros.
                            //Los parametros que le llegaran serán los número que el usuario ingresó en los TextBox "TB_J3tirar1" y "TB_J3tirar2".
                            Puntos.cuantosPuntos(Convert.ToInt32(TB_J3tirar1.Text), Convert.ToInt32(TB_J3tirar2.Text));
                            //¡ANIMACIÓN!
                            //Se resetean los pinos, la ubicación de la bola y el Timer.
                            PB_pinosJ3.Load("../../Resources/Boliche.png");
                            X = 180;
                            PB_bolaJ3.Location = new Point(X, 20);
                            PB_bolaJ3.Visible = true;
                            //Inicia el Timer del caso en el que se derrivan exactamente 10 pinos.
                            BTN_tirar3.Enabled = false;
                            TIME_J3bola10.Start();
                        }
                        if (Convert.ToInt32(TB_J3tirar1.Text) + Convert.ToInt32(TB_J3tirar2.Text) < 10) //Si la suma de los 2 tiros es menor a 10.
                        {
                            //Método cuantosPuntos de la Clase Punteo_Boliche, pide dos parametros.
                            //Los parametros que le llegaran serán los número que el usuario ingresó en los TextBox "TB_J3tirar1" y "TB_J3tirar2".
                            Puntos.cuantosPuntos(Convert.ToInt32(TB_J3tirar1.Text), Convert.ToInt32(TB_J3tirar2.Text));
                            //¡ANIMACIÓN!
                            //Se resetean los pinos, la ubicación de la bola y el Timer.
                            PB_pinosJ3.Load("../../Resources/Boliche.png");
                            X = 180;
                            PB_bolaJ3.Location = new Point(180, 20);
                            PB_bolaJ3.Visible = true;
                            //Inicia el Timer del caso en el que se derrivan menos de 10 pinos.
                            BTN_tirar3.Enabled = false;
                            TIME_J3bola1a9.Start();
                        }

                        if (Convert.ToInt32(TB_J3tirar1.Text) + Convert.ToInt32(TB_J3tirar2.Text) > 10)
                        {
                            //Quita el tiro que se conto.
                            Program.J3.GI_Turnos -= 1;
                            //Actualiza el texto que indica el tiro en el que el jugador va.
                            L_tiroJ3.Text = "Turno #" + Program.J3.GI_Turnos.ToString();
                            //Repone el turno que se desconto.
                            Program.J3.GI_turnosRestantes += 1;
                            //Mensaje que indica como funcionan los tiros y los turnos.
                            MessageBox.Show("¡El máximo número de pines que puedes derrivar por turno, entre los 2 tiros son 10!", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        //Quita el tiro que se conto.
                        Program.J3.GI_Turnos -= 1;
                        //Actualiza el texto que indica el tiro en el que el jugador va.
                        L_tiroJ3.Text = "Turno #" + Program.J3.GI_Turnos.ToString();
                        //Repone el turno que se desconto.
                        Program.J3.GI_turnosRestantes += 1;
                        //Mensaje que indica que el máximo de pines a derrivar son 10.
                        MessageBox.Show("¡El máximo número de pines que puedes derrivar son 10!", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("¡Llegaste al límite de tiros!", ".::INFO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Guarda el punteo total en una variable para el J3.
                    Program.J3.GI_PuntosFinales = Puntos.GI_punteo;
                    MessageBox.Show("Puntaje del Jugador 3: " + Convert.ToString(Program.J3.GI_PuntosFinales) + "\n*Total de Chuzas: " + Convert.ToString(Program.J3.GI_ChuzasTotales) + "\n*Total de Spare: " + Convert.ToString(Program.J3.GI_SparesTotales) + "\n*Total de Castigos: " + Convert.ToString(Program.J3.GI_CastigosTotales), ".::TOTAL::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpia los campos.
                    TB_J3tirar1.Text = "";
                    TB_J3tirar2.Text = "";
                    Puntos.GI_punteo = 0;
                    //Llama al método que apaga el panel del jugador 3.
                    OFF_Jugador3();
                    //Verifica si el siguiente panel esta visible.
                    if (PAN_jugador4.Visible == false)
                    {
                        this.Size = new Size(964, 655);
                        GB_resultado.Visible = true;
                        DGV_resultadoJuego.Rows.Add(3);
                        //Primer Jugador.
                        DGV_resultadoJuego[1, 0].Value = (Program.J1.GS_Nombre);
                        DGV_resultadoJuego[2, 0].Value = (Program.J1.GI_PuntosFinales);
                        DGV_resultadoJuego[3, 0].Value = (Program.J1.GI_ChuzasTotales);
                        DGV_resultadoJuego[4, 0].Value = (Program.J1.GI_SparesTotales);
                        DGV_resultadoJuego[5, 0].Value = (Program.J1.GI_CastigosTotales);
                        DGV_resultadoJuego.Rows[0].DefaultCellStyle.BackColor = Program.J1.GC_ColorPuro;
                        //Segundo Jugador.
                        DGV_resultadoJuego[1, 1].Value = (Program.J2.GS_Nombre);
                        DGV_resultadoJuego[2, 1].Value = (Program.J2.GI_PuntosFinales);
                        DGV_resultadoJuego[3, 1].Value = (Program.J2.GI_ChuzasTotales);
                        DGV_resultadoJuego[4, 1].Value = (Program.J2.GI_SparesTotales);
                        DGV_resultadoJuego[5, 1].Value = (Program.J2.GI_CastigosTotales);
                        DGV_resultadoJuego.Rows[1].DefaultCellStyle.BackColor = Program.J2.GC_ColorPuro;
                        //Tercer Jugador.
                        DGV_resultadoJuego[1, 2].Value = (Program.J3.GS_Nombre);
                        DGV_resultadoJuego[2, 2].Value = (Program.J3.GI_PuntosFinales);
                        DGV_resultadoJuego[3, 2].Value = (Program.J3.GI_ChuzasTotales);
                        DGV_resultadoJuego[4, 2].Value = (Program.J3.GI_SparesTotales);
                        DGV_resultadoJuego[5, 2].Value = (Program.J3.GI_CastigosTotales);
                        DGV_resultadoJuego.Rows[2].DefaultCellStyle.BackColor = Program.J3.GC_ColorPuro;
                        //Ordenar.
                        DGV_resultadoJuego.Sort(DGV_resultadoJuego.Columns["Punto"], ListSortDirection.Descending);
                        DGV_resultadoJuego[0, 0].Value = 1;
                        DGV_resultadoJuego[0, 1].Value = 2;
                        DGV_resultadoJuego[0, 2].Value = 3;
                    }
                    //Activa el turno del jugador 4.
                    TB_J4tirar1.Enabled = true;
                    BTN_tirar4.Enabled = true;
                }
            }
            catch
            {
                //Quita el tiro que se conto.
                Program.J3.GI_Turnos -= 1;
                //Actualiza el texto que indica el tiro en el que el jugador va.
                L_tiroJ3.Text = "Turno #" + Program.J3.GI_Turnos.ToString();
                //Repone el turno que se desconto.
                Program.J3.GI_turnosRestantes += 1;
                //Muestra el mensaje de error al usuario.
                MessageBox.Show("¡Ingresa una cantidad de pinos derrivados!", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TIME_J3bola10_Tick(object sender, EventArgs e) //Timer del caso en el que se derrivan los 10 pinos. (Jugador 3).
        {
            if (X < 196) //Verifica si la imagen ya llego a la posición 196.
            {
                X++;
                PB_bolaJ3.Location = new Point(X, 20);
            }
            else
            {
                TIME_J3bola10.Stop(); //Cuando pasa de la posición 196 apaga el Timer.
                PB_bolaJ3.Visible = false; //Hace invisible la imagen.
                //Muestra en el PictureBox los pinos que tiro en total.
                PB_pinosJ3.Load("../../Resources/" + Convert.ToString(Convert.ToInt32(TB_J3tirar1.Text) + Convert.ToInt32(TB_J3tirar2.Text)) + "Pinos.png");
                //Suma 10 puntos por la chuza o por el spare.
                Puntos.GI_punteo += 10;
                if (TB_J3tirar1.Text != "10")
                {
                    Program.J3.GI_SparesTotales++;
                }
                //Si la bandera es True, es porque hizo una chuza.
                if (Puntos.GB_banderaChuza == true)
                {
                    //Suma 1 al contador de las ChuzasTotales.
                    Program.J3.GI_ChuzasTotales++;
                    //Abre el Form de la chuza.
                    Tirar.ShowDialog();
                    //Guarda en una variable el resultado del tiro de la chuza.
                    Extraaa = Tirar.tiroEx;
                    //Calcula los puntos por ese punto.
                    Puntos.cuantosExtra(Extraaa);
                }
                //Le indica al jugador cuantos puntos lleva.
                MessageBox.Show("Tienes: " + Puntos.GI_punteo + " puntos. \nTe quedan: " + Program.J3.GI_turnosRestantes + " turnos.");
                TB_J3tirar1.Text = "";
                TB_J3tirar2.Text = "";
                TB_J3tirar1.Focus();
                BTN_tirar3.Enabled = true;
            }
        }

        private void TIME_J3bola1a9_Tick(object sender, EventArgs e) //Timer del caso en el que se derrivan menos de 10 pinos. (Jugador 3).
        {
            if (X < 196) //Verifica si la imagen ya llego a la posición 196.
            {
                X++;
                PB_bolaJ3.Location = new Point(X, 20);
            }
            else
            {
                TIME_J3bola1a9.Stop(); //Cuando pasa de la posición 196 apaga el Timer.
                PB_bolaJ3.Visible = false; //Hace invisible la imagen.
                //Muestra en el PictureBox los pinos que tiro en total.
                PB_pinosJ3.Load("../../Resources/" + Convert.ToString(Convert.ToInt32(TB_J3tirar1.Text) + Convert.ToInt32(TB_J3tirar2.Text)) + "Pinos.png");
                //Si la bandera es True, es porque tiene un castigo.
                if (Puntos.GB_banderaCastigo == true)
                {
                    if (Program.J3.GI_turnosRestantes <= 0) //Por defecto si solo le queda 1 turno y comete un castigo. Regresa que le quedan 0 turnos y no un número negativo.
                    {
                        //Le indica al jugador cuantos puntos lleva.
                        MessageBox.Show("Tienes: " + Puntos.GI_punteo + " puntos. \nTe quedan: 0 turnos.");
                        TB_J3tirar1.Text = "";
                        TB_J3tirar2.Text = "";
                        TB_J3tirar1.Focus();
                        BTN_tirar3.Enabled = true;
                    }
                    else
                    {
                        //Suma 1 al contador de los CastigosTotales.
                        Program.J3.GI_CastigosTotales++;
                        //Disminuye el limite de tiros.
                        Program.J3.GI_Limite -= 1;
                        //Disminuye los turnos que le quedan.
                        Program.J3.GI_turnosRestantes -= 1;
                        //Le indica al jugador cuantos puntos lleva.
                        MessageBox.Show("Tienes: " + Puntos.GI_punteo + " puntos. \nTe quedan: " + Program.J3.GI_turnosRestantes + " turnos.");
                        TB_J3tirar1.Text = "";
                        TB_J3tirar2.Text = "";
                        TB_J3tirar1.Focus();
                        BTN_tirar3.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Tienes: " + Puntos.GI_punteo + " puntos. \nTe quedan: " + Program.J3.GI_turnosRestantes + " turnos.");
                    TB_J3tirar1.Text = "";
                    TB_J3tirar2.Text = "";
                    TB_J3tirar1.Focus();
                    BTN_tirar3.Enabled = true;
                }
            }
        }

        private void BTN_tirar4_Click(object sender, EventArgs e) //Jugador 4.
        {
            //Contador de turnos del jugador 4.
            Program.J4.GI_Turnos += 1;
            try //Try & Catch por si el usuario ingresa una cadena en lugar de un entero en el TextBox "TB_J4tirar1".
            {
                //Condicional que permite que el jugador siga haciendo turnos hasta que alcance el límite.
                if (Program.J4.GI_Turnos <= Program.J4.GI_Limite)
                {
                    //Le indica al jugador el turno en el que va.
                    L_tiroJ4.Text = "Turno #" + Program.J4.GI_Turnos.ToString();
                    //Variable que indica cuantos turnos le quedan.
                    Program.J4.GI_turnosRestantes -= 1;
                    //Condicional que verifica si las cantidades ingresadas en "TB_J4tirar1" y "TB_J4tirar2" son menores o iguales a 10.
                    if (Convert.ToInt32(TB_J4tirar1.Text) <= 10 && Convert.ToInt32(TB_J4tirar2.Text) <= 10)
                    {
                        //Verifica su la suma de los 2 tiros es exactamente 10. Significa que es chuza o spare.
                        if (Convert.ToInt32(TB_J4tirar1.Text) + Convert.ToInt32(TB_J4tirar2.Text) == 10)
                        {
                            //Método cuantosPuntos de la Clase Punteo_Boliche, pide dos parametros.
                            //Los parametros que le llegaran serán los número que el usuario ingresó en los TextBox "TB_J4tirar1" y "TB_J4tirar2".
                            Puntos.cuantosPuntos(Convert.ToInt32(TB_J4tirar1.Text), Convert.ToInt32(TB_J4tirar2.Text));
                            //¡ANIMACIÓN!
                            //Se resetean los pinos, la ubicación de la bola y el Timer.
                            PB_pinosJ4.Load("../../Resources/Boliche.png");
                            X = 180;
                            PB_bolaJ4.Location = new Point(X, 20);
                            PB_bolaJ4.Visible = true;
                            //Inicia el Timer del caso en el que se derrivan exactamente 10 pinos.
                            BTN_tirar4.Enabled = false;
                            TIME_J4bola10.Start();
                        }
                        if (Convert.ToInt32(TB_J4tirar1.Text) + Convert.ToInt32(TB_J4tirar2.Text) < 10) //Si la suma de los 2 tiros es menor a 10.
                        {
                            //Método cuantosPuntos de la Clase Punteo_Boliche, pide dos parametros.
                            //Los parametros que le llegaran serán los número que el usuario ingresó en los TextBox "TB_J4tirar1" y "TB_J4tirar2".
                            Puntos.cuantosPuntos(Convert.ToInt32(TB_J4tirar1.Text), Convert.ToInt32(TB_J4tirar2.Text));
                            //¡ANIMACIÓN!
                            //Se resetean los pinos, la ubicación de la bola y el Timer.
                            PB_pinosJ4.Load("../../Resources/Boliche.png");
                            X = 180;
                            PB_bolaJ4.Location = new Point(180, 20);
                            PB_bolaJ4.Visible = true;
                            //Inicia el Timer del caso en el que se derrivan menos de 10 pinos.
                            BTN_tirar4.Enabled = false;
                            TIME_J4bola1a9.Start();
                        }

                        if (Convert.ToInt32(TB_J4tirar1.Text) + Convert.ToInt32(TB_J4tirar2.Text) > 10)
                        {
                            //Quita el tiro que se conto.
                            Program.J4.GI_Turnos -= 1;
                            //Actualiza el texto que indica el tiro en el que el jugador va.
                            L_tiroJ4.Text = "Turno #" + Program.J4.GI_Turnos.ToString();
                            //Repone el turno que se desconto.
                            Program.J4.GI_turnosRestantes += 1;
                            //Mensaje que indica como funcionan los tiros y los turnos.
                            MessageBox.Show("¡El máximo número de pines que puedes derrivar por turno, entre los 2 tiros son 10!", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        //Quita el tiro que se conto.
                        Program.J4.GI_Turnos -= 1;
                        //Actualiza el texto que indica el tiro en el que el jugador va.
                        L_tiroJ4.Text = "Turno #" + Program.J4.GI_Turnos.ToString();
                        //Repone el turno que se desconto.
                        Program.J4.GI_turnosRestantes += 1;
                        //Mensaje que indica que el máximo de pines a derrivar son 10.
                        MessageBox.Show("¡El máximo número de pines que puedes derrivar son 10!", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("¡Llegaste al límite de tiros!", ".::INFO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Guarda el punteo total en una variable para el J4.
                    Program.J4.GI_PuntosFinales = Puntos.GI_punteo;
                    MessageBox.Show("Puntaje del Jugador 4: " + Convert.ToString(Program.J4.GI_PuntosFinales) + "\n*Total de Chuzas: " + Convert.ToString(Program.J4.GI_ChuzasTotales) + "\n*Total de Spare: " + Convert.ToString(Program.J4.GI_SparesTotales) + "\n*Total de Castigos: " + Convert.ToString(Program.J4.GI_CastigosTotales), ".::TOTAL::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpia los campos.
                    TB_J4tirar1.Text = "";
                    TB_J4tirar2.Text = "";
                    Puntos.GI_punteo = 0;
                    //Llama al método que apaga el panel del jugador 4.
                    OFF_Jugador4();
                    //Verifica si el siguiente panel esta visible.
                    if (PAN_jugador5.Visible == false)
                    {
                        this.Size = new Size(964, 655);
                        GB_resultado.Visible = true;
                        DGV_resultadoJuego.Rows.Add(4);
                        //Primer Jugador.
                        DGV_resultadoJuego[1, 0].Value = (Program.J1.GS_Nombre);
                        DGV_resultadoJuego[2, 0].Value = (Program.J1.GI_PuntosFinales);
                        DGV_resultadoJuego[3, 0].Value = (Program.J1.GI_ChuzasTotales);
                        DGV_resultadoJuego[4, 0].Value = (Program.J1.GI_SparesTotales);
                        DGV_resultadoJuego[5, 0].Value = (Program.J1.GI_CastigosTotales);
                        DGV_resultadoJuego.Rows[0].DefaultCellStyle.BackColor = Program.J1.GC_ColorPuro;
                        //Segundo Jugador.
                        DGV_resultadoJuego[1, 1].Value = (Program.J2.GS_Nombre);
                        DGV_resultadoJuego[2, 1].Value = (Program.J2.GI_PuntosFinales);
                        DGV_resultadoJuego[3, 1].Value = (Program.J2.GI_ChuzasTotales);
                        DGV_resultadoJuego[4, 1].Value = (Program.J2.GI_SparesTotales);
                        DGV_resultadoJuego[5, 1].Value = (Program.J2.GI_CastigosTotales);
                        DGV_resultadoJuego.Rows[1].DefaultCellStyle.BackColor = Program.J2.GC_ColorPuro;
                        //Tercer Jugador.
                        DGV_resultadoJuego[1, 2].Value = (Program.J3.GS_Nombre);
                        DGV_resultadoJuego[2, 2].Value = (Program.J3.GI_PuntosFinales);
                        DGV_resultadoJuego[3, 2].Value = (Program.J3.GI_ChuzasTotales);
                        DGV_resultadoJuego[4, 2].Value = (Program.J3.GI_SparesTotales);
                        DGV_resultadoJuego[5, 2].Value = (Program.J3.GI_CastigosTotales);
                        DGV_resultadoJuego.Rows[2].DefaultCellStyle.BackColor = Program.J3.GC_ColorPuro;
                        //Cuarto Jugador.
                        DGV_resultadoJuego[1, 3].Value = (Program.J4.GS_Nombre);
                        DGV_resultadoJuego[2, 3].Value = (Program.J4.GI_PuntosFinales);
                        DGV_resultadoJuego[3, 3].Value = (Program.J4.GI_ChuzasTotales);
                        DGV_resultadoJuego[4, 3].Value = (Program.J4.GI_SparesTotales);
                        DGV_resultadoJuego[5, 3].Value = (Program.J4.GI_CastigosTotales);
                        DGV_resultadoJuego.Rows[3].DefaultCellStyle.BackColor = Program.J4.GC_ColorPuro;
                        //Ordenar.
                        DGV_resultadoJuego.Sort(DGV_resultadoJuego.Columns["Punto"], ListSortDirection.Descending);
                        DGV_resultadoJuego[0, 0].Value = 1;
                        DGV_resultadoJuego[0, 1].Value = 2;
                        DGV_resultadoJuego[0, 2].Value = 3;
                        DGV_resultadoJuego[0, 3].Value = 4;
                    }
                    //Activa el turno del jugador 5.
                    TB_J5tirar1.Enabled = true;
                    BTN_tirar5.Enabled = true;
                }
            }
            catch
            {
                //Quita el tiro que se conto.
                Program.J4.GI_Turnos -= 1;
                //Actualiza el texto que indica el tiro en el que el jugador va.
                L_tiroJ4.Text = "Turno #" + Program.J4.GI_Turnos.ToString();
                //Repone el turno que se desconto.
                Program.J4.GI_turnosRestantes += 1;
                //Muestra el mensaje de error al usuario.
                MessageBox.Show("¡Ingresa una cantidad de pinos derrivados!", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TIME_J4bola10_Tick(object sender, EventArgs e) //Timer del caso en el que se derrivan los 10 pinos. (Jugador 4).
        {
            if (X < 196) //Verifica si la imagen ya llego a la posición 196.
            {
                X++;
                PB_bolaJ4.Location = new Point(X, 20);
            }
            else
            {
                TIME_J4bola10.Stop(); //Cuando pasa de la posición 196 apaga el Timer.
                PB_bolaJ4.Visible = false; //Hace invisible la imagen.
                //Muestra en el PictureBox los pinos que tiro en total.
                PB_pinosJ4.Load("../../Resources/" + Convert.ToString(Convert.ToInt32(TB_J4tirar1.Text) + Convert.ToInt32(TB_J4tirar2.Text)) + "Pinos.png");
                //Suma 10 puntos por la chuza o por el spare.
                Puntos.GI_punteo += 10;
                if (TB_J4tirar1.Text != "10")
                {
                    Program.J4.GI_SparesTotales++;
                }
                //Si la bandera es True, es porque hizo una chuza.
                if (Puntos.GB_banderaChuza == true)
                {
                    //Suma 1 al contador de las ChuzasTotales.
                    Program.J4.GI_ChuzasTotales++;
                    //Abre el Form de la chuza.
                    Tirar.ShowDialog();
                    //Guarda en una variable el resultado del tiro de la chuza.
                    Extraaa = Tirar.tiroEx;
                    //Calcula los puntos por ese punto.
                    Puntos.cuantosExtra(Extraaa);
                }
                //Le indica al jugador cuantos puntos lleva.
                MessageBox.Show("Tienes: " + Puntos.GI_punteo + " puntos. \nTe quedan: " + Program.J4.GI_turnosRestantes + " turnos.");
                TB_J4tirar1.Text = "";
                TB_J4tirar2.Text = "";
                TB_J4tirar1.Focus();
                BTN_tirar4.Enabled = true;
            }
        }

        private void TIME_J4bola1a9_Tick(object sender, EventArgs e) //Timer del caso en el que se derrivan menos de 10 pinos. (Jugador 4).
        {
            if (X < 196) //Verifica si la imagen ya llego a la posición 196.
            {
                X++;
                PB_bolaJ4.Location = new Point(X, 20);
            }
            else
            {
                TIME_J4bola1a9.Stop(); //Cuando pasa de la posición 196 apaga el Timer.
                PB_bolaJ4.Visible = false; //Hace invisible la imagen.
                //Muestra en el PictureBox los pinos que tiro en total.
                PB_pinosJ4.Load("../../Resources/" + Convert.ToString(Convert.ToInt32(TB_J4tirar1.Text) + Convert.ToInt32(TB_J4tirar2.Text)) + "Pinos.png");
                //Si la bandera es True, es porque tiene un castigo.
                if (Puntos.GB_banderaCastigo == true)
                {
                    if (Program.J4.GI_turnosRestantes <= 0) //Por defecto si solo le queda 1 turno y comete un castigo. Regresa que le quedan 0 turnos y no un número negativo.
                    {
                        //Le indica al jugador cuantos puntos lleva.
                        MessageBox.Show("Tienes: " + Puntos.GI_punteo + " puntos. \nTe quedan: 0 turnos.");
                        TB_J4tirar1.Text = "";
                        TB_J4tirar2.Text = "";
                        TB_J4tirar1.Focus();
                        BTN_tirar4.Enabled = true;
                    }
                    else
                    {
                        //Suma 1 al contador de los CastigosTotales.
                        Program.J4.GI_CastigosTotales++;
                        //Disminuye el limite de tiros.
                        Program.J4.GI_Limite -= 1;
                        //Disminuye los turnos que le quedan.
                        Program.J4.GI_turnosRestantes -= 1;
                        //Le indica al jugador cuantos puntos lleva.
                        MessageBox.Show("Tienes: " + Puntos.GI_punteo + " puntos. \nTe quedan: " + Program.J4.GI_turnosRestantes + " turnos.");
                        TB_J4tirar1.Text = "";
                        TB_J4tirar2.Text = "";
                        TB_J4tirar1.Focus();
                        BTN_tirar4.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Tienes: " + Puntos.GI_punteo + " puntos. \nTe quedan: " + Program.J4.GI_turnosRestantes + " turnos.");
                    TB_J4tirar1.Text = "";
                    TB_J4tirar2.Text = "";
                    TB_J4tirar1.Focus();
                    BTN_tirar4.Enabled = true;
                }
            }
        }

        private void BTN_tirar5_Click(object sender, EventArgs e) //Jugador 5.
        {
            //Contador de turnos del jugador 5.
            Program.J5.GI_Turnos += 1;
            try //Try & Catch por si el usuario ingresa una cadena en lugar de un entero en el TextBox "TB_J5tirar1".
            {
                //Condicional que permite que el jugador siga haciendo turnos hasta que alcance el límite.
                if (Program.J5.GI_Turnos <= Program.J5.GI_Limite)
                {
                    //Le indica al jugador el turno en el que va.
                    L_tiroJ5.Text = "Turno #" + Program.J5.GI_Turnos.ToString();
                    //Variable que indica cuantos turnos le quedan.
                    Program.J5.GI_turnosRestantes -= 1;
                    //Condicional que verifica si las cantidades ingresadas en "TB_J5tirar1" y "TB_J5tirar2" son menores o iguales a 10.
                    if (Convert.ToInt32(TB_J5tirar1.Text) <= 10 && Convert.ToInt32(TB_J5tirar2.Text) <= 10)
                    {
                        //Verifica su la suma de los 2 tiros es exactamente 10. Significa que es chuza o spare.
                        if (Convert.ToInt32(TB_J5tirar1.Text) + Convert.ToInt32(TB_J5tirar2.Text) == 10)
                        {
                            //Método cuantosPuntos de la Clase Punteo_Boliche, pide dos parametros.
                            //Los parametros que le llegaran serán los número que el usuario ingresó en los TextBox "TB_J5tirar1" y "TB_J5tirar2".
                            Puntos.cuantosPuntos(Convert.ToInt32(TB_J5tirar1.Text), Convert.ToInt32(TB_J5tirar2.Text));
                            //¡ANIMACIÓN!
                            //Se resetean los pinos, la ubicación de la bola y el Timer.
                            PB_pinosJ5.Load("../../Resources/Boliche.png");
                            X = 180;
                            PB_bolaJ5.Location = new Point(X, 20);
                            PB_bolaJ5.Visible = true;
                            //Inicia el Timer del caso en el que se derrivan exactamente 10 pinos.
                            BTN_tirar5.Enabled = false;
                            TIME_J5bola10.Start();
                        }
                        if (Convert.ToInt32(TB_J5tirar1.Text) + Convert.ToInt32(TB_J5tirar2.Text) < 10) //Si la suma de los 2 tiros es menor a 10.
                        {
                            //Método cuantosPuntos de la Clase Punteo_Boliche, pide dos parametros.
                            //Los parametros que le llegaran serán los número que el usuario ingresó en los TextBox "TB_J5tirar1" y "TB_J5tirar2".
                            Puntos.cuantosPuntos(Convert.ToInt32(TB_J5tirar1.Text), Convert.ToInt32(TB_J5tirar2.Text));
                            //¡ANIMACIÓN!
                            //Se resetean los pinos, la ubicación de la bola y el Timer.
                            PB_pinosJ5.Load("../../Resources/Boliche.png");
                            X = 180;
                            PB_bolaJ5.Location = new Point(180, 20);
                            PB_bolaJ5.Visible = true;
                            //Inicia el Timer del caso en el que se derrivan menos de 10 pinos.
                            BTN_tirar5.Enabled = false;
                            TIME_J5bola1a9.Start();
                        }

                        if (Convert.ToInt32(TB_J5tirar1.Text) + Convert.ToInt32(TB_J5tirar2.Text) > 10)
                        {
                            //Quita el tiro que se conto.
                            Program.J5.GI_Turnos -= 1;
                            //Actualiza el texto que indica el tiro en el que el jugador va.
                            L_tiroJ5.Text = "Turno #" + Program.J5.GI_Turnos.ToString();
                            //Repone el turno que se desconto.
                            Program.J5.GI_turnosRestantes += 1;
                            //Mensaje que indica como funcionan los tiros y los turnos.
                            MessageBox.Show("¡El máximo número de pines que puedes derrivar por turno, entre los 2 tiros son 10!", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        //Quita el tiro que se conto.
                        Program.J5.GI_Turnos -= 1;
                        //Actualiza el texto que indica el tiro en el que el jugador va.
                        L_tiroJ5.Text = "Turno #" + Program.J5.GI_Turnos.ToString();
                        //Repone el turno que se desconto.
                        Program.J5.GI_turnosRestantes += 1;
                        //Mensaje que indica que el máximo de pines a derrivar son 10.
                        MessageBox.Show("¡El máximo número de pines que puedes derrivar son 10!", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("¡Llegaste al límite de tiros!", ".::INFO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Guarda el punteo total en una variable para el J5.
                    Program.J5.GI_PuntosFinales = Puntos.GI_punteo;
                    MessageBox.Show("Puntaje del Jugador 5: " + Convert.ToString(Program.J5.GI_PuntosFinales) + "\n*Total de Chuzas: " + Convert.ToString(Program.J5.GI_ChuzasTotales) + "\n*Total de Spare: " + Convert.ToString(Program.J5.GI_SparesTotales) + "\n*Total de Castigos: " + Convert.ToString(Program.J5.GI_CastigosTotales), ".::TOTAL::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpia los campos.
                    TB_J5tirar1.Text = "";
                    TB_J5tirar2.Text = "";
                    Puntos.GI_punteo = 0;
                    //Llama al método que apaga el panel del jugador 5.
                    OFF_Jugador5();
                    //Verifica si el siguiente panel esta visible.
                    if (PAN_jugador6.Visible == false)
                    {
                        this.Size = new Size(964, 655);
                        GB_resultado.Visible = true;
                        DGV_resultadoJuego.Rows.Add(5);
                        //Primer Jugador.
                        DGV_resultadoJuego[1, 0].Value = (Program.J1.GS_Nombre);
                        DGV_resultadoJuego[2, 0].Value = (Program.J1.GI_PuntosFinales);
                        DGV_resultadoJuego[3, 0].Value = (Program.J1.GI_ChuzasTotales);
                        DGV_resultadoJuego[4, 0].Value = (Program.J1.GI_SparesTotales);
                        DGV_resultadoJuego[5, 0].Value = (Program.J1.GI_CastigosTotales);
                        DGV_resultadoJuego.Rows[0].DefaultCellStyle.BackColor = Program.J1.GC_ColorPuro;
                        //Segundo Jugador.
                        DGV_resultadoJuego[1, 1].Value = (Program.J2.GS_Nombre);
                        DGV_resultadoJuego[2, 1].Value = (Program.J2.GI_PuntosFinales);
                        DGV_resultadoJuego[3, 1].Value = (Program.J2.GI_ChuzasTotales);
                        DGV_resultadoJuego[4, 1].Value = (Program.J2.GI_SparesTotales);
                        DGV_resultadoJuego[5, 1].Value = (Program.J2.GI_CastigosTotales);
                        DGV_resultadoJuego.Rows[1].DefaultCellStyle.BackColor = Program.J2.GC_ColorPuro;
                        //Tercer Jugador.
                        DGV_resultadoJuego[1, 2].Value = (Program.J3.GS_Nombre);
                        DGV_resultadoJuego[2, 2].Value = (Program.J3.GI_PuntosFinales);
                        DGV_resultadoJuego[3, 2].Value = (Program.J3.GI_ChuzasTotales);
                        DGV_resultadoJuego[4, 2].Value = (Program.J3.GI_SparesTotales);
                        DGV_resultadoJuego[5, 2].Value = (Program.J3.GI_CastigosTotales);
                        DGV_resultadoJuego.Rows[2].DefaultCellStyle.BackColor = Program.J3.GC_ColorPuro;
                        //Cuarto Jugador.
                        DGV_resultadoJuego[1, 3].Value = (Program.J4.GS_Nombre);
                        DGV_resultadoJuego[2, 3].Value = (Program.J4.GI_PuntosFinales);
                        DGV_resultadoJuego[3, 3].Value = (Program.J4.GI_ChuzasTotales);
                        DGV_resultadoJuego[4, 3].Value = (Program.J4.GI_SparesTotales);
                        DGV_resultadoJuego[5, 3].Value = (Program.J4.GI_CastigosTotales);
                        DGV_resultadoJuego.Rows[3].DefaultCellStyle.BackColor = Program.J4.GC_ColorPuro;
                        //Quinto Jugador.
                        DGV_resultadoJuego[1, 4].Value = (Program.J5.GS_Nombre);
                        DGV_resultadoJuego[2, 4].Value = (Program.J5.GI_PuntosFinales);
                        DGV_resultadoJuego[3, 4].Value = (Program.J5.GI_ChuzasTotales);
                        DGV_resultadoJuego[4, 4].Value = (Program.J5.GI_SparesTotales);
                        DGV_resultadoJuego[5, 4].Value = (Program.J5.GI_CastigosTotales);
                        DGV_resultadoJuego.Rows[4].DefaultCellStyle.BackColor = Program.J5.GC_ColorPuro;
                        //Ordenar.
                        DGV_resultadoJuego.Sort(DGV_resultadoJuego.Columns["Punto"], ListSortDirection.Descending);
                        DGV_resultadoJuego[0, 0].Value = 1;
                        DGV_resultadoJuego[0, 1].Value = 2;
                        DGV_resultadoJuego[0, 2].Value = 3;
                        DGV_resultadoJuego[0, 3].Value = 4;
                        DGV_resultadoJuego[0, 4].Value = 5;
                    }
                    //Activa el turno del jugador 6.
                    TB_J6tirar1.Enabled = true;
                    BTN_tirar6.Enabled = true;
                }
            }
            catch
            {
                //Quita el tiro que se conto.
                Program.J5.GI_Turnos -= 1;
                //Actualiza el texto que indica el tiro en el que el jugador va.
                L_tiroJ5.Text = "Turno #" + Program.J5.GI_Turnos.ToString();
                //Repone el turno que se desconto.
                Program.J5.GI_turnosRestantes += 1;
                //Muestra el mensaje de error al usuario.
                MessageBox.Show("¡Ingresa una cantidad de pinos derrivados!", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TIME_J5bola10_Tick(object sender, EventArgs e) //Timer del caso en el que se derrivan los 10 pinos. (Jugador 5).
        {
            if (X < 196) //Verifica si la imagen ya llego a la posición 196.
            {
                X++;
                PB_bolaJ5.Location = new Point(X, 20);
            }
            else
            {
                TIME_J5bola10.Stop(); //Cuando pasa de la posición 196 apaga el Timer.
                PB_bolaJ5.Visible = false; //Hace invisible la imagen.
                //Muestra en el PictureBox los pinos que tiro en total.
                PB_pinosJ5.Load("../../Resources/" + Convert.ToString(Convert.ToInt32(TB_J5tirar1.Text) + Convert.ToInt32(TB_J5tirar2.Text)) + "Pinos.png");
                //Suma 10 puntos por la chuza o por el spare.
                Puntos.GI_punteo += 10;
                if (TB_J5tirar1.Text != "10")
                {
                    Program.J5.GI_SparesTotales++;
                }
                //Si la bandera es True, es porque hizo una chuza.
                if (Puntos.GB_banderaChuza == true)
                {
                    //Suma 1 al contador de las ChuzasTotales.
                    Program.J5.GI_ChuzasTotales++;
                    //Abre el Form de la chuza.
                    Tirar.ShowDialog();
                    //Guarda en una variable el resultado del tiro de la chuza.
                    Extraaa = Tirar.tiroEx;
                    //Calcula los puntos por ese punto.
                    Puntos.cuantosExtra(Extraaa);
                }
                //Le indica al jugador cuantos puntos lleva.
                MessageBox.Show("Tienes: " + Puntos.GI_punteo + " puntos. \nTe quedan: " + Program.J5.GI_turnosRestantes + " turnos.");
                TB_J5tirar1.Text = "";
                TB_J5tirar2.Text = "";
                TB_J5tirar1.Focus();
                BTN_tirar5.Enabled = true;
            }
        }

        private void TIME_J5bola1a9_Tick(object sender, EventArgs e) //Timer del caso en el que se derrivan menos de 10 pinos. (Jugador 5).
        {
            if (X < 196) //Verifica si la imagen ya llego a la posición 196.
            {
                X++;
                PB_bolaJ5.Location = new Point(X, 20);
            }
            else
            {
                TIME_J5bola1a9.Stop(); //Cuando pasa de la posición 196 apaga el Timer.
                PB_bolaJ5.Visible = false; //Hace invisible la imagen.
                //Muestra en el PictureBox los pinos que tiro en total.
                PB_pinosJ5.Load("../../Resources/" + Convert.ToString(Convert.ToInt32(TB_J5tirar1.Text) + Convert.ToInt32(TB_J5tirar2.Text)) + "Pinos.png");
                //Si la bandera es True, es porque tiene un castigo.
                if (Puntos.GB_banderaCastigo == true)
                {
                    if (Program.J5.GI_turnosRestantes <= 0) //Por defecto si solo le queda 1 turno y comete un castigo. Regresa que le quedan 0 turnos y no un número negativo.
                    {
                        //Le indica al jugador cuantos puntos lleva.
                        MessageBox.Show("Tienes: " + Puntos.GI_punteo + " puntos. \nTe quedan: 0 turnos.");
                        TB_J5tirar1.Text = "";
                        TB_J5tirar2.Text = "";
                        TB_J5tirar1.Focus();
                        BTN_tirar5.Enabled = true;
                    }
                    else
                    {
                        //Suma 1 al contador de los CastigosTotales.
                        Program.J5.GI_CastigosTotales++;
                        //Disminuye el limite de tiros.
                        Program.J5.GI_Limite -= 1;
                        //Disminuye los turnos que le quedan.
                        Program.J5.GI_turnosRestantes -= 1;
                        //Le indica al jugador cuantos puntos lleva.
                        MessageBox.Show("Tienes: " + Puntos.GI_punteo + " puntos. \nTe quedan: " + Program.J5.GI_turnosRestantes + " turnos.");
                        TB_J5tirar1.Text = "";
                        TB_J5tirar2.Text = "";
                        TB_J5tirar1.Focus();
                        BTN_tirar5.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Tienes: " + Puntos.GI_punteo + " puntos. \nTe quedan: " + Program.J5.GI_turnosRestantes + " turnos.");
                    TB_J5tirar1.Text = "";
                    TB_J5tirar2.Text = "";
                    TB_J5tirar1.Focus();
                    BTN_tirar5.Enabled = true;
                }
            }
        }

        private void BTN_tirar6_Click(object sender, EventArgs e) //Jugador 6.
        {
            //Contador de turnos del jugador 6.
            Program.J6.GI_Turnos += 1;
            try //Try & Catch por si el usuario ingresa una cadena en lugar de un entero en el TextBox "TB_J6tirar1".
            {
                //Condicional que permite que el jugador siga haciendo turnos hasta que alcance el límite.
                if (Program.J6.GI_Turnos <= Program.J6.GI_Limite)
                {
                    //Le indica al jugador el turno en el que va.
                    L_tiroJ6.Text = "Turno #" + Program.J6.GI_Turnos.ToString();
                    //Variable que indica cuantos turnos le quedan.
                    Program.J6.GI_turnosRestantes -= 1;
                    //Condicional que verifica si las cantidades ingresadas en "TB_J6tirar1" y "TB_J6tirar2" son menores o iguales a 10.
                    if (Convert.ToInt32(TB_J6tirar1.Text) <= 10 && Convert.ToInt32(TB_J6tirar2.Text) <= 10)
                    {
                        //Verifica su la suma de los 2 tiros es exactamente 10. Significa que es chuza o spare.
                        if (Convert.ToInt32(TB_J6tirar1.Text) + Convert.ToInt32(TB_J6tirar2.Text) == 10)
                        {
                            //Método cuantosPuntos de la Clase Punteo_Boliche, pide dos parametros.
                            //Los parametros que le llegaran serán los número que el usuario ingresó en los TextBox "TB_J6tirar1" y "TB_J6tirar2".
                            Puntos.cuantosPuntos(Convert.ToInt32(TB_J6tirar1.Text), Convert.ToInt32(TB_J6tirar2.Text));
                            //¡ANIMACIÓN!
                            //Se resetean los pinos, la ubicación de la bola y el Timer.
                            PB_pinosJ6.Load("../../Resources/Boliche.png");
                            X = 180;
                            PB_bolaJ6.Location = new Point(X, 20);
                            PB_bolaJ6.Visible = true;
                            //Inicia el Timer del caso en el que se derrivan exactamente 10 pinos.
                            BTN_tirar6.Enabled = false;
                            TIME_J6bola10.Start();
                        }
                        if (Convert.ToInt32(TB_J6tirar1.Text) + Convert.ToInt32(TB_J6tirar2.Text) < 10) //Si la suma de los 2 tiros es menor a 10.
                        {
                            //Método cuantosPuntos de la Clase Punteo_Boliche, pide dos parametros.
                            //Los parametros que le llegaran serán los número que el usuario ingresó en los TextBox "TB_J6tirar1" y "TB_J6tirar2".
                            Puntos.cuantosPuntos(Convert.ToInt32(TB_J6tirar1.Text), Convert.ToInt32(TB_J6tirar2.Text));
                            //¡ANIMACIÓN!
                            //Se resetean los pinos, la ubicación de la bola y el Timer.
                            PB_pinosJ6.Load("../../Resources/Boliche.png");
                            X = 180;
                            PB_bolaJ6.Location = new Point(180, 20);
                            PB_bolaJ6.Visible = true;
                            //Inicia el Timer del caso en el que se derrivan menos de 10 pinos.
                            BTN_tirar6.Enabled = false;
                            TIME_J6bola1a9.Start();
                        }

                        if (Convert.ToInt32(TB_J6tirar1.Text) + Convert.ToInt32(TB_J6tirar2.Text) > 10)
                        {
                            //Quita el tiro que se conto.
                            Program.J6.GI_Turnos -= 1;
                            //Actualiza el texto que indica el tiro en el que el jugador va.
                            L_tiroJ6.Text = "Turno #" + Program.J6.GI_Turnos.ToString();
                            //Repone el turno que se desconto.
                            Program.J6.GI_turnosRestantes += 1;
                            //Mensaje que indica como funcionan los tiros y los turnos.
                            MessageBox.Show("¡El máximo número de pines que puedes derrivar por turno, entre los 2 tiros son 10!", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        //Quita el tiro que se conto.
                        Program.J6.GI_Turnos -= 1;
                        //Actualiza el texto que indica el tiro en el que el jugador va.
                        L_tiroJ6.Text = "Turno #" + Program.J6.GI_Turnos.ToString();
                        //Repone el turno que se desconto.
                        Program.J6.GI_turnosRestantes += 1;
                        //Mensaje que indica que el máximo de pines a derrivar son 10.
                        MessageBox.Show("¡El máximo número de pines que puedes derrivar son 10!", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("¡Llegaste al límite de tiros!", ".::INFO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Guarda el punteo total en una variable para el J6.
                    Program.J6.GI_PuntosFinales = Puntos.GI_punteo;
                    MessageBox.Show("Puntaje del Jugador 6: " + Convert.ToString(Program.J6.GI_PuntosFinales) + "\n*Total de Chuzas: " + Convert.ToString(Program.J6.GI_ChuzasTotales) + "\n*Total de Spare: " + Convert.ToString(Program.J6.GI_SparesTotales) + "\n*Total de Castigos: " + Convert.ToString(Program.J6.GI_CastigosTotales), ".::TOTAL::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpia los campos.
                    TB_J6tirar1.Text = "";
                    TB_J6tirar2.Text = "";
                    Puntos.GI_punteo = 0;
                    //Llama al método que apaga el panel del jugador 5.
                    OFF_Jugador6();
                    this.Size = new Size(964, 655);
                    GB_resultado.Visible = true;
                    DGV_resultadoJuego.Rows.Add(6);
                    //Primer Jugador.
                    DGV_resultadoJuego[1, 0].Value = (Program.J1.GS_Nombre);
                    DGV_resultadoJuego[2, 0].Value = (Program.J1.GI_PuntosFinales);
                    DGV_resultadoJuego[3, 0].Value = (Program.J1.GI_ChuzasTotales);
                    DGV_resultadoJuego[4, 0].Value = (Program.J1.GI_SparesTotales);
                    DGV_resultadoJuego[5, 0].Value = (Program.J1.GI_CastigosTotales);
                    DGV_resultadoJuego.Rows[0].DefaultCellStyle.BackColor = Program.J1.GC_ColorPuro;
                    //Segundo Jugador.
                    DGV_resultadoJuego[1, 1].Value = (Program.J2.GS_Nombre);
                    DGV_resultadoJuego[2, 1].Value = (Program.J2.GI_PuntosFinales);
                    DGV_resultadoJuego[3, 1].Value = (Program.J2.GI_ChuzasTotales);
                    DGV_resultadoJuego[4, 1].Value = (Program.J2.GI_SparesTotales);
                    DGV_resultadoJuego[5, 1].Value = (Program.J2.GI_CastigosTotales);
                    DGV_resultadoJuego.Rows[1].DefaultCellStyle.BackColor = Program.J2.GC_ColorPuro;
                    //Tercer Jugador.
                    DGV_resultadoJuego[1, 2].Value = (Program.J3.GS_Nombre);
                    DGV_resultadoJuego[2, 2].Value = (Program.J3.GI_PuntosFinales);
                    DGV_resultadoJuego[3, 2].Value = (Program.J3.GI_ChuzasTotales);
                    DGV_resultadoJuego[4, 2].Value = (Program.J3.GI_SparesTotales);
                    DGV_resultadoJuego[5, 2].Value = (Program.J3.GI_CastigosTotales);
                    DGV_resultadoJuego.Rows[2].DefaultCellStyle.BackColor = Program.J3.GC_ColorPuro;
                    //Cuarto Jugador.
                    DGV_resultadoJuego[1, 3].Value = (Program.J4.GS_Nombre);
                    DGV_resultadoJuego[2, 3].Value = (Program.J4.GI_PuntosFinales);
                    DGV_resultadoJuego[3, 3].Value = (Program.J4.GI_ChuzasTotales);
                    DGV_resultadoJuego[4, 3].Value = (Program.J4.GI_SparesTotales);
                    DGV_resultadoJuego[5, 3].Value = (Program.J4.GI_CastigosTotales);
                    DGV_resultadoJuego.Rows[3].DefaultCellStyle.BackColor = Program.J4.GC_ColorPuro;
                    //Quinto Jugador.
                    DGV_resultadoJuego[1, 4].Value = (Program.J5.GS_Nombre);
                    DGV_resultadoJuego[2, 4].Value = (Program.J5.GI_PuntosFinales);
                    DGV_resultadoJuego[3, 4].Value = (Program.J5.GI_ChuzasTotales);
                    DGV_resultadoJuego[4, 4].Value = (Program.J5.GI_SparesTotales);
                    DGV_resultadoJuego[5, 4].Value = (Program.J5.GI_CastigosTotales);
                    DGV_resultadoJuego.Rows[4].DefaultCellStyle.BackColor = Program.J5.GC_ColorPuro;
                    //Sexto Jugador.
                    DGV_resultadoJuego[1, 5].Value = (Program.J6.GS_Nombre);
                    DGV_resultadoJuego[2, 5].Value = (Program.J6.GI_PuntosFinales);
                    DGV_resultadoJuego[3, 5].Value = (Program.J6.GI_ChuzasTotales);
                    DGV_resultadoJuego[4, 5].Value = (Program.J6.GI_SparesTotales);
                    DGV_resultadoJuego[5, 5].Value = (Program.J6.GI_CastigosTotales);
                    DGV_resultadoJuego.Rows[5].DefaultCellStyle.BackColor = Program.J6.GC_ColorPuro;
                    //Ordenar.
                    DGV_resultadoJuego.Sort(DGV_resultadoJuego.Columns["Punto"], ListSortDirection.Descending);
                    DGV_resultadoJuego[0, 0].Value = 1;
                    DGV_resultadoJuego[0, 1].Value = 2;
                    DGV_resultadoJuego[0, 2].Value = 3;
                    DGV_resultadoJuego[0, 3].Value = 4;
                    DGV_resultadoJuego[0, 4].Value = 5;
                    DGV_resultadoJuego[0, 5].Value = 6;
                }
            }
            catch
            {
                //Quita el tiro que se conto.
                Program.J6.GI_Turnos -= 1;
                //Actualiza el texto que indica el tiro en el que el jugador va.
                L_tiroJ6.Text = "Turno #" + Program.J6.GI_Turnos.ToString();
                //Repone el turno que se desconto.
                Program.J6.GI_turnosRestantes += 1;
                //Muestra el mensaje de error al usuario.
                MessageBox.Show("¡Ingresa una cantidad de pinos derrivados!", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TIME_J6bola10_Tick(object sender, EventArgs e) //Timer del caso en el que se derrivan los 10 pinos. (Jugador 6).
        {
            if (X < 196) //Verifica si la imagen ya llego a la posición 196.
            {
                X++;
                PB_bolaJ6.Location = new Point(X, 20);
            }
            else
            {
                TIME_J6bola10.Stop(); //Cuando pasa de la posición 196 apaga el Timer.
                PB_bolaJ6.Visible = false; //Hace invisible la imagen.
                //Muestra en el PictureBox los pinos que tiro en total.
                PB_pinosJ6.Load("../../Resources/" + Convert.ToString(Convert.ToInt32(TB_J6tirar1.Text) + Convert.ToInt32(TB_J6tirar2.Text)) + "Pinos.png");
                //Suma 10 puntos por la chuza o por el spare.
                Puntos.GI_punteo += 10;
                if (TB_J6tirar1.Text != "10")
                {
                    Program.J6.GI_SparesTotales++;
                }
                //Si la bandera es True, es porque hizo una chuza.
                if (Puntos.GB_banderaChuza == true)
                {
                    //Suma 1 al contador de las ChuzasTotales.
                    Program.J6.GI_ChuzasTotales++;
                    //Abre el Form de la chuza.
                    Tirar.ShowDialog();
                    //Guarda en una variable el resultado del tiro de la chuza.
                    Extraaa = Tirar.tiroEx;
                    //Calcula los puntos por ese punto.
                    Puntos.cuantosExtra(Extraaa);
                }
                //Le indica al jugador cuantos puntos lleva.
                MessageBox.Show("Tienes: " + Puntos.GI_punteo + " puntos. \nTe quedan: " + Program.J6.GI_turnosRestantes + " turnos.");
                TB_J6tirar1.Text = "";
                TB_J6tirar2.Text = "";
                TB_J6tirar1.Focus();
                BTN_tirar6.Enabled = true;
            }
        }

        private void TIME_J6bola1a9_Tick(object sender, EventArgs e) //Timer del caso en el que se derrivan menos de 10 pinos. (Jugador 6).
        {
            if (X < 196) //Verifica si la imagen ya llego a la posición 196.
            {
                X++;
                PB_bolaJ6.Location = new Point(X, 20);
            }
            else
            {
                TIME_J6bola1a9.Stop(); //Cuando pasa de la posición 196 apaga el Timer.
                PB_bolaJ6.Visible = false; //Hace invisible la imagen.
                //Muestra en el PictureBox los pinos que tiro en total.
                PB_pinosJ6.Load("../../Resources/" + Convert.ToString(Convert.ToInt32(TB_J6tirar1.Text) + Convert.ToInt32(TB_J6tirar2.Text)) + "Pinos.png");
                //Si la bandera es True, es porque tiene un castigo.
                if (Puntos.GB_banderaCastigo == true)
                {
                    if (Program.J6.GI_turnosRestantes <= 0) //Por defecto si solo le queda 1 turno y comete un castigo. Regresa que le quedan 0 turnos y no un número negativo.
                    {
                        //Le indica al jugador cuantos puntos lleva.
                        MessageBox.Show("Tienes: " + Puntos.GI_punteo + " puntos. \nTe quedan: 0 turnos.");
                        TB_J6tirar1.Text = "";
                        TB_J6tirar2.Text = "";
                        TB_J6tirar1.Focus();
                        BTN_tirar6.Enabled = true;
                    }
                    else
                    {
                        //Suma 1 al contador de los CastigosTotales.
                        Program.J6.GI_CastigosTotales++;
                        //Disminuye el limite de tiros.
                        Program.J6.GI_Limite -= 1;
                        //Disminuye los turnos que le quedan.
                        Program.J6.GI_turnosRestantes -= 1;
                        //Le indica al jugador cuantos puntos lleva.
                        MessageBox.Show("Tienes: " + Puntos.GI_punteo + " puntos. \nTe quedan: " + Program.J6.GI_turnosRestantes + " turnos.");
                        TB_J6tirar1.Text = "";
                        TB_J6tirar2.Text = "";
                        TB_J6tirar1.Focus();
                        BTN_tirar6.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Tienes: " + Puntos.GI_punteo + " puntos. \nTe quedan: " + Program.J6.GI_turnosRestantes + " turnos.");
                    TB_J6tirar1.Text = "";
                    TB_J6tirar2.Text = "";
                    TB_J6tirar1.Focus();
                    BTN_tirar6.Enabled = true;
                }
            }
        }
        //JUEGO. (FIN)
    }
}
