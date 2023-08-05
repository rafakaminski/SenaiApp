using SenaiApp.Domain.Enums;

namespace SenaiApp.Domain.Entidade
{
    public class Cliente : BaseEntity
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public SexoEnum Sexo { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}
