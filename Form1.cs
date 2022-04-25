using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectoresCodigo
{
    public partial class Form1 : Form
    {
        //variables 
        string NoCarnet;
        string VectorControl;
        int CodVerificador;
        //variables de longitud de cadena
        int longitud1 = 0;
        int longitud2 = 0;
        //variables de operaciones
        int Multiplicacion= 0;
        int multiplo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
           
            //igualar variable a textbox
            VectorControl = txtVeControl.Text;
            NoCarnet = txtCarne.Text;

            //Generar longitud de las cadenas
            longitud1 = (txtVeControl.Text).Length;
            longitud2 = (txtCarne.Text).Length;

            //convertir los string a array por medio de expresion lambda
            int[] vec1 = VectorControl.ToCharArray().Select(x => int.Parse(x.ToString())).ToArray();
            int[] vec2 = NoCarnet .ToCharArray().Select(x => int.Parse(x.ToString())).ToArray();

            //comparacion para generar producto punto 
            if (longitud1 == 10 && longitud2 == 9)
            {
                for (int i = 0; i < 9; i++)
                {
                    Multiplicacion += vec1[i] * vec2[i];
                }
                // resolver para encontrar multiplo mas cercano
                multiplo = Multiplicacion % 10;
                //restar a 10 para encontrar d
                CodVerificador = 10 - multiplo;
                //mostrar resultado uniendo el valor de d con el numero de carnet ingresado
                txtCodVerificar.Text = NoCarnet + CodVerificador.ToString();
            }
            else
            {
                //si no contienen los digitos necesarios mostrar este mensaje
                MessageBox.Show("El Vector de control debe contener 10 dígitos y el Carnét al menos 9 dígitos");
                txtValidar.Text = "_____________________";
                txtValidar.BackColor = Color.Tan;
                txtVeControl.Clear();
                txtCarne.Clear();
                txtVerificar.Clear();
                txtCodVerificar.Clear();
            }
           
            
      
        }

        private void txtCodVerificador_TextChanged(object sender, EventArgs e)
        {

        }

        private void VerVec_Click(object sender, EventArgs e)
        {
            //mostrar Vector control elegido
            txtVeControl.Text = "2569734521";
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //validacion para ver si es correcto o incorrecto
            if (txtCodVerificar.Text == txtVerificar.Text )
            {
                txtValidar.Text = "Es correcto";
                txtValidar.BackColor = Color.Green;
            }
            else
            {
                txtValidar.Text = "Es incorrecto";
                txtValidar.BackColor = Color.Red;
            }
        }

        private void buton_Click(object sender, EventArgs e)
        {
            //limpiar textbox y labels
            txtValidar.Text =  "_____________________";
            txtValidar.BackColor = Color.Tan;
            txtVeControl.Clear();
            txtCarne.Clear();
            txtVerificar.Clear();
            txtCodVerificar.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("El siguiente programa consiste en la práctica de Vectores Código y la programación en C#. Porfavor dar click en boton para generar vector control e ingresar el NoCarné");
        }
    }
}
