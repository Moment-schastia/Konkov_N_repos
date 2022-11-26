using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDecorator
{
    internal class LoudGigantosarusDecorator : IGigantosaurus
    {
        private IGigantosaurus _gigantosaurus;

        public LoudGigantosarusDecorator(IGigantosaurus gigantosaurus) 
        {
            _gigantosaurus = gigantosaurus;
        }

        public string Roar()
        {
            return _gigantosaurus.Roar().ToUpper();
        }
    }
} // The class for "decorating" of objects, in this case modifies the Roar method
