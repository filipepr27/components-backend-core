﻿using System;

namespace Optsol.Components.Shared.Exceptions
{
    [Serializable]
    public sealed class ElasticContextNullException : Exception
    {
        public ElasticContextNullException()
            : base("O parametro ElasticContext não foi resolvido pela injeção de dependência")
        {

        }
    }
}
