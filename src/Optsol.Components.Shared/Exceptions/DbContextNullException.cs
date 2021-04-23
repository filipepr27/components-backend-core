using System;

namespace Optsol.Components.Shared.Exceptions
{
    [Serializable]
    public sealed class DbContextNullException : Exception
    {  
        public DbContextNullException()
            : base ("O parametro DBContext não foi resolvido pela injeção de dependência")
        {
            
        }
    }
}
