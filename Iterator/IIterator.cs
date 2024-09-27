public interface IIterator<T>
{
    T Current { get; }    // Retorna o item atual
    bool MoveNext();      // Avança para o próximo item
    void Reset();         // Reseta o iterador para o início
}