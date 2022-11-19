using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpException
{
    internal class UnsuitableZeroValue : Exception
    {
        public string Value { get; }
        public UnsuitableZeroValue() { }
        public UnsuitableZeroValue(string message) : base(message) { }
        public UnsuitableZeroValue(string massage, string value) : base(massage)
        {
            Value = value;
        }
    }
}
