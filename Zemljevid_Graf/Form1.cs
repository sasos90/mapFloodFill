// SAŠO SABOTIN E1031731
// 1206990500100

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Zemljevid_Graf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap map;
        List<Podrocje> obcina;
        List<Podrocje> regija;
        List<Podrocje> zzzsi;
        Podrocje temp;
        private void Form1_Load(object sender, EventArgs e)
        {
            obcina = new List<Podrocje>();
            #region Deklaracija občin
            temp = new Podrocje(1, 918, 141, "ROGAŠOVCI");
            obcina.Add(temp);
            temp = new Podrocje(2, 934, 112, "KUZMA");
            obcina.Add(temp);
            temp = new Podrocje(3, 977, 127, "GORNJI PETROVCI");
            obcina.Add(temp);
            temp = new Podrocje(4, 999, 117, "ŠALOVCI");
            obcina.Add(temp);
            temp = new Podrocje(5, 1016, 125, "HODOŠ/HODOS");
            obcina.Add(temp);
            temp = new Podrocje(6, 945, 132, "GRAD");
            obcina.Add(temp);
            temp = new Podrocje(7, 916, 172, "CANKOVA");
            obcina.Add(temp);
            temp = new Podrocje(8, 957, 164, "PUCONCI");
            obcina.Add(temp);
            temp = new Podrocje(9, 1004, 180, "MORAVSKE TOPLICE");
            obcina.Add(temp);
            temp = new Podrocje(10, 927, 207, "TIŠINA");
            obcina.Add(temp);
            temp = new Podrocje(11, 964, 203, "MURSKA SOBOTA");
            obcina.Add(temp);
            temp = new Podrocje(12, 1024, 212, "DOBROVNIK/DOBRONAK");
            obcina.Add(temp);
            temp = new Podrocje(13, 1035, 189, "KOBILJE");
            obcina.Add(temp);
            temp = new Podrocje(14, 988, 221, "BELTINCI");
            obcina.Add(temp);
            temp = new Podrocje(15, 1009, 218, "TURNIŠČE");
            obcina.Add(temp);
            temp = new Podrocje(16, 1053, 254, "LENDAVA/LENDVA");
            obcina.Add(temp);
            temp = new Podrocje(17, 1022, 245, "VELIKA POLANA");
            obcina.Add(temp);
            temp = new Podrocje(18, 1010, 247, "ČRENŠOVCI");
            obcina.Add(temp);
            temp = new Podrocje(19, 1002, 241, "ODRANCI");
            obcina.Add(temp);
            temp = new Podrocje(20, 996, 271, "RAZKRIŽJE");
            obcina.Add(temp);
            temp = new Podrocje(21, 984, 268, "LJUTOMER");
            obcina.Add(temp);
            temp = new Podrocje(22, 964, 248, "VERŽEJ");
            obcina.Add(temp);
            temp = new Podrocje(23, 947, 246, "KRIŽEVCI");
            obcina.Add(temp);
            temp = new Podrocje(24, 932, 229, "RADENCI");
            obcina.Add(temp);
            temp = new Podrocje(25, 899, 228, "GORNJA RADGONA");
            obcina.Add(temp);
            temp = new Podrocje(26, 874, 193, "APAČE");
            obcina.Add(temp);
            temp = new Podrocje(27, 851, 218, "SVETA ANA");
            obcina.Add(temp);
            temp = new Podrocje(28, 870, 232, "BENEDIKT");
            obcina.Add(temp);
            temp = new Podrocje(29, 891, 246, "CERKVENJAK");
            obcina.Add(temp);
            temp = new Podrocje(30, 902, 249, "SVETI JURIJ OB ŠČAVNICI");
            obcina.Add(temp);
            temp = new Podrocje(31, 923, 287, "SVETI TOMAŽ");
            obcina.Add(temp);
            temp = new Podrocje(32, 960, 318, "ORMOŽ");
            obcina.Add(temp);
            temp = new Podrocje(33, 994, 337, "SREDIŠČE OB DRAVI");
            obcina.Add(temp);
            temp = new Podrocje(34, 923, 345, "ZAVRČ");
            obcina.Add(temp);
            temp = new Podrocje(35, 916, 335, "GORIŠNICA");
            obcina.Add(temp);
            temp = new Podrocje(36, 910, 302, "DORNAVA");
            obcina.Add(temp);
            temp = new Podrocje(37, 898, 299, "JURŠINCI");
            obcina.Add(temp);
            temp = new Podrocje(38, 898, 269, "SVETI ANDRAŽ V SLOV. GORICAH");
            obcina.Add(temp);
            temp = new Podrocje(39, 863, 274, "TRNOVSKA VAS");
            obcina.Add(temp);
            temp = new Podrocje(40, 862, 261, "SVETA TROJICA V SLOV. GORICAH");
            obcina.Add(temp);
            temp = new Podrocje(41, 849, 250, "LENART");
            obcina.Add(temp);
            temp = new Podrocje(42, 833, 220, "SVETI JURIJ V SLOV. GORICAH");
            obcina.Add(temp);
            temp = new Podrocje(43, 825, 206, "ŠENTILJ");
            obcina.Add(temp);
            temp = new Podrocje(44, 813, 222, "PESNICA");
            obcina.Add(temp);
            temp = new Podrocje(45, 778, 223, "KUNGOTA");
            obcina.Add(temp);
            temp = new Podrocje(46, 791, 251, "MARIBOR");
            obcina.Add(temp);
            temp = new Podrocje(47, 830, 292, "DUPLEK");
            obcina.Add(temp);
            temp = new Podrocje(48, 856, 291, "DESTRNIK");
            obcina.Add(temp);
            temp = new Podrocje(49, 858, 311, "PTUJ");
            obcina.Add(temp);
            temp = new Podrocje(50, 896, 347, "MARKOVCI");
            obcina.Add(temp);
            temp = new Podrocje(51, 908, 354, "CIRKULANE");
            obcina.Add(temp);
            temp = new Podrocje(52, 873, 352, "VIDEM");
            obcina.Add(temp);
            temp = new Podrocje(53, 845, 316, "HAJDINA");
            obcina.Add(temp);
            temp = new Podrocje(54, 824, 313, "STARŠE");
            obcina.Add(temp);
            temp = new Podrocje(55, 806, 285, "MIKLAVŽ NA DRAVSKEM POLJU");
            obcina.Add(temp);
            temp = new Podrocje(56, 789, 296, "HOČE - SLIVNICA");
            obcina.Add(temp);
            temp = new Podrocje(57, 742, 276, "RUŠE");
            obcina.Add(temp);
            temp = new Podrocje(58, 733, 240, "SELNICA OB DRAVI");
            obcina.Add(temp);
            temp = new Podrocje(59, 682, 240, "PODVELKA");
            obcina.Add(temp);
            temp = new Podrocje(60, 700, 264, "LOVRENC NA POHORJU");
            obcina.Add(temp);
            temp = new Podrocje(61, 739, 318, "SLOVENSKA BISTRICA");
            obcina.Add(temp);
            temp = new Podrocje(62, 774, 306, "RAČE - FRAM");
            obcina.Add(temp);
            temp = new Podrocje(63, 830, 330, "KIDRIČEVO");
            obcina.Add(temp);
            temp = new Podrocje(64, 861, 368, "PODLEHNIK");
            obcina.Add(temp);
            temp = new Podrocje(65, 838, 382, "ŽETALE");
            obcina.Add(temp);
            temp = new Podrocje(66, 826, 365, "MAJŠPERK");
            obcina.Add(temp);
            temp = new Podrocje(67, 798, 369, "MAKOLE");
            obcina.Add(temp);
            temp = new Podrocje(68, 781, 385, "POLJČANE");
            obcina.Add(temp);
            temp = new Podrocje(69, 739, 378, "SLOVENSKE KONJICE");
            obcina.Add(temp);
            temp = new Podrocje(70, 728, 351, "OPLOTNICA");
            obcina.Add(temp);
            temp = new Podrocje(71, 693, 346, "ZREČE");
            obcina.Add(temp);
            temp = new Podrocje(72, 654, 267, "RIBNICA NA POHORJU");
            obcina.Add(temp);
            temp = new Podrocje(73, 647, 241, "RADLJE OB DRAVI");
            obcina.Add(temp);
            temp = new Podrocje(74, 611, 234, "MUTA");
            obcina.Add(temp);
            temp = new Podrocje(75, 622, 243, "VUZENICA");
            obcina.Add(temp);
            temp = new Podrocje(76, 646, 301, "MISLINJA");
            obcina.Add(temp);
            temp = new Podrocje(77, 663, 321, "VITANJE");
            obcina.Add(temp);
            temp = new Podrocje(78, 671, 384, "VOJNIK");
            obcina.Add(temp);
            temp = new Podrocje(79, 701, 426, "ŠENTJUR");
            obcina.Add(temp);
            temp = new Podrocje(80, 744, 414, "ŠMARJE PRI JELŠAH");
            obcina.Add(temp);
            temp = new Podrocje(81, 773, 417, "ROGAŠKA SLATINA");
            obcina.Add(temp);
            temp = new Podrocje(82, 807, 418, "ROGATEC");
            obcina.Add(temp);
            temp = new Podrocje(83, 770, 445, "PODČETRTEK");
            obcina.Add(temp);
            temp = new Podrocje(84, 782, 498, "BISTRICA OB SOTLI");
            obcina.Add(temp);
            temp = new Podrocje(85, 785, 547, "BREŽICE");
            obcina.Add(temp);
            temp = new Podrocje(86, 759, 510, "KOZJE");
            obcina.Add(temp);
            temp = new Podrocje(87, 696, 475, "DOBJE");
            obcina.Add(temp);
            temp = new Podrocje(88, 677, 429, "ŠTORE");
            obcina.Add(temp);
            temp = new Podrocje(89, 663, 412, "CELJE");
            obcina.Add(temp);
            temp = new Podrocje(90, 639, 370, "DOBRNA");
            obcina.Add(temp);
            temp = new Podrocje(91, 618, 361, "VELENJE");
            obcina.Add(temp);
            temp = new Podrocje(92, 606, 294, "SLOVENJ GRADEC");
            obcina.Add(temp);
            temp = new Podrocje(93, 577, 253, "DRAVOGRAD");
            obcina.Add(temp);
            temp = new Podrocje(94, 553, 260, "RAVNE NA KOROŠKEM");
            obcina.Add(temp);
            temp = new Podrocje(95, 520, 256, "PREVALJE");
            obcina.Add(temp);
            temp = new Podrocje(96, 508, 271, "MEŽICA");
            obcina.Add(temp);
            temp = new Podrocje(97, 525, 304, "ČRNA NA KOROŠKEM");
            obcina.Add(temp);
            temp = new Podrocje(98, 555, 332, "ŠOŠTANJ");
            obcina.Add(temp);
            temp = new Podrocje(99, 577, 372, "ŠMARTNO OB PAKI");
            obcina.Add(temp);
            temp = new Podrocje(100, 591, 376, "POLZELA");
            obcina.Add(temp);
            temp = new Podrocje(101, 620, 417, "ŽALEC");
            obcina.Add(temp);
            temp = new Podrocje(102, 640, 454, "LAŠKO");
            obcina.Add(temp);
            temp = new Podrocje(103, 672, 520, "SEVNICA");
            obcina.Add(temp);
            temp = new Podrocje(104, 725, 533, "KRŠKO");
            obcina.Add(temp);
            temp = new Podrocje(105, 708, 608, "KOSTANJEVICA NA KRKI");
            obcina.Add(temp);
            temp = new Podrocje(106, 680, 611, "ŠENTJERNEJ");
            obcina.Add(temp);
            temp = new Podrocje(107, 668, 572, "ŠKOCJAN");
            obcina.Add(temp);
            temp = new Podrocje(108, 647, 588, "ŠMARJEŠKE TOPLICE");
            obcina.Add(temp);
            temp = new Podrocje(109, 621, 573, "MOKRONOG - TREBELNO");
            obcina.Add(temp);
            temp = new Podrocje(110, 595, 555, "ŠENTRUPERT");
            obcina.Add(temp);
            temp = new Podrocje(111, 576, 520, "LITIJA");
            obcina.Add(temp);
            temp = new Podrocje(112, 624, 509, "RADEČE");
            obcina.Add(temp);
            temp = new Podrocje(113, 547, 475, "ZAGORJE OB SAVI");
            obcina.Add(temp);
            temp = new Podrocje(114, 578, 472, "TRBOVLJE");
            obcina.Add(temp);
            temp = new Podrocje(115, 598, 461, "HRASTNIK");
            obcina.Add(temp);
            temp = new Podrocje(116, 592, 423, "PREBOLD");
            obcina.Add(temp);
            temp = new Podrocje(117, 571, 389, "BRASLOVČE");
            obcina.Add(temp);
            temp = new Podrocje(118, 554, 371, "MOZIRJE");
            obcina.Add(temp);
            temp = new Podrocje(119, 511, 344, "LJUBNO");
            obcina.Add(temp);
            temp = new Podrocje(120, 477, 357, "LUČE");
            obcina.Add(temp);
            temp = new Podrocje(121, 459, 334, "SOLČAVA");
            obcina.Add(temp);
            temp = new Podrocje(122, 443, 395, "KAMNIK");
            obcina.Add(temp);
            temp = new Podrocje(123, 495, 402, "GORNJI GRAD");
            obcina.Add(temp);
            temp = new Podrocje(124, 525, 368, "REČICA OB SAVINJI");
            obcina.Add(temp);
            temp = new Podrocje(125, 521, 398, "NAZARJE");
            obcina.Add(temp);
            temp = new Podrocje(126, 547, 409, "VRANSKO");
            obcina.Add(temp);
            temp = new Podrocje(127, 563, 418, "TABOR");
            obcina.Add(temp);
            temp = new Podrocje(128, 500, 442, "LUKOVICA");
            obcina.Add(temp);
            temp = new Podrocje(129, 496, 463, "MORAVČE");
            obcina.Add(temp);
            temp = new Podrocje(130, 441, 491, "DOL PRI LJUBLJANI");
            obcina.Add(temp);
            temp = new Podrocje(131, 520, 520, "ŠMARTNO PRI LITIJI");
            obcina.Add(temp);
            temp = new Podrocje(132, 553, 572, "TREBNJE");
            obcina.Add(temp);
            temp = new Podrocje(133, 573, 559, "MIRNA");
            obcina.Add(temp);
            temp = new Podrocje(134, 593, 616, "MIRNA PEČ");
            obcina.Add(temp);
            temp = new Podrocje(135, 631, 627, "NOVO MESTO");
            obcina.Add(temp);
            temp = new Podrocje(136, 665, 698, "METLIKA");
            obcina.Add(temp);
            temp = new Podrocje(137, 638, 779, "ČRNOMELJ");
            obcina.Add(temp);
            temp = new Podrocje(138, 627, 707, "SEMIČ");
            obcina.Add(temp);
            temp = new Podrocje(139, 583, 682, "DOLENJSKE TOPLICE");
            obcina.Add(temp);
            temp = new Podrocje(140, 595, 638, "STRAŽA");
            obcina.Add(temp);
            temp = new Podrocje(141, 547, 639, "ŽUŽEMBERK");
            obcina.Add(temp);
            temp = new Podrocje(142, 501, 595, "IVANČNA GORICA");
            obcina.Add(temp);
            temp = new Podrocje(143, 437, 523, "LJUBLJANA");
            obcina.Add(temp);
            temp = new Podrocje(144, 409, 469, "TRZIN");
            obcina.Add(temp);
            temp = new Podrocje(145, 430, 458, "DOMŽALE");
            obcina.Add(temp);
            temp = new Podrocje(146, 410, 449, "MENGEŠ");
            obcina.Add(temp);
            temp = new Podrocje(147, 385, 443, "VODICE");
            obcina.Add(temp);
            temp = new Podrocje(148, 405, 426, "KOMENDA");
            obcina.Add(temp);
            temp = new Podrocje(149, 385, 422, "CERKLJE NA GORENJSKEM");
            obcina.Add(temp);
            temp = new Podrocje(150, 377, 382, "PREDDVOR");
            obcina.Add(temp);
            temp = new Podrocje(151, 374, 347, "JEZERSKO");
            obcina.Add(temp);
            temp = new Podrocje(152, 329, 350, "TRŽIČ");
            obcina.Add(temp);
            temp = new Podrocje(153, 319, 393, "NAKLO");
            obcina.Add(temp);
            temp = new Podrocje(154, 343, 407, "KRANJ");
            obcina.Add(temp);
            temp = new Podrocje(155, 360, 421, "ŠENČUR");
            obcina.Add(temp);
            temp = new Podrocje(156, 363, 460, "MEDVODE");
            obcina.Add(temp);
            temp = new Podrocje(157, 348, 504, "DOBROVA - POLHOV GRADEC");
            obcina.Add(temp);
            temp = new Podrocje(158, 342, 526, "LOG - DRAGOMER");
            obcina.Add(temp);
            temp = new Podrocje(159, 355, 542, "BREZOVICA");
            obcina.Add(temp);
            temp = new Podrocje(160, 396, 574, "IG");
            obcina.Add(temp);
            temp = new Podrocje(161, 415, 553, "ŠKOFLJICA");
            obcina.Add(temp);
            temp = new Podrocje(162, 442, 567, "GROSUPLJE");
            obcina.Add(temp);
            temp = new Podrocje(163, 464, 628, "DOBREPOLJE");
            obcina.Add(temp);
            temp = new Podrocje(164, 525, 721, "KOČEVJE");
            obcina.Add(temp);
            temp = new Podrocje(165, 514, 781, "KOSTEL");
            obcina.Add(temp);
            temp = new Podrocje(166, 479, 772, "OSILNICA");
            obcina.Add(temp);
            temp = new Podrocje(167, 441, 726, "LOŠKI POTOK");
            obcina.Add(temp);
            temp = new Podrocje(168, 462, 658, "RIBNICA");
            obcina.Add(temp);
            temp = new Podrocje(169, 426, 651, "SODRAŽICA");
            obcina.Add(temp);
            temp = new Podrocje(170, 421, 614, "VELIKE LAŠČE");
            obcina.Add(temp);
            temp = new Podrocje(171, 390, 632, "BLOKE");
            obcina.Add(temp);
            temp = new Podrocje(172, 348, 589, "BOROVNICA");
            obcina.Add(temp);
            temp = new Podrocje(173, 317, 562, "VRHNIKA");
            obcina.Add(temp);
            temp = new Podrocje(174, 310, 525, "HORJUL");
            obcina.Add(temp);
            temp = new Podrocje(175, 314, 456, "ŠKOFJA LOKA");
            obcina.Add(temp);
            temp = new Podrocje(176, 252, 428, "ŽELEZNIKI");
            obcina.Add(temp);
            temp = new Podrocje(177, 291, 380, "RADOVLJICA");
            obcina.Add(temp);
            temp = new Podrocje(178, 269, 338, "ŽIROVNICA");
            obcina.Add(temp);
            temp = new Podrocje(179, 249, 323, "JESENICE");
            obcina.Add(temp);
            temp = new Podrocje(180, 253, 355, "BLED");
            obcina.Add(temp);
            temp = new Podrocje(181, 196, 392, "BOHINJ");
            obcina.Add(temp);
            temp = new Podrocje(182, 223, 460, "CERKNO");
            obcina.Add(temp);
            temp = new Podrocje(183, 245, 475, "GORENJA VAS - POLJANE");
            obcina.Add(temp);
            temp = new Podrocje(184, 249, 505, "ŽIRI");
            obcina.Add(temp);
            temp = new Podrocje(185, 273, 557, "LOGATEC");
            obcina.Add(temp);
            temp = new Podrocje(186, 337, 643, "CERKNICA");
            obcina.Add(temp);
            temp = new Podrocje(187, 378, 688, "LOŠKA DOLINA");
            obcina.Add(temp);
            temp = new Podrocje(188, 318, 722, "ILIRSKA BISTRICA");
            obcina.Add(temp);
            temp = new Podrocje(189, 316, 683, "PIVKA");
            obcina.Add(temp);
            temp = new Podrocje(190, 291, 649, "POSTOJNA");
            obcina.Add(temp);
            temp = new Podrocje(191, 190, 582, "AJDOVŠČINA");
            obcina.Add(temp);
            temp = new Podrocje(192, 208, 522, "IDRIJA");
            obcina.Add(temp);
            temp = new Podrocje(193, 157, 478, "TOLMIN");
            obcina.Add(temp);
            temp = new Podrocje(194, 193, 341, "GORJE");
            obcina.Add(temp);
            temp = new Podrocje(195, 180, 309, "KRANJSKA GORA");
            obcina.Add(temp);
            temp = new Podrocje(196, 75, 356, "BOVEC");
            obcina.Add(temp);
            temp = new Podrocje(197, 81, 402, "KOBARID");
            obcina.Add(temp);
            temp = new Podrocje(198, 101, 475, "KANAL");
            obcina.Add(temp);
            temp = new Podrocje(199, 56, 536, "BRDA");
            obcina.Add(temp);
            temp = new Podrocje(200, 130, 549, "NOVA GORICA");
            obcina.Add(temp);
            temp = new Podrocje(201, 88, 579, "ŠEMPETER - VRTOJBA");
            obcina.Add(temp);
            temp = new Podrocje(202, 109, 576, "RENČE - VOGRSKO");
            obcina.Add(temp);
            temp = new Podrocje(203, 91, 614, "MIREN - KOSTANJEVICA");
            obcina.Add(temp);
            temp = new Podrocje(204, 122, 613, "KOMEN");
            obcina.Add(temp);
            temp = new Podrocje(205, 179, 647, "SEŽANA");
            obcina.Add(temp);
            temp = new Podrocje(206, 195, 614, "VIPAVA");
            obcina.Add(temp);
            temp = new Podrocje(207, 216, 670, "DIVAČA");
            obcina.Add(temp);
            temp = new Podrocje(208, 204, 734, "HRPELJE - KOZINA");
            obcina.Add(temp);
            temp = new Podrocje(209, 152, 754, "KOPER/CAPODISTRIA");
            obcina.Add(temp);
            temp = new Podrocje(210, 96, 765, "IZOLA/ISOLA");
            obcina.Add(temp);
            temp = new Podrocje(211, 84, 796, "PIRAN/PIRANO");
            obcina.Add(temp);
            #endregion

            regija = new List<Podrocje>();
            #region Deklaracija regij
            temp = new Podrocje(1, 676, 114, "Pomurska");
            regija.Add(temp);
            temp = new Podrocje(2, 575, 178, "Podravska");
            regija.Add(temp);
            temp = new Podrocje(3, 424, 145, "Koroška");
            regija.Add(temp);
            temp = new Podrocje(4, 479, 245, "Savinjska");
            regija.Add(temp);
            temp = new Podrocje(5, 412, 282, "Zasavska");
            regija.Add(temp);
            temp = new Podrocje(6, 513, 348, "Spodnjeposavska");
            regija.Add(temp);
            temp = new Podrocje(7, 421, 420, "Jugovzhodna Slovenija");
            regija.Add(temp);
            temp = new Podrocje(8, 322, 322, "Osrednjeslovenska");
            regija.Add(temp);
            temp = new Podrocje(9, 221, 228, "Gorenjska");
            regija.Add(temp);
            temp = new Podrocje(10, 246, 438, "Notranjsko - kraška");
            regija.Add(temp);
            temp = new Podrocje(11, 134, 305, "Goriška");
            regija.Add(temp);
            temp = new Podrocje(12, 166, 451, "Obalno - kraška");
            regija.Add(temp);
            #endregion

            zzzsi = new List<Podrocje>();
            #region Deklaracija ZZZSI
            temp = new Podrocje(1, 969, 187, "Murska Sobota");
            zzzsi.Add(temp);
            temp = new Podrocje(2, 1051, 242, "Lendava");
            zzzsi.Add(temp);
            temp = new Podrocje(3, 970, 267, "Ljutomer");
            zzzsi.Add(temp);
            temp = new Podrocje(4, 970, 307, "Ormož");
            zzzsi.Add(temp);
            temp = new Podrocje(5, 919, 235, "Gornja Radgona");
            zzzsi.Add(temp);
            temp = new Podrocje(6, 860, 236, "Lenart");
            zzzsi.Add(temp);
            temp = new Podrocje(7, 886, 309, "Ptuj");
            zzzsi.Add(temp);
            temp = new Podrocje(8, 793, 255, "Maribor");
            zzzsi.Add(temp);
            temp = new Podrocje(9, 767, 338, "Slovenska Bistrica");
            zzzsi.Add(temp);
            temp = new Podrocje(10, 770, 407, "Šmarje pri Jelšah");
            zzzsi.Add(temp);
            temp = new Podrocje(11, 692, 355, "Slovenske Konjice");
            zzzsi.Add(temp);
            temp = new Podrocje(12, 655, 252, "Radlje ob Dravi");
            zzzsi.Add(temp);
            temp = new Podrocje(13, 633, 307, "Slovenj Gradec");
            zzzsi.Add(temp);
            temp = new Podrocje(14, 658, 398, "Celje");
            zzzsi.Add(temp);
            temp = new Podrocje(15, 703, 426, "Šentjur");
            zzzsi.Add(temp);
            temp = new Podrocje(16, 782, 539, "Brežice");
            zzzsi.Add(temp);
            temp = new Podrocje(17, 737, 530, "Krško");
            zzzsi.Add(temp);
            temp = new Podrocje(18, 678, 522, "Sevnica");
            zzzsi.Add(temp);
            temp = new Podrocje(19, 678, 474, "Laško");
            zzzsi.Add(temp);
            temp = new Podrocje(20, 616, 404, "Žalec");
            zzzsi.Add(temp);
            temp = new Podrocje(21, 607, 344, "Velenje");
            zzzsi.Add(temp);
            temp = new Podrocje(22, 530, 265, "Ravne na Koroškem");
            zzzsi.Add(temp);
            temp = new Podrocje(23, 515, 360, "Mozirje");
            zzzsi.Add(temp);
            temp = new Podrocje(24, 502, 418, "Kamnik");
            zzzsi.Add(temp);
            temp = new Podrocje(25, 548, 464, "Zagorje ob Savi");
            zzzsi.Add(temp);
            temp = new Podrocje(26, 577, 468, "Trbovlje");
            zzzsi.Add(temp);
            temp = new Podrocje(27, 612, 466, "Hrastnik");
            zzzsi.Add(temp);
            temp = new Podrocje(28, 601, 555, "Trebnje");
            zzzsi.Add(temp);
            temp = new Podrocje(29, 648, 608, "Novo Mesto");
            zzzsi.Add(temp);
            temp = new Podrocje(30, 656, 691, "Metlika");
            zzzsi.Add(temp);
            temp = new Podrocje(31, 616, 720, "Črnomelj");
            zzzsi.Add(temp);
            temp = new Podrocje(32, 523, 705, "Kočevje");
            zzzsi.Add(temp);
            temp = new Podrocje(33, 474, 606, "Grosuplje");
            zzzsi.Add(temp);
            temp = new Podrocje(34, 511, 502, "Litija");
            zzzsi.Add(temp);
            temp = new Podrocje(35, 482, 452, "Domžale");
            zzzsi.Add(temp);
            temp = new Podrocje(36, 383, 391, "Kranj");
            zzzsi.Add(temp);
            temp = new Podrocje(37, 315, 345, "Tržič");
            zzzsi.Add(temp);
            temp = new Podrocje(38, 191, 297, "Jesenice");
            zzzsi.Add(temp);
            temp = new Podrocje(39, 212, 354, "Radovljica");
            zzzsi.Add(temp);
            temp = new Podrocje(40, 285, 463, "Škofja Loka");
            zzzsi.Add(temp);
            temp = new Podrocje(41, 374, 530, "Ljubljana");
            zzzsi.Add(temp);
            temp = new Podrocje(42, 443, 650, "Ribnica");
            zzzsi.Add(temp);
            temp = new Podrocje(43, 356, 633, "Cerknica");
            zzzsi.Add(temp);
            temp = new Podrocje(44, 326, 569, "Vrhnika");
            zzzsi.Add(temp);
            temp = new Podrocje(45, 287, 578, "Logatec");
            zzzsi.Add(temp);
            temp = new Podrocje(46, 203, 503, "Idrija");
            zzzsi.Add(temp);
            temp = new Podrocje(47, 155, 445, "Tolmin");
            zzzsi.Add(temp);
            temp = new Podrocje(48, 135, 522, "Nova Gorica");
            zzzsi.Add(temp);
            temp = new Podrocje(49, 177, 578, "Ajdovščina");
            zzzsi.Add(temp);
            temp = new Podrocje(50, 277, 669, "Postojna");
            zzzsi.Add(temp);
            temp = new Podrocje(51, 292, 742, "Ilirska Bistrica");
            zzzsi.Add(temp);
            temp = new Podrocje(52, 210, 704, "Sežana");
            zzzsi.Add(temp);
            temp = new Podrocje(53, 133, 767, "Koper");
            zzzsi.Add(temp);
            temp = new Podrocje(54, 89, 778, "Izola");
            zzzsi.Add(temp);
            temp = new Podrocje(55, 90, 796, "Piran");
            zzzsi.Add(temp);
            #endregion

            pBox_c1.BackColor = Color.FromArgb(255,255,255);
            num_st_razredov.Minimum = 1;
            num_st_razredov.Maximum = 10;
            num_st_razredov.Value = 10;
        }
        public class Podrocje
        {
            public int id;
            public int x;
            public int y;
            public string name;
            public Podrocje(int id, int x, int y, string name)
            {
                this.id = id;
                this.x = x;
                this.y = y;
                this.name = name;
            }
        }

        List<Razred> razredi;
        public class Razred
        {
            public float bot;
            public float top;
            public Color color;
            public Razred(float bot, float top, Color color)
            {
                this.bot = bot;
                this.top = top;
                this.color = color;
            }
        }

        Thread barvanje;
        private static bool ColorMatch(Color a, Color b)
        {
            return (a.ToArgb() & 0xffffff) == (b.ToArgb() & 0xffffff);
        }

        static void FloodFill(Bitmap bmp, Point pt, Color targetColor, Color replacementColor)
        {
            Queue<Point> q = new Queue<Point>();
            q.Enqueue(pt);
            //Target color! Barvanje preko vsake barve!
            targetColor = bmp.GetPixel(pt.X, pt.Y);
            if (bmp.GetPixel(pt.X, pt.Y).R.ToString() == "254" && bmp.GetPixel(pt.X, pt.Y).G.ToString() == "255" && bmp.GetPixel(pt.X, pt.Y).B.ToString() == "255")
            {
                MessageBox.Show("Na to barvno podlago je prepovedano barvati! Rezervirana podlaga!\nSlika je delno pobarvana.", "Napaka: 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Če je targetColor isti kot barva s katero barvamo, potem naredimo neopazen odtenek! Ne gre barvati na isto barvo!
            if (targetColor == replacementColor)
            {
                if (replacementColor.R.ToString() == "0")
                    replacementColor = Color.FromArgb(replacementColor.R + 1, replacementColor.G, replacementColor.B);
                else
                    replacementColor = Color.FromArgb(replacementColor.R - 1, replacementColor.G, replacementColor.B);
            }
            while (q.Count > 0)
            {
                Point n = q.Dequeue();
                if (!ColorMatch(bmp.GetPixel(n.X, n.Y), targetColor))
                    continue;
                Point w = n, e = new Point(n.X + 1, n.Y);
                while ((w.X > 0) && ColorMatch(bmp.GetPixel(w.X, w.Y), targetColor))
                {
                    // Start debugging colors (ne moremo barvati na isto barvo tudi v ostalih razredih in ne samo v prvem
                    if (replacementColor.R.ToString() == "255" && replacementColor.G.ToString() == "255" && replacementColor.B.ToString() == "255")
                    {
                        replacementColor = Color.FromArgb(replacementColor.R - 1, replacementColor.G, replacementColor.B);
                    }
                    // End debugging colors
                    bmp.SetPixel(w.X, w.Y, replacementColor);
                    if ((w.Y > 0) && ColorMatch(bmp.GetPixel(w.X, w.Y - 1), targetColor))
                        q.Enqueue(new Point(w.X, w.Y - 1));
                    if ((w.Y < bmp.Height - 1) && ColorMatch(bmp.GetPixel(w.X, w.Y + 1), targetColor))
                        q.Enqueue(new Point(w.X, w.Y + 1));
                    w.X--;
                }
                while ((e.X < bmp.Width - 1) && ColorMatch(bmp.GetPixel(e.X, e.Y), targetColor))
                {
                    // Start debugging colors (ne moremo barvati na isto barvo tudi v ostalih razredih in ne samo v prvem
                    if (replacementColor.R.ToString() == "255" && replacementColor.G.ToString() == "255" && replacementColor.B.ToString() == "255")
                    {
                        replacementColor = Color.FromArgb(replacementColor.R - 1, replacementColor.G, replacementColor.B);
                    }
                    // End debugging colors
                    bmp.SetPixel(e.X, e.Y, replacementColor);
                    if ((e.Y > 0) && ColorMatch(bmp.GetPixel(e.X, e.Y - 1), targetColor))
                        q.Enqueue(new Point(e.X, e.Y - 1));
                    if ((e.Y < bmp.Height - 1) && ColorMatch(bmp.GetPixel(e.X, e.Y + 1), targetColor))
                        q.Enqueue(new Point(e.X, e.Y + 1));
                    e.X++;
                }
            }
        }

        // Funkcije
        int num_razredov;
        public void IzdelavaRazredov(int num_razredov)
        {
            razredi = new List<Razred>();

            Razred razred;

            if (num_razredov >= 1)
            {
                razred = new Razred(float.Parse(txt_c1_bot.Text), float.Parse(txt_c1_top.Text), pBox_c1.BackColor);
                razredi.Add(razred);
            }

            if (num_razredov >= 2)
            {
                razred = new Razred(float.Parse(txt_c2_bot.Text), float.Parse(txt_c2_top.Text), pBox_c2.BackColor);
                razredi.Add(razred);
            }

            if (num_razredov >= 3)
            {
                razred = new Razred(float.Parse(txt_c3_bot.Text), float.Parse(txt_c3_top.Text), pBox_c3.BackColor);
                razredi.Add(razred);
            }

            if (num_razredov >= 4)
            {
                razred = new Razred(float.Parse(txt_c4_bot.Text), float.Parse(txt_c4_top.Text), pBox_c4.BackColor);
                razredi.Add(razred);
            }

            if (num_razredov >= 5)
            {
                razred = new Razred(float.Parse(txt_c5_bot.Text), float.Parse(txt_c5_top.Text), pBox_c5.BackColor);
                razredi.Add(razred);
            }

            if (num_razredov >= 6)
            {
                razred = new Razred(float.Parse(txt_c6_bot.Text), float.Parse(txt_c6_top.Text), pBox_c6.BackColor);
                razredi.Add(razred);
            }

            if (num_razredov >= 7)
            {
                razred = new Razred(float.Parse(txt_c7_bot.Text), float.Parse(txt_c7_top.Text), pBox_c7.BackColor);
                razredi.Add(razred);
            }

            if (num_razredov >= 8)
            {
                razred = new Razred(float.Parse(txt_c8_bot.Text), float.Parse(txt_c8_top.Text), pBox_c7.BackColor);
                razredi.Add(razred);
            }

            if (num_razredov >= 9)
            {
                razred = new Razred(float.Parse(txt_c9_bot.Text), float.Parse(txt_c9_top.Text), pBox_c9.BackColor);
                razredi.Add(razred);
            }

            if (num_razredov >= 10)
            {
                razred = new Razred(float.Parse(txt_c10_bot.Text), float.Parse(txt_c10_top.Text), pBox_c10.BackColor);
                razredi.Add(razred);
            }
        }

        public void IzdelavaLegende(int num_razredov, Bitmap map, int x, int y)
        {
            Graphics koncna_slika = Graphics.FromImage(map);

            using (Font font1 = new Font("Arial", 22, FontStyle.Regular, GraphicsUnit.Pixel))
            {
                for (int a = 0; a < num_razredov; a++)
                {
                    Rectangle rectF1 = new Rectangle(x, y + (a * 42), 90, 40);

                    koncna_slika.FillRectangle(new SolidBrush(razredi[a].color), rectF1);
                    koncna_slika.DrawRectangle(Pens.Black, rectF1);
                    koncna_slika.DrawString(razredi[a].bot + " .. " + razredi[a].top, font1, Brushes.Black, x, y + 7 + (a * 42));
                }
            }
        }

        int rowCount;
        int colCount;

        Excel.Application xlApp;
        Excel.Workbook xlWorkbook;
        Excel._Worksheet xlWorksheet;
        Excel.Range xlRange;

        public void Barvanje(List<Podrocje> list, ProgressBar pBar, Label finish, Button btn, Button btn_other1, Button btn_other2, string save_name)
        {
            bool searching;
            int while_a;

            int stevilka_razreda;

            for (int i = 1; i <= rowCount; i++)
            {
                //Pobarvaj podrocje
                searching = true;
                while_a = 0;
                while (searching == true && while_a < list.Count)
                {
                    if (list[while_a].name.ToLower() == xlRange.Cells[i, 1].Value2.ToString().ToLower())
                    {
                        stevilka_razreda = -1; // if -1 then error (no class exist)
                        for (int b = 0; b < razredi.Count; b++)
                        {
                            if (xlRange.Cells[i, 2].Value2 >= razredi[b].bot && xlRange.Cells[i, 2].Value2 < razredi[b].top)
                                stevilka_razreda = b;
                            else if (xlRange.Cells[i, 2].Value2 == razredi[b].top)
                                stevilka_razreda = razredi.Count - 1;
                        }

                        if (stevilka_razreda != -1)
                        {
                            FloodFill(map, new Point(list[while_a].x, list[while_a].y), Color.FromArgb(252, 254, 252), razredi[stevilka_razreda].color);
                        }
                            

                        searching = false;
                    }
                    else
                        while_a++;
                }

                if (pBar.InvokeRequired)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        pBar.Value += 1;
                    });
                }
            }

            map.Save(@"saved/" + save_name + ".png", ImageFormat.Png);
            if (finish.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    finish.Visible = true;
                    btn.Enabled = true;
                    btn_other1.Enabled = true;
                    btn_other2.Enabled = true;
                });
            }
            xlApp.Quit();
            barvanje.Abort();
        }

        ////////////
        // OBCINE //
        ////////////

        private void btn_obcine_Click(object sender, EventArgs e)
        {
            map = new Bitmap(@"pictures/OBCINE PRAZNA bela.png");

            // Izdelava razredov
            num_razredov = int.Parse(num_st_razredov.Value.ToString());
            IzdelavaRazredov(num_razredov);

            // Graphics Legenda razredov
            IzdelavaLegende(num_razredov, map, 900, 450);

            // Excel

            this.openFileDialog1.FileName = "*.xls";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Nastavitve kontrol
                pBar_obcine.Value = 0;
                btn_obcine.Enabled = false;
                lbl_finish_obcine.Visible = false;
                //Izklop Buttonov obcin in regij
                btn_zzzsi.Enabled = false;
                btn_regije.Enabled = false;

                // Excel
                xlApp = new Excel.Application();
                xlWorkbook = xlApp.Workbooks.Open(openFileDialog1.FileName);
                xlWorksheet = xlWorkbook.Sheets[1];
                xlRange = xlWorksheet.UsedRange;

                rowCount = xlRange.Rows.Count;
                colCount = xlRange.Columns.Count;

                pBar_obcine.Minimum = 0;
                pBar_obcine.Maximum = rowCount;
                barvanje = new Thread(BarvanjeObcin);
                barvanje.Start();
            }
        }

        public void BarvanjeObcin()
        {
            Barvanje(obcina, pBar_obcine, lbl_finish_obcine, btn_obcine, btn_zzzsi, btn_regije, "obcine");
        }

        ////////////////
        // END OBCINE //
        ////////////////

        ///////////
        // ZZZSI //
        ///////////

        private void btn_zzzsi_Click(object sender, EventArgs e)
        {
            map = new Bitmap(@"pictures/ZZZSI PRAZNA.png");

            // Izdelava razredov
            num_razredov = int.Parse(num_st_razredov.Value.ToString());
            IzdelavaRazredov(num_razredov);

            // Graphics Legenda razredov
            IzdelavaLegende(num_razredov, map, 900, 450);

            // Excel
            this.openFileDialog1.FileName = "*.xls";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Nastavitve kontrol
                pBar_zzzsi.Value = 0;
                btn_zzzsi.Enabled = false;
                lbl_finish_zzzsi.Visible = false;
                //Izklop Buttonov obcin in regij
                btn_regije.Enabled = false;
                btn_obcine.Enabled = false;

                xlApp = new Excel.Application();
                xlWorkbook = xlApp.Workbooks.Open(openFileDialog1.FileName);
                xlWorksheet = xlWorkbook.Sheets[1];
                xlRange = xlWorksheet.UsedRange;

                rowCount = xlRange.Rows.Count;
                colCount = xlRange.Columns.Count;

                pBar_zzzsi.Minimum = 0;
                pBar_zzzsi.Maximum = rowCount;
                barvanje = new Thread(BarvanjeZZZSI);
                barvanje.Start();
            }
        }

        public void BarvanjeZZZSI()
        {
            Barvanje(zzzsi, pBar_zzzsi, lbl_finish_zzzsi, btn_zzzsi, btn_obcine, btn_regije, "ZZZSI");
        }

        ///////////////
        // END ZZZSI //
        ///////////////

        ////////////
        // REGIJE //
        ////////////

        private void btn_regije_Click(object sender, EventArgs e)
        {
            map = new Bitmap(@"pictures/podrocja prazna.png");

            // Izdelava razredov
            num_razredov = int.Parse(num_st_razredov.Value.ToString());
            IzdelavaRazredov(num_razredov);

            // Graphics Legenda razredov
            IzdelavaLegende(num_razredov, map, 620, 270);

            // Excel
            this.openFileDialog1.FileName = "*.xls";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Nastavitve kontrol
                pBar_regije.Value = 0;
                pBar_regije.Step = 1;
                btn_regije.Enabled = false;
                lbl_finish_regije.Visible = false;
                //Izklop Buttonov obcin in regij
                btn_zzzsi.Enabled = false;
                btn_obcine.Enabled = false;

                // Excel
                xlApp = new Excel.Application();
                xlWorkbook = xlApp.Workbooks.Open(openFileDialog1.FileName);
                xlWorksheet = xlWorkbook.Sheets[1];
                xlRange = xlWorksheet.UsedRange;

                rowCount = xlRange.Rows.Count;
                colCount = xlRange.Columns.Count;

                pBar_regije.Minimum = 0;
                pBar_regije.Maximum = rowCount;
                barvanje = new Thread(BarvanjeRegij);
                barvanje.Start();
            }
        }

        public void BarvanjeRegij()
        {
            Barvanje(regija, pBar_regije, lbl_finish_regije, btn_regije, btn_obcine, btn_zzzsi, "regije");
        }

        ////////////////
        // END REGIJE //
        ////////////////


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            barvanje = new Thread(prazno);
            if (barvanje.IsAlive)
                barvanje.Abort();
            Application.Exit();
        }
        public void prazno() { }

        #region Razredi (legenda)
        private void num_st_razredov_ValueChanged(object sender, EventArgs e)
        {
            // Enablaj custom razrede
            if (num_st_razredov.Value >= 2)
            {
                lbl_c2_num.Enabled = true;
                pBox_c2.Visible = true;
                txt_c2_bot.Enabled = true;
                lbl_c2_minus.Enabled = true;
                txt_c2_top.Enabled = true;
            }
            else
            {
                lbl_c2_num.Enabled = false;
                pBox_c2.Visible = false;
                txt_c2_bot.Enabled = false;
                lbl_c2_minus.Enabled = false;
                txt_c2_top.Enabled = false;
            }

            if (num_st_razredov.Value >= 3)
            {
                lbl_c3_num.Enabled = true;
                pBox_c3.Visible = true;
                txt_c3_bot.Enabled = true;
                lbl_c3_minus.Enabled = true;
                txt_c3_top.Enabled = true;
            }
            else
            {
                lbl_c3_num.Enabled = false;
                pBox_c3.Visible = false;
                txt_c3_bot.Enabled = false;
                lbl_c3_minus.Enabled = false;
                txt_c3_top.Enabled = false;
            }

            if (num_st_razredov.Value >= 4)
            {
                lbl_c4_num.Enabled = true;
                pBox_c4.Visible = true;
                txt_c4_bot.Enabled = true;
                lbl_c4_minus.Enabled = true;
                txt_c4_top.Enabled = true;
            }
            else
            {
                lbl_c4_num.Enabled = false;
                pBox_c4.Visible = false;
                txt_c4_bot.Enabled = false;
                lbl_c4_minus.Enabled = false;
                txt_c4_top.Enabled = false;
            }

            if (num_st_razredov.Value >= 5)
            {
                lbl_c5_num.Enabled = true;
                pBox_c5.Visible = true;
                txt_c5_bot.Enabled = true;
                lbl_c5_minus.Enabled = true;
                txt_c5_top.Enabled = true;
            }
            else
            {
                lbl_c5_num.Enabled = false;
                pBox_c5.Visible = false;
                txt_c5_bot.Enabled = false;
                lbl_c5_minus.Enabled = false;
                txt_c5_top.Enabled = false;
            }

            if (num_st_razredov.Value >= 6)
            {
                lbl_c6_num.Enabled = true;
                pBox_c6.Visible = true;
                txt_c6_bot.Enabled = true;
                lbl_c6_minus.Enabled = true;
                txt_c6_top.Enabled = true;
            }
            else
            {
                lbl_c6_num.Enabled = false;
                pBox_c6.Visible = false;
                txt_c6_bot.Enabled = false;
                lbl_c6_minus.Enabled = false;
                txt_c6_top.Enabled = false;
            }

            if (num_st_razredov.Value >= 7)
            {
                lbl_c7_num.Enabled = true;
                pBox_c7.Visible = true;
                txt_c7_bot.Enabled = true;
                lbl_c7_minus.Enabled = true;
                txt_c7_top.Enabled = true;
            }
            else
            {
                lbl_c7_num.Enabled = false;
                pBox_c7.Visible = false;
                txt_c7_bot.Enabled = false;
                lbl_c7_minus.Enabled = false;
                txt_c7_top.Enabled = false;
            }

            if (num_st_razredov.Value >= 8)
            {
                lbl_c8_num.Enabled = true;
                pBox_c8.Visible = true;
                txt_c8_bot.Enabled = true;
                lbl_c8_minus.Enabled = true;
                txt_c8_top.Enabled = true;
            }
            else
            {
                lbl_c8_num.Enabled = false;
                pBox_c8.Visible = false;
                txt_c8_bot.Enabled = false;
                lbl_c8_minus.Enabled = false;
                txt_c8_top.Enabled = false;
            }

            if (num_st_razredov.Value >= 9)
            {
                lbl_c9_num.Enabled = true;
                pBox_c9.Visible = true;
                txt_c9_bot.Enabled = true;
                lbl_c9_minus.Enabled = true;
                txt_c9_top.Enabled = true;
            }
            else
            {
                lbl_c9_num.Enabled = false;
                pBox_c9.Visible = false;
                txt_c9_bot.Enabled = false;
                lbl_c9_minus.Enabled = false;
                txt_c9_top.Enabled = false;
            }

            if (num_st_razredov.Value >= 10)
            {
                lbl_c10_num.Enabled = true;
                pBox_c10.Visible = true;
                txt_c10_bot.Enabled = true;
                lbl_c10_minus.Enabled = true;
                txt_c10_top.Enabled = true;
            }
            else
            {
                lbl_c10_num.Enabled = false;
                pBox_c10.Visible = false;
                txt_c10_bot.Enabled = false;
                lbl_c10_minus.Enabled = false;
                txt_c10_top.Enabled = false;
            }
        }

        private void pBox_c1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pBox_c1.BackColor = colorDialog1.Color;
            }
        }

        private void pBox_c2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pBox_c2.BackColor = colorDialog1.Color;
            }
        }

        private void pBox_c3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pBox_c3.BackColor = colorDialog1.Color;
            }
        }

        private void pBox_c4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pBox_c4.BackColor = colorDialog1.Color;
            }
        }

        private void pBox_c5_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pBox_c5.BackColor = colorDialog1.Color;
            }
        }

        private void pBox_c6_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pBox_c6.BackColor = colorDialog1.Color;
            }
        }

        private void pBox_c7_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pBox_c7.BackColor = colorDialog1.Color;
            }
        }

        private void pBox_c8_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pBox_c8.BackColor = colorDialog1.Color;
            }
        }

        private void pBox_c9_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pBox_c9.BackColor = colorDialog1.Color;
            }
        }

        private void pBox_c10_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pBox_c10.BackColor = colorDialog1.Color;
            }
        }
        #endregion

        private void num_st_razredov_KeyUp(object sender, KeyEventArgs e)
        {
            num_st_razredov_ValueChanged(sender, e);
        }

    }
}
