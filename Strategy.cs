// Тип: Поведенческий
// Назначение: Подмена поведения объекта во время выполнения
interface IStrategy { void Act(); }
class Fast : IStrategy { public void Act() => Console.WriteLine("Fast"); }
class Slow : IStrategy { public void Act() => Console.WriteLine("Slow"); }
class Context { public IStrategy Strategy; public void Go() => Strategy.Act(); }
// Метафора: выбор маршрута навигатором
// Проблемы: слишком много классов
