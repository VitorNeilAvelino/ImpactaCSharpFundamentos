using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace Impacta.Infra.Apoio
{
    public class Validar
    {
        /// <summary>
        /// Valida um XML a partir de um XSD.
        /// </summary>
        public static void Xml(XDocument xml, string xsd)
        {
            var xsdSchema = new XmlSchemaSet();
            xsdSchema.Add(XmlSchema.Read(new StringReader(xsd), null));

            xml.Validate(xsdSchema, (o, e) =>
            {
                if (e.Exception != null)
                    throw new XmlException(string.Format("Erro na validação do XML de entrada: {0}", e.Message), e.Exception);
            });
        }
    }
}