using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpException
{
    internal class OversizedTriangeSideException : Exception
    { 
        public string Value { get; }

        public OversizedTriangeSideException() { }

        public OversizedTriangeSideException(string massage) : base(massage) { }

        public OversizedTriangeSideException(string massage, string value) : base(massage)
        {
            Value = value;
        }

        public override string? HelpLink 
        { 
            get
            {
                return "More about this you can find out https://google.com";
            }
        }
    }
}
