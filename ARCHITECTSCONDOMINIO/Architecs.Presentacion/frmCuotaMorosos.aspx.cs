﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Architecs.Presentacion.PagosService;

namespace Architecs.Presentacion
{
    public partial class frmCuotaMorosos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    CargarGrilla();
                }
            }
            catch (Exception ex)
            {
                lblMensajes.Text = ex.Message;
            }
        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
            lblMensajes.Text = string.Empty;
        }
        
        protected void gvCuotas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvCuotas.PageIndex = e.NewPageIndex;
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            
            PagosService.PagosServiceClient proxyPagos = new PagosService.PagosServiceClient();
            IList<Cuota> lstCuota = proxyPagos.ListarCuotaMorosas(txtPeriodo.Text);

            gvCuotas.DataSource = lstCuota;
            gvCuotas.DataBind();
        }
    }
}