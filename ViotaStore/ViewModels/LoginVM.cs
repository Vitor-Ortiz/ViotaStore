using System.ComponentModel.DataAnnotations;
namespace ViotaStore.ViewModels;

public class LoginVM
{
    [Display(Name = "Email ou Nome de Usuário", Prompt = "Informe seu Email ou Nome de Usuário")]
    [Required(ErrorMessage = "Por favor , informe seu email ou nome de Usuário")]

    public string email { get; set; }

    [Display(Name = "Senha de Acesso", Prompt = "***********")]
    [Required(ErrorMessage = "Por favor , informe sua senha")]
    [DataType(DataType.Password)]

    public string Senha { get; set; }

    [Display(Name = "Manter conectado?")]

    public bool Lembrar { get; set; } = false;

    public string UrlRetorno { get; set; }
}
