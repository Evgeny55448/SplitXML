using BLL;
using System;
using System.IO;

namespace SplitXML
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFile = @"C:\FileName.xml";
            string destFilePrefix = "FileNameNew";
            string destPath = @"C:\Result\";
            string rootElement = "ITEMS";
            string descElement = "ITEM";
            int take = 2000000;

            if (!File.Exists(sourceFile))
            {
                throw new Exception($"Not find file ({sourceFile})");
            }

            new SplitterXML().SplitXmlFile(sourceFile,
                rootElement,
                descElement,
                take,
                destFilePrefix,
                destPath);
        }
    }
}
