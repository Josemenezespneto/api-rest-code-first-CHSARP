using System.ComponentModel.DataAnnotations.Schema;

namespace API_REST_CODE_FIRST.Models
{
    [Table(name:"Professor")]
    public class Professor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(name: "Id")]
        public int Id { get; set; }
        [Column(name: "Nome")]
        public string Nome { get; set; }
        
        
        public string Cpf { get; set; }
        
        public string Titulacao { get; set; }

    }
}
