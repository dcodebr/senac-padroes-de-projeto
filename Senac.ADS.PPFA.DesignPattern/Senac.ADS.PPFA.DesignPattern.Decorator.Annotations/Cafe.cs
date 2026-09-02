namespace Senac.ADS.PPFA.DesignPattern.Decorator.Annotations
{
    public class Cafe
    {
        public readonly List<string> ingredientes = new();

        public void Adicionar(string ingrediente)
        {
            ingredientes.Add(ingrediente);
        }

        public string Servir()
        {
            if (ingredientes.Count == 0) {
                return "Café Simples";
            }

            var resultado = "Café com " 
                   + String.Join(", ", ingredientes);

            return resultado;
        }
    }
}
