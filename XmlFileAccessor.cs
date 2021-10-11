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
        private StreamReader sr;
        private Type objType;

        public void WriteObjectGroup(List<Type> list)
        {
            tw.Flush();
            for (int i = 0; i < list.Count; i++)
                serializer.Serialize(tw, list[i]);
        }

        public List<Type> ReadObjectGroup()
        {
            List<Type> list = new List<Type>();

            using (sr)
            {

            }

                return list;
        }

        public XmlFileAccessor(string Path, Type classType)
        {
            objType = classType;
            serializer = new XmlSerializer(objType);
            tw = new StreamWriter(Path);
            sr = new StreamReader(Path);
        }
    }
}
