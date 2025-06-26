// Тип: Порождающий
// Назначение: Пошаговое создание сложного объекта
class BurgerBuilder
{
    private string result = "";
    public BurgerBuilder AddBun() { result += "Bun "; return this; }
    public BurgerBuilder AddMeat() { result += "Meat "; return this; }
    public string Build() => result;
}
// Метафора: сборка бургера
// Проблемы: усложнение архитектуры при простых объектах
