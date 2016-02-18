using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlMarkupBuilderLibrary
{
    public class CustomExceptions
    {
        [Serializable]
        public class XmlMarkupBuilderFinalizedException  : InvalidOperationException
        {
            public XmlMarkupBuilderFinalizedException() { }
            public XmlMarkupBuilderFinalizedException(string message) : base(message) { }
            public XmlMarkupBuilderFinalizedException(string message, Exception inner) : base(message, inner) { }
            protected XmlMarkupBuilderFinalizedException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context)
                : base(info, context) { }
        }

        [Serializable]
        public class XmlMarkupNoRootXmlObjectException : InvalidOperationException
        {
            public XmlMarkupNoRootXmlObjectException() { }
            public XmlMarkupNoRootXmlObjectException(string message) : base(message) { }
            public XmlMarkupNoRootXmlObjectException(string message, Exception inner) : base(message, inner) { }
            protected XmlMarkupNoRootXmlObjectException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context)
                : base(info, context)
            { }
        }

        [Serializable]
        public class XmlMarkupNoOpenedTagException : InvalidOperationException
        {
            public XmlMarkupNoOpenedTagException() { }
            public XmlMarkupNoOpenedTagException(string message) : base(message) { }
            public XmlMarkupNoOpenedTagException(string message, Exception inner) : base(message, inner) { }
            protected XmlMarkupNoOpenedTagException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context)
                : base(info, context)
            { }
        }
    }
}
