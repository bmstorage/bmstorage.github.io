using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BMStorage.Migrations
{
    public partial class FinalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UnitType",
                columns: table => new
                {
                    UnitTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitTypeName = table.Column<string>(nullable: true),
                    Width = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    Depth = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    Height = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(6,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitType", x => x.UnitTypeID);
                });

            migrationBuilder.CreateTable(
                name: "UserType",
                columns: table => new
                {
                    UserTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserType", x => x.UserTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Unit",
                columns: table => new
                {
                    UnitID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitTypeID = table.Column<int>(nullable: false),
                    UnitLocation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit", x => x.UnitID);
                    table.ForeignKey(
                        name: "FK_Unit_UnitType_UnitTypeID",
                        column: x => x.UnitTypeID,
                        principalTable: "UnitType",
                        principalColumn: "UnitTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserTypeID = table.Column<int>(nullable: false),
                    GateCode = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_User_UserType_UserTypeID",
                        column: x => x.UserTypeID,
                        principalTable: "UserType",
                        principalColumn: "UserTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contract",
                columns: table => new
                {
                    ContractID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contract", x => x.ContractID);
                    table.ForeignKey(
                        name: "FK_Contract_Unit_UnitID",
                        column: x => x.UnitID,
                        principalTable: "Unit",
                        principalColumn: "UnitID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contract_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "UnitType",
                columns: new[] { "UnitTypeID", "Depth", "Height", "Price", "UnitTypeName", "Width" },
                values: new object[,]
                {
                    { 1, 10m, 10m, 40m, "Small", 10m },
                    { 2, 24m, 20m, 70m, "Medium", 11m },
                    { 3, 30m, 20m, 140m, "Large", 22m },
                    { 4, 30m, 50m, 70m, "Lot", 11m }
                });

            migrationBuilder.InsertData(
                table: "UserType",
                columns: new[] { "UserTypeID", "UserTypeName" },
                values: new object[,]
                {
                    { 1, "Owner" },
                    { 2, "Employee" },
                    { 3, "Tenant" }
                });

            migrationBuilder.InsertData(
                table: "Unit",
                columns: new[] { "UnitID", "UnitLocation", "UnitTypeID" },
                values: new object[,]
                {
                    { 100, "A1", 1 },
                    { 172, "D13", 2 },
                    { 171, "D12", 2 },
                    { 170, "D11", 2 },
                    { 169, "D10", 2 },
                    { 168, "D9", 2 },
                    { 167, "D8", 2 },
                    { 166, "D7", 2 },
                    { 165, "D6", 2 },
                    { 164, "D5", 2 },
                    { 163, "D4", 2 },
                    { 162, "D3", 2 },
                    { 161, "D2", 2 },
                    { 160, "D1", 2 },
                    { 159, "C20", 2 },
                    { 158, "C19", 2 },
                    { 157, "C18", 2 },
                    { 156, "C17", 2 },
                    { 155, "C16", 2 },
                    { 154, "C15", 2 },
                    { 153, "C14", 2 },
                    { 152, "C13", 2 },
                    { 173, "D14", 2 },
                    { 174, "D15", 2 },
                    { 175, "D16", 2 },
                    { 176, "D17", 2 },
                    { 198, "E19", 4 },
                    { 197, "E18", 4 },
                    { 196, "E17", 4 },
                    { 195, "E16", 4 },
                    { 194, "E15", 3 },
                    { 193, "E14", 3 },
                    { 192, "E13", 3 },
                    { 191, "E12", 3 },
                    { 190, "E11", 3 },
                    { 189, "E10", 3 },
                    { 151, "C12", 2 },
                    { 188, "E9", 3 },
                    { 186, "E7", 3 },
                    { 185, "E6", 3 },
                    { 184, "E5", 3 },
                    { 183, "E4", 3 },
                    { 182, "E3", 3 },
                    { 181, "E2", 3 },
                    { 180, "E1", 3 },
                    { 179, "D20", 2 },
                    { 178, "D19", 2 },
                    { 177, "D18", 2 },
                    { 187, "E8", 3 },
                    { 150, "C11", 2 },
                    { 199, "E20", 4 },
                    { 148, "C9", 2 },
                    { 121, "B2", 1 },
                    { 120, "B1", 1 },
                    { 119, "A20", 1 },
                    { 118, "A19", 1 },
                    { 117, "A18", 1 },
                    { 116, "A17", 1 },
                    { 115, "A16", 1 },
                    { 114, "A15", 1 },
                    { 112, "A13", 1 },
                    { 111, "A12", 1 },
                    { 110, "A11", 1 },
                    { 109, "A10", 1 },
                    { 108, "A9", 1 },
                    { 107, "A8", 1 },
                    { 106, "A7", 1 },
                    { 105, "A6", 1 },
                    { 104, "A5", 1 },
                    { 103, "A4", 1 },
                    { 102, "A3", 1 },
                    { 101, "A2", 1 },
                    { 149, "C10", 2 },
                    { 122, "B3", 1 },
                    { 123, "B4", 1 },
                    { 113, "A14", 1 },
                    { 125, "B6", 1 },
                    { 124, "B5", 1 },
                    { 146, "C7", 2 },
                    { 145, "C6", 2 },
                    { 144, "C5", 2 },
                    { 143, "C4", 2 },
                    { 142, "C3", 2 },
                    { 141, "C2", 2 },
                    { 139, "B20", 1 },
                    { 138, "B19", 1 },
                    { 137, "B18", 1 },
                    { 136, "B17", 1 },
                    { 140, "C1", 2 },
                    { 147, "C8", 2 },
                    { 135, "B16", 1 },
                    { 127, "B8", 1 },
                    { 128, "B9", 1 },
                    { 129, "B10", 1 },
                    { 130, "B11", 1 },
                    { 126, "B7", 1 },
                    { 132, "B13", 1 },
                    { 133, "B14", 1 },
                    { 134, "B15", 1 },
                    { 131, "B12", 1 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "City", "Email", "FirstName", "GateCode", "LastName", "Phone", "State", "StreetAddress", "UserTypeID", "Zip" },
                values: new object[,]
                {
                    { 64, "Salem", "lindgren.lizeth@gmail.com", "Jeremy", "#1234631", "Cooper ", "(662) 229-4328", "Utah", "Cleveland Avenue", 3, "84653" },
                    { 72, "Salem", "neichmann@hotmail.com", "Sean", "#1234639", "Ramirez ", "(289) 438-0939", "Utah", "Orchard Avenue", 3, "84653" },
                    { 71, "Salem", "vdeckow@gmail.com", "Christian", "#1234638", "Gray ", "(455) 276-3589", "Utah", "Wood Street", 3, "84653" },
                    { 70, "Salem", "carroll.jayce@yahoo.com", "Terry", "#1234637", "Peterson ", "(345) 943-0028", "Utah", "Grant Avenue", 3, "84653" },
                    { 69, "Salem", "green.lowe@hotmail.com", "Arthur", "#1234636", "Torres ", "(969) 343-4045", "Utah", "6th Street North", 3, "84653" },
                    { 68, "Salem", "vcrist@gulgowski.com", "Ethan", "#1234635", "Ward ", "(762) 449-5349", "Utah", "Route 5", 3, "84653" },
                    { 67, "Salem", "rutherford.kaleb@gmail.com", "Gerald", "#1234634", "Howard ", "(442) 828-8828", "Utah", "Carriage Drive", 3, "84653" },
                    { 66, "Salem", "kelton.johnson@gmail.com", "Roger", "#1234633", "Cox ", "(447) 869-4029", "Utah", "Cypress Court", 3, "84653" },
                    { 65, "Salem", "heathcote.aleen@hotmail.com", "Keith", "#1234632", "Richardson", "(706) 869-4762", "Utah", "Lantern Lane", 3, "84653" },
                    { 63, "Salem", "hoconner@kovacek.biz", "Carl", "#1234630", "Rivera ", "(779) 359-9033", "Utah", "Elm Avenue", 3, "84653" },
                    { 52, "Salem", "shemar.hand@kuphal.org", "Aaron", "#1234619", "Collins ", "(261) 230-7851", "Utah", "Andover Court", 3, "84653" },
                    { 61, "Salem", "della99@gmail.com", "Kyle", "#1234628", "Murphy ", "(350) 700-1679", "Utah", "Glenwood Avenue", 3, "84653" },
                    { 60, "Salem", "dubuque.margarete@yahoo.com", "Walter", "#1234627", "Bell ", "(442) 372-7921", "Utah", "Woodland Avenue", 3, "84653" },
                    { 59, "Salem", "yrunolfsdottir@hotmail.com", "Zachary", "#1234626", "Morgan ", "(423) 889-1573", "Utah", "Main Street", 3, "84653" },
                    { 58, "Salem", "kassulke.madonna@hotmail.com", "Nathan", "#1234625", "Cook ", "(204) 478-6176", "Utah", "North Street", 3, "84653" },
                    { 57, "Salem", "isidro88@bayer.com", "Peter", "#1234624", "Reed ", "(664) 787-7073", "Utah", "Fieldstone Drive", 3, "84653" },
                    { 56, "Salem", "bradtke.tod@glover.info", "Adam", "#1234623", "Rogers ", "(778) 483-1998", "Utah", "New Street", 3, "84653" },
                    { 55, "Salem", "americo18@heathcote.org", "Douglas", "#1234622", "Morris ", "(301) 202-6137", "Utah", "Oxford Court", 3, "84653" },
                    { 54, "Salem", "luella33@gmail.com", "Henry", "#1234621", "Sanchez ", "(361) 782-3242", "Utah", "13th Street", 3, "84653" },
                    { 53, "Salem", "brandt48@macejkovic.info", "Jose", "#1234620", "Stewart ", "(380) 661-1262", "Utah", "Augusta Drive", 3, "84653" },
                    { 73, "Salem", "kelly39@klocko.com", "Lawrence", "#1234640", "James ", "(992) 448-4283", "Utah", "Green Street", 3, "84653" },
                    { 62, "Salem", "sally.hamill@yahoo.com", "Harold", "#1234629", "Bailey ", "(768) 334-9085", "Utah", "Race Street", 3, "84653" },
                    { 74, "Salem", "ulehner@miller.com", "Austin", "#1234641", "Watson ", "(732) 910-7514", "Utah", "York Street", 3, "84653" },
                    { 98, "Salem", "gibson.ferne@nitzsche.com", "Bobby", "#1234665", "Alexander ", "(769) 341-5802", "Utah", "Adams Avenue", 3, "84653" },
                    { 76, "Salem", "amaya29@heathcote.com", "Noah", "#1234643", "Kelly ", "(207) 352-4156", "Utah", "Dogwood Lane", 3, "84653" },
                    { 51, "Salem", "cormier.dixie@gmail.com", "Tyler", "#1234618", "Edwards ", "(352) 614-5587", "Utah", "Jones Street", 3, "84653" },
                    { 97, "Salem", "nyah33@hotmail.com", "Philip", "#1234664", "Bryant ", "(419) 478-7333", "Utah", "Hudson Street", 3, "84653" },
                    { 96, "Salem", "amari.harris@treutel.com", "Vincent", "#1234663", "Gonzales ", "(803) 244-3886", "Utah", "Oak Lane", 3, "84653" },
                    { 95, "Salem", "elenora.schiller@hotmail.com", "Russell", "#1234662", "Foster ", "(620) 719-4371", "Utah", "Fawn Lane", 3, "84653" },
                    { 94, "Salem", "macejkovic.birdie@friesen.com", "Louis", "#1234661", "Simmons ", "(368) 889-7655", "Utah", "Hartford Road", 3, "84653" },
                    { 93, "Salem", "laverna.altenwerth@gmail.com", "Randy", "#1234660", "Butler ", "(237) 667-9492", "Utah", "Pearl Street", 3, "84653" },
                    { 92, "Salem", "lturcotte@volkman.com", "Logan", "#1234659", "Washington", "(474) 615-7747", "Utah", "Glenwood Drive", 3, "84653" },
                    { 91, "Salem", "wiegand.lilliana@hotmail.com", "Eugene", "#1234658", "Flores ", "(621) 670-6363", "Utah", "Harrison Avenue", 3, "84653" },
                    { 90, "Salem", "lucie55@nolan.com", "Wayne", "#1234657", "Hughes ", "(853) 579-5197", "Utah", "Market Street", 3, "84653" },
                    { 89, "Salem", "isabel.monahan@bailey.com", "Juan", "#1234656", "Patterson ", "(879) 964-3220", "Utah", "4th Avenue", 3, "84653" },
                    { 75, "Salem", "dessie.ortiz@gusikowski.net", "Joe", "#1234642", "Brooks ", "(436) 599-8157", "Utah", "2nd Street East", 3, "84653" },
                    { 88, "Salem", "ekoss@effertz.biz", "Roy", "#1234655", "Long ", "(582) 213-0674", "Utah", "Lafayette Avenue", 3, "84653" },
                    { 86, "Salem", "pbatz@hotmail.com", "Ralph", "#1234653", "Perry ", "(601) 617-2984", "Utah", "Hawthorne Avenue", 3, "84653" },
                    { 85, "Salem", "alvah.pacocha@hotmail.com", "Alan", "#1234652", "Jenkins ", "(591) 971-5188", "Utah", "Sunset Avenue", 3, "84653" },
                    { 84, "Salem", "kessler.marcelino@gmail.com", "Dylan", "#1234651", "Coleman ", "(241) 239-5034", "Utah", "Park Drive", 3, "84653" },
                    { 83, "Salem", "giovanni88@hotmail.com", "Jordan", "#1234650", "Henderson ", "(623) 253-4885", "Utah", "Penn Street", 3, "84653" },
                    { 82, "Salem", "lhansen@gmail.com", "Willie", "#1234649", "Ross ", "(823) 753-5309", "Utah", "Route 6", 3, "84653" },
                    { 81, "Salem", "chloe55@yahoo.com", "Bruce", "#1234648", "Barnes ", "(915) 423-5213", "Utah", "Route 41", 3, "84653" },
                    { 80, "Salem", "jannie14@steuber.com", "Billy", "#1234647", "Wood ", "(823) 296-1108", "Utah", "Amherst Street", 3, "84653" },
                    { 79, "Salem", "lamont17@brekke.com", "Bryan", "#1234646", "Bennett ", "(554) 977-4955", "Utah", "Washington Avenue", 3, "84653" },
                    { 78, "Salem", "abigail.mills@braun.org", "Albert", "#1234645", "Price", "(840) 982-0682", "Utah", "Bank Street", 3, "84653" },
                    { 77, "Salem", "muriel.mann@breitenberg.info", "Jesse", "#1234644", "Sanders ", "(274) 481-1298", "Utah", "Monroe Street", 3, "84653" },
                    { 87, "Salem", "shartmann@wolff.com", "Gabriel", "#1234654", "Powell ", "(561) 753-9609", "Utah", "Maple Street", 3, "84653" },
                    { 50, "Salem", "vwehner@gmail.com", "Jerry", "#1234617", "Evans ", "(812) 826-3947", "Utah", "Railroad Street", 3, "84653" },
                    { 26, "Salem", "jettie.parker@kerluke.com", "Brian", "#1234593", "Lee ", "(983) 293-7362", "Utah", "Heritage Drive", 3, "84653" },
                    { 48, "Salem", "miles.hoeger@gmail.com", "Jack", "#1234615", "Campbell ", "(366) 363-0437", "Utah", "Locust Street", 3, "84653" },
                    { 20, "Salem", "denesik.zetta@hotmail.com", "Steven", "#1234587", "Garcia ", "(356) 705-5724", "Utah", "Summit Street", 3, "84653" },
                    { 19, "Salem", "nbartoletti@stracke.net", "Paul", "#1234586", "Thompson ", "(894) 770-4409", "Utah", "Myrtle Street", 3, "84653" },
                    { 18, "Salem", "qbauch@hotmail.com", "Mark", "#1234585", "Martin ", "(931) 376-0137", "Utah", "High Street", 3, "84653" },
                    { 17, "Salem", "graham.ciara@yahoo.com", "Donald", "#1234584", "Harris ", "(638) 913-5361", "Utah", "Church Street", 3, "84653" },
                    { 16, "Salem", "heaney.amparo@bashirian.com", "Anthony", "#1234583", "White ", "(264) 329-7978", "Utah", "Cobblestone Court", 3, "84653" },
                    { 15, "Salem", "emelia.wisozk@wisozk.com", "Matthew", "#1234582", "Jackson ", "(730) 630-6822", "Utah", "Sherwood Drive", 3, "84653" },
                    { 14, "Salem", "ucorwin@lakin.net", "Daniel", "#1234581", "Thomas ", "(276) 950-6582", "Utah", "Parker Street", 3, "84653" },
                    { 13, "Salem", "mitchell.jensen@torphy.com", "Christopher", "#1234580", "Anderson ", "(667) 314-3885", "Utah", "Madison Street", 3, "84653" },
                    { 12, "Salem", "celine92@gmail.com", "Charles", "#1234579", "Taylor ", "(642) 883-4169", "Utah", "Manor Drive", 3, "84653" },
                    { 11, "Salem", "ukshlerin@crooks.com", "Thomas", "#1234578", "Moore ", "(886) 512-4682", "Utah", "Harrison Street", 3, "84653" },
                    { 10, "Salem", "gulgowski.kaya@hotmail.com", "Joseph", "#1234577", "Wilson ", "(626) 446-2869", "Utah", "Old York Road", 3, "84653" },
                    { 9, "Salem", "moberbrunner@marquardt.com", "Richard", "#1234576", "Miller ", "(745) 286-3362", "Utah", "Roosevelt Avenue", 3, "84653" },
                    { 8, "Salem", "reva.miller@hotmail.com", "David", "#1234575", "Davis ", "(614) 488-9114", "Utah", "Charles Street", 3, "84653" },
                    { 7, "Salem", "jolie85@kuhlman.com", "William", "#1234574", "Brown ", "(408) 908-1165", "Utah", "1st Avenue", 3, "84653" },
                    { 6, "Salem", "june42@pagac.com", "Michael", "#1234573", "Jones ", "(314) 307-6256", "Utah", "Bay Street", 3, "84653" },
                    { 5, "Salem", "marks.jessica@yahoo.com", "Robert", "#1234572", "Williams ", "(988) 306-1491", "Utah", "Willow Drive", 3, "84653" },
                    { 4, "Salem", "zion.kemmer@haag.com", "Ryan", "#1234571", "Cross", "(903) 656-1199", "Utah", "Beech Street", 2, "84653" },
                    { 3, "Salem", "alfonzo39@crist.biz", "Ryan", "#1234570", "Harris ", "(401) 740-9127", "Utah", "Chestnut Avenue", 2, "84653" },
                    { 2, "Salem", "estel91@yahoo.com", "Robin", "#1234569", "Mortensen", "(285) 285-9701", "Utah", "Ashley Court", 1, "84653" },
                    { 1, "Salem", "darian45@hayes.com", "Troy ", "#1234568", "Mortensen", "(529) 843-8255", "Utah", "7th Avenue", 1, "84653" },
                    { 99, "Salem", "kylee.lind@simonis.biz", "Johnny", "#1234666", "Russell ", "(739) 867-8242", "Utah", "Canterbury Road", 3, "84653" },
                    { 21, "Salem", "ideckow@hotmail.com", "Andrew", "#1234588", "Martinez ", "(966) 646-6421", "Utah", "Heather Lane", 3, "84653" },
                    { 22, "Salem", "hoyt88@gmail.com", "Kenneth", "#1234589", "Robinson ", "(433) 856-3323", "Utah", "Buttonwood Drive", 3, "84653" },
                    { 23, "Salem", "rodriguez.elwin@medhurst.com", "Joshua", "#1234590", "Clark ", "(246) 685-3429", "Utah", "Lawrence Street", 3, "84653" },
                    { 24, "Salem", "bart28@gmail.com", "George", "#1234591", "Rodriguez ", "(355) 901-5786", "Utah", "Magnolia Drive", 3, "84653" },
                    { 47, "Salem", "lilliana.reilly@turcotte.info", "Alexander", "#1234614", "Phillips ", "(649) 547-2312", "Utah", "Jackson Avenue", 3, "84653" },
                    { 46, "Salem", "chelsey.rosenbaum@yahoo.com", "Patrick", "#1234613", "Turner ", "(960) 905-8473", "Utah", "Wall Street", 3, "84653" },
                    { 45, "Salem", "kassulke.robert@thompson.com", "Gregory", "#1234612", "Roberts ", "(424) 839-9339", "Utah", "Devon Court", 3, "84653" },
                    { 44, "Salem", "aidan.nikolaus@gmail.com", "Benjamin", "#1234611", "Perez ", "(872) 744-9854", "Utah", "Overlook Circle", 3, "84653" },
                    { 43, "Salem", "rodriguez.vallie@gmail.com", "Frank", "#1234610", "Mitchell ", "(594) 377-2850", "Utah", "Lafayette Street", 3, "84653" },
                    { 42, "Salem", "norris78@daniel.net", "Brandon", "#1234609", "Carter ", "(305) 688-7567", "Utah", "3rd Street West", 3, "84653" },
                    { 41, "Salem", "tboyer@lockman.com", "Scott", "#1234608", "Nelson ", "(251) 573-0976", "Utah", "Mulberry Lane", 3, "84653" },
                    { 40, "Salem", "mckenzie.wilderman@gmail.com", "Justin", "#1234607", "Gonzalez ", "(505) 673-4412", "Utah", "Pine Street", 3, "84653" },
                    { 39, "Salem", "paxton.vandervort@roberts.info", "Larry", "#1234606", "Baker ", "(942) 734-0461", "Utah", "Park Avenue", 3, "84653" },
                    { 38, "Salem", "jake77@cole.biz", "Jonathan", "#1234605", "Adams ", "(608) 523-7789", "Utah", "Summit Avenue", 3, "84653" },
                    { 49, "Salem", "caden55@gmail.com", "Dennis", "#1234616", "Parker ", "(920) 664-6551", "Utah", "Hillcrest Avenue", 3, "84653" },
                    { 37, "Salem", "rhett.greenfelder@kirlin.org", "Stephen", "#1234604", "Green ", "(354) 319-7623", "Utah", "Buckingham Drive", 3, "84653" },
                    { 35, "Salem", "jaskolski.kaitlyn@quigley.net", "Nicholas", "#1234602", "Hill ", "(370) 728-6715", "Utah", "Virginia Avenue", 3, "84653" },
                    { 34, "Salem", "adolfo.dickinson@gmail.com", "Gary", "#1234601", "Lopez ", "(812) 899-0970", "Utah", "Franklin Court", 3, "84653" },
                    { 33, "Salem", "corkery.pinkie@parker.com", "Jacob", "#1234600", "Wright ", "(882) 994-9899", "Utah", "Cedar Avenue", 3, "84653" },
                    { 32, "Salem", "veda05@rutherford.com", "Ryan", "#1234599", "King ", "(769) 528-5967", "Utah", "Pheasant Run", 3, "84653" },
                    { 31, "Salem", "abraham93@witting.com", "Jeffrey", "#1234598", "Hernandez ", "(643) 525-9476", "Utah", "State Street East", 3, "84653" },
                    { 30, "Salem", "yesenia24@yahoo.com", "Jason", "#1234597", "Young ", "(690) 896-4303", "Utah", "Mulberry Court", 3, "84653" },
                    { 29, "Salem", "junius22@ullrich.info", "Timothy", "#1234596", "Allen ", "(466) 984-2480", "Utah", "B Street", 3, "84653" },
                    { 28, "Salem", "jamel03@hotmail.com", "Ronald", "#1234595", "Hall ", "(363) 694-3872", "Utah", "Laurel Drive", 3, "84653" },
                    { 27, "Salem", "ostamm@hotmail.com", "Edward", "#1234594", "Walker ", "(253) 677-8238", "Utah", "3rd Avenue", 3, "84653" },
                    { 25, "Salem", "thettinger@shanahan.com", "Kevin", "#1234592", "Lewis ", "(377) 301-4350", "Utah", "Arlington Avenue", 3, "84653" },
                    { 36, "Salem", "aniyah27@wehner.info", "Eric", "#1234603", "Scott ", "(921) 356-0929", "Utah", "Chapel Street", 3, "84653" },
                    { 100, "Salem", "raul38@yahoo.com", "Bradley", "#1234667", "Griffin ", "(409) 855-1819", "Utah", "Canterbury Road", 3, "84653" }
                });

            migrationBuilder.InsertData(
                table: "Contract",
                columns: new[] { "ContractID", "EndDate", "StartDate", "UnitID", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, 5 },
                    { 73, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 172, 77 },
                    { 72, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 76 },
                    { 71, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 170, 75 },
                    { 70, new DateTime(2020, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 169, 74 },
                    { 69, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 168, 73 },
                    { 68, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 167, 72 },
                    { 67, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 166, 71 },
                    { 66, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 165, 70 },
                    { 65, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 164, 69 },
                    { 64, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 163, 68 },
                    { 63, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2004, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 162, 67 },
                    { 62, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2002, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 161, 66 },
                    { 61, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2001, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 160, 65 },
                    { 60, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2001, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 159, 64 },
                    { 59, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 158, 63 },
                    { 58, new DateTime(2020, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 157, 62 },
                    { 57, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 156, 61 },
                    { 56, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 155, 60 },
                    { 55, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 154, 59 },
                    { 54, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 153, 58 },
                    { 53, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 152, 57 },
                    { 74, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 173, 78 },
                    { 52, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 151, 56 },
                    { 75, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 174, 79 },
                    { 77, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 176, 81 },
                    { 100, new DateTime(2020, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 199, 98 },
                    { 94, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 193, 98 },
                    { 99, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 198, 97 },
                    { 93, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 192, 97 },
                    { 98, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 197, 96 },
                    { 92, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 191, 96 },
                    { 97, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 196, 95 },
                    { 91, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 190, 95 },
                    { 90, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2007, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 189, 94 },
                    { 89, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 188, 93 },
                    { 88, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 187, 92 },
                    { 87, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 186, 91 },
                    { 86, new DateTime(2020, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2002, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 185, 90 },
                    { 85, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 184, 89 },
                    { 84, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 183, 88 },
                    { 83, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 182, 87 },
                    { 82, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 181, 86 },
                    { 81, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 180, 85 },
                    { 80, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 179, 84 },
                    { 79, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 178, 83 },
                    { 78, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 177, 82 },
                    { 76, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 175, 80 },
                    { 51, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 150, 55 },
                    { 50, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 149, 54 },
                    { 49, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 148, 53 },
                    { 22, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 121, 26 },
                    { 21, new DateTime(2020, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 120, 25 },
                    { 20, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 119, 24 },
                    { 19, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 118, 23 },
                    { 18, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 117, 22 },
                    { 17, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 116, 21 },
                    { 16, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 115, 20 },
                    { 15, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 114, 19 },
                    { 14, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2007, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 113, 18 },
                    { 13, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 112, 17 },
                    { 12, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 111, 16 },
                    { 11, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 110, 15 },
                    { 10, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 109, 14 },
                    { 9, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 108, 13 },
                    { 8, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 107, 12 },
                    { 7, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2001, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 106, 11 },
                    { 6, new DateTime(2020, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 105, 10 },
                    { 5, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 104, 9 },
                    { 4, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 103, 8 },
                    { 3, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 102, 7 },
                    { 2, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 101, 6 },
                    { 23, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 27 },
                    { 24, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 123, 28 },
                    { 25, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 124, 29 },
                    { 26, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 125, 30 },
                    { 48, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 147, 52 },
                    { 47, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 146, 51 },
                    { 46, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 145, 50 },
                    { 45, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 144, 49 },
                    { 44, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 143, 48 },
                    { 43, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 142, 47 },
                    { 42, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 141, 46 },
                    { 41, new DateTime(2020, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 140, 45 },
                    { 40, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 139, 44 },
                    { 39, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 138, 43 },
                    { 95, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 194, 99 },
                    { 38, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 137, 42 },
                    { 36, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 135, 40 },
                    { 35, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2004, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 134, 39 },
                    { 34, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2004, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 133, 38 },
                    { 33, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2002, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 132, 37 },
                    { 32, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, 36 },
                    { 31, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 130, 35 },
                    { 30, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 129, 34 },
                    { 29, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 128, 33 },
                    { 28, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 127, 32 },
                    { 27, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 126, 31 },
                    { 37, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 136, 41 },
                    { 96, new DateTime(2040, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 195, 100 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contract_UnitID",
                table: "Contract",
                column: "UnitID");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_UserID",
                table: "Contract",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_UnitTypeID",
                table: "Unit",
                column: "UnitTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserTypeID",
                table: "User",
                column: "UserTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contract");

            migrationBuilder.DropTable(
                name: "Unit");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UnitType");

            migrationBuilder.DropTable(
                name: "UserType");
        }
    }
}
