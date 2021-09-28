using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyOneCartaPorte
{
    public class clasescartaporte
    {

        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.sat.gob.mx/cfd/3", IsNullable = false)]
        public partial class Comprobante
        {

            private ComprobanteEmisor emisorField;

            private ComprobanteReceptor receptorField;

            private ComprobanteConceptos conceptosField;

            private ComprobanteComplemento complementoField;

            private string certificadoField;

            private System.DateTime fechaField;

            private byte folioField;

            private ushort lugarExpedicionField;

            private string monedaField;

            private string noCertificadoField;

            private string selloField;

            private string serieField;

            private byte subTotalField;

            private string tipoDeComprobanteField;

            private byte totalField;

            private decimal versionField;

            /// <remarks/>
            public ComprobanteEmisor Emisor
            {
                get
                {
                    return this.emisorField;
                }
                set
                {
                    this.emisorField = value;
                }
            }

            /// <remarks/>
            public ComprobanteReceptor Receptor
            {
                get
                {
                    return this.receptorField;
                }
                set
                {
                    this.receptorField = value;
                }
            }

            /// <remarks/>
            public ComprobanteConceptos Conceptos
            {
                get
                {
                    return this.conceptosField;
                }
                set
                {
                    this.conceptosField = value;
                }
            }

            /// <remarks/>
            public ComprobanteComplemento Complemento
            {
                get
                {
                    return this.complementoField;
                }
                set
                {
                    this.complementoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Certificado
            {
                get
                {
                    return this.certificadoField;
                }
                set
                {
                    this.certificadoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public System.DateTime Fecha
            {
                get
                {
                    return this.fechaField;
                }
                set
                {
                    this.fechaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Folio
            {
                get
                {
                    return this.folioField;
                }
                set
                {
                    this.folioField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort LugarExpedicion
            {
                get
                {
                    return this.lugarExpedicionField;
                }
                set
                {
                    this.lugarExpedicionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Moneda
            {
                get
                {
                    return this.monedaField;
                }
                set
                {
                    this.monedaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
            public string NoCertificado
            {
                get
                {
                    return this.noCertificadoField;
                }
                set
                {
                    this.noCertificadoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Sello
            {
                get
                {
                    return this.selloField;
                }
                set
                {
                    this.selloField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Serie
            {
                get
                {
                    return this.serieField;
                }
                set
                {
                    this.serieField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte SubTotal
            {
                get
                {
                    return this.subTotalField;
                }
                set
                {
                    this.subTotalField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string TipoDeComprobante
            {
                get
                {
                    return this.tipoDeComprobanteField;
                }
                set
                {
                    this.tipoDeComprobanteField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Total
            {
                get
                {
                    return this.totalField;
                }
                set
                {
                    this.totalField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal Version
            {
                get
                {
                    return this.versionField;
                }
                set
                {
                    this.versionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
        public partial class ComprobanteEmisor
        {

            private string nombreField;

            private ushort regimenFiscalField;

            private string rfcField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Nombre
            {
                get
                {
                    return this.nombreField;
                }
                set
                {
                    this.nombreField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort RegimenFiscal
            {
                get
                {
                    return this.regimenFiscalField;
                }
                set
                {
                    this.regimenFiscalField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Rfc
            {
                get
                {
                    return this.rfcField;
                }
                set
                {
                    this.rfcField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
        public partial class ComprobanteReceptor
        {

            private string nombreField;

            private string rfcField;

            private string usoCFDIField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Nombre
            {
                get
                {
                    return this.nombreField;
                }
                set
                {
                    this.nombreField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Rfc
            {
                get
                {
                    return this.rfcField;
                }
                set
                {
                    this.rfcField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string UsoCFDI
            {
                get
                {
                    return this.usoCFDIField;
                }
                set
                {
                    this.usoCFDIField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
        public partial class ComprobanteConceptos
        {

            private ComprobanteConceptosConcepto conceptoField;

            /// <remarks/>
            public ComprobanteConceptosConcepto Concepto
            {
                get
                {
                    return this.conceptoField;
                }
                set
                {
                    this.conceptoField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
        public partial class ComprobanteConceptosConcepto
        {

            private ComprobanteConceptosConceptoInformacionAduanera informacionAduaneraField;

            private decimal cantidadField;

            private uint claveProdServField;

            private string claveUnidadField;

            private string descripcionField;

            private decimal importeField;

            private string unidadField;

            private byte valorUnitarioField;

            /// <remarks/>
            public ComprobanteConceptosConceptoInformacionAduanera InformacionAduanera
            {
                get
                {
                    return this.informacionAduaneraField;
                }
                set
                {
                    this.informacionAduaneraField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal Cantidad
            {
                get
                {
                    return this.cantidadField;
                }
                set
                {
                    this.cantidadField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint ClaveProdServ
            {
                get
                {
                    return this.claveProdServField;
                }
                set
                {
                    this.claveProdServField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ClaveUnidad
            {
                get
                {
                    return this.claveUnidadField;
                }
                set
                {
                    this.claveUnidadField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Descripcion
            {
                get
                {
                    return this.descripcionField;
                }
                set
                {
                    this.descripcionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal Importe
            {
                get
                {
                    return this.importeField;
                }
                set
                {
                    this.importeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Unidad
            {
                get
                {
                    return this.unidadField;
                }
                set
                {
                    this.unidadField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte ValorUnitario
            {
                get
                {
                    return this.valorUnitarioField;
                }
                set
                {
                    this.valorUnitarioField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
        public partial class ComprobanteConceptosConceptoInformacionAduanera
        {

            private string numeroPedimentoField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string NumeroPedimento
            {
                get
                {
                    return this.numeroPedimentoField;
                }
                set
                {
                    this.numeroPedimentoField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
        public partial class ComprobanteComplemento
        {

            private CartaPorte cartaPorteField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.sat.gob.mx/CartaPorte")]
            public CartaPorte CartaPorte
            {
                get
                {
                    return this.cartaPorteField;
                }
                set
                {
                    this.cartaPorteField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.sat.gob.mx/CartaPorte", IsNullable = false)]
        public partial class CartaPorte
        {

            private CartaPorteUbicacion[] ubicacionesField;

            private CartaPorteMercancias mercanciasField;

            private CartaPorteFiguraTransporte figuraTransporteField;

            private string entradaSalidaMercField;

            private ushort totalDistRecField;

            private string transpInternacField;

            private decimal versionField;

            private byte viaEntradaSalidaField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Ubicacion", IsNullable = false)]
            public CartaPorteUbicacion[] Ubicaciones
            {
                get
                {
                    return this.ubicacionesField;
                }
                set
                {
                    this.ubicacionesField = value;
                }
            }

            /// <remarks/>
            public CartaPorteMercancias Mercancias
            {
                get
                {
                    return this.mercanciasField;
                }
                set
                {
                    this.mercanciasField = value;
                }
            }

            /// <remarks/>
            public CartaPorteFiguraTransporte FiguraTransporte
            {
                get
                {
                    return this.figuraTransporteField;
                }
                set
                {
                    this.figuraTransporteField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string EntradaSalidaMerc
            {
                get
                {
                    return this.entradaSalidaMercField;
                }
                set
                {
                    this.entradaSalidaMercField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort TotalDistRec
            {
                get
                {
                    return this.totalDistRecField;
                }
                set
                {
                    this.totalDistRecField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string TranspInternac
            {
                get
                {
                    return this.transpInternacField;
                }
                set
                {
                    this.transpInternacField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal Version
            {
                get
                {
                    return this.versionField;
                }
                set
                {
                    this.versionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte ViaEntradaSalida
            {
                get
                {
                    return this.viaEntradaSalidaField;
                }
                set
                {
                    this.viaEntradaSalidaField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
        public partial class CartaPorteUbicacion
        {

            private CartaPorteUbicacionOrigen origenField;

            private CartaPorteUbicacionDestino destinoField;

            private CartaPorteUbicacionDomicilio domicilioField;

            private ushort distanciaRecorridaField;

            private byte tipoEstacionField;

            /// <remarks/>
            public CartaPorteUbicacionOrigen Origen
            {
                get
                {
                    return this.origenField;
                }
                set
                {
                    this.origenField = value;
                }
            }

            /// <remarks/>
            public CartaPorteUbicacionDestino Destino
            {
                get
                {
                    return this.destinoField;
                }
                set
                {
                    this.destinoField = value;
                }
            }

            /// <remarks/>
            public CartaPorteUbicacionDomicilio Domicilio
            {
                get
                {
                    return this.domicilioField;
                }
                set
                {
                    this.domicilioField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort DistanciaRecorrida
            {
                get
                {
                    return this.distanciaRecorridaField;
                }
                set
                {
                    this.distanciaRecorridaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte TipoEstacion
            {
                get
                {
                    return this.tipoEstacionField;
                }
                set
                {
                    this.tipoEstacionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
        public partial class CartaPorteUbicacionOrigen
        {

            private System.DateTime fechaHoraSalidaField;

            private string nombreRemitenteField;

            private string rFCRemitenteField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public System.DateTime FechaHoraSalida
            {
                get
                {
                    return this.fechaHoraSalidaField;
                }
                set
                {
                    this.fechaHoraSalidaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string NombreRemitente
            {
                get
                {
                    return this.nombreRemitenteField;
                }
                set
                {
                    this.nombreRemitenteField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string RFCRemitente
            {
                get
                {
                    return this.rFCRemitenteField;
                }
                set
                {
                    this.rFCRemitenteField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
        public partial class CartaPorteUbicacionDestino
        {

            private System.DateTime fechaHoraProgLlegadaField;

            private string nombreDestinatarioField;

            private string rFCDestinatarioField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public System.DateTime FechaHoraProgLlegada
            {
                get
                {
                    return this.fechaHoraProgLlegadaField;
                }
                set
                {
                    this.fechaHoraProgLlegadaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string NombreDestinatario
            {
                get
                {
                    return this.nombreDestinatarioField;
                }
                set
                {
                    this.nombreDestinatarioField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string RFCDestinatario
            {
                get
                {
                    return this.rFCDestinatarioField;
                }
                set
                {
                    this.rFCDestinatarioField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
        public partial class CartaPorteUbicacionDomicilio
        {

            private string calleField;

            private ushort codigoPostalField;

            private ushort coloniaField;

            private string estadoField;

            private byte localidadField;

            private byte municipioField;

            private byte numeroExteriorField;

            private string numeroInteriorField;

            private string paisField;

            private string referenciaField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Calle
            {
                get
                {
                    return this.calleField;
                }
                set
                {
                    this.calleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort CodigoPostal
            {
                get
                {
                    return this.codigoPostalField;
                }
                set
                {
                    this.codigoPostalField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort Colonia
            {
                get
                {
                    return this.coloniaField;
                }
                set
                {
                    this.coloniaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Estado
            {
                get
                {
                    return this.estadoField;
                }
                set
                {
                    this.estadoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Localidad
            {
                get
                {
                    return this.localidadField;
                }
                set
                {
                    this.localidadField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Municipio
            {
                get
                {
                    return this.municipioField;
                }
                set
                {
                    this.municipioField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte NumeroExterior
            {
                get
                {
                    return this.numeroExteriorField;
                }
                set
                {
                    this.numeroExteriorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string NumeroInterior
            {
                get
                {
                    return this.numeroInteriorField;
                }
                set
                {
                    this.numeroInteriorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Pais
            {
                get
                {
                    return this.paisField;
                }
                set
                {
                    this.paisField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Referencia
            {
                get
                {
                    return this.referenciaField;
                }
                set
                {
                    this.referenciaField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
        public partial class CartaPorteMercancias
        {

            private CartaPorteMercanciasMercancia mercanciaField;

            private CartaPorteMercanciasAutotransporteFederal autotransporteFederalField;

            private byte numTotalMercanciasField;

            /// <remarks/>
            public CartaPorteMercanciasMercancia Mercancia
            {
                get
                {
                    return this.mercanciaField;
                }
                set
                {
                    this.mercanciaField = value;
                }
            }

            /// <remarks/>
            public CartaPorteMercanciasAutotransporteFederal AutotransporteFederal
            {
                get
                {
                    return this.autotransporteFederalField;
                }
                set
                {
                    this.autotransporteFederalField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte NumTotalMercancias
            {
                get
                {
                    return this.numTotalMercanciasField;
                }
                set
                {
                    this.numTotalMercanciasField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
        public partial class CartaPorteMercanciasMercancia
        {

            private string cveMaterialPeligrosoField;

            private string embalajeField;

            private uint fraccionArancelariaField;

            private string materialPeligrosoField;

            private ushort pesoEnKgField;

            private string uUIDComercioExtField;

            private string unidadField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string CveMaterialPeligroso
            {
                get
                {
                    return this.cveMaterialPeligrosoField;
                }
                set
                {
                    this.cveMaterialPeligrosoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Embalaje
            {
                get
                {
                    return this.embalajeField;
                }
                set
                {
                    this.embalajeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint FraccionArancelaria
            {
                get
                {
                    return this.fraccionArancelariaField;
                }
                set
                {
                    this.fraccionArancelariaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string MaterialPeligroso
            {
                get
                {
                    return this.materialPeligrosoField;
                }
                set
                {
                    this.materialPeligrosoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort PesoEnKg
            {
                get
                {
                    return this.pesoEnKgField;
                }
                set
                {
                    this.pesoEnKgField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string UUIDComercioExt
            {
                get
                {
                    return this.uUIDComercioExtField;
                }
                set
                {
                    this.uUIDComercioExtField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Unidad
            {
                get
                {
                    return this.unidadField;
                }
                set
                {
                    this.unidadField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
        public partial class CartaPorteMercanciasAutotransporteFederal
        {

            private CartaPorteMercanciasAutotransporteFederalIdentificacionVehicular identificacionVehicularField;

            private string nombreAsegField;

            private string numPermisoSCTField;

            private byte numPolizaSeguroField;

            private string permSCTField;

            /// <remarks/>
            public CartaPorteMercanciasAutotransporteFederalIdentificacionVehicular IdentificacionVehicular
            {
                get
                {
                    return this.identificacionVehicularField;
                }
                set
                {
                    this.identificacionVehicularField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string NombreAseg
            {
                get
                {
                    return this.nombreAsegField;
                }
                set
                {
                    this.nombreAsegField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string NumPermisoSCT
            {
                get
                {
                    return this.numPermisoSCTField;
                }
                set
                {
                    this.numPermisoSCTField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte NumPolizaSeguro
            {
                get
                {
                    return this.numPolizaSeguroField;
                }
                set
                {
                    this.numPolizaSeguroField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string PermSCT
            {
                get
                {
                    return this.permSCTField;
                }
                set
                {
                    this.permSCTField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
        public partial class CartaPorteMercanciasAutotransporteFederalIdentificacionVehicular
        {

            private ushort anioModeloVMField;

            private string configVehicularField;

            private string placaVMField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort AnioModeloVM
            {
                get
                {
                    return this.anioModeloVMField;
                }
                set
                {
                    this.anioModeloVMField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ConfigVehicular
            {
                get
                {
                    return this.configVehicularField;
                }
                set
                {
                    this.configVehicularField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string PlacaVM
            {
                get
                {
                    return this.placaVMField;
                }
                set
                {
                    this.placaVMField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
        public partial class CartaPorteFiguraTransporte
        {

            private CartaPorteFiguraTransporteOperadores operadoresField;

            private byte cveTransporteField;

            /// <remarks/>
            public CartaPorteFiguraTransporteOperadores Operadores
            {
                get
                {
                    return this.operadoresField;
                }
                set
                {
                    this.operadoresField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte CveTransporte
            {
                get
                {
                    return this.cveTransporteField;
                }
                set
                {
                    this.cveTransporteField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
        public partial class CartaPorteFiguraTransporteOperadores
        {

            private CartaPorteFiguraTransporteOperadoresOperador operadorField;

            /// <remarks/>
            public CartaPorteFiguraTransporteOperadoresOperador Operador
            {
                get
                {
                    return this.operadorField;
                }
                set
                {
                    this.operadorField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
        public partial class CartaPorteFiguraTransporteOperadoresOperador
        {

            private CartaPorteFiguraTransporteOperadoresOperadorDomicilio domicilioField;

            private string nombreOperadorField;

            private string numLicenciaField;

            private string rFCOperadorField;

            private string residenciaFiscalOperadorField;

            /// <remarks/>
            public CartaPorteFiguraTransporteOperadoresOperadorDomicilio Domicilio
            {
                get
                {
                    return this.domicilioField;
                }
                set
                {
                    this.domicilioField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string NombreOperador
            {
                get
                {
                    return this.nombreOperadorField;
                }
                set
                {
                    this.nombreOperadorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string NumLicencia
            {
                get
                {
                    return this.numLicenciaField;
                }
                set
                {
                    this.numLicenciaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string RFCOperador
            {
                get
                {
                    return this.rFCOperadorField;
                }
                set
                {
                    this.rFCOperadorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ResidenciaFiscalOperador
            {
                get
                {
                    return this.residenciaFiscalOperadorField;
                }
                set
                {
                    this.residenciaFiscalOperadorField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
        public partial class CartaPorteFiguraTransporteOperadoresOperadorDomicilio
        {

            private string calleField;

            private ushort codigoPostalField;

            private ushort coloniaField;

            private string estadoField;

            private byte localidadField;

            private byte municipioField;

            private byte numeroExteriorField;

            private string numeroInteriorField;

            private string paisField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Calle
            {
                get
                {
                    return this.calleField;
                }
                set
                {
                    this.calleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort CodigoPostal
            {
                get
                {
                    return this.codigoPostalField;
                }
                set
                {
                    this.codigoPostalField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort Colonia
            {
                get
                {
                    return this.coloniaField;
                }
                set
                {
                    this.coloniaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Estado
            {
                get
                {
                    return this.estadoField;
                }
                set
                {
                    this.estadoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Localidad
            {
                get
                {
                    return this.localidadField;
                }
                set
                {
                    this.localidadField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Municipio
            {
                get
                {
                    return this.municipioField;
                }
                set
                {
                    this.municipioField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte NumeroExterior
            {
                get
                {
                    return this.numeroExteriorField;
                }
                set
                {
                    this.numeroExteriorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string NumeroInterior
            {
                get
                {
                    return this.numeroInteriorField;
                }
                set
                {
                    this.numeroInteriorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Pais
            {
                get
                {
                    return this.paisField;
                }
                set
                {
                    this.paisField = value;
                }
            }
        }


    }
}
