using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViotaStore.Models;

[Table("Produto")]
public class Produto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required(ErrorMessage = "Por favor , informe a Categoria")]
    public int CategoriaId { get; set; }
    [ForeignKey("CategoriaId")]

    public Categoria Categoria { get; set; }

    [Required(ErrorMessage = "Por favor deixe de ser filha da puta e digite essa porra , obrigado")]
    [StringLength(60, ErrorMessage = "O nome deve possuir no maximo 60 caracteres , filha da puta")]
    public string Nome { get; set; }

    [Display(Name = "Desciçao", Prompt = "Desciçao")]
    [StringLength(1000, ErrorMessage = "A Desciçao deve possuir no maximo 100caracteres , cuzao")]
    public string Descricao { get; set; }

    [Display(Name = "Quantidade em estoque")]
    [Range(0, int.MaxValue)]
    [StringLength(1000, ErrorMessage = "Por favor , informe a quantidade em estoque")]
    public int QtdeEstoque { get; set; }

    [Display(Name = "Valor de Custo")]
    [Range(0, double.MaxValue)]
    [Column(TypeName = "numeric(10,2)")]
    public decimal ValorCusto { get; set; }

    [Display(Name = "Valor de Custo")]
    [Range(0, double.MaxValue)]
    [Column(TypeName = "numeric(10,2)")]
    public decimal ValorVenda { get; set; }

    public bool Destaque { get; set; }

    public List<ProdutoFoto> Fotos { get; set; }
    

}
