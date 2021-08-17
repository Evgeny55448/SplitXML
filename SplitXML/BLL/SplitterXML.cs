using System;
using System.Linq;
using System.Xml.Linq;

namespace BLL
{
    public class SplitterXML
    {
        public void SplitXmlFile(string sourceFile,
            string rootElement,
            string descendantElement,
            int takeElements,
            string destFilePrefix,
            string destPath)
        {
            XElement xml = XElement.Load(sourceFile);
            var childNodes = xml.Descendants(descendantElement);

            int cnt = childNodes.Count();
            int skip = 0;
            int take = takeElements;
            int fileno = 0;

            while (skip < cnt)
            {
                var c1 = childNodes.Skip(skip).Take(take);
                skip += take;
                fileno += 1;
                var fileName = $"{destFilePrefix}_{fileno}.xml";
                var frag = new XElement(rootElement, c1);

                frag.Save(destPath + fileName);
            }
        }
    }
}
