using Microsoft.AspNetCore.Mvc;

namespace tp10_1302220144.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController : ControllerBase
    {
        public static List<Mahasiswa> mhs = new List<Mahasiswa>
        {
            new Mahasiswa("Muhammad Fauzan Majid", "1302220144"),
            new Mahasiswa("Muhammad Daffa Fadillah", "1302223124"),
            new Mahasiswa("Arinza Aurelvia", "1302220022"),
            new Mahasiswa("⁠Muhammad Hashfi Hadyan", "1302220079"),
            new Mahasiswa("Soraya Haidar Salma", "1302223006"),
            new Mahasiswa("Maulana Farras", "103022390001")
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mhs;
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa newvalue)
        {
            mhs.Add(newvalue);
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mhs[id];
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mhs.RemoveAt(id);
        }
    }
}
