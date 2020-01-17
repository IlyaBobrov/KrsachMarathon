using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Marathon
{
    [Table("Users")]
    public class User
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        [NotNull]
        public string Name { get; set; }
        [NotNull, Unique]
        public string Email { get; set; }
        [NotNull]
        public int Phone { get; set; }
        public string Photo { get; set; }
        [NotNull, Unique]
        public string Login { get; set; }
        [NotNull]
        public string Pass { get; set; }

    }
}
