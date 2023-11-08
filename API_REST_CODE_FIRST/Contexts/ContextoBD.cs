using API_REST_CODE_FIRST.Models;
using Microsoft.EntityFrameworkCore;

namespace API_REST_CODE_FIRST.Contexts
{
    public class ContextoBD: DbContext
    {
        public ContextoBD(DbContextOptions<ContextoBD> options) : base(options)
        {

        }
        public DbSet<Professor> Professores { get; set;}
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Curso> Cursos{ get; set; }

    }
}
