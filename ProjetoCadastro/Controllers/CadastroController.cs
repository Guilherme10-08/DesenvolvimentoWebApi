using Microsoft.AspNetCore.Mvc;
using ProjetoCadastro.Models;

namespace ProjetoCadastro.Controllers
{
	[Route("cadastro")]
	public class CadastroController:ControllerBase
	{
		[HttpGet]
		[Route("")]
		public string GetAll()
		{
			return "Consultando a lista de todos os usuários cadastrados!";
		}

		[HttpGet]
		[Route("{id:int}")]
		public string GetById(int id)
		{
			return "Retornando apenas um único dados como resultado de consulta";
		}

		[HttpPost]
		[Route("")]
		public string PostUser()
		{
			return "Inserindo um novo cadastro";
		}

		[HttpPut]
		[Route("{id:int}")]
		public string PutUser(int id)
		{
			return "Atualizando dados";
		}

		[HttpDelete]
		[Route("{id:int}")]
		public string DeleteUser(int id)
		{
			return "Deletando dados";
		}
	}
}
