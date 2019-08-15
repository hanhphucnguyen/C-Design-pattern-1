using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory
{
    public class MarkdownTable : MarkdownElement
    {
        private TableProperties _props;
        public MarkdownTable(TableProperties props)
        {
            _props = props;
        }

        public override string ToString()
        {
            string table = "";
            if (_props.Headers != null)
            {
                table += "|";
                foreach (var header in _props.Headers)
                {
                    table += $" {header} |";
                }
                table += "\n";

                table += "|";
                foreach (var header in _props.Headers)
                {
                    table += $" --- |";
                }
                table += "\n";
            }


            if (_props.Rows != null)
            {
                foreach (var row in _props.Rows)
                {
                    table += "|";
                    foreach (var item in row)
                    {
                        table += $" {item} |";
                    }
                    table += "\n";
                }
            }
            return table;
        }
    }
}
