using System;
using AngouriMath;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AngouriMath.Entity;
using HonkSharp.Fluency;
using System.IO;

namespace Analisis_Numerico_Sistema_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (validacion() != "")
            {
                MessageBox.Show(validacion(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try {
                    //LIMPIEZA DE LOS DATOS
                    rtb_proceso.Clear();
                    dgv_solucion.Rows.Clear();

                    //FUNCION A ENCONTRAR RAIZ
                    Entity expresion = txt_Ecuacion.Text;
                    pbx_Ecuacion.Image = new Bitmap(EcuacionPNG.CrearEcuacion("f(x)= " + expresion.Latexise()));

                    //VARIABLES QUE SE VAN A UTILIZAR
                    int iteracion = 0;
                    double XI = Convert.ToDouble(num_XI.Value), XU = Convert.ToDouble(num_XU.Value), ErrorAproximado = 0, ErrorAproximadoPedido = Convert.ToDouble(num_error.Value);

                    //SI AL EVALUAR LA FUNCION EN UNO DE LOS EXTREMOS DEL INTERVALO F(X)=0 UN EXTREMO DEL INTERVALO ES RAIZ
                    if (EvaluarExpresion(XI) == 0 || EvaluarExpresion(XU) == 0)
                    {
                        if (EvaluarExpresion(XI) == 0)
                        {
                            rtb_proceso.AppendText("AL EVALUAR EL VALOR DEL PRIMER EXTREMO DEL INTERVALO (XI) SE OBTUVO QUE ESE VALOR ES UNA RAÍZ\n\n");
                            Clipboard.SetImage(Image.FromFile(EcuacionPNG.CrearEcuacion(("f(x)= " + expresion.Latexise() + "=0").Replace("x", XI.ToString()))));

                        }
                        else
                        {
                            rtb_proceso.AppendText("AL EVALUAR EL VALOR DEL SEGUNDO EXTREMO DEL INTERVALO (XU) SE OBTUVO QUE ESE VALOR ES UNA RAÍZ\n\n");
                            Clipboard.SetImage(Image.FromFile(EcuacionPNG.CrearEcuacion(("f(x)= " + expresion.Latexise() + "=0").Replace("x", XU.ToString()))));
                        }
                        soloCopiar();
                    }
                    //AL MULTIPLICAR F(XI)*F(XU) DEBERIAMOS OBTENER UN NUMERO NEGATIVO, SI NO, NO HAY RAIZ EN EL INTERVALO
                    else if (EvaluarExpresion(XI) * EvaluarExpresion(XU) > 0)
                    {
                        rtb_proceso.AppendText("\nNO EXISTE UNA RAÍZ EN ESE INTERVALO:(\n\nPrueba ingresando otro intervalo:)");
                    }
                    else
                    {
                        //INICIO CON EL METODO DE LA REGLA FALSA
                        double XRanterior = 0, XR = 0;
                        do
                        {
                            //MENSAJE INICIAL E IMPRESION DE LA FORMULA DE XR
                            if (iteracion == 0)
                            {
                                rtb_proceso.AppendText("\nINICIO DEL PROCESO\n\nFórmula para obtener los valores de XR:\n\n");

                                ImagenARichTextbox("XR=XU - (f((XU))*(XI - XU))/(f(XI)-f(XU))");

                                dgv_solucion.Rows.Add(iteracion, XI, XR, XU, "-");
                                iteracion++;
                            }
                            //COMIENZO DE LAS ITERACIONES, SE MUESTRAN LOS VALORES DE XI y XU
                            rtb_proceso.AppendText("\n\t\t\t-----ITERACIÓN " + iteracion + "-----\n\n\t\t XI= " + XI + " \t\t XU=" + XU + "\nSe obtiene el valor de XR\n\n");

                            //SE GUARDA EL VALOR DE XR ANTERIOR Y SE OBTIENE EL NUEVO VALOR, SE IMPRIME EL PROCESO
                            XRanterior = XR;
                            XR = XU - (EvaluarExpresion(XU) * (XI - XU)) / (EvaluarExpresion(XI) - EvaluarExpresion(XU));
                            ImagenARichTextbox(("XR=" + Math.Round(XU, 7) + "-" + "(" + Math.Round(EvaluarExpresion(XU), 7) + ")(" + Math.Round(XI, 7) + "-" + Math.Round(XU, 7) + ") / (" + Math.Round(EvaluarExpresion(XI), 7) + " - " + Math.Round(EvaluarExpresion(XU), 7) + ")").ToString());
                            rtb_proceso.AppendText("\n");
                            ImagenARichTextbox("XR=" + XR);

                            //SE CALCULA EL ERROR APROXIMADO Y SE IMPRIME EL PROCESO
                            ErrorAproximado = Math.Abs(((XR - XRanterior) / XR)) * 100;
                            rtb_proceso.AppendText("\n\nSe calcula el error aproximado respecto al valor anterior\n");
                            ImagenARichTextbox(expresion = "Ea=(" + Math.Round(XR, 7) + "-" + Math.Round(XRanterior, 7) + ")/" + Math.Round(XR, 7) + "*100");
                            rtb_proceso.AppendText("\n");
                            ImagenARichTextbox("Ea=" + ErrorAproximado);

                            //SE AGREGAN LOS VALORES A LA TABLA
                            dgv_solucion.Rows.Add(iteracion, XI, XR, XU, ErrorAproximado);

                            //EVALUACION DE LAS EXPRESIONES PARA SACAR EL SIGUIENTE INTERVALO
                            rtb_proceso.AppendText("\n\nSe evalúa el producto de las funciones:\n");

                            if (EvaluarExpresion(XI) * EvaluarExpresion(XR) > 0)
                            {
                                //SI ES MAYOR A CERO SE USA EL SEGUNDO INTERVALO

                                Clipboard.SetImage(Image.FromFile(EcuacionPNG.CrearEcuacion("f(XI)*f(XR)=(+)(+)>0")));
                                soloCopiar();
                                XI = XR;
                            }
                            else if (EvaluarExpresion(XI) * EvaluarExpresion(XR) < 0)
                            {
                                //SI ES MAYOR A CERO SE USA EL PRIMER INTERVALO
                                Clipboard.SetImage(Image.FromFile(EcuacionPNG.CrearEcuacion("f(XI)*f(XR)=(-)(+)<0")));
                                soloCopiar();
                                XU = XR;
                            }
                            else
                            {
                                //SI ES IGUAL A CERO SE LLEGÓ AL VALOR EXACTO DE LA RAIZ
                                Clipboard.SetImage(Image.FromFile(EcuacionPNG.CrearEcuacion("f(XI)*f(XR)=0")));
                                soloCopiar();
                                ErrorAproximado = 0;
                                dgv_solucion.Rows.Add(iteracion + 1, XI, XR, XU, ErrorAproximado);
                            }

                            iteracion++;

                        } while (ErrorAproximado > ErrorAproximadoPedido && iteracion < 100);
                        //MENSAJE FINAL CON RESULTADO
                        rtb_proceso.AppendText("\n\nFin del Proceso:\n\nSe concluye que " + XR + " es una buena aproximacion a una raiz de la función, con un error aproximado de " + ErrorAproximado + "%");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("ERROR EN EL PROCESO, VERFICAR DATOS INGRESADOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    
        }

        private double EvaluarExpresion(double x)
        {
            //ESTA FUNCION NOS REGRESA EL VALOR DE LA FUNCION EVALUADA EN UN VALOR
            try
            {
                string expresionSustituidaConX = txt_Ecuacion.Text.Replace("x", x.ToString());
                Entity expresion1 = expresionSustituidaConX;
                double expresionEvaluada = ((double)expresion1.EvalNumerical());
                return expresionEvaluada;
            }
            catch (Exception e) {
                MessageBox.Show("Verificar la correcta escritura de la funcion, o seleccionar otros intervalos","ERROR AL EVALUAR LA FUNCIÓN",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return 0;
            }
            
        }
        private void ImagenARichTextbox(Entity expresion)
        {
            //ESTA FUNCION CREA LA IMAGEN BASADA EN LA CLASE "EcuacionPNG" Y COPIA LA IMAGEN AL RTB
            Clipboard.SetImage(Image.FromFile(EcuacionPNG.CrearEcuacion(expresion.Latexise())));
            soloCopiar();
        }
        private void soloCopiar()
        {
            //HABILITAR PERMISOS PARA COPIAR Y HACER EL COPIADO EN EL RTB
            rtb_proceso.ReadOnly = false;
            rtb_proceso.Paste();
            rtb_proceso.ReadOnly = true;
            rtb_proceso.AppendText("\n");
        }
        private string validacion()
        {
            string mensajeError="";
            char[] caracteresInvalidos = { 'a', 'b', 'c', 'd', 'f', 'g', 'h', 'i', 'j', 'k','l', 'm','n','o', 'p', 'q', 'r','s','t','u','v', 'w', 'y','z' };//NO, NO FALTAN LETRAS
            if (txt_Ecuacion.Text.Trim()=="")
            {
                mensajeError = "No se ha ingresado ninguna función\n";
            }
            for (int i = 0; i < txt_Ecuacion.Text.Length; i++)
            {
                for (int j = 0; j < caracteresInvalidos.Length; j++)
                {
                    if (txt_Ecuacion.Text[i] == caracteresInvalidos[j] || txt_Ecuacion.Text[i] == Char.ToUpper(caracteresInvalidos[j])) 
                    {
                        if ((txt_Ecuacion.Text[i] == 's' && txt_Ecuacion.Text[i + 1] == 'i' && txt_Ecuacion.Text[i+2] == 'n')|| (txt_Ecuacion.Text[i] == 'c' && txt_Ecuacion.Text[i + 1] == 'o' && txt_Ecuacion.Text[i + 2] == 's')|| (txt_Ecuacion.Text[i] == 't' && txt_Ecuacion.Text[i + 1] == 'a' && txt_Ecuacion.Text[i + 2] == 'n')|| (txt_Ecuacion.Text[i] == 'c' && txt_Ecuacion.Text[i + 1] == 'o' && txt_Ecuacion.Text[i + 2] == 't')|| (txt_Ecuacion.Text[i] == 's' && txt_Ecuacion.Text[i + 1] == 'e' && txt_Ecuacion.Text[i + 2] == 'c')|| (txt_Ecuacion.Text[i] == 'c' && txt_Ecuacion.Text[i + 1] == 's' && txt_Ecuacion.Text[i + 2] == 'c'))
                        {
                            i = i + 3;
                            break;
                        }
                        else
                        {
                            mensajeError = mensajeError + "Hay caracteres inválidos\n";
                            break;
                        }
                    }
                }
            }
            if (num_XI.Value>=num_XU.Value)
            {
                mensajeError = mensajeError + "El primer extremo del intervalo no puede ser mayor o igual al segundo";
            }

            return mensajeError;
        }

        private void px_info_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            txt_Ecuacion.Clear();
            dgv_solucion.Rows.Clear();
            rtb_proceso.Clear();
            pbx_Ecuacion.Image = null;
        }
    }
}
