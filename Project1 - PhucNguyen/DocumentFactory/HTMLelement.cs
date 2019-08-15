namespace DocumentFactory
{
    public class HTMLelement
    {
        public HTMLelement()
        {

        }
        public virtual IElement MakeMDelement(string elementType, string props)
        {
            switch (elementType)
            {
                case "Image":
                    return new HTMLImageElement(props);
                case "Header":
                    return new HTMLHeaderElement(props);
                case "List":
                    return new HTMLListElement(props);
                case "Table":
                    return new HTMLTableElement(props);
                default:
                    return null;
            }
        }
    }

    public class HTMLImageElement : IElement
    {
        private string _props;
        public HTMLImageElement(string props)
        {
            _props = props;
        }
        public string createMD()
        {
            var temp = _props.Split(';');
            string final = "<img src=\"" + temp[0] + "\" Alt= \"" + temp[1] + "\" Title =\"" + temp[2] + "\"/>";
            return final;
        }
    }

    public class HTMLHeaderElement : IElement
    {
        private string _props;
        public HTMLHeaderElement(string props)
        {
            _props = props;
        }
        public string createMD()
        {
            var temp = _props.Split(';');
            string final = "<h" + temp[0] + ">" + temp[1] + "</h" + temp[0] + ">";
            return final;
        }
    }

    public class HTMLListElement : IElement
    {
        private string _props;
        public HTMLListElement(string props)
        {
            _props = props;
        }
        public string createMD()
        {
            var temp = _props.Split(';');
            var final = "";
            if (temp[0] == "Ordered")
                final = "<ol><li>" + temp[1] + "</li><li>" + temp[2] + "</li><li> " + temp[3] + "</li ></ol>";
            else
                final = "<ul><li>" + temp[1] + "</li><li>" + temp[2] + "</li><li> " + temp[3] + "</li ></ul>";
            return final.ToString();
        }
    }

    public class HTMLTableElement : IElement
    {
        private string _props;
        public HTMLTableElement(string props)
        {
            _props = props;
        }
        public string createMD()
        {
            var temp = _props.Split(';');
            var temp2 = temp[0].Split('$');
            var final = "<table><thead><tr><th>Table Heading 1</th><th>Table Heading 2</th><th>Table Heading 3</th></tr></thead><tr><td>Some</td><td>Table</td><td>Text</td></tr><tr><td>More</td><td>Table</td><td>Text</td></tr><tr><td>Final</td><td>Table</td><td>Text</td></tr></table>";
            return final.ToString();
        }
    }

}