﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTesteClasses
{
    abstract class Empregado
    {
        private int matricula;
        private string nomeEmpregado;
        private DateTime dataEntradaEmpresa;

        public int Matricula //propriedade
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public string NomeEmpregado
        {
            get { return nomeEmpregado; }
            set { nomeEmpregado = value; }
        }
        public DateTime DataEntradaEmpresa 
        {
            get { return dataEntradaEmpresa; }
            set { dataEntradaEmpresa = value; }
        }
            public virtual int TempoTrabalho()
            {
                TimeSpan span = DateTime.Today.Subtract(this.DataEntradaEmpresa);
                return (Convert.ToInt32(span.Days));
            }
            public abstract double SalarioBruto ();
    }
   

    
}
