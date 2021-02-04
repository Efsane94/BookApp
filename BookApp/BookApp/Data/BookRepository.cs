using BookApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Data
{
    public class BookRepository
    {
        private static List<Book> _books = null;

        static BookRepository()
        {
            _books = new List<Book>()
            {
                new Book
                {
                    Id=1,
                    Name="Ovod",
                    AuthorName="Etel Lilian Voyniç",
                    Description="<p>'Ovod' romanı bir əsrdən artıqdır ki, böyük maraqla qarşılanır və oxucularda güclü emosiyalar yaradır. Bu əsər XIX əsrin 30-cu illərində italyanların işğalçı Avstriya imperiyasına qarşı üsyanından, bu üsyanın iştirakçılarından biri olan Artur Bertonun faciəli həyatından bəhs edir. “Ovod” təxəllüsü ilə kəskin yazılar yazan bu gənc idealist sonunda öz xalqının azadlığı uğrunda canından belə keçməyə hazır olan inqilabçı Feliçe Rivarisə çevrilir. O, usanmadan, yorulmadan düşmənlə mübarizə aparır, hətta haqqında çıxarılan ölüm hökmünün dəyişdirilməsi təklifi də onu tutduğu yoldan döndərə bilmir. Bu mübariz gəncin qəlbində bir də şəxsi faciələrinin açdığı yaralar doğmalarının onu intihara sürükləyən yalanı və bütün həyatını qaraldan cavabsız sevgisi var.</p>",
                    ImageUrl="ovod.jpg",
                    CategoryId =1
                },
                new Book
                {
                    Id=2,
                    Name="Sirli Ada",
                    AuthorName="Jül Vern",
                    Description="<p>Jül Vernin yaradıcılığında “Sirli ada” romanı xüsusi yer tutur. “Sirli ada” əsəri hava şarı ilə əsirlikdən qaçmış mühəndis Sayrus Smit və onun dörd yoldaşının qəza nəticəsində kimsəsiz adaya düşmələrindən və oradakı macəralarından bəhs edir. Yazıçının kolonistlər adlandırdığı bu insanlar adadakı həyatlarından razıdırlar. Bu azad insanlar (azad yaşamağa layiq insanlar) Riçmondda quldarların əhatəsində qalmaqdansa, adada yaşamağı üstün tuturlar. Bu isə Amerikada vətəndaş müharibəsinin böyük dəhşətlərindən xəbər verirdi.</p>",
                    ImageUrl="sirliada.jpg",
                    CategoryId =2
                },
                new Book
                {
                    Id=3,
                    Name="Çərpələng uçuran",
                    AuthorName="Xalid Hüseyni",
                    Description="<p>Xalid Hüseyninin bu debüt romanını artıq yeni əsrin baş romanı, müəllifini isə canlı klassik hesab eləyirlər. ‘Çərpaləng uçuran’ bu an yaşanan müstəmləkəçilik sonrası yeni müstəmləkəçilik (neokolonial), qloballaşma, mədəniyyətlərarası savaş, vətəndaş müharibəsi və miqrasiya kimi mövzulara bədii baxış açısı gətirir. Bundan əlavə, müəllif xatirələr, aydınlatma, cinsi ilişkilər kimi qavrayışlara da toxunur. Kitab sözün əsl mənasında dostluq, sədaqət, xəyanət, günahlardan arınma haqqındadır və Xalid Hüseyninin bu incə, canayaxın, ironik və sözün yaxşı mənasında sentimental romanı doymadan və göz çəkə bilmədən baxdıqca baxılan möhtəşəm bir rəsm əsərinə bənzəyir. Müəllif, əsərin adından da göründüyü kimi, Əfqan uşaqlarının çərpələng uçurmaq əyləncəsini yada salır. Bu yarışlardan birində əsərin qəhrəmanlarından biri – Həzara (Xəzər) oğlu Həsənin başına dəhşətli hadisə gəlir, o bu hadisəyə dostu bildiyi Əmirin naminə razı olur, ancaq onu kədərləndirmək haqda düşünmür. Həmin dost isə, bu dəhşəti kənardan görür, lakin gizlənib səsini çıxarmır. Bununla da faciə böyüyür, getdikcə davam edir. Öz qorxaqlığından çıldıran Əmir ayılanda artıq gec olduğunu düşünür. Haçansa gec olurmu?</p>",
                    ImageUrl="cerpeleng.jpg",
                    CategoryId =1
                },
                new Book
                {
                    Id=4,
                    Name="Hava şarında beş həftə",
                    AuthorName="Jül Vern",
                    Description="<p>Məşhur fransız yazıçısı Jül Vern dünya ədəbiyyatı tarixində elmi-fantastik romanın banilərindən biridir. Onun ilk elmi-fantastik romanı da “Hava şarında beş həftə” əsəridir. Romandakı hadisələr baş qəhrəman cənab Ferqyusonun Afrikanı başdan-ayağa kəşf etmək istəyi ilə başlayır. Cənab Ferqyusonadək bir çox səyyahlar da bu yola çıxmışdılar. Ancaq bəziləri bu yolda həlak olmuş, bəziləri də müxtəlif çətinliklərə görə geri qayıtmışdı. Cənab Ferqyuson və iki dostu bu dəfə sələflərinin yarımçıq qalan işini başa çatdırmaq istəyir və Afrikanın şərq sahilindən qərb sahilinədək səyahət etmək qərarına gəlirlər. Özü də hava şarı ilə. Əsərdə bu səyahət ərzində cənab Ferqyuson və dostlarının başlarına gələn maraqlı sərgüzəştlərin şahidi olacaqsınız…</p>",
                    ImageUrl="havasari.jpg",
                    CategoryId =2
                },
                new Book
                {
                    Id=5,
                    Name="Mən, robot",
                    AuthorName="İsaac Asimov",
                    Description="<p>Ayzek Azimov əsərlərini elmi fantastika janrında qələmə alan dünyanın üç ən böyük yazıçısından biridir. Yəhudi əsilli yazıçı uzun müddət ABŞ-ın önəmli universitetlərində dərs deyib. Lakin o, sadəcə biokimya professoru olmaqla kifayətlənməyib, bütün ömrünü elmin kütləviləşməsinə həsr edib. 500-ə qədər əsərin müəllifidir və yaratdığı, ilk dəfə istifadə etdiyi terminlər sonradan dünya elmində işləklik qazanıb. “Mən, robot” müəllifin ən çox sevilən və dünyanın müxtəlif dillərinə tərcümə edilən kitablarındandır. Kitaba daxil olan hekayələr müstəqil süjet xətti ilə seçilsələr də, “robot və insan” qarşılaşdırmasına müxtəlif rakurslardan yanaşma, tanış qəhrəmanların üzləşdiyi çətin situasiyaların əvəzlənməsi baxımından sıx bağlıdırlar. A.Azimov Robotexnikanın Üç Əsas Qanununa ilk dəfə bu hekayələr toplusunda yer verib. Sonradan bu üç konsepsiya böyük populyarlıq qazanıb və onun digər əsərlərində də tez-tez yer alıb. Kitabı maraqlı edən digər bir məqam da dünyanın elmi gələcəyi ilə bağlı verilən proqnozların hekayələr fonunda bugünümüzlə necə real səsləşməsidir. Kitabın orijinalı 1950-ci ildə çapdan çıxıb, Azərbaycan dilində isə ilk dəfədir oxuculara təqdim olunur.</p>",
                    ImageUrl="menrobot.jpg",
                    CategoryId =2
                },
                new Book
                {
                    Id=6,
                    Name="Da Vinçi kodu ",
                    AuthorName=" Dan Brown",
                    Description="<p>Harvard Universitetinin dini simvolizm üzrə professoru Robert Lenqdon Parisə mühazirə söyləməyə gəlib. Mühazirə qurtarandan sonra o bütün dünyada məşhur olan Luvr muzeyinin hörmətli kuratoru ilə də görüşməyi planlaşdırır. Amma kurator görüşə gəlmir. Həmin gecə Lenqdonu yerli polisin nümayəndələri oyadır, ona deyirlər ki, kuratoru qətlə yetiriblər, onu Luvr muzeyinə, cinayət baş verən yerə aparırlar. Robert cinayət yerində çaşdırıcı kodlarla rastlaşır. Polislər kuratorun qətlində Robertdən şübhələnir. Robert isə kuratorun nəvəsi, kriptologist Sofinin köməyilə çaşdırıcı kodları açmağa çalışır. Əgər onlar bu kodu vaxtında aça bilməsələr qədim bir həqiqət əbədi olaraq açılmamış qalacaq.</p>",
                    ImageUrl="davincikodu.jpg",
                    CategoryId =3
                },
                new Book
                {
                    Id=7,
                    Name="Şüphenin İzinde",
                    AuthorName="Sherlock Holmes",
                    Description="<p>Şüphenin İzinde – Sherlock Holmes kitabı Artur Konan Doyl tərəfindən yazılmışdır. Bu kitabın qiyməti tələbə endirimi ilə 7.49 AZN'ə satılır. Tələbə endirimi ilə Şüphenin İzinde – Sherlock Holmes kitabını almaq üçün mağazaya yaxınlaşmaq lazımdır.</p>",
                    ImageUrl="supheninizinide.jpg",
                    CategoryId =3
                },
                new Book
                {
                    Id=8,
                    Name="Dəfinələr adası",
                    AuthorName=" Robert Louis Stevenson",
                    Description="<p>“Dəfinələr adası” yüz ildən artıdır ki, ən qiymətli macəra romanlarından biri kimi dönə-dönə dünyanın müxtəlif dillərinə tərcümə edilərək oxunur.Tropik adalar, məchul işarəli xəzinə xəritələri, bir gözü kor, bir əli xəncərli, çiynindəki tutuquşu ilə yaddaşımızda canlanan dəniz döyüşçüsü anlayışlarının yaranmasında “Dəfinələr adası” romanının böyük təsiri olmuşdur. Baş qəhrəman Cim Hokins həmişə hərəkətdə olan, narahat düşüncələr və duyğular axarına düşmüş bir gəncdir. O, yoxsul mənəviyyatlı, iradəsiz kişilərə nifrət edir.Əsərdə həmçinin qarşıya çıxan hər cür maneəni dəf etməyə qa­dir, gəmi xidmətində nizam-intizamı əsas şərt sayan tələbkar kapitan Smollet, quldurların qəzəbinə düçar olduğu üçün üç il Dəfinələr ada­sında tənha həyat sürmüş cəsur dənizçi Ben Hann, kimliyindən asılı ol­mayaraq, ehtiyacı olan hər kəsə tibbi yardım göstərərək öz insani borcunu yerinə yetirən doktor Livsi kimi maraqlı obrazlar da var.</p>",
                    ImageUrl="defineleradasi.jpg",
                    CategoryId =4
                },
                new Book
                {
                    Id=9,
                    Name="Mauqli",
                    AuthorName="Redyard Kipling",
                    Description="<p>Canavar ailəsi cəngəlliyə düşmüş balaca Mauqlini qəddar Şirxanın əlindən xilas edib böyütməyə başladı. Oğlan çox cəsarətli idi, həmişə canavaraların balaları ilə oynayırdı. Bir gün Şirxan onu görməyə gəlib: ‘Bu mənim ovumdur!’ – dedi və hər şey də elə bundan sonra başladı…</p>",
                    ImageUrl="Mauqli.jpg",
                    CategoryId =4
                },
                new Book
                {
                    Id=10,
                    Name="Çalıquşu",
                    AuthorName="Reşat Nuri Güntekin",
                    Description="<p>Rəsad Nuri Güntəkin 1889-cu ildə İstanbul səhərində anadan olub. Əsərləri dünyanın bir çox xalqlarının dillərinə çevrilərək genis oxucu auditoriyası qazanıb. Yazıçının əsərlərinin ssenarisi əsasında çəkilmis filmlər isə həm Türkiyədə, həmçinin göstərildiyi bütün ölkələrdə tamasaçıların rəğbətini qazanıb, ən böyük reytinqli filmlərə çevrilib. İlk dəfə 1922-ci ildə nəsr olunan «Çalıqusu» romanında müəllif əsərin qəhrəmanı Fəridənin – Çalıqusunun simasında çətin və məsəqqətli həyat tərzinə baxmayaraq, öz məhəbbətinə sədaqətini qoruyub saxlayan əsil türk qadınının obrazını ustalıqla qələmə almısdır. Romanda çoxlu tarixi məqamlar da var…</p>",
                    ImageUrl="Caliqusu.jpg",
                    CategoryId =5
                },
                new Book
                {
                    Id=11,
                    Name="Məni heç vaxt tərk etmə",
                    AuthorName="Kazuo İşiquro",
                    Description="<p>“Məni heç vaxt tərk etmə” romanı təxminən 30 yaşlarında olan Keti adlı gənc qadının xatirələri əsasında yazılıb. Onun uşaqlığı və yeniyetməliyi Heylşemdəki qeyri-adi internat məktəbində keçib. Hadisələr XX əsrin sonlarında, insanların orqan transplantasiyası əməliyyatları üçün canlı donor kimi klonlaşdırılıb yetişdirilməsinin geniş vüsət aldığı illərdə baş verir. Keti və onun internatdakı dostları məhz belə donor rolunda çıxış etməyə əla namizədlər sayılır. Onlar donor olana qədər müəyyən müddət “köməkçi” rolunda çıxış etməyə, artıq donor olmuş adamların qayğısına qalmağa məhkumdur. Adi insan həyatının ümumiləşdirilmiş metaforası kimi düşünülən romanda məhəbbət, tale, ruh azadlığı məsələləri ön plana çəkilib.Kitab geniş oxucu kütləsi üçün nəzərdə tutulub.</p>",
                    ImageUrl="menihecvaxt.jpg",
                    CategoryId =5
                },
                new Book
                {
                    Id=12,
                    Name="Mart Bənövşələri",
                    AuthorName="Sarah Jio",
                    Description="<p>«Mart bənövşələri» müasir Amerika yazıçısı Sarah Jionun ən çox oxunan kitablarından biridir. Romanda böyük və əbədi məhəbbətdən söz açılır. Şəxsi həyatında uğursuzluğa uğrayan yazıçı qız əsəblərini dincəltmək üçün xalasının olduğu adaya gedir və burda yataq otağından bir gündəlik tapır. Bu gündəliyin sayəsində yazıçı on illərlə gizlin qalan ailə sirlərinin üstünü açır. Bununla da onun sevgi, həyəcan, təlatüm dolu əsl həyatı başlayır.</p>",
                    ImageUrl="mart.jpg",
                    CategoryId =5
                },

            };
            
        }
        public static List<Book> Books
        {
            get
            {
                return _books;
            }
        }
        public static void AddBook(Book entity)
        {
            _books.Add(entity);  
        }

        public static Book GetById(int id)
        {
            return _books.FirstOrDefault(i => i.Id == id);
        }
    }
}


