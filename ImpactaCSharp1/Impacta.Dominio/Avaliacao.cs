using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Impacta.Dominio
{
    public class Avaliacao
    {
        private string _materia;
        // public string Materia {get; set;}
        public string Materia
        {
            get { return _materia; }
            set { _materia = value; }
        }

        private decimal[] _notas = new decimal[4];
        public decimal[] Notas
        {
            get { return _notas; }
            set { _notas = value; }
        }

        //private decimal _media;
        public decimal Media
        {
            get { return (Notas[0] + Notas[1] + Notas[2] + Notas[3]) / 4; }
            // Media, por não poder ser atribuído nenhum valor a ela, é conhecida como
            // propriedade read-only.
            //set { _media = value; }
        }

        public SituacaoAluno Situacao
        {
            get
            {
                return Media < 5 ?
                    SituacaoAluno.Reprovado : Media < 7 ?
                    SituacaoAluno.Recuperacao : SituacaoAluno.Aprovado;
            }
            //set { _situacao = value; }
        }
    }
}
