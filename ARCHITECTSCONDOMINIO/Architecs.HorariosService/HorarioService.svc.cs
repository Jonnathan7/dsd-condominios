﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Architecs.HorariosService.Persitencia;
using Architects.Dominio;

namespace Architecs.HorariosService
{
    public class HorarioService : IHorarioService
    {
        HorarioDAO dao = new HorarioDAO();

        public IList<Architects.Dominio.HorarioBE> ListarHorario()
        {
            return dao.Listar().ToList();
        }

        public HorarioBE RegistrarHorario(string rango)
        {
            throw new NotImplementedException();
        }

        public HorarioBE ActualizarHorario(int idHorario, string rango, int estado)
        {
            throw new NotImplementedException();
        }

        public void EliminarHorario(int idHorario)
        {
            throw new NotImplementedException();
        }
    }
}
