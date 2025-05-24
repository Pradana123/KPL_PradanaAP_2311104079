using Microsoft.AspNetCore.Mvc;
using TPModul9_2311104079.Models;

namespace TPModul9_2311104079.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>()
        {
            new Mahasiswa { Nama = "Pradana Argo Pangestu", NIM = "2311104079" },
            new Mahasiswa { Nama = "Jauhar Fajar", NIM = "2311104055" },
            new Mahasiswa { Nama = "Rizaldy AUlia", NIM = "2311104056" },

        };

        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> Get()
        {
            return daftarMahasiswa;
        }

        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> Get(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound("Mahasiswa tidak ditemukan");
            return daftarMahasiswa[index];
        }

        [HttpPost]
        public IActionResult Post([FromBody] Mahasiswa mhs)
        {
            daftarMahasiswa.Add(mhs);
            return Ok("Mahasiswa berhasil ditambahkan");
        }

        [HttpDelete("{index}")]
        public IActionResult Delete(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound("Index tidak valid");
            daftarMahasiswa.RemoveAt(index);
            return Ok("Mahasiswa berhasil dihapus");
        }
    }
}