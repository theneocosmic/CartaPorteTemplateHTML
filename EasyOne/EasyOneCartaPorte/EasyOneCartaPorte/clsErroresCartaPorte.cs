using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EasyOneCartaPorte
{
    public class clsErroresCartaPorte
    {
        private List<erroresPorte> listaErrores = new List<erroresPorte>();
        public clsErroresCartaPorte()
        {
            CargarErrores();
        }

        public class erroresCartaPorte
        {
            public List<erroresPorte> errores { get; set; }
        }

        public class erroresPorte
        {
            public float NUM { get; set; }
            public string ELEMENTO { get; set; }
            public string ATRIBUTO { get; set; }
            public string CASODEVALIDACION { get; set; }
            public string CODIGOERROR { get; set; }
            public string ERROR { get; set; }
        }


        public void CargarErrores()
        {
            string archivoJson = File.ReadAllText(@"C:\CartaPorte\erroresporte.json");
            listaErrores = JsonConvert.DeserializeObject<List<erroresPorte>>(archivoJson);
        }

        public erroresPorte ObtenerError(string codigo_error)
        {
            return listaErrores.Where(x => x.CODIGOERROR == codigo_error).Select(x => x).FirstOrDefault();
        }

    }
}
