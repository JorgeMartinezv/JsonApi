using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.Net.Http;
using System.Net;
using Api.Models.Ws;


namespace Api.Controllers
{
    public class Post : Controller
    {


    }
 
    [System.Web.Http.HttpPost]
    public Reply Register([FromBody] Models.Solicitudes.usuario model)
    {
        Reply oReply = new Reply();
        using (Models.practicantesEntities1 practicantes = new Models.practicantesEntities1())
        {
            Models.Persona_Jorge ousuario = new Models.Persona_Jorge();
            ousuario.Nombres = model.Nombres;
            ousuario.ApellidoP = model.ApellidoP;
            ousuario.ApellidoM = model.ApellidoM;
            ousuario.Direccion = model.Direccion;
            ousuario.Telefono = model.Telefono;
            ousuario.Estatus = model.Estatus;

            practicantes.Persona_Jorge.Add(ousuario);
            practicantes.SaveChanges();
        }
        return oReply;
    }
}
