using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViotaStore.Models;

[Table("categoria")]
public class Categoria
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor deixe de ser filha da puta e digite essa porra , obrigado")]
    [StringLength(30, ErrorMessage = "O nome deve possuir no maximo 30 caracteres , filha da puta")]
    public string Nome { get; set; }

    [StringLength(300)]
    public string Foto { get; set; }
}
