using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Marathon
{
    [Table("Marathons")]
    public class MarathonClass
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        [NotNull]
        public string Name { get; set; }
        public string Text { get; set; }
        [NotNull]
        public string Date { get; set; }
        [NotNull]
        public string Time { get; set; }
        [NotNull]
        public string Admins { get; set; }

        
    }
}
