using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TexasRangers.Models
{
    public class Booking
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public int NumberofPeople { get; set; }
        public DateTime Date { get; set; }
    }
}
