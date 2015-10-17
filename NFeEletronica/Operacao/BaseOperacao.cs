﻿using NFeEletronica.Contexto;

namespace NFeEletronica.Operacao
{
    public abstract class BaseOperacao
    {
        protected INFeContexto NFeContexto;

        protected BaseOperacao(INFeContexto nfeContexto)
        {
            NFeContexto = nfeContexto;
        }
    }
}