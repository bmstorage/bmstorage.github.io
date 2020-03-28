using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BMStorage.Data;
using System;
using System.Linq;


namespace BMStorage.Models
{
   public static class SeedData
   {
      public static void Initialize(IServiceProvider serviceProvider)
      {
         using (var context = new BMStorageContext(
             serviceProvider.GetRequiredService<
                 DbContextOptions<BMStorageContext>>()))
         {
            // // Look for any movies.
            // if (context.Contract.Any())
            // {
            //    return;   // DB has been seeded
            // }

            context.UserType.AddRange(
               new UserType
               {
                  UserTypeID = 1,
                  UserTypeName = "Owner"
               },
               new UserType
               {
                  UserTypeID = 2,
                  UserTypeName = "Employee"
               },
               new UserType
               {
                  UserTypeID = 3,
                  UserTypeName = "Tenant"
               }
            );

            context.User.AddRange(
               new User
               {
                  UserID = 1,
                  UserTypeID = 1,
                  GateCode = "#1234568",
                  FirstName = "Troy ",
                  LastName = "Mortensen",
                  StreetAddress = "7th Avenue",
                  Email = "darian45@hayes.com",
                  Phone = "(529) 843-8255",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 2,
                  UserTypeID = 1,
                  GateCode = "#1234569",
                  FirstName = "Robin",
                  LastName = "Mortensen",
                  StreetAddress = "Ashley Court",
                  Email = "estel91@yahoo.com",
                  Phone = "(285) 285-9701",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 3,
                  UserTypeID = 2,
                  GateCode = "#1234570",
                  FirstName = "Ryan",
                  LastName = "Harris ",
                  StreetAddress = "Chestnut Avenue",
                  Email = "alfonzo39@crist.biz",
                  Phone = "(401) 740-9127",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 4,
                  UserTypeID = 2,
                  GateCode = "#1234571",
                  FirstName = "Ryan",
                  LastName = "Cross",
                  StreetAddress = "Beech Street",
                  Email = "zion.kemmer@haag.com",
                  Phone = "(903) 656-1199",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 5,
                  UserTypeID = 3,
                  GateCode = "#1234572",
                  FirstName = "Robert",
                  LastName = "Williams ",
                  StreetAddress = "Willow Drive",
                  Email = "marks.jessica@yahoo.com",
                  Phone = "(988) 306-1491",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 6,
                  UserTypeID = 3,
                  GateCode = "#1234573",
                  FirstName = "Michael",
                  LastName = "Jones ",
                  StreetAddress = "Bay Street",
                  Email = "june42@pagac.com",
                  Phone = "(314) 307-6256",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 7,
                  UserTypeID = 3,
                  GateCode = "#1234574",
                  FirstName = "William",
                  LastName = "Brown ",
                  StreetAddress = "1st Avenue",
                  Email = "jolie85@kuhlman.com",
                  Phone = "(408) 908-1165",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 8,
                  UserTypeID = 3,
                  GateCode = "#1234575",
                  FirstName = "David",
                  LastName = "Davis ",
                  StreetAddress = "Charles Street",
                  Email = "reva.miller@hotmail.com",
                  Phone = "(614) 488-9114",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 9,
                  UserTypeID = 3,
                  GateCode = "#1234576",
                  FirstName = "Richard",
                  LastName = "Miller ",
                  StreetAddress = "Roosevelt Avenue",
                  Email = "moberbrunner@marquardt.com",
                  Phone = "(745) 286-3362",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 10,
                  UserTypeID = 3,
                  GateCode = "#1234577",
                  FirstName = "Joseph",
                  LastName = "Wilson ",
                  StreetAddress = "Old York Road",
                  Email = "gulgowski.kaya@hotmail.com",
                  Phone = "(626) 446-2869",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 11,
                  UserTypeID = 3,
                  GateCode = "#1234578",
                  FirstName = "Thomas",
                  LastName = "Moore ",
                  StreetAddress = "Harrison Street",
                  Email = "ukshlerin@crooks.com",
                  Phone = "(886) 512-4682",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 12,
                  UserTypeID = 3,
                  GateCode = "#1234579",
                  FirstName = "Charles",
                  LastName = "Taylor ",
                  StreetAddress = "Manor Drive",
                  Email = "celine92@gmail.com",
                  Phone = "(642) 883-4169",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 13,
                  UserTypeID = 3,
                  GateCode = "#1234580",
                  FirstName = "Christopher",
                  LastName = "Anderson ",
                  StreetAddress = "Madison Street",
                  Email = "mitchell.jensen@torphy.com",
                  Phone = "(667) 314-3885",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 14,
                  UserTypeID = 3,
                  GateCode = "#1234581",
                  FirstName = "Daniel",
                  LastName = "Thomas ",
                  StreetAddress = "Parker Street",
                  Email = "ucorwin@lakin.net",
                  Phone = "(276) 950-6582",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 15,
                  UserTypeID = 3,
                  GateCode = "#1234582",
                  FirstName = "Matthew",
                  LastName = "Jackson ",
                  StreetAddress = "Sherwood Drive",
                  Email = "emelia.wisozk@wisozk.com",
                  Phone = "(730) 630-6822",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 16,
                  UserTypeID = 3,
                  GateCode = "#1234583",
                  FirstName = "Anthony",
                  LastName = "White ",
                  StreetAddress = "Cobblestone Court",
                  Email = "heaney.amparo@bashirian.com",
                  Phone = "(264) 329-7978",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 17,
                  UserTypeID = 3,
                  GateCode = "#1234584",
                  FirstName = "Donald",
                  LastName = "Harris ",
                  StreetAddress = "Church Street",
                  Email = "graham.ciara@yahoo.com",
                  Phone = "(638) 913-5361",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 18,
                  UserTypeID = 3,
                  GateCode = "#1234585",
                  FirstName = "Mark",
                  LastName = "Martin ",
                  StreetAddress = "High Street",
                  Email = "qbauch@hotmail.com",
                  Phone = "(931) 376-0137",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 19,
                  UserTypeID = 3,
                  GateCode = "#1234586",
                  FirstName = "Paul",
                  LastName = "Thompson ",
                  StreetAddress = "Myrtle Street",
                  Email = "nbartoletti@stracke.net",
                  Phone = "(894) 770-4409",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 20,
                  UserTypeID = 3,
                  GateCode = "#1234587",
                  FirstName = "Steven",
                  LastName = "Garcia ",
                  StreetAddress = "Summit Street",
                  Email = "denesik.zetta@hotmail.com",
                  Phone = "(356) 705-5724",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 21,
                  UserTypeID = 3,
                  GateCode = "#1234588",
                  FirstName = "Andrew",
                  LastName = "Martinez ",
                  StreetAddress = "Heather Lane",
                  Email = "ideckow@hotmail.com",
                  Phone = "(966) 646-6421",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 22,
                  UserTypeID = 3,
                  GateCode = "#1234589",
                  FirstName = "Kenneth",
                  LastName = "Robinson ",
                  StreetAddress = "Buttonwood Drive",
                  Email = "hoyt88@gmail.com",
                  Phone = "(433) 856-3323",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 23,
                  UserTypeID = 3,
                  GateCode = "#1234590",
                  FirstName = "Joshua",
                  LastName = "Clark ",
                  StreetAddress = "Lawrence Street",
                  Email = "rodriguez.elwin@medhurst.com",
                  Phone = "(246) 685-3429",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 24,
                  UserTypeID = 3,
                  GateCode = "#1234591",
                  FirstName = "George",
                  LastName = "Rodriguez ",
                  StreetAddress = "Magnolia Drive",
                  Email = "bart28@gmail.com",
                  Phone = "(355) 901-5786",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 25,
                  UserTypeID = 3,
                  GateCode = "#1234592",
                  FirstName = "Kevin",
                  LastName = "Lewis ",
                  StreetAddress = "Arlington Avenue",
                  Email = "thettinger@shanahan.com",
                  Phone = "(377) 301-4350",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 26,
                  UserTypeID = 3,
                  GateCode = "#1234593",
                  FirstName = "Brian",
                  LastName = "Lee ",
                  StreetAddress = "Heritage Drive",
                  Email = "jettie.parker@kerluke.com",
                  Phone = "(983) 293-7362",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 27,
                  UserTypeID = 3,
                  GateCode = "#1234594",
                  FirstName = "Edward",
                  LastName = "Walker ",
                  StreetAddress = "3rd Avenue",
                  Email = "ostamm@hotmail.com",
                  Phone = "(253) 677-8238",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 28,
                  UserTypeID = 3,
                  GateCode = "#1234595",
                  FirstName = "Ronald",
                  LastName = "Hall ",
                  StreetAddress = "Laurel Drive",
                  Email = "jamel03@hotmail.com",
                  Phone = "(363) 694-3872",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 29,
                  UserTypeID = 3,
                  GateCode = "#1234596",
                  FirstName = "Timothy",
                  LastName = "Allen ",
                  StreetAddress = "B Street",
                  Email = "junius22@ullrich.info",
                  Phone = "(466) 984-2480",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 30,
                  UserTypeID = 3,
                  GateCode = "#1234597",
                  FirstName = "Jason",
                  LastName = "Young ",
                  StreetAddress = "Mulberry Court",
                  Email = "yesenia24@yahoo.com",
                  Phone = "(690) 896-4303",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 31,
                  UserTypeID = 3,
                  GateCode = "#1234598",
                  FirstName = "Jeffrey",
                  LastName = "Hernandez ",
                  StreetAddress = "State Street East",
                  Email = "abraham93@witting.com",
                  Phone = "(643) 525-9476",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 32,
                  UserTypeID = 3,
                  GateCode = "#1234599",
                  FirstName = "Ryan",
                  LastName = "King ",
                  StreetAddress = "Pheasant Run",
                  Email = "veda05@rutherford.com",
                  Phone = "(769) 528-5967",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 33,
                  UserTypeID = 3,
                  GateCode = "#1234600",
                  FirstName = "Jacob",
                  LastName = "Wright ",
                  StreetAddress = "Cedar Avenue",
                  Email = "corkery.pinkie@parker.com",
                  Phone = "(882) 994-9899",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 34,
                  UserTypeID = 3,
                  GateCode = "#1234601",
                  FirstName = "Gary",
                  LastName = "Lopez ",
                  StreetAddress = "Franklin Court",
                  Email = "adolfo.dickinson@gmail.com",
                  Phone = "(812) 899-0970",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 35,
                  UserTypeID = 3,
                  GateCode = "#1234602",
                  FirstName = "Nicholas",
                  LastName = "Hill ",
                  StreetAddress = "Virginia Avenue",
                  Email = "jaskolski.kaitlyn@quigley.net",
                  Phone = "(370) 728-6715",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 36,
                  UserTypeID = 3,
                  GateCode = "#1234603",
                  FirstName = "Eric",
                  LastName = "Scott ",
                  StreetAddress = "Chapel Street",
                  Email = "aniyah27@wehner.info",
                  Phone = "(921) 356-0929",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 37,
                  UserTypeID = 3,
                  GateCode = "#1234604",
                  FirstName = "Stephen",
                  LastName = "Green ",
                  StreetAddress = "Buckingham Drive",
                  Email = "rhett.greenfelder@kirlin.org",
                  Phone = "(354) 319-7623",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 38,
                  UserTypeID = 3,
                  GateCode = "#1234605",
                  FirstName = "Jonathan",
                  LastName = "Adams ",
                  StreetAddress = "Summit Avenue",
                  Email = "jake77@cole.biz",
                  Phone = "(608) 523-7789",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 39,
                  UserTypeID = 3,
                  GateCode = "#1234606",
                  FirstName = "Larry",
                  LastName = "Baker ",
                  StreetAddress = "Park Avenue",
                  Email = "paxton.vandervort@roberts.info",
                  Phone = "(942) 734-0461",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 40,
                  UserTypeID = 3,
                  GateCode = "#1234607",
                  FirstName = "Justin",
                  LastName = "Gonzalez ",
                  StreetAddress = "Pine Street",
                  Email = "mckenzie.wilderman@gmail.com",
                  Phone = "(505) 673-4412",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 41,
                  UserTypeID = 3,
                  GateCode = "#1234608",
                  FirstName = "Scott",
                  LastName = "Nelson ",
                  StreetAddress = "Mulberry Lane",
                  Email = "tboyer@lockman.com",
                  Phone = "(251) 573-0976",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 42,
                  UserTypeID = 3,
                  GateCode = "#1234609",
                  FirstName = "Brandon",
                  LastName = "Carter ",
                  StreetAddress = "3rd Street West",
                  Email = "norris78@daniel.net",
                  Phone = "(305) 688-7567",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 43,
                  UserTypeID = 3,
                  GateCode = "#1234610",
                  FirstName = "Frank",
                  LastName = "Mitchell ",
                  StreetAddress = "Lafayette Street",
                  Email = "rodriguez.vallie@gmail.com",
                  Phone = "(594) 377-2850",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 44,
                  UserTypeID = 3,
                  GateCode = "#1234611",
                  FirstName = "Benjamin",
                  LastName = "Perez ",
                  StreetAddress = "Overlook Circle",
                  Email = "aidan.nikolaus@gmail.com",
                  Phone = "(872) 744-9854",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 45,
                  UserTypeID = 3,
                  GateCode = "#1234612",
                  FirstName = "Gregory",
                  LastName = "Roberts ",
                  StreetAddress = "Devon Court",
                  Email = "kassulke.robert@thompson.com",
                  Phone = "(424) 839-9339",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 46,
                  UserTypeID = 3,
                  GateCode = "#1234613",
                  FirstName = "Patrick",
                  LastName = "Turner ",
                  StreetAddress = "Wall Street",
                  Email = "chelsey.rosenbaum@yahoo.com",
                  Phone = "(960) 905-8473",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 47,
                  UserTypeID = 3,
                  GateCode = "#1234614",
                  FirstName = "Alexander",
                  LastName = "Phillips ",
                  StreetAddress = "Jackson Avenue",
                  Email = "lilliana.reilly@turcotte.info",
                  Phone = "(649) 547-2312",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 48,
                  UserTypeID = 3,
                  GateCode = "#1234615",
                  FirstName = "Jack",
                  LastName = "Campbell ",
                  StreetAddress = "Locust Street",
                  Email = "miles.hoeger@gmail.com",
                  Phone = "(366) 363-0437",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 49,
                  UserTypeID = 3,
                  GateCode = "#1234616",
                  FirstName = "Dennis",
                  LastName = "Parker ",
                  StreetAddress = "Hillcrest Avenue",
                  Email = "caden55@gmail.com",
                  Phone = "(920) 664-6551",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 50,
                  UserTypeID = 3,
                  GateCode = "#1234617",
                  FirstName = "Jerry",
                  LastName = "Evans ",
                  StreetAddress = "Railroad Street",
                  Email = "vwehner@gmail.com",
                  Phone = "(812) 826-3947",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 51,
                  UserTypeID = 3,
                  GateCode = "#1234618",
                  FirstName = "Tyler",
                  LastName = "Edwards ",
                  StreetAddress = "Jones Street",
                  Email = "cormier.dixie@gmail.com",
                  Phone = "(352) 614-5587",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 52,
                  UserTypeID = 3,
                  GateCode = "#1234619",
                  FirstName = "Aaron",
                  LastName = "Collins ",
                  StreetAddress = "Andover Court",
                  Email = "shemar.hand@kuphal.org",
                  Phone = "(261) 230-7851",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 53,
                  UserTypeID = 3,
                  GateCode = "#1234620",
                  FirstName = "Jose",
                  LastName = "Stewart ",
                  StreetAddress = "Augusta Drive",
                  Email = "brandt48@macejkovic.info",
                  Phone = "(380) 661-1262",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 54,
                  UserTypeID = 3,
                  GateCode = "#1234621",
                  FirstName = "Henry",
                  LastName = "Sanchez ",
                  StreetAddress = "13th Street",
                  Email = "luella33@gmail.com",
                  Phone = "(361) 782-3242",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 55,
                  UserTypeID = 3,
                  GateCode = "#1234622",
                  FirstName = "Douglas",
                  LastName = "Morris ",
                  StreetAddress = "Oxford Court",
                  Email = "americo18@heathcote.org",
                  Phone = "(301) 202-6137",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 56,
                  UserTypeID = 3,
                  GateCode = "#1234623",
                  FirstName = "Adam",
                  LastName = "Rogers ",
                  StreetAddress = "New Street",
                  Email = "bradtke.tod@glover.info",
                  Phone = "(778) 483-1998",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 57,
                  UserTypeID = 3,
                  GateCode = "#1234624",
                  FirstName = "Peter",
                  LastName = "Reed ",
                  StreetAddress = "Fieldstone Drive",
                  Email = "isidro88@bayer.com",
                  Phone = "(664) 787-7073",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 58,
                  UserTypeID = 3,
                  GateCode = "#1234625",
                  FirstName = "Nathan",
                  LastName = "Cook ",
                  StreetAddress = "North Street",
                  Email = "kassulke.madonna@hotmail.com",
                  Phone = "(204) 478-6176",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 59,
                  UserTypeID = 3,
                  GateCode = "#1234626",
                  FirstName = "Zachary",
                  LastName = "Morgan ",
                  StreetAddress = "Main Street",
                  Email = "yrunolfsdottir@hotmail.com",
                  Phone = "(423) 889-1573",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 60,
                  UserTypeID = 3,
                  GateCode = "#1234627",
                  FirstName = "Walter",
                  LastName = "Bell ",
                  StreetAddress = "Woodland Avenue",
                  Email = "dubuque.margarete@yahoo.com",
                  Phone = "(442) 372-7921",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 61,
                  UserTypeID = 3,
                  GateCode = "#1234628",
                  FirstName = "Kyle",
                  LastName = "Murphy ",
                  StreetAddress = "Glenwood Avenue",
                  Email = "della99@gmail.com",
                  Phone = "(350) 700-1679",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 62,
                  UserTypeID = 3,
                  GateCode = "#1234629",
                  FirstName = "Harold",
                  LastName = "Bailey ",
                  StreetAddress = "Race Street",
                  Email = "sally.hamill@yahoo.com",
                  Phone = "(768) 334-9085",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 63,
                  UserTypeID = 3,
                  GateCode = "#1234630",
                  FirstName = "Carl",
                  LastName = "Rivera ",
                  StreetAddress = "Elm Avenue",
                  Email = "hoconner@kovacek.biz",
                  Phone = "(779) 359-9033",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 64,
                  UserTypeID = 3,
                  GateCode = "#1234631",
                  FirstName = "Jeremy",
                  LastName = "Cooper ",
                  StreetAddress = "Cleveland Avenue",
                  Email = "lindgren.lizeth@gmail.com",
                  Phone = "(662) 229-4328",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 65,
                  UserTypeID = 3,
                  GateCode = "#1234632",
                  FirstName = "Keith",
                  LastName = "Richardson",
                  StreetAddress = "Lantern Lane",
                  Email = "heathcote.aleen@hotmail.com",
                  Phone = "(706) 869-4762",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 66,
                  UserTypeID = 3,
                  GateCode = "#1234633",
                  FirstName = "Roger",
                  LastName = "Cox ",
                  StreetAddress = "Cypress Court",
                  Email = "kelton.johnson@gmail.com",
                  Phone = "(447) 869-4029",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 67,
                  UserTypeID = 3,
                  GateCode = "#1234634",
                  FirstName = "Gerald",
                  LastName = "Howard ",
                  StreetAddress = "Carriage Drive",
                  Email = "rutherford.kaleb@gmail.com",
                  Phone = "(442) 828-8828",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 68,
                  UserTypeID = 3,
                  GateCode = "#1234635",
                  FirstName = "Ethan",
                  LastName = "Ward ",
                  StreetAddress = "Route 5",
                  Email = "vcrist@gulgowski.com",
                  Phone = "(762) 449-5349",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 69,
                  UserTypeID = 3,
                  GateCode = "#1234636",
                  FirstName = "Arthur",
                  LastName = "Torres ",
                  StreetAddress = "6th Street North",
                  Email = "green.lowe@hotmail.com",
                  Phone = "(969) 343-4045",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 70,
                  UserTypeID = 3,
                  GateCode = "#1234637",
                  FirstName = "Terry",
                  LastName = "Peterson ",
                  StreetAddress = "Grant Avenue",
                  Email = "carroll.jayce@yahoo.com",
                  Phone = "(345) 943-0028",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 71,
                  UserTypeID = 3,
                  GateCode = "#1234638",
                  FirstName = "Christian",
                  LastName = "Gray ",
                  StreetAddress = "Wood Street",
                  Email = "vdeckow@gmail.com",
                  Phone = "(455) 276-3589",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 72,
                  UserTypeID = 3,
                  GateCode = "#1234639",
                  FirstName = "Sean",
                  LastName = "Ramirez ",
                  StreetAddress = "Orchard Avenue",
                  Email = "neichmann@hotmail.com",
                  Phone = "(289) 438-0939",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 73,
                  UserTypeID = 3,
                  GateCode = "#1234640",
                  FirstName = "Lawrence",
                  LastName = "James ",
                  StreetAddress = "Green Street",
                  Email = "kelly39@klocko.com",
                  Phone = "(992) 448-4283",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 74,
                  UserTypeID = 3,
                  GateCode = "#1234641",
                  FirstName = "Austin",
                  LastName = "Watson ",
                  StreetAddress = "York Street",
                  Email = "ulehner@miller.com",
                  Phone = "(732) 910-7514",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 75,
                  UserTypeID = 3,
                  GateCode = "#1234642",
                  FirstName = "Joe",
                  LastName = "Brooks ",
                  StreetAddress = "2nd Street East",
                  Email = "dessie.ortiz@gusikowski.net",
                  Phone = "(436) 599-8157",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 76,
                  UserTypeID = 3,
                  GateCode = "#1234643",
                  FirstName = "Noah",
                  LastName = "Kelly ",
                  StreetAddress = "Dogwood Lane",
                  Email = "amaya29@heathcote.com",
                  Phone = "(207) 352-4156",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 77,
                  UserTypeID = 3,
                  GateCode = "#1234644",
                  FirstName = "Jesse",
                  LastName = "Sanders ",
                  StreetAddress = "Monroe Street",
                  Email = "muriel.mann@breitenberg.info",
                  Phone = "(274) 481-1298",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 78,
                  UserTypeID = 3,
                  GateCode = "#1234645",
                  FirstName = "Albert",
                  LastName = "Price",
                  StreetAddress = "Bank Street",
                  Email = "abigail.mills@braun.org",
                  Phone = "(840) 982-0682",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 79,
                  UserTypeID = 3,
                  GateCode = "#1234646",
                  FirstName = "Bryan",
                  LastName = "Bennett ",
                  StreetAddress = "Washington Avenue",
                  Email = "lamont17@brekke.com",
                  Phone = "(554) 977-4955",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 80,
                  UserTypeID = 3,
                  GateCode = "#1234647",
                  FirstName = "Billy",
                  LastName = "Wood ",
                  StreetAddress = "Amherst Street",
                  Email = "jannie14@steuber.com",
                  Phone = "(823) 296-1108",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 81,
                  UserTypeID = 3,
                  GateCode = "#1234648",
                  FirstName = "Bruce",
                  LastName = "Barnes ",
                  StreetAddress = "Route 41",
                  Email = "chloe55@yahoo.com",
                  Phone = "(915) 423-5213",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 82,
                  UserTypeID = 3,
                  GateCode = "#1234649",
                  FirstName = "Willie",
                  LastName = "Ross ",
                  StreetAddress = "Route 6",
                  Email = "lhansen@gmail.com",
                  Phone = "(823) 753-5309",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 83,
                  UserTypeID = 3,
                  GateCode = "#1234650",
                  FirstName = "Jordan",
                  LastName = "Henderson ",
                  StreetAddress = "Penn Street",
                  Email = "giovanni88@hotmail.com",
                  Phone = "(623) 253-4885",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 84,
                  UserTypeID = 3,
                  GateCode = "#1234651",
                  FirstName = "Dylan",
                  LastName = "Coleman ",
                  StreetAddress = "Park Drive",
                  Email = "kessler.marcelino@gmail.com",
                  Phone = "(241) 239-5034",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 85,
                  UserTypeID = 3,
                  GateCode = "#1234652",
                  FirstName = "Alan",
                  LastName = "Jenkins ",
                  StreetAddress = "Sunset Avenue",
                  Email = "alvah.pacocha@hotmail.com",
                  Phone = "(591) 971-5188",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 86,
                  UserTypeID = 3,
                  GateCode = "#1234653",
                  FirstName = "Ralph",
                  LastName = "Perry ",
                  StreetAddress = "Hawthorne Avenue",
                  Email = "pbatz@hotmail.com",
                  Phone = "(601) 617-2984",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 87,
                  UserTypeID = 3,
                  GateCode = "#1234654",
                  FirstName = "Gabriel",
                  LastName = "Powell ",
                  StreetAddress = "Maple Street",
                  Email = "shartmann@wolff.com",
                  Phone = "(561) 753-9609",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 88,
                  UserTypeID = 3,
                  GateCode = "#1234655",
                  FirstName = "Roy",
                  LastName = "Long ",
                  StreetAddress = "Lafayette Avenue",
                  Email = "ekoss@effertz.biz",
                  Phone = "(582) 213-0674",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653",

               },
               new User
               {
                  UserID = 89,
                  UserTypeID = 3,
                  GateCode = "#1234656",
                  FirstName = "Juan",
                  LastName = "Patterson ",
                  StreetAddress = "4th Avenue",
                  Email = "isabel.monahan@bailey.com",
                  Phone = "(879) 964-3220",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 90,
                  UserTypeID = 3,
                  GateCode = "#1234657",
                  FirstName = "Wayne",
                  LastName = "Hughes ",
                  StreetAddress = "Market Street",
                  Email = "lucie55@nolan.com",
                  Phone = "(853) 579-5197",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 91,
                  UserTypeID = 3,
                  GateCode = "#1234658",
                  FirstName = "Eugene",
                  LastName = "Flores ",
                  StreetAddress = "Harrison Avenue",
                  Email = "wiegand.lilliana@hotmail.com",
                  Phone = "(621) 670-6363",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 92,
                  UserTypeID = 3,
                  GateCode = "#1234659",
                  FirstName = "Logan",
                  LastName = "Washington",
                  StreetAddress = "Glenwood Drive",
                  Email = "lturcotte@volkman.com",
                  Phone = "(474) 615-7747",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 93,
                  UserTypeID = 3,
                  GateCode = "#1234660",
                  FirstName = "Randy",
                  LastName = "Butler ",
                  StreetAddress = "Pearl Street",
                  Email = "laverna.altenwerth@gmail.com",
                  Phone = "(237) 667-9492",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 94,
                  UserTypeID = 3,
                  GateCode = "#1234661",
                  FirstName = "Louis",
                  LastName = "Simmons ",
                  StreetAddress = "Hartford Road",
                  Email = "macejkovic.birdie@friesen.com",
                  Phone = "(368) 889-7655",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 95,
                  UserTypeID = 3,
                  GateCode = "#1234662",
                  FirstName = "Russell",
                  LastName = "Foster ",
                  StreetAddress = "Fawn Lane",
                  Email = "elenora.schiller@hotmail.com",
                  Phone = "(620) 719-4371",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 96,
                  UserTypeID = 3,
                  GateCode = "#1234663",
                  FirstName = "Vincent",
                  LastName = "Gonzales ",
                  StreetAddress = "Oak Lane",
                  Email = "amari.harris@treutel.com",
                  Phone = "(803) 244-3886",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 97,
                  UserTypeID = 3,
                  GateCode = "#1234664",
                  FirstName = "Philip",
                  LastName = "Bryant ",
                  StreetAddress = "Hudson Street",
                  Email = "nyah33@hotmail.com",
                  Phone = "(419) 478-7333",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 98,
                  UserTypeID = 3,
                  GateCode = "#1234665",
                  FirstName = "Bobby",
                  LastName = "Alexander ",
                  StreetAddress = "Adams Avenue",
                  Email = "gibson.ferne@nitzsche.com",
                  Phone = "(769) 341-5802",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 99,
                  UserTypeID = 3,
                  GateCode = "#1234666",
                  FirstName = "Johnny",
                  LastName = "Russell ",
                  StreetAddress = "Canterbury Road",
                  Email = "kylee.lind@simonis.biz",
                  Phone = "(739) 867-8242",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               },
               new User
               {
                  UserID = 100,
                  UserTypeID = 3,
                  GateCode = "#1234667",
                  FirstName = "Bradley",
                  LastName = "Griffin ",
                  StreetAddress = "Canterbury Road",
                  Email = "raul38@yahoo.com",
                  Phone = "(409) 855-1819",
                  City = "Salem",
                  State = "Utah",
                  Zip = "84653"
               }
            );

            context.UnitType.AddRange(
                new UnitType
                {
                   UnitTypeID = 1,
                   UnitTypeName = "Small",
                   Width = 10,
                   Depth = 10,
                   Height = 10,
                   Price = 40
                }, new UnitType
                {
                   UnitTypeID = 2,
                   UnitTypeName = "Medium",
                   Width = 11,
                   Depth = 24,
                   Height = 20,
                   Price = 70
                }, new UnitType
                {
                   UnitTypeID = 3,
                   UnitTypeName = "Large",
                   Width = 22,
                   Depth = 30,
                   Height = 20,
                   Price = 140
                }, new UnitType
                {
                   UnitTypeID = 4,
                   UnitTypeName = "Lot",
                   Width = 11,
                   Depth = 30,
                   Height = 50,
                   Price = 70
                }
            );

            context.Unit.AddRange(
               new Unit
               {
                  UnitID = 100,
                  UnitTypeID = 1,
                  UnitLocation = "A1"
               },
               new Unit
               {
                  UnitID = 101,
                  UnitTypeID = 1,
                  UnitLocation = "A2"
               },
               new Unit
               {
                  UnitID = 102,
                  UnitTypeID = 1,
                  UnitLocation = "A3"
               },
               new Unit
               {
                  UnitID = 103,
                  UnitTypeID = 1,
                  UnitLocation = "A4"
               },
               new Unit
               {
                  UnitID = 104,
                  UnitTypeID = 1,
                  UnitLocation = "A5"
               },
               new Unit
               {
                  UnitID = 105,
                  UnitTypeID = 1,
                  UnitLocation = "A6"
               },
               new Unit
               {
                  UnitID = 106,
                  UnitTypeID = 1,
                  UnitLocation = "A7"
               },
               new Unit
               {
                  UnitID = 107,
                  UnitTypeID = 1,
                  UnitLocation = "A8"
               },
               new Unit
               {
                  UnitID = 108,
                  UnitTypeID = 1,
                  UnitLocation = "A9"
               },
               new Unit
               {
                  UnitID = 109,
                  UnitTypeID = 1,
                  UnitLocation = "A10"
               },
               new Unit
               {
                  UnitID = 110,
                  UnitTypeID = 1,
                  UnitLocation = "A11"
               },
               new Unit
               {
                  UnitID = 111,
                  UnitTypeID = 1,
                  UnitLocation = "A12"
               },
               new Unit
               {
                  UnitID = 112,
                  UnitTypeID = 1,
                  UnitLocation = "A13"
               },
               new Unit
               {
                  UnitID = 113,
                  UnitTypeID = 1,
                  UnitLocation = "A14"
               },
               new Unit
               {
                  UnitID = 114,
                  UnitTypeID = 1,
                  UnitLocation = "A15"
               },
               new Unit
               {
                  UnitID = 115,
                  UnitTypeID = 1,
                  UnitLocation = "A16"
               },
               new Unit
               {
                  UnitID = 116,
                  UnitTypeID = 1,
                  UnitLocation = "A17"
               },
               new Unit
               {
                  UnitID = 117,
                  UnitTypeID = 1,
                  UnitLocation = "A18"
               },
               new Unit
               {
                  UnitID = 118,
                  UnitTypeID = 1,
                  UnitLocation = "A19"
               },
               new Unit
               {
                  UnitID = 119,
                  UnitTypeID = 1,
                  UnitLocation = "A20"
               },
               new Unit
               {
                  UnitID = 120,
                  UnitTypeID = 1,
                  UnitLocation = "B1"
               },
               new Unit
               {
                  UnitID = 121,
                  UnitTypeID = 1,
                  UnitLocation = "B2"
               },
               new Unit
               {
                  UnitID = 122,
                  UnitTypeID = 1,
                  UnitLocation = "B3"
               },
               new Unit
               {
                  UnitID = 123,
                  UnitTypeID = 1,
                  UnitLocation = "B4"
               },
               new Unit
               {
                  UnitID = 124,
                  UnitTypeID = 1,
                  UnitLocation = "B5"
               },
               new Unit
               {
                  UnitID = 125,
                  UnitTypeID = 1,
                  UnitLocation = "B6"
               },
               new Unit
               {
                  UnitID = 126,
                  UnitTypeID = 1,
                  UnitLocation = "B7"
               },
               new Unit
               {
                  UnitID = 127,
                  UnitTypeID = 1,
                  UnitLocation = "B8"
               },
               new Unit
               {
                  UnitID = 128,
                  UnitTypeID = 1,
                  UnitLocation = "B9"
               },
               new Unit
               {
                  UnitID = 129,
                  UnitTypeID = 1,
                  UnitLocation = "B10"
               },
               new Unit
               {
                  UnitID = 130,
                  UnitTypeID = 1,
                  UnitLocation = "B11"
               },
               new Unit
               {
                  UnitID = 131,
                  UnitTypeID = 1,
                  UnitLocation = "B12"
               },
               new Unit
               {
                  UnitID = 132,
                  UnitTypeID = 1,
                  UnitLocation = "B13"
               },
               new Unit
               {
                  UnitID = 133,
                  UnitTypeID = 1,
                  UnitLocation = "B14"
               },
               new Unit
               {
                  UnitID = 134,
                  UnitTypeID = 1,
                  UnitLocation = "B15"
               },
               new Unit
               {
                  UnitID = 135,
                  UnitTypeID = 1,
                  UnitLocation = "B16"
               },
               new Unit
               {
                  UnitID = 136,
                  UnitTypeID = 1,
                  UnitLocation = "B17"
               },
               new Unit
               {
                  UnitID = 137,
                  UnitTypeID = 1,
                  UnitLocation = "B18"
               },
               new Unit
               {
                  UnitID = 138,
                  UnitTypeID = 1,
                  UnitLocation = "B19"
               },
               new Unit
               {
                  UnitID = 139,
                  UnitTypeID = 1,
                  UnitLocation = "B20"
               },
               new Unit
               {
                  UnitID = 140,
                  UnitTypeID = 2,
                  UnitLocation = "C1"
               },
               new Unit
               {
                  UnitID = 141,
                  UnitTypeID = 2,
                  UnitLocation = "C2"
               },
               new Unit
               {
                  UnitID = 142,
                  UnitTypeID = 2,
                  UnitLocation = "C3"
               },
               new Unit
               {
                  UnitID = 143,
                  UnitTypeID = 2,
                  UnitLocation = "C4"
               },
               new Unit
               {
                  UnitID = 144,
                  UnitTypeID = 2,
                  UnitLocation = "C5"
               },
               new Unit
               {
                  UnitID = 145,
                  UnitTypeID = 2,
                  UnitLocation = "C6"
               },
               new Unit
               {
                  UnitID = 146,
                  UnitTypeID = 2,
                  UnitLocation = "C7"
               },
               new Unit
               {
                  UnitID = 147,
                  UnitTypeID = 2,
                  UnitLocation = "C8"
               },
               new Unit
               {
                  UnitID = 148,
                  UnitTypeID = 2,
                  UnitLocation = "C9"
               },
               new Unit
               {
                  UnitID = 149,
                  UnitTypeID = 2,
                  UnitLocation = "C10"
               },
               new Unit
               {
                  UnitID = 150,
                  UnitTypeID = 2,
                  UnitLocation = "C11"
               },
               new Unit
               {
                  UnitID = 151,
                  UnitTypeID = 2,
                  UnitLocation = "C12"
               },
               new Unit
               {
                  UnitID = 152,
                  UnitTypeID = 2,
                  UnitLocation = "C13"
               },
               new Unit
               {
                  UnitID = 153,
                  UnitTypeID = 2,
                  UnitLocation = "C14"
               },
               new Unit
               {
                  UnitID = 154,
                  UnitTypeID = 2,
                  UnitLocation = "C15"
               },
               new Unit
               {
                  UnitID = 155,
                  UnitTypeID = 2,
                  UnitLocation = "C16"
               },
               new Unit
               {
                  UnitID = 156,
                  UnitTypeID = 2,
                  UnitLocation = "C17"
               },
               new Unit
               {
                  UnitID = 157,
                  UnitTypeID = 2,
                  UnitLocation = "C18"
               },
               new Unit
               {
                  UnitID = 158,
                  UnitTypeID = 2,
                  UnitLocation = "C19"
               },
               new Unit
               {
                  UnitID = 159,
                  UnitTypeID = 2,
                  UnitLocation = "C20"
               },
               new Unit
               {
                  UnitID = 160,
                  UnitTypeID = 2,
                  UnitLocation = "D1"
               },
               new Unit
               {
                  UnitID = 161,
                  UnitTypeID = 2,
                  UnitLocation = "D2"
               },
               new Unit
               {
                  UnitID = 162,
                  UnitTypeID = 2,
                  UnitLocation = "D3"
               },
               new Unit
               {
                  UnitID = 163,
                  UnitTypeID = 2,
                  UnitLocation = "D4"
               },
               new Unit
               {
                  UnitID = 164,
                  UnitTypeID = 2,
                  UnitLocation = "D5"
               },
               new Unit
               {
                  UnitID = 165,
                  UnitTypeID = 2,
                  UnitLocation = "D6"
               },
               new Unit
               {
                  UnitID = 166,
                  UnitTypeID = 2,
                  UnitLocation = "D7"
               },
               new Unit
               {
                  UnitID = 167,
                  UnitTypeID = 2,
                  UnitLocation = "D8"
               },
               new Unit
               {
                  UnitID = 168,
                  UnitTypeID = 2,
                  UnitLocation = "D9"
               },
               new Unit
               {
                  UnitID = 169,
                  UnitTypeID = 2,
                  UnitLocation = "D10"
               },
               new Unit
               {
                  UnitID = 170,
                  UnitTypeID = 2,
                  UnitLocation = "D11"
               },
               new Unit
               {
                  UnitID = 171,
                  UnitTypeID = 2,
                  UnitLocation = "D12"
               },
               new Unit
               {
                  UnitID = 172,
                  UnitTypeID = 2,
                  UnitLocation = "D13"
               },
               new Unit
               {
                  UnitID = 173,
                  UnitTypeID = 2,
                  UnitLocation = "D14"
               },
               new Unit
               {
                  UnitID = 174,
                  UnitTypeID = 2,
                  UnitLocation = "D15"
               },
               new Unit
               {
                  UnitID = 175,
                  UnitTypeID = 2,
                  UnitLocation = "D16"
               },
               new Unit
               {
                  UnitID = 176,
                  UnitTypeID = 2,
                  UnitLocation = "D17"
               },
               new Unit
               {
                  UnitID = 177,
                  UnitTypeID = 2,
                  UnitLocation = "D18"
               },
               new Unit
               {
                  UnitID = 178,
                  UnitTypeID = 2,
                  UnitLocation = "D19"
               },
               new Unit
               {
                  UnitID = 179,
                  UnitTypeID = 2,
                  UnitLocation = "D20"
               },
               new Unit
               {
                  UnitID = 180,
                  UnitTypeID = 3,
                  UnitLocation = "E1"
               },
               new Unit
               {
                  UnitID = 181,
                  UnitTypeID = 3,
                  UnitLocation = "E2"
               },
               new Unit
               {
                  UnitID = 182,
                  UnitTypeID = 3,
                  UnitLocation = "E3"
               },
               new Unit
               {
                  UnitID = 183,
                  UnitTypeID = 3,
                  UnitLocation = "E4"
               },
               new Unit
               {
                  UnitID = 184,
                  UnitTypeID = 3,
                  UnitLocation = "E5"
               },
               new Unit
               {
                  UnitID = 185,
                  UnitTypeID = 3,
                  UnitLocation = "E6"
               },
               new Unit
               {
                  UnitID = 186,
                  UnitTypeID = 3,
                  UnitLocation = "E7"
               },
               new Unit
               {
                  UnitID = 187,
                  UnitTypeID = 3,
                  UnitLocation = "E8"
               },
               new Unit
               {
                  UnitID = 188,
                  UnitTypeID = 3,
                  UnitLocation = "E9"
               },
               new Unit
               {
                  UnitID = 189,
                  UnitTypeID = 3,
                  UnitLocation = "E10"
               },
               new Unit
               {
                  UnitID = 190,
                  UnitTypeID = 3,
                  UnitLocation = "E11"
               },
               new Unit
               {
                  UnitID = 191,
                  UnitTypeID = 3,
                  UnitLocation = "E12"
               },
               new Unit
               {
                  UnitID = 192,
                  UnitTypeID = 3,
                  UnitLocation = "E13"
               },
               new Unit
               {
                  UnitID = 193,
                  UnitTypeID = 3,
                  UnitLocation = "E14"
               },
               new Unit
               {
                  UnitID = 194,
                  UnitTypeID = 3,
                  UnitLocation = "E15"
               },
               new Unit
               {
                  UnitID = 195,
                  UnitTypeID = 4,
                  UnitLocation = "E16"
               },
               new Unit
               {
                  UnitID = 196,
                  UnitTypeID = 4,
                  UnitLocation = "E17"
               },
               new Unit
               {
                  UnitID = 197,
                  UnitTypeID = 4,
                  UnitLocation = "E18"
               },
               new Unit
               {
                  UnitID = 198,
                  UnitTypeID = 4,
                  UnitLocation = "E19"
               },
               new Unit
               {
                  UnitID = 199,
                  UnitTypeID = 4,
                  UnitLocation = "E20"
               }
            );

            context.Contract.AddRange(
               new Contract
               {
                  ContractID = 1,
                  UnitID = 100,
                  UserID = 5,
                  StartDate = new DateTime(1990, 02, 10),
                  EndDate = new DateTime(2020, 24, 3)
               },
               new Contract
               {
                  ContractID = 2,
                  UnitID = 101,
                  UserID = 6,
                  StartDate = new DateTime(1993, 24, 11),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 3,
                  UnitID = 102,
                  UserID = 7,
                  StartDate = new DateTime(1995, 24, 3),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 4,
                  UnitID = 103,
                  UserID = 8,
                  StartDate = new DateTime(1995, 22, 6),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 5,
                  UnitID = 104,
                  UserID = 9,
                  StartDate = new DateTime(1998, 16, 2),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 6,
                  UnitID = 105,
                  UserID = 10,
                  StartDate = new DateTime(1999, 08, 12),
                  EndDate = new DateTime(2020, 24, 3)
               },
               new Contract
               {
                  ContractID = 7,
                  UnitID = 106,
                  UserID = 11,
                  StartDate = new DateTime(2001, 14, 12),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 8,
                  UnitID = 107,
                  UserID = 12,
                  StartDate = new DateTime(2003, 10, 1),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 9,
                  UnitID = 108,
                  UserID = 13,
                  StartDate = new DateTime(2003, 30, 4),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 10,
                  UnitID = 109,
                  UserID = 14,
                  StartDate = new DateTime(2003, 03, 6),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 11,
                  UnitID = 110,
                  UserID = 15,
                  StartDate = new DateTime(2005, 08, 7),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 12,
                  UnitID = 111,
                  UserID = 16,
                  StartDate = new DateTime(2006, 24, 10),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 13,
                  UnitID = 112,
                  UserID = 17,
                  StartDate = new DateTime(2006, 14, 11),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 14,
                  UnitID = 113,
                  UserID = 18,
                  StartDate = new DateTime(2007, 29, 8),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 15,
                  UnitID = 114,
                  UserID = 19,
                  StartDate = new DateTime(2008, 27, 3),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 16,
                  UnitID = 115,
                  UserID = 20,
                  StartDate = new DateTime(2008, 21, 5),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 17,
                  UnitID = 116,
                  UserID = 21,
                  StartDate = new DateTime(2009, 28, 8),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 18,
                  UnitID = 117,
                  UserID = 22,
                  StartDate = new DateTime(2010, 30, 6),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 19,
                  UnitID = 118,
                  UserID = 23,
                  StartDate = new DateTime(2011, 01, 2),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 20,
                  UnitID = 119,
                  UserID = 24,
                  StartDate = new DateTime(2013, 24, 7),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 21,
                  UnitID = 120,
                  UserID = 25,
                  StartDate = new DateTime(2014, 24, 4),
                  EndDate = new DateTime(2020, 24, 3)
               },
               new Contract
               {
                  ContractID = 22,
                  UnitID = 121,
                  UserID = 26,
                  StartDate = new DateTime(2015, 16, 2),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 23,
                  UnitID = 122,
                  UserID = 27,
                  StartDate = new DateTime(2015, 20, 3),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 24,
                  UnitID = 123,
                  UserID = 28,
                  StartDate = new DateTime(2020, 11, 11),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 25,
                  UnitID = 124,
                  UserID = 29,
                  StartDate = new DateTime(2020, 04, 12),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 26,
                  UnitID = 125,
                  UserID = 30,
                  StartDate = new DateTime(1992, 07, 5),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 27,
                  UnitID = 126,
                  UserID = 31,
                  StartDate = new DateTime(1992, 18, 5),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 28,
                  UnitID = 127,
                  UserID = 32,
                  StartDate = new DateTime(1996, 20, 3),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 29,
                  UnitID = 128,
                  UserID = 33,
                  StartDate = new DateTime(1996, 11, 6),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 30,
                  UnitID = 129,
                  UserID = 34,
                  StartDate = new DateTime(1997, 03, 1),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 31,
                  UnitID = 130,
                  UserID = 35,
                  StartDate = new DateTime(1998, 11, 2),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 32,
                  UnitID = 131,
                  UserID = 36,
                  StartDate = new DateTime(2000, 21, 8),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 33,
                  UnitID = 132,
                  UserID = 37,
                  StartDate = new DateTime(2002, 30, 8),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 34,
                  UnitID = 133,
                  UserID = 38,
                  StartDate = new DateTime(2004, 31, 3),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 35,
                  UnitID = 134,
                  UserID = 39,
                  StartDate = new DateTime(2004, 20, 5),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 36,
                  UnitID = 135,
                  UserID = 40,
                  StartDate = new DateTime(2006, 13, 1),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 37,
                  UnitID = 136,
                  UserID = 41,
                  StartDate = new DateTime(2006, 03, 2),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 38,
                  UnitID = 137,
                  UserID = 42,
                  StartDate = new DateTime(2006, 21, 3),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 39,
                  UnitID = 138,
                  UserID = 43,
                  StartDate = new DateTime(2006, 26, 6),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 40,
                  UnitID = 139,
                  UserID = 44,
                  StartDate = new DateTime(2006, 22, 9),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 41,
                  UnitID = 140,
                  UserID = 45,
                  StartDate = new DateTime(2008, 13, 2),
                  EndDate = new DateTime(2020, 24, 3)
               },
               new Contract
               {
                  ContractID = 42,
                  UnitID = 141,
                  UserID = 46,
                  StartDate = new DateTime(2008, 06, 11),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 43,
                  UnitID = 142,
                  UserID = 47,
                  StartDate = new DateTime(2008, 08, 12),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 44,
                  UnitID = 143,
                  UserID = 48,
                  StartDate = new DateTime(2011, 15, 11),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 45,
                  UnitID = 144,
                  UserID = 49,
                  StartDate = new DateTime(2013, 20, 2),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 46,
                  UnitID = 145,
                  UserID = 50,
                  StartDate = new DateTime(2014, 09, 7),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 47,
                  UnitID = 146,
                  UserID = 51,
                  StartDate = new DateTime(2015, 10, 12),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 48,
                  UnitID = 147,
                  UserID = 52,
                  StartDate = new DateTime(2017, 08, 12),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 49,
                  UnitID = 148,
                  UserID = 53,
                  StartDate = new DateTime(2018, 24, 8),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 50,
                  UnitID = 149,
                  UserID = 54,
                  StartDate = new DateTime(2019, 10, 7),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 51,
                  UnitID = 150,
                  UserID = 55,
                  StartDate = new DateTime(1990, 26, 4),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 52,
                  UnitID = 151,
                  UserID = 56,
                  StartDate = new DateTime(1991, 15, 8),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 53,
                  UnitID = 152,
                  UserID = 57,
                  StartDate = new DateTime(1992, 27, 10),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 54,
                  UnitID = 153,
                  UserID = 58,
                  StartDate = new DateTime(1994, 05, 4),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 55,
                  UnitID = 154,
                  UserID = 59,
                  StartDate = new DateTime(1995, 05, 5),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 56,
                  UnitID = 155,
                  UserID = 60,
                  StartDate = new DateTime(1995, 29, 9),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 57,
                  UnitID = 156,
                  UserID = 61,
                  StartDate = new DateTime(1996, 26, 2),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 58,
                  UnitID = 157,
                  UserID = 62,
                  StartDate = new DateTime(1997, 09, 10),
                  EndDate = new DateTime(2020, 24, 3)
               },
               new Contract
               {
                  ContractID = 59,
                  UnitID = 158,
                  UserID = 63,
                  StartDate = new DateTime(1998, 22, 12),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 60,
                  UnitID = 159,
                  UserID = 64,
                  StartDate = new DateTime(2001, 10, 5),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 61,
                  UnitID = 160,
                  UserID = 65,
                  StartDate = new DateTime(2001, 01, 11),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 62,
                  UnitID = 161,
                  UserID = 66,
                  StartDate = new DateTime(2002, 22, 7),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 63,
                  UnitID = 162,
                  UserID = 67,
                  StartDate = new DateTime(2004, 15, 3),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 64,
                  UnitID = 163,
                  UserID = 68,
                  StartDate = new DateTime(2006, 30, 5),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 65,
                  UnitID = 164,
                  UserID = 69,
                  StartDate = new DateTime(2010, 13, 10),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 66,
                  UnitID = 165,
                  UserID = 70,
                  StartDate = new DateTime(2011, 23, 12),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 67,
                  UnitID = 166,
                  UserID = 71,
                  StartDate = new DateTime(2013, 18, 10),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 68,
                  UnitID = 167,
                  UserID = 72,
                  StartDate = new DateTime(2014, 20, 5),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 69,
                  UnitID = 168,
                  UserID = 73,
                  StartDate = new DateTime(2015, 12, 5),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 70,
                  UnitID = 169,
                  UserID = 74,
                  StartDate = new DateTime(2016, 25, 10),
                  EndDate = new DateTime(2020, 24, 3)
               },
               new Contract
               {
                  ContractID = 71,
                  UnitID = 170,
                  UserID = 75,
                  StartDate = new DateTime(2017, 22, 5),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 72,
                  UnitID = 171,
                  UserID = 76,
                  StartDate = new DateTime(2018, 29, 6),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 73,
                  UnitID = 172,
                  UserID = 77,
                  StartDate = new DateTime(2019, 17, 12),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 74,
                  UnitID = 173,
                  UserID = 78,
                  StartDate = new DateTime(2020, 18, 8),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 75,
                  UnitID = 174,
                  UserID = 79,
                  StartDate = new DateTime(2020, 26, 8),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 76,
                  UnitID = 175,
                  UserID = 80,
                  StartDate = new DateTime(1990, 12, 9),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 77,
                  UnitID = 176,
                  UserID = 81,
                  StartDate = new DateTime(1991, 02, 1),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 78,
                  UnitID = 177,
                  UserID = 82,
                  StartDate = new DateTime(1993, 15, 2),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 79,
                  UnitID = 178,
                  UserID = 83,
                  StartDate = new DateTime(1994, 18, 2),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 80,
                  UnitID = 179,
                  UserID = 84,
                  StartDate = new DateTime(1994, 04, 3),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 81,
                  UnitID = 180,
                  UserID = 85,
                  StartDate = new DateTime(1995, 18, 4),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 82,
                  UnitID = 181,
                  UserID = 86,
                  StartDate = new DateTime(1996, 08, 1),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 83,
                  UnitID = 182,
                  UserID = 87,
                  StartDate = new DateTime(1997, 12, 2),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 84,
                  UnitID = 183,
                  UserID = 88,
                  StartDate = new DateTime(1999, 18, 5),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 85,
                  UnitID = 184,
                  UserID = 89,
                  StartDate = new DateTime(2000, 05, 1),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 86,
                  UnitID = 185,
                  UserID = 90,
                  StartDate = new DateTime(2002, 01, 3),
                  EndDate = new DateTime(2020, 24, 3)
               },
               new Contract
               {
                  ContractID = 87,
                  UnitID = 186,
                  UserID = 91,
                  StartDate = new DateTime(2003, 09, 1),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 88,
                  UnitID = 187,
                  UserID = 92,
                  StartDate = new DateTime(2003, 17, 1),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 89,
                  UnitID = 188,
                  UserID = 93,
                  StartDate = new DateTime(2003, 02, 5),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 90,
                  UnitID = 189,
                  UserID = 94,
                  StartDate = new DateTime(2007, 25, 7),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 91,
                  UnitID = 190,
                  UserID = 95,
                  StartDate = new DateTime(2008, 22, 1),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 92,
                  UnitID = 191,
                  UserID = 96,
                  StartDate = new DateTime(2010, 22, 12),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 93,
                  UnitID = 192,
                  UserID = 97,
                  StartDate = new DateTime(2011, 24, 5),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 94,
                  UnitID = 193,
                  UserID = 98,
                  StartDate = new DateTime(2014, 28, 5),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 95,
                  UnitID = 194,
                  UserID = 99,
                  StartDate = new DateTime(2015, 27, 7),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 96,
                  UnitID = 195,
                  UserID = 100,
                  StartDate = new DateTime(2016, 02, 3),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 97,
                  UnitID = 196,
                  UserID = 95,
                  StartDate = new DateTime(2016, 07, 7),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 98,
                  UnitID = 197,
                  UserID = 96,
                  StartDate = new DateTime(2017, 15, 5),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 99,
                  UnitID = 198,
                  UserID = 97,
                  StartDate = new DateTime(2017, 16, 6),
                  EndDate = Contract.END_OF_TIME
               },
               new Contract
               {
                  ContractID = 100,
                  UnitID = 199,
                  UserID = 98,
                  StartDate = new DateTime(2018, 09, 8),
                  EndDate = new DateTime(2020, 24, 3)
               }

            );

            context.SaveChanges();
         }
      }
   }
}