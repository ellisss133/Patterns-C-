// Тип: Архитектурный
// Назначение: Разделение логики, UI и данных
// Model — данные, View — отображение, Controller — управление
class Model { public string Data = "Hello"; }
class View { public void Display(string data) => Console.WriteLine("View: " + data); }
class Controller
{
    private Model model;
    private View view;
    public Controller(Model m, View v) { model = m; view = v; }
    public void UpdateView() => view.Display(model.Data);
}
// Пример использования:
// var model = new Model();
// var view = new View();
// var controller = new Controller(model, view);
// controller.UpdateView();

// Метафора: театр: сценарий (Model), актёры (View), режиссёр (Controller)
// Проблемы: сложно настроить, запутанная коммуникация при росте
