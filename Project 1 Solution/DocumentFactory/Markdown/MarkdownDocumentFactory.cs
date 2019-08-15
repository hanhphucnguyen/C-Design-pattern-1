using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFactory
{
    public class MarkdownDocumentFactory : IDocumentFactory
    {
        private static MarkdownDocumentFactory _markdownDocumentFactory;
        private MarkdownDocumentFactory() { }

        public static IDocumentFactory GetInstance()
        {
            if(_markdownDocumentFactory == null)
            {
                _markdownDocumentFactory = new MarkdownDocumentFactory();
            }
            return _markdownDocumentFactory;
        }

        public IDocument CreateDocument(string fileName)
        {
            return new MarkdownDocument(fileName);
        }

        private MarkdownHeader CreateHeader(string props)
        {
            var propList = props.Split(';');
            var properties = new HeaderProperties
            {
                HeaderLevel = Convert.ToInt32(propList[0]),
                Text = propList[1]
            };
            return new MarkdownHeader(properties);
        }

        private MarkdownImage CreateImage(string props)
        {
            var propList = props.Split(';');
            var properties = new ImageProperties
            {
                Uri = propList[0],
                AltText = propList[1],
                TitleText = propList[2]
            };
            return new MarkdownImage(properties);
        }

        private MarkdownList CreateList(string props)
        {
            var propList = props.Split(';');
            var properties = new ListProperties
            {
                Type = propList[0] == "Unordered" ? ListProperties.ListType.Unordered : ListProperties.ListType.Ordered,
                Items = propList.Skip(1).ToList()
            };
            return new MarkdownList(properties);
        }

        private MarkdownTable CreateTable(string props)
        {
            var itemList = props.Split(';');
            var properties = new TableProperties();
            properties.Rows = new List<List<string>>();

            foreach(var item in itemList)
            {
                var parts = item.Split('$');
                switch (parts[0])
                {
                    case "Head":
                        properties.Headers = new List<string>(parts.Skip(1));
                        break;
                    case "Row":
                        properties.Rows.Add(new List<string>(parts.Skip(1)));
                        break;
                }
            }

            return new MarkdownTable(properties);
        }

        public IElement CreateElement(string elementType, string props)
        {
            switch (elementType)
            {
                case "Header":
                    return CreateHeader(props);
                case "Image":
                    return CreateImage(props);
                case "List":
                    return CreateList(props);
                case "Table":
                    return CreateTable(props);
                default:
                    return new MarkdownElement();
            }
        }
    }
}
