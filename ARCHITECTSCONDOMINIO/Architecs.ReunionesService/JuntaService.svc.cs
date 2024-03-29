﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Architecs.ReunionesService.Dominio;
using Architecs.ReunionesService.Persistencia;
using Architects.Dominio;


namespace Architecs.ReunionesService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "JuntaService" en el código, en svc y en el archivo de configuración a la vez.
    public class JuntaService : IJuntaService
    {
        JuntaDAO ObjjuntaDAO = new JuntaDAO();

        #region Miembros de IJuntaService

        public List<Directivo> listarDirectivos(string C_NomPer)
        {
            return ObjjuntaDAO.listarDirectivos(C_NomPer);
        }

        public int CreaJunta(DateTime D_Fecha, string C_Hora, string C_Tema, string C_Acuerdo)
        {
            try
            {
                Junta ObjJunta = new Junta();
                ObjJunta.D_Fecha = D_Fecha;
                ObjJunta.C_Hora = C_Hora;
                ObjJunta.C_Tema = C_Tema;
                ObjJunta.C_Acuerdo = C_Acuerdo;

                return ObjjuntaDAO.CreaJunta(ObjJunta);
            }
            catch (Exception exception)
            {
                 throw new FaultException<RetornaMensaje>
                    (new RetornaMensaje
                    {
                        Mensage = string.Format(resMensajes.msjNoRegistrado, "Cuota"),
                        CodigoError = exception.GetHashCode().ToString(),
                        Exito = false
                    }
                    , new FaultReason(exception.Message));
            
            }
           
        }

        public int CreaJuntaDirectivos(int N_IdJunta, int N_IdDirectivo, string C_PreJun, bool B_Estado)
        {
            JuntaDirectivos ObjJuntaDirectivos = new JuntaDirectivos();
            ObjJuntaDirectivos.N_IdJunta = N_IdJunta;
            ObjJuntaDirectivos.N_IdDirectivo = N_IdDirectivo;
            ObjJuntaDirectivos.C_PreJun = C_PreJun;
            ObjJuntaDirectivos.B_Estado = B_Estado;

            return ObjjuntaDAO.CreaJuntaDirectivos(ObjJuntaDirectivos);
        }

        #endregion


        public List<ListaJuntas> listarJuntas(string fechaini, string fechafin)
        {

            return ObjjuntaDAO.listarJuntas(fechaini, fechafin);
        }
    }
}
