namespace Observer
{
  public interface ISubject<Temperature>
  {
    void Subscribe(IObserver<Temperature> observer);
    void Unsubscribe(IObserver<Temperature> observer);
  }
}
