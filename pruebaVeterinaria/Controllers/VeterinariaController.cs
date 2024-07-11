using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using pruebaVeterinaria.clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace pruebaVeterinaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeterinariaController : ControllerBase
    {
        private readonly string connectionString = "Data Source=LAPTOP-8EULMH7U\\SQLEXPRESS;Initial Catalog=veterinaria;Integrated Security=True;";

        /// <summary>
        /// Autor:          Byron Yagual
        /// descripción:    Consulta de Servicios
        /// Fecha Creacíón: 2024-05-09
        /// Fecha Modifica: 2024-05-10
        /// </summary>
        #region pacientes
        [HttpGet]
         [Route("GetPacientes")]
         public IActionResult GetPacientes( string i_nomb_paciente, string i_cedula_paciente, string i_tipo_consulta, string i_tipo_mascota)
         {
             string ProcedureName = "sp_con_paciente";
             List<PacienteValidator> Lista = new List<PacienteValidator>();
             new PacienteValidator();
             try
             {
                 using (SqlConnection connection = new SqlConnection(connectionString))
                 {
                     connection.Open();
                     var cmd = new SqlCommand(ProcedureName, connection);
                     cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@i_id_paciente", 0);
                    cmd.Parameters.AddWithValue("@i_nomb_paciente", i_nomb_paciente);
                     cmd.Parameters.AddWithValue("@i_cedula_paciente", i_cedula_paciente);
                     cmd.Parameters.AddWithValue("@i_tipo_consulta", i_tipo_consulta);
                     cmd.Parameters.AddWithValue("@i_tipo_mascota", i_tipo_mascota);

                     using (var rd = cmd.ExecuteReader())
                     {
                         while (rd.Read())
                         {
                             Lista.Add(new PacienteValidator()
                             {
                                 id_consulta = Convert.ToInt32(rd["id_consulta"]),
                                 nombre_paciente = rd["nombre_paciente"].ToString(),
                                 cedula_paciente = rd["cedula_paciente"].ToString(),
                                 tipo_consulta = rd["tipo_consulta"].ToString(),
                                 tipo_mascota = rd["tipo_mascota"].ToString()
                                 
                             });
                         }
                     }
                     return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", response = Lista });
                 }

             }
             catch (Exception error) { return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = error.Message, response = Lista }); }

         }


        /// <summary>
        /// Autor:          Byron Yagual
        /// descripción:    grabar de Servicios
        /// Fecha Creacíón: 2024-05-10
        /// Fecha Modifica: 2024-05-15  
        /// </summary>


        /////////////////////////////
        ///
        


        [HttpPost]
        [Route("GrabarConsultav")]
        public ActionResult GrabarConsultav([FromBody] PacienteValidator model)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("[sp_grb_con_paciente]", connection))
                    {
                        connection.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@i_id_consulta", model.id_consulta);// asi debes llamar desde el front los paramtros no pongas i_id_consulta no los reconoce debes enviarlo lo que esta en la clase validador osea todo lo que
                        cmd.Parameters.AddWithValue("@i_nomb_paciente", model.nombre_paciente);// va despues del model.    en otras palabras los parametros son id_consulta, nombre_paciente
                        cmd.Parameters.AddWithValue("@i_cedula_paciente", model.cedula_paciente);
                        cmd.Parameters.AddWithValue("@i_tipo_consulta", model.tipo_consulta);
                        cmd.Parameters.AddWithValue("@i_tipo_mascota", model.tipo_mascota);

                        cmd.ExecuteNonQuery();

                        return Ok("Servicio creado exitosamente");
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }
        #endregion
        #region personal

        [HttpGet]
        [Route("GetPersonal")]
        public IActionResult GetPersonal(string i_nombre, string i_cargo, string i_cedula, string i_edad)
        {
            string ProcedureName = "sp_con_personal";
            List<PersonalValidator> Lista = new List<PersonalValidator>();
            new PersonalValidator();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var cmd = new SqlCommand(ProcedureName, connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@i_personal", 0);
                    cmd.Parameters.AddWithValue("@i_nombre", i_nombre);
                    cmd.Parameters.AddWithValue("@i_cargo", i_cargo);
                    cmd.Parameters.AddWithValue("@i_cedula", i_cedula);
                    cmd.Parameters.AddWithValue("@i_edad", i_edad);

                    using (var rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            Lista.Add(new PersonalValidator()
                            {
                                id_personal = Convert.ToInt32(rd["id_Personal"]),
                                nombre = rd["nombre"].ToString(),
                                cargo = rd["cargo"].ToString(),
                                cedula = rd["cedula"].ToString(),
                                edad = rd["edad"].ToString()

                            });
                        }
                    }
                    return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", response = Lista });
                }

            }
            catch (Exception error) { return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = error.Message, response = Lista }); }

        }

        [HttpPost]
        [Route("GrabarPersonal")]
        public ActionResult GrabarPersonal([FromBody] PersonalValidator model)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_grb_personal", connection))
                    {
                        connection.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@i_id_Personal", model.id_personal);// asi debes llamar desde el front los paramtros no pongas i_id_consulta no los reconoce debes enviarlo lo que esta en la clase validador osea todo lo que
                        cmd.Parameters.AddWithValue("@i_nombre", model.nombre);// va despues del model.    en otras palabras los parametros son id_consulta, nombre_paciente
                        cmd.Parameters.AddWithValue("@i_cargo", model.cargo);
                        cmd.Parameters.AddWithValue("@i_cedula", model.cedula);
                        cmd.Parameters.AddWithValue("@i_edad", model.edad);

                        cmd.ExecuteNonQuery();

                        return Ok("Servicio creado exitosamente");
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }
        #endregion
        #region Productos

        [HttpGet]
        [Route("GetProducto")]
        public IActionResult GetProducto (string i_tipo_producto)
        {
            string ProcedureName = "sp_con_producto";
            List<ProductoValidator> Lista = new List<ProductoValidator>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var cmd = new SqlCommand(ProcedureName, connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@i_id_producto", 0);
                    cmd.Parameters.AddWithValue("@i_nomb_prod", "");
                    cmd.Parameters.AddWithValue("@i_descripcion", "");
                    cmd.Parameters.AddWithValue("@i_cantidad_stock", 0);
                    cmd.Parameters.AddWithValue("@i_precio", 0);
                    cmd.Parameters.AddWithValue("@i_tipo_producto", i_tipo_producto);


                    using (var rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            Lista.Add(new ProductoValidator()
                            {
                                idproducto = Convert.ToInt32(rd["id_producto"]),
                                nombre_producto = rd["nombre_producto"].ToString(),
                                descripcion_producto = rd["descripcion_producto"].ToString(),
                                cantidadStock = Convert.ToInt32(rd["cantidadStock"]),
                                precio = Convert.ToDecimal(rd["precio"]),
                                tipoProducto = rd["tipoProducto"].ToString()
                            });
                        }
                    }
                    return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", response = Lista });
                }
            }
            catch (Exception error)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = "Error al procesar la solicitud: " + error.Message });
            }

        }

            #endregion
        }
    }
