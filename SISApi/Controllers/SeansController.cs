using Microsoft.AspNetCore.Mvc;
using System;
using IS = SISIsKatmani;
using VAR = SISVarliklar;

namespace SISApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeansController : ControllerBase
    {
        [HttpPost("kaydet")]
        public IActionResult Kaydet([FromBody] VAR.Seans seans)
        {
            try
            {
                int sonuc = IS.Seans.Kaydet(seans);
                return Ok(sonuc);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("uzman/{uzmanNo}")]
        public IActionResult UzmanSeanslariniListele(int uzmanNo)
        {
            try
            {
                var seanslar = IS.Seans.UzmanSeanslariniListele(uzmanNo);
                return Ok(seanslar);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("iptal")]
        public IActionResult IptalEt([FromBody] VAR.Seans seans)
        {
            try
            {
                bool sonuc = IS.Seans.IptalEt(seans);
                return Ok(sonuc);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("hasta/{hastaNo}/son-seans")]
        public IActionResult SonSeansBilgisiGetir(int hastaNo)
        {
            try
            {
                var seans = IS.Seans.SonSeansBilgisiGetir(hastaNo);

                if (seans == null)
                    return NotFound("Seans bilgisi bulunamadı.");

                return Ok(seans);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("hasta/{hastaNo}/son-randevu")]
        public IActionResult SonRandevuBilgisiGetir(int hastaNo)
        {
            try
            {
                var seans = IS.Seans.SonRandevuBilgisiGetir(hastaNo);

                if (seans == null)
                    return NotFound("Randevu bilgisi bulunamadı.");

                return Ok(seans);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("randevu-kaydet")]
        public IActionResult RandevuKaydet([FromBody] RandevuKaydetRequest request)
        {
            try
            {
                bool sonuc = IS.Seans.RandevuKaydet(request.SeansNo, request.HastaNo);
                return Ok(sonuc);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("randevu-iptal/{seansNo}")]
        public IActionResult RandevuIptalEt(int seansNo)
        {
            try
            {
                bool sonuc = IS.Seans.RandevuIptalEt(seansNo);
                return Ok(sonuc);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("hasta/{hastaNo}/seanslar")]
        public IActionResult HastaSeanslariniListele(int hastaNo)
        {
            try
            {
                var seanslar = IS.Seans.HastaSeanslariniListele(hastaNo);
                return Ok(seanslar);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("not-guncelle")]
        public IActionResult NotGuncelle([FromBody] NotGuncelleRequest request)
        {
            try
            {
                bool sonuc = IS.Seans.NotGuncelle(request.SeansNo, request.SeansNotu);
                return Ok(sonuc);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }

    // --- YARDIMCI SINIFLAR (DTO) ---

    public class RandevuKaydetRequest
    {
        public int SeansNo { get; set; }
        public int HastaNo { get; set; }
    }

    public class NotGuncelleRequest
    {
        public int SeansNo { get; set; }
        public string SeansNotu { get; set; } = string.Empty;
    }
}