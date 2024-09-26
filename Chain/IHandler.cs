public interface IHandler
{
    void SetNext(IHandler handler);
    void Handle(string request);
    void Escalate(string request);
}