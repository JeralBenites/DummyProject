using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DummyProject.Domain
{
    [Table("dummyTable")]
    public class Dummy
    {
        [Key]
        [Column("id")]
        public int id { get; set; }
        [Column("name")]
        public string name { get; set; }
        [Column("document_number")]
        public string document_number { get; set; }
        [Column("salary")]
        public decimal salary { get; set; }
        [Column("age")]
        public int age { get; set; }
        [Column("profile")]
        public string profile { get; set; }
        [Column("address")]
        public string address { get; set; }
        [ForeignKey("phone_number")]
        public string phone_number { get; set; }
    }
}
