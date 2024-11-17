using EducationalPractice.Models.Client;
using EducationalPractice.Models;

namespace EducationalPractice.Utils
{
    public static class DataInitializer
    {
        public static List<Service> GetServices() => new List<Service>
        {
            new Service(336, "Содержание хрома", "8HFJHG443", "12 часов", "0.04", 12000, 1100),
            new Service(353, "Содержание никеля", "87FDJKHJ", "3 сут", "0.012", 24000, 800),
            new Service(31, "Содержание ртути", "JUR8R", "10 час", "0.06", 24000, 930),
            new Service(34, "Содержание хлора", "JKFBJ09", "120 мин", "0.011", 32000, 450),
            new Service(98, "Проверка концентрации основного компонента", "63748HF", "23 час", "0.012", 23000, 1200),
            new Service(45, "Содержание аллергенов", "JFH7382", "13 час", "1%", 30000, 3000),
            new Service(89, "Однородность состава", "OIJNB12", "1 сут", "1%", 23000, 450),
            new Service(99, "Соответствие состава ГОСТ", "BSFBHV63", "1,5 сут", "5%", 12000, 1000),
            new Service(92, "Соответствие состава ТУ", "HJBUJE21J", "12 часов", "5%", 15000, 1000),
            new Service(44, "Проверка на высоких температурах", "DHBGFY563", "5 час", "1 градус", 100000, 12000),
            new Service(57, "Проверка на высоких температурах", "JHVSJF6", "2 сут", "1 градус", 100000, 12000),
            new Service(88, "Герметичность упаковки", "DJHGBS982", "240 мин", "0.03", 6000, 300),
            new Service(123, "Соответствие срокам годности", "638VVNQ3", "360 мин", "1 мес", 10000, 600)
        };

        public static List<ClientCorporate> GetCorporateClients() => new List<ClientCorporate>
        {
            new ClientCorporate("ЗАО \"Русская косметика\"", "МО, Одинцово, Ворошилова ул, 153", "7927728472", "78123678892", "445334327",
               "Харитонова Ева Адамовна", "Кузнецов Александр Сергеевич", "16(7185)250-54-23556", "dcoppit@mac.com", "UL1234", "hh123"),
            new ClientCorporate("ООО «Коконат»", "МО, Чехов, Минская ул, 128", "7934728472", "78123678842", "445622227",
                        "Орлова Татьяна Мироновна", "Демидов Дмитрий Глебович", "33(5855)767-28-30549", "tezbo@mac.com", "UL1235", "fj23"),
            new ClientCorporate("Nicole laboratory", "МО, Ногинск, Заводская ул, 34", "7927425472", "78122378892", "493993327",
                           "Дементьев Ярослав Георгиевич", "Розанова Камила Максимовна", "2(63)151-61-70518", "stecoop@yahoo.com", "UL1236", "8739"),
        };

        public static List<ClientIndividual> GetIndividualClients() => new List<ClientIndividual>
        {
            new ClientIndividual("Фролов Андрей Иванович", "45462526", "Серия 1180 Номер 176596", "7/14/2001", "344288, г. Москва, ул. Чехова, 1, кв. 34", "gohufreilagrau-3818@yopmail.com", "cl12345"),
            new ClientIndividual("Николаев Даниил Всеволодович", "45462527", "Серия 2280 Номер 223523", "2/10/2001", "614164, г. Москва, ул. Степная, 30, кв. 75", "xawugosune-1385@yopmail.com", "cl12346"),
            new ClientIndividual("Снегирев Макар Иванович", "45462528", "Серия 4560 Номер 354155", "5/21/1998", "394242, г. Москва, ул. Коммунистическая, 43, кв. 57", "satrahuddusei-4458@yopmail.com", "cl12347"),
        };

        public static List<Order> GetOrders() => new List<Order>
        {
            new Order(1, "45462527/44632", "3/12/2022", "45462527", "34, 31, 353, 336", "Новая", null, "ID 104", "78 ч"),
            new Order(2, "45462528/44633", "3/13/2022", "45462528", "98, 45, 89, 99, 123", "На исследовании", null, "ID 105", "16 ч"),
            new Order(3, "45462529/44634", "3/14/2022", "45462529", "92, 45, 57, 88", "На исследовании", null, "ID 106", "28 ч"),
        };

        public static List<Employee> GetEmployees() => new List<Employee>
        {
            new Employee("ID 101", "Менеджер по работе с клиентами", "Иванов Иван Иванович", "Ivanov@namecomp.ru", "2L6KZG", new List<int>(), "15:05:2022 13:13:00"),
            new Employee("ID 102", "Менеджер по работе с клиентами", "Петров Петр Петрович", "petrov@namecomp.ru", "uzWC67", new List<int>(), "15:05:2022 13:13:01"),
            new Employee("ID 103", "Администратор", "Федоров Федор Федорович", "fedorov@namecomp.ru", "8ntwUp", new List<int>(), "15:05:2022 13:13:02"),
            new Employee("ID 104", "Лаборант", "Миронов Вениамин Куприянович", "mironov@namecomp.ru", "YOyhfR", new List<int> {34, 31, 353, 336}, "15:05:2022 13:13:03"),
            new Employee("ID 105", "Лаборант", "Ширяев Ермолай Вениаминович", "shiryev@namecomp.ru", "RSbvHv", new List<int> {98, 45, 89, 99, 123}, "15:05:2022 13:13:04"),
        };
    }
}
