namespace GridLancamento.Models
{
    public class PilotoGrupo
    {
        public string Categoria { get; set; }
        public string Sexo { get; set; }
        public string Tracado { get; set; }
        public List<Piloto> Pilotos { get; set; }

        public string Titulo =>
            $"{Categoria} - {Sexo} - {Tracado}";
    }

}
