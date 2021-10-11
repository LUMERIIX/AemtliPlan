using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace AemtliPlan
{
    class XmlFileAccessor
    {
        private XmlSerializer serializer;
        private TextWriter tw;
        private Type objType;

        public void WriteObjectGroup(List<Type> list)
        {

        }

        public XmlFileAccessor(string Path, Type classType)
        {
            objType = classType;
            serializer = new XmlSerializer(objType);
            tw = new StreamWriter(Path);
        }
    }
}
