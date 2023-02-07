using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
    
        private double valor1 = 0;
        private double valor2 = 0;
        private string operador;
        private double? resultOperado;

        public Form1()
        {
            InitializeComponent();
        }     
 


        private void agregarOperador(object sender, EventArgs e)
        {
            var boton = (Button)sender;

            valor1 = Convert.ToDouble(txtResultado.Text);
            operador = boton.Text;

            txtResultado.Text = "0";
        }
       
        private void agregarNumero(object sender, EventArgs e)
        {
            
            var boton = (Button)sender;

            if (txtResultado.Text == "0") txtResultado.Text = "";
            txtResultado.Text += boton.Text;

        }

        private double getResult()
        {
            double result = 0;

            switch (operador)
            {
                case "+":
                    result = valor1 + valor2;

                    break;
                case "-":
                    result = valor1 - valor2;

                    break;
                case "X":
                    result = valor1 * valor2;
                    break;
                case "/":
                    if (valor2 == 0)
                    {
                        MessageBox.Show("No se puede dividir entre 0");
                        result = 0;
                    }
                    else
                    {
                        result = valor1 / valor2;
                    }
                    
                    break;
                case "%":
                    result = valor1 % valor2;

                    break;

            }
            return result;

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {

            ObtenerResultados();
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains("."))
            {
                txtResultado.Text += ".";
            }
        }

        private void KeyDownFunction(object sender, KeyEventArgs e)
        {

            int result = 0;
            var keyPress = e.KeyData.ToString().Substring(e.KeyData.ToString().Length - 1);
            int.TryParse("e", out result).ToString();
            if (int.TryParse(keyPress, out result))
            {
                agregarDelTeclado(keyPress);
            }
            else
            {
                switch (e.KeyData.ToString())
                {
                    case "Add":
                        agregarOperadorTeclado("+");
                        break;
                    case "Subtract":
                        agregarOperadorTeclado("-");
                        break;
                    case "Divide":
                        agregarOperadorTeclado("/");
                        break;
                    case "Multiply":
                        agregarOperadorTeclado("X");
                        break;
                    case "Decimal":
                        if (!txtResultado.Text.Contains("."))
                        {
                            txtResultado.Text += ".";
                        }
                        break;
                    case "Return":
                        ObtenerResultados();
                        break;
                    case "Back":
                        DeleteOne();
                        break;
                    case "Delete":
                        DeleteAll();
                        break;

                }
            }

            lblHistorial.Text = operador;
        }

        private void agregarDelTeclado(string caracter)
        {
            if (txtResultado.Text == "0") txtResultado.Text = "";
            txtResultado.Text += caracter;
        }

        private void agregarOperadorTeclado(string operacion)
        {

            valor1 = Convert.ToDouble(txtResultado.Text);
            operador = operacion;

            txtResultado.Text = "0";
        }
        
        private void ObtenerResultados()
        {
            if (Convert.ToDouble(txtResultado.Text) != resultOperado)
            {
                valor2 = Convert.ToDouble(txtResultado.Text);
            }

            var resultado = getResult();

            txtResultado.Text = resultado.ToString();
            valor1 = Convert.ToDouble(resultado);

            resultOperado = Convert.ToDouble(resultado);
        }

        private void DeleteOne()
        {
            if (txtResultado.Text != "0" && txtResultado.Text.Length > 0)
            {
                string NewOperation = txtResultado.Text.Remove(txtResultado.Text.Length - 1);

                if (NewOperation.Length > 0)
                {
                    txtResultado.Text = NewOperation;

                }
                else
                {
                    txtResultado.Text = "0";
                }
            }
        }

        private void DeleteAll()
        {
            txtResultado.Text = "0";
            lblHistorial.Text = string.Empty;

            valor1 = 0;
            valor2 = 0;
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DeleteAll();
        }

        private void btnDeleteOne_Click(object sender, EventArgs e)
        {
            DeleteOne();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
