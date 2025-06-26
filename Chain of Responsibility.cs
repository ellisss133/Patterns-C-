// Тип: Поведенческий
// Назначение: Передача запроса по цепочке обработчиков
abstract class Handler
{
    protected Handler next;
    public void SetNext(Handler h) => next = h;
    public abstract void Handle(string req);
}
class ConcreteHandler : Handler
{
    public override void Handle(string req)
    {
        if (req == "ok") Console.WriteLine("Handled");
        else next?.Handle(req);
    }
}
// Метафора: начальник → зам → стажёр
// Проблемы: не всегда понятно, кто обработает
