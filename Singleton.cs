// Тип: Порождающий
// Назначение: Гарантирует, что у класса есть только один экземпляр
class Singleton
{
    private static Singleton instance;
    private Singleton() {}
    public static Singleton GetInstance()
    {
        if (instance == null)
            instance = new Singleton();
        return instance;
    }
}
// Метафора: электросчетчик в доме — один на всех
// Проблемы: потокобезопасность, тестируемость
