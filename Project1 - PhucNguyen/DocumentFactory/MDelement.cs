namespace DocumentFactory
{
    public class MDelement
    {
        public MDelement()
        {

        }
        public virtual IElement MakeMDelement(string elementType, string props)
        {
            switch (elementType)
            {
                case "Image":
                     return new MDImageElement(props);
                case "Header":
                    return new MDHeaderElement(props);
                case "List":
                    return new MDListElement(props);
                case "Table":
                    return new MDTableElement(props);
                default:
                    return null;
            }
        }
    }

    public class MDImageElement : IElement
    {
        private string _props;
        public MDImageElement(string props)
        {
            _props = props;
        }
        public string createMD()
        {
            var temp = _props.Split(';');
            string final = "![" +temp[1]+ "](" + temp[0]+ " \"" + temp[2] +"\")" +"\n\n";
            return final;
        }
    }

    public class MDHeaderElement : IElement
    {
        private string _props;
        public MDHeaderElement(string props)
        {
            _props = props;
        }
        public string createMD()
        {
            var temp = _props.Split(';');
            string final = "# " + temp[1] + "\n\n";
            return final;
        }
    }

    public class MDListElement : IElement
    {
        private string _props;
        public MDListElement(string props)
        {
            _props = props;
        }
        public string createMD()
        {
            var temp = _props.Split(';');
            var final = "";
            if (temp[0] == "Ordered")
                final = "1. " + temp[1] + "\n2. " + temp[2] + "\n3. " + temp[3] + "\n\n";
            else
                final = "* " + temp[1] + "\n* " + temp[2] + "\n* " + temp[3] + "\n\n";
            return final;
        }
    }

    public class MDTableElement : IElement
    {
        private string _props;
        public MDTableElement(string props)
        {
            _props = props;
        }
        public string createMD()
        {
            var temp = _props.Split(';');
            var temp2 = temp[0].Split('$');
            string final = "| Table Heading 1 | Table Heading 2 | Table Heading 3 |" + "\n" + "| --- | --- | --- |" + "\n" + "| Some | Table | Text |" + "\n" + "| More | Table | Text |" + "\n" + "| Final | Table | Text | ";
            return final;
        }
    }

}