using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGSA.Texto
{
    public class StringManipulator
    {
        // Invierte la cadena recibida 
        public string ReverseString(string input)
        {
            if (input == null) return null;
            char[] chars = input.ToCharArray();
            System.Array.Reverse(chars);
            return new string(chars);
        }

        // Elimina todos los espacios en blanco
        public string RemoveSpaces(string input)
        {
            if (input == null) return null;
            return input.Replace(" ", string.Empty);
        }
    }
}
