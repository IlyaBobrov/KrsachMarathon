using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Marathon
{
    [Table("UsersClass")]
    public class User
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string Name { get; set; }
        [Unique]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Photo { get; set; }
        [Unique]
        public string Login { get; set; }
        public string Pass { get; set; }

    }
}
