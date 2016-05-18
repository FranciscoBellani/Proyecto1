﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Web.DynamicData;
using System.Web.Routing;
using System.Web.UI;

namespace CapaPresentacion1
{
    public class Global : System.Web.HttpApplication
    {
        private static MetaModel s_defaultModel = new MetaModel();
        public static MetaModel DefaultModel
        {
            get
            {
                return s_defaultModel;
            }
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            //                    IMPORTANTE: REGISTRO DEL MODELO DE DATOS 
            // Quite la marca de comentario de esta línea para registrar un modelo de ADO.NET Entity Framework para datos dinámicos de ASP.NET.
            // Establezca ScaffoldAllTables = true solo si está seguro de que desea que todas las tablas del
            // modelo de datos admitan una vista con scaffold (es decir, plantillas). Para controlar la técnica scaffolding para
            // tablas individuales, cree una clase parcial para la tabla y aplique el
            // atributo [ScaffoldTable(true)] a la clase parcial.
            // Nota: asegúrese de que cambia "YourDataContextType" al nombre de la clase del contexto de datos
            // en la aplicación.
            // See http://go.microsoft.com/fwlink/?LinkId=257395 for more information on how to add and configure an Entity Data model to this project
            //DefaultModel.RegisterContext(typeof(YourDataContextType), new ContextConfiguration() { ScaffoldAllTables = false });

            // La siguiente declaración admite el modo de páginas independientes, donde las tareas List, Detail, Insert y 
            // Update se realizan usando páginas independientes. Para habilitar este modo, quite las marcas de comentario de la siguiente 
            // definición del objeto route y marque como comentario las definiciones de route en la sección del modo de páginas combinadas siguiente.
            routes.Add(new DynamicDataRoute("{table}/{action}.aspx")
            {
                Constraints = new RouteValueDictionary(new { action = "List|Details|Edit|Insert" }),
                Model = DefaultModel
            });

            // Las siguientes declaraciones admiten el modo de páginas combinadas, donde las tareas List, Detail, Insert y
            // Update se realizan usando la misma página. Para habilitar este modo, quite las marcas de comentario de las siguientes
            // routes y marque como comentario la definición del objeto route en la sección del modo de páginas independientes anterior.
            //routes.Add(new DynamicDataRoute("{table}/ListDetails.aspx") {
            //    Action = PageAction.List,
            //    ViewName = "ListDetails",
            //    Model = DefaultModel
            //});

            //routes.Add(new DynamicDataRoute("{table}/ListDetails.aspx") {
            //    Action = PageAction.Details,
            //    ViewName = "ListDetails",
            //    Model = DefaultModel
            //});
        }

        private static void RegisterScripts()
        {
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            {
                Path = "~/Scripts/jquery-1.7.1.min.js",
                DebugPath = "~/Scripts/jquery-1.7.1.js",
                CdnPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.7.1.min.js",
                CdnDebugPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.7.1.js",
                CdnSupportsSecureConnection = true,
                LoadSuccessExpression = "window.jQuery"
            });
        }

        void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);
            RegisterScripts();
        }

    }
}
