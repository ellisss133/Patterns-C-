// Тип: Порождающий
// Назначение: Создание копий объектов без зависимости от их классов
interface IPrototype { IPrototype Clone(); }
class Sheep : IPrototype
{
    public string Name;
    public IPrototype Clone() => (IPrototype)MemberwiseClone();
}
// Метафора: копировальный аппарат
// Проблемы: неглубокое/глубокое копирование
