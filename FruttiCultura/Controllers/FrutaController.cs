using FruttiCultura.DataContext;
using FruttiCultura.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace FruttiCultura.Controllers
{
    [Route("fruta")]
    public class FrutaController : ControllerBase
    {
        [HttpGet]
        [Route("")]

        public async Task<ActionResult<List<Fruta>>> GetFruta([FromServices] FrutaDataContext frutaDataContext)
        {
            await Task.Delay(500);


            return new List<Fruta>();
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Fruta>> GetOneFruta(int id, Fruta fruta, [FromServices] FrutaDataContext frutaDataContext)
        {
            //string mensagemGetOne = "Pegando apenas uma fruta, usando o id e restrição de rota!";

            //await Task.Delay(500);

            //try
            //{
            //    Ok(mensagemGetOne);

            //    return await Task.FromResult<string>(mensagemGetOne);
            //}
            //catch
            //{
            //    NotFound(mensagemGetOne);

            //    return mensagemGetOne;
            //}
            try
            {
                if (fruta.idFruta == id)
                {
                    await frutaDataContext.fruta.AsNoTracking().FirstOrDefaultAsync();

                    return new Fruta();
                }
                else
                {
                    NotFound(new { message = "Não foram encontrados nenhum registro que corresponde ao id passado na requisição!" });
                    return fruta;
                }
            }
            catch
            {
                return BadRequest(fruta);
            }

        }
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Fruta>> PostFruta([FromBody] Fruta fruta, [FromServices] FrutaDataContext frutaDataContext)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                frutaDataContext.Entry<Fruta>(fruta);

                await frutaDataContext.SaveChangesAsync();

                return Ok(fruta);
            }
            catch
            {
                await Task.Delay(500);

                return NotFound(fruta);
            }

        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<Fruta>> PutFruta(int id, [FromBody] Fruta fruta, [FromServices] FrutaDataContext frutaDataContext)
        {
            if (!ModelState.IsValid)
            {
                BadRequest(ModelState);
            }

            if (fruta.idFruta == id)
            {
                frutaDataContext.Update<Fruta>(fruta);

                await frutaDataContext.SaveChangesAsync();

                return Ok(fruta);
            }
            else
            {
                await Task.Delay(500);

                return NotFound(fruta);
            }

        }
    }
}
