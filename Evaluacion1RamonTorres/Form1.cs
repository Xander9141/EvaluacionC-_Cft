
using Evaluacion1RamonTorres.Dato;
using Evaluacion1RamonTorres.Modelo;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Evaluacion1RamonTorres
{
    public partial class Form1 : Form
    {
        DataTable tabla;

        Paciente dato = new Paciente();
        public Form1()
        {
            InitializeComponent();
            Iniciar();
        }

        private void ICC_Click(object sender, EventArgs e)
        {
            string nombre = textname.Text;
            float icc, cintura, cadera;
            cintura = float.Parse(textwaist.Text);
            cadera = float.Parse(texthip.Text);
            icc = cintura / cadera;
            string resultado = "";

            if (icc >= 0.96 && icc <= 1)
            {
                resultado = "Usted tiene Moderado riesgo de problemas cardiacos.";
            }
            else if (icc < 0.94)
            {
                resultado = " Usted tiene Bajo riesgo de problemas cardiacos.";
            }
            else
            {
                resultado = "Usted tiene Alto riesgo de problemas cardiacos.";
            }
            MessageBox.Show(nombre + " Su ICC es: " + icc.ToString("F2") + ". " + resultado, "Resultado ICC", MessageBoxButtons.OK);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            if (!EsRutValido(textrut.Text))
            {
                MessageBox.Show("El formato del RUT no es válido.", "RUT Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Guardar();
            Consultar();
            Limpiar();
            Iniciar();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Iniciar()
        {
            if (tabla == null)
            {
                tabla = new DataTable();
                tabla.Columns.Add("Nombre");
                tabla.Columns.Add("Rut");
                tabla.Columns.Add("Edad");
                tabla.Columns.Add("FechaNacimiento");
                tabla.Columns.Add("Estatura");
                tabla.Columns.Add("Peso");
                tabla.Columns.Add("TamañoCintura");
                tabla.Columns.Add("TamañoCadera");
                tabla.Columns.Add("ICC");
                tabla.Columns.Add("IMC");
                grilla.DataSource = tabla;
            }
        }

        private void Guardar()
        {
            if (string.IsNullOrWhiteSpace(textname.Text))
            {
                MessageBox.Show("El campo 'Nombre' no puede estar vacío.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textrut.Text))
            {
                MessageBox.Show("El campo 'Rut' no puede estar vacío.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textage.Text))
            {
                MessageBox.Show("El campo 'Edad' no puede estar vacío.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(dateb.Text))
            {
                MessageBox.Show("El campo 'Fecha de Nacimiento' no puede estar vacío.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textheight.Text))
            {
                MessageBox.Show("El campo 'Estatura' no puede estar vacío.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textweight.Text))
            {
                MessageBox.Show("El campo 'Peso' no puede estar vacío.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textwaist.Text))
            {
                MessageBox.Show("El campo 'Tamaño de Cintura' no puede estar vacío.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(texthip.Text))
            {
                MessageBox.Show("El campo 'Tamaño de Cadera' no puede estar vacío.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime fechaNacimiento;
            if (!DateTime.TryParse(dateb.Text, out fechaNacimiento))
            {
                // Manejo de error si la conversión falla
                MessageBox.Show("Fecha de nacimiento no válida.");
                return;
            }

            float estatura = float.Parse(textheight.Text);
            float peso = float.Parse(textweight.Text);
            float tamañoCintura = float.Parse(textwaist.Text);
            float tamañoCadera = float.Parse(texthip.Text);
            float imc = peso / (estatura * estatura);
            float icc = tamañoCintura / tamañoCadera;
         
            PacienteModel modelo = new PacienteModel()
            {
                Nombre = textname.Text,
                Rut = textrut.Text,
                Edad = int.Parse(textage.Text),
                FechaNacimiento = fechaNacimiento,
                Estatura = float.Parse(textheight.Text),
                Peso = float.Parse(textweight.Text),
                TamañoCintura = float.Parse(textwaist.Text),
                TamañoCadera = float.Parse(texthip.Text),
                ICC = icc, 
                IMC = imc
            };

            dato.Guardar(modelo);
            MessageBox.Show("Los datos se han guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Consultar()
        {
            tabla.Clear();
            foreach (var item in dato.Consultar())
            {
                DataRow fila = tabla.NewRow();
                fila["Nombre"] = item.Nombre;
                fila["Rut"] = item.Rut;
                fila["Edad"] = item.Edad;
                fila["FechaNacimiento"] = item.FechaNacimiento;
                fila["Estatura"] = item.Estatura;
                fila["Peso"] = item.Peso;
                fila["TamañoCintura"] = item.TamañoCintura;
                fila["TamañoCadera"] = item.TamañoCadera;
                fila["ICC"] = item.ICC;
                fila["IMC"] = item.IMC;
                tabla.Rows.Add(fila);
            }
        }

        private void Limpiar()
        {
            textname.Text = "";
            textrut.Text = "";
            textage.Text = "";
            dateb.Text = "";
            textheight.Text = "";
            textweight.Text = "";
            textwaist.Text = "";
            texthip.Text = "";
        }

        private bool EsRutValido(string rut)
        {
            string patron = @"^\d{1,8}-(\d|K|k)$";
            return Regex.IsMatch(rut, patron);
        }

        private void btnimc_Click(object sender, EventArgs e)
        {
            string nombre = textname.Text;
            float imc, peso, estatura;
            peso = float.Parse(textweight.Text);
            estatura = float.Parse(textheight.Text);
            imc = peso / (estatura * estatura);
            string resultado = "";

            if (imc >= 18.5 && imc <= 24.9)
            {
                resultado = "Usted tiene valores normales.";
            }
            else if (imc < 18.5)
            {
                resultado = "Usted está por debajo de su peso.";
            }
            else
            {
                resultado = "Usted tiene sobrepeso.";
            }
            MessageBox.Show(nombre + " Su IMC es: " + imc.ToString("F2") + ". " + resultado, "Resultado IMC", MessageBoxButtons.OK);
        }
    }
}