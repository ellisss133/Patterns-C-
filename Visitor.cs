// Тип: Поведенческий
// Назначение: Добавление операций без изменения классов элементов
interface IElement { void Accept(IVisitor v); }
interface IVisitor { void Visit(ElementA e); }
class ElementA : IElement { public void Accept(IVisitor v) => v.Visit(this); }
class ConcreteVisitor : IVisitor { public void Visit(ElementA e) => Console.WriteLine("Visited A"); }
// Метафора: налоговая проверка всех отделов
// Проблемы: сложно добавлять новые элементы
