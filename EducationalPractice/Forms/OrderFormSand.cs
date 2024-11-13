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
                new Service(336, "���������� �����", "8HFJHG443", "12 �����", "0.04", 12000, 1100),
                new Service(353, "���������� ������", "87FDJKHJ", "3 ���", "0.012", 24000, 800),
                new Service(31, "���������� �����", "JUR8R", "10 ���", "0.06", 24000, 930),
                new Service(34, "���������� �����", "JKFBJ09", "120 ���", "0.011", 32000, 450),
                new Service(98, "�������� ������������ ��������� ����������", "63748HF", "23 ���", "0.012", 23000, 1200),
                new Service(45, "���������� ����������", "JFH7382", "13 ���", "1%", 30000, 3000),
                new Service(89, "������������ �������", "OIJNB12", "1 ���", "1%", 23000, 450),
                new Service(99, "������������ ������� ����", "BSFBHV63", "1,5 ���", "5%", 12000, 1000),
                new Service(92, "������������ ������� ��", "HJBUJE21J", "12 �����", "5%", 15000, 1000),
                new Service(44, "�������� �� ������� ������������", "DHBGFY563", "5 ���", "1 ������", 100000, 12000),
                new Service(57, "�������� �� ������� ������������", "JHVSJF6", "2 ���", "1 ������", 100000, 12000),
                new Service(88, "������������� ��������", "DJHGBS982", "240 ���", "0.03", 6000, 300),
                new Service(123, "������������ ������ ��������", "638VVNQ3", "360 ���", "1 ���", 10000, 600)
            };

            clientsCorporate = new List<ClientCorporate>
            {
                new ClientCorporate("��� \"������� ���������\"", "��, ��������, ���������� ��, 153", "7927728472", "78123678892", "445334327",
               "���������� ��� ��������", "�������� ��������� ���������", "16(7185)250-54-23556", "dcoppit@mac.com", "UL1234", "hh123"),
                new ClientCorporate("��� ��������", "��, �����, ������� ��, 128", "7934728472", "78123678842", "445622227",
                           "������ ������� ���������", "������� ������� ��������", "33(5855)767-28-30549", "tezbo@mac.com", "UL1235", "fj23"),
                new ClientCorporate("Nicole laboratory", "��, �������, ��������� ��, 34", "7927425472", "78122378892", "493993327",
                           "��������� ������� ����������", "�������� ������ ����������", "2(63)151-61-70518", "stecoop@yahoo.com", "UL1236", "8739"),
                new ClientCorporate("��� ����-�������", "��, �������, ����������� ��, 54", "7922424472", "78899678892", "445982837",
                           "����� ����� ���������", "������ ������� ��������", "0(601)740-14-66478", "kassiesa@aol.com", "UL1237", "37728"),
                new ClientCorporate("�� ������� ������", "��, �������, ��������� ������� ��, 67", "7955555572", "78123723992", "402000227",
                           "������� ���� �������������", "���������� ������� ��������", "31(57)181-23-30334", "bartlett@att.net", "UL1238", "34yy32"),
                new ClientCorporate("��� ������������", "��, �������, �� ������, 28", "7922985472", "70989678892", "408288227",
                           "��������� ��������� ����������", "���������� ����� ����������", "3(2113)599-96-85099", "alias@sbcglobal.net", "UL1239", "873"),
                new ClientCorporate("�� ������ ����", "��, ��������, 9 ������, 298", "7929388332", "73626626892", "445639927",
                           "�������� Ը��� ��������", "������� �������� ��������", "73(5598)021-52-52563", "research@sbcglobal.net", "UL1240", "ue378")
            };

            clientsIndividual = new List<ClientIndividual>
            {
                new ClientIndividual("������ ������ ��������", "45462526", "����� 1180 ����� 176596", "7/14/2001", "344288, �. ������, ��. ������, 1, ��. 34", "gohufreilagrau-3818@yopmail.com", "cl12345"),
                new ClientIndividual("�������� ������ ������������", "45462527", "����� 2280 ����� 223523", "2/10/2001", "614164, �. ������, ��. �������, 30, ��. 75", "xawugosune-1385@yopmail.com", "cl12346"),
                new ClientIndividual("�������� ����� ��������", "45462528", "����� 4560 ����� 354155", "5/21/1998", "394242, �. ������, ��. ����������������, 43, ��. 57", "satrahuddusei-4458@yopmail.com", "cl12347"),
                new ClientIndividual("������ ���� �����", "45462529", "����� 9120 ����� 554296", "10/1/1998", "660540, �. ������, ��. ���������, 25, ��. 78", "boippaxeufrepra-7093@yopmail.com", "cl12348"),
                new ClientIndividual("��������� ���� ��������", "45462530", "����� 2367 ����� 558134", "5/31/1976", "125837, �. ������, ��. ���������, 40, ��. 92", "zapramaxesu-7741@yopmail.com", "cl12349"),
                new ClientIndividual("������ ������ ������������", "45462531", "����� 7101 ����� 669343", "11/4/1985", "125703, �. ������, ��. ������������, 49, ��. 84", "rouzecroummegre-3899@yopmail.com", "cl12350"),
                new ClientIndividual("������ ������� �������������", "45462532", "����� 3455 ����� 719630", "8/17/1998", "625283, �. ������, ��. ������, 46, ��. 7", "ziyeuddocrabri-4748@yopmail.com", "cl12351"),
                new ClientIndividual("������ ��������� �������", "45462533", "����� 2377 ����� 871623", "10/24/1984", "614611, �. ������, ��. ����������, 50, ��. 78", "ketameissoinnei-1951@yopmail.com", "cl12352"),
                new ClientIndividual("�������� ����� ��������", "45462534", "����� 8755 ����� 921148", "10/14/1976", "454311, �. ������, ��. �����, 19, ��. 78", "yipraubaponou-5849@yopmail.com", "cl12353"),
                new ClientIndividual("������ ������ ��������", "45462535", "����� 4355 ����� 104594", "10/14/1999", "660007, �. ������, ��. �����������, 19, ��. 42", "crapedocouca-3572@yopmail.com", "cl12354"),
                new ClientIndividual("�������� ��������� ����������", "45462536", "����� 2791 ����� 114390", "7/13/1985", "603036, �. ������, ��. �������, 4, ��. 13", "ceigoixakaunni-9227@yopmail.com", "cl12355"),
                new ClientIndividual("�������� ������ ����������", "45462537", "����� 5582 ����� 126286", "5/26/1976", "450983, �. ������, ��. �������������, 26, ��. 60", "yeimmeiwauzomo-7054@yopmail.com", "cl12356"),
                new ClientIndividual("����������� ����� ����������", "45462538", "����� 2978 ����� 133653", "8/13/1999", "394782, �. ������, ��. ������, 3, ��. 14", "poleifenevi-1560@yopmail.com", "cl12357"),
                new ClientIndividual("������ ������ ����������", "45462539", "����� 7512 ����� 141956", "10/13/1985", "603002, �. ������, ��. ������������, 28, ��. 56", "kauprezofautei-6607@yopmail.com", "cl12358"),
                new ClientIndividual("������ ������� ���������", "45462540", "����� 5046 ����� 158433", "4/15/1999", "450558, �. ������, ��. ����������, 30, ��. 71", "quaffaullelourei-1667@yopmail.com", "cl12359"),
                new ClientIndividual("��������� �������� ����������", "45462541", "����� 2460 ����� 169505", "1/13/1999", "394060, �. ������, ��. ������, 43, ��. 79", "jsteele@rojas-robinson.net", "cl12360"),
                new ClientIndividual("������� ��������� ���������", "45462542", "����� 3412 ����� 174593", "1/7/1999", "410661, �. ������, ��. ��������, 50, ��. 53", "vhopkins@lewis-mullen.com", "cl12361"),
                new ClientIndividual("��������� ������ �������������", "45462543", "����� 4950 ����� 183034", "1/24/1999", "625590, �. ������, ��. ����������������, 20, ��. 34", "nlewis@yahoo.com", "cl12362"),
                new ClientIndividual("������ ���� ���������", "45462544", "����� 5829 ����� 219464", "9/2/1993", "625683, �. ������, ��. 8 �����, 20, ��. 21", "garciadavid@mckinney-mcbride.com", "cl12363"),
                new ClientIndividual("������ ����� �������������", "45462545", "����� 6443 ����� 208059", "9/3/1998", "400562, �. ������, ��. �������, 32, ��. 67", "cbradley@castro.com", "cl12364"),
                new ClientIndividual("����� ������ ��������", "45462546", "����� 7079 ����� 213265", "10/23/1985", "614510, �. ������, ��. �����������, 47, ��. 72", "cuevascatherine@carlson.biz", "cl12365"),
                new ClientIndividual("����� ������� ��������", "45462547", "����� 8207 ����� 522702", "7/27/1985", "410542, �. ������, ��. �������, 46, ��. 82", "thomasmoore@wilson-singh.net", "cl12366"),
                new ClientIndividual("��������� ���� ����������", "45462548", "����� 9307 ����� 232158", "10/4/1998", "620839, �. ������, ��. ���������, 8, ��. 100", "jessica84@hotmail.com", "cl12367"),
                new ClientIndividual("������� ������ ����������", "45462549", "����� 1357 ����� 242839", "4/23/1999", "443890, �. ������, ��. ����������������, 1, ��. 10", "jessicapark@hotmail.com", "cl12368"),
                new ClientIndividual("������� ����� ��������", "45462550", "����� 1167 ����� 256636", "10/1/1993", "603379, �. ������, ��. ����������, 46, ��. 95", "ginaritter@schneider-buchanan.com", "cl12369"),
                new ClientIndividual("�������� ����� ���������", "45462551", "����� 1768 ����� 266986", "3/22/1976", "603721, �. ������, ��. ������, 41, ��. 57", "stephen99@yahoo.com", "cl12370"),
                new ClientIndividual("�������� ���������� ���������", "45462552", "����� 1710 ����� 427875", "3/26/1999", "410172, �. ������, ��. ��������, 13, ��. 86", "lopezlisa@hotmail.com", "cl12371"),
                new ClientIndividual("������ ������ ����������", "45462553", "����� 1806 ����� 289145", "10/11/1999", "420151, �. ������, ��. ��������, 32, ��. 81", "lori17@hotmail.com", "cl12372"),
                new ClientIndividual("������� ������ ���������", "45462554", "����� 1587 ����� 291249", "6/29/1997", "125061, �. ������, ��. ���������, 8, ��. 74", "campbellkevin@gardner.com", "cl12373"),
                new ClientIndividual("�������� ����� �����", "45462555", "����� 1647 ����� 306372", "3/6/1984", "630370, �. ������, ��. ���������, 24, ��. 81", "morganhoward@clark.com", "cl12374"),
                new ClientIndividual("��������� ������� ����������", "45462556", "����� 1742 ����� 316556", "9/30/1999", "614753, �. ������, ��. �������, 35, ��. 39", "carsontamara@gmail.com", "cl12375"),
                new ClientIndividual("�������� �������� ���������", "45462557", "����� 1474 ����� 326347", "4/8/1999", "426030, �. ������, ��. �����������, 44, ��. 93", "kevinpatel@gmail.com", "cl12376"),
                new ClientIndividual("�������� ������ ����������", "45462558", "����� 1452 ����� 339539", "8/2/1998", "450375, �. ������, ��. �������, 44, ��. 80", "sethbishop@yahoo.com", "cl12377"),
                new ClientIndividual("�������� ������ �������������", "45462559", "����� 2077 ����� 443480", "9/19/1976", "625560, �. ������, ��. ���������, 12, ��. 66", "drollins@schultz-soto.net", "cl12378"),
                new ClientIndividual("������� ����� ����������", "45462560", "����� 2147 ����� 357518", "4/3/1999", "630201, �. ������, ��. �������������, 17, ��. 25", "pblack@copeland-winters.org", "cl12379"),
                new ClientIndividual("�������� ������ ������", "45462561", "����� 2687 ����� 363884", "4/21/1976", "190949, �. ������, ��. ��������, 26, ��. 93", "johnathon.oberbrunner@yahoo.com", "cl12380"),
                new ClientIndividual("������ �������� ���������", "45462562", "����� 2376 ����� 443711", "1/26/1998", "350501, �. ������, ��. ��������, 2, ��. 7", "bradly29@gmail.com", "cl12381"),
                new ClientIndividual("������ ������� ����������", "45462563", "����� 2568 ����� 386237", "8/11/1976", "450048, �. ������, ��. ����������������, 21, ��. 3", "stark.cristina@hilpert.biz", "cl12382"),
                new ClientIndividual("������� ������ ���������", "45462564", "����� 2556 ����� 439376", "7/12/1993", "644921, �. ������, ��. ��������, 46, ��. 37", "bruen.eleanore@yahoo.com", "cl12383"),
                new ClientIndividual("������ ������ ����������", "45462565", "����� 2737 ����� 407501", "9/19/1998", "614228, �. ������, ��. ��������, 36, ��. 54", "percival.halvorson@yahoo.com", "cl12384"),
                new ClientIndividual("������� ������ ���������", "45462566", "����� 2581 ����� 441645", "5/24/1998", "350940, �. ������, ��. ������������, 23, ��. 2", "javonte71@kuhlman.biz", "cl12385"),
                new ClientIndividual("������� ������ ��������", "45462567", "����� 2675 ����� 427933", "1/4/1976", "344990, �. ������, ��. ���������������, 19, ��. 92", "vconnelly@kautzer.com", "cl12386"),
                new ClientIndividual("���������� �������� ����������", "45462568", "����� 2967 ����� 434531", "7/12/1976", "410248, �. ������, ��. �������, 11, ��. 75", "anabelle07@schultz.info", "cl12387"),
                new ClientIndividual("�������� ������ Ը�������", "45462569", "����� 3070 ����� 449655", "5/2/1976", "400839, �. ������, ��. 8 �����, 46, ��. 44", "nitzsche.katlynn@yahoo.com", "cl12388"),
                new ClientIndividual("�������� ���� �������", "45462570", "����� 3108 ����� 451174", "3/23/1985", "450539, �. ������, ��. ���������, 3, ��. 81", "corine16@von.com", "cl12389"),
                new ClientIndividual("��������� ������ ����������", "45462571", "����� 3250 ����� 464705", "6/3/1999", "614591, �. ������, ��. ���������, 20, ��. 40", "otha.wisozk@lubowitz.org", "cl12390"),
                new ClientIndividual("�������� ���� ����������", "45462572", "����� 3392 ����� 471644", "7/18/1997", "400260, �. ������, ��. ����������, 30, ��. 53", "may.kirlin@hotmail.com", "cl12391"),
                new ClientIndividual("���������� ���� ���������", "45462573", "����� 3497 ����� 487819", "11/6/1985", "660924, �. ������, ��. ����������, 32, ��. 59", "bryana.kautzer@yahoo.com", "cl12392"),
                new ClientIndividual("��������� ������ ����������", "45462574", "����� 3560 ����� 491260", "5/26/1999", "644133, �. ������, ��. ��������, 28, ��. 69", "deborah.christiansen@quigley.biz", "cl12393"),
                new ClientIndividual("������� ������� �������������", "45462575", "����� 3620 ����� 506034", "6/14/1999", "450698, �. ������, ��. ����������, 14, ��. 37", "connelly.makayla@yahoo.com", "cl12394"),
                new ClientIndividual("������� ���� ���������", "45462576", "����� 3774 ����� 511438", "1/26/1985", "620653, �. ������, ��. ��������, 15, ��. 25", "tatum.collins@fay.org", "cl12395"),
                new ClientIndividual("������� ������ ���������", "45462577", "����� 3862 ����� 521377", "7/6/1976", "644321, �. ������, ��. �������, 32, ��. 10", "itzel73@anderson.com", "cl12396"),
                new ClientIndividual("������ ����� ����������", "45462578", "����� 3084 ����� 535966", "2/24/1997", "603653, �. ������, ��. ����������, 2, ��. 45", "arjun39@hotmail.com", "cl12397"),
                new ClientIndividual("������� ���������� ����������", "45462579", "����� 4021 ����� 541528", "6/20/1993", "410181, �. ������, ��. �������������, 16, ��. 74", "ohara.rebeka@yahoo.com", "cl12398"),
                new ClientIndividual("��������� ������ ���������", "45462580", "����� 4109 ����� 554053", "5/10/1998", "394207, �. ������, ��. ���������, 31, ��. 28", "danika58@rath.com", "cl12399"),
                new ClientIndividual("�������� ���� Ը�������", "45462581", "����� 4537 ����� 564868", "3/14/1998", "420633, �. ������, ��. ���������, 18, ��. 41", "janae.bogan@gmail.com", "cl12400"),
                new ClientIndividual("��������� ������� ����������", "45462582", "����� 4914 ����� 572471", "2/18/1985", "445720, �. ������, ��. ���������, 50, ��. 67", "vern91@yahoo.com", "cl12401"),
                new ClientIndividual("����� ������ ����������", "45462583", "����� 4445 ����� 581302", "11/23/1999", "400646, �. ������, ��. �����������, 47, ��. 65", "mariana.leannon@larkin.net", "cl12402"),
                new ClientIndividual("�������� ������� ���������", "45462584", "����� 4743 ����� 598180", "9/13/1993", "644410, �. ������, ��. �������, 17, ��. 69", "vmoore@gmail.com", "cl12403"),
                new ClientIndividual("������ ������ ����������", "45462585", "����� 4741 ����� 601821", "6/24/1984", "400750, �. ������, ��. ��������, 36, ��. 71", "damon.mcclure@mills.com", "cl12404"),
                new ClientIndividual("��������� ������ ��������������", "45462586", "����� 4783 ����� 612567", "8/1/1999", "660590, �. ������, ��. ������, 37, ��. 70", "grady.reilly@block.com", "cl12405"),
                new ClientIndividual("�������� ������ ����������", "45462587", "����� 4658 ����� 621200", "5/29/1993", "426083, �. ������, ��. �������������, 41, ��. 26", "boyd.koss@yahoo.com", "cl12406"),
                new ClientIndividual("�������� ����� �����", "45462588", "����� 4908 ����� 634613", "4/13/1985", "410569, �. ������, ��. ��������, 36, ��. 17", "obartell@franecki.info", "cl12407"),
                new ClientIndividual("�������� ���� �������������", "45462589", "����� 5092 ����� 642468", "3/30/1985", "443375, �. ������, ��. ������������, 50, ��. 95", "reina75@ferry.net", "cl12408"),
                new ClientIndividual("��������� ���� ��������", "45462590", "����� 5155 ����� 465274", "6/2/1984", "614316, �. ������, ��. ������������, 48, ��. 31", "karson28@hotmail.com", "cl12409"),
                new ClientIndividual("�������� ����� ����������", "45462591", "����� 5086 ����� 666893", "5/23/1976", "445685, �. ������, ��. �������, 7, ��. 47", "damaris61@okon.com", "cl12410"),
                new ClientIndividual("������� ������ ����������", "45462592", "����� 5333 ����� 675375", "6/17/1999", "614505, �. ������, ��. ��������, 37, ��. 31", "carroll.jerod@hotmail.com", "cl12411"),
                new ClientIndividual("���������� ����� ��������������", "45462593", "����� 5493 ����� 684572", "10/13/1984", "426629, �. ������, ��. ��������, 32, ��. 46", "ron.treutel@quitzon.com", "cl12412"),
                new ClientIndividual("��������� ����� ��������", "45462594", "����� 5150 ����� 696226", "12/2/1976", "603743, �. ������, ��. ���������, 19, ��. 20", "olen79@yahoo.com", "cl12413"),
                new ClientIndividual("�������� ������ ����������", "45462595", "����� 1308 ����� 703305", "5/22/1985", "450750, �. ������, ��. �������, 23, ��. 90", "pacocha.robbie@yahoo.com", "cl12414")
            };

            orders = new List<Order>
            {
                new Order(1, "45462527/44632", "3/12/2022", "45462527", new List<int> { 34, 31, 353, 336 }, "�����", null, "ID 104", "78 �"),
                new Order(2, "45462528/44633", "3/13/2022", "45462528", new List<int> { 98, 45, 89, 99, 123 }, "�� ������������", null, "ID 105", "16 �"),
                new Order(3, "45462529/44634", "3/14/2022", "45462529", new List<int> { 92, 45, 57, 88 }, "�� ������������", null, "ID 106", "28 �"),
                new Order(4, "45462530/44635", "3/15/2022", "45462530", new List<int> { 92, 45, 57, 88, 44 }, "�����", null, "ID 109", "1200 �����"),
                new Order(5, "45462531/44636", "3/16/2022", "45462531", new List<int> { 98, 45, 89, 353, 336, 34 }, "�������", "4/16/2022", "ID 110", "3 �����"),
                new Order(6, "45462532/44637", "3/17/2022", "45462532", new List<int> { 34, 31, 353, 337 }, "�����", null, "ID 104", "480 �����"),
                new Order(7, "45462533/44638", "3/18/2022", "45462533", new List<int> { 98, 45, 89, 99, 124 }, "�����", null, "ID 105", "2 �����"),
                new Order(8, "45462534/44639", "3/19/2022", "45462534", new List<int> { 92, 45, 57, 89 }, "�� ������������", null, "ID 106", "48 �����"),
                new Order(9, "hh123/44640", "3/20/2022", "hh123", new List<int> { 92, 45, 57, 88, 45 }, "�� ������������", null, "ID 109", "78 �"),
                new Order(10, "fj23/44641", "3/21/2022", "fj23", new List<int> { 98, 45, 89, 353, 336, 35 }, "�����", null, "ID 110", "16 �"),
                new Order(11, "8739/44642", "3/22/2022", "8739", new List<int> { 34, 31, 353, 338 }, "�������", "4/22/2022", "ID 104", "78 �"),
                new Order(12, "37728/44643", "3/23/2022", "37728", new List<int> { 98, 45, 89, 99, 125 }, "�� ������������", null, "ID 105", "160 �"),
                new Order(13, "34yy32/44644", "3/24/2022", "34yy32", new List<int> { 92, 45, 57, 90 }, "�� ������������", null, "ID 106", "28 �"),
                new Order(14, "873/44645", "3/25/2022", "873", new List<int> { 92, 45, 57, 88, 46 }, "�� ������������", null, "ID 109", "1200 �����"),
                new Order(15, "ue378/44646", "3/26/2022", "ue378", new List<int> { 98, 45, 89, 353, 336, 36 }, "�������", "4/26/2022", "ID 110", "3 �����"),
                new Order(16, "45462542/44647", "3/27/2022", "45462542", new List<int> { 34, 31, 353, 339 }, "�����", null, "ID 104", "480 �����"),
                new Order(17, "45462543/44648", "3/28/2022", "45462543", new List<int> { 98, 45, 89, 99, 126 }, "�� ������������", null, "ID 105", "2 �����"),
                new Order(18, "45462531/44649", "3/29/2022", "45462531", new List<int> { 92, 45, 57, 91 }, "�� ������������", null, "ID 106", "48 �����"),
                new Order(19, "45462532/44650", "3/30/2022", "45462532", new List<int> { 92, 45, 57, 88, 47 }, "�����", null, "ID 109", "78 �"),
                new Order(20, "45462533/44651", "3/31/2022", "45462533", new List<int> { 98, 45, 89, 353, 336, 37 }, "�����", null, "ID 110", "16 �"),
                new Order(21, "45462534/44652", "4/1/2022", "45462534", new List<int> { 34, 31, 353, 340 }, "�������", "5/2/2022", "ID 104", "78 �"),
                new Order(22, "45462535/44653", "4/2/2022", "45462535", new List<int> { 98, 45, 89, 99, 127 }, "�����", null, "ID 105", "16 �"),
                new Order(23, "hh123/44654", "4/3/2022", "hh123", new List<int> { 92, 45, 57, 92 }, "�����", null, "ID 106", "28 �"),
                new Order(24, "fj23/44655", "4/4/2022", "fj23", new List<int> { 92, 45, 57, 88, 48 }, "�� ������������", null, "ID 109", "1200 �����"),
                new Order(25, "8739/44656", "4/5/2022", "8739", new List<int> { 98, 45, 89, 353, 336, 38 }, "�� ������������", null, "ID 110", "3 �����"),
                new Order(26, "37728/44657", "4/6/2022", "37728", new List<int> { 34, 31, 353, 341 }, "�� ������������", null, "ID 104", "480 �����"),
                new Order(27, "34yy32/44658", "4/7/2022", "34yy32", new List<int> { 98, 45, 89, 99, 128 }, "�� ������������", null, "ID 105", "2 �����"),
                new Order(28, "873/44659", "4/8/2022", "873", new List<int> { 92, 45, 57, 93 }, "�������", "5/9/2022", "ID 106", "48 �����"),
                new Order(29, "ue378/44660", "4/9/2022", "ue378", new List<int> { 92, 45, 57, 88, 49 }, "�����", null, "ID 109", "78 �"),
                new Order(30, "45462556/44661", "4/10/2022", "45462556", new List<int> { 98, 45, 89, 353, 336, 39 }, "�� ������������", null, "ID 110", "16 �"),
                new Order(31, "45462557/44662", "4/11/2022", "45462557", new List<int> { 34, 31, 353, 342 }, "�� ������������", null, "ID 104", "78 �"),
                new Order(32, "45462558/44663", "4/12/2022", "45462558", new List<int> { 98, 45, 89, 99, 129 }, "�����", null, "ID 105", "16 �"),
                new Order(33, "45462559/44664", "4/13/2022", "45462559", new List<int> { 92, 45, 57, 94 }, "�����", null, "ID 106", "28 �"),
                new Order(34, "45462579/44665", "4/14/2022", "45462579", new List<int> { 92, 45, 57, 88, 50 }, "�����", null, "ID 109", "1200 �����"),
                new Order(35, "45462580/44666", "4/15/2022", "45462580", new List<int> { 98, 45, 89, 353, 336, 40 }, "�� ������������", null, "ID 110", "3 �����"),
                new Order(36, "45462581/44667", "4/16/2022", "45462581", new List<int> { 34, 31, 353, 343 }, "�� ������������", null, "ID 104", "480 �����"),
                new Order(37, "45462582/44668", "4/17/2022", "45462582", new List<int> { 98, 45, 89, 99, 130 }, "�� ������������", null, "ID 105", "2 �����"),
                new Order(38, "hh123/44669", "4/18/2022", "hh123", new List<int> { 92, 45, 57, 95 }, "�������", "5/19/2022", "ID 106", "48 �����"),
                new Order(39, "fj23/44670", "4/19/2022", "fj23", new List<int> { 92, 45, 57, 88, 51 }, "�� ������������", null, "ID 109", "78 �"),
                new Order(40, "8739/44671", "4/20/2022", "8739", new List<int> { 98, 45, 89, 353, 336, 41 }, "�����", null, "ID 110", "16 �"),
                new Order(41, "37728/44672", "4/21/2022", "37728", new List<int> { 34, 31, 353, 344 }, "�������", "5/22/2022", "ID 104", "78 �"),
                new Order(42, "34yy32/44673", "4/22/2022", "34yy32", new List<int> { 98, 45, 89, 99, 131 }, "�� ������������", null, "ID 105", "16 �"),
                new Order(43, "873/44674", "4/23/2022", "873", new List<int> { 92, 45, 57, 96 }, "�� ������������", null, "ID 106", "28 �"),
                new Order(44, "ue378/44675", "4/24/2022", "ue378", new List<int> { 92, 45, 57, 88, 52 }, "�� ������������", null, "ID 109", "1200 �����"),
                new Order(45, "45462534/44676", "4/25/2022", "45462534", new List<int> { 98, 45, 89, 353, 336, 42 }, "�� ������������", null, "ID 110", "3 �����"),
                new Order(46, "45462535/44677", "4/26/2022", "45462535", new List<int> { 34, 31, 353, 345 }, "�� ������������", null, "ID 104", "480 �����"),
                new Order(47, "45462536/44678", "4/27/2022", "45462536", new List<int> { 98, 45, 89, 99, 132 }, "�������", "5/28/2022", "ID 105", "2 �����"),
                new Order(48, "45462537/44679", "4/28/2022", "45462537", new List<int> { 92, 45, 57, 97 }, "�����", null, "ID 106", "48 �����"),
                new Order(49, "45462575/44680", "4/29/2022", "45462575", new List<int> { 92, 45, 57, 88, 53 }, "�����", null, "ID 109", "78 �"),
                new Order(50, "45462576/44681", "4/30/2022", "45462576", new List<int> { 98, 45, 89, 353, 336, 43 }, "�����", null, "ID 110", "16 �")
            };

            employees = new List<Employee>
            {
                new Employee("ID 101", "�������� �� ������ � ���������", "������ ���� ��������", "Ivanov@namecomp.ru", "2L6KZG", new List<int>(), "15:05:2022 13:13:00"),
                new Employee("ID 102", "�������� �� ������ � ���������", "������ ���� ��������", "petrov@namecomp.ru", "uzWC67", new List<int>(), "15:05:2022 13:13:01"),
                new Employee("ID 103", "�������������", "������� ����� ���������", "fedorov@namecomp.ru", "8ntwUp", new List<int>(), "15:05:2022 13:13:02"),
                new Employee("ID 104", "��������", "������� �������� �����������", "mironov@namecomp.ru", "YOyhfR", new List<int> {34, 31, 353, 336}, "15:05:2022 13:13:03"),
                new Employee("ID 105", "��������", "������ ������� ������������", "shiryev@namecomp.ru", "RSbvHv", new List<int> {98, 45, 89, 99, 123}, "15:05:2022 13:13:04"),
                new Employee("ID 106", "��������", "������� ������� ����������", "ignatov@namecomp.ru", "rwVDh9", new List<int> {92, 45, 57, 88}, "15:05:2022 13:13:05"),
                new Employee("ID 107", "��������� ���", "������ �������� ��������", "hohlov@namecomp.ru", "LdNyos", new List<int>(), "15:05:2022 13:13:06"),
                new Employee("ID 108", "�������������", "�������� �������� ����������", "strelkov@namecomp.ru", "gynQMT", new List<int>(), "15:05:2022 13:13:07"),
                new Employee("ID 109", "��������� ���", "������� ����� ��������", "belyeva@@namecomp.ru", "AtnDjr", new List<int> {92, 45, 57, 88, 44}, "15:05:2022 13:13:08"),
                new Employee("ID 110", "��������� ���", "�������� ������ ���������", "smirnova@@namecomp.ru", "JlFRCZ", new List<int> {98, 45, 89, 353, 336, 34}, "15:05:2022 13:13:09")
            };

            // ��������� ��������� ��� ������ ������
            idLaboratoryVesselTextBox.Text = GetNextOrderNumber();

            // ���������� ������� Enter
            idLaboratoryVesselTextBox.KeyPress += IdLaboratoryVesselTextBox_KeyPress;


            string[] customerItems = { "��", "��" };
            customerChoiceComboBox.Items.AddRange(customerItems);
            customerChoiceComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (var service in services)
            {
                servicesCheckedListBox.Items.Add(service.Name);
            }
        }
        private string GetNextOrderNumber()
        {
            // ������� ��������� ����� ������, �������� ������ � ������ (��������, � �������� "�������")
            var lastOrderNumber = orders
                .Select(order => ParseOrderNumber(order.OrderNumber))
                .Max();

            // ���������� ��������� �����
            return (lastOrderNumber + 1).ToString();
        }

        private int ParseOrderNumber(string orderNumber)
        {
            // ��������� �������� ����� �� ������ ������
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

                // ��������� ������������ ������
                if (IsUniqueVesselNumber(enteredVesselNumber))
                {
                    MessageBox.Show("����� ������ �����������: " + enteredVesselNumber);
                }
                else
                {
                    MessageBox.Show("���� ����� ��� ����������. ����������, ������� ���������� �����.");
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
                bool isLegalEntity = customerChoiceComboBox.SelectedItem.ToString() == "��";

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

            // �������� ������� ������� �� ���
            if (!string.IsNullOrEmpty(fullName) && !clientsIndividual.Any(c => c.FullName == fullName))
            {
                // ���������� ������ �������
                ClientIndividual newClient = new ClientIndividual(
                    fullName,
                    "����� ��� �������",
                    "����� ���������� ������",
                    "���� ��������",
                    "�����",
                    "email@example.com",
                    "������"
                );

                clientsIndividual.Add(newClient);
                MessageBox.Show($"������ {newClient.FullName} ��������.");
            }
            else
            {
                MessageBox.Show("������ � ����� ��� ��� ���������� ��� ���� ��� ������.");
            }
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            string customerChoiceValue = customerChoiceComboBox.SelectedItem.ToString();
            if (customerChoiceValue == "��")
            {
                ClientCorporateForm newForm = new ClientCorporateForm();
                newForm.Show();
            }
            else if (customerChoiceValue == "��")
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
                // �������� ������� ���������
                decimal currentTotalCost = 0;
                if (decimal.TryParse(costValue.Text.Replace(" ���.", ""), out decimal parsedCost))
                {
                    currentTotalCost = parsedCost;
                }

                // ������������ ����� ��������� � ����������� �� ��������� NewValue
                if (e.NewValue == CheckState.Checked)
                {
                    // ���� ������� �������, ��������� ��� ���������
                    currentTotalCost += selectedService.Cost;
                }
                else if (e.NewValue == CheckState.Unchecked)
                {
                    // ���� ������� ���������, �������� ��� ���������
                    currentTotalCost -= selectedService.Cost;
                }

                // ��������� ����������� ���������, �������� " ���."
                costValue.Text = $"{currentTotalCost} ���.";
            }
        }
    }
}

