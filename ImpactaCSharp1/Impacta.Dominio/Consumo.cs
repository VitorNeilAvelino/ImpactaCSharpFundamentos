using System;

namespace Impacta.Dominio
{
    public class Consumo
    {
        public decimal Km;
        public decimal Litros
        {
            get;
            set;
        }

        //private decimal _resultado;
        public decimal Resultado
        {
            get 
            {
                try
                {
                    return (Km / Litros); 
                }
                catch
                {
                    // Arremessa uma nova instância da classe Exception contendo uma 
                    // mensagem mais significativa para o usuário.
                    throw new Exception("A propriedade Litros não pode ser igual a zero.");
                }
            }
            //set { _resultado = value; }
        }
    }
}