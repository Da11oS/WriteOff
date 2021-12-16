using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace WriteOff
{
    [Table(Name = "Employeer")]
    class Employeer
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "ID")]
        public int ID { get; set; }

        [Column(Name = "Surname")]
        public string Surname { get; set; }

        [Column(Name = "Name")]
        public string Name { get; set; }

        [Column(Name = "Patronymic")]
        public string Patronymic { get; set; }

        [Column(Name = "Position")]
        public string Position { get; set; }

        [Column(Name = "Branch")]
        public string Branch { get; set; }

        [Column(Name = "Date")]
        public DateTime Date { get; set; }

    }
    [Table(Name = "Hardwares")]
    class Hardwares
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "ID")]
        public int ID { get; set; }
        [Column(Name = "Name")]
        public string Name { get; set; }

        [Column(Name = "Type")]
        public string Type { get; set; }

        [Column(Name = "Date")]
        public DateTime Date { get; set; }
        [Column(Name = "FIO")]
        public string FIO { get; set; }
        [Column(Name = "Place")]
        public string Place { get; set; }
    }
    [Table(Name = "WriteOff")]
    class WriteOff
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "ID")]
        public int ID { get; set; }

        [Column(Name = "Reason")]
        public string Reason { get; set; }

        [Column(Name = "Type")]
        public string Type { get; set; }

        [Column(Name = "F_WriteOff")]
        public int F_WriteOff { get; set; }

        [Column(Name = "F_Employeer")]
        public int F_Employeer { get; set; }

        [Column(Name = "Date")]
        public DateTime Date { get; set; }
    }
}
