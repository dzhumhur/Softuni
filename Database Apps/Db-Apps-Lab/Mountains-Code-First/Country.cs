namespace Mountains_Code_First
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Country
    {
        [Key]
        [StringLength(2), MinLength(2)]
        [Column(TypeName = "char")]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
