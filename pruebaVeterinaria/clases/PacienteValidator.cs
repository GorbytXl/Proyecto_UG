using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebaVeterinaria.clases
{
    public class PacienteValidator
    {
        public int id_consulta { get; set; }
        public string nombre_paciente { get; set; }
        public string cedula_paciente { get; set; }
        public string tipo_consulta { get; set; }
        public string tipo_mascota { get; set; }

    }
}
