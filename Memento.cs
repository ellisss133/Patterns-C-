// Тип: Поведенческий
// Назначение: Сохраняет внутреннее состояние объекта без раскрытия структуры
class Memento { public string State; public Memento(string s) { State = s; } }
class Originator
{
    public string State;
    public Memento Save() => new Memento(State);
    public void Restore(Memento m) => State = m.State;
}
// Метафора: ctrl+z
// Проблемы: утечка памяти, безопасность
