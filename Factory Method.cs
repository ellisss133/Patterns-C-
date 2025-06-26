// Тип: Порождающий
// Назначение: Делегирование создания объекта подклассам
abstract class Creator { public abstract Product FactoryMethod(); }
class ConcreteCreator : Creator { public override Product FactoryMethod() => new Product(); }
class Product {}
// Метафора: фабрика по производству товаров
// Проблемы: множество классов
