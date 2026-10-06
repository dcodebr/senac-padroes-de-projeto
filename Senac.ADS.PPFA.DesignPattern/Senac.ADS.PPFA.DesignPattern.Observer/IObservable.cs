namespace Senac.ADS.PPFA.DesignPattern.Observer
{
    public interface IObservable<TValue>
    {
        void Update(TValue value);
    }
}
