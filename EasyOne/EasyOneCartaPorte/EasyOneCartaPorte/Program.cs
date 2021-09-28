using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using static EasyOneCartaPorte.clsCartaPorte;

namespace EasyOneCartaPorte
{
    class Program
    {
        string EasyOneDll = @"C:\EasyOne\EasyOne.dll";

        #region wrappers cfd33

        [DllImport(@"EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cfdi33_AddCfdiRelacionado(int p, string UUID);

        [DllImport(@"EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cfdi33_AddConcepto(int p, string ClaveProdServ, string NoIdentificacion, string Cantidad, string ClaveUnidad, string Unidad, string Descripcion, string ValorUnitario, string Importe, string Descuento);

        [DllImport(@"EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cfdi33_AddInformacionAduanera(int p, string NumeroPedimento);

        [DllImport(@"EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cfdi33_AddParte(int p, string ClaveProdServ, string NoIdentificacion, string Cantidad, string Unidad, string Descripcion, string ValorUnitario, string Importe);

        [DllImport(@"EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cfdi33_AddParteInformacionAduanera(int p, string NumeroPedimento);

        [DllImport(@"EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cfdi33_AddRetencion(int p, string Base, string Impuesto, string TipoFactor, string TasaOCuota, string Importe);

        [DllImport(@"EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cfdi33_AddRetencionesRetencion(int p, string Impuesto, string Importe);

        [DllImport(@"EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cfdi33_AddTraslado(int p, string Base, string Impuesto, string TipoFactor, string TasaOCuota, string Importe);

        [DllImport(@"EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cfdi33_AddTrasladosTraslado(int p, string Impuesto, string TipoFactor, string TasaOCuota, string Importe);

        [DllImport(@"EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern int EasyOne_cfdi33_Create(string outFile);

        [DllImport(@"EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cfdi33_Free(int p);

        [DllImport(@"EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cfdi33_SetCfdiRelacionados(int p, string TipoRelacion);

        [DllImport(@"EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cfdi33_SetComprobante(int p, string Serie, string Folio, string Fecha, string FormaPago, string CondicionesDePago, string SubTotal, string Descuento, string Moneda, string TipoCambio, string Total, string TipoDeComprobante, string MetodoPago, string LugarExpedicion, string Confirmacion);

        [DllImport(@"EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cfdi33_SetComprobanteImpuestos(int p, string TotalImpuestosRetenidos, string TotalImpuestosTrasladados);

        [DllImport(@"EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cfdi33_SetCuentaPredial(int p, string Numero);

        [DllImport(@"EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cfdi33_SetEmisor(int p, string Rfc, string Nombre, string RegimenFiscal);

        [DllImport(@"EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cfdi33_SetReceptor(int p, string Rfc, string Nombre, string ResidenciaFiscal, string NumRegIdTrib, string UsoCFDI);

        [DllImport(@"EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_SetInvoiceOneFachadaInfoPrueba(int p, string AgenteId, string SoftwareId);


        #endregion

        #region wrappers easyone

        [DllImport(@"EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern string EasyOne_LeeResultado(int p, int valor);

        [DllImport(@"EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern int EasyOne_FirmaComprobante(int p, string csd, string key, string pwd);

        [DllImport(@"EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_AddComplemento(int p, int pComp);


        #endregion

        #region wrappers CartaPorte


        //CartaPorte 

        [DllImport("EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern int EasyOne_cartaporte10_Create();

        [DllImport("EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cartaporte10_SetCartaPorte(int p, string TranspInternac, string EntradaSalidaMerc, string ViaEntradaSalida, string TotalDistRec);

        //CartaPorte/Ubicaciones/Ubicacion 
        // 0 ... infinito 

        [DllImport("EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cartaporte10_AddUbicacion(int p, string TipoEstacion, string DistanciaRecorrida);

        //CartaPorte/Ubicaciones/Ubicacion[last]/Origen 

        [DllImport("EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cartaporte10_SetUbicacionOrigen(int p, string IDOrigen, string RFCRemitente, string NombreRemitente, string NumRegIdTrib, string ResidenciaFiscal, string NumEstacion, string NombreEstacion, string NavegacionTrafico, string FechaHoraSalida);

        //CartaPorte/Ubicaciones/Ubicacion[last]/Destino 

        [DllImport("EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cartaporte10_SetUbicacionDestino(int p, string IDDestino, string RFCDestinatario, string NombreDestinatario, string NumRegIdTrib, string ResidenciaFiscal, string NumEstacion, string NombreEstacion, string NavegacionTrafico, string FechaHoraProgLlegada);

        //CartaPorte/Ubicaciones/Ubicacion[last]/Domicilio 

        [DllImport("EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cartaporte10_SetUbicacionDomicilio(int p, string Calle, string NumeroExterior, string NumeroInterior, string Colonia, string Localidad, string Referencia, string Municipio, string Estado, string Pais, string CodigoPostal);
        //CartaPorte/Mercancias 

        [DllImport("EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cartaporte10_SetMercancias(int p, string PesoBrutoTotal, string UnidadPeso, string PesoNetoTotal, string NumTotalMercancias, string CargoPorTasacion);

        //CartaPorte/Mercancias/Mercancia 
        // 0 ... infinito 

        [DllImport("EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cartaporte10_AddMercancia(int p, string BienesTransp, string ClaveSTCC, string Descripcion, string Cantidad, string ClaveUnidad, string Unidad, string Dimensiones, string MaterialPeligroso, string CveMaterialPeligroso, string Embalaje, string DescripEmbalaje, string PesoEnKg, string ValorMercancia, string Moneda, string FraccionArancelaria, string UUIDComercioExt);

        //CartaPorte/Mercancias/Mercancia[last]/CantidadTransporta 
        // 0 ... infinito meter antes de DetalleMercancia 

        [DllImport("EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cartaporte10_AddMercanciaCantidadTransporta(int p, string Cantidad, string IDOrigen, string IDDestino, string CvesTransporte);

        //CartaPorte/Mercancias/Mercancia[last]/CantidadTransporta 

        [DllImport("EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cartaporte10_SetDetalleMercancia(int p, string UnidadPeso, string PesoBruto, string PesoNeto, string PesoTara, string NumPiezas);

        //CartaPorte/Mercancias/AutotransporteFederal 

        [DllImport("EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cartaporte10_SetMercanciasAutotransporteFederal(int p, string PermSCT, string NumPermisoSCT, string NombreAseg, string NumPolizaSeguro);

        //CartaPorte/Mercancias/AutotransporteFederal/IdentificacionVehicular 

        [DllImport("EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cartaporte10_SetMercanciasAutotransporteFederalIdentificacionVehicular(int p, string ConfigVehicular, string PlacaVM, string AnioModeloVM);

        //CartaPorte/Mercancias/AutotransporteFederal/Remolques/Remolque 

        [DllImport("EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cartaporte10_AddMercanciasAutotransporteFederalRemolque(int p, string SubTipoRem, string Placa);

        [DllImport("EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cartaporte10_SetMercanciasTransporteMaritimo(int p, string TipoEmbarcacion, string Matricula, string NumeroOMI, string NacionalidadEmbarc, string UnidadesDeArqBruto, string TipoCarga, string NumCertITC, string NumViaje, string NumAutorizacionNaviero);

        [DllImport("EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cartaporte10_SetMercanciasTransporteMaritimoOpt(int p, string PermSCT, string NumPermisoSCT, string NombreAseg, string NumPolizaSeguro, string AnioEmbarcacion, string NombreEmbarc, string Eslora, string Manga, string Calado, string LineaNaviera, string NombreAgenteNaviero, string NumConocEmbarc);

        [DllImport("EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cartaporte10_AddMercanciasTransporteMaritimoContenedor(int p, string MatriculaContenedor, string TipoContenedor, string NumPrecinto);

        [DllImport("EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cartaporte10_SetMercaciasTransporteAereo(int p, string PermSCT, string NumPermisoSCT, string MatriculaAeronave, string NombreAseg, string NumPolizaSeguro, string NumeroGuia, string LugarContrato, string RFCTransportista, string CodigoTransportista, string NumRegIdTribTranspor, string ResidenciaFiscalTranspor, string NombreTransportista, string RFCEmbarcador, string NumRegIdTribEmbarc, string ResidenciaFiscalEmbarc, string NombreEmbarcador);

        [DllImport("EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cartaporte10_SetMercanciasTransporteFerroviario(int p, string TipoDeServicio, string NombreAseg, string NumPolizaSeguro, string Concesionario);

        [DllImport("EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cartaporte10_AddMercanciasTransporteFerroviarioDerechosDePaso(int p, string TipoDerechoDePaso, string KilometrajePagado);

        [DllImport("EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cartaporte10_AddMercanciasTransporteFerroviarioCarro(int p, string TipoCarro, string MatriculaCarro, string GuiaCarro, string ToneladasNetasCarro);

        [DllImport("EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cartaporte10_AddMercanciasTransporteFerroviarioCarroContenedor(int p, string TipoContenedor, string PesoContenedorVacio, string PesoNetoMercancia);

        [DllImport("EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cartaporte10_SetFiguraTransporte(int p, string CveTransporte);

        [DllImport("EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cartaporte10_AddFiguraTransporteOperadores(int p);

        [DllImport("EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cartaporte10_AddFiguraTransporteOperador(int p, string RFCOperador, string NumLicencia, string NombreOperador, string NumRegIdTribOperador, string ResidenciaFiscalOperador);

        [DllImport("EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cartaporte10_SetFiguraTransporteOperadorDomicilio(int p, string Calle, string NumeroExterior, string NumeroInterior, string Colonia, string Localidad, string Referencia, string Municipio, string Estado, string Pais, string CodigoPostal);

        [DllImport("EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cartaporte10_AddFiguraTransportePropietario(int p, string RFCPropietario, string NombrePropietario, string NumRegIdTribPropietario, string ResidenciaFiscalPropietario);

        [DllImport("EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cartaporte10_SetFiguraTransportePropietarioDomicilio(int p, string Calle, string NumeroExterior, string NumeroInterior, string Colonia, string Localidad, string Referencia, string Municipio, string Estado, string Pais, string CodigoPostal);

        [DllImport("EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cartaporte10_AddFiguraTransporteArrendatario(int p, string RFCArrendatario, string NombreArrendatario, string NumRegIdTribArrendatario, string ResidenciaFiscalArrendatario);

        [DllImport("EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cartaporte10_SetFiguraTransporteArrendatarioDomicilio(int p, string Calle, string NumeroExterior, string NumeroInterior, string Colonia, string Localidad, string Referencia, string Municipio, string Estado, string Pais, string CodigoPostal);

        [DllImport("EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cartaporte10_AddFiguraTransporteNotificado(int p, string RFCNotificado, string NombreNotificado, string NumRegIdTribNotificado, string ResidenciaFiscalNotificado);

        [DllImport("EasyOne.DLL", CallingConvention = CallingConvention.Cdecl)]
        static public extern void EasyOne_cartaporte10_SetFiguraTransporteNotificadoDomicilio(int p, string Calle, string NumeroExterior, string NumeroInterior, string Colonia, string Localidad, string Referencia, string Municipio, string Estado, string Pais, string CodigoPostal);


        #endregion

        static void Main(string[] args)
        {

            try
            {
                CartaPorte();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private static void CartaPorte()
        {

            int p = EasyOne_cfdi33_Create("Cartaporte.xml");



            // Llenamos la sección del comprobante
            EasyOne_cfdi33_SetComprobante(p, "CP", "1", "2021-09-26T13:24:29", "99", "", "15635.00", "7736.00", "MXN", "1", "7899.00", "I", "PUE", "64000", "");

            //Llenamos la sección del Emisor
            EasyOne_cfdi33_SetEmisor(p, "EKU9003173C9", "emisor", "601");

            //Llenamos la sección del Receptor
            EasyOne_cfdi33_SetReceptor(p, "XAXX010101000", "receptor", "", "", "P01");

            //Agregamos los concepto 
            EasyOne_cfdi33_AddConcepto(p, "11101606", "", "1", "ACT", "", "Ejemplo CartaPorte", "15635.00", "15635.00", "7736.00");
            EasyOne_cfdi33_AddTraslado(p, "15635.00", "002", "Tasa", "0.000000", "0.00");
            EasyOne_cfdi33_AddRetencion(p, "15635.00", "001", "Tasa", "0.000000", "0.00");
            EasyOne_cfdi33_AddRetencion(p, "15635.00", "002", "Tasa", "0.000000", "0.00");
            EasyOne_cfdi33_AddInformacionAduanera(p, "16  16  3990  6000525");

            EasyOne_cfdi33_SetComprobanteImpuestos(p, "0.00", "0.00");
            EasyOne_cfdi33_AddRetencionesRetencion(p, "001", "0.00");
            EasyOne_cfdi33_AddRetencionesRetencion(p, "002", "0.00");
            EasyOne_cfdi33_AddTrasladosTraslado(p, "002", "Tasa", "0.000000", "0.00");

            //Se crea el complemento Carta porte
            int c = EasyOne_cartaporte10_Create();

            EasyOne_cartaporte10_SetCartaPorte(c, "No", "", "", "200.00");

            EasyOne_cartaporte10_AddUbicacion(c, "", "100.00");
            EasyOne_cartaporte10_SetUbicacionOrigen(c, "", "", "NombreRemitente1", "NumRegIdTrib1", "AFG", "", "", "", "2021-01-01T01:01:01");
            EasyOne_cartaporte10_SetUbicacionDestino(c, "", "", "NombreDestinatario1", "NumRegIdTrib1", "AFG", "", "", "", "2021-01-01T05:01:01");
            EasyOne_cartaporte10_SetUbicacionDomicilio(c, "Calle1", "NumeroExterior1", "NumeroInterior1", "Colonia1", "Localidad1", "Referencia1", "Municipio1", "Estado1", "AFG", "CodigoPosta1");

            EasyOne_cartaporte10_AddUbicacion(c, "", "100.00");
            EasyOne_cartaporte10_SetUbicacionOrigen(c, "", "", "NombreRemitente1", "NumRegIdTrib1", "AFG", "", "", "", "2021-01-01T01:01:01");
            EasyOne_cartaporte10_SetUbicacionDestino(c, "", "", "NombreDestinatario1", "NumRegIdTrib1", "AFG", "", "", "", "2021-01-01T05:01:01");
            EasyOne_cartaporte10_SetUbicacionDomicilio(c, "Calle1", "NumeroExterior1", "NumeroInterior1", "Colonia1", "Localidad1", "Referencia1", "Municipio1", "Estado1", "AFG", "CodigoPostal");


            EasyOne_cartaporte10_SetMercancias(c, "", "Tu", "1.00", "1", "0.000000");
            EasyOne_cartaporte10_AddMercancia(c, "11101606", "01", "Descripcion1", "1.00", "18", "Unidad1", "01/01/01cm", "Sí", "M0001", "1A1", "DescripEmbalaje1", "100.00", "0.000000", "AED", "", "");
            EasyOne_cartaporte10_SetMercanciasAutotransporteFederal(c, "TPAF01", "NumPermisoSCT1", "NombreAseg1", "NumPolizaSeguro1");
            EasyOne_cartaporte10_SetMercanciasAutotransporteFederalIdentificacionVehicular(c, "C2", "ABC123", "2020");
            EasyOne_cartaporte10_AddMercanciasAutotransporteFederalRemolque(c, "CTR001", "Placa1");
            EasyOne_cartaporte10_AddMercanciasAutotransporteFederalRemolque(c, "CTR002", "Placa2");

            EasyOne_cartaporte10_SetFiguraTransporte(c, "01");

            EasyOne_cartaporte10_AddFiguraTransporteOperador(c, "AAAA0001023NA", "NumLicencia1", "NombreOperador1", "", "");
            EasyOne_cartaporte10_SetFiguraTransporteOperadorDomicilio(c, "Calle1", "NumeroExterior1", "NumeroInterior1", "Colonia1", "Localidad1", "Referencia1", "Municipio1", "Estado1", "AFG", "CodigoPostal");

            EasyOne_cartaporte10_AddFiguraTransportePropietario(c, "", "NombrePropietario1", "NumRegIdTribPropietario1", "AFG");
            EasyOne_cartaporte10_SetFiguraTransportePropietarioDomicilio(c, "Calle1", "NumeroExterior1", "NumeroInterior1", "Colonia1", "Localidad1", "Referencia1", "Municipio1", "Estado1", "AFG", "CodigoPostal");

            EasyOne_cartaporte10_AddFiguraTransporteArrendatario(c, "", "NombrePropietario1", "NumRegIdTribPropietario1", "AFG");
            EasyOne_cartaporte10_SetFiguraTransporteArrendatarioDomicilio(c, "Calle1", "NumeroExterior1", "NumeroInterior1", "Colonia1", "Localidad1", "Referencia1", "Municipio1", "Estado1", "AFG", "CodigoPostal");

            EasyOne_cartaporte10_AddFiguraTransporteNotificado(c, "", "NombrePropietario1", "NumRegIdTribPropietario1", "ALB");
            EasyOne_cartaporte10_SetFiguraTransporteNotificadoDomicilio(c, "Calle1", "NumeroExterior1", "NumeroInterior1", "Colonia1", "Localidad1", "Referencia1", "Municipio1", "Estado1", "ALB", "CodigoPostal");


            EasyOne_AddComplemento(p, c);

            //Enviamos el CFDI al metodo de PRUEBAS donde los parametros son su clave de integracion (AgenteID/SoftwareId)
            EasyOne_SetInvoiceOneFachadaInfoPrueba(p, "2T6XDPCI", "2T6XDPCI");

            

            int i = EasyOne_FirmaComprobante(p, @"C:\EasyOne\CSD.cer", @"C:\EasyOne\CSD.key", "12345678a");
            
            //Si el resultado es 0 = El CFDI se procesó correctamente
            if (i == 0)
            {
                string resultadoXML = String.Empty;

                //Obtenemos el XML completo y timbrado

                Console.WriteLine(resultadoXML = EasyOne_LeeResultado(p, 8));
                File.WriteAllText(@"c:\CartaPorte\resultado.xml", resultadoXML);

                StreamReader sr = new StreamReader(@"c:\CartaPorte\resultado.xml");
                XmlSerializer serializer = new XmlSerializer(typeof(Comprobante));
                var oCartaPorte = (Comprobante)serializer.Deserialize(sr);



                #region QRCreacion

                byte[] qr = null;
                string sQR = "";
                string baseQR = "";

                qr = EasyOneCartaPorte.QR.createBarCode("https://verificacfdi.facturaelectronica.sat.gob.mx/default.aspx?id=" + oCartaPorte.Complemento.TimbreFiscalDigital.UUID +
                    "&re=" + oCartaPorte.Emisor.Rfc + "&fe=" + oCartaPorte.Receptor.Rfc + "&tt=" + oCartaPorte.Total + "&fe=" + oCartaPorte.Sello.Substring(oCartaPorte.Sello.Length - 9, 8));
                baseQR = System.Convert.ToBase64String(qr, 0, qr.Length);

                byte[] imgBytes = Convert.FromBase64String(baseQR);
                File.WriteAllBytes(@"c:\CartaPorte\qr.jpg", imgBytes);


                //sQR = System.String.Format("data:image/jpg;base64,{0}", baseQR);
                //File.WriteAllBytes(@"c:\CartaPorte\qr.jpg", sQR);




                ////Convert the Byte Array to Base64 Encoded string.
                //string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);

                ////***Save Base64 Encoded string as Image File***//

                ////Convert Base64 Encoded string to Byte Array.
                //byte[] imageBytes = Convert.FromBase64String(base64String);

                ////Save the Byte Array as Image File.
                //string filePath = Server.MapPath("~/Files/" + Path.GetFileName(FileUpload1.PostedFile.FileName));
                //File.WriteAllBytes(filePath, imageBytes);


                #endregion





                Console.WriteLine();
                Console.WriteLine("******************************");
                Console.WriteLine("*****¡Listo, XML Creado!*****");
                Console.WriteLine("******************************");


                Console.ReadLine();



            }
            else
            {

                //En caso de error mostrar el detalle.
                string DetalleError = EasyOne_LeeResultado(p, 11);
                Console.WriteLine(DetalleError);
                ObtenerMasDetalles(DetalleError);
                Console.ReadLine();
                Console.ReadLine();

                Console.ReadLine();
            }
        }

        private static void ObtenerMasDetalles(string detalleError)
        {
            Negocio negocio = new Negocio();
            var oError = negocio.ObtenerDetallesDelError(detalleError);

            if (oError != null)
            {
                Console.WriteLine("*************************************************************************");
                Console.WriteLine("                DETALLE DEL ERROR                                           ");
                Console.WriteLine("*************************************************************************");
                Console.WriteLine(oError.ATRIBUTO);
                Console.WriteLine(oError.CODIGOERROR);
                Console.WriteLine(oError.CASODEVALIDACION);
                Console.WriteLine(oError.ERROR);

            }
        }
    }
}
