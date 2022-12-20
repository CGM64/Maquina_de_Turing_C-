using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maquina_de_Turing
{
    public partial class Form1 : Form
    {
        public static string cadena = "", cadena2, aux, cadenaSalida;
        public static int longitud;
        public string[] arreglo;
        public int apuntador = 1;
        public bool aceptado = false;
        int estado = 0;

        public Form1()
        {
            InitializeComponent();
            LimpiarDG();

            txtCadenaEntrada.Text = "";
            txtCadenaSalida.Text = "";
        }

        private void LimpiarDG()
        {
            for (int i = 0; i < maquinaTuring.ColumnCount; i++)
            {
                maquinaTuring[i, 0].Style.BackColor = Color.White;

                //Agrega las letras en blanco a la cinta 1 en cada columna
                maquinaTuring[i, 0].Value = "B";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if(txtCadena.Text != "")
            {
                txtCadena.Enabled = true;
                txtCadena.Text = "";
                txtCadenaEntrada.Text = "";
                txtCadenaSalida.Text = "";
                txtEstado.Text = "";
                cadena = "";
                cadena2 = "";
                aux = "";
                longitud = 0;
                Array.Clear(arreglo, 0, arreglo.Length);
                apuntador = 1;
                estado = 0;

                LimpiarDG();

                txtCadenaEntrada.ForeColor = Color.Black;
                txtEstado.ForeColor = Color.Black;
            }
        }

        //Metodo decodificar se encarga de crear el arreglo que contendrá la cadena
        public void decodificar()
        {
            cadena = txtCadena.Text;
            string betas = "";

            cadena2 = "B" + cadena;
            longitud = cadena2.Length;

            if (longitud < maquinaTuring.ColumnCount)
            {
                for(int i = 0; i < (maquinaTuring.ColumnCount - cadena2.Length); i++)
                {
                    betas = betas + "B";
                }

                cadena2 = cadena2 + betas;
            }

            longitud = cadena2.Length;
            arreglo = new string[longitud];

            for (int j = 0; j < longitud; j++)
            {
                arreglo[j] = arreglo[j] + cadena2.Substring(j, 1);
            }

            //Llenando el DataGridView
            for (int k = 0; k < longitud; k++)
            {
                //Agrega las letras b (blanco) a la cinta en cada columna del DataGridview
                maquinaTuring[k, 0].Value = cadena2.Substring(k,1);
            }
        }

        public void Movimiento(int estado)
        {
            switch (estado)
            {
                case 0: Estado0(); break;
                case 1: Estado1(); break;
                case 2: Estado2(); break;
                case 3: Estado3(); break;
                case 4: Estado4(); break;
                case 5: Estado5(); break;
                case 6: Estado6(); break;
                case 7: Estado7(); break;
                case 8: Estado8(); break;
                case 9: Estado9(); break;
                case 10: Estado10(); break;
                case 11: Estado11(); break;
                case 12: Estado12(); break;
                case 13: Estado13(); break;
                case 14: Estado14(); break;
                case 15: Estado15(); break;
            }
        }

        public void Estado0()
        {
            aux = arreglo[apuntador];

            if (aux.Equals("0"))
            {
                //Sustituye el caracter anterior (0) en el estado actual por el nuevo caracter (X)
                arreglo[apuntador] = "X";

                //Modifica el caracter del Data 
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 1;
            }
            else if (aux.Equals("1"))
            {
                arreglo[apuntador] = "Y";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                cadenaSalida = cadenaSalida + arreglo[apuntador];

                moverDerecha();

                estado = 11;
            }
            else if (aux.Equals("#"))
            {
                arreglo[apuntador] = "#";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                cadenaSalida = cadenaSalida + arreglo[apuntador];

                moverIzquierda();

                estado = 10;
            }
            else
            {
                //Si se ingresa un caracter distinto a los establecidos
                rechazar();
            }
        }

        public void Estado1()
        {
            aux = arreglo[apuntador];

            if (aux.Equals("0"))
            {
                arreglo[apuntador] = "0";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 1;
            }
            else if (aux.Equals("1"))
            {
                arreglo[apuntador] = "1";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 1;
            }
            else if (aux.Equals("#"))
            {
                arreglo[apuntador] = "#";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 2;
            }
            else
            {
                rechazar();
            }
        }

        public void Estado2()
        {
            aux = arreglo[apuntador];
            if (aux.Equals("X"))
            {
                arreglo[apuntador] = "X";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 2;
            }
            else if (aux.Equals("Y"))
            {
                arreglo[apuntador] = "Y";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 2;
            }
            else if (aux.Equals("0"))
            {
                arreglo[apuntador] = "X";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 4;
            }
            else if (aux.Equals("1"))
            {
                arreglo[apuntador] = "Y";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 4;
            }
            else
            {
                rechazar();
            }
        }

        public void Estado3()
        {
            aux = arreglo[apuntador];

            if (aux.Equals("0"))
            {
                arreglo[apuntador] = "0";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 3;
            }
            else if (aux.Equals("1"))
            {
                arreglo[apuntador] = "1";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 3;
            }
            else if (aux.Equals("$"))
            {
                arreglo[apuntador] = "$";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 6;
            }
            else
            {
                rechazar();
            }
        }

        public void Estado4()
        {
            aux = arreglo[apuntador];

            if (aux.Equals("0"))
            {
                arreglo[apuntador] = "0";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 4;
            }
            else if (aux.Equals("1"))
            {
                arreglo[apuntador] = "1";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 4;
            }
            else if (aux.Equals("$"))
            {
                arreglo[apuntador] = "$";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 5;
            }
            else
            {
                rechazar();
            }
        }

        public void Estado5()
        {
            aux = arreglo[apuntador];

            if (aux.Equals("1"))
            {
                arreglo[apuntador] = "1";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 5;
            }
            else if (aux.Equals("0"))
            {
                arreglo[apuntador] = "0";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 5;
            }
            else if (aux.Equals("B"))
            {
                arreglo[apuntador] = "0";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverIzquierda();

                estado = 7;
            }
            else
            {
                rechazar();
            }
        }

        public void Estado6()
        {
            aux = arreglo[apuntador];

            if (aux.Equals("1"))
            {
                arreglo[apuntador] = "1";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 6;
            }
            else if (aux.Equals("0"))
            {
                arreglo[apuntador] = "0";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 6;
            }
            else if (aux.Equals("B"))
            {
                arreglo[apuntador] = "1";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverIzquierda();

                estado = 7;
            }
            else
            {
                rechazar();
            }
        }

        public void Estado7()
        {
            aux = arreglo[apuntador];

            if (aux.Equals("0"))
            {
                arreglo[apuntador] = "0";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverIzquierda();

                estado = 7;
            }
            else if (aux.Equals("1"))
            {
                arreglo[apuntador] = "1";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverIzquierda();

                estado = 7;
            }
            else if (aux.Equals("$"))
            {
                arreglo[apuntador] = "$";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverIzquierda();

                estado = 8;
            }
            else
            {
                rechazar();
            }
        }

        public void Estado8()
        {
            aux = arreglo[apuntador];
            if (aux.Equals("1"))
            {
                arreglo[apuntador] = "1";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverIzquierda();

                estado = 8;
            }
            else if (aux.Equals("Y"))
            {
                arreglo[apuntador] = "Y";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverIzquierda();

                estado = 8;
            }
            else if (aux.Equals("X"))
            {
                arreglo[apuntador] = "X";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverIzquierda();

                estado = 8;
            }
            else if (aux.Equals("0"))
            {
                arreglo[apuntador] = "0";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverIzquierda();

                estado = 8;
            }
            else if (aux.Equals("#"))
            {
                arreglo[apuntador] = "#";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverIzquierda();

                estado = 9;
            }
            else
            {
                rechazar();
            }
        }

        public void Estado9()
        {
            aux = arreglo[apuntador];

            if (aux.Equals("0"))
            {
                arreglo[apuntador] = "0";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverIzquierda();

                estado = 9;
            }
            else if (aux.Equals("1"))
            {
                arreglo[apuntador] = "1";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverIzquierda();

                estado = 9;
            }
            else if (aux.Equals("X"))
            {
                arreglo[apuntador] = "X";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 0;
            }
            else if (aux.Equals("Y"))
            {
                arreglo[apuntador] = "Y";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 0;
            }
            else
            {
                rechazar();
            }
        }

        public void Estado10()
        {
            aux = arreglo[apuntador];

            if (aux.Equals("Y"))
            {
                arreglo[apuntador] = "1";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverIzquierda();

                estado = 10;
            }
            else if (aux.Equals("X"))
            {
                arreglo[apuntador] = "0";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverIzquierda();

                estado = 10;
            }
            else if (aux.Equals("B"))
            {
                arreglo[apuntador] = "B";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 13;
            }
            else
            {
                rechazar();
            }
        }

        public void Estado11()
        {
            aux = arreglo[apuntador];

            if (aux.Equals("0"))
            {
                arreglo[apuntador] = "0";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 11;
            }
            else if (aux.Equals("1"))
            {
                arreglo[apuntador] = "1";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 11;
            }
            else if (aux.Equals("#"))
            {
                arreglo[apuntador] = "#";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 12;
            }
            else
            {
                rechazar();
            }
        }

        public void Estado12()
        {
            aux = arreglo[apuntador];

            if (aux.Equals("X"))
            {
                arreglo[apuntador] = "X";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 12;
            }
            else if (aux.Equals("Y"))
            {
                arreglo[apuntador] = "Y";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 12;
            }
            else if (aux.Equals("0"))
            {
                arreglo[apuntador] = "X";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 4;
            }
            else if (aux.Equals("1"))
            {
                arreglo[apuntador] = "Y";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 3;
            }
            else
            {
                rechazar();
            }
        }

        public void Estado13()
        {
            aux = arreglo[apuntador];

            if (aux.Equals("0"))
            {
                arreglo[apuntador] = "0";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 13;
            }
            else if (aux.Equals("1"))
            {
                arreglo[apuntador] = "1";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 13;
            }
            else if (aux.Equals("#"))
            {
                arreglo[apuntador] = "#";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 14;
            }
            else
            {
                rechazar();
            }
        }

        public void Estado14()
        {
            aux = arreglo[apuntador];

            if (aux.Equals("Y"))
            {
                arreglo[apuntador] = "1";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 14;
            }
            else if (aux.Equals("X"))
            {
                arreglo[apuntador] = "0";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 14;
            }
            else if (aux.Equals("$"))
            {
                arreglo[apuntador] = "$";
                maquinaTuring[apuntador, 0].Value = arreglo[apuntador];

                moverDerecha();

                estado = 15;
            }
            else
            {
                rechazar();
            }
        }

        public void Estado15()
        {
            aceptado = true;
        }

        //Mueve el puntero de la MT a la derecha
        public void moverDerecha()
        {
            apuntador++;

            if(apuntador != 15)
            {
                maquinaTuring[apuntador - 1, 0].Style.BackColor = Color.White;
                maquinaTuring[apuntador, 0].Style.BackColor = Color.Yellow;
            }
            else
            {
                maquinaTuring[apuntador - 1, 0].Style.BackColor = Color.White;
                maquinaTuring[apuntador, 0].Style.BackColor = Color.Green;
            }
        }

        //Mueve el puntero de la MT a la izquierda
        public void moverIzquierda()
        {
            apuntador--;

            maquinaTuring[apuntador + 1, 0].Style.BackColor = Color.White;
            maquinaTuring[apuntador, 0].Style.BackColor = Color.Yellow;
        }

        //Si se encontró un caracter no valido
        public void rechazar()
        {
            aceptado = false;

            maquinaTuring[apuntador - 1, 0].Style.BackColor = Color.White;
            maquinaTuring[apuntador, 0].Style.BackColor = Color.Red;

            txtCadenaEntrada.ForeColor = Color.Red;
            txtEstado.ForeColor = Color.Red;

            MessageBox.Show("Cadena no aceptada, porque ingresó un caracter distinto a los establecidos");
        }

        private void listaColorFondo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listaColorFondo.Text == "Blanco")
            {
                this.BackColor = Color.LightGray;
                txtEncabezado.ForeColor = Color.Black;
                txtCadenaEntrada.ForeColor = Color.Black;
                txtCadenaSalida.ForeColor = Color.Black;
                txtTEstado.ForeColor = Color.Black;
                txtEstado.ForeColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.Black;
                txtEncabezado.ForeColor = Color.White;
                txtCadenaEntrada.ForeColor = Color.White;
                txtCadenaSalida.ForeColor = Color.White;
                txtTEstado.ForeColor = Color.White;
                txtEstado.ForeColor = Color.White;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mListaColorFondo();
        }

        private void btnPasos_Click(object sender, EventArgs e)
        {
            try
            {
                txtEstado.Text = estado.ToString();

                Movimiento(estado);

                if (aceptado == true)
                {
                    //Concatena todos los caracteres con los que se trabajaron a una nueva variable
                    for (int i = 0; i < arreglo.Length; i++)
                    {
                        //No permite la concatenación de B a la nueva cadena
                        if (arreglo[i] != "B")
                        {
                            cadenaSalida = cadenaSalida + arreglo[i];
                        }
                    }

                    txtCadenaSalida.Text = cadenaSalida;
                    txtEstado.ForeColor = Color.Green;
                    txtCadenaSalida.ForeColor = Color.Green;

                    MessageBox.Show("Cadena aceptada");
                }
            }
            catch
            {
                //
            }
        }

        private void btnAgregarCadena_Click(object sender, EventArgs e)
        {
            if(txtCadena.Text == "")
            {
                MessageBox.Show("No puede dejar campos vacíos");
            }
            else
            {
                txtCadena.Enabled = false;

                decodificar();

                maquinaTuring[apuntador, 0].Style.BackColor = Color.Yellow;

                txtEstado.Text = estado.ToString();
                txtCadenaEntrada.Text = cadena;
            }
        }

        private void mListaColorFondo()
        {
            listaColorFondo.Items.Add("Blanco");
            listaColorFondo.Items.Add("Negro");
        }
    }
}
