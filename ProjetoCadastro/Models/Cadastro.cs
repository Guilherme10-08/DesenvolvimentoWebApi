using System.ComponentModel.DataAnnotations;

namespace ProjetoCadastro.Models
{
	public class Cadastro
	{
		[Key]
		public int id_Cadastro { get; set; }

		[Required(ErrorMessage = "informe o nome do usuário a ser cadastrado")]
		public string nome_Cadastro { get; set; } = string.Empty;

		[Required(ErrorMessage = "informe a área de formação do usuário a ser cadastrado")]
		public string area_Formacao_Cadastro { get; set; } = string.Empty;

		[Required(ErrorMessage = "informe o tempo de experiência do usuário a ser cadastrado")]
		public int tempo_Experiencia { get; set; }
		[Required(ErrorMessage = "informe o telefone do usuário a ser cadastrado")]
		public int telefone_Cadastro { get; set; }

		[Required(ErrorMessage = "informe o e-mail do usuário a ser cadastrado")]
		[EmailAddress(ErrorMessage = "e-mail inválido, digite um e-mail válido")]
		public string email_Cadastro { get; set; } = string.Empty;
	}
}
