﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool secuencia = true;
        string operacion, borrado;
        double numero1, numero2, resultado;
       
        //Números de la calculadora
        private void num0_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0")
            {
                return;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "0";
            }
        }

        private void num1_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "1";
                secuencia = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "1";
            }
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if(secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "2";
                secuencia = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "2"; 
            }
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "3";
                secuencia = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "3";
            }
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "4";
                secuencia = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "4";
            }
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "5";
                secuencia = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "5";
            }
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "6";
                secuencia = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "6";
            }
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "7";
                secuencia = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "7";
            }
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "8";
                secuencia = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "8";
            }
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "9";
                secuencia = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "9";
            }
        }
        //Fin de los números de la calculadora

        //Inicio de los botones de operación
        private void suma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            numero1 = double.Parse(Pantalla.Text);
            secuencia = true;
        }

        private void resta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            numero1 = double.Parse(Pantalla.Text);
            secuencia = true;
        }

        private void division_Click(object sender, EventArgs e)
        {
            operacion = "/";
            numero1 = double.Parse(Pantalla.Text);
            secuencia = true;
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "*";
            numero1 = double.Parse(Pantalla.Text);
            secuencia = true;
        }

        private void cuadrado_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(Pantalla.Text);
            resultado = numero1 * numero1;
            Pantalla.Text = resultado.ToString();
            secuencia = true;
        }

        private void raiz_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(Pantalla.Text);
            resultado = Math.Sqrt (numero1);
            Pantalla.Text = resultado.ToString();
            secuencia = true;
        }

        private void igual_Click(object sender, EventArgs e)
        {
            numero2 = double.Parse(Pantalla.Text);
            if (operacion == "+")
            {
                resultado = numero1 + numero2;
                Pantalla.Text = resultado.ToString();
                secuencia = true;
            }

            if(operacion == "-")
            {
                resultado = numero1 - numero2;
                Pantalla.Text = resultado.ToString();
                secuencia = true;
            }

            if (operacion == "/")
            {
                resultado = numero1 / numero2;
                Pantalla.Text = resultado.ToString();
                secuencia = true;
            }

            if (operacion == "*")
            {
                resultado = numero1 * numero2;
                Pantalla.Text = resultado.ToString();
                secuencia = true;
            }
        }
        //Fin de los botones de operación

        //Ini
        private void retroceso_Click(object sender, EventArgs e)
        {
            int x = 0;
            borrado = Pantalla.Text;
            x = borrado.Length - 1;
            borrado = borrado.Substring(0,x);
            Pantalla.Text = borrado;
            if (Pantalla.Text == "")
            {
                Pantalla.Text = "0";
                secuencia = true;
            }
            if (Pantalla.Text == "-")
            {
                Pantalla.Text = "0";
                secuencia = true;
            }
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            Pantalla.Text = "0";
            numero1 = 0;
            numero2 = 0;
            secuencia = true;
        }
    }
}
