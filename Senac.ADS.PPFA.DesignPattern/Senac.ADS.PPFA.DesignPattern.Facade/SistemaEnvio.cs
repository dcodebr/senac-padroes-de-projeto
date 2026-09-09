namespace Senac.ADS.PPFA.DesignPattern.Facade
{
    public class SistemaEnvio
    {
        public static int id = 0;
        public string EnviarPedido(string item) {
            id++;
            var idEnvio = $"Envio #{id}";

            return idEnvio;
            
        }
    }
}
