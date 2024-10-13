namespace JovemProgramadorMVC10.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Aluno aluno { get; set; }   
    }
}
