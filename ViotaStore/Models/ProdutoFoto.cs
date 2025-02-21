using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViotaStore.Models;

[Table("ProdutoFoto")]

public class ProdutoFoto
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Produto")]
    [Required(ErrorMessage = "Por favor , informe o Produto")]
    public int ProdutoId { get; set; }
    
    [ForeignKey("ProdutoId")]
    public Produto Produto { get; set; }

    [Display(Name = "Foto")]
    [StringLength(200)]
    [Required(ErrorMessage = "Por favor , selecione a foto")]
    public string ArquivoFoto { get; set; }
    
    [Display(Name = "Descrição")]
    public string Descicao { get; set; }
}
