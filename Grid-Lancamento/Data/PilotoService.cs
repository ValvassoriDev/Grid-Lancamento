using GridLancamento.Models;
using System.Text.Json;

namespace GridLancamento.Data
{
    public class PilotoService
    {
        private readonly IWebHostEnvironment _env;

        public PilotoService(IWebHostEnvironment env)
        {
            _env = env;
        }

        public async Task<List<Piloto>> ObterPilotosAsync()
        {
            var caminho = Path.Combine(_env.ContentRootPath, "wwwroot", "Mock.json");

            if (!File.Exists(caminho))
                return new List<Piloto>();

            var json = await File.ReadAllTextAsync(caminho);
            return JsonSerializer.Deserialize<List<Piloto>>(json);
        }
    }
}
