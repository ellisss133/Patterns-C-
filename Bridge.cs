// Тип: Структурный
// Назначение: Разделение абстракции и реализации
interface IRenderer { void Render(string shape); }
class VectorRenderer : IRenderer { public void Render(string s) => Console.WriteLine("Vector " + s); }
class Shape
{
    protected IRenderer renderer;
    public Shape(IRenderer r) { renderer = r; }
    public virtual void Draw() => renderer.Render("Shape");
}
// Метафора: пульт (абстракция) и телевизор (реализация)
// Проблемы: усложнение структуры
