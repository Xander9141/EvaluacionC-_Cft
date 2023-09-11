using Evaluacion1RamonTorres.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion1RamonTorres.Dato
{
    public class Paciente
    {
        List<PacienteModel> lista = new List<PacienteModel>();

        public void Guardar(PacienteModel modelo)
        {
            lista.Add(modelo);
        }

        public List<PacienteModel> Consultar()
        {
            return lista;
        }
    }
}
