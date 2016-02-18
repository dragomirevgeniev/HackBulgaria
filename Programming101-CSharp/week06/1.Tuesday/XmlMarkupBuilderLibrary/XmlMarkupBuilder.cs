using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlMarkupBuilderLibrary
{
    public class XmlMarkupBuilder
    {
        const string Tabulation = "    ";
        List<StringBuilder> documentLines;
        Stack<string> openedTagNames;
        Stack<int> openedTagLineNumbers;
        StringBuilder currentIndent;
        bool addedFirstTag;
        bool finalized;

        public XmlMarkupBuilder()
        {
            documentLines = new List<StringBuilder>();
            openedTagNames = new Stack<string>();
            openedTagLineNumbers = new Stack<int>();
            currentIndent = new StringBuilder();
            addedFirstTag = false;
            finalized = false;
        }

        public XmlMarkupBuilder OpenTag(string tagName)
        {
            if (finalized)
            {
                throw new XmlMarkupBuilderLibrary.CustomExceptions.XmlMarkupBuilderFinalizedException("Cannot use operation on finalized object!");
            }
            else if (!addedFirstTag)
            {
                openedTagNames.Push(tagName);
                openedTagLineNumbers.Push(documentLines.Count);
                documentLines.Add(new StringBuilder().Append(currentIndent).Append("<").Append(tagName));
                addedFirstTag = true;
            }
            else
            {
                if (openedTagNames.Count == 0)
                {
                    throw new XmlMarkupBuilderLibrary.CustomExceptions.XmlMarkupNoRootXmlObjectException("No root XML object!");
                }
                else
                {
                    openedTagNames.Push(tagName);
                    openedTagLineNumbers.Push(documentLines.Count);
                    documentLines.Add(new StringBuilder().Append(currentIndent).Append("<").Append(tagName));
                }
            }

            currentIndent.Append(Tabulation);
            return this;
        }

        public XmlMarkupBuilder AddAttr(string attrName, string attrValue)
        {
            if (finalized)
            {
                throw new XmlMarkupBuilderLibrary.CustomExceptions.XmlMarkupBuilderFinalizedException("Cannot use operation on finalized object!");
            }
            else if (openedTagNames.Count == 0) 
            {
                throw new XmlMarkupBuilderLibrary.CustomExceptions.XmlMarkupNoOpenedTagException("There is no opened tag!");
            }
            else
            {
                documentLines[openedTagLineNumbers.Peek()].Append(" ").Append(attrName).Append("=\"").Append(attrValue).Append("\"");
            }

            return this;
        }

        public XmlMarkupBuilder AddText(string text)
        {
            if (finalized)
            {
                throw new XmlMarkupBuilderLibrary.CustomExceptions.XmlMarkupBuilderFinalizedException("Cannot use operation on finalized object!");
            }
            else if (openedTagNames.Count == 0)
            {
                throw new XmlMarkupBuilderLibrary.CustomExceptions.XmlMarkupNoOpenedTagException("There is no opened tag!");
            }
            else
            {
                documentLines.Add(new StringBuilder().Append(currentIndent).Append(text));
            }

            return this;
        }

        public XmlMarkupBuilder CloseTag()
        {
            if (finalized)
            {
                throw new XmlMarkupBuilderLibrary.CustomExceptions.XmlMarkupBuilderFinalizedException("Cannot use operation on finalized object!");
            }

            else if (openedTagNames.Count == 0) 
            {
                throw new XmlMarkupBuilderLibrary.CustomExceptions.XmlMarkupNoOpenedTagException("There is no opened tag!");
            }
            else
            {
                currentIndent.Length -= Tabulation.Length;
                documentLines[openedTagLineNumbers.Pop()].Append(">");
                documentLines.Add(new StringBuilder().Append(currentIndent).Append("</").Append(openedTagNames.Pop()).Append(">"));
            }

            return this;
        }

        public XmlMarkupBuilder Finalize()
        {
            while (openedTagNames.Count > 0)
            {
                CloseTag();
            }

            finalized = true;
            return this;
        }

        public string GetResult()
        {
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < documentLines.Count - 1; i++)
            {
                output.Append(documentLines[i]);
                output.AppendLine();
            }

            return output.Append(documentLines[documentLines.Count - 1]).ToString();
        }
    }
}
