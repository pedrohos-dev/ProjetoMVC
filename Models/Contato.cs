using System.Reflection.Metadata;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoMVC.Models
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Telefone { get; set; }
        [Column(TypeName = "Number(1)")]
        public bool Ativo { get; set; }
    }
}