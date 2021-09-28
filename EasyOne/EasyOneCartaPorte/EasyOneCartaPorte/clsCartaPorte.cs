namespace EasyOneCartaPorte
{
    public class clsCartaPorte
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

            private ComprobanteImpuestos impuestosField;

            private ComprobanteComplemento complementoField;

            private decimal versionField;

            private string selloField;

            private string noCertificadoField;

            private string certificadoField;

            private string serieField;

            private byte folioField;

            private System.DateTime fechaField;

            private byte formaPagoField;

            private decimal subTotalField;

            private decimal descuentoField;

            private string monedaField;

            private byte tipoCambioField;

            private decimal totalField;

            private string tipoDeComprobanteField;

            private string metodoPagoField;

            private ushort lugarExpedicionField;

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
            public ComprobanteImpuestos Impuestos
            {
                get
                {
                    return this.impuestosField;
                }
                set
                {
                    this.impuestosField = value;
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
            public byte FormaPago
            {
                get
                {
                    return this.formaPagoField;
                }
                set
                {
                    this.formaPagoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal SubTotal
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
            public decimal Descuento
            {
                get
                {
                    return this.descuentoField;
                }
                set
                {
                    this.descuentoField = value;
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
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte TipoCambio
            {
                get
                {
                    return this.tipoCambioField;
                }
                set
                {
                    this.tipoCambioField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal Total
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
            public string MetodoPago
            {
                get
                {
                    return this.metodoPagoField;
                }
                set
                {
                    this.metodoPagoField = value;
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
        public partial class ComprobanteEmisor
        {

            private string rfcField;

            private string nombreField;

            private ushort regimenFiscalField;

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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
        public partial class ComprobanteReceptor
        {

            private string rfcField;

            private string nombreField;

            private string usoCFDIField;

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

            private ComprobanteConceptosConceptoImpuestos impuestosField;

            private ComprobanteConceptosConceptoInformacionAduanera informacionAduaneraField;

            private uint claveProdServField;

            private byte cantidadField;

            private string claveUnidadField;

            private string descripcionField;

            private decimal valorUnitarioField;

            private decimal importeField;

            private decimal descuentoField;

            /// <remarks/>
            public ComprobanteConceptosConceptoImpuestos Impuestos
            {
                get
                {
                    return this.impuestosField;
                }
                set
                {
                    this.impuestosField = value;
                }
            }

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
            public byte Cantidad
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
            public decimal ValorUnitario
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
            public decimal Descuento
            {
                get
                {
                    return this.descuentoField;
                }
                set
                {
                    this.descuentoField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
        public partial class ComprobanteConceptosConceptoImpuestos
        {

            private ComprobanteConceptosConceptoImpuestosTraslados trasladosField;

            private ComprobanteConceptosConceptoImpuestosRetencion[] retencionesField;

            /// <remarks/>
            public ComprobanteConceptosConceptoImpuestosTraslados Traslados
            {
                get
                {
                    return this.trasladosField;
                }
                set
                {
                    this.trasladosField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Retencion", IsNullable = false)]
            public ComprobanteConceptosConceptoImpuestosRetencion[] Retenciones
            {
                get
                {
                    return this.retencionesField;
                }
                set
                {
                    this.retencionesField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
        public partial class ComprobanteConceptosConceptoImpuestosTraslados
        {

            private ComprobanteConceptosConceptoImpuestosTrasladosTraslado trasladoField;

            /// <remarks/>
            public ComprobanteConceptosConceptoImpuestosTrasladosTraslado Traslado
            {
                get
                {
                    return this.trasladoField;
                }
                set
                {
                    this.trasladoField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
        public partial class ComprobanteConceptosConceptoImpuestosTrasladosTraslado
        {

            private decimal baseField;

            private byte impuestoField;

            private string tipoFactorField;

            private decimal tasaOCuotaField;

            private decimal importeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal Base
            {
                get
                {
                    return this.baseField;
                }
                set
                {
                    this.baseField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Impuesto
            {
                get
                {
                    return this.impuestoField;
                }
                set
                {
                    this.impuestoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string TipoFactor
            {
                get
                {
                    return this.tipoFactorField;
                }
                set
                {
                    this.tipoFactorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal TasaOCuota
            {
                get
                {
                    return this.tasaOCuotaField;
                }
                set
                {
                    this.tasaOCuotaField = value;
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
        public partial class ComprobanteConceptosConceptoImpuestosRetencion
        {

            private decimal baseField;

            private byte impuestoField;

            private string tipoFactorField;

            private decimal tasaOCuotaField;

            private decimal importeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal Base
            {
                get
                {
                    return this.baseField;
                }
                set
                {
                    this.baseField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Impuesto
            {
                get
                {
                    return this.impuestoField;
                }
                set
                {
                    this.impuestoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string TipoFactor
            {
                get
                {
                    return this.tipoFactorField;
                }
                set
                {
                    this.tipoFactorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal TasaOCuota
            {
                get
                {
                    return this.tasaOCuotaField;
                }
                set
                {
                    this.tasaOCuotaField = value;
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
        public partial class ComprobanteImpuestos
        {

            private ComprobanteImpuestosRetencion[] retencionesField;

            private ComprobanteImpuestosTraslados trasladosField;

            private decimal totalImpuestosRetenidosField;

            private decimal totalImpuestosTrasladadosField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Retencion", IsNullable = false)]
            public ComprobanteImpuestosRetencion[] Retenciones
            {
                get
                {
                    return this.retencionesField;
                }
                set
                {
                    this.retencionesField = value;
                }
            }

            /// <remarks/>
            public ComprobanteImpuestosTraslados Traslados
            {
                get
                {
                    return this.trasladosField;
                }
                set
                {
                    this.trasladosField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal TotalImpuestosRetenidos
            {
                get
                {
                    return this.totalImpuestosRetenidosField;
                }
                set
                {
                    this.totalImpuestosRetenidosField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal TotalImpuestosTrasladados
            {
                get
                {
                    return this.totalImpuestosTrasladadosField;
                }
                set
                {
                    this.totalImpuestosTrasladadosField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
        public partial class ComprobanteImpuestosRetencion
        {

            private byte impuestoField;

            private decimal importeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Impuesto
            {
                get
                {
                    return this.impuestoField;
                }
                set
                {
                    this.impuestoField = value;
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
        public partial class ComprobanteImpuestosTraslados
        {

            private ComprobanteImpuestosTrasladosTraslado trasladoField;

            /// <remarks/>
            public ComprobanteImpuestosTrasladosTraslado Traslado
            {
                get
                {
                    return this.trasladoField;
                }
                set
                {
                    this.trasladoField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
        public partial class ComprobanteImpuestosTrasladosTraslado
        {

            private byte impuestoField;

            private string tipoFactorField;

            private decimal tasaOCuotaField;

            private decimal importeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Impuesto
            {
                get
                {
                    return this.impuestoField;
                }
                set
                {
                    this.impuestoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string TipoFactor
            {
                get
                {
                    return this.tipoFactorField;
                }
                set
                {
                    this.tipoFactorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal TasaOCuota
            {
                get
                {
                    return this.tasaOCuotaField;
                }
                set
                {
                    this.tasaOCuotaField = value;
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
        public partial class ComprobanteComplemento
        {

            private TimbreFiscalDigital timbreFiscalDigitalField;

            private CartaPorte cartaPorteField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.sat.gob.mx/TimbreFiscalDigital")]
            public TimbreFiscalDigital TimbreFiscalDigital
            {
                get
                {
                    return this.timbreFiscalDigitalField;
                }
                set
                {
                    this.timbreFiscalDigitalField = value;
                }
            }

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
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/TimbreFiscalDigital")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.sat.gob.mx/TimbreFiscalDigital", IsNullable = false)]
        public partial class TimbreFiscalDigital
        {

            private decimal versionField;

            private string uUIDField;

            private System.DateTime fechaTimbradoField;

            private string rfcProvCertifField;

            private string selloCFDField;

            private string noCertificadoSATField;

            private string selloSATField;

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
            public string UUID
            {
                get
                {
                    return this.uUIDField;
                }
                set
                {
                    this.uUIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public System.DateTime FechaTimbrado
            {
                get
                {
                    return this.fechaTimbradoField;
                }
                set
                {
                    this.fechaTimbradoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string RfcProvCertif
            {
                get
                {
                    return this.rfcProvCertifField;
                }
                set
                {
                    this.rfcProvCertifField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string SelloCFD
            {
                get
                {
                    return this.selloCFDField;
                }
                set
                {
                    this.selloCFDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
            public string NoCertificadoSAT
            {
                get
                {
                    return this.noCertificadoSATField;
                }
                set
                {
                    this.noCertificadoSATField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string SelloSAT
            {
                get
                {
                    return this.selloSATField;
                }
                set
                {
                    this.selloSATField = value;
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

            private decimal versionField;

            private string transpInternacField;

            private decimal totalDistRecField;

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
            public decimal TotalDistRec
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

            private decimal distanciaRecorridaField;

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
            public decimal DistanciaRecorrida
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
        public partial class CartaPorteUbicacionOrigen
        {

            private string nombreRemitenteField;

            private string numRegIdTribField;

            private string residenciaFiscalField;

            private System.DateTime fechaHoraSalidaField;

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
            public string NumRegIdTrib
            {
                get
                {
                    return this.numRegIdTribField;
                }
                set
                {
                    this.numRegIdTribField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ResidenciaFiscal
            {
                get
                {
                    return this.residenciaFiscalField;
                }
                set
                {
                    this.residenciaFiscalField = value;
                }
            }

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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
        public partial class CartaPorteUbicacionDestino
        {

            private string nombreDestinatarioField;

            private string numRegIdTribField;

            private string residenciaFiscalField;

            private System.DateTime fechaHoraProgLlegadaField;

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
            public string NumRegIdTrib
            {
                get
                {
                    return this.numRegIdTribField;
                }
                set
                {
                    this.numRegIdTribField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ResidenciaFiscal
            {
                get
                {
                    return this.residenciaFiscalField;
                }
                set
                {
                    this.residenciaFiscalField = value;
                }
            }

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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
        public partial class CartaPorteUbicacionDomicilio
        {

            private string calleField;

            private string numeroExteriorField;

            private string numeroInteriorField;

            private string coloniaField;

            private string localidadField;

            private string referenciaField;

            private string municipioField;

            private string estadoField;

            private string paisField;

            private string codigoPostalField;

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
            public string NumeroExterior
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
            public string Colonia
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
            public string Localidad
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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Municipio
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
            public string CodigoPostal
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
        public partial class CartaPorteMercancias
        {

            private CartaPorteMercanciasMercancia mercanciaField;

            private CartaPorteMercanciasAutotransporteFederal autotransporteFederalField;

            private string unidadPesoField;

            private decimal pesoNetoTotalField;

            private byte numTotalMercanciasField;

            private decimal cargoPorTasacionField;

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
            public string UnidadPeso
            {
                get
                {
                    return this.unidadPesoField;
                }
                set
                {
                    this.unidadPesoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal PesoNetoTotal
            {
                get
                {
                    return this.pesoNetoTotalField;
                }
                set
                {
                    this.pesoNetoTotalField = value;
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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal CargoPorTasacion
            {
                get
                {
                    return this.cargoPorTasacionField;
                }
                set
                {
                    this.cargoPorTasacionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
        public partial class CartaPorteMercanciasMercancia
        {

            private uint bienesTranspField;

            private byte claveSTCCField;

            private string descripcionField;

            private decimal cantidadField;

            private byte claveUnidadField;

            private string unidadField;

            private string dimensionesField;

            private string materialPeligrosoField;

            private string cveMaterialPeligrosoField;

            private string embalajeField;

            private string descripEmbalajeField;

            private decimal pesoEnKgField;

            private decimal valorMercanciaField;

            private string monedaField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint BienesTransp
            {
                get
                {
                    return this.bienesTranspField;
                }
                set
                {
                    this.bienesTranspField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte ClaveSTCC
            {
                get
                {
                    return this.claveSTCCField;
                }
                set
                {
                    this.claveSTCCField = value;
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
            public byte ClaveUnidad
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
            public string Dimensiones
            {
                get
                {
                    return this.dimensionesField;
                }
                set
                {
                    this.dimensionesField = value;
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
            public string DescripEmbalaje
            {
                get
                {
                    return this.descripEmbalajeField;
                }
                set
                {
                    this.descripEmbalajeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal PesoEnKg
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
            public decimal ValorMercancia
            {
                get
                {
                    return this.valorMercanciaField;
                }
                set
                {
                    this.valorMercanciaField = value;
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
        public partial class CartaPorteMercanciasAutotransporteFederal
        {

            private CartaPorteMercanciasAutotransporteFederalIdentificacionVehicular identificacionVehicularField;

            private CartaPorteMercanciasAutotransporteFederalRemolque[] remolquesField;

            private string permSCTField;

            private string numPermisoSCTField;

            private string nombreAsegField;

            private string numPolizaSeguroField;

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
            [System.Xml.Serialization.XmlArrayItemAttribute("Remolque", IsNullable = false)]
            public CartaPorteMercanciasAutotransporteFederalRemolque[] Remolques
            {
                get
                {
                    return this.remolquesField;
                }
                set
                {
                    this.remolquesField = value;
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
            public string NumPolizaSeguro
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
        public partial class CartaPorteMercanciasAutotransporteFederalIdentificacionVehicular
        {

            private string configVehicularField;

            private string placaVMField;

            private ushort anioModeloVMField;

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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
        public partial class CartaPorteMercanciasAutotransporteFederalRemolque
        {

            private string subTipoRemField;

            private string placaField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string SubTipoRem
            {
                get
                {
                    return this.subTipoRemField;
                }
                set
                {
                    this.subTipoRemField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Placa
            {
                get
                {
                    return this.placaField;
                }
                set
                {
                    this.placaField = value;
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

            private CartaPorteFiguraTransportePropietario propietarioField;

            private CartaPorteFiguraTransporteArrendatario arrendatarioField;

            private CartaPorteFiguraTransporteNotificado notificadoField;

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
            public CartaPorteFiguraTransportePropietario Propietario
            {
                get
                {
                    return this.propietarioField;
                }
                set
                {
                    this.propietarioField = value;
                }
            }

            /// <remarks/>
            public CartaPorteFiguraTransporteArrendatario Arrendatario
            {
                get
                {
                    return this.arrendatarioField;
                }
                set
                {
                    this.arrendatarioField = value;
                }
            }

            /// <remarks/>
            public CartaPorteFiguraTransporteNotificado Notificado
            {
                get
                {
                    return this.notificadoField;
                }
                set
                {
                    this.notificadoField = value;
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

            private string rFCOperadorField;

            private string numLicenciaField;

            private string nombreOperadorField;

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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
        public partial class CartaPorteFiguraTransporteOperadoresOperadorDomicilio
        {

            private string calleField;

            private string numeroExteriorField;

            private string numeroInteriorField;

            private string coloniaField;

            private string localidadField;

            private string referenciaField;

            private string municipioField;

            private string estadoField;

            private string paisField;

            private string codigoPostalField;

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
            public string NumeroExterior
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
            public string Colonia
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
            public string Localidad
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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Municipio
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
            public string CodigoPostal
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
        public partial class CartaPorteFiguraTransportePropietario
        {

            private CartaPorteFiguraTransportePropietarioDomicilio domicilioField;

            private string nombrePropietarioField;

            private string numRegIdTribPropietarioField;

            private string residenciaFiscalPropietarioField;

            /// <remarks/>
            public CartaPorteFiguraTransportePropietarioDomicilio Domicilio
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
            public string NombrePropietario
            {
                get
                {
                    return this.nombrePropietarioField;
                }
                set
                {
                    this.nombrePropietarioField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string NumRegIdTribPropietario
            {
                get
                {
                    return this.numRegIdTribPropietarioField;
                }
                set
                {
                    this.numRegIdTribPropietarioField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ResidenciaFiscalPropietario
            {
                get
                {
                    return this.residenciaFiscalPropietarioField;
                }
                set
                {
                    this.residenciaFiscalPropietarioField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
        public partial class CartaPorteFiguraTransportePropietarioDomicilio
        {

            private string calleField;

            private string numeroExteriorField;

            private string numeroInteriorField;

            private string coloniaField;

            private string localidadField;

            private string referenciaField;

            private string municipioField;

            private string estadoField;

            private string paisField;

            private string codigoPostalField;

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
            public string NumeroExterior
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
            public string Colonia
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
            public string Localidad
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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Municipio
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
            public string CodigoPostal
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
        public partial class CartaPorteFiguraTransporteArrendatario
        {

            private CartaPorteFiguraTransporteArrendatarioDomicilio domicilioField;

            private string nombreArrendatarioField;

            private string numRegIdTribArrendatarioField;

            private string residenciaFiscalArrendatarioField;

            /// <remarks/>
            public CartaPorteFiguraTransporteArrendatarioDomicilio Domicilio
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
            public string NombreArrendatario
            {
                get
                {
                    return this.nombreArrendatarioField;
                }
                set
                {
                    this.nombreArrendatarioField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string NumRegIdTribArrendatario
            {
                get
                {
                    return this.numRegIdTribArrendatarioField;
                }
                set
                {
                    this.numRegIdTribArrendatarioField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ResidenciaFiscalArrendatario
            {
                get
                {
                    return this.residenciaFiscalArrendatarioField;
                }
                set
                {
                    this.residenciaFiscalArrendatarioField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
        public partial class CartaPorteFiguraTransporteArrendatarioDomicilio
        {

            private string calleField;

            private string numeroExteriorField;

            private string numeroInteriorField;

            private string coloniaField;

            private string localidadField;

            private string referenciaField;

            private string municipioField;

            private string estadoField;

            private string paisField;

            private string codigoPostalField;

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
            public string NumeroExterior
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
            public string Colonia
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
            public string Localidad
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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Municipio
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
            public string CodigoPostal
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
        public partial class CartaPorteFiguraTransporteNotificado
        {

            private CartaPorteFiguraTransporteNotificadoDomicilio domicilioField;

            private string nombreNotificadoField;

            private string numRegIdTribNotificadoField;

            private string residenciaFiscalNotificadoField;

            /// <remarks/>
            public CartaPorteFiguraTransporteNotificadoDomicilio Domicilio
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
            public string NombreNotificado
            {
                get
                {
                    return this.nombreNotificadoField;
                }
                set
                {
                    this.nombreNotificadoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string NumRegIdTribNotificado
            {
                get
                {
                    return this.numRegIdTribNotificadoField;
                }
                set
                {
                    this.numRegIdTribNotificadoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ResidenciaFiscalNotificado
            {
                get
                {
                    return this.residenciaFiscalNotificadoField;
                }
                set
                {
                    this.residenciaFiscalNotificadoField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
        public partial class CartaPorteFiguraTransporteNotificadoDomicilio
        {

            private string calleField;

            private string numeroExteriorField;

            private string numeroInteriorField;

            private string coloniaField;

            private string localidadField;

            private string referenciaField;

            private string municipioField;

            private string estadoField;

            private string paisField;

            private string codigoPostalField;

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
            public string NumeroExterior
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
            public string Colonia
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
            public string Localidad
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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Municipio
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
            public string CodigoPostal
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
        }


    }
}
