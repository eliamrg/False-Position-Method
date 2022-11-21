using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WpfMath;

namespace Analisis_Numerico_Sistema_2
{
    static class EcuacionPNG
    {
        static int i = 0;
        public static string CrearEcuacion(string strLatex)
        {
            
            
            string nombreArchivo = @"EcuacionPNG"+i+".png";

            var parser = new TexFormulaParser();
            var formula = parser.Parse(strLatex);
            var pngByte = formula.RenderToPng(50.0, 0.0, 0.0, "Arial");
            File.WriteAllBytes(nombreArchivo, pngByte);
            i++;
            return nombreArchivo;
        }
    }
}
