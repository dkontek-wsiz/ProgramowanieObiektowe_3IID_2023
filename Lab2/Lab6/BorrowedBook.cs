using Lab2.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Lab6
{
    [Table("BorrowedBooks2")]
    public class BorrowedBook : IEntity<long>, ICreationTime
    {
        [Key]
        public long Id { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;
        public long BookId { get; set; }
        [ForeignKey(nameof(BookId))]
        public Book Book { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
