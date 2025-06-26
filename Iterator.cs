// Тип: Поведенческий
// Назначение: Последовательный доступ к элементам без раскрытия структуры
class MyCollection : IEnumerable<int>
{
    int[] data = {1,2,3};
    public IEnumerator<int> GetEnumerator() => ((IEnumerable<int>)data).GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
// Метафора: пульт листает каналы
// Проблемы: сложности с модификацией коллекции во время итерации
