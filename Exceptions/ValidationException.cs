using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTubeDownloader.Exceptions
{
    internal class ValidationException : Exception
    {
        public ValidationException(string mensagem) : base(mensagem)
        {
            //
        }
    }
}
