using System;
using System.Collections.Generic;
using System.Configuration;

using Architecs.PagosService.Persitencia;

namespace Architecs.PagosService.Persistencia
{
    /// <summary>
    /// Proyecto    : Modulo de Mantenimiento de : 
    /// Creacion    : CROM - Orlando Carril Ramírez
    /// Fecha       : 20/05/2014-06:35:42 a.m.
    /// Descripcion : Capa de Datos 
    /// Archivo     : [Gestion.CuotaData.cs]
    /// </summary>
    public class CuotaDAO
    {
        private string conexion = string.Empty;
        public CuotaDAO()
        {
            conexion = Utilitario.CadenaConeccion();
        }

        #region /* Proceso de SELECT ALL */

        /// <summary>
        /// Retorna un LISTA de registros de la Entidad Gestion.Cuota
        /// En la BASE de DATO la Tabla : [Gestion.Cuota]
        /// <summary>
        /// <returns>List</returns>
        public List<TipoPago> Listar()
        {
            List<TipoPago> lstTipoPago = new List<TipoPago>();
            try
            {
                using (DBMLPagosDataContext SQLDC = new DBMLPagosDataContext(conexion))
                {
                    var resul = SQLDC.dsd_mnt_S_TipoPago();

                    foreach (var item in resul)
                    {
                        TipoPago tipoPago = new TipoPago();
                        tipoPago.N_IdTipoPago = item.N_IdTipoPago;
                        tipoPago.C_Descripcion = item.C_Descripcion;
                        tipoPago.B_Estado = item.B_Estado;

                        lstTipoPago.Add(tipoPago);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstTipoPago;
        }

        #endregion

        #region /* Proceso de SELECT ALL */

        /// <summary>
        /// Retorna un LISTA de registros de la Entidad Gestion.Cuota
        /// En la BASE de DATO la Tabla : [Gestion.Cuota]
        /// <summary>
        /// <returns>List</returns>
        public List<Cuota> Listar(string prm_C_Periodo)
        {
            List<Cuota> lstCuota = new List<Cuota>();
            try
            {
                using (DBMLPagosDataContext SQLDC = new DBMLPagosDataContext(conexion))
                {
                    var resul = SQLDC.dsd_mnt_S_Cuota(prm_C_Periodo);

                    foreach (var item in resul)
                    {
                        Cuota cuota = new Cuota();
                        cuota.N_IdCuota = item.N_IdCuota;
                        cuota.C_Periodo = item.C_Periodo;
                        cuota.N_IdVivienda = item.N_IdVivienda;

                        cuota.objVivienda.C_NumDpto = item.C_NumDpto;
                        cuota.objVivienda.C_NumEdificio = item.C_NumEdificio;
                        cuota.objVivienda.objResidente.C_Apellidos = item.C_Propietario;

                        cuota.N_IdTipoPago = item.N_IdTipoPago;
                        cuota.N_Importe = item.N_Importe;
                        cuota.D_FecVncto = item.D_FecVncto;
                        cuota.D_FecPago = item.D_FecPago;
                        
                        cuota.objTipoPago.C_Descripcion = item.V_IdTipoPago;
                        cuota.objVivienda.C_NumDpto = item.C_NumDpto;
                        cuota.objVivienda.C_NumEdificio = item.C_NumEdificio;
                        cuota.C_NumDeposito = item.C_NumDeposito;

                        lstCuota.Add(cuota);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstCuota;
        }

        public List<Cuota> ListarPorResidente(string pCorreoResidente)
        {
            List<Cuota> lstCuota = new List<Cuota>();
            try
            {
                using (DBMLPagosDataContext SQLDC = new DBMLPagosDataContext(conexion))
                {
                    var resul = SQLDC.dsd_mnt_S_CuotaPorResidente(pCorreoResidente);

                    foreach (var item in resul)
                    {
                        Cuota cuota = new Cuota();
                        cuota.N_IdCuota = item.N_IdCuota;
                        cuota.C_Periodo = item.C_Periodo;
                        cuota.N_IdVivienda = item.N_IdVivienda;

                        cuota.objVivienda.C_NumDpto = item.C_NumDpto;
                        cuota.objVivienda.C_NumEdificio = item.C_NumEdificio;
                        cuota.objVivienda.objResidente.C_Apellidos = item.C_Propietario;

                        cuota.N_IdTipoPago = item.N_IdTipoPago;
                        cuota.N_Importe = item.N_Importe;
                        cuota.D_FecVncto = item.D_FecVncto;
                        cuota.D_FecPago = item.D_FecPago;

                        cuota.objTipoPago.C_Descripcion = item.V_IdTipoPago;
                        cuota.objVivienda.C_NumDpto = item.C_NumDpto;
                        cuota.objVivienda.C_NumEdificio = item.C_NumEdificio;
                        cuota.C_NumDeposito = item.C_NumDeposito;

                        lstCuota.Add(cuota);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstCuota;
        }

        public List<Cuota> ListarMorosos(string prm_C_Periodo)
        {
            List<Cuota> lstCuota = new List<Cuota>();
            try
            {
                using (DBMLPagosDataContext SQLDC = new DBMLPagosDataContext(conexion))
                {
                    var resul = SQLDC.dsd_mnt_S_CuotaMorosos(prm_C_Periodo);

                    foreach (var item in resul)
                    {
                        Cuota cuota = new Cuota();
                        cuota.N_IdCuota = item.N_IdCuota;
                        cuota.C_Periodo = item.C_Periodo;
                        cuota.N_IdVivienda = item.N_IdVivienda;

                        cuota.objVivienda.C_NumDpto = item.C_NumDpto;
                        cuota.objVivienda.C_NumEdificio = item.C_NumEdificio;
                        cuota.objVivienda.objResidente.C_Apellidos = item.C_Propietario;

                        cuota.N_IdTipoPago = item.N_IdTipoPago;
                        cuota.N_Importe = item.N_Importe;
                        cuota.D_FecVncto = item.D_FecVncto;
                        cuota.D_FecPago = item.D_FecPago;

                        cuota.objTipoPago.C_Descripcion = item.V_IdTipoPago;
                        cuota.objVivienda.C_NumDpto = item.C_NumDpto;
                        cuota.objVivienda.C_NumEdificio = item.C_NumEdificio;
                        cuota.C_NumDeposito = item.C_NumDeposito;

                        lstCuota.Add(cuota);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstCuota;
        }
      
        #endregion

        #region /* Proceso de SELECT BY ID CODE */

        /// <summary>
        /// Retorna una ENTIDAD de registro de la Entidad Gestion.Cuota
        /// En la BASE de DATO la Tabla : [Gestion.Cuota]
        /// <summary>
        /// <returns>Entidad</returns>
        public Cuota Buscar(int prm_N_IdCuota)
        {
            Cuota cuota = new Cuota();
            try
            {
                using (DBMLPagosDataContext SQLDC = new DBMLPagosDataContext(conexion))
                {
                    var resul = SQLDC.dsd_mnt_S_CuotaId(prm_N_IdCuota);
                    foreach (var item in resul)
                    {
                        cuota = new Cuota() { };
                        cuota.N_IdCuota = item.N_IdCuota;
                        cuota.C_Periodo = item.C_Periodo;
                        cuota.N_IdVivienda = item.N_IdVivienda;

                        cuota.objVivienda.C_NumDpto = item.C_NumDpto;
                        cuota.objVivienda.C_NumEdificio = item.C_NumEdificio;
                        cuota.objVivienda.objResidente.C_Apellidos = item.C_Propietario;

                        cuota.N_IdTipoPago = item.N_IdTipoPago;
                        cuota.N_Importe = item.N_Importe;
                        cuota.D_FecVncto = item.D_FecVncto;
                        cuota.D_FecPago = item.D_FecPago;

                        cuota.objTipoPago.C_Descripcion = item.V_IdTipoPago;
                        cuota.objVivienda.C_NumDpto = item.C_NumDpto;
                        cuota.objVivienda.C_NumEdificio = item.C_NumEdificio;
                        cuota.C_NumDeposito = item.C_NumDeposito;

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return cuota;
        }

        public Cuota Buscar(string prm_C_Periodo, int prm_N_IdVivienda)
        {
            Cuota cuota = null;
            try
            {
                using (DBMLPagosDataContext SQLDC = new DBMLPagosDataContext(conexion))
                {
                    var resul = SQLDC.dsd_mnt_S_CuotaIdPeriodo(prm_C_Periodo, prm_N_IdVivienda);
                    foreach (var item in resul)
                    {
                        cuota = new Cuota()
                        {
                            N_IdCuota = item.N_IdCuota,
                            C_Periodo = item.C_Periodo,
                            N_IdVivienda = item.N_IdVivienda,
                            N_IdTipoPago = item.N_IdTipoPago,
                            N_Importe = item.N_Importe,
                            D_FecVncto = item.D_FecVncto,
                            D_FecPago = item.D_FecPago,
                            C_NumDeposito = item.C_NumDeposito
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return cuota;
        }

        #endregion

        #region /* Proceso de INSERT RECORD */

        /// <summary>
        /// Almacena el registro de una ENTIDAD de registro de Tipo Cuota
        /// En la BASE de DATO la Tabla : [Gestion.Cuota]
        /// <summary>
        /// <param name = >pcuota</param>
        public int Registrar(Cuota pcuota)
        {
            int? codigoRetorno = -1;
            try
            {
                using (DBMLPagosDataContext SQLDC = new DBMLPagosDataContext(conexion))
                {
                    SQLDC.dsd_mnt_I_Cuota(
                        ref codigoRetorno,
                        pcuota.C_Periodo,
                        pcuota.N_IdVivienda,
                        pcuota.N_Importe,
                        pcuota.D_FecVncto);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return codigoRetorno == null ? 0 : codigoRetorno.Value;
        }
    
        #endregion

        #region /* Proceso de UPDATE RECORD */

        /// <summary>
        /// Almacena el registro de una ENTIDAD de registro de Tipo Cuota
        /// En la BASE de DATO la Tabla : [Gestion.Cuota]
        /// <summary>
        /// <param name = >itemCuota</param>
        public int Actualizar(Cuota pcuota)
        {
            int codigoRetorno = -1;
            try
            {
                using (DBMLPagosDataContext SQLDC = new DBMLPagosDataContext(conexion))
                {
                    codigoRetorno = SQLDC.dsd_mnt_U_Cuota(
                        pcuota.N_IdCuota,
                        pcuota.N_Importe,
                        pcuota.D_FecVncto);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return codigoRetorno;
        }

        public int PagarCuota(Cuota pcuota)
        {
            int codigoRetorno = -1;
            try
            {
                using (DBMLPagosDataContext SQLDC = new DBMLPagosDataContext(conexion))
                {
                    codigoRetorno = SQLDC.dsd_mnt_U_CuotaPago(
                        pcuota.N_IdCuota,
                        pcuota.D_FecPago,
                        pcuota.N_IdTipoPago,
                        pcuota.C_NumDeposito);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return codigoRetorno;
        }
        #endregion

        #region /* Proceso de DELETE BY ID CODE */

        /// <summary>
        /// ELIMINA un registro de la Entidad Gestion.Cuota
        /// En la BASE de DATO la Tabla : [Gestion.Cuota]
        /// <summary>
        /// <returns>bool</returns>
        public bool Eliminar(int prm_N_IdCuota)
        {
            int codigoRetorno = -1;
            try
            {
                using (DBMLPagosDataContext SQLDC = new DBMLPagosDataContext(conexion))
                {
                    codigoRetorno = SQLDC.dsd_mnt_D_Cuota(prm_N_IdCuota);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return codigoRetorno == 0 ? true : false;
        }

        #endregion

    }
}
