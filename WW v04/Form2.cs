using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WW_v04
{
    public partial class F2_Quiz : Form
    {
        //Declarar las variables del juego
        int rtacorrecta;
        int nropregunta = 1;
        int puntaje;
        int calificacion;
        int totalpreguntas;

// constructor de la clase F2_Quiz.
// Inicializa los componentes, pide la primera pregunta y establece el número total de preguntas en 13.
        public F2_Quiz()
        {
            InitializeComponent();
            PedirPregunta(nropregunta);
            totalpreguntas = 23;
        }

        private void F2_Quiz_Load(object sender, EventArgs e)
        { }

 //El método ClicAnswerEvent se ejecuta cuando el usuario hace clic en una de las opciones de respuesta. 
 //Determina si la respuesta seleccionada es correcta, actualiza el puntaje
 //y muestra un mensaje de finalización del juego si todas las preguntas han sido respondidas.
        private void ClickAnswerEvent(object sender, EventArgs e)
        {
            //convierte el objeto sender del tipo object al tipo de datos Button.
            var senderObject = (Button)sender;

            //defino una variable llamada buttonTag y almacena el valor de Tag convertido a un entero
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            //si el Tag coincide con la rta correcta incremento el puntaje
            if (buttonTag == rtacorrecta) 
            {
                //incremento puntaje en 1 
                puntaje ++; 
            }

            if(nropregunta == totalpreguntas)
            {
                calificacion = (int)Math.Round((double)(10 * puntaje) / totalpreguntas);

               // Abre el formulario Form4
                Form4 f4 = new Form4();
                f4.lbl_puntajefinal.Text = lbl_puntaje.Text;
                f4.lbl_calificacionfinal.Text = calificacion.ToString();
                f4.Show();
               
                // Cierra el formulario Form2
                this.Hide();
                puntaje = 0;
                nropregunta = 0;

                PedirPregunta(nropregunta);
             }
            nropregunta ++;
            PedirPregunta(nropregunta);
        }

        //Función con las opciones de preguntas. Este método toma un número de pregunta como entrada
        //muestra la pregunta correspondiente y las opciones de respuesta.
        //Utiliza un switch para determinar qué pregunta mostrar y cuál es la respuesta correcta.
        private void PedirPregunta(int qnum) 
        {
            switch (qnum)
            {
                case 1:
                    //defino la 1° imagen
                    pictureBox1.Image = Properties.Resources.case1_calculadora;

                    // transfiero puntaje al label convirtiendo el nro a texto
                    lbl_puntaje.Text = puntaje.ToString();

                    // transfiero de nro de pregunta al label convirtiendo el nro a texto
                    lbl_nropregunta.Text = nropregunta.ToString();

                    //Modifico el contenido de los botones
                    button1.Text = "CALCULATOR";
                    button2.Text = "CALCULATIONS";
                    
                    //Indico cuál es la respuesta correcta
                    rtacorrecta = 1;

                    break;

                case 2:
                    
                    pictureBox1.Image = Properties.Resources.case2_lapiz;
                    lbl_puntaje.Text = puntaje.ToString();
                    lbl_nropregunta.Text = nropregunta.ToString();
                    button1.Text = "PEN";
                    button2.Text = "PENCIL";
                                        
                    rtacorrecta = 2;
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.case14_campera;
                    lbl_puntaje.Text = puntaje.ToString();
                    lbl_nropregunta.Text = nropregunta.ToString();
                    button1.Text = "JACKET";
                    button2.Text = "CAP";

                    rtacorrecta = 1;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.case4_goma;
                    lbl_puntaje.Text = puntaje.ToString();
                    lbl_nropregunta.Text = nropregunta.ToString();
                    button1.Text = "RUBBER";
                    button2.Text = "ERASER";

                    rtacorrecta = 2;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.case15_cometa;
                    lbl_puntaje.Text = puntaje.ToString();
                    lbl_nropregunta.Text = nropregunta.ToString();
                    button1.Text = "KITE";
                    button2.Text = "KEY";

                    rtacorrecta = 1;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.case6_libro;
                    lbl_puntaje.Text = puntaje.ToString();
                    lbl_nropregunta.Text = nropregunta.ToString();
                    button1.Text = "BOOK";
                    button2.Text = "NEWSPAPER";

                    rtacorrecta = 1;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.cartuchera__case1;
                    lbl_puntaje.Text = puntaje.ToString();
                    lbl_nropregunta.Text = nropregunta.ToString();
                    button1.Text = "BOX";
                    button2.Text = "PENCIL CASE";

                    rtacorrecta = 2;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.case16_estrella;
                    lbl_puntaje.Text = puntaje.ToString();
                    lbl_nropregunta.Text = nropregunta.ToString();
                    button1.Text = "START";
                    button2.Text = "STAR";

                    rtacorrecta = 2;
                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.case9_mochila;
                    lbl_puntaje.Text = puntaje.ToString();
                    lbl_nropregunta.Text = nropregunta.ToString();
                    button1.Text = "BAG";
                    button2.Text = "BACK";

                    rtacorrecta = 1;
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.case10_tijera;
                    lbl_puntaje.Text = puntaje.ToString();
                    lbl_nropregunta.Text = nropregunta.ToString();
                    button1.Text = "SCISSORS";
                    button2.Text = "SCIENCE";

                    rtacorrecta = 1;
                    break;

                case 11:
                    pictureBox1.Image = Properties.Resources.case17_pájaro;
                    lbl_puntaje.Text = puntaje.ToString();
                    lbl_nropregunta.Text = nropregunta.ToString();
                    button1.Text = "BIRD";
                    button2.Text = "BITE";

                    rtacorrecta = 1;
                    break;

                case 12:
                    pictureBox1.Image = Properties.Resources.case12_sacapuntas;
                    lbl_puntaje.Text = puntaje.ToString();
                    lbl_nropregunta.Text = nropregunta.ToString();
                    button1.Text = "SHARPENER";
                    button2.Text = "STAPLER";

                    rtacorrecta = 1;
                    break;

                case 13:
                    pictureBox1.Image = Properties.Resources.paleta__case;
                    lbl_puntaje.Text = puntaje.ToString();
                    lbl_nropregunta.Text = nropregunta.ToString();
                    button1.Text = "GLUE";
                    button2.Text = "PALETTE";

                    rtacorrecta = 2;
                    break;

                case 14:
                    pictureBox1.Image = Properties.Resources.case19_parque;
                    lbl_puntaje.Text = puntaje.ToString();
                    lbl_nropregunta.Text = nropregunta.ToString();
                    button1.Text = "PARK";
                    button2.Text = "PARKING";

                    rtacorrecta = 1;
                    break;

                case 15:
                    pictureBox1.Image = Properties.Resources.colores__case;
                    lbl_puntaje.Text = puntaje.ToString();
                    lbl_nropregunta.Text = nropregunta.ToString();
                    button1.Text = "COLORED" + Environment.NewLine + "PENCILS";
                    button2.Text = "COLORS";

                    rtacorrecta = 1;
                    break;

                case 16:
                    pictureBox1.Image = Properties.Resources.case18_pantalon;
                    lbl_puntaje.Text = puntaje.ToString();
                    lbl_nropregunta.Text = nropregunta.ToString();
                    button1.Text = "PANTS";
                    button2.Text = "SHORT";

                    rtacorrecta = 1;
                    break;
                case 17:
                    pictureBox1.Image = Properties.Resources.case11_pincel;
                    lbl_puntaje.Text = puntaje.ToString();
                    lbl_nropregunta.Text = nropregunta.ToString();
                    button1.Text = "BRUSH";
                    button2.Text = "PAINT";

                    rtacorrecta = 1;
                    break;
                case 18:
                    pictureBox1.Image = Properties.Resources.case20_planeta;
                    lbl_puntaje.Text = puntaje.ToString();
                    lbl_nropregunta.Text = nropregunta.ToString();
                    button1.Text = "EARTH";
                    button2.Text = "LAND";

                    rtacorrecta = 1;
                    break;
                case 19:
                    pictureBox1.Image = Properties.Resources.case8_hoja_de_carpeta;
                    lbl_puntaje.Text = puntaje.ToString();
                    lbl_nropregunta.Text = nropregunta.ToString();
                    button1.Text = "LEAF";
                    button2.Text = "FOLDER SHEET";

                    rtacorrecta = 2;
                    break;
                case 20:
                    pictureBox1.Image = Properties.Resources.case3_regla;
                    lbl_puntaje.Text = puntaje.ToString();
                    lbl_nropregunta.Text = nropregunta.ToString();
                    button1.Text = "RULER";
                    button2.Text = "RULE";
                    rtacorrecta = 1;
                    break;
                case 21:
                    pictureBox1.Image = Properties.Resources.case21_playa;
                    lbl_puntaje.Text = puntaje.ToString();
                    lbl_nropregunta.Text = nropregunta.ToString();
                    button1.Text = "BEACH";
                    button2.Text = "WISH";
                    rtacorrecta = 1;
                    break;

                case 22:
                    pictureBox1.Image = Properties.Resources.case22_zapatos;
                    lbl_puntaje.Text = puntaje.ToString();
                    lbl_nropregunta.Text = nropregunta.ToString();
                    button1.Text = "SHOULD";
                    button2.Text = "SHOES";
                    rtacorrecta = 2;
                    break;

                case 23:
                    pictureBox1.Image = Properties.Resources.case21_selva;
                    lbl_puntaje.Text = puntaje.ToString();
                    lbl_nropregunta.Text = nropregunta.ToString();
                    button1.Text = "JUNGLE";
                    button2.Text = "FORECAST";
                    rtacorrecta = 1;
                    break;
            }
        }
    }
}
