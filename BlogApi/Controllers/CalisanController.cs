using BlogApi.Models.Context;
using BlogApi.Models.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalisanController : ControllerBase
    {
        [HttpGet]

        public IActionResult CalısanListesi()
        {
            using var ctx = new Context();

            var deger = ctx.Calısans.ToList();

            return Ok(deger);
        }


        [HttpPost]

        public IActionResult CalısanEkle(Calısan calısan)
        {
            using var ctx=new Context();
            ctx.Add(calısan);
            ctx.SaveChanges();
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult CalısanGetir(int id)
        {
            using var ctx = new Context();  
            var deger=ctx.Calısans.Find(id);
            if (deger==null)
            {
                return NotFound();
            }
            else
            {
                return Ok(deger);
            }
          
        }
        [HttpDelete("{id}")]
        public IActionResult CalısanSil(int id)
        {

            using var ctx = new Context();
            var deger = ctx.Calısans.Find(id);
            if (deger == null)
            {
                return NotFound();

            }
            else
            {
                ctx.Remove(deger);
                ctx.SaveChanges();
                return Ok();
            }
           
        }
        [HttpPut]
        public IActionResult CalısanGüncelle(Calısan  calısan)
        {
            using var ctx=new Context();
            var cls = ctx.Calısans.Find(calısan.CalısanID);
            if (cls==null)
            {
                return NotFound();
            }
            else
            {
                cls.CalısanAdı = calısan.CalısanAdı;
                ctx.Update(cls);
                ctx.SaveChanges();
                return Ok();    

            }
        }
    }

}
