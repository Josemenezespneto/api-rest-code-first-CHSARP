using System.ComponentModel.DataAnnotations.Schema;

namespace API_REST_CODE_FIRST.Models
{
    public class Curso
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(name: "Id")]
        public int Id { get; set; }
        [Column(name: "Nome")]
        public string Nome { get; set; }
        [Column(name: "Preco")]
        public float Preco { get; set; }
        [Column(name: "Ementa")]
        public string Ementa { get; set; }


        public Professor Professor
        {
            get => default;
            set
            {
            }
        }

        public Disciplina Disciplina
        {
            get => default;
            set
            {
            }
        }
    }
}
