namespace VoeAirlines.Entities;

public class Aeronave{
        public Aeronave(string fabricante, string modelo, string codigo,string celebridade)
        {
            Fabricante = fabricante;
            Modelo = modelo;
            Codigo = codigo;
            Celebridade = celebridade;
        }

        public int Id { get; set; }
        public string Fabricante { get; set; }
        public string Celebridade{get;set;}
        public string Modelo { get; set; }
        public string Codigo { get; set; }

        public ICollection<Manutencao> Manutencoes { get; set; }=null!;
        public ICollection<Voo> Voos { get; set; }=null!;





}

