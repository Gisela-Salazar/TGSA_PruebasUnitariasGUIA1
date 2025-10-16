using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using TGSA.Texto;

    namespace TGSA.Texto.UnitTestxUnit
    {
        public class StringManipulatorTests
        {
            private readonly StringManipulator _manipulator = new StringManipulator();

            // 1005: Invertir cadena "Hola"
            [Fact]
            public void ReverseString_InputHola_ReturnsAloH()
            {
                string result = _manipulator.ReverseString("Hola");
                Assert.Equal("aloH", result);
            }

            // -1006: Invertir cadena vacía
            [Fact]
            public void ReverseString_EmptyString_ReturnsEmpty()
            {
                string result = _manipulator.ReverseString(string.Empty);
                Assert.Equal(string.Empty, result);
            }

            // 1007: Remover espacios "Hola mundo"
            [Fact]
            public void RemoveSpaces_HolaMundo_ReturnsHolamundo()
            {
                string result = _manipulator.RemoveSpaces("Hola mundo");
                Assert.Equal("Holamundo", result);
            }

            // 1008: Remover solo espacios
            [Fact]
            public void RemoveSpaces_OnlySpaces_ReturnsEmpty()
            {
                string result = _manipulator.RemoveSpaces("   ");
                Assert.Equal(string.Empty, result);
            }
        }
    }

