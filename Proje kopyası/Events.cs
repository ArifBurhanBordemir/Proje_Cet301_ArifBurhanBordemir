using System;
using SQLite;

namespace Proje
{
    public class Events
    {
        [PrimaryKey, AutoIncrement]
        public int Id          { get; set; }
        public string Name     { get; set; }
        public string Location { get; set; }
        public string Imageurl { get; set; }

    }
}




