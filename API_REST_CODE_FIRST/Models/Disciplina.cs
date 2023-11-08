using System.ComponentModel.DataAnnotations.Schema;

namespace API_REST_CODE_FIRST.Models
{
    public class Disciplina
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(name: "Id")]
        public int Id { get; set; }
        [Column(name: "Nome")]
        public string Nome { get; set; }
        [Column(name: "Descricao")]
         public string Descricao { get; set; }
    }
}
