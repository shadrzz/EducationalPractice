using EducationalPractice.Models;

namespace EducationalPractice.Utils
{
    public static class DataInitializer
    {
        public static List<Service> GetServices() => new List<Service>
        {
            new Service(336, "Содержание хрома", "8HFJHG443", "12 часов", "0.04", "12000", "1100"),
            new Service(353, "Содержание никеля", "87FDJKHJ", "3 сут", "0.012", "24000", "800"),
            new Service(31, "Содержание ртути", "JUR8R", "10 час", "0.06", "24000", "930"),
            new Service(34, "Содержание хлора", "JKFBJ09", "120 мин", "0.011", "32000", "450")
        };

        public static List<ClientsCorporate> GetCorporateClients() => new List<ClientsCorporate>
        {
            new ClientsCorporate(4, "ЗАО \"Русская косметика\"", "МО, Одинцово, Ворошилова ул, 153", "7927728472", "78123678892", "445334327",
               "Харитонова Ева Адамовна", "16(7185)250-54-23556", "dcoppit@mac.com", "UL1234"),
            new ClientsCorporate(5, "ООО «Коконат»", "МО, Чехов, Минская ул, 128", "7934728472", "78123678842", "445622227",
                        "Орлова Татьяна Мироновна", "33(5855)767-28-30549", "tezbo@mac.com", "UL1235"),
            new ClientsCorporate(6, "Nicole laboratory", "МО, Ногинск, Заводская ул, 34", "7927425472", "78122378892", "493993327",
                           "Дементьев Ярослав Георгиевич", "2(63)151-61-70518", "stecoop@yahoo.com", "UL1236"),
        };

        public static List<ClientsIndividual> GetIndividualClients() => new List<ClientsIndividual>
        {
            new ClientsIndividual("45462526", "Фролов Андрей Иванович", "Серия 1180 Номер 176596", "7/14/2001", "344288, г. Москва, ул. Чехова, 1, кв. 34", "gohufreilagrau-3818@yopmail.com", "cl12345"),
            new ClientsIndividual("45462527", "Николаев Даниил Всеволодович", "Серия 2280 Номер 223523", "2/10/2001", "614164, г. Москва, ул. Степная, 30, кв. 75", "xawugosune-1385@yopmail.com", "cl12346"),
            new ClientsIndividual("45462528", "Снегирев Макар Иванович", "Серия 4560 Номер 354155", "5/21/1998", "394242, г. Москва, ул. Коммунистическая, 43, кв. 57", "satrahuddusei-4458@yopmail.com", "cl12347"),
        };

        public static List<Order> GetOrders() => new List<Order>
        {
            new Order(1, "45462527/44632", "3/12/2022", "45462527", "34, 31, 353, 336", "Новая", null, "ID 104", "78 ч"),
            new Order(2, "45462528/44633", "3/13/2022", "45462528", "98, 45, 89, 99, 123", "На исследовании", null, "ID 105", "16 ч"),
            new Order(3, "45462529/44634", "3/14/2022", "45462529", "92, 45, 57, 88", "На исследовании", null, "ID 106", "28 ч"),
        };

    }
}
