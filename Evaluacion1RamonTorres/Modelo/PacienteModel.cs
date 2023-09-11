using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion1RamonTorres.Modelo
{
    public class PacienteModel
    {
        public string Nombre { get; set; }
        public string Rut { get; set; }
        public int Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public float Estatura { get; set; }
        public float Peso { get; set; }
        public float TamañoCintura { get; set; }
        public float TamañoCadera { get; set; }
        public float ICC { get; set;  }
        public float IMC { get; set; }
    }
}
