﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Web;
using System.Net;
using System.Text;
using System.IO;
using System.Web.Script.Serialization;
using Architecs.Presentacion.Dominio;

namespace Architecs.Presentacion.Quejas
{
    public partial class ConsultaQuejas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //string postdata = "{\"FechaIni\":\"" + TxtDesde.Text + "\",\"FechaFin\":\"" + txtMotivo.Text + "\",\"C_Detalle\":\"" + TxtDetalle.Text + "\",\"D_FecQueja\":\"" + txtFecha.Text + "\"}"; //JSON
                //byte[] data = Encoding.UTF8.GetBytes(postdata);

                //HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:62070/QuejaService.svc/Quejas/Todos" + TxtDesde.Text + "," +TxtHasta.Text + "," + CboTipoQueja.SelectedValue);

                //req.Method = "GET";
                //req.ContentLength = data.Length;
                //req.ContentType = "application/json";

                //var reqStream = req.GetRequestStream();
                //reqStream.Write(data, 0, data.Length);

                //var res = (HttpWebResponse)req.GetResponse();
                //StreamReader reader = new StreamReader(res.GetResponseStream());
                //string alumnoJson = reader.ReadToEnd();

                //JavaScriptSerializer js = new JavaScriptSerializer();
                //Queja alumnoCreado = js.Deserialize<Queja>(alumnoJson);


                //String script = "document.getElementById('divacepto').style.display='block';";
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "alerta", script, true);

                string strURL = "http://localhost:62070/QuejaService.svc/Quejas/Todos/" + TxtDesde.Text + "," + TxtHasta.Text + "," + CboTipoQueja.SelectedValue;
                HttpWebRequest reqObtener = (HttpWebRequest)WebRequest
                   .Create(strURL);
                reqObtener.Method = "GET";
                HttpWebResponse resObtener = (HttpWebResponse)reqObtener.GetResponse();
                StreamReader readerObtener = new StreamReader(resObtener.GetResponseStream());
                string QuejasObtener = readerObtener.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                IList<Queja> ListaQuejas = js.Deserialize<List<Queja>>(QuejasObtener);

                GvQuejas.DataSource = ListaQuejas;
                GvQuejas.DataBind();
            }
            catch (FaultException ex)
            {
                String strScript;
                strScript = "<script>alert('" + ex.Message + "')</script>";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", strScript, false);
            }
        }
    }
}