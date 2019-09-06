using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DepartamentoDAL
    {
        //private string Conexion = "data source = DESARROLLO55; initial catalog = Departamentos; integrated security = True; MultipleActiveResultSets=True;";
        //SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionBd"].ToString());
        SqlConnection cn = new SqlConnection(
            new SqlConnectionStringBuilder()
                {
                    DataSource = "DESARROLLO55",
                    InitialCatalog = "Departamentos",
                    UserID = "SA",
                    Password = "TRIACON"
                }.ConnectionString
            );

        SqlCommand cmd = new SqlCommand();
        public List<Entidad> BuscarInfo(ParametrosDep Parametros)
        {

            List<Entidad> ListEntidad = new List<Entidad>();


            try
            {
                cn.Open();
                cmd = new SqlCommand("SpCrudDepartamentos", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };


                SqlParameter Operacion = new SqlParameter
                {
                    ParameterName = "@Operacion",
                    SqlDbType = SqlDbType.Int,
                    Value = Parametros.Operacion
                };

                SqlParameter NombreCiudad = new SqlParameter
                {
                    ParameterName = "@NombreCiudad",
                    SqlDbType = SqlDbType.VarChar,
                    Value = Parametros.NombreCiudad
                };

                SqlParameter nombreDepartamento = new SqlParameter
                {
                    ParameterName = "@nombreDepartamento",
                    SqlDbType = SqlDbType.VarChar,
                    Value = Parametros.nombreDepartamento
                };

                SqlParameter IdCiudad = new SqlParameter
                {
                    ParameterName = "@IdCiudad",
                    SqlDbType = SqlDbType.Int,
                    Value = Parametros.IdCiudad
                };

                SqlParameter IdDepartamento = new SqlParameter
                {
                    ParameterName = "@IdDepartamento",
                    SqlDbType = SqlDbType.Int,
                    Value = Parametros.IdDepartamento
                };

                SqlParameter IdRelacion = new SqlParameter
                {
                    ParameterName = "@IdRelacion",
                    SqlDbType = SqlDbType.Int,
                    Value = Parametros.IdRelacion
                };

                SqlParameter login = new SqlParameter
                {
                    ParameterName = "@login",
                    SqlDbType = SqlDbType.VarChar,
                    Value = Parametros.login
                };


                cmd.Parameters.Add(Operacion);
                cmd.Parameters.Add(NombreCiudad);
                cmd.Parameters.Add(nombreDepartamento);
                cmd.Parameters.Add(IdCiudad);
                cmd.Parameters.Add(IdDepartamento);
                cmd.Parameters.Add(IdRelacion);
                cmd.Parameters.Add(login);


                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();


                if (dr.HasRows)
                {
                    Entidad Entidad = new Entidad();
                    Entidad.IdDepartamento = Convert.ToInt32(dr["IdDepartmento"]);
                    Entidad.DescripcionDep = dr["DescripcionDep"].ToString();
                    Entidad.IdCiudad = Convert.ToInt32(dr["IdCiudad"].ToString());
                    Entidad.DescripcionCiu = dr["DescripcionCiu"].ToString();
                    Entidad.IdRelacion = Convert.ToInt32(dr["IdRelacion"].ToString());
                    Entidad.ESTADO = Convert.ToInt32(dr["ESTADO"].ToString());
                    Entidad.DESCRIESTADO = dr["DESCRIESTADO"].ToString();

                    ListEntidad.Add(Entidad);

                }
            }

            catch (Exception ex)
            {

                throw ex;
            }

            return ListEntidad;
        }

        public bool GuardarInfo (List<ParametrosDep> Parametros)
        {
            try
            {
                foreach (ParametrosDep item in Parametros)
                {
                    cn.Open();
                    cmd = new SqlCommand("SpCrudDepartamentos", cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    SqlParameter Operacion = new SqlParameter
                    {
                        ParameterName = "@Operacion",
                        SqlDbType = SqlDbType.Int,
                        Value = item.Operacion
                    };

                    SqlParameter NombreCiudad = new SqlParameter
                    {
                        ParameterName = "@NombreCiudad",
                        SqlDbType = SqlDbType.VarChar,
                        Value = item.NombreCiudad
                    };

                    SqlParameter nombreDepartamento = new SqlParameter
                    {
                        ParameterName = "@nombreDepartamento",
                        SqlDbType = SqlDbType.VarChar,
                        Value = item.nombreDepartamento
                    };

                    SqlParameter IdCiudad = new SqlParameter
                    {
                        ParameterName = "@IdCiudad",
                        SqlDbType = SqlDbType.Int,
                        Value = item.IdCiudad
                    };

                    SqlParameter IdDepartamento = new SqlParameter
                    {
                        ParameterName = "@IdDepartamento",
                        SqlDbType = SqlDbType.Int,
                        Value = item.IdDepartamento
                    };

                    SqlParameter IdRelacion = new SqlParameter
                    {
                        ParameterName = "@IdRelacion",
                        SqlDbType = SqlDbType.Int,
                        Value = item.IdRelacion
                    };

                    SqlParameter login = new SqlParameter
                    {
                        ParameterName = "@login",
                        SqlDbType = SqlDbType.VarChar,
                        Value = item.login
                    };

                    cmd.Parameters.Add(Operacion);
                    cmd.Parameters.Add(NombreCiudad);
                    cmd.Parameters.Add(nombreDepartamento);
                    cmd.Parameters.Add(IdCiudad);
                    cmd.Parameters.Add(IdDepartamento);
                    cmd.Parameters.Add(IdRelacion);
                    cmd.Parameters.Add(login);

                    cmd.ExecuteNonQuery();

                    cn.Close();
                }
            }

            catch (Exception ex)
            {

                throw ex;
            }

            return true;
        }


    }
}
