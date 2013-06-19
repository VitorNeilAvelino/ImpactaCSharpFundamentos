using System;
using System.Linq;

namespace Impacta.Dominio
{
    public class Cliente : Pessoa
    {
        public decimal Renda { get; set; }
        
        /// <summary>
        /// Propriedade não mapeada no banco de dados
        /// </summary>
        public string Cpf
        {
            get
            {
                var cpf = Documentos.FirstOrDefault(x => x.TipoDocumento == TipoDocumento.Cpf);
                return cpf != null ? cpf.Numero : null;
            }
            set
            {
                var documento = new Documento();
                documento.Numero = value;
                documento.TipoDocumento = TipoDocumento.Cpf;
                Documentos.Add(documento);
            }
        }

        public bool Preferencial { get; set; }

        public override void Validar()
        {
            const int idadeMinima = 18;

            if (DataNascimento > DateTime.Now.AddYears(-idadeMinima))
            {
                throw new RegraNegocioException(string.Format("O cliente deve ter mais de {0} anos.", idadeMinima));
            }
        }
    }
}