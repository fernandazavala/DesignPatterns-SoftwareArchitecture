using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;

namespace ExamenSegundoParcial
{
    class DocxFile
    {
        public void generateFile(string text, string path)
        {
            var doc = DocX.Create(path);
            doc.AddHeaders();
            doc.AddFooters();
            doc.InsertParagraph(text);
            doc.Save();
        }
    }
}
