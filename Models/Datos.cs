using System.Collections.Generic;

namespace MI_WEB_PERSONAL.Models
{
    public static class Datos
    {
        public static DatosPersonales GetDatosPersonales()
        {
            return new DatosPersonales
            {
                Nombre = "Felipe Otero",
                Descripcion = "Mi nombre es Felipe Otero, tengo 16 años, me encuentro en cuarto año de secundaria en ort. Mi principal hobbie es el gimnasio, entreno cinco veces por semana. Uno de mis objetivos principales es poder recorrer el mundo.",
            };
        }

      public static List<curso> Getcursos()
{
    return new List<curso>
    {
        new curso { Nombre = "Curso de Nutrición Básico", descripcion = "Aprendí los conceptos fundamentales sobre nutrición y alimentación saludable.", Icono = "fas fa-utensils fa-3x mb-3 text-primary" },
        new curso { Nombre = "Curso de RCP", descripcion = "Capacitación en reanimación cardiopulmonar y primeros auxilios.", Icono = "fas fa-heartbeat fa-3x mb-3 text-danger" },
        new curso { Nombre = "Conocimiento en HTML y CSS", descripcion = "Estoy desarrollando mis habilidades en diseño web utilizando HTML y CSS en el ámbito escolar que me brinda la escuela ORT.", Icono = "fas fa-code fa-3x mb-3 text-info" }
    };
}


        public static List<Idioma> GetIdiomas()
{
    return new List<Idioma>
    {
        new Idioma { Nombre = "Español", Nivel = "Idioma nativo.", Icono = "fas fa-language fa-3x mb-3 text-warning" },
        new Idioma { Nombre = "Inglés", Nivel = "Nivel intermedio-avanzado.", Icono = "fas fa-language fa-3x mb-3 text-success" },
        new Idioma { Nombre = "Hebreo", Nivel = "Nivel básico.", Icono = "fas fa-language fa-3x mb-3 text-primary" }
    };
}


        public static List<Proyecto> GetProyectos()
        {
            return new List<Proyecto>
            {
                new Proyecto { Nombre = "Proyecto 1", Descripcion = "Aplicacion de estilo nav.", ImagenUrl = "/img/proyecto1.png", Url = "https://estilandonavbartp7.netlify.app/" },
                new Proyecto { Nombre = "Proyecto 2", Descripcion = "Agencia de turismo con styles", ImagenUrl = "/img/proyecto2.png", Url = "https://marcos-agency-arte.netlify.app/lugares" },
                new Proyecto { Nombre = "Proyecto 3", Descripcion = "agencia de turismo sin styles", ImagenUrl = "/img/proyecto3.png", Url = "https://tp1htmloterokanterdicarlo.netlify.app/" }
            };
        }
    }

    public class DatosPersonales
    {
        public string Nombre { get; set; }
     public string Descripcion { get; set; }
    }

    public class curso
{
    public string Nombre { get; set; }
    public string descripcion { get; set; }
    public string Icono { get; set; }  // Nuevo atributo para el icono
}


    public class Idioma
{
    public string Nombre { get; set; }
    public string Nivel { get; set; }
    public string Icono { get; set; } 
}


    public class Proyecto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string ImagenUrl { get; set; }
        public string Url { get; set; }
    }
}