using System.Collections.Generic;
using static EasyOneCartaPorte.clsErroresCartaPorte;

namespace EasyOneCartaPorte
{

    public class Negocio
    {
        public List<string> erroresCartPorte = new List<string>();
        public string[] codigosErrorPorte = new string[] { };
        public Negocio()
        {
            CargarListaErroresCartaPorte();
        }

        private void CargarListaErroresCartaPorte()
        {
            string[] codigosError = {"CP101","CP102","CP103","CP104","CP105","CP106","CP107","CP108","CP109","CP110","CP111","CP112","CP113","CP114",
                                "CP115","CP116","CP117","CP118","CP119","CP120","CP121","CP122","CP123","CP124","CP125","CP126","CP127","CP128",
                                "CP129","CP130","CP131","CP132","CP133","CP134","CP135","CP136","CP137","CP138","CP139","CP140","CP141","CP142",
                                "CP143","CP144","CP145","CP146","CP147","CP148","CP149","CP150","CP151","CP152","CP153","CP154","CP155","CP156",
                                "CP157","CP158","CP159","CP160","CP161","CP162","CP163","CP164","CP165","CP166","CP167","CP168","CP169","CP170",
                                "CP171","CP172","CP173","CP174","CP175","CP176","CP177","CP176","CP179","CP180","CP181","CP182","CP183","CP184",
                                "CP185","CP186","CP187","CP188","CP189","CP190","CP191","CP192","CP193","CP194","CP195","CP196","CP197","CP198",
                                "CP199","CP200","CP201","CP202","CP203","CP204","CP205","CP206","CP207","CP208","CP209","CP210","CP211","CP212",
                                "CP213","CP214","CP215","CP216","CP217","CP218","CP219","CP220","CP221","CP222","CP223","CP224","CP225","CP226",
                                "CP227","CP228","CP229","CP230","CP231","CP232","CP233","CP234","CP235","CP236","CP237","CP238","CP239","CP240",
                                "CP241","CP242","CP243","CP244","CP245","CP246","CP247","CP248","CP249","CP250","CP251","CP252","CP253","CP254",
                                "CP255"};

            codigosErrorPorte = codigosError;

        }

        public erroresPorte ObtenerDetallesDelError(string error)
        {
            erroresPorte oError = new erroresPorte();

            for (int i = 0; i <= codigosErrorPorte.Length; i++)
            {
                string codigoDelError = codigosErrorPorte[i];
                if (error.Contains(codigoDelError))
                {
                    clsErroresCartaPorte brErrores = new clsErroresCartaPorte();
                    oError = brErrores.ObtenerError(codigoDelError.Replace("\"", ""));
                    break;
                }
            }

            return oError;
        }
    }
}
