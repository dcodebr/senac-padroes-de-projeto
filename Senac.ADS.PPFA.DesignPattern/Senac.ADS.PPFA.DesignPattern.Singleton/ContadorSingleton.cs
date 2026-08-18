namespace Senac.ADS.PPFA.DesignPattern.Singleton
{
    public class ContadorSingleton
    {
        private static ContadorSingleton? instance;
        public int Valor { get; private set; }
        private ContadorSingleton() { }
        public static ContadorSingleton getInstance() {
            if (instance is null) {
                instance = new ContadorSingleton();
            }

            return instance;
        }
        public void Incrementar() {
            Valor++;
        }
    }
}
