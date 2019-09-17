namespace Dragonfly.PeekabooProperties.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class Column
    {
        public string columnName { get; set; }
        public string columnValue { get; set; }
    }

    public class ListItem
    {
        public SortedList<int, Column> columns { get; set; }

        public ListItem()
        {
            columns = new SortedList<int, Column>();
        }
    }
}