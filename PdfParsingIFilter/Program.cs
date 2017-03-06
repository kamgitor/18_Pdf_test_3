using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IFilter;

namespace PdfParsingIFilter
{
    class Program
    {
        static void Main(string[] args)
        {
			// remember to rename the output exe to "filtdump.exe" to get access to the Adobe PDF IFilter 
			// installed with Acrobat Reader

			// read more: http://www.squarepdf.net/parsing-pdf-files-using-ifilter-c-net

			string path = "circ92.pdf";
			// string path = "SpiewnikKFC.pdf";

			Console.WriteLine("Parsing " + path);
			string result = ExtractTextFromPdf(path);
			Console.WriteLine(result);
        }

        public static string ExtractTextFromPdf(string path)
        {
			// DefaultParser.

			return DefaultParser.Extract(path);
        }
    }
}
