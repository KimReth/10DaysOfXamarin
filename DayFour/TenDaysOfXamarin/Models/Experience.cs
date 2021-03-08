using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TenDaysOfXamarin.Models
{
    //This is the class that models the table. Name of class is name of table.
    public class Experience
    {
        [PrimaryKey, AutoIncrement] // using directive for SQLite needed
        public int Id { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
