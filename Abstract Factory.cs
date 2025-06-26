// Тип: Порождающий
// Назначение: Создание семейства связанных объектов без указания классов
interface IButton { }
class WinButton : IButton { }
interface IGUIFactory { IButton CreateButton(); }
class WinFactory : IGUIFactory { public IButton CreateButton() => new WinButton(); }
// Метафора: IKEA — набор мебели из одной серии
// Проблемы: много интерфейсов и классов
