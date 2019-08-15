using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory
{
    public class HtmlTable : HtmlElement
    {
        private TableProperties _props;
        public HtmlTable(TableProperties props)
        {
            _props = props;
        }

        public override string ToString()
        {
            string table = "<table>";
            if (_props.Headers != null)
            {
                table += "<thead><tr>";
                foreach (var header in _props.Headers)
                {
                    table += $"<th>{header}</th>";
                }
                table += "</tr></thead>";
            }


            if (_props.Rows != null)
            {
                foreach (var row in _props.Rows)
                {
                    table += "<tr>";
                    foreach (var item in row)
                    {
                        table += $"<td>{item}</td>";
                    }
                    table += "</tr>";
                }
            }

            table += "</table>";
            return table;
        }
    }
}
