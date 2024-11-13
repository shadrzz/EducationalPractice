using EducationalPractice.Forms;
using EducationalPractice.Models;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace EducationalPractice
{
    public partial class OrderFormSand : Form
    {
        private List<Order> orders;
        private List<ClientCorporate> clientsCorporate;
        private List<ClientIndividual> clientsIndividual;
        private List<Service> services;
        private List<Employee> employees;

        public OrderFormSand()
        {
            InitializeComponent();
        }
        private void OrderFormation_Load(object sender, EventArgs e)
        {
            services = new List<Service>
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

            clientsCorporate = new List<ClientCorporate>
            {
                new ClientCorporate("ЗАО \"Русская косметика\"", "МО, Одинцово, Ворошилова ул, 153", "7927728472", "78123678892", "445334327",
               "Харитонова Ева Адамовна", "Кузнецов Александр Сергеевич", "16(7185)250-54-23556", "dcoppit@mac.com", "UL1234", "hh123"),
                new ClientCorporate("ООО «Коконат»", "МО, Чехов, Минская ул, 128", "7934728472", "78123678842", "445622227",
                           "Орлова Татьяна Мироновна", "Демидов Дмитрий Глебович", "33(5855)767-28-30549", "tezbo@mac.com", "UL1235", "fj23"),
                new ClientCorporate("Nicole laboratory", "МО, Ногинск, Заводская ул, 34", "7927425472", "78122378892", "493993327",
                           "Дементьев Ярослав Георгиевич", "Розанова Камила Максимовна", "2(63)151-61-70518", "stecoop@yahoo.com", "UL1236", "8739"),
                new ClientCorporate("ООО «ВДС-Ступино»", "МО, Ступино, Космонавтов ул, 54", "7922424472", "78899678892", "445982837",
                           "Седов Тимур Матвеевич", "Сычева Надежда Артёмовна", "0(601)740-14-66478", "kassiesa@aol.com", "UL1237", "37728"),
                new ClientCorporate("ПК «Парфюм Стиль»", "МО, Королев, Партизана Германа ул, 67", "7955555572", "78123723992", "402000227",
                           "Иванова Анна Александровна", "Пономарева Валерия Ивановна", "31(57)181-23-30334", "bartlett@att.net", "UL1238", "34yy32"),
                new ClientCorporate("ООО «КоролевФарм»", "МО, Королев, ДК Кирова, 28", "7922985472", "70989678892", "408288227",
                           "Молчанова Елизавета Руслановна", "Козловская София Данииловна", "3(2113)599-96-85099", "alias@sbcglobal.net", "UL1239", "873"),
                new ClientCorporate("ГК Коттон Клаб", "МО, Одинцово, 9 Января, 298", "7929388332", "73626626892", "445639927",
                           "Софронов Фёдор Иванович", "Зубкова Василиса Петровна", "73(5598)021-52-52563", "research@sbcglobal.net", "UL1240", "ue378")
            };

            clientsIndividual = new List<ClientIndividual>
            {
                new ClientIndividual("Фролов Андрей Иванович", "45462526", "Серия 1180 Номер 176596", "7/14/2001", "344288, г. Москва, ул. Чехова, 1, кв. 34", "gohufreilagrau-3818@yopmail.com", "cl12345"),
                new ClientIndividual("Николаев Даниил Всеволодович", "45462527", "Серия 2280 Номер 223523", "2/10/2001", "614164, г. Москва, ул. Степная, 30, кв. 75", "xawugosune-1385@yopmail.com", "cl12346"),
                new ClientIndividual("Снегирев Макар Иванович", "45462528", "Серия 4560 Номер 354155", "5/21/1998", "394242, г. Москва, ул. Коммунистическая, 43, кв. 57", "satrahuddusei-4458@yopmail.com", "cl12347"),
                new ClientIndividual("Иванов Иван Ильич", "45462529", "Серия 9120 Номер 554296", "10/1/1998", "660540, г. Москва, ул. Солнечная, 25, кв. 78", "boippaxeufrepra-7093@yopmail.com", "cl12348"),
                new ClientIndividual("Филиппова Анна Глебовна", "45462530", "Серия 2367 Номер 558134", "5/31/1976", "125837, г. Москва, ул. Шоссейная, 40, кв. 92", "zapramaxesu-7741@yopmail.com", "cl12349"),
                new ClientIndividual("Иванов Михаил Владимирович", "45462531", "Серия 7101 Номер 669343", "11/4/1985", "125703, г. Москва, ул. Партизанская, 49, кв. 84", "rouzecroummegre-3899@yopmail.com", "cl12350"),
                new ClientIndividual("Власов Дмитрий Александрович", "45462532", "Серия 3455 Номер 719630", "8/17/1998", "625283, г. Москва, ул. Победы, 46, кв. 7", "ziyeuddocrabri-4748@yopmail.com", "cl12351"),
                new ClientIndividual("Серова Екатерина Львовна", "45462533", "Серия 2377 Номер 871623", "10/24/1984", "614611, г. Москва, ул. Молодежная, 50, кв. 78", "ketameissoinnei-1951@yopmail.com", "cl12352"),
                new ClientIndividual("Борисова Ирина Ивановна", "45462534", "Серия 8755 Номер 921148", "10/14/1976", "454311, г. Москва, ул. Новая, 19, кв. 78", "yipraubaponou-5849@yopmail.com", "cl12353"),
                new ClientIndividual("Зайцев Никита Артёмович", "45462535", "Серия 4355 Номер 104594", "10/14/1999", "660007, г. Москва, ул. Октябрьская, 19, кв. 42", "crapedocouca-3572@yopmail.com", "cl12354"),
                new ClientIndividual("Медведев Святослав Евгеньевич", "45462536", "Серия 2791 Номер 114390", "7/13/1985", "603036, г. Москва, ул. Садовая, 4, кв. 13", "ceigoixakaunni-9227@yopmail.com", "cl12355"),
                new ClientIndividual("Коротков Кирилл Алексеевич", "45462537", "Серия 5582 Номер 126286", "5/26/1976", "450983, г. Москва, ул. Комсомольская, 26, кв. 60", "yeimmeiwauzomo-7054@yopmail.com", "cl12356"),
                new ClientIndividual("Калашникова Арина Максимовна", "45462538", "Серия 2978 Номер 133653", "8/13/1999", "394782, г. Москва, ул. Чехова, 3, кв. 14", "poleifenevi-1560@yopmail.com", "cl12357"),
                new ClientIndividual("Минина Таисия Кирилловна", "45462539", "Серия 7512 Номер 141956", "10/13/1985", "603002, г. Москва, ул. Дзержинского, 28, кв. 56", "kauprezofautei-6607@yopmail.com", "cl12358"),
                new ClientIndividual("Наумов Серафим Романович", "45462540", "Серия 5046 Номер 158433", "4/15/1999", "450558, г. Москва, ул. Набережная, 30, кв. 71", "quaffaullelourei-1667@yopmail.com", "cl12359"),
                new ClientIndividual("Воробьева Василиса Евгеньевна", "45462541", "Серия 2460 Номер 169505", "1/13/1999", "394060, г. Москва, ул. Фрунзе, 43, кв. 79", "jsteele@rojas-robinson.net", "cl12360"),
                new ClientIndividual("Калинин Александр Андреевич", "45462542", "Серия 3412 Номер 174593", "1/7/1999", "410661, г. Москва, ул. Школьная, 50, кв. 53", "vhopkins@lewis-mullen.com", "cl12361"),
                new ClientIndividual("Кузнецова Милана Владиславовна", "45462543", "Серия 4950 Номер 183034", "1/24/1999", "625590, г. Москва, ул. Коммунистическая, 20, кв. 34", "nlewis@yahoo.com", "cl12362"),
                new ClientIndividual("Фирсов Егор Романович", "45462544", "Серия 5829 Номер 219464", "9/2/1993", "625683, г. Москва, ул. 8 Марта, 20, кв. 21", "garciadavid@mckinney-mcbride.com", "cl12363"),
                new ClientIndividual("Зимина Агния Александровна", "45462545", "Серия 6443 Номер 208059", "9/3/1998", "400562, г. Москва, ул. Зеленая, 32, кв. 67", "cbradley@castro.com", "cl12364"),
                new ClientIndividual("Титов Андрей Глебович", "45462546", "Серия 7079 Номер 213265", "10/23/1985", "614510, г. Москва, ул. Маяковского, 47, кв. 72", "cuevascatherine@carlson.biz", "cl12365"),
                new ClientIndividual("Орлов Николай Егорович", "45462547", "Серия 8207 Номер 522702", "7/27/1985", "410542, г. Москва, ул. Светлая, 46, кв. 82", "thomasmoore@wilson-singh.net", "cl12366"),
                new ClientIndividual("Кузнецова Аиша Михайловна", "45462548", "Серия 9307 Номер 232158", "10/4/1998", "620839, г. Москва, ул. Цветочная, 8, кв. 100", "jessica84@hotmail.com", "cl12367"),
                new ClientIndividual("Куликов Никита Георгиевич", "45462549", "Серия 1357 Номер 242839", "4/23/1999", "443890, г. Москва, ул. Коммунистическая, 1, кв. 10", "jessicapark@hotmail.com", "cl12368"),
                new ClientIndividual("Карпова София Егоровна", "45462550", "Серия 1167 Номер 256636", "10/1/1993", "603379, г. Москва, ул. Спортивная, 46, кв. 95", "ginaritter@schneider-buchanan.com", "cl12369"),
                new ClientIndividual("Смирнова Дарья Макаровна", "45462551", "Серия 1768 Номер 266986", "3/22/1976", "603721, г. Москва, ул. Гоголя, 41, кв. 57", "stephen99@yahoo.com", "cl12370"),
                new ClientIndividual("Абрамова Александра Мироновна", "45462552", "Серия 1710 Номер 427875", "3/26/1999", "410172, г. Москва, ул. Северная, 13, кв. 86", "lopezlisa@hotmail.com", "cl12371"),
                new ClientIndividual("Наумов Руслан Михайлович", "45462553", "Серия 1806 Номер 289145", "10/11/1999", "420151, г. Москва, ул. Вишневая, 32, кв. 81", "lori17@hotmail.com", "cl12372"),
                new ClientIndividual("Бочаров Никита Матвеевич", "45462554", "Серия 1587 Номер 291249", "6/29/1997", "125061, г. Москва, ул. Подгорная, 8, кв. 74", "campbellkevin@gardner.com", "cl12373"),
                new ClientIndividual("Соловьев Давид Ильич", "45462555", "Серия 1647 Номер 306372", "3/6/1984", "630370, г. Москва, ул. Шоссейная, 24, кв. 81", "morganhoward@clark.com", "cl12374"),
                new ClientIndividual("Васильева Валерия Дмитриевна", "45462556", "Серия 1742 Номер 316556", "9/30/1999", "614753, г. Москва, ул. Полевая, 35, кв. 39", "carsontamara@gmail.com", "cl12375"),
                new ClientIndividual("Макарова Василиса Андреевна", "45462557", "Серия 1474 Номер 326347", "4/8/1999", "426030, г. Москва, ул. Маяковского, 44, кв. 93", "kevinpatel@gmail.com", "cl12376"),
                new ClientIndividual("Алексеев Матвей Викторович", "45462558", "Серия 1452 Номер 339539", "8/2/1998", "450375, г. Москва, ул. Клубная, 44, кв. 80", "sethbishop@yahoo.com", "cl12377"),
                new ClientIndividual("Никитина Полина Александровна", "45462559", "Серия 2077 Номер 443480", "9/19/1976", "625560, г. Москва, ул. Некрасова, 12, кв. 66", "drollins@schultz-soto.net", "cl12378"),
                new ClientIndividual("Окулова Олеся Алексеевна", "45462560", "Серия 2147 Номер 357518", "4/3/1999", "630201, г. Москва, ул. Комсомольская, 17, кв. 25", "pblack@copeland-winters.org", "cl12379"),
                new ClientIndividual("Захарова Полина Яновна", "45462561", "Серия 2687 Номер 363884", "4/21/1976", "190949, г. Москва, ул. Мичурина, 26, кв. 93", "johnathon.oberbrunner@yahoo.com", "cl12380"),
                new ClientIndividual("Зайцев Владимир Давидович", "45462562", "Серия 2376 Номер 443711", "1/26/1998", "350501, г. Москва, ул. Парковая, 2, кв. 7", "bradly29@gmail.com", "cl12381"),
                new ClientIndividual("Иванов Виталий Даниилович", "45462563", "Серия 2568 Номер 386237", "8/11/1976", "450048, г. Москва, ул. Коммунистическая, 21, кв. 3", "stark.cristina@hilpert.biz", "cl12382"),
                new ClientIndividual("Захаров Матвей Романович", "45462564", "Серия 2556 Номер 439376", "7/12/1993", "644921, г. Москва, ул. Школьная, 46, кв. 37", "bruen.eleanore@yahoo.com", "cl12383"),
                new ClientIndividual("Иванов Степан Степанович", "45462565", "Серия 2737 Номер 407501", "9/19/1998", "614228, г. Москва, ул. Дорожная, 36, кв. 54", "percival.halvorson@yahoo.com", "cl12384"),
                new ClientIndividual("Ткачева Милана Тимуровна", "45462566", "Серия 2581 Номер 441645", "5/24/1998", "350940, г. Москва, ул. Первомайская, 23, кв. 2", "javonte71@kuhlman.biz", "cl12385"),
                new ClientIndividual("Семенов Даниил Иванович", "45462567", "Серия 2675 Номер 427933", "1/4/1976", "344990, г. Москва, ул. Красноармейская, 19, кв. 92", "vconnelly@kautzer.com", "cl12386"),
                new ClientIndividual("Виноградов Вячеслав Дмитриевич", "45462568", "Серия 2967 Номер 434531", "7/12/1976", "410248, г. Москва, ул. Чкалова, 11, кв. 75", "anabelle07@schultz.info", "cl12387"),
                new ClientIndividual("Соболева Николь Фёдоровна", "45462569", "Серия 3070 Номер 449655", "5/2/1976", "400839, г. Москва, ул. 8 Марта, 46, кв. 44", "nitzsche.katlynn@yahoo.com", "cl12388"),
                new ClientIndividual("Тихонова Анна Львовна", "45462570", "Серия 3108 Номер 451174", "3/23/1985", "450539, г. Москва, ул. Заводская, 3, кв. 81", "corine16@von.com", "cl12389"),
                new ClientIndividual("Кузнецова Ульяна Савельевна", "45462571", "Серия 3250 Номер 464705", "6/3/1999", "614591, г. Москва, ул. Цветочная, 20, кв. 40", "otha.wisozk@lubowitz.org", "cl12390"),
                new ClientIndividual("Смирнова Анна Германовна", "45462572", "Серия 3392 Номер 471644", "7/18/1997", "400260, г. Москва, ул. Больничная, 30, кв. 53", "may.kirlin@hotmail.com", "cl12391"),
                new ClientIndividual("Черепанова Анна Давидовна", "45462573", "Серия 3497 Номер 487819", "11/6/1985", "660924, г. Москва, ул. Молодежная, 32, кв. 59", "bryana.kautzer@yahoo.com", "cl12392"),
                new ClientIndividual("Григорьев Максим Кириллович", "45462574", "Серия 3560 Номер 491260", "5/26/1999", "644133, г. Москва, ул. Гагарина, 28, кв. 69", "deborah.christiansen@quigley.biz", "cl12393"),
                new ClientIndividual("Голубев Даниэль Александрович", "45462575", "Серия 3620 Номер 506034", "6/14/1999", "450698, г. Москва, ул. Вокзальная, 14, кв. 37", "connelly.makayla@yahoo.com", "cl12394"),
                new ClientIndividual("Миронов Юрий Денисович", "45462576", "Серия 3774 Номер 511438", "1/26/1985", "620653, г. Москва, ул. Западная, 15, кв. 25", "tatum.collins@fay.org", "cl12395"),
                new ClientIndividual("Терехов Михаил Андреевич", "45462577", "Серия 3862 Номер 521377", "7/6/1976", "644321, г. Москва, ул. Клубная, 32, кв. 10", "itzel73@anderson.com", "cl12396"),
                new ClientIndividual("Орлова Алиса Михайловна", "45462578", "Серия 3084 Номер 535966", "2/24/1997", "603653, г. Москва, ул. Молодежная, 2, кв. 45", "arjun39@hotmail.com", "cl12397"),
                new ClientIndividual("Кулаков Константин Даниилович", "45462579", "Серия 4021 Номер 541528", "6/20/1993", "410181, г. Москва, ул. Механизаторов, 16, кв. 74", "ohara.rebeka@yahoo.com", "cl12398"),
                new ClientIndividual("Кудрявцев Максим Романович", "45462580", "Серия 4109 Номер 554053", "5/10/1998", "394207, г. Москва, ул. Свердлова, 31, кв. 28", "danika58@rath.com", "cl12399"),
                new ClientIndividual("Соболева Кира Фёдоровна", "45462581", "Серия 4537 Номер 564868", "3/14/1998", "420633, г. Москва, ул. Матросова, 18, кв. 41", "janae.bogan@gmail.com", "cl12400"),
                new ClientIndividual("Коновалов Арсений Максимович", "45462582", "Серия 4914 Номер 572471", "2/18/1985", "445720, г. Москва, ул. Матросова, 50, кв. 67", "vern91@yahoo.com", "cl12401"),
                new ClientIndividual("Гусев Михаил Дмитриевич", "45462583", "Серия 4445 Номер 581302", "11/23/1999", "400646, г. Москва, ул. Октябрьская, 47, кв. 65", "mariana.leannon@larkin.net", "cl12402"),
                new ClientIndividual("Суханова Варвара Матвеевна", "45462584", "Серия 4743 Номер 598180", "9/13/1993", "644410, г. Москва, ул. Красная, 17, кв. 69", "vmoore@gmail.com", "cl12403"),
                new ClientIndividual("Орлова Ясмина Васильевна", "45462585", "Серия 4741 Номер 601821", "6/24/1984", "400750, г. Москва, ул. Школьная, 36, кв. 71", "damon.mcclure@mills.com", "cl12404"),
                new ClientIndividual("Васильева Ксения Константиновна", "45462586", "Серия 4783 Номер 612567", "8/1/1999", "660590, г. Москва, ул. Дачная, 37, кв. 70", "grady.reilly@block.com", "cl12405"),
                new ClientIndividual("Борисова Тамара Данииловна", "45462587", "Серия 4658 Номер 621200", "5/29/1993", "426083, г. Москва, ул. Механизаторов, 41, кв. 26", "boyd.koss@yahoo.com", "cl12406"),
                new ClientIndividual("Дмитриев Мирон Ильич", "45462588", "Серия 4908 Номер 634613", "4/13/1985", "410569, г. Москва, ул. Парковая, 36, кв. 17", "obartell@franecki.info", "cl12407"),
                new ClientIndividual("Лебедева Анна Александровна", "45462589", "Серия 5092 Номер 642468", "3/30/1985", "443375, г. Москва, ул. Дзержинского, 50, кв. 95", "reina75@ferry.net", "cl12408"),
                new ClientIndividual("Пономарев Артём Маркович", "45462590", "Серия 5155 Номер 465274", "6/2/1984", "614316, г. Москва, ул. Первомайская, 48, кв. 31", "karson28@hotmail.com", "cl12409"),
                new ClientIndividual("Борисова Елена Михайловна", "45462591", "Серия 5086 Номер 666893", "5/23/1976", "445685, г. Москва, ул. Зеленая, 7, кв. 47", "damaris61@okon.com", "cl12410"),
                new ClientIndividual("Моисеев Камиль Максимович", "45462592", "Серия 5333 Номер 675375", "6/17/1999", "614505, г. Москва, ул. Нагорная, 37, кв. 31", "carroll.jerod@hotmail.com", "cl12411"),
                new ClientIndividual("Герасимова Дарья Константиновна", "45462593", "Серия 5493 Номер 684572", "10/13/1984", "426629, г. Москва, ул. Весенняя, 32, кв. 46", "ron.treutel@quitzon.com", "cl12412"),
                new ClientIndividual("Михайлова Мария Марковна", "45462594", "Серия 5150 Номер 696226", "12/2/1976", "603743, г. Москва, ул. Матросова, 19, кв. 20", "olen79@yahoo.com", "cl12413"),
                new ClientIndividual("Коршунов Кирилл Максимович", "45462595", "Серия 1308 Номер 703305", "5/22/1985", "450750, г. Москва, ул. Клубная, 23, кв. 90", "pacocha.robbie@yahoo.com", "cl12414")
            };

            orders = new List<Order>
            {
                new Order(1, "45462527/44632", "3/12/2022", "45462527", new List<int> { 34, 31, 353, 336 }, "Новая", null, "ID 104", "78 ч"),
                new Order(2, "45462528/44633", "3/13/2022", "45462528", new List<int> { 98, 45, 89, 99, 123 }, "На исследовании", null, "ID 105", "16 ч"),
                new Order(3, "45462529/44634", "3/14/2022", "45462529", new List<int> { 92, 45, 57, 88 }, "На исследовании", null, "ID 106", "28 ч"),
                new Order(4, "45462530/44635", "3/15/2022", "45462530", new List<int> { 92, 45, 57, 88, 44 }, "Новая", null, "ID 109", "1200 минут"),
                new Order(5, "45462531/44636", "3/16/2022", "45462531", new List<int> { 98, 45, 89, 353, 336, 34 }, "Закрыта", "4/16/2022", "ID 110", "3 суток"),
                new Order(6, "45462532/44637", "3/17/2022", "45462532", new List<int> { 34, 31, 353, 337 }, "Новая", null, "ID 104", "480 минут"),
                new Order(7, "45462533/44638", "3/18/2022", "45462533", new List<int> { 98, 45, 89, 99, 124 }, "Новая", null, "ID 105", "2 суток"),
                new Order(8, "45462534/44639", "3/19/2022", "45462534", new List<int> { 92, 45, 57, 89 }, "На исследовании", null, "ID 106", "48 часов"),
                new Order(9, "hh123/44640", "3/20/2022", "hh123", new List<int> { 92, 45, 57, 88, 45 }, "На исследовании", null, "ID 109", "78 ч"),
                new Order(10, "fj23/44641", "3/21/2022", "fj23", new List<int> { 98, 45, 89, 353, 336, 35 }, "Новая", null, "ID 110", "16 ч"),
                new Order(11, "8739/44642", "3/22/2022", "8739", new List<int> { 34, 31, 353, 338 }, "Закрыта", "4/22/2022", "ID 104", "78 ч"),
                new Order(12, "37728/44643", "3/23/2022", "37728", new List<int> { 98, 45, 89, 99, 125 }, "На исследовании", null, "ID 105", "160 ч"),
                new Order(13, "34yy32/44644", "3/24/2022", "34yy32", new List<int> { 92, 45, 57, 90 }, "На исследовании", null, "ID 106", "28 ч"),
                new Order(14, "873/44645", "3/25/2022", "873", new List<int> { 92, 45, 57, 88, 46 }, "На исследовании", null, "ID 109", "1200 минут"),
                new Order(15, "ue378/44646", "3/26/2022", "ue378", new List<int> { 98, 45, 89, 353, 336, 36 }, "Закрыта", "4/26/2022", "ID 110", "3 суток"),
                new Order(16, "45462542/44647", "3/27/2022", "45462542", new List<int> { 34, 31, 353, 339 }, "Новая", null, "ID 104", "480 минут"),
                new Order(17, "45462543/44648", "3/28/2022", "45462543", new List<int> { 98, 45, 89, 99, 126 }, "На исследовании", null, "ID 105", "2 суток"),
                new Order(18, "45462531/44649", "3/29/2022", "45462531", new List<int> { 92, 45, 57, 91 }, "На исследовании", null, "ID 106", "48 часов"),
                new Order(19, "45462532/44650", "3/30/2022", "45462532", new List<int> { 92, 45, 57, 88, 47 }, "Новая", null, "ID 109", "78 ч"),
                new Order(20, "45462533/44651", "3/31/2022", "45462533", new List<int> { 98, 45, 89, 353, 336, 37 }, "Новая", null, "ID 110", "16 ч"),
                new Order(21, "45462534/44652", "4/1/2022", "45462534", new List<int> { 34, 31, 353, 340 }, "Закрыта", "5/2/2022", "ID 104", "78 ч"),
                new Order(22, "45462535/44653", "4/2/2022", "45462535", new List<int> { 98, 45, 89, 99, 127 }, "Новая", null, "ID 105", "16 ч"),
                new Order(23, "hh123/44654", "4/3/2022", "hh123", new List<int> { 92, 45, 57, 92 }, "Новая", null, "ID 106", "28 ч"),
                new Order(24, "fj23/44655", "4/4/2022", "fj23", new List<int> { 92, 45, 57, 88, 48 }, "На исследовании", null, "ID 109", "1200 минут"),
                new Order(25, "8739/44656", "4/5/2022", "8739", new List<int> { 98, 45, 89, 353, 336, 38 }, "На исследовании", null, "ID 110", "3 суток"),
                new Order(26, "37728/44657", "4/6/2022", "37728", new List<int> { 34, 31, 353, 341 }, "На исследовании", null, "ID 104", "480 минут"),
                new Order(27, "34yy32/44658", "4/7/2022", "34yy32", new List<int> { 98, 45, 89, 99, 128 }, "На исследовании", null, "ID 105", "2 суток"),
                new Order(28, "873/44659", "4/8/2022", "873", new List<int> { 92, 45, 57, 93 }, "Закрыта", "5/9/2022", "ID 106", "48 часов"),
                new Order(29, "ue378/44660", "4/9/2022", "ue378", new List<int> { 92, 45, 57, 88, 49 }, "Новая", null, "ID 109", "78 ч"),
                new Order(30, "45462556/44661", "4/10/2022", "45462556", new List<int> { 98, 45, 89, 353, 336, 39 }, "На исследовании", null, "ID 110", "16 ч"),
                new Order(31, "45462557/44662", "4/11/2022", "45462557", new List<int> { 34, 31, 353, 342 }, "На исследовании", null, "ID 104", "78 ч"),
                new Order(32, "45462558/44663", "4/12/2022", "45462558", new List<int> { 98, 45, 89, 99, 129 }, "Новая", null, "ID 105", "16 ч"),
                new Order(33, "45462559/44664", "4/13/2022", "45462559", new List<int> { 92, 45, 57, 94 }, "Новая", null, "ID 106", "28 ч"),
                new Order(34, "45462579/44665", "4/14/2022", "45462579", new List<int> { 92, 45, 57, 88, 50 }, "Новая", null, "ID 109", "1200 минут"),
                new Order(35, "45462580/44666", "4/15/2022", "45462580", new List<int> { 98, 45, 89, 353, 336, 40 }, "На исследовании", null, "ID 110", "3 суток"),
                new Order(36, "45462581/44667", "4/16/2022", "45462581", new List<int> { 34, 31, 353, 343 }, "На исследовании", null, "ID 104", "480 минут"),
                new Order(37, "45462582/44668", "4/17/2022", "45462582", new List<int> { 98, 45, 89, 99, 130 }, "На исследовании", null, "ID 105", "2 суток"),
                new Order(38, "hh123/44669", "4/18/2022", "hh123", new List<int> { 92, 45, 57, 95 }, "Закрыта", "5/19/2022", "ID 106", "48 часов"),
                new Order(39, "fj23/44670", "4/19/2022", "fj23", new List<int> { 92, 45, 57, 88, 51 }, "На исследовании", null, "ID 109", "78 ч"),
                new Order(40, "8739/44671", "4/20/2022", "8739", new List<int> { 98, 45, 89, 353, 336, 41 }, "Новая", null, "ID 110", "16 ч"),
                new Order(41, "37728/44672", "4/21/2022", "37728", new List<int> { 34, 31, 353, 344 }, "Закрыта", "5/22/2022", "ID 104", "78 ч"),
                new Order(42, "34yy32/44673", "4/22/2022", "34yy32", new List<int> { 98, 45, 89, 99, 131 }, "На исследовании", null, "ID 105", "16 ч"),
                new Order(43, "873/44674", "4/23/2022", "873", new List<int> { 92, 45, 57, 96 }, "На исследовании", null, "ID 106", "28 ч"),
                new Order(44, "ue378/44675", "4/24/2022", "ue378", new List<int> { 92, 45, 57, 88, 52 }, "На исследовании", null, "ID 109", "1200 минут"),
                new Order(45, "45462534/44676", "4/25/2022", "45462534", new List<int> { 98, 45, 89, 353, 336, 42 }, "На исследовании", null, "ID 110", "3 суток"),
                new Order(46, "45462535/44677", "4/26/2022", "45462535", new List<int> { 34, 31, 353, 345 }, "На исследовании", null, "ID 104", "480 минут"),
                new Order(47, "45462536/44678", "4/27/2022", "45462536", new List<int> { 98, 45, 89, 99, 132 }, "Закрыта", "5/28/2022", "ID 105", "2 суток"),
                new Order(48, "45462537/44679", "4/28/2022", "45462537", new List<int> { 92, 45, 57, 97 }, "Новая", null, "ID 106", "48 часов"),
                new Order(49, "45462575/44680", "4/29/2022", "45462575", new List<int> { 92, 45, 57, 88, 53 }, "Новая", null, "ID 109", "78 ч"),
                new Order(50, "45462576/44681", "4/30/2022", "45462576", new List<int> { 98, 45, 89, 353, 336, 43 }, "Новая", null, "ID 110", "16 ч")
            };

            employees = new List<Employee>
            {
                new Employee("ID 101", "Менеджер по работе с клиентами", "Иванов Иван Иванович", "Ivanov@namecomp.ru", "2L6KZG", new List<int>(), "15:05:2022 13:13:00"),
                new Employee("ID 102", "Менеджер по работе с клиентами", "Петров Петр Петрович", "petrov@namecomp.ru", "uzWC67", new List<int>(), "15:05:2022 13:13:01"),
                new Employee("ID 103", "Администратор", "Федоров Федор Федорович", "fedorov@namecomp.ru", "8ntwUp", new List<int>(), "15:05:2022 13:13:02"),
                new Employee("ID 104", "Лаборант", "Миронов Вениамин Куприянович", "mironov@namecomp.ru", "YOyhfR", new List<int> {34, 31, 353, 336}, "15:05:2022 13:13:03"),
                new Employee("ID 105", "Лаборант", "Ширяев Ермолай Вениаминович", "shiryev@namecomp.ru", "RSbvHv", new List<int> {98, 45, 89, 99, 123}, "15:05:2022 13:13:04"),
                new Employee("ID 106", "Лаборант", "Игнатов Кассиан Васильевич", "ignatov@namecomp.ru", "rwVDh9", new List<int> {92, 45, 57, 88}, "15:05:2022 13:13:05"),
                new Employee("ID 107", "Начальник ОТК", "Хохлов Владимир Мэлсович", "hohlov@namecomp.ru", "LdNyos", new List<int>(), "15:05:2022 13:13:06"),
                new Employee("ID 108", "Администратор", "Стрелков Мстислав Георгьевич", "strelkov@namecomp.ru", "gynQMT", new List<int>(), "15:05:2022 13:13:07"),
                new Employee("ID 109", "Контролер ОТК", "Беляева Лилия Наумовна", "belyeva@@namecomp.ru", "AtnDjr", new List<int> {92, 45, 57, 88, 44}, "15:05:2022 13:13:08"),
                new Employee("ID 110", "Контролер ОТК", "Смирнова Ульяна Гордеевна", "smirnova@@namecomp.ru", "JlFRCZ", new List<int> {98, 45, 89, 353, 336, 34}, "15:05:2022 13:13:09")
            };

            // Установка подсказки для номера заказа
            idLaboratoryVesselTextBox.Text = GetNextOrderNumber();

            // Обработчик нажатия Enter
            idLaboratoryVesselTextBox.KeyPress += IdLaboratoryVesselTextBox_KeyPress;


            string[] customerItems = { "ЮЛ", "ФЛ" };
            customerChoiceComboBox.Items.AddRange(customerItems);
            customerChoiceComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (var service in services)
            {
                servicesCheckedListBox.Items.Add(service.Name);
            }
        }
        private string GetNextOrderNumber()
        {
            // Находим последний номер заказа, исключая заказы в архиве (например, с статусом "Закрыта")
            var lastOrderNumber = orders
                .Select(order => ParseOrderNumber(order.OrderNumber))
                .Max();

            // Возвращаем следующий номер
            return (lastOrderNumber + 1).ToString();
        }

        private int ParseOrderNumber(string orderNumber)
        {
            // Извлекаем числовую часть из номера заказа
            int numericPart;
            if (int.TryParse(orderNumber.Split('/')[0], out numericPart))
                return numericPart;
            return 0;
        }

        private void IdLaboratoryVesselTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string enteredVesselNumber = idLaboratoryVesselTextBox.Text;

                // Проверяем уникальность номера
                if (IsUniqueVesselNumber(enteredVesselNumber))
                {
                    MessageBox.Show("Номер сосуда подтвержден: " + enteredVesselNumber);
                }
                else
                {
                    MessageBox.Show("Этот номер уже существует. Пожалуйста, введите уникальный номер.");
                }
            }
        }

        private bool IsUniqueVesselNumber(string vesselNumber)
        {
            return !orders.Any(order => order.OrderNumber.Split('/')[0] == vesselNumber);
        }

        private void customerChoiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customerChoiceComboBox.SelectedItem != null)
            {
                bool isLegalEntity = customerChoiceComboBox.SelectedItem.ToString() == "ЮЛ";

                companyNameLabel.Visible = isLegalEntity;
                companyNameTextBox.Visible = isLegalEntity;

                fullNameLabel.Visible = !isLegalEntity;
                fullNameTextBox.Visible = !isLegalEntity;
            }
            servicesLabel.Visible = true;
            servicesCheckedListBox.Visible = true;
            costLabel.Visible = true;
            costValue.Visible = true;
        }

        private void fullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string fullName = fullNameTextBox.Text.Trim();

            // Проверка наличия клиента по ФИО
            if (!string.IsNullOrEmpty(fullName) && !clientsIndividual.Any(c => c.FullName == fullName))
            {
                // Добавление нового клиента
                ClientIndividual newClient = new ClientIndividual(
                    fullName,
                    "новый код клиента",
                    "новые паспортные данные",
                    "дата рождения",
                    "адрес",
                    "email@example.com",
                    "пароль"
                );

                clientsIndividual.Add(newClient);
                MessageBox.Show($"Клиент {newClient.FullName} добавлен.");
            }
            else
            {
                MessageBox.Show("Клиент с таким ФИО уже существует или поле ФИО пустое.");
            }
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            string customerChoiceValue = customerChoiceComboBox.SelectedItem.ToString();
            if (customerChoiceValue == "ЮЛ")
            {
                ClientCorporateForm newForm = new ClientCorporateForm();
                newForm.Show();
            }
            else if (customerChoiceValue == "ФЛ")
            {
                ClientIndividualForm newForm = new ClientIndividualForm(clientsIndividual);
                newForm.Show();
            }
        }

        private void servicesCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Get the item that is being checked or unchecked
            string item = servicesCheckedListBox.Items[e.Index].ToString();

            // Get the service associated with the checked item
            Service selectedService = services.FirstOrDefault(s => s.Name == item);

            if (selectedService != null)
            {
                // Получаем текущую стоимость
                decimal currentTotalCost = 0;
                if (decimal.TryParse(costValue.Text.Replace(" руб.", ""), out decimal parsedCost))
                {
                    currentTotalCost = parsedCost;
                }

                // Корректируем общую стоимость в зависимости от состояния NewValue
                if (e.NewValue == CheckState.Checked)
                {
                    // Если элемент отмечен, добавляем его стоимость
                    currentTotalCost += selectedService.Cost;
                }
                else if (e.NewValue == CheckState.Unchecked)
                {
                    // Если элемент снимается, вычитаем его стоимость
                    currentTotalCost -= selectedService.Cost;
                }

                // Обновляем отображение стоимости, добавляя " руб."
                costValue.Text = $"{currentTotalCost} руб.";
            }
        }
    }
}

