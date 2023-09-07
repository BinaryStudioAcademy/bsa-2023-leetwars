using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeetWars.Core.DAL.Migrations
{
    public partial class ChangeChallengeVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_ChallengeVersions_ChallengeVersionId",
                table: "Tests");

            migrationBuilder.DropIndex(
                name: "IX_Tests_ChallengeVersionId",
                table: "Tests");

            migrationBuilder.AddColumn<string>(
                name: "ExampleTestCases",
                table: "ChallengeVersions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PreloadedCode",
                table: "ChallengeVersions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TestCases",
                table: "ChallengeVersions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ChallengeId", "CreatedAt", "CreatedBy", "ExampleTestCases", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 10L, new DateTime(2023, 5, 7, 12, 12, 26, 439, DateTimeKind.Utc).AddTicks(8347), 8L, "Est aut repellendus qui fugit. Sed fugit explicabo autem cum consequuntur alias. Quo alias et quisquam voluptates. Nisi voluptatem omnis inventore velit ipsum maxime fuga.", 4, "", 2, "Dolores nostrum earum deleniti iusto aut nesciunt modi et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 40L, "odit", new DateTime(2023, 3, 12, 17, 32, 36, 42, DateTimeKind.Utc).AddTicks(9774), 34L, "Vel voluptatum quia quia nesciunt sequi impedit.\nVoluptas repellat nam omnis est magnam rerum eum repudiandae minima.\nQuis atque reprehenderit accusamus dolore est ratione maiores non et.\nSequi minima pariatur dignissimos eum eligendi dolorum.\nCum voluptatibus quibusdam corporis saepe dolores.", "Et fugit vero vitae.", 2, "", "amet" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 47L, "Officiis ducimus aut dolorem sit dicta ullam.", new DateTime(2021, 6, 19, 9, 53, 7, 984, DateTimeKind.Utc).AddTicks(6937), 25L, "maxime", "Amet voluptates temporibus esse magni.", "", 3, "Minima accusamus magnam quia laudantium id ut corrupti. Et id nulla nesciunt. Nesciunt minima cupiditate. Dolore corrupti iusto ipsam sapiente." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 57L, "Molestiae hic et officiis accusantium nostrum repellat aut et.\nItaque animi eveniet ut delectus voluptates dolorem.\nLaudantium itaque sequi officiis sapiente et.", new DateTime(2023, 4, 2, 19, 0, 1, 638, DateTimeKind.Utc).AddTicks(5900), 27L, "Non porro impedit.", "Quis perferendis et pariatur sapiente repellat quasi.", 3, "", 2, "Exercitationem dolorem adipisci veniam blanditiis quidem earum tempore molestias." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 60L, "Sit molestiae adipisci repellat eum vel dolorum aut ullam distinctio.\nOmnis animi officiis tenetur.", new DateTime(2019, 4, 30, 1, 12, 24, 218, DateTimeKind.Utc).AddTicks(7390), 9L, "Libero dolorem voluptatem et vitae eius nemo.", "Fugit mollitia aut ab eum est quaerat consequatur.", 1, "", "Aliquid neque nemo dolore possimus.\nOptio veniam ratione qui nulla vel in aut.\nVel sit repellendus cupiditate quo quo.\nSunt unde ex doloremque necessitatibus quo veniam dolor officiis eos.\nExplicabo enim necessitatibus soluta est libero voluptatum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 69L, "Culpa maiores officiis deleniti cumque similique optio et sed ab. Quis voluptatem et veniam iusto rerum. Provident inventore voluptas nihil rerum totam expedita hic. Sint rerum earum facilis iusto unde nihil officia minima. Id occaecati quod. Laborum illo ipsum fuga ratione ipsa sequi.", new DateTime(2023, 1, 17, 0, 32, 7, 98, DateTimeKind.Utc).AddTicks(3807), 25L, "Qui placeat facere omnis ea quia.", "Commodi architecto omnis necessitatibus est eum.", "", 2, "Dolor nesciunt sit itaque quidem debitis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 63L, "Est totam voluptas excepturi et expedita dignissimos et. Atque aut est et. Recusandae rerum dolor assumenda maiores placeat magnam debitis. Facilis velit et qui totam et iusto consequatur ut. Et tempora officiis error enim nulla.", new DateTime(2023, 4, 17, 20, 56, 39, 527, DateTimeKind.Utc).AddTicks(7376), 13L, "Debitis consequuntur perspiciatis dolorum architecto placeat error eum aut repellendus. Est cumque velit aspernatur voluptatum fugiat. Consequatur est voluptatum natus sed qui atque inventore beatae totam.", "Iure nisi voluptatem.", 4, "", 1, "suscipit" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 55L, "Quia commodi non quis voluptatem ea.\nQuis dignissimos ipsam et in dolores perferendis.\nAspernatur praesentium sint quis eos et at iusto.\nOfficia harum in ab at at dolorem qui nobis.", new DateTime(2023, 3, 18, 6, 8, 10, 687, DateTimeKind.Utc).AddTicks(7400), 32L, "Et illo voluptas culpa ea ducimus ea.\nEt eum est est neque qui.\nVoluptatem unde voluptatem non.", "Voluptas veniam rerum sed qui ipsam accusamus fuga id.", 2, "", 2, "rerum" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 66L, "Quis voluptatem autem voluptas ducimus maiores praesentium odit error adipisci. Vitae eligendi consequatur laboriosam commodi atque. Dolor eos est repellat enim aliquam ratione. A voluptatem assumenda delectus quaerat est recusandae aliquam provident. Rerum eius accusamus rerum recusandae cum et officia odit aliquid. Corrupti repellat aliquid dolorum iste quia voluptatibus dolores nostrum ab.", new DateTime(2023, 4, 29, 2, 55, 5, 570, DateTimeKind.Utc).AddTicks(2157), 6L, "Suscipit animi recusandae quo voluptatem odio.\nEsse quam ut optio quo non.", "Officia quos laboriosam porro aut consequuntur.", 1, "", "dolor" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 16L, "Sint dolores laboriosam totam. Reprehenderit sed blanditiis perferendis qui non aliquid vero. Ab eaque ea consequatur aut.", new DateTime(2022, 11, 6, 2, 49, 41, 558, DateTimeKind.Utc).AddTicks(3947), 37L, "sed", "Totam voluptatem quam ut cumque sint tenetur sed et debitis.", 3, "", 1, "Natus esse sint magnam incidunt velit adipisci voluptatem." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 2L, "Vitae aut molestias pariatur expedita provident ex beatae nihil numquam. Adipisci consequatur eos dolor quae sit. In esse et veniam.", new DateTime(2020, 10, 23, 16, 22, 6, 922, DateTimeKind.Utc).AddTicks(8475), 23L, "Et dignissimos omnis veniam.\nDoloribus dolorem et accusamus nostrum aliquam aut repellat tenetur.\nQuia impedit ut.", "Laudantium accusantium possimus mollitia totam blanditiis odio corrupti asperiores.", 2, "", 2, "Repellendus labore aut aut. Quaerat iure voluptatem exercitationem ut ut. Facere similique molestiae. Ex sit magnam animi natus deserunt voluptas." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 48L, "Rerum quaerat perferendis iusto ea et.", new DateTime(2023, 5, 10, 18, 40, 15, 873, DateTimeKind.Utc).AddTicks(6385), 34L, "Suscipit exercitationem error iure rerum.\nEt autem culpa nemo delectus voluptates.\nPariatur ut nihil.", "Quaerat hic facilis quod expedita adipisci voluptates molestiae qui.", "", 1, "cumque" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 63L, "Consequatur et ut dolor ut enim atque. Quia nobis dicta reiciendis. Doloribus qui perferendis odio ratione. Magnam atque minus. Minus rem voluptatum amet a dolorem modi. Qui quia commodi perferendis.", new DateTime(2020, 12, 2, 3, 33, 46, 631, DateTimeKind.Utc).AddTicks(7691), 13L, "nihil", "Natus explicabo repudiandae optio totam architecto sequi blanditiis.", 2, "", 2, "repellat" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 52L, "Deserunt veritatis ad perferendis et nihil autem quia cupiditate.", new DateTime(2022, 11, 26, 17, 39, 4, 494, DateTimeKind.Utc).AddTicks(7385), 2L, "Maiores aut aliquid perferendis adipisci odio expedita ex nulla.\nIste aliquam ex repudiandae atque beatae.\nExcepturi illum et.\nCorporis quod eius vel ut repudiandae et.\nEt voluptas corrupti voluptas quaerat.", "Fugit error nihil aut veritatis quo.", "", 2, "maiores" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 34L, "Voluptatum quod sit voluptas nobis ut magni harum expedita non.", new DateTime(2022, 10, 1, 23, 20, 22, 39, DateTimeKind.Utc).AddTicks(3437), 24L, "Dicta rerum omnis voluptatem consectetur. Id et nihil. Maxime dolorem recusandae necessitatibus dolores ea velit vero laboriosam. Quaerat doloribus omnis iure rerum magnam perspiciatis necessitatibus et.", "Dolor labore numquam at praesentium ea ut aut rerum.", 4, "", 3, "Tempora explicabo quasi esse aspernatur suscipit facere perspiciatis inventore asperiores." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 15L, "Officia neque ducimus aliquam eos.\nDolores est tempore doloremque aspernatur consequuntur autem beatae.\nQuos quo sit nulla autem hic dolore eveniet nostrum voluptatem.", new DateTime(2023, 3, 16, 23, 34, 30, 677, DateTimeKind.Utc).AddTicks(2515), 8L, "A velit laudantium cupiditate veritatis ex sunt aspernatur quidem.", "Ut consequatur laborum laudantium quos consequatur inventore.", 4, "", 1, "et" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 14L, "Explicabo ipsa cum.\nAutem nisi voluptatem sequi aut aut nulla quod voluptas.\nFugiat harum id enim quisquam at reprehenderit beatae.\nHarum doloremque assumenda laboriosam saepe.", new DateTime(2023, 2, 11, 0, 37, 3, 210, DateTimeKind.Utc).AddTicks(3537), 34L, "Aliquid ratione quisquam molestiae ipsam commodi.", "Et eius asperiores.", 2, "", 0, "Ut accusamus voluptas. Nesciunt repellendus expedita est perferendis dolorem earum provident distinctio. Animi quam consectetur ipsum et. Soluta vel tempore est perferendis temporibus quae. Est consequatur quis commodi ipsum veritatis in officiis et. Cum nulla rerum fuga impedit doloremque qui unde deserunt." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 38L, "Dolores sit libero inventore odit.\nNesciunt totam velit omnis ea quaerat vero est.\nVero optio consequuntur tempore est consequatur.\nOdit quia perspiciatis cumque in.", new DateTime(2023, 5, 31, 11, 12, 37, 575, DateTimeKind.Utc).AddTicks(179), 16L, "Sit amet repudiandae unde excepturi ea et veniam veniam.\nNemo cumque ea ab.", "Dolorem vitae consequatur qui in ea animi autem.", 2, "", 0, "Rem cumque at consequatur tempora et facilis corporis ut iste. Autem ipsum sapiente. Qui ratione et dolores quas ut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 26L, "optio", new DateTime(2023, 3, 15, 8, 30, 37, 186, DateTimeKind.Utc).AddTicks(523), 36L, "Unde animi sed et illo. Sunt iure unde fugit animi. Et dolorem sed ipsum atque reiciendis corporis blanditiis qui. Reprehenderit culpa sint impedit. Dolor maiores eius dolore repellat sunt velit labore dolores. Nesciunt libero inventore cupiditate doloribus ab quia et ab.", "Et harum dolores.", "", 0, "Id nobis dicta consequatur facilis quae deleniti eaque doloribus.\nAutem earum quos.\nExplicabo delectus expedita quisquam quam aspernatur vel animi nostrum.\nNecessitatibus itaque adipisci optio ab est pariatur." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 35L, "Accusamus animi maxime molestiae qui. Voluptas quia enim. Recusandae ea dicta numquam. Accusamus qui atque dolorum odit non quis molestias.", new DateTime(2023, 5, 24, 1, 46, 59, 125, DateTimeKind.Utc).AddTicks(4963), 2L, "nostrum", "Quos reprehenderit saepe voluptate quia ut culpa ut molestias.", 2, "", "Quis nemo culpa voluptatem omnis minus deserunt quisquam nemo.\nCorporis rerum dolor sed omnis.\nError dolore praesentium quos quia asperiores et impedit tenetur voluptatem." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 23L, "Molestias nihil quas omnis delectus consequatur quaerat.", new DateTime(2023, 8, 28, 3, 46, 25, 882, DateTimeKind.Utc).AddTicks(2503), 30L, "Officiis consequatur non natus ullam voluptatem.\nNon quaerat omnis accusantium ea provident eius sunt iste.\nCum a dicta et ratione.", "Possimus sit maxime doloribus est velit vel commodi et.", "", 2, "vel" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 65L, "quidem", new DateTime(2022, 9, 1, 12, 8, 35, 54, DateTimeKind.Utc).AddTicks(1807), 36L, "earum", "Fugiat consequatur ipsam dolore laudantium culpa accusamus fuga.", 3, "", "Nesciunt nemo placeat.\nQui voluptatem maxime ut cumque reiciendis dolores unde." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 68L, "Doloribus laboriosam quo eligendi quidem non porro est qui magni.\nDolor optio magnam quidem qui cumque hic maxime tenetur.", new DateTime(2023, 3, 8, 6, 45, 44, 342, DateTimeKind.Utc).AddTicks(7273), 22L, "Eveniet et et in quis. Ea ut quidem eius animi. Tempora in consequatur voluptas velit cum dolore dolorum ut vitae. Voluptatem sed dolore ducimus officiis non possimus voluptatem. Voluptatibus iure quod veniam et nostrum neque. Totam non veritatis aperiam aperiam aliquam rem autem vel.", "Consequuntur vel ducimus ducimus dolor eveniet tenetur ut hic qui.", 1, "", 1, "delectus" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 55L, "eaque", new DateTime(2022, 11, 8, 6, 54, 39, 631, DateTimeKind.Utc).AddTicks(6502), 25L, "Ut ullam et ab omnis odit vitae maiores. Maiores totam dolore voluptatem repellendus doloribus et beatae laudantium. Neque quos voluptates. Quis vel iure blanditiis dolorem mollitia.", "Vel animi placeat.", 4, "", 1, "Debitis adipisci eaque voluptates voluptas fugiat vitae consectetur voluptates. Nihil voluptatem illo voluptatem laborum veniam hic. Architecto dolores aut quibusdam minus doloremque maxime aliquid molestiae. Ut explicabo consequuntur delectus maiores blanditiis sit quo." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 61L, "optio", new DateTime(2023, 4, 27, 1, 45, 24, 794, DateTimeKind.Utc).AddTicks(2354), 28L, "Labore reprehenderit est sint iure tenetur numquam dolor.\nQuia dolore temporibus rem suscipit excepturi dicta quas.\nOmnis cumque pariatur sapiente.\nAd dolorem autem minus in ullam quam.\nEt ullam unde molestias natus ad quod reiciendis dolor atque.\nQuia quod recusandae quia voluptas.", "Velit dolor maxime tenetur molestiae distinctio commodi.", 4, "", 3, "Eos sit repellat et aut autem maiores sit qui." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "TestCases" },
                values: new object[] { 25L, "Nisi quos molestiae. Hic consequatur omnis voluptatem mollitia eius deserunt possimus repellendus. A laudantium delectus sed qui.", new DateTime(2022, 12, 17, 19, 1, 38, 438, DateTimeKind.Utc).AddTicks(6072), 8L, "Et veritatis voluptatem dolorum corporis qui aut quibusdam. Sunt porro id. Adipisci aliquam impedit iure saepe dolores voluptatum corporis voluptas.", "Velit repellendus ad accusamus autem facere deserunt eius illum.", "", "Aut omnis incidunt.\nEveniet doloribus eum sapiente libero vel voluptatibus et.\nPorro ea earum repudiandae sunt sint accusamus.\nReiciendis consectetur sint dicta eaque.\nMagni aliquam minima atque atque qui quis reprehenderit neque.\nQuaerat repudiandae est assumenda harum omnis numquam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "TestCases" },
                values: new object[] { 5L, "Omnis et incidunt distinctio dolor.\nDoloremque quos ut deserunt debitis et illo culpa.\nMolestiae neque voluptatem minima eligendi ducimus repudiandae.\nTempore delectus consequuntur cum aut dolor eligendi mollitia aut.\nSunt rerum amet voluptatum qui porro fugiat dignissimos.\nInventore facilis totam consequatur consequuntur error officia optio ut.", new DateTime(2023, 7, 26, 10, 57, 35, 699, DateTimeKind.Utc).AddTicks(7971), 21L, "Nihil atque molestiae. Excepturi praesentium qui alias hic sint aperiam nam pariatur nihil. Atque est error ipsa facilis fuga. Dolore eum illo voluptatem reiciendis. Dolor inventore ex minus. Accusamus mollitia fugiat.", "Dolorum molestiae reiciendis.", "", "Voluptas quidem labore iste.\nIllo maiores sit ipsam sunt repellat et delectus.\nItaque voluptas ducimus iusto id dignissimos.\nHarum vero dolor sed." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 60L, "Neque ut mollitia aut corrupti deleniti. Modi necessitatibus error corporis laborum voluptatibus eum. Laboriosam officia dolorem sed eveniet est rerum porro. Fugit molestiae sequi quasi velit cupiditate.", new DateTime(2023, 4, 1, 13, 16, 5, 363, DateTimeKind.Utc).AddTicks(9452), 32L, "In nesciunt beatae vel.", "Autem non in itaque deserunt dolorem dolores quis provident rerum.", 2, "", 2, "Vel iusto mollitia unde dolor et voluptatem tempora.\nAtque sapiente aspernatur voluptas laborum asperiores totam aperiam.\nRem eum blanditiis et ad sint dolorem voluptas veritatis voluptas.\nVel consequatur at corrupti voluptates animi.\nQuasi autem voluptate voluptatem excepturi libero.\nIn possimus sit temporibus vel nesciunt id autem culpa et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 33L, "animi", new DateTime(2023, 3, 27, 21, 45, 0, 436, DateTimeKind.Utc).AddTicks(2426), 20L, "Fugiat reiciendis dolore dolorem pariatur iusto repellendus laborum veritatis. Voluptatem ut doloribus velit asperiores quam illum necessitatibus. Veniam facilis est. Et natus sed dolores ipsa. Iste blanditiis placeat. Voluptatem perspiciatis iusto mollitia provident.", "Aut est esse.", 4, "", "Sed quia accusamus temporibus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 37L, "Aut est dignissimos. Facilis ullam maxime in quas numquam enim. Tempore et natus dolorem veniam sapiente mollitia hic ratione quia. Consequatur consectetur quibusdam nemo et et et. Maiores eligendi velit iusto eum voluptatem molestiae.", new DateTime(2022, 12, 12, 3, 31, 7, 580, DateTimeKind.Utc).AddTicks(1596), 30L, "Sapiente voluptatibus delectus est recusandae neque rerum aut.\nMaiores harum esse nulla doloribus dolore suscipit alias expedita quis.\nRem et qui tempore ex.\nMolestiae commodi modi magni dicta explicabo assumenda veritatis.", "Doloribus consequatur voluptate eum perspiciatis temporibus illo eveniet.", 2, "", 1, "Officia et quae sed." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 69L, "Et ipsum voluptatem provident magnam exercitationem quam quaerat id ad.\nAut ut ut est repellendus est qui illo.", new DateTime(2022, 10, 17, 19, 59, 29, 938, DateTimeKind.Utc).AddTicks(8682), 19L, "Nulla labore dolore voluptatem. Dicta quia distinctio mollitia et consequatur voluptatem maiores. Commodi dicta omnis deleniti optio. Reiciendis eos et provident laborum provident assumenda nulla ut ut. Id consequatur eos. Voluptatem quos aliquam fugit porro eligendi aut.", "Illo tempora et nulla sint molestias odio sit laboriosam.", "", 3, "Laudantium velit et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 56L, "Voluptatem ea eligendi.", new DateTime(2019, 8, 22, 4, 28, 29, 328, DateTimeKind.Utc).AddTicks(7048), 17L, "tempora", "Tempore vel nihil voluptas incidunt earum dolor maiores qui quo.", 2, "", 3, "Eveniet nulla id laboriosam.\nCupiditate commodi voluptatibus magnam explicabo consequatur libero.\nRatione praesentium aut ipsum officia unde magnam autem.\nSapiente officia odio dolor voluptas perferendis.\nSit amet nihil sed harum similique." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 58L, "beatae", new DateTime(2020, 8, 14, 2, 10, 16, 192, DateTimeKind.Utc).AddTicks(7323), 32L, "Distinctio omnis quia. Ducimus hic est ea itaque ut ullam molestiae nobis. Maxime repellat id autem quae aut reiciendis nihil.", "Vitae quia repudiandae perferendis ut rerum sint amet.", 4, "", 0, "Aut voluptatem ut consequatur soluta aliquid.\nSint et iure totam veritatis in ut.\nVoluptas aut est nulla consequuntur qui aut.\nCupiditate voluptas in quis aut qui.\nNisi libero aut.\nUt beatae et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 67L, "Impedit fuga beatae illum necessitatibus ut earum autem temporibus repudiandae.", new DateTime(2023, 4, 2, 1, 39, 35, 283, DateTimeKind.Utc).AddTicks(9945), 36L, "Quis fugit ullam incidunt numquam consequatur omnis reiciendis aperiam. Vel nesciunt magni ut. Aliquid eveniet voluptatem porro.", "Necessitatibus et voluptate eum iusto autem.", 3, "", 1, "Ut laboriosam inventore non fugit. A consequatur aliquid. Est eligendi quia sint odio earum totam asperiores." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 40L, "Sunt et natus inventore tempora possimus cumque eveniet quasi adipisci. Voluptatem et fugiat. Architecto aut minima deserunt similique tempore quia. Voluptas non ut accusamus odit provident iste quaerat.", new DateTime(2023, 6, 2, 2, 25, 28, 73, DateTimeKind.Utc).AddTicks(8519), 38L, "quisquam", "Nobis qui quas.", 2, "", 1, "porro" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 27L, "quaerat", new DateTime(2022, 9, 2, 9, 47, 33, 214, DateTimeKind.Utc).AddTicks(1191), 32L, "Et beatae aperiam et ut delectus aut. At aliquid rerum nihil. Illo magni autem sit odio at deleniti. Odit voluptatibus debitis quaerat autem.", "Nihil facilis enim et.", 4, "", 2, "Voluptatum modi quaerat placeat et sint dolores.\nConsequuntur doloribus rerum mollitia consequatur sint itaque ut.\nVoluptate fugit labore quas dolores nisi alias.\nMagnam provident quam et necessitatibus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 9L, "Eaque harum dignissimos nemo architecto et qui in ullam assumenda.", new DateTime(2022, 12, 26, 6, 41, 54, 15, DateTimeKind.Utc).AddTicks(2106), 7L, "ut", "Est vitae ducimus.", 2, "", 3, "in" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 32L, "Illo fugit recusandae explicabo cupiditate est. Voluptatum voluptatibus aut voluptate ipsum minima blanditiis voluptas. A est quibusdam voluptatibus tempore saepe. Rerum consequatur sint harum nisi maxime et ipsa rem.", new DateTime(2023, 8, 28, 4, 7, 16, 210, DateTimeKind.Utc).AddTicks(3437), 18L, "Quasi dolor inventore.", "Sequi est deserunt.", 2, "", "Accusantium laudantium sed dolore officia impedit similique. Facilis porro et rerum ea aliquam cum est maiores quia. Omnis nesciunt sit quae veniam id. Aliquid qui omnis voluptas itaque quis est vero illum sit. Commodi quia ad aut aut eos ipsum sit aperiam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 6L, "Ut et odio distinctio saepe. Delectus neque tempore amet adipisci debitis aut. Cumque voluptatem distinctio assumenda impedit quidem quo. Quam quia animi quo quisquam deserunt repudiandae ut animi. Reprehenderit voluptas et est est. Rerum iusto sit veniam dolor magnam.", new DateTime(2023, 4, 27, 5, 37, 36, 317, DateTimeKind.Utc).AddTicks(6843), 3L, "et", "Sint facilis laborum ea quo quis.", 2, "", 1, "Illum architecto repudiandae explicabo quia id ipsum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 31L, "Ad nemo iste fuga ipsum fuga inventore voluptatem facilis soluta.", new DateTime(2023, 8, 2, 6, 17, 25, 115, DateTimeKind.Utc).AddTicks(6051), 24L, "Quisquam eveniet quo rerum consequatur et est repellat aperiam quaerat.", "Quis dolore voluptate officia itaque atque quaerat voluptas molestiae laborum.", 3, "", 1, "Dicta magnam laboriosam consequatur optio suscipit aliquid eum provident sapiente. Assumenda nam natus. Iste enim maiores." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 57L, "Nisi occaecati at molestias veritatis alias laudantium suscipit. Suscipit ipsum minima consectetur esse reprehenderit natus temporibus. Aliquid autem ad ut est blanditiis architecto impedit.", new DateTime(2023, 4, 8, 6, 48, 16, 380, DateTimeKind.Utc).AddTicks(1296), 4L, "Sit aliquid modi aliquid ut sint. Voluptas ab perferendis odit beatae. Sunt totam velit nobis velit. Natus delectus enim dolorem quod quas et. Asperiores cumque fuga necessitatibus error ut ab et velit aperiam.", "Et qui incidunt minima.", 1, "", 1, "Possimus sed sit libero sequi quos molestiae a in fuga. Sunt et alias sunt ratione enim distinctio vel non quo. Harum omnis quaerat totam beatae voluptates. Et ex quia eum quam recusandae. Voluptatem est eaque molestiae." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 36L, "Excepturi ducimus ipsa nihil maxime.\nAtque nulla sed iste ipsam veritatis nihil.", new DateTime(2022, 5, 7, 23, 50, 42, 114, DateTimeKind.Utc).AddTicks(489), 25L, "Enim autem error animi quia rem exercitationem ut nam sit. Ducimus qui enim et. Autem sed consectetur fuga accusamus. Omnis enim est voluptas est id debitis aperiam.", "Nesciunt quisquam nisi et error.", 1, "", 1, "perspiciatis" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 46L, "Natus sequi placeat. Est rerum dicta animi dolorem exercitationem. Veniam cumque est sunt harum voluptas expedita explicabo temporibus eveniet.", new DateTime(2022, 7, 7, 16, 5, 29, 270, DateTimeKind.Utc).AddTicks(568), 14L, "Aperiam qui asperiores temporibus id impedit dolores animi.", "Temporibus voluptates quia sunt consequuntur omnis eos laudantium est.", 4, "", "Autem et dolores sunt consequatur sunt.\nVero soluta voluptas ipsa est veniam facere.\nQuo occaecati vel repellat quos sint ipsa officiis odio.\nIncidunt dolorum aperiam expedita quis aut rerum libero." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 57L, "Totam omnis velit enim expedita nesciunt illo.", new DateTime(2023, 4, 21, 20, 52, 30, 345, DateTimeKind.Utc).AddTicks(3872), 4L, "Deserunt non ut. Itaque nostrum minima corrupti. Ex aut voluptatibus consequatur maxime. Esse quia voluptas.", "Eum enim vitae cum doloribus perspiciatis placeat maxime inventore.", 2, "", 1, "Sunt cupiditate voluptatem voluptatem dolor dolor odio earum autem. Aut non tempora ad aspernatur. Quia soluta quod." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 47L, "Fuga nulla ratione distinctio corporis perferendis cupiditate iste et laudantium. Delectus temporibus rem reiciendis sunt. Vel sint excepturi voluptas quo perferendis. Est provident recusandae. Id qui voluptatem. Magnam quam qui et neque qui sapiente veritatis quia.", new DateTime(2022, 1, 10, 9, 3, 19, 439, DateTimeKind.Utc).AddTicks(6792), 27L, "et", "Quia et non et tenetur autem aliquam ut provident corrupti.", 2, "", 0, "Praesentium vero nam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 53L, "Qui autem qui ut quo quis. Inventore voluptate nisi at qui laboriosam hic omnis iste tempora. Quis accusantium qui quasi ea facilis in tenetur facere et.", new DateTime(2020, 8, 27, 21, 36, 12, 244, DateTimeKind.Utc).AddTicks(6234), 12L, "consectetur", "Nam repellendus eum et perferendis.", 4, "", 2, "explicabo" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 49L, "A porro accusantium ad voluptas doloremque in illo id placeat.\nEt qui omnis et dicta delectus.\nNon distinctio voluptatum deserunt iure.\nEt voluptates doloremque in aut animi.\nCumque dolorem iusto asperiores eaque est illum magnam aut.\nEt qui vel eveniet illum ipsum consectetur dolor recusandae.", new DateTime(2023, 8, 17, 22, 40, 16, 755, DateTimeKind.Utc).AddTicks(1506), 29L, "alias", "Hic autem sit eius aliquam.", 4, "", 2, "Quos neque corrupti commodi sit omnis doloremque recusandae repellat qui." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 22L, "Id voluptas in architecto ut officiis.\nDistinctio hic harum nihil.\nRepellendus voluptatem aut ut.\nEos debitis non qui laudantium nihil animi dolorum aut.", new DateTime(2023, 1, 2, 11, 1, 26, 858, DateTimeKind.Utc).AddTicks(1156), 15L, "eveniet", "Enim voluptatem veritatis aut accusamus omnis qui.", 3, "", 2, "Recusandae repudiandae possimus aut id. Sequi nihil ut et. Deleniti perferendis possimus. Officiis dicta commodi quod." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 3L, "Quisquam hic magnam. Consequuntur hic unde ut. Qui qui consequuntur impedit quis qui. Quod eos autem qui aliquam animi inventore.", new DateTime(2023, 7, 21, 13, 15, 40, 269, DateTimeKind.Utc).AddTicks(1760), 13L, "Est et quia non molestiae iure architecto possimus architecto atque. Officiis aut optio natus cupiditate ipsam ipsa deleniti est sit. Nesciunt ex id unde mollitia et quia quia tempore voluptatibus.", "Quam et blanditiis et asperiores.", 2, "", "Id dolorum sint velit et expedita facilis quod esse et.\nSit et inventore aliquid est dolorem debitis rerum nesciunt.\nMagni quasi et quas vero ducimus aut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 41L, "rerum", new DateTime(2023, 6, 11, 0, 3, 57, 252, DateTimeKind.Utc).AddTicks(4638), 29L, "Est autem temporibus dolorem unde et vel voluptatibus in.\nMolestias et fugit rem dolorum sunt voluptatem veritatis qui.\nPossimus nisi veniam quis sapiente debitis.\nQuod nihil hic.\nQuas est natus labore quae.", "Nihil iure facere sed similique cum animi quaerat ut.", 3, "", 2, "Non minima ut impedit." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 37L, "quia", new DateTime(2022, 2, 24, 13, 49, 50, 784, DateTimeKind.Utc).AddTicks(3657), 28L, "Dolorum qui expedita autem expedita quaerat expedita esse.", "Nobis corrupti porro cumque eius distinctio enim.", 2, "", 2, "Explicabo ut explicabo quam.\nTempore temporibus quasi minima.\nBlanditiis consequatur quidem omnis incidunt sunt dolores odio." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 27L, "Inventore aperiam impedit et libero. Quod eligendi rerum voluptatem mollitia id. Est ullam voluptas hic sit quis rerum voluptas repellat est. Magnam vitae voluptatem et ipsam veritatis deserunt omnis dolorem. Animi omnis hic adipisci maiores maiores eligendi dolorem quod. Et dolor sint commodi expedita esse molestiae.", new DateTime(2022, 11, 10, 7, 13, 4, 777, DateTimeKind.Utc).AddTicks(5270), 23L, "Impedit ut tempore ut ut et aperiam vel. Qui similique ducimus et ut et. Consequatur aliquid sed. Libero at sequi quia harum aut perferendis. Nisi sit ut dolorem rem sit at culpa. Repudiandae rem eaque.", "Totam ut tenetur dolor autem ut.", 4, "", 2, "Sunt veritatis quaerat repudiandae. Qui dolorem quia autem qui natus illum omnis ratione. Sed illum possimus. Iure rerum itaque. Dolore quia rem similique ut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 27L, "At vitae laudantium animi minus atque exercitationem aperiam iure iste. Reiciendis id sed eius ut blanditiis. Vitae vel exercitationem incidunt officia eum ratione totam id commodi. Illum porro voluptas dolorem numquam repellat et rerum ipsam id.", new DateTime(2023, 7, 1, 23, 33, 43, 531, DateTimeKind.Utc).AddTicks(1951), 1L, "Quaerat eos qui cupiditate voluptas hic doloribus in.\nHarum officiis in quia enim architecto ab similique cum.", "Suscipit ad autem laudantium velit unde.", 3, "", 0, "Labore perferendis aut excepturi mollitia.\nNesciunt error maxime libero.\nQuos tempore fuga dolores quidem blanditiis ut maxime recusandae.\nSimilique quo beatae consequatur." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 7L, "Iusto corporis id.\nUt neque quisquam harum sint dolor qui.", new DateTime(2020, 4, 21, 8, 25, 30, 934, DateTimeKind.Utc).AddTicks(1369), 2L, "Quod porro aliquam minima libero porro est voluptas ipsam in.\nNon quibusdam sed assumenda consequatur rem occaecati suscipit sint qui.", "Consequatur iste amet tempore quia eveniet.", 3, "", 0, "Qui voluptas quos temporibus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 6L, "Vero sint reprehenderit a voluptatem.\nDolorem necessitatibus mollitia harum a fugiat voluptatem.", new DateTime(2023, 5, 8, 11, 47, 18, 307, DateTimeKind.Utc).AddTicks(2834), 17L, "labore", "Eum nisi dolor iure iure similique aspernatur corporis.", 3, "", 3, "Et sequi repellat et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 32L, "quae", new DateTime(2023, 8, 21, 21, 47, 43, 26, DateTimeKind.Utc).AddTicks(302), "Sit dicta ut.", "Similique ea optio.", 2, "", "Illum quia eos nihil similique qui voluptatem atque. Accusamus molestias nesciunt. Non tenetur earum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 40L, "Dolores nostrum sunt veritatis quidem. Odit et architecto. Reiciendis saepe ea voluptate possimus molestiae a earum veritatis qui. Cum voluptas et et eos dolorum. Id a harum veniam sint at blanditiis.", new DateTime(2023, 1, 13, 5, 22, 56, 45, DateTimeKind.Utc).AddTicks(7914), 10L, "adipisci", "Non eveniet in voluptates debitis.", 4, "", 0, "Vel repellat nesciunt.\nQuis fuga sed est eveniet.\nQui voluptatum tenetur.\nVel quia voluptatibus illum delectus voluptas repellat dolores laudantium cupiditate.\nSed veniam optio vel molestias hic." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 9L, "Consequatur optio totam enim.", new DateTime(2022, 1, 24, 22, 52, 37, 462, DateTimeKind.Utc).AddTicks(9926), 26L, "Ea provident modi.\nSuscipit in at voluptatibus quia porro nisi necessitatibus quia.", "Cumque ipsa blanditiis et quas.", 2, "", "Ea doloremque rerum provident harum voluptates aliquam nisi. Incidunt reprehenderit ipsum eaque minima voluptatem autem. Delectus reiciendis sint voluptatem quis ut aliquam sapiente dicta. Aut qui tempora et rerum. Nihil autem eveniet cum non." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 40L, "Optio modi commodi necessitatibus.\nEt facere ipsam ea et nobis.\nMagni voluptatem molestias quisquam placeat consectetur.\nCum voluptate quae.", new DateTime(2023, 3, 14, 19, 52, 47, 686, DateTimeKind.Utc).AddTicks(6985), 21L, "Dignissimos alias nam est vel quisquam est voluptatem enim.", "Culpa qui possimus minima dolorem facere at.", 2, "", 1, "Et animi aliquam inventore aspernatur deleniti repellendus. At fuga dolores reiciendis alias. Excepturi ea quia tempora earum eos aut perferendis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "TestCases" },
                values: new object[] { 48L, "quod", new DateTime(2023, 6, 10, 9, 50, 18, 760, DateTimeKind.Utc).AddTicks(5544), 1L, "sed", "Voluptatem eveniet fugit ad rerum.", "", "Ipsam ut qui sit consectetur voluptate.\nOdit atque et explicabo vel dolor omnis dolores aut ut.\nDolorum explicabo non eos sint et temporibus sapiente.\nQuod at possimus cumque aliquam consequuntur fugit dolores atque eum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 37L, "Consequuntur dignissimos veniam.\nVoluptatem ut incidunt incidunt esse voluptatem.\nEst repudiandae voluptas nobis et.\nEst ratione asperiores.\nEst quam perferendis voluptas enim quo qui.", new DateTime(2022, 8, 31, 13, 36, 24, 919, DateTimeKind.Utc).AddTicks(3498), 21L, "Et consequuntur nobis eum ipsa dolorem molestiae aut necessitatibus iste.\nEarum exercitationem qui consequatur et expedita molestias.", "Suscipit quisquam error eos.", 2, "", 3, "molestiae" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "TestCases" },
                values: new object[] { 28L, "dolor", new DateTime(2022, 9, 23, 0, 10, 27, 315, DateTimeKind.Utc).AddTicks(1079), 18L, "Velit et quas voluptas.", "Enim laborum quae.", "", "Veritatis quod veniam porro repellat ut perferendis. Modi voluptatibus nam explicabo saepe quasi. Perspiciatis ut et officia sint fugit tempore. Aut est nam natus. Quia id incidunt ut error reiciendis. Omnis ducimus est et quam dolores consequatur exercitationem quibusdam at." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 22L, "Sint consectetur asperiores explicabo optio voluptatem dolorem. Odit autem in quaerat voluptatem sed. Commodi dolorum saepe magnam molestias. Ut corrupti aut ad culpa ipsam. Et facilis vel quae sunt at non aut. Voluptate ratione eum.", new DateTime(2023, 4, 18, 8, 58, 7, 121, DateTimeKind.Utc).AddTicks(5877), 30L, "Eos repudiandae aut.", "Ipsum quasi suscipit tempore officia ea atque.", 4, "", 0, "est" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 58L, "Laudantium error ex dolorem voluptate quia aliquid. Non placeat quam veniam nulla. Rem accusamus commodi omnis. Iusto soluta ut eius perspiciatis quo qui.", new DateTime(2019, 12, 28, 6, 32, 48, 627, DateTimeKind.Utc).AddTicks(5963), 13L, "Quos ipsa sed dolorum quisquam nihil voluptatum. Ut voluptatem dicta laborum eum aperiam rem placeat. Vel laudantium accusamus harum libero. Reiciendis dolores nobis.", "Aliquam aperiam autem cumque voluptatibus illum sed.", 3, "", "Officia accusantium repellat. Magni et qui repellendus placeat qui voluptatum sapiente recusandae. Voluptas vitae ut consectetur neque tempora aut. Nisi quia maiores fugiat natus nisi." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 3L, "Nulla a quis. Dicta consectetur delectus ut blanditiis a dolorem. Modi corrupti aperiam facere et quam ipsa repudiandae aut amet.", new DateTime(2023, 6, 29, 23, 11, 19, 394, DateTimeKind.Utc).AddTicks(2216), 14L, "A molestias nihil dicta. Voluptas illo est nostrum repudiandae expedita eum labore a architecto. Impedit ut vitae et ut dicta enim velit. Consequatur nisi non non est. Modi qui rerum deserunt quas aperiam. Ut provident aut beatae.", "Nihil aut maiores et minus voluptates quia expedita dolores voluptatum.", 3, "", 2, "Perferendis praesentium aliquam aut autem nesciunt at.\nHic nostrum est eum enim non fugit qui fuga." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { "consectetur", new DateTime(2022, 4, 11, 16, 27, 57, 581, DateTimeKind.Utc).AddTicks(8882), 13L, "Laboriosam ea laboriosam nobis optio quisquam ut. Reprehenderit commodi eaque aliquam ut veritatis est velit eligendi. Maiores similique est saepe dignissimos sit ut ullam consequatur.", "Eos eum et vitae aut.", "", 3, "Omnis sed dolores nulla. Occaecati molestiae et et aliquid commodi similique optio ut. Omnis cumque necessitatibus quas ut error delectus modi." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 4L, "minima", new DateTime(2022, 6, 7, 21, 57, 0, 438, DateTimeKind.Utc).AddTicks(8334), 3L, "Et autem ullam perspiciatis aut dolores enim dignissimos. Et sunt et quaerat quis aperiam maxime similique. Voluptatibus sapiente est error. Quaerat perspiciatis ullam. Ut inventore nihil autem amet iusto possimus iusto. Nulla aperiam dolorem aperiam non corrupti voluptatem sint sit aspernatur.", "Corporis dolor accusantium explicabo delectus expedita facilis ullam necessitatibus.", 4, "", 0, "Dignissimos fuga commodi enim et consequatur quas vero.\nA consequatur laboriosam in ex ut.\nCulpa quae provident deleniti.\nAut qui odit est dolores nisi ut et maxime dolorem." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 51L, "Enim ut consectetur.", new DateTime(2022, 9, 9, 0, 38, 17, 233, DateTimeKind.Utc).AddTicks(4785), 21L, "Dolorem tempora aperiam iure et esse omnis. Distinctio omnis officia aspernatur dolores atque maxime in. Exercitationem minima quia sed. Ea voluptates nulla. Maiores blanditiis nemo nesciunt magni maxime repellat corrupti esse aut. Quo dolorum eum error.", "Quo earum sint ea suscipit ipsa repellat qui fugiat aperiam.", 1, "", 1, "Ut provident veritatis rerum.\nUt velit cupiditate labore ducimus quam est alias alias.\nVero ut dolores quo architecto iste et.\nCulpa sed quia.\nSed et fugit.\nAutem sed sunt sequi rerum accusamus saepe consectetur soluta rerum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 6L, "Perferendis quia dolorem consequuntur perspiciatis et molestiae aspernatur.\nQuas est nulla aut aut et.\nIusto nihil tempore ducimus natus voluptas voluptas aut voluptate.\nQuod animi nemo optio laborum voluptatum non ipsam rem.", new DateTime(2023, 8, 9, 6, 56, 17, 961, DateTimeKind.Utc).AddTicks(5824), 28L, "Non dolor expedita tenetur eos quia vel quia quia.", "Iure voluptatem laborum perspiciatis.", 4, "", 0, "Perferendis ipsum alias ea." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 32L, "Et nihil aliquam libero ipsa explicabo et fugit consectetur. Fugiat animi ad molestiae occaecati quos dolores consequuntur adipisci. Et ullam exercitationem esse consequuntur in cum magni voluptatem. Voluptatem dolorem animi unde voluptas facere et. Ipsa accusantium amet cum expedita.", new DateTime(2023, 8, 28, 3, 55, 12, 139, DateTimeKind.Utc).AddTicks(964), 7L, "Beatae labore magnam ad dolorem nihil voluptate est atque quam.\nNesciunt ducimus tempore aut nisi est.\nLaborum voluptate officiis rerum numquam sunt.\nDucimus porro ratione animi.\nExcepturi error omnis itaque error sunt.\nIn sed odit omnis.", "Quisquam facere debitis dolorem temporibus eligendi necessitatibus ipsum quidem.", 1, "", 0, "Omnis et quia in tempore. Officia facere enim ipsam magni voluptas ut. Quam consequatur quibusdam culpa qui libero. Est neque assumenda et consectetur dicta ipsum mollitia qui rerum. Dolores at accusantium consequatur a. Itaque sint in pariatur minima ducimus dolorum accusantium voluptas in." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 6L, "neque", new DateTime(2023, 5, 6, 1, 30, 24, 663, DateTimeKind.Utc).AddTicks(9217), "Inventore et vero vel. Aut porro aspernatur aut ut quas vero. Sit quia recusandae blanditiis dolorum rerum voluptas sint. Autem similique consequatur non consequuntur.", "Est illum nobis beatae eos asperiores velit aut iusto.", 1, "", 1, "autem" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 6L, "Aut qui delectus ut quos omnis veniam magnam.", new DateTime(2023, 7, 29, 22, 40, 38, 916, DateTimeKind.Utc).AddTicks(3986), 15L, "Beatae vel facilis officiis ipsum at.", "Reiciendis in amet corporis enim.", 4, "", 0, "Possimus ipsa non aliquam quo provident quis perferendis. Voluptatibus facilis perferendis expedita ea eum error. Repellendus recusandae harum ratione ullam veniam tempora sit." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 43L, "Doloribus provident totam.", new DateTime(2023, 8, 29, 21, 58, 53, 514, DateTimeKind.Utc).AddTicks(8506), 40L, "Aut explicabo aut sunt reiciendis voluptate iusto. Quibusdam temporibus quas commodi. Voluptatibus tempore saepe nesciunt recusandae neque ut dicta. Vel qui cumque enim.", "Et perferendis exercitationem id soluta blanditiis sunt enim.", 4, "", 2, "Blanditiis omnis nihil molestiae suscipit inventore non. Recusandae odit voluptatum neque. Suscipit nemo sed doloremque aut minima et pariatur natus. Est omnis quasi aut ut qui aut. Quia aliquam voluptatem et ipsam distinctio." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 57L, "Aliquid harum consequatur quia aperiam est ipsa cupiditate enim. Quisquam nesciunt qui harum dicta molestias error. Voluptatibus officiis impedit quas dolorem dignissimos aut dolore.", new DateTime(2023, 6, 2, 8, 45, 23, 687, DateTimeKind.Utc).AddTicks(6674), 15L, "Ut numquam expedita.\nHarum voluptatem repellat fugiat vel animi libero dolor.\nIpsa omnis nesciunt vitae.", "Facere nobis vel possimus.", 4, "", "Asperiores dolorem sint dolores consequuntur eos vel." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 66L, "officia", new DateTime(2021, 12, 2, 19, 38, 29, 600, DateTimeKind.Utc).AddTicks(229), 27L, "dolor", "Et non odit tempore qui.", 1, "", "Et consequatur assumenda eius. Accusamus aut ducimus aut et tempore rerum illum sint debitis. Delectus inventore delectus eum voluptates. Iste aut modi numquam non aliquid velit quibusdam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 17L, "Non at dolorum. Et consequatur rerum asperiores placeat. Blanditiis aperiam dolor sed saepe.", new DateTime(2023, 3, 5, 11, 15, 43, 195, DateTimeKind.Utc).AddTicks(4785), 23L, "Dignissimos quas delectus dolores voluptatem eius suscipit incidunt beatae. Nisi quis odit explicabo ipsa blanditiis voluptatibus. Voluptas a voluptatem eligendi odit veritatis aut ad. Magnam praesentium eligendi consequuntur est rerum. Assumenda et et. Similique quibusdam quaerat rerum sapiente voluptatem cupiditate.", "Sed voluptatibus repellat sint reprehenderit ea distinctio atque impedit amet.", "", 1, "Velit aliquid accusantium itaque.\nEum doloribus nemo velit modi id quas nisi iste consectetur.\nOptio non mollitia laborum hic et quia hic.\nFacilis perspiciatis aut numquam sequi.\nPossimus fugiat perferendis mollitia accusamus eaque deserunt accusamus temporibus.\nQuos laborum nam aliquam et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 41L, "Voluptas maiores omnis dicta est eum odio eligendi facilis quasi.", new DateTime(2022, 3, 11, 12, 57, 30, 8, DateTimeKind.Utc).AddTicks(1740), 35L, "Corporis quae inventore soluta magnam quam iste.\nCumque molestias sit quaerat eveniet exercitationem qui aperiam quia et.", "Sunt nam earum non facere.", 3, "", 3, "Et ea aut provident cumque soluta." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 64L, "Labore pariatur voluptatem nemo.", new DateTime(2020, 10, 19, 10, 20, 51, 881, DateTimeKind.Utc).AddTicks(4211), 8L, "Impedit rerum error nemo magni possimus veritatis occaecati dolores non.\nSequi quas cumque dignissimos necessitatibus voluptatibus et cumque molestias.\nPariatur praesentium distinctio.\nHic provident enim facilis suscipit assumenda nisi laborum optio quia.\nMollitia assumenda ab quibusdam at hic quidem quo aperiam accusamus.\nNam culpa ab quisquam et qui blanditiis autem vero.", "Sit omnis repudiandae.", 2, "", 1, "Earum cumque ea." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 67L, "ducimus", new DateTime(2023, 8, 4, 7, 23, 14, 242, DateTimeKind.Utc).AddTicks(3248), 30L, "Facilis id ad amet eaque ea aspernatur veniam. Eveniet rerum eum ut ipsam aut animi. Culpa voluptas mollitia et id quibusdam veritatis et voluptatem. Rerum fugiat aut ea id ex magnam dolorum eligendi. Enim eum numquam sapiente temporibus molestiae. Dolorum earum explicabo.", "Debitis neque omnis totam ut aut culpa provident exercitationem.", 4, "", 0, "Numquam placeat et consequuntur. Et eligendi deserunt laborum. Cupiditate nesciunt et ut molestiae eligendi blanditiis accusamus sunt. Architecto voluptatum tenetur. Voluptas repellat dicta ab possimus quas blanditiis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 70L, "Odio quos nisi accusantium et eligendi.\nSit corrupti placeat fugit harum minima.\nQuod dignissimos vero illo consequatur eligendi soluta commodi non.\nVoluptatem nam quo.", new DateTime(2023, 6, 18, 20, 12, 37, 957, DateTimeKind.Utc).AddTicks(2766), 15L, "Delectus sit officiis. Voluptatibus et aut animi consequatur atque magni earum quia dolor. Itaque laborum non voluptatem. Aut in provident culpa ex dolorum omnis odio. Aut inventore id similique velit. Rerum ipsa blanditiis aspernatur rerum repellat distinctio.", "Quia officia et earum non iure necessitatibus.", 2, "", 1, "Earum harum quas laboriosam corrupti natus ad sint dignissimos beatae. Aut quaerat consequuntur voluptatum sunt nemo explicabo. Assumenda non fugiat sunt." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "TestCases" },
                values: new object[] { 7L, "Aut error quibusdam.\nEt ea aspernatur sed dolore.\nNihil reprehenderit autem repudiandae qui modi eveniet nesciunt.\nVoluptatem quo odio vitae ut eos doloribus pariatur sed.\nVoluptas necessitatibus velit quia molestias iusto doloremque ratione placeat.", new DateTime(2021, 2, 1, 3, 47, 40, 258, DateTimeKind.Utc).AddTicks(9803), 1L, "Quasi eum mollitia assumenda sequi ut. Rerum officia amet modi modi omnis recusandae. Natus omnis consequuntur vel rerum ullam unde qui est.", "Animi deserunt eius.", "", "Praesentium esse dolorum sunt ab doloribus vero iusto autem. Veritatis illum aliquid aliquid provident atque quaerat nesciunt. Excepturi error optio deleniti consequatur aut enim et. Omnis beatae ratione suscipit explicabo voluptatum. Accusantium praesentium delectus dicta alias." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 57L, "voluptate", new DateTime(2023, 9, 1, 12, 1, 7, 953, DateTimeKind.Utc).AddTicks(3579), 5L, "ad", "Quidem occaecati totam.", 2, "", "Impedit sunt alias adipisci natus voluptatem accusamus. Corrupti sunt est voluptate enim. Est numquam neque cupiditate aut officiis necessitatibus inventore qui non. Occaecati unde cumque facere cupiditate cupiditate fugiat." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 65L, "Architecto rerum debitis perspiciatis laborum. Dolor voluptatum animi ipsa animi dolorem et delectus. Vel voluptatem eaque praesentium et sit illo. Cupiditate sit enim ducimus voluptatibus sequi nihil. Repellendus temporibus et ducimus rerum a animi distinctio omnis. Voluptate quas rerum reiciendis est sed facilis pariatur.", new DateTime(2022, 3, 7, 17, 10, 4, 776, DateTimeKind.Utc).AddTicks(368), 39L, "Iusto dicta laborum distinctio nesciunt enim sed.", "At dolorum laborum esse quis rerum omnis.", 1, "", 2, "Corporis aut et sit ut aliquid cupiditate nisi.\nAdipisci voluptatem saepe veniam.\nAutem alias sint molestiae at distinctio autem cumque ipsum.\nOmnis deserunt unde sit voluptatem et dolores mollitia vitae doloremque.\nSoluta culpa molestiae nostrum id beatae." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 32L, "Est consequatur aliquam.", new DateTime(2023, 8, 9, 13, 12, 46, 231, DateTimeKind.Utc).AddTicks(9400), 34L, "Iure sit aperiam tempore non necessitatibus sed soluta rerum maxime. A sed et aut quia qui autem. Et voluptate dolorem et eligendi. Nostrum blanditiis eum. Ducimus sed voluptatem non eum. Quia neque id at fugiat eligendi.", "Itaque asperiores totam possimus aut adipisci adipisci.", 3, "", 3, "Nihil sunt harum dolore qui inventore voluptatem id." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 67L, "commodi", new DateTime(2023, 1, 24, 5, 13, 2, 979, DateTimeKind.Utc).AddTicks(1974), 28L, "Id reprehenderit iusto perspiciatis iusto molestiae.\nVel impedit sapiente voluptate cupiditate non odit quo.\nLibero at voluptates consectetur aut soluta.\nDignissimos voluptas tempore reprehenderit nemo.\nEst qui aut non in a dolor perferendis voluptate.\nCumque reprehenderit et asperiores aut mollitia.", "Ducimus cumque itaque.", 4, "", 0, "Occaecati natus ea laboriosam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 47L, "Occaecati recusandae qui nemo deserunt magni. Expedita commodi quaerat qui. Quibusdam earum est vel.", new DateTime(2020, 12, 18, 17, 55, 27, 470, DateTimeKind.Utc).AddTicks(4374), 29L, "Sint non atque.", "Atque est qui nihil illo eaque asperiores nihil.", 2, "", "Ea fuga cum aperiam suscipit vel sed aut. Qui voluptatem nihil rerum nam asperiores perspiciatis inventore fugiat nostrum. Illum aut accusantium qui." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 8L, "Consequatur perspiciatis aut qui harum perspiciatis omnis.\nUt deleniti mollitia vero natus corporis et enim corrupti.\nAtque officiis repellat animi maiores modi cumque.", new DateTime(2017, 12, 18, 6, 51, 14, 205, DateTimeKind.Utc).AddTicks(9273), 38L, "Distinctio harum sint deleniti sint modi ut consequuntur dicta.", "Est voluptas ut aut molestiae reprehenderit nesciunt dolore.", 3, "", 2, "doloremque" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 43L, "sed", new DateTime(2023, 8, 23, 0, 13, 3, 341, DateTimeKind.Utc).AddTicks(9453), 17L, "Qui aliquam mollitia voluptate illo eveniet ex.", "Quia maiores laboriosam et.", 1, "", "Totam iste non.\nCulpa eligendi voluptatum sint amet eveniet et.\nVitae vel rerum vitae saepe ratione ea aut quis.\nAb praesentium repellendus ab porro.\nNon corporis quod asperiores et corrupti perferendis ea aut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 67L, "Dolore et mollitia consequatur. Architecto atque mollitia aut unde. Officiis repellat error molestiae sapiente aut sed aut eos. Qui sit eum eum at quaerat quidem sit quam. Laborum cupiditate eveniet est iusto dolores labore. Ut nobis autem aliquam ex aut.", new DateTime(2023, 1, 1, 21, 8, 22, 712, DateTimeKind.Utc).AddTicks(7831), 15L, "Ut voluptas sed nihil vel nulla in.", "Ut et expedita amet molestias facere est non aut expedita.", 3, "", 0, "Consectetur nisi similique et ut officiis maxime." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 10L, "Nostrum qui omnis.\nId omnis molestias.\nProvident qui nihil asperiores.", new DateTime(2022, 11, 30, 11, 4, 23, 834, DateTimeKind.Utc).AddTicks(7498), 28L, "Et molestias quis iure vel quos rerum consequatur.", "Asperiores laudantium accusamus cumque voluptas qui qui rem nam hic.", 4, "", 3, "Nam ea porro sapiente voluptate ad ut aut asperiores.\nAut nostrum asperiores ab labore vel voluptatem beatae maxime.\nConsequuntur eaque saepe molestiae in deserunt dolor.\nMinus dolorem impedit ut et animi.\nVoluptatem ut omnis itaque autem rerum aliquid natus eius.\nAtque sint vitae nostrum sint soluta repudiandae repellendus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 56L, "Voluptatum cum et sunt beatae cumque quia illum corrupti. Ducimus sit non quia facere hic dolorem consequuntur ullam. Voluptatibus minus dicta. Aut sed quo enim laboriosam non est fugiat tempore. Sequi eum atque exercitationem id autem impedit omnis laboriosam laboriosam.", new DateTime(2018, 7, 29, 2, 38, 50, 136, DateTimeKind.Utc).AddTicks(9359), 24L, "et", "Reiciendis culpa totam qui.", "", 2, "Totam quasi tempora et ullam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 17L, "et", new DateTime(2023, 7, 16, 18, 18, 35, 378, DateTimeKind.Utc).AddTicks(1177), 1L, "Assumenda dicta impedit voluptates facere dolor quia aspernatur.", "A et eos deleniti ad.", 2, "", "Et laudantium officiis.\nMolestias aliquid molestiae reprehenderit placeat voluptas." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 33L, "Ratione velit consequatur aliquid nulla est dolorem nemo.", new DateTime(2022, 12, 29, 0, 25, 2, 120, DateTimeKind.Utc).AddTicks(4784), 3L, "Iusto sed recusandae laborum nobis. Et laborum culpa. Ex voluptas et sint omnis eius quisquam. Ut atque consequuntur doloremque molestiae minus inventore qui impedit.", "Nulla architecto et ipsam consequatur nobis et quae corporis dolorem.", 1, "", "omnis" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 8L, "similique", new DateTime(2021, 11, 3, 6, 56, 52, 474, DateTimeKind.Utc).AddTicks(4698), 10L, "Est sed iste nostrum voluptatem soluta. Placeat iusto illo fuga. Qui fuga quisquam veniam dolorem ea.", "Quae quis voluptatem et iusto et eos natus.", "", 1, "Velit non quae.\nVel doloribus incidunt." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 27L, "Beatae architecto qui et delectus perspiciatis.", new DateTime(2022, 10, 6, 10, 20, 27, 850, DateTimeKind.Utc).AddTicks(4498), 21L, "Explicabo qui eum a accusantium.", "Voluptatibus et dolores.", 4, "", 1, "Voluptas qui debitis accusamus illum quaerat a qui accusantium quasi." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 4L, "Voluptas culpa quae dolore facilis aut.", new DateTime(2023, 3, 31, 22, 14, 53, 129, DateTimeKind.Utc).AddTicks(3952), 24L, "sint", "Unde voluptas ullam ex voluptatibus aut voluptatum quia vitae.", 3, "", 3, "Et quo aut ea quaerat dolore et aut voluptatem dolorem. Ex voluptatem alias sit aut occaecati et reiciendis deserunt. Saepe laboriosam rerum est voluptatibus dolore repudiandae. Ullam ea quo rerum aliquid iure fugiat possimus itaque. Minus itaque mollitia." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 39L, "Autem veritatis tempore minima repellat tenetur aspernatur.", new DateTime(2023, 2, 6, 9, 0, 29, 968, DateTimeKind.Utc).AddTicks(1488), 8L, "Non et perspiciatis quaerat unde reprehenderit qui et hic est.\nSed sit facere.", "Consequuntur et temporibus ipsa.", 2, "", 1, "Rem libero et.\nNisi culpa consequatur et et tenetur.\nNihil laboriosam quidem nesciunt libero velit quidem quia.\nMolestiae voluptas rerum nulla praesentium.\nUt illum id maiores dolores et sequi quas." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 6L, "Quo veritatis consequatur impedit maiores.", new DateTime(2023, 8, 18, 22, 7, 24, 404, DateTimeKind.Utc).AddTicks(4774), 16L, "Aut dolorum voluptas fuga sint ut et quia tempora est.\nSoluta beatae nostrum aspernatur iusto nihil quam.\nExcepturi aut in occaecati illum est in.\nSuscipit minus et omnis eum vitae quaerat officia repellendus.\nVoluptate ut vel cupiditate est velit.\nRerum totam voluptatem reiciendis earum quis.", "Assumenda ipsa est enim doloribus quas libero blanditiis.", 3, "", 0, "Autem qui dolores. Molestias ut ut. Voluptate incidunt aperiam rerum qui voluptas hic molestiae. Ipsum voluptatem incidunt enim. Quisquam asperiores quos." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 21L, "Animi qui cumque ipsam ut perferendis ducimus dolorem.\nLaboriosam autem illo quia eius dolore eum reprehenderit ducimus non.", new DateTime(2023, 2, 28, 17, 9, 17, 439, DateTimeKind.Utc).AddTicks(5579), 35L, "voluptas", "Aut hic itaque sint ut laudantium dignissimos.", 2, "", "Cumque qui illo soluta sint rem qui quo." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 30L, "Nesciunt ab omnis porro enim quo architecto.", new DateTime(2021, 2, 18, 10, 21, 10, 408, DateTimeKind.Utc).AddTicks(6804), 12L, "nemo", "Et ipsam iste et ut.", 4, "", 3, "Aut eveniet nihil est harum qui perspiciatis asperiores. Molestiae aut et possimus ut. Repudiandae unde voluptas magni autem. Quisquam enim officiis eveniet et quod facere sit quia. Sit cum animi non ut et harum asperiores eos aut. Rerum totam sint aliquam exercitationem ut consequatur ex." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 8L, "Nemo vel consequatur sint.\nUt consequatur eius beatae voluptas ea rerum suscipit sed.\nDolorem sapiente soluta laudantium aliquam omnis.", new DateTime(2019, 10, 8, 0, 17, 18, 649, DateTimeKind.Utc).AddTicks(5718), 21L, "maxime", "Facere alias quo autem vel quia itaque.", 1, "", 2, "Debitis doloribus voluptatem numquam qui.\nNon fugiat accusantium eos incidunt maiores.\nEt sed animi illo fuga." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 10L, "sequi", new DateTime(2022, 8, 14, 21, 40, 35, 152, DateTimeKind.Utc).AddTicks(5854), 26L, "eos", "Dolore quaerat eius aut qui libero repellat et ipsa dolor.", 1, "", 1, "Ipsam cupiditate et velit ut qui voluptatum porro." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "TestCases" },
                values: new object[] { 54L, "Sed possimus deleniti eveniet modi similique molestiae libero.\nTotam perspiciatis perferendis excepturi non sed.\nEst aliquam labore ea corrupti.\nBlanditiis deleniti ut error qui.\nEt similique qui.\nVoluptate omnis excepturi eum eum corporis.", new DateTime(2023, 2, 11, 21, 4, 50, 526, DateTimeKind.Utc).AddTicks(9168), 15L, "Vitae eum facere aliquam quod dolorem minus. Voluptas a sit deserunt est. Nostrum consequatur ratione earum voluptatum eius. Nihil laborum doloribus esse sit corrupti quia quidem illo illo. Neque et est officia porro dicta rerum voluptas quaerat.", "Quia quidem aut fugiat consectetur ut et ab maxime.", "", "Dolores ad vero explicabo. Quia nam voluptatem voluptatem minima corrupti quia et non. Corporis alias omnis distinctio sed eum omnis molestiae perferendis eos. Minus perferendis minus ut totam laboriosam eum. Asperiores asperiores animi iure. Et temporibus eveniet rerum quis sapiente vitae." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 28L, "corporis", new DateTime(2023, 1, 10, 21, 19, 50, 731, DateTimeKind.Utc).AddTicks(7139), 18L, "Molestiae numquam assumenda nihil explicabo. Ullam ratione a. Rerum amet et assumenda consectetur. Est neque labore. Cupiditate vel temporibus enim qui a dolore ut doloribus est. Ut non perferendis eius molestiae nihil est eum facere voluptas.", "Voluptatum aliquid voluptatum vel.", "", 1, "Autem assumenda omnis quo voluptate laboriosam laborum quo." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 45L, "Quo et nihil dolores aut dolores vel veritatis nesciunt nemo.\nAut expedita animi unde ut.\nConsequuntur omnis atque architecto consequatur.\nOdio voluptas labore vel dolor sit.", new DateTime(2023, 4, 26, 4, 13, 38, 828, DateTimeKind.Utc).AddTicks(8123), 17L, "Expedita quasi harum explicabo animi.", "Quasi numquam voluptas voluptas.", 2, "", 2, "Nihil perspiciatis dolor id et non.\nDolore itaque dolor repellat dicta maiores blanditiis molestiae ut.\nHic accusantium porro omnis veritatis repudiandae rem.\nMaiores expedita rerum quia.\nIpsa et et maiores omnis fugit nihil rerum.\nExplicabo ea non unde exercitationem consequatur suscipit blanditiis eum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { "In sit non. Dolore sint dolorum aut eos. Enim voluptas quae voluptatibus ut et voluptate. Adipisci atque quo ut magnam ut. Animi magnam iste officiis. Praesentium deleniti et sequi beatae necessitatibus cumque id.", new DateTime(2023, 4, 23, 11, 16, 51, 510, DateTimeKind.Utc).AddTicks(4110), 27L, "Impedit sit ea aperiam non reprehenderit quia.\nUt veritatis tempora fugit quasi temporibus eum saepe.", "Quia molestiae ullam id dolores qui repellat.", 4, "", 0, "Aut est ut maiores veniam autem debitis ipsam voluptas." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 70L, "Recusandae autem et sunt nulla assumenda ipsum placeat.", new DateTime(2023, 3, 4, 3, 32, 24, 38, DateTimeKind.Utc).AddTicks(5180), 28L, "Impedit culpa hic vel molestiae sint dolores.", "Rem aut repellat voluptatem quaerat.", "", 1, "sapiente" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 39L, "Ut maiores ut modi sit.\nQui eos quia at illo voluptatem est cupiditate.\nSunt ut voluptas voluptatum id occaecati aut omnis.\nVoluptatem velit enim.\nConsequatur exercitationem dolor itaque temporibus dolore.\nQui rerum eligendi voluptatum corporis nulla omnis natus.", new DateTime(2022, 2, 11, 18, 11, 50, 109, DateTimeKind.Utc).AddTicks(844), 25L, "necessitatibus", "Culpa ea vero corporis eaque nam dolores.", 4, "", 0, "Officia suscipit in laudantium voluptatem.\nSed amet vel sequi non.\nSapiente est ut eligendi at dolorem.\nSed provident cupiditate nulla sit nobis expedita quis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 28L, "voluptate", new DateTime(2023, 8, 11, 14, 10, 49, 430, DateTimeKind.Utc).AddTicks(1908), 3L, "qui", "Reiciendis officiis ut reiciendis aut id animi et cupiditate.", "", 3, "Sequi cumque id itaque suscipit qui veritatis quos dolore dolor.\nVitae accusantium exercitationem pariatur est quae et a.\nQuis qui enim pariatur accusamus eum non explicabo voluptatem.\nAd molestiae quam eius.\nVoluptatem vel tempora ad enim possimus corrupti fuga.\nIpsam est impedit nemo qui sint eos perspiciatis assumenda." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 7L, "Nobis doloremque rerum adipisci omnis provident ratione. Fuga molestias ea aut minus sequi laboriosam harum. Officiis molestiae neque quia voluptatum repellendus. Cupiditate aliquam qui inventore eveniet. Repellat consequuntur voluptatem hic vitae illo cumque eos. Ex sint minima ipsum praesentium assumenda sunt est in.", new DateTime(2021, 11, 19, 16, 12, 53, 447, DateTimeKind.Utc).AddTicks(4794), 36L, "Et similique tempore exercitationem.", "Ut ipsum aut quas minus nam consequatur natus qui.", 4, "", "Nesciunt quo et expedita." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 64L, "Sunt et ipsa.", new DateTime(2020, 11, 11, 1, 42, 15, 143, DateTimeKind.Utc).AddTicks(2331), 1L, "Quaerat distinctio nobis officiis vel.\nTotam perspiciatis voluptate fugiat.\nNostrum hic quos in doloribus quas ipsa.\nEveniet cum exercitationem esse.", "Eligendi dolor quasi veniam recusandae.", 1, "", 3, "Perspiciatis et atque consequatur minus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 66L, "Quibusdam corrupti neque voluptate ut perferendis autem illo aperiam.", new DateTime(2023, 1, 19, 15, 49, 0, 926, DateTimeKind.Utc).AddTicks(9031), 1L, "Modi minus laudantium. Qui asperiores qui voluptatum consequatur necessitatibus. Similique dignissimos aut amet magni. Est eveniet perspiciatis. Quia ipsam odio distinctio in laborum laborum ab autem rerum. In eligendi sunt possimus.", "Earum ex illo exercitationem modi sit aperiam aspernatur velit.", 3, "", 0, "Eligendi deleniti nobis laborum delectus et blanditiis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 7L, "Quasi ex eos sit esse accusantium vel debitis eum. Nihil sunt magnam. Asperiores placeat provident.", new DateTime(2020, 6, 25, 7, 35, 52, 275, DateTimeKind.Utc).AddTicks(4506), 6L, "Ut accusantium amet numquam iste accusamus dolorem.\nOmnis iste laboriosam tempore.\nNon quidem non.", "Libero id adipisci quia eaque qui nihil.", 1, "", 1, "Architecto animi debitis eveniet reprehenderit ut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 37L, "blanditiis", new DateTime(2022, 4, 24, 6, 40, 50, 427, DateTimeKind.Utc).AddTicks(1989), 31L, "Rerum architecto aut modi ex sunt architecto. Est velit dolor hic vitae quas accusantium ut nam eos. Vel minus in. Soluta non consequatur reprehenderit eveniet praesentium et.", "Ab asperiores ea nesciunt ipsum.", 1, "", "Dolor ad laboriosam ex non quia sit vel.\nEst velit reiciendis sunt possimus a iure et quis labore.\nEa sed velit magnam reiciendis adipisci.\nIn cumque aut assumenda aut vitae harum necessitatibus voluptas." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 29L, "Velit sint accusantium nobis.", new DateTime(2021, 2, 9, 16, 55, 40, 854, DateTimeKind.Utc).AddTicks(7837), 19L, "Unde blanditiis exercitationem nostrum aliquid optio dolor dignissimos dolor. Ut maiores enim. Et sapiente assumenda aut. Voluptatum odio ut quam omnis ut voluptatem sunt voluptas ipsum. Dolores est inventore repudiandae placeat sint sunt id. Laudantium est pariatur vel fugit est eaque autem.", "Eum eveniet inventore neque ut.", 1, "", 1, "Quis tempora voluptatibus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 70L, "Rerum ut molestiae qui.", new DateTime(2022, 11, 24, 15, 18, 22, 137, DateTimeKind.Utc).AddTicks(9360), 34L, "et", "Nihil quam enim aperiam provident reprehenderit doloremque est suscipit.", 4, "", 1, "Officiis dolorem aut praesentium facere deserunt at corporis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 1L, "Odit aut reiciendis et.\nDucimus nostrum architecto voluptate tempore eum blanditiis minus.\nNon vitae est eveniet nihil sapiente.", new DateTime(2022, 12, 28, 6, 57, 54, 409, DateTimeKind.Utc).AddTicks(7564), 6L, "Omnis fugit labore magni accusantium quasi. Tempora sit et. Nihil amet ut. Ex debitis vero laboriosam hic in recusandae ut omnis. Ut unde labore est expedita nulla qui omnis porro voluptates.", "Eos quidem quos odio aut iste non tempore vero iure.", 2, "", 1, "Et voluptatem at voluptatem tenetur. Animi consequatur perferendis et dolores consequatur. Ut quis assumenda in necessitatibus rerum blanditiis sapiente distinctio. Voluptatem dolores nobis officia dolore corrupti sequi minima sit molestiae. Quasi est vel magni laboriosam est aut nemo illum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 31L, "Architecto consequatur qui molestiae a et facilis voluptas voluptas numquam.\nQuia possimus occaecati eos in cum.", new DateTime(2023, 8, 11, 4, 53, 36, 174, DateTimeKind.Utc).AddTicks(6261), 10L, "Velit nulla quia.", "Sed corrupti dolorem.", "", 0, "Voluptatem totam ex commodi nisi occaecati minus magni et autem." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 56L, "et", new DateTime(2020, 2, 26, 13, 26, 27, 288, DateTimeKind.Utc).AddTicks(7152), 32L, "Explicabo ipsam distinctio enim consequuntur velit libero consequuntur aliquam vero. Facilis quibusdam magnam consequatur repudiandae voluptate porro rerum molestiae nisi. In et molestiae qui quisquam. Corrupti placeat dignissimos qui veniam dignissimos veniam magni pariatur. Sed dolor dolorum reiciendis iste voluptatum nihil quibusdam voluptas dolores. Id quia dolorem sapiente sit.", "Et debitis et voluptatem provident amet quis est.", 3, "", 2, "Sapiente voluptatum porro dignissimos odit voluptates tempora quis. Totam in eos minima voluptas et ipsa molestiae autem. Excepturi quaerat et deserunt quis aut. Suscipit ea dignissimos rerum maxime et est provident rerum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 16L, "quam", new DateTime(2022, 10, 11, 13, 29, 20, 637, DateTimeKind.Utc).AddTicks(8024), 19L, "facilis", "Est eveniet quidem molestias velit aliquid ea ex ut ut.", "", 2, "Consequatur quod aspernatur odio consequuntur corporis tempora molestias facere.\nAd fuga hic et corrupti reprehenderit illo facilis.\nQuos est laboriosam ab.\nQuasi iusto corrupti.\nDoloremque tempore cumque similique quaerat cupiditate ad." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 57L, "vitae", new DateTime(2022, 7, 11, 21, 37, 25, 726, DateTimeKind.Utc).AddTicks(5651), 20L, "quis", "Aut eos qui velit iste deleniti nulla aut omnis laudantium.", 3, "", "eligendi" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 1L, "Ipsum molestiae nisi accusantium recusandae quae.", new DateTime(2023, 4, 24, 10, 47, 39, 888, DateTimeKind.Utc).AddTicks(8211), 30L, "Dignissimos dolore commodi. Maiores cupiditate et voluptas et aut a. Commodi voluptatibus doloremque ab aspernatur enim.", "Impedit consequatur molestiae cupiditate et placeat optio molestiae blanditiis accusantium.", 2, "", 0, "distinctio" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "TestCases" },
                values: new object[] { 53L, "Maiores ad et eos quo. Officia voluptatem et est numquam et reiciendis quae ut asperiores. Ut in explicabo. Optio tempore voluptas et a eos maiores aut laborum. A qui ipsa repellat possimus voluptatibus.", new DateTime(2023, 5, 16, 5, 20, 53, 917, DateTimeKind.Utc).AddTicks(6261), 27L, "aut", "Odit accusantium nam aut et exercitationem quam.", "", "Nihil molestiae enim molestiae nemo est. Dolorum voluptatibus expedita. Architecto nihil excepturi totam. Animi modi rerum facere eaque. Voluptatem illum ut aliquam cum itaque quae." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 34L, "Nemo sed enim sunt quo sequi.", new DateTime(2023, 3, 21, 17, 54, 22, 163, DateTimeKind.Utc).AddTicks(7004), 14L, "Saepe sunt deleniti a.\nTempore dolorem aut voluptas reiciendis et rem aperiam vel.\nQuasi similique alias laborum eius.\nBeatae cumque sit.\nMaxime labore pariatur qui voluptatem et sunt.\nEum consequatur voluptas quia temporibus ipsa quia et necessitatibus dicta.", "Placeat provident necessitatibus voluptates et alias.", 4, "", 3, "Voluptate illum omnis quos distinctio ab recusandae aut sunt. Est beatae sit exercitationem voluptas ut ut at est. Nulla autem animi optio esse a quisquam commodi. Sit maiores magnam vel eveniet." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 61L, "reprehenderit", new DateTime(2023, 6, 30, 0, 25, 26, 764, DateTimeKind.Utc).AddTicks(9174), 39L, "Veritatis unde libero atque est aut.", "Sit et eveniet odit harum beatae vel iure.", 3, "", 3, "et" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 1L, "provident", new DateTime(2023, 4, 17, 2, 52, 57, 910, DateTimeKind.Utc).AddTicks(4897), 36L, "Deleniti voluptatem et. Voluptate nobis quo ratione quia totam itaque dolorum pariatur. Qui libero ullam quo facilis impedit voluptatem sed quae perferendis. Dolores laboriosam laborum neque. Autem aut quibusdam libero nihil ut quis ipsa ut.", "Amet doloribus quisquam pariatur cum velit quisquam dolorem non.", 3, "", 0, "Nemo adipisci autem inventore in." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 31L, "Delectus minima reiciendis quam id ad nisi aut voluptatibus cupiditate.", new DateTime(2023, 4, 23, 12, 2, 54, 71, DateTimeKind.Utc).AddTicks(5938), 35L, "At eum quaerat ducimus. Nihil dolores ipsam quos quam ea et et et praesentium. Est et consequatur.", "Nulla quas quam quis nihil possimus nobis.", 3, "", "delectus" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 67L, "Labore molestiae minima fugiat sapiente atque.", new DateTime(2023, 5, 22, 13, 5, 23, 487, DateTimeKind.Utc).AddTicks(157), 20L, "Accusamus amet ut sapiente quae excepturi rerum. Exercitationem aut nulla. Est consequatur tempore repellendus eveniet deleniti. Aut qui non repudiandae nisi id dolores reprehenderit.", "Eum et aperiam commodi praesentium harum voluptatem quia ut sint.", 4, "", 0, "Nihil eos cupiditate voluptatum in suscipit perferendis deleniti. Et excepturi dolorem blanditiis provident et aspernatur hic aperiam. Suscipit corporis est est dolores perspiciatis qui sed provident." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "TestCases" },
                values: new object[] { 70L, "Aut dolores quia. Quia beatae quia accusamus nam corporis. Magni blanditiis illo. Ad consequatur tempora voluptates quia tenetur aut nesciunt. Ut consectetur nostrum dolorem eaque cum voluptas.", new DateTime(2023, 8, 31, 19, 38, 19, 900, DateTimeKind.Utc).AddTicks(6167), 13L, "Laudantium aut et suscipit autem tempora perferendis repellendus sequi.", "Ea rerum quidem odit similique.", "", "Deleniti porro officia aut non inventore et veritatis quis eum.\nVoluptatum eum corporis voluptatibus commodi aut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 35L, "Aspernatur possimus ea maiores amet. Sunt doloribus aut est fugiat et vel autem. Excepturi enim voluptates tempora ullam vero aut dolores. Qui eaque soluta voluptatibus rerum. Voluptate eius ipsa consequatur optio totam et quibusdam ut neque. Maiores odio exercitationem soluta sapiente error.", new DateTime(2023, 5, 15, 11, 9, 34, 151, DateTimeKind.Utc).AddTicks(9839), 3L, "Sed rerum assumenda voluptatum temporibus sint blanditiis voluptate. Omnis occaecati sed impedit quia. Perspiciatis qui ipsum qui rerum unde aut. Iure consectetur autem. Quia aut quia id quidem. Quia inventore ea corrupti tempore sed architecto.", "In earum nobis quia optio at inventore.", 4, "", 0, "Qui ratione nam occaecati. Doloribus quaerat ipsa aliquam ratione asperiores. Ut saepe veniam laborum sunt quis aspernatur. Eos rem earum veritatis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 3L, "sunt", new DateTime(2023, 9, 1, 5, 36, 19, 886, DateTimeKind.Utc).AddTicks(1484), 39L, "Iure voluptatem non illo voluptatem ut maxime placeat veritatis doloribus. Sit aliquid ea. Architecto sit dicta impedit similique. Sed et eum aut eum. Quo possimus consectetur ut. Ipsum ut alias.", "Iure voluptatibus dolore non sed saepe et incidunt sed.", "", 3, "Repellat labore magni exercitationem illo." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 25L, "Inventore fugit delectus labore ipsam error sit veniam eum tenetur. Voluptas voluptates asperiores officiis voluptatem saepe neque qui ea. Eaque nemo sed repellendus dolore necessitatibus. Nam quaerat illo qui. Necessitatibus cumque beatae alias accusamus at suscipit.", new DateTime(2023, 5, 10, 2, 11, 59, 365, DateTimeKind.Utc).AddTicks(3214), 25L, "Neque ut nihil velit soluta enim nesciunt. Repellendus distinctio dolor non provident voluptatem. Consequatur qui adipisci iure nesciunt et culpa consequatur animi error. Quam molestiae eum ut enim et magni ut.", "Deleniti illo velit similique ab.", 3, "", 2, "Et sed nesciunt velit corrupti sit dolor cum. Atque amet deleniti sit aut nulla blanditiis quasi cum aperiam. Quia eveniet ipsam sequi sit nostrum autem. Voluptatem nemo fugit. Repudiandae vel iure sint fuga fugiat ea." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 3L, "Et iusto quia.", new DateTime(2023, 8, 22, 0, 54, 27, 788, DateTimeKind.Utc).AddTicks(4531), 11L, "Non quibusdam et corrupti aut laborum sequi maxime et voluptas. Libero et voluptatem aut et sunt amet. Beatae dolores laboriosam est et quo accusantium aut cupiditate.", "Eos id cupiditate blanditiis aut maiores pariatur.", 3, "", 1, "Culpa animi dolorem nulla quae at incidunt qui unde iure.\nEt asperiores quis sed ad temporibus officia et.\nAb inventore voluptates autem culpa." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 50L, "Autem quis accusantium voluptatem.", new DateTime(2023, 9, 3, 12, 44, 31, 363, DateTimeKind.Utc).AddTicks(2321), 38L, "vitae", "Quis placeat voluptatem incidunt repellat.", 4, "", 1, "tempore" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 14L, "Et enim accusamus quis est tempora maxime eos consectetur rem.\nNihil ut fuga mollitia sint ex at dignissimos nulla quia.", new DateTime(2023, 1, 24, 21, 24, 8, 330, DateTimeKind.Utc).AddTicks(6155), 31L, "Aut amet quia omnis harum asperiores. Nisi ratione fuga. Ea ut dolorem dignissimos delectus voluptatum aspernatur rerum sit. Rem qui placeat deleniti distinctio vero temporibus aliquam animi quasi.", "Accusamus voluptatem ducimus est omnis minus.", "", 3, "Rerum et animi officiis blanditiis eius est quas id. Cupiditate impedit sit eum vel vero. Nulla quia laudantium. Est ut non." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 13L, "dignissimos", new DateTime(2018, 7, 17, 6, 27, 19, 832, DateTimeKind.Utc).AddTicks(8773), 3L, "Molestiae delectus architecto dignissimos velit animi.\nQuasi aut eos quaerat dicta perspiciatis.\nAt sed dolorem inventore consequuntur odio provident.\nIpsum ut recusandae ut.\nCupiditate eaque nihil eius velit.", "Rerum necessitatibus porro veniam ipsa ut incidunt.", 3, "", 2, "quidem" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 37L, "Est cum quis labore quasi in laudantium veniam saepe eius.\nIpsum excepturi quia dolore itaque aperiam omnis sint veritatis.", new DateTime(2023, 4, 30, 3, 34, 11, 784, DateTimeKind.Utc).AddTicks(8807), 10L, "Sapiente in ipsam voluptas similique nesciunt voluptatem officiis. Repudiandae labore et. Exercitationem non fuga sunt. Ut sed ad voluptas nemo explicabo corrupti unde consequuntur.", "Ex quo quasi officiis repudiandae.", "", 3, "Et beatae consequatur cumque velit consequatur expedita exercitationem officia debitis.\nUnde cum sequi quibusdam aliquid rerum minus magnam minima nihil.\nTenetur nulla sit laudantium dolores." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { "Et quae expedita.", new DateTime(2023, 6, 27, 3, 10, 52, 841, DateTimeKind.Utc).AddTicks(161), 15L, "ad", "Non repudiandae qui incidunt repudiandae officia rerum sunt voluptas cum.", 1, "", 1, "Saepe aliquid est neque eum harum explicabo." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 61L, "Et ut illo maiores quas rem facilis.\nAb rerum non est unde minima corrupti aut quidem similique.", new DateTime(2023, 4, 29, 7, 14, 19, 862, DateTimeKind.Utc).AddTicks(2164), 12L, "Autem illum qui velit est.\nExercitationem consequatur voluptas ut illo ipsa dolores perferendis.", "Quam doloribus minima vel rerum reprehenderit distinctio adipisci.", 3, "", 1, "Similique expedita dolorum excepturi voluptas ad.\nDolorem ut sequi perferendis ab.\nVoluptatibus quia dolorem nostrum excepturi error et qui inventore.\nNon eius minus aut blanditiis eum voluptatem et maiores.\nAspernatur vitae ipsam et voluptatum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 45L, "est", new DateTime(2023, 4, 21, 2, 5, 53, 257, DateTimeKind.Utc).AddTicks(1940), 34L, "Quo harum architecto ut accusantium.", "Sint repellendus non non.", 3, "", 3, "Id illum omnis consequatur eum animi labore et perferendis. Inventore aut sunt ut cum sunt. Amet dicta similique qui voluptatem sit nihil voluptatem ex aut. Velit ipsum repellat ut qui natus odit. Minima cum facere velit ad quibusdam qui. Aut consequatur dolorem et provident a vitae sed est." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 63L, "Iusto tempore exercitationem expedita fuga.", new DateTime(2022, 11, 23, 21, 8, 1, 363, DateTimeKind.Utc).AddTicks(758), 14L, "sed", "Velit non et ratione.", 2, "", 0, "Et non voluptas architecto et sunt praesentium non." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 19L, "Perferendis eaque cumque.\nDolore nisi optio.\nDolorem iste dolorum placeat eaque rerum.\nVoluptas eaque magnam sunt itaque.\nAt et est quasi dicta repudiandae eligendi ut.\nEst culpa ad ex velit voluptatem quas nemo est eos.", new DateTime(2022, 7, 24, 14, 37, 45, 463, DateTimeKind.Utc).AddTicks(437), 22L, "Eos error esse quaerat dolorem quae.", "Facilis non iste ullam illum a exercitationem vel iure.", 1, "", 0, "Dicta nemo consequatur voluptatem accusamus est ut est eos sunt.\nIn nesciunt iure aut sit neque et alias voluptatem officiis.\nIpsa rem soluta placeat voluptas qui qui animi tempora." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 25L, "Ut quia eius ut suscipit culpa sed veniam.", new DateTime(2023, 1, 17, 4, 42, 23, 238, DateTimeKind.Utc).AddTicks(3611), 38L, "Molestiae exercitationem qui iste possimus laboriosam iure.\nAlias eligendi voluptatem aperiam architecto est impedit eligendi nostrum odio.\nEt cum et.", "A ipsa quidem provident nostrum corrupti.", 3, "", 0, "ipsa" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "TestCases" },
                values: new object[] { 24L, "Impedit ut molestiae.\nIncidunt voluptatem vero velit deserunt eos id molestiae unde necessitatibus.", new DateTime(2021, 9, 19, 12, 5, 52, 839, DateTimeKind.Utc).AddTicks(64), 29L, "Et eligendi sapiente debitis voluptatem et.\nPossimus ut non enim qui sint nam iure excepturi non.\nProvident qui fugit earum id.", "Et aut eos aut distinctio eum doloremque maxime vel aut.", "", "Voluptatum voluptate fugiat explicabo laudantium fugit necessitatibus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 22L, "Ut optio totam temporibus et saepe dolore accusantium.", new DateTime(2023, 3, 31, 1, 27, 10, 531, DateTimeKind.Utc).AddTicks(8293), 32L, "est", "Deserunt vitae officiis officia vero sit neque.", 2, "", 0, "Impedit hic et quidem." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 65L, "veritatis", new DateTime(2023, 7, 15, 8, 27, 12, 750, DateTimeKind.Utc).AddTicks(2508), 25L, "Est ducimus at eos deserunt porro beatae tempore.\nTemporibus quos natus est.\nDucimus consequatur neque molestiae cupiditate corrupti necessitatibus.", "Quia et dolor autem ducimus iusto eos veritatis facilis.", 2, "", 0, "Quo sed voluptas sit quo earum ipsam quasi." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 27L, "Repellat qui repellat totam molestiae qui iure quia.\nNisi iste porro voluptatum voluptatem magni voluptatem facilis aut vero.\nVeniam cupiditate libero aliquam expedita iusto cumque voluptas.\nOdit qui repellat inventore vero ducimus tempora dolorem sapiente mollitia.", new DateTime(2023, 2, 5, 9, 51, 16, 920, DateTimeKind.Utc).AddTicks(8011), 21L, "Distinctio nihil vel.\nVoluptatum sint quod consequatur quos odio.", "Autem fugiat modi soluta tempore.", 3, "", "Vitae alias nulla ab eius aut fugit." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { "occaecati", new DateTime(2023, 7, 20, 16, 51, 46, 485, DateTimeKind.Utc).AddTicks(2810), 12L, "quia", "Et vel et maiores soluta esse excepturi ut.", 2, "", 0, "Harum officia eos debitis et neque. Et qui ut enim nihil. Odit ut a impedit." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 62L, "Explicabo ut quis vero at voluptate dolores facere ea ut.\nDolorem voluptas mollitia natus provident enim.\nMinima quos laboriosam et impedit debitis dignissimos.", new DateTime(2022, 10, 18, 14, 44, 17, 487, DateTimeKind.Utc).AddTicks(4344), 10L, "perferendis", "Ex et adipisci.", "", 3, "Repellendus impedit sint aspernatur nam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 56L, "non", new DateTime(2021, 5, 24, 18, 48, 57, 318, DateTimeKind.Utc).AddTicks(6422), 28L, "Accusamus accusantium sunt. Impedit ab ut possimus asperiores qui. Qui neque praesentium et reprehenderit vel et facere fuga laudantium. Quasi dolore repellendus occaecati. Nihil ut voluptatem. Quia voluptate aut aut.", "Non et sapiente tempora qui voluptatem blanditiis.", 2, "", 0, "Corporis impedit et deserunt eum quos esse. Et quo ipsa dignissimos dolorem facere sint. Vel cum placeat veritatis natus qui veniam et ut. Id nihil fugiat qui quaerat aut. Sint ea sed qui fuga illo quis eum corrupti atque. Iure occaecati inventore iure aut et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 68L, "Et modi laborum quidem. Quia rerum consectetur doloremque et voluptate tempore non mollitia quae. Ut neque id enim maxime. Sint recusandae qui ipsam. Quod exercitationem sapiente perferendis aliquid animi alias aliquam.", new DateTime(2023, 6, 29, 9, 57, 45, 743, DateTimeKind.Utc).AddTicks(5564), 35L, "Laudantium totam dolores perspiciatis repellendus quia neque.", "Provident quo possimus error quae tempora inventore voluptate.", 1, "", 0, "adipisci" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 6L, "Et rerum rerum ut eveniet et voluptates illo.", new DateTime(2023, 6, 17, 16, 24, 5, 707, DateTimeKind.Utc).AddTicks(6452), 30L, "Nesciunt officiis fuga eos et dolore harum dolores consequatur.", "Reprehenderit qui blanditiis necessitatibus.", 1, "", 2, "cupiditate" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 1L, "Eveniet dolorem similique animi. Officiis et sunt impedit fuga eos. Fugiat dolorum aliquam est non aliquam quia accusamus. Iste et neque. Consequatur eos explicabo et aut aut.", new DateTime(2023, 2, 12, 5, 33, 48, 926, DateTimeKind.Utc).AddTicks(2310), "Sit dolorem error assumenda iure doloribus iure nihil quidem. Minima alias quam iure voluptate dolorem occaecati corrupti cupiditate. Ut rerum ducimus dignissimos quidem ut quaerat assumenda vitae.", "Assumenda sapiente voluptatem unde consequatur.", 4, "", 3, "Qui ipsam incidunt est sequi quaerat quod eos. Aspernatur animi impedit nihil voluptatem. Et laboriosam aut nihil facilis modi laboriosam et. Consequuntur libero id ut ipsum minus. Nesciunt quasi consectetur saepe itaque quam error aut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 47L, "Explicabo dolor debitis quasi assumenda quas provident deserunt.\nLaborum reprehenderit ea.\nPerspiciatis autem quia magni sequi minus dolorum laboriosam eos vero.\nAtque quasi incidunt voluptas voluptatibus neque.", new DateTime(2022, 3, 1, 3, 33, 5, 258, DateTimeKind.Utc).AddTicks(4220), 23L, "modi", "Vitae nulla ea minima.", 3, "", 2, "omnis" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 8L, "Perferendis sapiente voluptate.\nMolestiae eum qui cumque.\nSed laborum debitis ea laborum.", new DateTime(2018, 9, 25, 2, 36, 53, 653, DateTimeKind.Utc).AddTicks(2412), 12L, "Natus eligendi reiciendis eum at consequuntur praesentium. Voluptas et et. Quaerat recusandae dicta omnis modi illum enim. Sit maiores voluptas deleniti eaque debitis vero asperiores. Maiores est et repellat dolorem libero et aperiam culpa.", "Labore corrupti id qui qui nesciunt qui laborum nihil.", "", 1, "cum" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 42L, "Rerum eos nobis sapiente quis sunt non et ut. Ut laudantium enim laboriosam nulla repellat fuga sunt ut et. Facilis quaerat quia minima saepe minus soluta qui. Cupiditate sint cum non ipsa voluptates.", new DateTime(2023, 5, 23, 13, 48, 12, 777, DateTimeKind.Utc).AddTicks(2803), 39L, "Aliquid temporibus vel ullam recusandae quasi.\nUllam ipsum ratione consectetur voluptate soluta consequatur.\nRepudiandae illum dignissimos nesciunt quas.\nLabore perferendis aut quod nemo.\nUt ipsam aliquam quaerat vero ut.\nCorrupti numquam mollitia et.", "Distinctio culpa aliquid.", 2, "", "Explicabo quas sed ut culpa quo alias reiciendis repudiandae. Distinctio tenetur voluptatem cum. Consequuntur corporis animi deleniti nobis deleniti voluptas dolore." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 24L, "Amet aut omnis sunt natus et. Labore voluptatibus repudiandae necessitatibus suscipit inventore unde. Veritatis ipsam sed qui similique eos ullam minus dolores accusamus. Eum laboriosam itaque placeat incidunt blanditiis suscipit sapiente earum. Iusto accusantium illo tempore aut consequuntur.", new DateTime(2023, 4, 26, 7, 51, 42, 812, DateTimeKind.Utc).AddTicks(9034), 28L, "Et eum porro ab alias nesciunt.", "Recusandae eveniet et fugit velit error voluptatem.", 2, "", 1, "Animi quo autem incidunt ut magnam qui expedita. Dolore necessitatibus autem minima nihil porro et minima corporis ut. Et repellat explicabo est quas fuga nostrum voluptatem. Mollitia perferendis voluptatem qui et enim. Aut odit deserunt." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 40L, "Ut sunt ut esse et.\nIncidunt quia impedit id enim et et vel.", new DateTime(2023, 3, 3, 15, 34, 52, 767, DateTimeKind.Utc).AddTicks(2075), 15L, "aut", "Voluptates velit animi quod voluptas qui quisquam a.", 3, "", 3, "Ut vel ipsa ut consectetur sunt.\nLibero libero voluptatem et.\nOfficiis ut quod laborum accusantium deleniti.\nVoluptas quod rerum fuga velit occaecati." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 159L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 57L, "Alias alias placeat.", new DateTime(2022, 12, 5, 1, 59, 3, 769, DateTimeKind.Utc).AddTicks(6358), 23L, "Voluptas asperiores quia quia non quisquam.", "Magnam maiores eos ratione.", "", 0, "Quibusdam quo adipisci provident perferendis officia eveniet beatae id qui. Amet voluptas eum. Error mollitia aspernatur. Ut aperiam sequi dolorum omnis aut totam sunt." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 37L, "ut", new DateTime(2023, 1, 10, 8, 31, 34, 931, DateTimeKind.Utc).AddTicks(7747), 38L, "Sit laudantium mollitia ut minus sapiente aut.\nDistinctio quibusdam facere quos unde veniam iusto ut.\nAspernatur et quia dolorem dolores laudantium ipsa commodi.\nAperiam fuga quaerat beatae inventore.\nQui consequatur vel repellat.", "Dolores corrupti cupiditate ut tempore corporis.", 3, "", 3, "Est dicta unde tenetur facilis eius." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 1L, "Dignissimos vel occaecati alias iste est iure molestiae eum quis. Id culpa ipsa perspiciatis ut iusto commodi. Nemo impedit perspiciatis quos.", new DateTime(2023, 9, 6, 9, 41, 44, 78, DateTimeKind.Utc).AddTicks(4382), 35L, "Dolore incidunt excepturi quia aut itaque.", "Velit quia nobis voluptates aspernatur aut fugit illo.", 1, "", 2, "nostrum" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 162L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 25L, "Dolorem vel minima ut necessitatibus iusto quo velit. Qui eligendi officiis dolorem. Et in aperiam et eaque odio. Et et optio ut consectetur aliquam. Magnam qui est voluptas fugiat sint ad consequuntur eveniet.", new DateTime(2023, 7, 18, 2, 1, 11, 315, DateTimeKind.Utc).AddTicks(452), 29L, "Dolor facere quaerat voluptatem ea.", "Voluptates in perferendis minima ullam eum iusto odit accusamus iste.", "", 2, "minus" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 163L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 64L, "vero", new DateTime(2020, 4, 7, 16, 42, 33, 978, DateTimeKind.Utc).AddTicks(3563), 11L, "sapiente", "Et ut nemo culpa et qui quidem optio.", 1, "", 1, "Consequatur eaque et sed tempore et. Amet laborum sequi animi corrupti est autem eos inventore et. Perspiciatis facere illo praesentium. Quia optio eius ipsam rem eaque et. Fugiat amet aut tenetur commodi atque." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 164L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 39L, "Odio dignissimos molestias blanditiis amet praesentium ratione consequatur qui voluptas. Voluptas nihil et sunt omnis. Nisi pariatur id non sint. Id a odit cumque in ut.", new DateTime(2023, 1, 29, 16, 0, 29, 944, DateTimeKind.Utc).AddTicks(9770), 17L, "Et autem in sed consequuntur placeat voluptas in corporis voluptas. Unde illum perspiciatis voluptatem. Sit praesentium in autem in et. Repellat dicta qui aut recusandae.", "Sunt quaerat non est rerum ad rerum ea.", "", 1, "Voluptate quae et eaque quidem. Sit ducimus corporis aut aliquid rerum repellendus. Repellendus enim et excepturi eum inventore. Autem optio molestiae hic et dolores vitae possimus placeat qui." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 165L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 9L, "In sunt tenetur voluptas sit esse itaque perspiciatis a.", new DateTime(2020, 8, 22, 15, 12, 45, 191, DateTimeKind.Utc).AddTicks(795), 5L, "Ipsam impedit nobis quae laboriosam omnis possimus cum eius.\nEt exercitationem necessitatibus ad expedita.\nNon laborum quisquam sunt eos ullam.\nReprehenderit qui ut eius sint nam ipsam possimus occaecati est.\nLaboriosam animi atque.\nOmnis voluptatem tempora modi quia.", "Maiores voluptate optio non eum quidem minus similique corrupti.", 3, "", 0, "In ducimus qui.\nReprehenderit quo facere voluptas possimus recusandae delectus iste.\nQui et architecto voluptas rerum eum magni voluptatibus labore est.\nInventore ipsum ex dolores unde et expedita enim.\nVel sed vitae maiores.\nNisi vero id non alias totam quia qui at animi." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 64L, "id", new DateTime(2022, 7, 14, 21, 35, 55, 616, DateTimeKind.Utc).AddTicks(1597), 19L, "Illo et adipisci fugiat in eos rerum quia rem enim.\nQuia doloremque quae expedita.\nVoluptas fuga repudiandae ipsum quia et consectetur id cum dolor.\nQuia eius eveniet voluptatem et nemo aliquam esse aut magni.\nDolores voluptates ad nulla.\nVoluptatem autem voluptatibus excepturi adipisci.", "Consequatur quia doloribus saepe est sint.", "", 3, "Aut ut et perferendis et animi aspernatur." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 7L, "Deserunt illum est et. Eos est consequuntur consequatur saepe voluptatum id. Commodi eligendi ut temporibus. Corporis veritatis unde recusandae tempore facilis incidunt iure tempore. Debitis eaque voluptas rerum est est dolor neque id similique.", new DateTime(2022, 1, 2, 19, 48, 7, 804, DateTimeKind.Utc).AddTicks(3578), 28L, "Illo deserunt sint qui qui provident provident modi ab magnam.\nSed dolore recusandae molestias est nulla culpa sed cupiditate.\nQuaerat incidunt quia quasi quia sit est dolorem harum eos.", "Laborum amet quo blanditiis nesciunt dolorum officiis et.", "", 2, "Ut est quod dolores. Perspiciatis sunt laudantium aliquid dicta culpa expedita. Cumque expedita ratione magni in dolorem consectetur." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 53L, "Numquam fuga facere quia est architecto.", new DateTime(2022, 2, 5, 23, 6, 55, 463, DateTimeKind.Utc).AddTicks(1081), 38L, "Id nihil sunt. Eum quas sunt quo aut maiores esse enim. Ut consequatur nihil saepe dolor. Qui quae quam eveniet aut sed aut qui reprehenderit aut. Distinctio assumenda et ut rem voluptatem molestiae et sed labore.", "Ratione molestias recusandae qui eos provident ea tempore.", 4, "", 2, "Commodi quod voluptas laudantium excepturi et illo esse reprehenderit.\nOdit non dolore delectus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 55L, "Inventore officiis accusantium sit aut veniam est illum ab. Eum quo quia est. Quo et ut dolor eum facilis nobis quasi. Quo a dolorem perferendis accusamus.", new DateTime(2023, 3, 22, 21, 9, 29, 578, DateTimeKind.Utc).AddTicks(3024), 15L, "Magni eos autem non et et vel voluptas nisi. Deserunt odio neque voluptatem. Explicabo id suscipit.", "Qui soluta id.", 4, "", 3, "Et debitis impedit. Excepturi nostrum numquam rerum blanditiis porro amet similique sint. Laborum asperiores quam molestiae laborum reprehenderit ipsa cupiditate eos. Aut qui rem nulla sed. Hic ad provident est modi ducimus itaque." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 37L, "Ratione quia officiis nemo aliquid et et rerum alias molestias. Ut possimus consequuntur. Id maiores quam a omnis et sint neque. Praesentium incidunt adipisci dolor sed aut non.", new DateTime(2022, 9, 19, 12, 52, 30, 104, DateTimeKind.Utc).AddTicks(1662), 18L, "Molestiae consectetur accusamus in at quaerat quibusdam assumenda.", "Assumenda repudiandae eaque ratione est dolorem illo quos incidunt.", "", 1, "Aut rerum provident." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "TestCases" },
                values: new object[] { 61L, "Ut ullam temporibus ut facilis sit dolor ratione ut.", new DateTime(2023, 6, 10, 16, 5, 29, 612, DateTimeKind.Utc).AddTicks(6729), 21L, "Nobis aut ut nostrum impedit rerum omnis.\nAut suscipit ducimus commodi.\nCulpa nisi ut in nisi ut.\nHarum doloremque repellat hic officia et inventore tempore.\nSint rem qui sit animi dolores aspernatur quaerat.\nVoluptatem adipisci est ut ipsum nihil voluptatem quibusdam eos voluptatem.", "Officiis dolores quis harum quae nostrum nulla quia et.", "", "Eaque distinctio et temporibus est nulla cum est libero animi. Qui quas dolorem ipsam corrupti ipsum. Nemo possimus unde placeat tenetur a aut quas quod. Minima corporis sequi illum odit. Dolore ut qui et nesciunt ad possimus. Nesciunt corporis eveniet suscipit omnis qui et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 3L, "rerum", new DateTime(2023, 7, 8, 8, 45, 18, 249, DateTimeKind.Utc).AddTicks(2653), 18L, "et", "Molestiae et perferendis in nihil.", 4, "", "dignissimos" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 30L, "Soluta aut cum hic labore accusantium cum atque. Vero magnam quia. Dolorum non maiores iste nostrum. Sit officiis maxime eius dolorum odio adipisci commodi voluptatem. Iusto animi repudiandae voluptatem ratione nihil error excepturi sint. Consequatur dolorem sapiente neque repellendus quis officiis.", new DateTime(2020, 7, 12, 5, 14, 29, 883, DateTimeKind.Utc).AddTicks(9939), 36L, "magni", "Dolorum vitae voluptatem rerum distinctio eos in quibusdam.", 4, "", 0, "Officiis sit molestias accusantium. Accusamus itaque distinctio illo molestias ipsa distinctio velit eligendi. Quaerat suscipit earum neque velit delectus voluptatum quidem. Possimus pariatur repudiandae culpa iusto magnam error ex." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 29L, "Ut sint cupiditate aperiam non cum consequuntur dolorem in.", new DateTime(2020, 10, 6, 7, 12, 22, 639, DateTimeKind.Utc).AddTicks(4704), 26L, "Incidunt neque ducimus qui rerum quo veritatis sit tempora.", "Atque ut blanditiis velit in.", "", 0, "Ut et a ex modi aut earum est fuga." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 7L, "Soluta et totam necessitatibus.", new DateTime(2022, 3, 8, 1, 56, 0, 95, DateTimeKind.Utc).AddTicks(2140), 31L, "Omnis sed eligendi fuga sequi.\nUnde et nesciunt aut et at eos aut sint.\nId consequatur quo consequatur et neque debitis aut voluptatem.", "Numquam quidem cum repudiandae sapiente sint aperiam quaerat fuga similique.", 1, "", 1, "Quis commodi officia voluptatum autem esse.\nVel sequi maxime.\nEum enim nostrum ipsam officia nemo perferendis quo quia.\nAdipisci et dolorem rerum similique." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 8L, "Nesciunt excepturi voluptas sapiente.\nMagni numquam totam quia.", new DateTime(2021, 9, 27, 23, 42, 28, 984, DateTimeKind.Utc).AddTicks(64), 3L, "Rem molestiae est sunt eos error expedita nam.\nQuia quos aut id.\nPariatur voluptas animi aut perferendis maxime autem.", "Fugiat est perferendis reprehenderit.", 3, "", 3, "Inventore voluptatem natus maxime perferendis corporis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 70L, "Incidunt dolorem cum aspernatur qui rem unde laboriosam.", new DateTime(2023, 7, 23, 5, 58, 28, 918, DateTimeKind.Utc).AddTicks(1753), 1L, "Ut et qui consequuntur et voluptas. Sunt repudiandae quos velit nesciunt nemo rerum ducimus quo. Consequatur eveniet ullam doloremque et quia ut quos magni provident. Quia officia enim inventore ut temporibus ad quam occaecati.", "Libero dicta impedit quo autem numquam.", 4, "", 3, "Qui et impedit esse esse velit. Culpa necessitatibus temporibus qui voluptates voluptatem sequi. Doloribus in esse. Optio omnis quia et dolorum quas. Alias molestiae enim dolore nisi odit tenetur et aliquam dolorem. Tempore exercitationem excepturi quia harum deserunt earum velit repudiandae et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 13L, "neque", new DateTime(2021, 4, 1, 2, 52, 13, 558, DateTimeKind.Utc).AddTicks(1923), 33L, "Aut voluptas eius eos amet occaecati consequatur accusantium consectetur consequuntur.\nAut quis neque voluptatem voluptatem.\nDignissimos aut culpa ea molestias harum voluptatibus.\nConsequatur laboriosam numquam.\nQuo adipisci voluptatum consequuntur ab maiores et.", "Aut ipsam ab quia hic dolores optio a quis.", "", 3, "Et nobis quidem." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 14L, "Adipisci porro eius. Autem eligendi labore consequuntur vel sit sequi. Ex recusandae saepe nulla labore dolor. Id velit culpa alias asperiores necessitatibus alias aut.", new DateTime(2023, 5, 2, 2, 19, 10, 697, DateTimeKind.Utc).AddTicks(3508), 28L, "Qui quod alias possimus voluptates. Laborum id ut ab deleniti dolorum. Veritatis sequi saepe accusantium tempora quidem.", "Molestias eum et quasi officiis nostrum.", 1, "", 2, "earum" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 61L, "Recusandae eos recusandae temporibus error voluptatibus reprehenderit. Aut eum natus dolorem pariatur. Eaque quo ullam itaque odit in ab iure eaque nobis. Labore pariatur ipsum accusamus aperiam corrupti culpa quibusdam.", new DateTime(2023, 8, 22, 15, 42, 4, 687, DateTimeKind.Utc).AddTicks(3296), 16L, "vero", "Tempora impedit quis necessitatibus quia sit ducimus dolores.", "", 0, "Nostrum pariatur unde non aliquid voluptas molestias sit nam aut.\nReiciendis eos totam voluptatem velit maxime et.\nPerspiciatis aspernatur magnam quae voluptas dolores eius.\nQuasi saepe voluptatibus doloremque enim tenetur.\nQuam ducimus iure eveniet.\nQuisquam aut nihil." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 31L, "et", new DateTime(2023, 2, 28, 16, 56, 13, 621, DateTimeKind.Utc).AddTicks(6439), 35L, "quo", "Fugiat non aut velit temporibus.", "", 2, "beatae" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 7L, "Voluptas nam reprehenderit ut consectetur laborum voluptatem amet sunt. Id ratione aspernatur suscipit. Ea eum est ipsum qui repudiandae rerum. Ut sit alias quas nulla quae. Amet atque maiores aut dolores. Qui aut est est vel rerum placeat aliquam.", new DateTime(2020, 2, 7, 13, 19, 58, 287, DateTimeKind.Utc).AddTicks(298), 4L, "Nobis dolores nulla tenetur sed quia.\nEnim et quam dolores qui aut aut.\nQuo vel assumenda tempore eligendi.", "Doloribus quae cumque.", 3, "", 0, "Officiis corrupti et nam ab quidem doloremque et a. Quia ut amet aut. Eos id repellat quia neque doloribus. Autem sapiente in eaque. Consequatur delectus dolores amet et autem dolore." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 33L, "Repellendus doloremque enim est.", new DateTime(2023, 8, 27, 14, 3, 20, 176, DateTimeKind.Utc).AddTicks(6156), 16L, "Aut esse omnis optio odit aut.", "Qui eaque eligendi odit earum atque veritatis quisquam illo et.", "", 2, "Est neque consequuntur.\nPorro esse deleniti a nam facere mollitia quia assumenda non.\nEx atque culpa quibusdam deleniti.\nSuscipit vitae a.\nIusto quia voluptatibus facilis nihil aut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 35L, "debitis", new DateTime(2023, 8, 11, 6, 4, 30, 767, DateTimeKind.Utc).AddTicks(5016), 10L, "Ipsum perspiciatis veniam.", "Quod molestias ad occaecati cum temporibus.", 1, "", 1, "ab" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 55L, "Aut perferendis corrupti itaque fugit et est.\nEveniet praesentium delectus harum et ut magnam sapiente eos optio.\nError eligendi ducimus delectus numquam sequi adipisci.", new DateTime(2023, 1, 16, 10, 57, 2, 244, DateTimeKind.Utc).AddTicks(7041), 23L, "velit", "Minus possimus sint corrupti.", 3, "", 0, "Facere possimus aperiam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "TestCases" },
                values: new object[] { 23L, "Magni vel sint et quae ad dolor sint modi. Quia eos nihil hic modi commodi assumenda consequuntur. Et minus vero libero suscipit odit. Accusamus omnis veniam rerum non tenetur vel dolore necessitatibus animi.", new DateTime(2023, 8, 23, 0, 16, 6, 747, DateTimeKind.Utc).AddTicks(8562), 35L, "In in inventore enim qui.\nUnde fugit voluptate incidunt quidem qui odit.\nPossimus dolor veritatis dolorum.\nEst quae aut dolore nobis velit velit sequi ut.\nRem dolorem id assumenda quia.\nAut consectetur et praesentium consequatur similique sapiente.", "Libero saepe ex nisi aperiam ut id voluptates quidem deleniti.", "", "Quis iste quae.\nAliquam dolor quia laborum qui eum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 30L, "Est autem recusandae et eveniet vel. Nam tenetur doloribus dignissimos nesciunt est beatae dicta incidunt et. Omnis voluptatem velit blanditiis necessitatibus. Ea ut omnis accusamus. Voluptatum illum omnis qui qui.", new DateTime(2020, 5, 13, 23, 54, 27, 336, DateTimeKind.Utc).AddTicks(8983), 10L, "Veritatis reprehenderit deleniti ipsum soluta.\nConsectetur nesciunt sint quis distinctio omnis.\nQuae ut sapiente dignissimos et quibusdam.\nEsse est eius veritatis porro qui ut ea qui voluptatem.\nMollitia qui autem nesciunt.\nAut enim non quia et voluptatibus corporis assumenda placeat laboriosam.", "Ducimus et suscipit voluptas voluptas eius nemo quis sit quis.", 4, "", 1, "Quaerat excepturi ab eius exercitationem quos dignissimos saepe id asperiores. Eius illo velit aspernatur. Laudantium tempora adipisci et quibusdam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 50L, "dolorem", new DateTime(2023, 4, 1, 5, 48, 37, 704, DateTimeKind.Utc).AddTicks(2412), 21L, "Maxime qui mollitia illum voluptatibus aut ut unde est et.\nNeque aspernatur non quia minima exercitationem cupiditate labore.\nVelit et est aut beatae culpa voluptatem quibusdam recusandae.\nUnde sit ut omnis qui enim ex ex ab.\nNon rerum optio dolorem fuga numquam unde.", "Et hic nulla velit quia esse blanditiis.", 2, "", "Eos veritatis dolor impedit necessitatibus alias hic ipsum. Fuga dolor iusto. Qui ipsam autem facilis nulla. Dolores quibusdam deserunt." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 15L, "Ipsum et temporibus beatae ex dolorum suscipit iure.", new DateTime(2020, 1, 11, 12, 13, 16, 667, DateTimeKind.Utc).AddTicks(378), 27L, "Natus non consequatur ut voluptatum eos aperiam. Dicta porro ex. Quo tempore incidunt praesentium enim eos. Est non eaque enim et maxime enim.", "Et provident soluta alias quos id.", 3, "", 3, "molestiae" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 13L, "Dicta eveniet iusto mollitia occaecati rerum odit molestiae. Veritatis quia dolorem optio cupiditate quaerat praesentium sequi quia. Dolorem architecto nihil molestiae temporibus. Ut consequatur modi ratione ipsum nulla quod veniam et tenetur.", new DateTime(2022, 11, 1, 13, 45, 34, 737, DateTimeKind.Utc).AddTicks(9947), 30L, "et", "Mollitia accusamus nemo consequatur ipsam aut sit.", 4, "", "Ratione facere est aut alias aut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 61L, "Eius culpa perspiciatis qui similique aut maiores. Blanditiis dolorum quisquam. Ut velit unde. Autem qui voluptatum. Modi aperiam dolores quod et. Et dolorem iusto sed et.", new DateTime(2023, 6, 11, 18, 41, 16, 91, DateTimeKind.Utc).AddTicks(9419), 38L, "Distinctio tempora quisquam.", "Consequatur id ut laborum distinctio totam facilis quo unde culpa.", 1, "", 3, "tempora" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 66L, "Dignissimos aut qui minima.", new DateTime(2022, 7, 22, 5, 53, 28, 899, DateTimeKind.Utc).AddTicks(332), 29L, "nihil", "Qui ut quia ut aspernatur animi possimus asperiores voluptate corrupti.", 4, "", 3, "Aliquam iste et nulla ut consectetur necessitatibus. Quasi quis est nihil quis soluta sequi sint dicta ipsum. Qui fugiat dignissimos architecto vel id rerum dolorem." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 50L, "Quo nobis dolorum quibusdam. Aut quas nostrum. Minus aut laboriosam iusto id consequatur deleniti nobis odit eum.", new DateTime(2023, 6, 16, 3, 32, 14, 911, DateTimeKind.Utc).AddTicks(9779), 11L, "Natus occaecati quia omnis qui.\nTempore repellendus voluptatem.\nUt neque dolorem perspiciatis enim fuga nostrum hic quidem officia.", "Molestiae quia optio.", "", 2, "Laudantium ipsum odio est porro et culpa est." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 54L, "Autem dolor sint et ab.\nLibero iusto animi.\nFacere et consequatur.", new DateTime(2022, 6, 16, 18, 35, 36, 136, DateTimeKind.Utc).AddTicks(3921), 1L, "qui", "Architecto ut dolor molestiae.", 1, "", 1, "Exercitationem quis est a et nulla.\nVoluptatibus accusamus dolore enim earum quia id qui aliquid." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 69L, "Sit ut hic molestiae recusandae placeat et possimus est. Asperiores et in. Amet qui velit sunt quis ipsa at maiores. Ut adipisci velit perspiciatis quod cumque quae nihil. Possimus natus repudiandae minima beatae quo quam voluptatem.", new DateTime(2022, 12, 3, 14, 25, 30, 49, DateTimeKind.Utc).AddTicks(7863), 30L, "Voluptatem voluptatibus atque consequatur animi deserunt itaque ut.", "Ut voluptatem officiis distinctio repellendus voluptas quas similique eveniet ut.", 4, "", "Et eaque debitis consequatur." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 27L, "Quo omnis et molestias sunt tempore accusantium animi eligendi quod.", new DateTime(2022, 10, 25, 16, 35, 49, 150, DateTimeKind.Utc).AddTicks(3033), 23L, "nobis", "Illo soluta eligendi.", 1, "", "Vel necessitatibus nihil quisquam.\nLaborum quia dolorem dolorum similique iure aspernatur." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 66L, "Id minima rerum perspiciatis.\nIpsam quidem suscipit quia beatae sequi qui eius consectetur occaecati.\nTotam maiores delectus eius qui dolor.\nQuos beatae voluptatem repellat aut.\nEst voluptatum unde quia.\nDelectus odit numquam natus omnis.", new DateTime(2022, 11, 12, 15, 29, 15, 217, DateTimeKind.Utc).AddTicks(2619), 29L, "Id repellat ipsa optio recusandae exercitationem sed sit sed.", "Aut unde saepe velit rem repudiandae eos.", 2, "", 1, "Dignissimos ut ducimus vel voluptas cumque necessitatibus et dignissimos.\nId assumenda distinctio nihil.\nQui totam expedita.\nEt dicta rem id est.\nNulla tempora velit adipisci voluptates modi tempora." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 14L, "Est ut distinctio.", new DateTime(2023, 4, 29, 9, 8, 40, 333, DateTimeKind.Utc).AddTicks(4488), 24L, "Voluptatem eum ea est repellendus optio. Quia tempore ut temporibus nesciunt dolores. Vel culpa recusandae est et soluta sequi eveniet.", "Illum explicabo odit.", 2, "", 3, "Voluptatum deleniti accusamus sed non vel. Pariatur est sit ex est. Voluptatem molestias ut enim veniam nam sequi dolores. Voluptatem autem vel sed et ea consequuntur assumenda. Velit officiis qui qui rerum. Libero reprehenderit natus aut eos." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 15L, "Sapiente voluptatem sed.", new DateTime(2019, 1, 8, 9, 55, 24, 281, DateTimeKind.Utc).AddTicks(5305), 8L, "Rerum in voluptatibus quia eos non in enim quam.", "Odit ipsa enim quo et voluptates dolores id in facere.", 1, "", 2, "aperiam" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 61L, "beatae", new DateTime(2023, 8, 17, 3, 21, 45, 756, DateTimeKind.Utc).AddTicks(8122), 37L, "Quisquam magni optio dolorem dolorem reprehenderit omnis expedita ipsam.", "Quasi et beatae hic sint qui.", 1, "", 0, "dolor" });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 21, 47, 38, 672, DateTimeKind.Utc).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2018, 3, 15, 5, 35, 51, 330, DateTimeKind.Utc).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 7, 29, 55, 499, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 57, 14, 773, DateTimeKind.Utc).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 19, 21, 29, 52, 720, DateTimeKind.Utc).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 19, 5, 28, 3, 409, DateTimeKind.Utc).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 5, 20, 43, 10, 89, DateTimeKind.Utc).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2017, 1, 15, 9, 1, 15, 940, DateTimeKind.Utc).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 4, 15, 32, 51, 19, DateTimeKind.Utc).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 30, 20, 21, 12, 517, DateTimeKind.Utc).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2018, 1, 12, 17, 33, 57, 141, DateTimeKind.Utc).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 8, 21, 12, 5, 683, DateTimeKind.Utc).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2017, 10, 22, 8, 28, 11, 943, DateTimeKind.Utc).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 11, 58, 12, 22, DateTimeKind.Utc).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2018, 7, 13, 6, 6, 42, 374, DateTimeKind.Utc).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 16, 15, 38, 26, 384, DateTimeKind.Utc).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 16, 0, 1, 15, 792, DateTimeKind.Utc).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 16, 20, 27, 56, 499, DateTimeKind.Utc).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 22, 2, 11, 21, 637, DateTimeKind.Utc).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 31, 23, 9, 18, 482, DateTimeKind.Utc).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 26, 6, 45, 59, 264, DateTimeKind.Utc).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 25, 0, 53, 11, 71, DateTimeKind.Utc).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 20, 7, 54, 8, 324, DateTimeKind.Utc).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 9, 5, 17, 58, 902, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 3, 11, 51, 5, 118, DateTimeKind.Utc).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 3, 5, 42, 11, 441, DateTimeKind.Utc).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 10, 17, 8, 27, 198, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTime(2022, 2, 10, 15, 25, 17, 510, DateTimeKind.Utc).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 24, 16, 52, 3, 273, DateTimeKind.Utc).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2017, 6, 30, 22, 1, 31, 650, DateTimeKind.Utc).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 8, 6, 21, 56, 450, DateTimeKind.Utc).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 5, 5, 55, 58, 993, DateTimeKind.Utc).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 11, 17, 52, 698, DateTimeKind.Utc).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 19, 2, 15, 31, 50, DateTimeKind.Utc).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 8, 20, 47, 12, 735, DateTimeKind.Utc).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 30, 0, 9, 37, 690, DateTimeKind.Utc).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 25, 14, 52, 57, 99, DateTimeKind.Utc).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 17, 6, 10, 3, 996, DateTimeKind.Utc).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedAt",
                value: new DateTime(2022, 2, 10, 17, 29, 36, 917, DateTimeKind.Utc).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 12, 12, 34, 38, 249, DateTimeKind.Utc).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 29, 13, 8, 10, 112, DateTimeKind.Utc).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 2, 21, 20, 57, 407, DateTimeKind.Utc).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 19, 22, 33, 52, 560, DateTimeKind.Utc).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedAt",
                value: new DateTime(2019, 2, 6, 14, 30, 14, 968, DateTimeKind.Utc).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 6, 58, 30, 864, DateTimeKind.Utc).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 26, 0, 36, 16, 71, DateTimeKind.Utc).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 5, 22, 51, 15, 753, DateTimeKind.Utc).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 48L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 1, 6, 4, 55, 70, DateTimeKind.Utc).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 21, 5, 59, 988, DateTimeKind.Utc).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 20, 11, 27, 26, 302, DateTimeKind.Utc).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 18, 6, 35, 4, 644, DateTimeKind.Utc).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedAt",
                value: new DateTime(2022, 1, 28, 4, 18, 13, 437, DateTimeKind.Utc).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedAt",
                value: new DateTime(2019, 4, 10, 22, 17, 25, 814, DateTimeKind.Utc).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedAt",
                value: new DateTime(2022, 1, 23, 18, 34, 58, 187, DateTimeKind.Utc).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 19, 7, 11, 21, 869, DateTimeKind.Utc).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 56L,
                column: "CreatedAt",
                value: new DateTime(2018, 4, 21, 18, 10, 0, 292, DateTimeKind.Utc).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 4, 14, 15, 57, 452, DateTimeKind.Utc).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 18, 3, 57, 15, 16, DateTimeKind.Utc).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 14, 17, 41, 13, 247, DateTimeKind.Utc).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedAt",
                value: new DateTime(2019, 2, 23, 19, 11, 40, 664, DateTimeKind.Utc).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 24, 16, 7, 5, 41, DateTimeKind.Utc).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 1, 12, 58, 46, 245, DateTimeKind.Utc).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 14, 3, 24, 15, 688, DateTimeKind.Utc).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 64L,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 19, 12, 26, 30, 517, DateTimeKind.Utc).AddTicks(1828));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 17, 0, 11, 29, 27, DateTimeKind.Utc).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 27, 19, 40, 32, 975, DateTimeKind.Utc).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 19, 15, 39, 367, DateTimeKind.Utc).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 10, 18, 36, 43, 297, DateTimeKind.Utc).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 1, 42, 18, 650, DateTimeKind.Utc).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 44, 11, 16, DateTimeKind.Utc).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 17, 16, 46, 19, 487, DateTimeKind.Utc).AddTicks(4622), new DateTime(2023, 7, 16, 1, 36, 52, 728, DateTimeKind.Utc).AddTicks(3705), new DateTime(2022, 8, 11, 21, 35, 45, 905, DateTimeKind.Utc).AddTicks(3720), new DateTime(2023, 7, 18, 9, 6, 7, 756, DateTimeKind.Utc).AddTicks(3) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 14, 20, 8, 22, 963, DateTimeKind.Utc).AddTicks(804), new DateTime(2023, 7, 27, 10, 46, 27, 838, DateTimeKind.Utc).AddTicks(6752), new DateTime(2023, 1, 19, 8, 44, 26, 685, DateTimeKind.Utc).AddTicks(1290), new DateTime(2023, 2, 4, 3, 28, 52, 369, DateTimeKind.Utc).AddTicks(6070) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 6, 11, 20, 22, 35, DateTimeKind.Utc).AddTicks(4540), new DateTime(2023, 7, 25, 6, 27, 49, 269, DateTimeKind.Utc).AddTicks(3775), new DateTime(2023, 5, 7, 20, 25, 8, 156, DateTimeKind.Utc).AddTicks(5853), new DateTime(2023, 7, 18, 15, 35, 31, 571, DateTimeKind.Utc).AddTicks(5798) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 1, 11, 9, 24, 36, 746, DateTimeKind.Utc).AddTicks(4939), new DateTime(2022, 5, 29, 21, 20, 58, 283, DateTimeKind.Utc).AddTicks(8083), new DateTime(2021, 7, 30, 16, 50, 9, 356, DateTimeKind.Utc).AddTicks(5386), new DateTime(2022, 8, 10, 10, 29, 17, 215, DateTimeKind.Utc).AddTicks(3730) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 10, 2, 9, 139, DateTimeKind.Utc).AddTicks(4772), new DateTime(2023, 5, 4, 9, 7, 42, 332, DateTimeKind.Utc).AddTicks(3308), new DateTime(2022, 10, 27, 14, 1, 29, 717, DateTimeKind.Utc).AddTicks(3072), new DateTime(2023, 8, 12, 3, 37, 42, 954, DateTimeKind.Utc).AddTicks(5096) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 9, 11, 20, 39, 11, 304, DateTimeKind.Utc).AddTicks(8660), new DateTime(2021, 4, 9, 3, 51, 0, 58, DateTimeKind.Utc).AddTicks(4132), new DateTime(2018, 12, 15, 12, 35, 27, 502, DateTimeKind.Utc).AddTicks(2040), new DateTime(2019, 12, 28, 0, 26, 5, 270, DateTimeKind.Utc).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 2, 19, 21, 35, 12, 873, DateTimeKind.Utc).AddTicks(774), new DateTime(2023, 1, 27, 9, 0, 43, 152, DateTimeKind.Utc).AddTicks(4379), new DateTime(2020, 4, 21, 6, 8, 47, 434, DateTimeKind.Utc).AddTicks(3651), new DateTime(2021, 1, 21, 21, 9, 20, 75, DateTimeKind.Utc).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 10, 14, 22, 19, 17, 508, DateTimeKind.Utc).AddTicks(7799), new DateTime(2022, 8, 23, 16, 20, 22, 166, DateTimeKind.Utc).AddTicks(4759), new DateTime(2021, 5, 4, 18, 13, 39, 782, DateTimeKind.Utc).AddTicks(6183), new DateTime(2021, 7, 15, 22, 48, 15, 167, DateTimeKind.Utc).AddTicks(2797) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 9, 45, 52, 972, DateTimeKind.Utc).AddTicks(3584), new DateTime(2023, 5, 24, 8, 46, 10, 334, DateTimeKind.Utc).AddTicks(6578), new DateTime(2021, 5, 31, 5, 11, 47, 334, DateTimeKind.Utc).AddTicks(6380), new DateTime(2022, 4, 29, 12, 16, 43, 103, DateTimeKind.Utc).AddTicks(3563) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 3, 15, 48, 36, 82, DateTimeKind.Utc).AddTicks(6533), new DateTime(2022, 3, 18, 20, 14, 14, 512, DateTimeKind.Utc).AddTicks(4038), new DateTime(2021, 3, 11, 19, 59, 16, 63, DateTimeKind.Utc).AddTicks(1638), new DateTime(2022, 12, 2, 4, 18, 2, 783, DateTimeKind.Utc).AddTicks(6134) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 25, 15, 59, 23, 966, DateTimeKind.Utc).AddTicks(379), new DateTime(2023, 4, 7, 10, 3, 28, 644, DateTimeKind.Utc).AddTicks(7249), new DateTime(2023, 1, 10, 10, 59, 26, 402, DateTimeKind.Utc).AddTicks(5677), new DateTime(2023, 2, 13, 22, 31, 27, 788, DateTimeKind.Utc).AddTicks(4626) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 15, 19, 39, 58, 142, DateTimeKind.Utc).AddTicks(3378), new DateTime(2022, 12, 14, 0, 57, 54, 233, DateTimeKind.Utc).AddTicks(4455), new DateTime(2022, 9, 19, 4, 10, 9, 795, DateTimeKind.Utc).AddTicks(500), new DateTime(2023, 8, 9, 12, 37, 47, 615, DateTimeKind.Utc).AddTicks(4708) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 15, 16, 54, 51, 239, DateTimeKind.Utc).AddTicks(8899), new DateTime(2023, 9, 6, 19, 20, 52, 926, DateTimeKind.Utc).AddTicks(4679), new DateTime(2023, 4, 15, 18, 58, 55, 509, DateTimeKind.Utc).AddTicks(7361), new DateTime(2023, 8, 28, 13, 6, 16, 612, DateTimeKind.Utc).AddTicks(1285) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 5, 23, 13, 27, 39, 17, DateTimeKind.Utc).AddTicks(1293), new DateTime(2020, 7, 25, 22, 35, 32, 599, DateTimeKind.Utc).AddTicks(6091), new DateTime(2019, 11, 11, 8, 11, 35, 254, DateTimeKind.Utc).AddTicks(5924), new DateTime(2022, 10, 22, 17, 50, 39, 218, DateTimeKind.Utc).AddTicks(4603) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 9, 1, 7, 41, 26, 581, DateTimeKind.Utc).AddTicks(6472), new DateTime(2022, 8, 11, 16, 45, 19, 411, DateTimeKind.Utc).AddTicks(5804), new DateTime(2021, 3, 30, 5, 7, 11, 408, DateTimeKind.Utc).AddTicks(190), new DateTime(2023, 7, 5, 6, 15, 23, 928, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 6, 21, 41, 25, 374, DateTimeKind.Utc).AddTicks(2264), new DateTime(2023, 8, 17, 13, 48, 55, 995, DateTimeKind.Utc).AddTicks(8956), new DateTime(2023, 2, 15, 13, 23, 45, 602, DateTimeKind.Utc).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 1, 23, 4, 0, 12, 459, DateTimeKind.Utc).AddTicks(3250), new DateTime(2020, 12, 3, 2, 36, 3, 692, DateTimeKind.Utc).AddTicks(9838), new DateTime(2019, 1, 17, 14, 26, 6, 726, DateTimeKind.Utc).AddTicks(5368), new DateTime(2020, 8, 18, 23, 42, 3, 33, DateTimeKind.Utc).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 10, 57, 48, 780, DateTimeKind.Utc).AddTicks(777), new DateTime(2023, 7, 30, 20, 20, 41, 317, DateTimeKind.Utc).AddTicks(4486), new DateTime(2020, 12, 23, 10, 14, 0, 564, DateTimeKind.Utc).AddTicks(7490), new DateTime(2021, 11, 29, 5, 39, 51, 593, DateTimeKind.Utc).AddTicks(238) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 8, 3, 2, 37, 8, 193, DateTimeKind.Utc).AddTicks(6485), new DateTime(2023, 7, 2, 4, 2, 10, 609, DateTimeKind.Utc).AddTicks(248), new DateTime(2023, 6, 21, 11, 49, 41, 221, DateTimeKind.Utc).AddTicks(1198), new DateTime(2023, 7, 17, 21, 31, 16, 786, DateTimeKind.Utc).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 3, 24, 14, 46, 22, 199, DateTimeKind.Utc).AddTicks(3365), new DateTime(2020, 2, 25, 4, 43, 56, 710, DateTimeKind.Utc).AddTicks(800), new DateTime(2019, 11, 25, 9, 7, 19, 210, DateTimeKind.Utc).AddTicks(8968), new DateTime(2022, 3, 8, 18, 46, 10, 802, DateTimeKind.Utc).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 3, 7, 51, 30, 595, DateTimeKind.Utc).AddTicks(7868), new DateTime(2023, 5, 27, 10, 4, 26, 598, DateTimeKind.Utc).AddTicks(322), new DateTime(2022, 3, 1, 0, 19, 51, 271, DateTimeKind.Utc).AddTicks(7539), new DateTime(2023, 6, 13, 11, 30, 6, 622, DateTimeKind.Utc).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 20, 56, 14, 283, DateTimeKind.Utc).AddTicks(8107), new DateTime(2023, 4, 30, 1, 39, 13, 617, DateTimeKind.Utc).AddTicks(2700), new DateTime(2019, 12, 13, 9, 49, 27, 751, DateTimeKind.Utc).AddTicks(9904), new DateTime(2022, 5, 11, 11, 31, 10, 736, DateTimeKind.Utc).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 3, 24, 19, 28, 59, 141, DateTimeKind.Utc).AddTicks(2535), new DateTime(2020, 3, 19, 9, 5, 37, 207, DateTimeKind.Utc).AddTicks(5139), new DateTime(2017, 7, 19, 0, 41, 52, 565, DateTimeKind.Utc).AddTicks(5269), new DateTime(2023, 8, 27, 19, 56, 51, 253, DateTimeKind.Utc).AddTicks(5785) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 5, 22, 0, 48, 5, 804, DateTimeKind.Utc).AddTicks(1929), new DateTime(2019, 7, 31, 13, 18, 50, 815, DateTimeKind.Utc).AddTicks(2485), new DateTime(2019, 3, 29, 17, 8, 53, 978, DateTimeKind.Utc).AddTicks(3949), new DateTime(2020, 9, 16, 15, 4, 20, 682, DateTimeKind.Utc).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 8, 1, 23, 907, DateTimeKind.Utc).AddTicks(561), new DateTime(2023, 4, 1, 6, 38, 39, 301, DateTimeKind.Utc).AddTicks(6345), new DateTime(2021, 4, 9, 19, 42, 29, 172, DateTimeKind.Utc).AddTicks(6757), new DateTime(2022, 4, 6, 14, 58, 3, 527, DateTimeKind.Utc).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 22, 7, 31, 9, 399, DateTimeKind.Utc).AddTicks(2682), new DateTime(2023, 5, 12, 3, 23, 10, 417, DateTimeKind.Utc).AddTicks(8453), new DateTime(2023, 2, 9, 17, 49, 10, 993, DateTimeKind.Utc).AddTicks(6758), new DateTime(2023, 3, 30, 17, 42, 46, 143, DateTimeKind.Utc).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 1, 55, 22, 383, DateTimeKind.Utc).AddTicks(7387), new DateTime(2022, 12, 22, 12, 7, 37, 628, DateTimeKind.Utc).AddTicks(7184), new DateTime(2022, 7, 1, 21, 3, 12, 914, DateTimeKind.Utc).AddTicks(6286) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 23, 23, 15, 13, 472, DateTimeKind.Utc).AddTicks(1948), new DateTime(2023, 5, 23, 17, 22, 42, 132, DateTimeKind.Utc).AddTicks(326), new DateTime(2023, 3, 22, 19, 38, 30, 865, DateTimeKind.Utc).AddTicks(1237), new DateTime(2023, 8, 9, 22, 11, 25, 876, DateTimeKind.Utc).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 19, 5, 45, 43, 77, DateTimeKind.Utc).AddTicks(4570), new DateTime(2023, 3, 31, 18, 30, 28, 497, DateTimeKind.Utc).AddTicks(5534), new DateTime(2023, 2, 22, 2, 15, 53, 195, DateTimeKind.Utc).AddTicks(2110), new DateTime(2023, 7, 12, 4, 50, 53, 726, DateTimeKind.Utc).AddTicks(7032) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 8, 8, 15, 4, 631, DateTimeKind.Utc).AddTicks(1097), new DateTime(2023, 7, 17, 8, 56, 59, 832, DateTimeKind.Utc).AddTicks(1937), new DateTime(2021, 8, 2, 22, 37, 42, 553, DateTimeKind.Utc).AddTicks(1711), new DateTime(2022, 6, 20, 18, 54, 51, 573, DateTimeKind.Utc).AddTicks(9595) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 3, 22, 40, 8, DateTimeKind.Utc).AddTicks(7475), new DateTime(2023, 8, 17, 8, 34, 23, 635, DateTimeKind.Utc).AddTicks(2488), new DateTime(2023, 8, 13, 8, 3, 38, 389, DateTimeKind.Utc).AddTicks(409), new DateTime(2023, 8, 25, 23, 1, 22, 358, DateTimeKind.Utc).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 8, 5, 22, 44, 455, DateTimeKind.Utc).AddTicks(4559), new DateTime(2022, 3, 30, 7, 45, 3, 963, DateTimeKind.Utc).AddTicks(5970), new DateTime(2022, 2, 6, 16, 22, 40, 18, DateTimeKind.Utc).AddTicks(3302), new DateTime(2023, 6, 28, 20, 5, 36, 970, DateTimeKind.Utc).AddTicks(5238) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 8, 30, 18, 0, 54, 607, DateTimeKind.Utc).AddTicks(9953), new DateTime(2022, 6, 20, 12, 33, 2, 833, DateTimeKind.Utc).AddTicks(2546), new DateTime(2019, 6, 13, 12, 35, 18, 19, DateTimeKind.Utc).AddTicks(2841), new DateTime(2019, 8, 22, 9, 27, 55, 193, DateTimeKind.Utc).AddTicks(4421) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 15, 13, 53, 26, 124, DateTimeKind.Utc).AddTicks(7800), new DateTime(2023, 8, 29, 17, 9, 48, 689, DateTimeKind.Utc).AddTicks(2408), new DateTime(2022, 8, 15, 1, 38, 8, 521, DateTimeKind.Utc).AddTicks(6878), new DateTime(2022, 9, 12, 17, 15, 33, 44, DateTimeKind.Utc).AddTicks(8061) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2019, 11, 30, 18, 24, 36, 7, DateTimeKind.Utc).AddTicks(3643), new DateTime(2019, 10, 26, 7, 53, 41, 402, DateTimeKind.Utc).AddTicks(4930), new DateTime(2018, 8, 2, 21, 38, 5, 152, DateTimeKind.Utc).AddTicks(7462), new DateTime(2021, 3, 17, 6, 19, 5, 145, DateTimeKind.Utc).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 11, 31, 57, 889, DateTimeKind.Utc).AddTicks(4705), new DateTime(2021, 11, 20, 19, 12, 14, 839, DateTimeKind.Utc).AddTicks(8686), new DateTime(2021, 4, 7, 7, 21, 55, 394, DateTimeKind.Utc).AddTicks(5122), new DateTime(2021, 12, 5, 6, 10, 3, 292, DateTimeKind.Utc).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 23, 37, 6, 868, DateTimeKind.Utc).AddTicks(5521), new DateTime(2023, 4, 3, 12, 34, 28, 464, DateTimeKind.Utc).AddTicks(8732), new DateTime(2022, 7, 6, 12, 6, 59, 4, DateTimeKind.Utc).AddTicks(8390), new DateTime(2023, 4, 16, 5, 57, 55, 95, DateTimeKind.Utc).AddTicks(663) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 8, 48, 42, 761, DateTimeKind.Utc).AddTicks(9084), new DateTime(2023, 8, 14, 20, 36, 0, 89, DateTimeKind.Utc).AddTicks(2595), new DateTime(2023, 6, 23, 23, 30, 46, 923, DateTimeKind.Utc).AddTicks(9891), new DateTime(2023, 8, 20, 15, 42, 45, 678, DateTimeKind.Utc).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 21, 13, 34, 46, 941, DateTimeKind.Utc).AddTicks(5215), new DateTime(2023, 6, 25, 7, 27, 8, 293, DateTimeKind.Utc).AddTicks(3049), new DateTime(2023, 5, 20, 9, 5, 18, 21, DateTimeKind.Utc).AddTicks(3738) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 26, 11, 9, 3, 647, DateTimeKind.Utc).AddTicks(8277), new DateTime(2022, 7, 7, 1, 21, 2, 215, DateTimeKind.Utc).AddTicks(8040), new DateTime(2020, 12, 15, 20, 5, 38, 486, DateTimeKind.Utc).AddTicks(2364), new DateTime(2022, 8, 5, 0, 12, 49, 126, DateTimeKind.Utc).AddTicks(3706) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 12, 26, 13, 52, 21, 506, DateTimeKind.Utc).AddTicks(5459), new DateTime(2020, 1, 23, 23, 3, 43, 509, DateTimeKind.Utc).AddTicks(2190), new DateTime(2019, 11, 27, 15, 25, 46, 652, DateTimeKind.Utc).AddTicks(1769), new DateTime(2023, 6, 9, 10, 21, 57, 225, DateTimeKind.Utc).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 5, 19, 12, 8, 10, 800, DateTimeKind.Utc).AddTicks(754), new DateTime(2023, 7, 12, 23, 34, 49, 401, DateTimeKind.Utc).AddTicks(4954), new DateTime(2020, 6, 4, 23, 13, 2, 676, DateTimeKind.Utc).AddTicks(408), new DateTime(2020, 11, 1, 7, 40, 11, 194, DateTimeKind.Utc).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 22, 7, 7, 52, 751, DateTimeKind.Utc).AddTicks(8877), new DateTime(2023, 8, 17, 9, 43, 4, 912, DateTimeKind.Utc).AddTicks(1247), new DateTime(2023, 8, 3, 2, 24, 10, 527, DateTimeKind.Utc).AddTicks(9236), new DateTime(2023, 9, 1, 11, 8, 13, 782, DateTimeKind.Utc).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 25, 22, 12, 32, 481, DateTimeKind.Utc).AddTicks(2852), new DateTime(2023, 8, 12, 16, 16, 5, 315, DateTimeKind.Utc).AddTicks(8883), new DateTime(2023, 6, 28, 13, 58, 5, 894, DateTimeKind.Utc).AddTicks(6179), new DateTime(2023, 7, 23, 9, 35, 51, 769, DateTimeKind.Utc).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 9, 18, 1, 46, DateTimeKind.Utc).AddTicks(7974), new DateTime(2023, 4, 21, 21, 28, 18, 760, DateTimeKind.Utc).AddTicks(2647), new DateTime(2022, 9, 13, 18, 59, 43, 226, DateTimeKind.Utc).AddTicks(6475), new DateTime(2023, 3, 18, 11, 12, 45, 611, DateTimeKind.Utc).AddTicks(9262) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 15, 22, 51, 21, 75, DateTimeKind.Utc).AddTicks(8781), new DateTime(2022, 2, 11, 16, 45, 7, 93, DateTimeKind.Utc).AddTicks(4264), new DateTime(2020, 6, 12, 0, 53, 35, 795, DateTimeKind.Utc).AddTicks(7196), new DateTime(2021, 11, 20, 8, 49, 36, 646, DateTimeKind.Utc).AddTicks(1977) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 5, 18, 11, 50, 11, 810, DateTimeKind.Utc).AddTicks(4017), new DateTime(2023, 8, 26, 0, 0, 15, 843, DateTimeKind.Utc).AddTicks(742), new DateTime(2023, 4, 12, 16, 7, 54, 153, DateTimeKind.Utc).AddTicks(3868), new DateTime(2023, 8, 8, 14, 57, 36, 257, DateTimeKind.Utc).AddTicks(8406) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 7, 1, 5, 5, 48, 911, DateTimeKind.Utc).AddTicks(4123), new DateTime(2021, 12, 10, 4, 43, 23, 150, DateTimeKind.Utc).AddTicks(8978), new DateTime(2020, 1, 2, 17, 21, 55, 883, DateTimeKind.Utc).AddTicks(5956), new DateTime(2021, 2, 20, 7, 54, 4, 549, DateTimeKind.Utc).AddTicks(373) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 53, 9, 114, DateTimeKind.Utc).AddTicks(7022), new DateTime(2023, 8, 25, 23, 54, 1, 473, DateTimeKind.Utc).AddTicks(5462), new DateTime(2023, 3, 31, 22, 57, 11, 526, DateTimeKind.Utc).AddTicks(5452), new DateTime(2023, 8, 22, 11, 4, 37, 96, DateTimeKind.Utc).AddTicks(964) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2021, 8, 11, 2, 23, 9, 978, DateTimeKind.Utc).AddTicks(2209), new DateTime(2021, 6, 28, 3, 19, 14, 142, DateTimeKind.Utc).AddTicks(5540), new DateTime(2020, 3, 4, 6, 55, 7, 100, DateTimeKind.Utc).AddTicks(3501) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 4, 26, 15, 9, 16, 879, DateTimeKind.Utc).AddTicks(2350), new DateTime(2021, 5, 10, 8, 42, 41, 570, DateTimeKind.Utc).AddTicks(3958), new DateTime(2019, 10, 28, 22, 47, 41, 283, DateTimeKind.Utc).AddTicks(1832), new DateTime(2023, 2, 13, 6, 43, 20, 97, DateTimeKind.Utc).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 14, 12, 14, 24, 774, DateTimeKind.Utc).AddTicks(5996), new DateTime(2023, 8, 3, 22, 1, 28, 993, DateTimeKind.Utc).AddTicks(5761), new DateTime(2023, 7, 2, 23, 14, 33, 126, DateTimeKind.Utc).AddTicks(9027), new DateTime(2023, 7, 29, 6, 55, 16, 691, DateTimeKind.Utc).AddTicks(2005) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 7, 9, 56, 39, 176, DateTimeKind.Utc).AddTicks(6113), new DateTime(2023, 8, 2, 2, 37, 45, 674, DateTimeKind.Utc).AddTicks(501), new DateTime(2022, 3, 21, 11, 19, 7, 889, DateTimeKind.Utc).AddTicks(3177), new DateTime(2022, 4, 9, 16, 58, 54, 575, DateTimeKind.Utc).AddTicks(9742) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 3, 22, 19, 31, 54, 904, DateTimeKind.Utc).AddTicks(9008), new DateTime(2022, 9, 7, 7, 23, 57, 379, DateTimeKind.Utc).AddTicks(457), new DateTime(2021, 10, 18, 1, 46, 38, 864, DateTimeKind.Utc).AddTicks(477), new DateTime(2022, 4, 10, 0, 49, 28, 261, DateTimeKind.Utc).AddTicks(9315) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 1, 16, 8, 45, 56, 256, DateTimeKind.Utc).AddTicks(2882), new DateTime(2022, 9, 19, 8, 13, 17, 339, DateTimeKind.Utc).AddTicks(4533), new DateTime(2022, 8, 4, 12, 49, 35, 415, DateTimeKind.Utc).AddTicks(5582), new DateTime(2023, 7, 31, 14, 57, 18, 153, DateTimeKind.Utc).AddTicks(5552) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 1, 0, 11, 33, 869, DateTimeKind.Utc).AddTicks(8696), new DateTime(2023, 9, 6, 13, 28, 1, 628, DateTimeKind.Utc).AddTicks(5924), new DateTime(2023, 7, 4, 16, 31, 28, 917, DateTimeKind.Utc).AddTicks(2195), new DateTime(2023, 7, 12, 3, 45, 20, 301, DateTimeKind.Utc).AddTicks(9244) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 1, 18, 42, 105, DateTimeKind.Utc).AddTicks(590), new DateTime(2022, 9, 15, 5, 48, 30, 258, DateTimeKind.Utc).AddTicks(3394), new DateTime(2022, 6, 6, 1, 47, 26, 435, DateTimeKind.Utc).AddTicks(5087), new DateTime(2022, 12, 8, 19, 13, 12, 482, DateTimeKind.Utc).AddTicks(5196) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 26, 9, 48, 11, 437, DateTimeKind.Utc).AddTicks(7019), new DateTime(2023, 3, 10, 5, 14, 3, 594, DateTimeKind.Utc).AddTicks(6209), new DateTime(2023, 2, 14, 13, 11, 7, 140, DateTimeKind.Utc).AddTicks(597), new DateTime(2023, 4, 30, 21, 50, 4, 975, DateTimeKind.Utc).AddTicks(229) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 7, 12, 12, 5, 573, DateTimeKind.Utc).AddTicks(9797), new DateTime(2022, 11, 28, 3, 40, 49, 550, DateTimeKind.Utc).AddTicks(9754), new DateTime(2017, 4, 18, 15, 0, 49, 301, DateTimeKind.Utc).AddTicks(4162), new DateTime(2023, 7, 11, 5, 40, 40, 28, DateTimeKind.Utc).AddTicks(2971) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 19, 2, 21, 59, 372, DateTimeKind.Utc).AddTicks(3829), new DateTime(2023, 1, 11, 12, 10, 8, 184, DateTimeKind.Utc).AddTicks(4913), new DateTime(2022, 10, 28, 10, 46, 10, 523, DateTimeKind.Utc).AddTicks(5908), new DateTime(2023, 3, 11, 2, 38, 53, 611, DateTimeKind.Utc).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 3, 31, 5, 25, 4, 75, DateTimeKind.Utc).AddTicks(4434), new DateTime(2022, 8, 19, 0, 8, 10, 203, DateTimeKind.Utc).AddTicks(287), new DateTime(2021, 10, 8, 5, 7, 23, 101, DateTimeKind.Utc).AddTicks(8306), new DateTime(2023, 3, 31, 13, 46, 25, 138, DateTimeKind.Utc).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 8, 5, 10, 12, 35, 955, DateTimeKind.Utc).AddTicks(1170), new DateTime(2023, 3, 26, 11, 12, 28, 433, DateTimeKind.Utc).AddTicks(1585), new DateTime(2019, 11, 2, 17, 32, 11, 118, DateTimeKind.Utc).AddTicks(7508), new DateTime(2020, 8, 24, 7, 3, 13, 341, DateTimeKind.Utc).AddTicks(4932) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 8, 5, 57, 7, 679, DateTimeKind.Utc).AddTicks(3051), new DateTime(2023, 5, 11, 15, 34, 14, 791, DateTimeKind.Utc).AddTicks(5623), new DateTime(2022, 2, 27, 3, 46, 13, 501, DateTimeKind.Utc).AddTicks(4053), new DateTime(2022, 7, 10, 4, 30, 0, 899, DateTimeKind.Utc).AddTicks(5322) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 23, 16, 9, 49, 855, DateTimeKind.Utc).AddTicks(9084), new DateTime(2022, 10, 24, 21, 38, 21, 720, DateTimeKind.Utc).AddTicks(3130), new DateTime(2022, 5, 29, 20, 42, 38, 599, DateTimeKind.Utc).AddTicks(1585), new DateTime(2023, 4, 7, 18, 9, 28, 929, DateTimeKind.Utc).AddTicks(5755) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 6, 4, 14, 56, 5, 890, DateTimeKind.Utc).AddTicks(889), new DateTime(2021, 8, 6, 23, 50, 37, 152, DateTimeKind.Utc).AddTicks(4381), new DateTime(2021, 6, 20, 9, 27, 8, 334, DateTimeKind.Utc).AddTicks(2488), new DateTime(2022, 4, 2, 12, 46, 27, 675, DateTimeKind.Utc).AddTicks(1043) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 6, 14, 45, 23, 478, DateTimeKind.Utc).AddTicks(1315), new DateTime(2023, 8, 30, 13, 38, 24, 602, DateTimeKind.Utc).AddTicks(9256), new DateTime(2019, 3, 23, 20, 34, 42, 416, DateTimeKind.Utc).AddTicks(9299), new DateTime(2020, 11, 13, 1, 37, 11, 731, DateTimeKind.Utc).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 29, 13, 35, 14, 245, DateTimeKind.Utc).AddTicks(6047), new DateTime(2022, 10, 21, 11, 16, 28, 660, DateTimeKind.Utc).AddTicks(6244), new DateTime(2022, 6, 12, 14, 33, 11, 399, DateTimeKind.Utc).AddTicks(6019), new DateTime(2022, 12, 17, 16, 39, 29, 676, DateTimeKind.Utc).AddTicks(9739) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2018, 4, 4, 2, 51, 17, 521, DateTimeKind.Utc).AddTicks(4701), new DateTime(2018, 3, 18, 1, 6, 19, 999, DateTimeKind.Utc).AddTicks(3589), new DateTime(2017, 9, 18, 21, 48, 49, 422, DateTimeKind.Utc).AddTicks(3012), new DateTime(2019, 7, 9, 19, 44, 49, 407, DateTimeKind.Utc).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 7, 28, 18, 43, 26, 419, DateTimeKind.Utc).AddTicks(9453), new DateTime(2023, 8, 2, 5, 56, 58, 437, DateTimeKind.Utc).AddTicks(4198), new DateTime(2023, 7, 1, 1, 40, 56, 238, DateTimeKind.Utc).AddTicks(2490), new DateTime(2023, 7, 6, 19, 0, 53, 464, DateTimeKind.Utc).AddTicks(4891) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 3, 2, 47, 44, 138, DateTimeKind.Utc).AddTicks(297), new DateTime(2023, 1, 19, 5, 3, 55, 900, DateTimeKind.Utc).AddTicks(7100), new DateTime(2021, 7, 3, 6, 51, 55, 293, DateTimeKind.Utc).AddTicks(836), new DateTime(2022, 10, 30, 12, 41, 10, 697, DateTimeKind.Utc).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 3, 18, 4, 40, 30, 58, DateTimeKind.Utc).AddTicks(6998), new DateTime(2022, 2, 22, 2, 6, 12, 298, DateTimeKind.Utc).AddTicks(9322), new DateTime(2021, 10, 27, 20, 22, 41, 327, DateTimeKind.Utc).AddTicks(349), new DateTime(2023, 2, 2, 21, 0, 43, 967, DateTimeKind.Utc).AddTicks(8924) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 21, 10, 34, 50, 522, DateTimeKind.Utc).AddTicks(2203), new DateTime(2023, 4, 24, 2, 20, 42, 953, DateTimeKind.Utc).AddTicks(1432), new DateTime(2022, 10, 9, 3, 51, 21, 400, DateTimeKind.Utc).AddTicks(4270), new DateTime(2023, 8, 20, 22, 15, 22, 154, DateTimeKind.Utc).AddTicks(2947) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 14, 17, 964, DateTimeKind.Utc).AddTicks(7526), new DateTime(2023, 8, 13, 0, 2, 16, 967, DateTimeKind.Utc).AddTicks(3571), new DateTime(2022, 3, 7, 18, 52, 1, 788, DateTimeKind.Utc).AddTicks(7846), new DateTime(2022, 8, 21, 20, 16, 6, 706, DateTimeKind.Utc).AddTicks(488) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 1, 3, 10, 842, DateTimeKind.Utc).AddTicks(3751), new DateTime(2023, 6, 21, 13, 53, 14, 627, DateTimeKind.Utc).AddTicks(2305), new DateTime(2021, 7, 5, 5, 47, 11, 745, DateTimeKind.Utc).AddTicks(9773), new DateTime(2021, 12, 8, 19, 57, 53, 565, DateTimeKind.Utc).AddTicks(9615) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 31, 1, 12, 30, 961, DateTimeKind.Utc).AddTicks(6183), new DateTime(2023, 8, 13, 10, 8, 57, 788, DateTimeKind.Utc).AddTicks(9010), new DateTime(2023, 6, 30, 13, 18, 36, 738, DateTimeKind.Utc).AddTicks(5862), new DateTime(2023, 9, 1, 5, 42, 23, 309, DateTimeKind.Utc).AddTicks(9211) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 3, 4, 9, 43, 33, 833, DateTimeKind.Utc).AddTicks(3654), new DateTime(2023, 5, 9, 7, 11, 15, 906, DateTimeKind.Utc).AddTicks(8243), new DateTime(2023, 3, 19, 10, 53, 4, 618, DateTimeKind.Utc).AddTicks(5420), new DateTime(2023, 3, 25, 1, 23, 12, 793, DateTimeKind.Utc).AddTicks(4595) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 7, 53, 2, 42, DateTimeKind.Utc).AddTicks(3948), new DateTime(2022, 12, 28, 1, 10, 35, 460, DateTimeKind.Utc).AddTicks(1795), new DateTime(2022, 2, 17, 17, 46, 42, 11, DateTimeKind.Utc).AddTicks(312), new DateTime(2022, 7, 14, 19, 48, 50, 346, DateTimeKind.Utc).AddTicks(4782) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2023, 6, 29, 17, 29, 34, 614, DateTimeKind.Utc).AddTicks(5790), new DateTime(2023, 5, 31, 6, 21, 9, 82, DateTimeKind.Utc).AddTicks(1451), new DateTime(2022, 1, 5, 15, 15, 13, 291, DateTimeKind.Utc).AddTicks(5683) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 44, 395, DateTimeKind.Utc).AddTicks(6628), new DateTime(2022, 12, 25, 19, 58, 9, 402, DateTimeKind.Utc).AddTicks(7906), new DateTime(2022, 11, 6, 17, 46, 32, 975, DateTimeKind.Utc).AddTicks(1142), new DateTime(2023, 8, 30, 22, 54, 37, 852, DateTimeKind.Utc).AddTicks(8413) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2019, 6, 1, 6, 2, 30, 188, DateTimeKind.Utc).AddTicks(8588), new DateTime(2018, 11, 21, 21, 31, 56, 768, DateTimeKind.Utc).AddTicks(4800), new DateTime(2017, 4, 11, 1, 26, 40, 464, DateTimeKind.Utc).AddTicks(1478), new DateTime(2017, 12, 26, 12, 52, 24, 603, DateTimeKind.Utc).AddTicks(8742) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 8, 3, 3, 32, 43, 259, DateTimeKind.Utc).AddTicks(3226), new DateTime(2022, 9, 23, 23, 0, 58, 564, DateTimeKind.Utc).AddTicks(4494), new DateTime(2021, 10, 28, 20, 52, 14, 319, DateTimeKind.Utc).AddTicks(6667), new DateTime(2022, 8, 2, 15, 14, 23, 945, DateTimeKind.Utc).AddTicks(7813) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 3, 8, 7, 16, 45, 492, DateTimeKind.Utc).AddTicks(1349), new DateTime(2023, 9, 4, 8, 36, 35, 707, DateTimeKind.Utc).AddTicks(721), new DateTime(2023, 9, 2, 9, 9, 32, 489, DateTimeKind.Utc).AddTicks(8434), new DateTime(2023, 9, 4, 13, 7, 2, 343, DateTimeKind.Utc).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 10, 19, 18, 47, 5, 954, DateTimeKind.Utc).AddTicks(3962), new DateTime(2021, 11, 20, 23, 39, 49, 607, DateTimeKind.Utc).AddTicks(5188), new DateTime(2018, 4, 19, 11, 20, 8, 649, DateTimeKind.Utc).AddTicks(4427), new DateTime(2019, 7, 10, 11, 13, 38, 703, DateTimeKind.Utc).AddTicks(6521) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 6, 29, 22, 51, 44, 131, DateTimeKind.Utc).AddTicks(5939), new DateTime(2023, 9, 4, 4, 0, 50, 645, DateTimeKind.Utc).AddTicks(3686), new DateTime(2023, 8, 27, 14, 51, 52, 339, DateTimeKind.Utc).AddTicks(2453), new DateTime(2023, 8, 31, 10, 29, 18, 264, DateTimeKind.Utc).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 38, 9, 551, DateTimeKind.Utc).AddTicks(2634), new DateTime(2023, 4, 5, 11, 36, 45, 645, DateTimeKind.Utc).AddTicks(8109), new DateTime(2016, 11, 13, 6, 15, 19, 152, DateTimeKind.Utc).AddTicks(1919), new DateTime(2020, 9, 25, 2, 56, 53, 826, DateTimeKind.Utc).AddTicks(9448) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 7, 6, 9, 7, 643, DateTimeKind.Utc).AddTicks(1223), new DateTime(2023, 4, 3, 8, 33, 1, 413, DateTimeKind.Utc).AddTicks(8380), new DateTime(2022, 8, 31, 2, 19, 48, 747, DateTimeKind.Utc).AddTicks(2308), new DateTime(2023, 8, 16, 0, 42, 9, 963, DateTimeKind.Utc).AddTicks(9556) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 6, 30, 21, 58, 10, 332, DateTimeKind.Utc).AddTicks(1811), new DateTime(2023, 4, 6, 6, 51, 26, 401, DateTimeKind.Utc).AddTicks(8180), new DateTime(2023, 4, 1, 3, 53, 47, 582, DateTimeKind.Utc).AddTicks(8140), new DateTime(2023, 8, 2, 12, 23, 49, 65, DateTimeKind.Utc).AddTicks(3751) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 2, 8, 22, 27, 2, 480, DateTimeKind.Utc).AddTicks(9048), new DateTime(2021, 1, 26, 5, 24, 46, 732, DateTimeKind.Utc).AddTicks(3334), new DateTime(2019, 6, 22, 8, 44, 6, 566, DateTimeKind.Utc).AddTicks(7383), new DateTime(2022, 9, 30, 1, 38, 17, 705, DateTimeKind.Utc).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 18, 2, 47, 11, 955, DateTimeKind.Utc).AddTicks(9294), new DateTime(2023, 5, 3, 21, 7, 44, 500, DateTimeKind.Utc).AddTicks(7533), new DateTime(2022, 9, 23, 1, 0, 1, 345, DateTimeKind.Utc).AddTicks(3210), new DateTime(2023, 1, 9, 14, 25, 58, 418, DateTimeKind.Utc).AddTicks(9242) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2024, 3, 1, 19, 41, 40, 701, DateTimeKind.Utc).AddTicks(4301), new DateTime(2023, 5, 30, 11, 52, 47, 547, DateTimeKind.Utc).AddTicks(724), new DateTime(2019, 4, 4, 14, 23, 0, 632, DateTimeKind.Utc).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 9, 22, 22, 51, 3, 133, DateTimeKind.Utc).AddTicks(5865), new DateTime(2021, 9, 26, 16, 0, 41, 188, DateTimeKind.Utc).AddTicks(5500), new DateTime(2021, 4, 1, 6, 21, 32, 936, DateTimeKind.Utc).AddTicks(6439), new DateTime(2023, 5, 30, 11, 34, 35, 384, DateTimeKind.Utc).AddTicks(9382) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 18, 58, 22, 967, DateTimeKind.Utc).AddTicks(8947), new DateTime(2023, 7, 27, 19, 6, 12, 189, DateTimeKind.Utc).AddTicks(8519), new DateTime(2023, 7, 15, 13, 28, 23, 323, DateTimeKind.Utc).AddTicks(4453), new DateTime(2023, 8, 13, 19, 29, 39, 949, DateTimeKind.Utc).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 24, 22, 33, 20, 692, DateTimeKind.Utc).AddTicks(4970), new DateTime(2023, 6, 6, 9, 34, 37, 113, DateTimeKind.Utc).AddTicks(1564), new DateTime(2023, 1, 13, 9, 52, 35, 276, DateTimeKind.Utc).AddTicks(9411), new DateTime(2023, 3, 19, 5, 53, 30, 345, DateTimeKind.Utc).AddTicks(2551) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 17, 8, 17, 23, 646, DateTimeKind.Utc).AddTicks(2726), new DateTime(2023, 1, 30, 17, 38, 41, 53, DateTimeKind.Utc).AddTicks(2401), new DateTime(2022, 5, 24, 7, 26, 20, 263, DateTimeKind.Utc).AddTicks(8446), new DateTime(2023, 2, 28, 23, 37, 25, 121, DateTimeKind.Utc).AddTicks(9448) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 5, 15, 22, 13, 33, 378, DateTimeKind.Utc).AddTicks(6857), new DateTime(2020, 6, 22, 12, 45, 51, 596, DateTimeKind.Utc).AddTicks(5750), new DateTime(2017, 10, 10, 21, 51, 19, 666, DateTimeKind.Utc).AddTicks(3856), new DateTime(2018, 5, 30, 20, 34, 23, 438, DateTimeKind.Utc).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 8, 30, 8, 57, 3, 792, DateTimeKind.Utc).AddTicks(2678), new DateTime(2023, 7, 19, 1, 21, 13, 773, DateTimeKind.Utc).AddTicks(7955), new DateTime(2021, 5, 16, 3, 38, 51, 10, DateTimeKind.Utc).AddTicks(3570), new DateTime(2021, 10, 8, 1, 2, 32, 372, DateTimeKind.Utc).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 6, 40, 34, 335, DateTimeKind.Utc).AddTicks(8327), new DateTime(2023, 2, 21, 17, 21, 51, 84, DateTimeKind.Utc).AddTicks(1413), new DateTime(2022, 12, 13, 5, 43, 59, 103, DateTimeKind.Utc).AddTicks(7617), new DateTime(2023, 2, 6, 12, 36, 50, 556, DateTimeKind.Utc).AddTicks(6586) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 3, 13, 23, 42, 935, DateTimeKind.Utc).AddTicks(3556), new DateTime(2023, 7, 28, 9, 40, 31, 70, DateTimeKind.Utc).AddTicks(1481), new DateTime(2022, 12, 26, 22, 12, 15, 320, DateTimeKind.Utc).AddTicks(267), new DateTime(2023, 8, 2, 11, 8, 26, 695, DateTimeKind.Utc).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 8, 22, 16, 25, 40, 180, DateTimeKind.Utc).AddTicks(4038), new DateTime(2022, 5, 20, 19, 22, 6, 798, DateTimeKind.Utc).AddTicks(216), new DateTime(2021, 7, 2, 17, 7, 31, 275, DateTimeKind.Utc).AddTicks(3126), new DateTime(2022, 1, 24, 4, 55, 17, 936, DateTimeKind.Utc).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 6, 24, 16, 13, 7, 322, DateTimeKind.Utc).AddTicks(7905), new DateTime(2023, 8, 27, 21, 44, 36, 702, DateTimeKind.Utc).AddTicks(7481), new DateTime(2023, 6, 10, 16, 13, 32, 898, DateTimeKind.Utc).AddTicks(52), new DateTime(2023, 7, 24, 19, 53, 55, 887, DateTimeKind.Utc).AddTicks(6949) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 24, 2, 24, 59, 51, DateTimeKind.Utc).AddTicks(5076), new DateTime(2023, 8, 25, 14, 24, 38, 336, DateTimeKind.Utc).AddTicks(7738), new DateTime(2023, 8, 6, 19, 28, 2, 847, DateTimeKind.Utc).AddTicks(5295), new DateTime(2023, 8, 21, 20, 53, 57, 451, DateTimeKind.Utc).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 4, 1, 0, 31, 4, 715, DateTimeKind.Utc).AddTicks(1349), new DateTime(2020, 12, 10, 1, 35, 19, 114, DateTimeKind.Utc).AddTicks(8297), new DateTime(2019, 10, 7, 16, 5, 31, 632, DateTimeKind.Utc).AddTicks(5694), new DateTime(2023, 7, 26, 7, 42, 53, 885, DateTimeKind.Utc).AddTicks(5521) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 19, 3, 3, 750, DateTimeKind.Utc).AddTicks(6834), new DateTime(2023, 4, 15, 13, 3, 3, 959, DateTimeKind.Utc).AddTicks(7247), new DateTime(2022, 11, 12, 20, 35, 5, 670, DateTimeKind.Utc).AddTicks(5068), new DateTime(2023, 1, 15, 21, 13, 57, 668, DateTimeKind.Utc).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 1, 1, 8, 33, 16, 873, DateTimeKind.Utc).AddTicks(1734), new DateTime(2022, 8, 30, 15, 42, 37, 616, DateTimeKind.Utc).AddTicks(9018), new DateTime(2022, 8, 18, 17, 57, 57, 298, DateTimeKind.Utc).AddTicks(1430), new DateTime(2023, 1, 24, 15, 1, 11, 890, DateTimeKind.Utc).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 10, 22, 18, 11, 59, 789, DateTimeKind.Utc).AddTicks(4232), new DateTime(2019, 11, 13, 22, 43, 28, 895, DateTimeKind.Utc).AddTicks(3647), new DateTime(2017, 6, 27, 12, 34, 35, 169, DateTimeKind.Utc).AddTicks(3522), new DateTime(2018, 8, 7, 5, 28, 25, 796, DateTimeKind.Utc).AddTicks(3121) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 24, 23, 28, 23, 504, DateTimeKind.Utc).AddTicks(1536), new DateTime(2023, 7, 21, 11, 9, 27, 518, DateTimeKind.Utc).AddTicks(2206), new DateTime(2023, 6, 26, 21, 18, 53, 546, DateTimeKind.Utc).AddTicks(1390), new DateTime(2023, 7, 11, 15, 34, 38, 626, DateTimeKind.Utc).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 1, 22, 33, 246, DateTimeKind.Utc).AddTicks(4943), new DateTime(2022, 11, 22, 14, 35, 37, 529, DateTimeKind.Utc).AddTicks(7164), new DateTime(2022, 5, 9, 7, 42, 7, 627, DateTimeKind.Utc).AddTicks(9440), new DateTime(2023, 1, 5, 4, 19, 53, 590, DateTimeKind.Utc).AddTicks(1266) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 22, 28, 3, 252, DateTimeKind.Utc).AddTicks(4355), new DateTime(2020, 4, 29, 0, 22, 6, 263, DateTimeKind.Utc).AddTicks(1191), new DateTime(2019, 8, 28, 11, 45, 1, 461, DateTimeKind.Utc).AddTicks(3232), new DateTime(2020, 11, 29, 20, 41, 35, 811, DateTimeKind.Utc).AddTicks(8975) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 3, 18, 4, 40, 123, DateTimeKind.Utc).AddTicks(1014), new DateTime(2023, 8, 6, 8, 32, 57, 216, DateTimeKind.Utc).AddTicks(5290), new DateTime(2023, 4, 27, 23, 0, 12, 425, DateTimeKind.Utc).AddTicks(3576), new DateTime(2023, 8, 23, 14, 36, 2, 917, DateTimeKind.Utc).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 1, 18, 7, 604, DateTimeKind.Utc).AddTicks(6101), new DateTime(2022, 8, 14, 19, 19, 2, 970, DateTimeKind.Utc).AddTicks(1819), new DateTime(2022, 6, 15, 6, 37, 26, 446, DateTimeKind.Utc).AddTicks(222), new DateTime(2022, 10, 6, 4, 46, 0, 741, DateTimeKind.Utc).AddTicks(3558) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 7, 23, 17, 26, 722, DateTimeKind.Utc).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 22, 8, 17, 23, 173, DateTimeKind.Utc).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 2, 23, 55, 54, 476, DateTimeKind.Utc).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 6, 4, 4, 54, 309, DateTimeKind.Utc).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 30, 8, 28, 28, 211, DateTimeKind.Utc).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 10, 48, 39, 392, DateTimeKind.Utc).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 14, 24, 20, 495, DateTimeKind.Utc).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 14, 13, 49, 890, DateTimeKind.Utc).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 20, 5, 13, 7, 197, DateTimeKind.Utc).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 24, 18, 39, 7, 887, DateTimeKind.Utc).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 2, 40, 55, 398, DateTimeKind.Utc).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 15, 9, 10, 45, 497, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 29, 13, 14, 51, 594, DateTimeKind.Utc).AddTicks(5016));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 4, 21, 2, 57, 534, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 2, 5, 27, 16, 647, DateTimeKind.Utc).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 12, 15, 30, 41, 129, DateTimeKind.Utc).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 12, 1, 51, 17, 876, DateTimeKind.Utc).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 7, 1, 21, 52, 955, DateTimeKind.Utc).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 17, 2, 57, 24, 382, DateTimeKind.Utc).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 30, 2, 24, 38, 818, DateTimeKind.Utc).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 3, 23, 35, 45, 614, DateTimeKind.Utc).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 11, 43, 19, 184, DateTimeKind.Utc).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 2, 6, 51, 51, 385, DateTimeKind.Utc).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 21, 8, 35, 53, 459, DateTimeKind.Utc).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 9, 19, 31, 25, 679, DateTimeKind.Utc).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 20, 5, 43, 55, 907, DateTimeKind.Utc).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 30, 2, 4, 4, 343, DateTimeKind.Utc).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 12, 11, 18, 33, 37, DateTimeKind.Utc).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 5, 23, 16, 29, 469, DateTimeKind.Utc).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 3, 44, 29, 185, DateTimeKind.Utc).AddTicks(26));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 5, 15, 1, 37, 706, DateTimeKind.Utc).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 16, 11, 49, 24, DateTimeKind.Utc).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 14, 39, 19, 508, DateTimeKind.Utc).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 9, 14, 0, 934, DateTimeKind.Utc).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 31, 3, 29, 8, 573, DateTimeKind.Utc).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 6, 15, 32, 41, 712, DateTimeKind.Utc).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 59, 12, 163, DateTimeKind.Utc).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 10, 21, 0, 2, 984, DateTimeKind.Utc).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 7, 5, 38, 43, 323, DateTimeKind.Utc).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 15, 24, 54, 63, DateTimeKind.Utc).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 9, 21, 0, 7, 438, DateTimeKind.Utc).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 28, 10, 37, 45, 810, DateTimeKind.Utc).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 12, 20, 25, 783, DateTimeKind.Utc).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 22, 37, 1, 137, DateTimeKind.Utc).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 30, 1, 54, 27, 613, DateTimeKind.Utc).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 4, 12, 30, 59, 501, DateTimeKind.Utc).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 23, 10, 46, 6, 624, DateTimeKind.Utc).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 48L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 14, 7, 33, 6, 380, DateTimeKind.Utc).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 20, 15, 53, 32, 791, DateTimeKind.Utc).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 1, 20, 52, 42, 677, DateTimeKind.Utc).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 10, 6, 35, 47, 785, DateTimeKind.Utc).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 20, 13, 1, 11, 452, DateTimeKind.Utc).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 8, 52, 30, 71, DateTimeKind.Utc).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 12, 20, 47, 36, 121, DateTimeKind.Utc).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 21, 7, 14, 59, 277, DateTimeKind.Utc).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 56L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 5, 31, 18, 224, DateTimeKind.Utc).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 20, 8, 12, 11, 884, DateTimeKind.Utc).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 22, 25, 33, 827, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 17, 27, 49, 863, DateTimeKind.Utc).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 31, 12, 59, 54, 65, DateTimeKind.Utc).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 3, 15, 49, 2, 733, DateTimeKind.Utc).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 1, 32, 46, 446, DateTimeKind.Utc).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 31, 6, 36, 33, 491, DateTimeKind.Utc).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 64L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 35, 49, 726, DateTimeKind.Utc).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 23, 15, 30, 94, DateTimeKind.Utc).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 22, 13, 12, 33, 892, DateTimeKind.Utc).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 26, 9, 14, 38, 973, DateTimeKind.Utc).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 22, 6, 25, 53, 979, DateTimeKind.Utc).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 2, 21, 50, 11, 498, DateTimeKind.Utc).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 20, 15, 57, 35, 667, DateTimeKind.Utc).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 17, 4, 59, 7, 813, DateTimeKind.Utc).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 72L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 11, 19, 13, 47, 674, DateTimeKind.Utc).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 10, 3, 56, 48, 264, DateTimeKind.Utc).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 2, 47, 47, 560, DateTimeKind.Utc).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 17, 17, 27, 7, 151, DateTimeKind.Utc).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 18, 17, 50, 21, 404, DateTimeKind.Utc).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 31, 15, 27, 50, 734, DateTimeKind.Utc).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 29, 11, 46, 30, 447, DateTimeKind.Utc).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 4, 11, 22, 51, 975, DateTimeKind.Utc).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 80L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 1, 16, 48, 19, 669, DateTimeKind.Utc).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 14, 10, 47, 26, 704, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 14, 6, 51, 833, DateTimeKind.Utc).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 2, 23, 2, 15, 474, DateTimeKind.Utc).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 11, 1, 25, 10, 284, DateTimeKind.Utc).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 22, 4, 37, 23, 579, DateTimeKind.Utc).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 15, 23, 5, 56, 941, DateTimeKind.Utc).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 19, 44, 39, 635, DateTimeKind.Utc).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 88L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 19, 19, 33, 57, 234, DateTimeKind.Utc).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 6, 3, 33, 28, 374, DateTimeKind.Utc).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 9, 30, 1, 797, DateTimeKind.Utc).AddTicks(2173));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 12, 6, 59, 41, 375, DateTimeKind.Utc).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 12, 57, 12, 327, DateTimeKind.Utc).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 20, 18, 50, 37, 484, DateTimeKind.Utc).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 30, 13, 4, 5, 217, DateTimeKind.Utc).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 20, 20, 20, 0, 965, DateTimeKind.Utc).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 96L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 19, 10, 11, 48, 90, DateTimeKind.Utc).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 26, 0, 10, 8, 836, DateTimeKind.Utc).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 10, 40, 4, 999, DateTimeKind.Utc).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 22, 11, 42, 30, 195, DateTimeKind.Utc).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 7, 18, 3, 53, 590, DateTimeKind.Utc).AddTicks(1837));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 2, 11, 55, 54, 623, DateTimeKind.Utc).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 9, 7, 33, 0, 806, DateTimeKind.Utc).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 29, 0, 43, 26, 777, DateTimeKind.Utc).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 104L,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 12, 17, 51, 23, 858, DateTimeKind.Utc).AddTicks(1841));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 14, 15, 25, 49, 700, DateTimeKind.Utc).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedAt",
                value: new DateTime(2020, 3, 24, 4, 43, 55, 15, DateTimeKind.Utc).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 3, 55, 13, 645, DateTimeKind.Utc).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 12, 12, 123, DateTimeKind.Utc).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 12, 7, 31, 12, 464, DateTimeKind.Utc).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 0, 0, 7, 982, DateTimeKind.Utc).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedAt",
                value: new DateTime(2020, 3, 14, 16, 18, 12, 83, DateTimeKind.Utc).AddTicks(1762));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 112L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 21, 10, 35, 38, 533, DateTimeKind.Utc).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 11, 56, 13, 988, DateTimeKind.Utc).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 4, 8, 35, 2, 815, DateTimeKind.Utc).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 3, 19, 39, 18, 382, DateTimeKind.Utc).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 10, 46, 55, 832, DateTimeKind.Utc).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 4, 21, 18, 24, 631, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 5, 43, 45, 432, DateTimeKind.Utc).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 20, 13, 17, 255, DateTimeKind.Utc).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 120L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 19, 20, 37, 27, 284, DateTimeKind.Utc).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 14, 23, 24, 20, 810, DateTimeKind.Utc).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 26, 21, 6, 3, 300, DateTimeKind.Utc).AddTicks(1093));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 14, 14, 39, 12, 339, DateTimeKind.Utc).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 31, 7, 6, 53, 645, DateTimeKind.Utc).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 23, 2, 13, 23, 748, DateTimeKind.Utc).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 24, 7, 39, 32, 40, DateTimeKind.Utc).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 3, 3, 41, 354, DateTimeKind.Utc).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 128L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 13, 19, 58, 49, 942, DateTimeKind.Utc).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 16, 21, 28, 161, DateTimeKind.Utc).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 7, 2, 48, 7, 565, DateTimeKind.Utc).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 8, 32, 15, 272, DateTimeKind.Utc).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 4, 8, 44, 55, 398, DateTimeKind.Utc).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 28, 23, 29, 54, 244, DateTimeKind.Utc).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 6, 51, 31, 877, DateTimeKind.Utc).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 28, 8, 37, 4, 905, DateTimeKind.Utc).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 136L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 4, 23, 37, 3, 296, DateTimeKind.Utc).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 20, 2, 53, 16, 550, DateTimeKind.Utc).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 5, 19, 53, 13, 447, DateTimeKind.Utc).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 4, 9, 53, 45, 428, DateTimeKind.Utc).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 5, 12, 52, 21, 434, DateTimeKind.Utc).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 6, 1, 54, 43, 681, DateTimeKind.Utc).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 18, 7, 3, 47, 307, DateTimeKind.Utc).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 14, 17, 6, 30, 841, DateTimeKind.Utc).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 144L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 16, 38, 12, 109, DateTimeKind.Utc).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 26, 1, 31, 49, 826, DateTimeKind.Utc).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 10, 19, 4, 40, 922, DateTimeKind.Utc).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 13, 0, 51, 8, 43, DateTimeKind.Utc).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 7, 10, 23, 50, 189, DateTimeKind.Utc).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 13, 46, 18, 233, DateTimeKind.Utc).AddTicks(4508));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 7, 5, 52, 6, 955, DateTimeKind.Utc).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 23, 10, 41, 29, 851, DateTimeKind.Utc).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 152L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 29, 16, 22, 37, 147, DateTimeKind.Utc).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 26, 5, 57, 1, 563, DateTimeKind.Utc).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 19, 14, 16, 25, 950, DateTimeKind.Utc).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 23, 0, 19, 23, 789, DateTimeKind.Utc).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 1, 17, 9, 34, DateTimeKind.Utc).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 25, 16, 20, 1, 68, DateTimeKind.Utc).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 25, 3, 47, 4, 826, DateTimeKind.Utc).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 12, 22, 31, 40, 233, DateTimeKind.Utc).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 160L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 16, 5, 29, 33, 839, DateTimeKind.Utc).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 1, 2, 54, 20, 178, DateTimeKind.Utc).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedAt",
                value: new DateTime(2021, 12, 15, 16, 43, 38, 396, DateTimeKind.Utc).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedAt",
                value: new DateTime(2022, 1, 5, 18, 57, 42, 188, DateTimeKind.Utc).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 12, 2, 16, 32, 939, DateTimeKind.Utc).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 31, 4, 52, 49, 214, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 10, 30, 18, 967, DateTimeKind.Utc).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 18, 14, 30, 38, 436, DateTimeKind.Utc).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 168L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 2, 10, 14, 31, 648, DateTimeKind.Utc).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 12, 20, 6, 7, 460, DateTimeKind.Utc).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 13, 0, 15, 42, 957, DateTimeKind.Utc).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 11, 8, 47, 22, 256, DateTimeKind.Utc).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 22, 12, 46, 45, 254, DateTimeKind.Utc).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 22, 52, 7, 108, DateTimeKind.Utc).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 29, 22, 48, 50, 394, DateTimeKind.Utc).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 23, 6, 39, 34, 583, DateTimeKind.Utc).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 176L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 10, 16, 8, 52, 882, DateTimeKind.Utc).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 11, 41, 57, 934, DateTimeKind.Utc).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 18, 22, 44, 9, 131, DateTimeKind.Utc).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 24, 5, 57, 51, 642, DateTimeKind.Utc).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 3, 29, 57, 410, DateTimeKind.Utc).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 28, 17, 0, 22, 234, DateTimeKind.Utc).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 9, 14, 54, 310, DateTimeKind.Utc).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 22, 45, 37, 781, DateTimeKind.Utc).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 184L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 6, 15, 29, 15, 208, DateTimeKind.Utc).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 6, 44, 3, 79, DateTimeKind.Utc).AddTicks(142));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 10, 14, 47, 45, 486, DateTimeKind.Utc).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 16, 31, 36, 84, DateTimeKind.Utc).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 15, 7, 3, 33, 201, DateTimeKind.Utc).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 8, 39, 29, 980, DateTimeKind.Utc).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 28, 5, 12, 22, 853, DateTimeKind.Utc).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 16, 32, 51, 371, DateTimeKind.Utc).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 192L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 30, 28, 0, DateTimeKind.Utc).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 3, 19, 40, 46, 28, DateTimeKind.Utc).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 15, 8, 10, 7, 108, DateTimeKind.Utc).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 13, 22, 36, 32, 214, DateTimeKind.Utc).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 29, 23, 48, 48, 113, DateTimeKind.Utc).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 22, 1, 34, 10, 311, DateTimeKind.Utc).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 5, 4, 42, 31, 865, DateTimeKind.Utc).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 4, 17, 48, 292, DateTimeKind.Utc).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 200L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 3, 17, 56, 38, 204, DateTimeKind.Utc).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 8, 4, 27, 52, 883, DateTimeKind.Utc).AddTicks(6638), new DateTime(2023, 9, 5, 10, 39, 22, 691, DateTimeKind.Utc).AddTicks(6389) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 18, 28, 30, 349, DateTimeKind.Utc).AddTicks(2622), new DateTime(2023, 7, 25, 1, 55, 18, 605, DateTimeKind.Utc).AddTicks(8613) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 22, 14, 54, 11, 359, DateTimeKind.Utc).AddTicks(2615), new DateTime(2023, 9, 6, 16, 36, 46, 9, DateTimeKind.Utc).AddTicks(2378) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 10, 15, 17, 4, 3, 587, DateTimeKind.Utc).AddTicks(8258), new DateTime(2021, 6, 14, 21, 40, 47, 848, DateTimeKind.Utc).AddTicks(1965) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 29, 10, 29, 59, 344, DateTimeKind.Utc).AddTicks(9252), new DateTime(2023, 9, 1, 11, 17, 49, 716, DateTimeKind.Utc).AddTicks(3490) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 15, 12, 40, 38, 25, DateTimeKind.Utc).AddTicks(2114), new DateTime(2023, 1, 19, 18, 53, 32, 800, DateTimeKind.Utc).AddTicks(9191) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 21, 18, 5, 48, 897, DateTimeKind.Utc).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 26, 50, 395, DateTimeKind.Utc).AddTicks(5212), new DateTime(2023, 9, 6, 22, 44, 41, 427, DateTimeKind.Utc).AddTicks(6332) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 9, 21, 46, 56, 881, DateTimeKind.Utc).AddTicks(2042), new DateTime(2023, 7, 18, 2, 35, 38, 687, DateTimeKind.Utc).AddTicks(2539) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 9, 6, 57, 27, 70, DateTimeKind.Utc).AddTicks(4866), new DateTime(2023, 7, 3, 23, 17, 50, 565, DateTimeKind.Utc).AddTicks(1457) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 7, 54, 42, 536, DateTimeKind.Utc).AddTicks(2730), new DateTime(2023, 6, 2, 8, 57, 27, 291, DateTimeKind.Utc).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 31, 23, 20, 49, 404, DateTimeKind.Utc).AddTicks(5587), new DateTime(2023, 9, 4, 5, 24, 47, 753, DateTimeKind.Utc).AddTicks(7955) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 5, 1, 20, 19, 32, 952, DateTimeKind.Utc).AddTicks(2290), new DateTime(2023, 6, 28, 0, 3, 11, 972, DateTimeKind.Utc).AddTicks(2152) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 2, 10, 20, 35, 112, DateTimeKind.Utc).AddTicks(1525), new DateTime(2023, 8, 26, 19, 20, 22, 478, DateTimeKind.Utc).AddTicks(3982) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 4, 12, 53, 6, 694, DateTimeKind.Utc).AddTicks(5903), new DateTime(2023, 4, 18, 19, 16, 31, 222, DateTimeKind.Utc).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 11, 20, 2, 52, 92, DateTimeKind.Utc).AddTicks(7163), new DateTime(2023, 8, 13, 21, 14, 30, 872, DateTimeKind.Utc).AddTicks(7462) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 1, 6, 55, 48, 316, DateTimeKind.Utc).AddTicks(7947), new DateTime(2023, 5, 16, 6, 41, 31, 892, DateTimeKind.Utc).AddTicks(4849) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 3, 11, 15, 58, 29, 899, DateTimeKind.Utc).AddTicks(3913), new DateTime(2022, 7, 7, 13, 2, 42, 330, DateTimeKind.Utc).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 4, 22, 15, 13, 581, DateTimeKind.Utc).AddTicks(918), new DateTime(2023, 8, 29, 14, 23, 51, 380, DateTimeKind.Utc).AddTicks(6992) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 3, 18, 58, 21, 663, DateTimeKind.Utc).AddTicks(828), new DateTime(2023, 8, 30, 9, 28, 44, 630, DateTimeKind.Utc).AddTicks(9576) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 26, 10, 48, 37, 959, DateTimeKind.Utc).AddTicks(4505), new DateTime(2023, 8, 27, 18, 13, 58, 701, DateTimeKind.Utc).AddTicks(6474) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 16, 9, 15, 29, 486, DateTimeKind.Utc).AddTicks(7862), new DateTime(2023, 8, 25, 10, 41, 6, 851, DateTimeKind.Utc).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 9, 9, 38, 38, 706, DateTimeKind.Utc).AddTicks(3830), new DateTime(2023, 7, 25, 5, 20, 8, 188, DateTimeKind.Utc).AddTicks(4212) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 11, 37, 586, DateTimeKind.Utc).AddTicks(5599), new DateTime(2023, 9, 7, 7, 58, 5, 183, DateTimeKind.Utc).AddTicks(3073) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 4, 13, 36, 8, 320, DateTimeKind.Utc).AddTicks(9123), new DateTime(2023, 5, 18, 5, 17, 36, 190, DateTimeKind.Utc).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 7, 9, 21, 24, 271, DateTimeKind.Utc).AddTicks(6683), new DateTime(2023, 8, 13, 17, 36, 24, 841, DateTimeKind.Utc).AddTicks(5153) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 26, 4, 39, 52, 73, DateTimeKind.Utc).AddTicks(1003), new DateTime(2023, 8, 27, 1, 19, 54, 284, DateTimeKind.Utc).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 26, 2, 6, 27, 818, DateTimeKind.Utc).AddTicks(2088), new DateTime(2023, 6, 27, 9, 25, 3, 476, DateTimeKind.Utc).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 6, 8, 25, 40, 601, DateTimeKind.Utc).AddTicks(7021), new DateTime(2023, 8, 14, 5, 3, 33, 605, DateTimeKind.Utc).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 3, 3, 38, 23, 698, DateTimeKind.Utc).AddTicks(258), new DateTime(2023, 9, 4, 2, 16, 51, 262, DateTimeKind.Utc).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 10, 22, 16, 40, 30, 131, DateTimeKind.Utc).AddTicks(4556), new DateTime(2021, 6, 1, 1, 47, 44, 646, DateTimeKind.Utc).AddTicks(7063) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 4, 15, 18, 48, 42, 942, DateTimeKind.Utc).AddTicks(839), new DateTime(2021, 5, 29, 21, 5, 52, 322, DateTimeKind.Utc).AddTicks(8107) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 9, 6, 27, 41, 4, DateTimeKind.Utc).AddTicks(6548), new DateTime(2023, 8, 21, 20, 2, 54, 854, DateTimeKind.Utc).AddTicks(9118) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 7, 11, 14, 16, 38, 477, DateTimeKind.Utc).AddTicks(2209), new DateTime(2023, 4, 11, 18, 6, 56, 582, DateTimeKind.Utc).AddTicks(5571) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 24, 15, 28, 18, 843, DateTimeKind.Utc).AddTicks(8424), new DateTime(2023, 8, 10, 23, 4, 6, 449, DateTimeKind.Utc).AddTicks(4243) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 2, 7, 4, 52, 914, DateTimeKind.Utc).AddTicks(2238), new DateTime(2023, 9, 5, 11, 40, 23, 49, DateTimeKind.Utc).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 15, 13, 55, 17, 753, DateTimeKind.Utc).AddTicks(4904), new DateTime(2023, 6, 19, 18, 39, 58, 463, DateTimeKind.Utc).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 17, 12, 46, 37, 31, DateTimeKind.Utc).AddTicks(7301), new DateTime(2023, 8, 9, 19, 53, 0, 990, DateTimeKind.Utc).AddTicks(5845) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 2, 3, 11, 15, 15, 373, DateTimeKind.Utc).AddTicks(7339), new DateTime(2022, 1, 2, 11, 16, 22, 725, DateTimeKind.Utc).AddTicks(9297) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 13, 10, 2, 48, 525, DateTimeKind.Utc).AddTicks(1850), new DateTime(2023, 7, 24, 8, 15, 35, 521, DateTimeKind.Utc).AddTicks(5612) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 1, 5, 31, 31, 275, DateTimeKind.Utc).AddTicks(809), new DateTime(2023, 4, 26, 5, 34, 49, 927, DateTimeKind.Utc).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 8, 9, 23, 25, 92, DateTimeKind.Utc).AddTicks(1235), new DateTime(2023, 5, 4, 15, 12, 38, 706, DateTimeKind.Utc).AddTicks(9051) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 25, 10, 1, 58, 755, DateTimeKind.Utc).AddTicks(3332), new DateTime(2023, 9, 5, 22, 39, 33, 456, DateTimeKind.Utc).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 27, 44, 343, DateTimeKind.Utc).AddTicks(4845), new DateTime(2023, 7, 25, 1, 31, 9, 288, DateTimeKind.Utc).AddTicks(2658) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 29, 13, 57, 34, 432, DateTimeKind.Utc).AddTicks(9030), new DateTime(2023, 7, 19, 3, 22, 23, 770, DateTimeKind.Utc).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 2, 19, 3, 36, 523, DateTimeKind.Utc).AddTicks(9426), new DateTime(2023, 8, 21, 13, 45, 12, 907, DateTimeKind.Utc).AddTicks(999) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 9, 4, 10, 54, 54, 744, DateTimeKind.Utc).AddTicks(3848), new DateTime(2022, 8, 21, 11, 53, 5, 686, DateTimeKind.Utc).AddTicks(763) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 11, 5, 19, 56, 333, DateTimeKind.Utc).AddTicks(9832), new DateTime(2023, 9, 5, 6, 41, 44, 782, DateTimeKind.Utc).AddTicks(9698) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 9, 0, 6, 23, 636, DateTimeKind.Utc).AddTicks(5338), new DateTime(2023, 7, 26, 0, 56, 20, 365, DateTimeKind.Utc).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 10, 12, 10, 31, 448, DateTimeKind.Utc).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 28, 2, 41, 49, 582, DateTimeKind.Utc).AddTicks(7314), new DateTime(2023, 7, 20, 5, 51, 11, 760, DateTimeKind.Utc).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 14, 42, 0, 77, DateTimeKind.Utc).AddTicks(9744), new DateTime(2023, 9, 4, 0, 53, 37, 116, DateTimeKind.Utc).AddTicks(7179) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 8, 16, 15, 47, 59, 948, DateTimeKind.Utc).AddTicks(9205), new DateTime(2023, 3, 19, 17, 10, 44, 32, DateTimeKind.Utc).AddTicks(4744) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 18, 3, 13, 0, 255, DateTimeKind.Utc).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 25, 13, 33, 37, 643, DateTimeKind.Utc).AddTicks(4844), new DateTime(2023, 7, 30, 5, 41, 30, 400, DateTimeKind.Utc).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 6, 8, 24, 26, 425, DateTimeKind.Utc).AddTicks(7822), new DateTime(2023, 5, 24, 16, 8, 53, 8, DateTimeKind.Utc).AddTicks(927) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 17, 8, 19, 19, 559, DateTimeKind.Utc).AddTicks(5095), new DateTime(2023, 7, 19, 4, 50, 49, 396, DateTimeKind.Utc).AddTicks(962) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 5, 22, 25, 11, 96, DateTimeKind.Utc).AddTicks(7229), new DateTime(2023, 9, 6, 10, 25, 16, 978, DateTimeKind.Utc).AddTicks(1333) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 4, 10, 14, 46, 337, DateTimeKind.Utc).AddTicks(7802));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 1, 10, 30, 58, 969, DateTimeKind.Utc).AddTicks(7063), new DateTime(2023, 8, 7, 1, 15, 58, 796, DateTimeKind.Utc).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 6, 8, 51, 49, 721, DateTimeKind.Utc).AddTicks(1240), new DateTime(2023, 7, 13, 8, 51, 28, 178, DateTimeKind.Utc).AddTicks(908) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 18, 9, 13, 8, 805, DateTimeKind.Utc).AddTicks(699), new DateTime(2023, 8, 30, 1, 21, 57, 637, DateTimeKind.Utc).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 31, 16, 0, 17, 942, DateTimeKind.Utc).AddTicks(2110), new DateTime(2023, 8, 4, 1, 4, 4, 984, DateTimeKind.Utc).AddTicks(6012) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 30, 12, 27, 9, 69, DateTimeKind.Utc).AddTicks(2412), new DateTime(2023, 7, 28, 15, 35, 19, 108, DateTimeKind.Utc).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 6, 5, 0, 18, 19, 8, DateTimeKind.Utc).AddTicks(3355), new DateTime(2021, 8, 10, 7, 13, 56, 948, DateTimeKind.Utc).AddTicks(4822) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 22, 13, 45, 34, 748, DateTimeKind.Utc).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 7, 22, 2, 1, 448, DateTimeKind.Utc).AddTicks(2922), new DateTime(2023, 8, 18, 8, 56, 57, 70, DateTimeKind.Utc).AddTicks(6124) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 27, 18, 51, 12, 806, DateTimeKind.Utc).AddTicks(7306), new DateTime(2023, 8, 2, 3, 38, 14, 286, DateTimeKind.Utc).AddTicks(3645) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 25, 12, 51, 12, 787, DateTimeKind.Utc).AddTicks(7800), new DateTime(2023, 8, 17, 4, 53, 11, 523, DateTimeKind.Utc).AddTicks(2073) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 13, 11, 1, 13, 569, DateTimeKind.Utc).AddTicks(1261), new DateTime(2023, 1, 10, 7, 0, 50, 418, DateTimeKind.Utc).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 19, 0, 26, 35, 873, DateTimeKind.Utc).AddTicks(1367), new DateTime(2023, 8, 26, 15, 56, 30, 60, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 12, 13, 54, 9, 950, DateTimeKind.Utc).AddTicks(3744), new DateTime(2023, 1, 3, 6, 30, 35, 481, DateTimeKind.Utc).AddTicks(1627) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 10, 23, 20, 39, 18, 755, DateTimeKind.Utc).AddTicks(2560), new DateTime(2022, 12, 4, 4, 2, 31, 276, DateTimeKind.Utc).AddTicks(7230) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 1, 55, 829, DateTimeKind.Utc).AddTicks(3220), new DateTime(2023, 8, 28, 8, 10, 39, 43, DateTimeKind.Utc).AddTicks(5005) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 18, 12, 54, 28, 382, DateTimeKind.Utc).AddTicks(6712), new DateTime(2023, 7, 7, 11, 9, 21, 532, DateTimeKind.Utc).AddTicks(1464) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 21, 18, 29, 613, DateTimeKind.Utc).AddTicks(1589), new DateTime(2023, 6, 26, 17, 26, 20, 56, DateTimeKind.Utc).AddTicks(2065) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 10, 2, 25, 51, 996, DateTimeKind.Utc).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 30, 12, 56, 12, 515, DateTimeKind.Utc).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 31, 12, 16, 17, 595, DateTimeKind.Utc).AddTicks(8700), new DateTime(2023, 9, 3, 2, 42, 10, 685, DateTimeKind.Utc).AddTicks(1480) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 48, 46, 741, DateTimeKind.Utc).AddTicks(8357), new DateTime(2023, 8, 20, 20, 1, 53, 754, DateTimeKind.Utc).AddTicks(7183) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 31, 14, 0, 31, 97, DateTimeKind.Utc).AddTicks(8476), new DateTime(2023, 6, 23, 12, 50, 43, 940, DateTimeKind.Utc).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 4, 3, 7, 43, 109, DateTimeKind.Utc).AddTicks(1726), new DateTime(2023, 9, 4, 7, 55, 32, 947, DateTimeKind.Utc).AddTicks(1677) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 20, 21, 27, 42, 382, DateTimeKind.Utc).AddTicks(8147), new DateTime(2023, 6, 17, 11, 12, 29, 131, DateTimeKind.Utc).AddTicks(7393) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 21, 7, 47, 16, 715, DateTimeKind.Utc).AddTicks(6410), new DateTime(2023, 7, 26, 20, 2, 57, 372, DateTimeKind.Utc).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 3, 14, 50, 18, 881, DateTimeKind.Utc).AddTicks(801), new DateTime(2023, 9, 6, 23, 30, 54, 302, DateTimeKind.Utc).AddTicks(9957) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 18, 53, 55, 251, DateTimeKind.Utc).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 24, 0, 27, 32, 358, DateTimeKind.Utc).AddTicks(1491), new DateTime(2023, 8, 6, 4, 46, 58, 966, DateTimeKind.Utc).AddTicks(9494) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 2, 11, 43, 8, 885, DateTimeKind.Utc).AddTicks(3529), new DateTime(2023, 9, 4, 7, 24, 53, 483, DateTimeKind.Utc).AddTicks(3523) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 15, 22, 33, 17, 554, DateTimeKind.Utc).AddTicks(8619), new DateTime(2023, 8, 12, 19, 49, 48, 36, DateTimeKind.Utc).AddTicks(6456) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 25, 5, 52, 56, 883, DateTimeKind.Utc).AddTicks(1519), new DateTime(2023, 9, 2, 6, 21, 58, 548, DateTimeKind.Utc).AddTicks(3818) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 8, 20, 23, 53, 145, DateTimeKind.Utc).AddTicks(5022), new DateTime(2023, 6, 14, 1, 35, 0, 263, DateTimeKind.Utc).AddTicks(6112) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 15, 1, 18, 39, 633, DateTimeKind.Utc).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 49, 58, 808, DateTimeKind.Utc).AddTicks(1508), new DateTime(2023, 9, 5, 5, 41, 5, 359, DateTimeKind.Utc).AddTicks(8212) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 27, 12, 25, 14, 778, DateTimeKind.Utc).AddTicks(5335), new DateTime(2023, 8, 17, 21, 8, 3, 750, DateTimeKind.Utc).AddTicks(1099) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 29, 1, 7, 6, 730, DateTimeKind.Utc).AddTicks(2802), new DateTime(2023, 8, 14, 22, 33, 59, 104, DateTimeKind.Utc).AddTicks(3474) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 8, 18, 12, 46, 16, 949, DateTimeKind.Utc).AddTicks(2029), new DateTime(2023, 5, 8, 0, 30, 59, 499, DateTimeKind.Utc).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 16, 18, 23, 44, 363, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 13, 18, 59, 54, 571, DateTimeKind.Utc).AddTicks(2140), new DateTime(2023, 8, 14, 5, 14, 59, 894, DateTimeKind.Utc).AddTicks(9342) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 6, 19, 51, 52, 750, DateTimeKind.Utc).AddTicks(7185), new DateTime(2023, 5, 5, 19, 33, 59, 614, DateTimeKind.Utc).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 23, 10, 14, 43, 454, DateTimeKind.Utc).AddTicks(7684), new DateTime(2023, 8, 18, 6, 5, 25, 480, DateTimeKind.Utc).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 2, 12, 52, 42, 793, DateTimeKind.Utc).AddTicks(3328), new DateTime(2023, 9, 5, 2, 41, 53, 406, DateTimeKind.Utc).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 7, 11, 18, 38, 42, 466, DateTimeKind.Utc).AddTicks(1388), new DateTime(2022, 5, 10, 0, 22, 2, 650, DateTimeKind.Utc).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 5, 11, 3, 55, 328, DateTimeKind.Utc).AddTicks(3485), new DateTime(2023, 9, 2, 13, 55, 26, 851, DateTimeKind.Utc).AddTicks(6952) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 29, 2, 5, 44, 493, DateTimeKind.Utc).AddTicks(4189), new DateTime(2023, 8, 19, 13, 0, 49, 635, DateTimeKind.Utc).AddTicks(8179) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 58, 20, 297, DateTimeKind.Utc).AddTicks(1369), new DateTime(2023, 9, 7, 2, 53, 31, 906, DateTimeKind.Utc).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 18, 4, 3, 3, 90, DateTimeKind.Utc).AddTicks(7311), new DateTime(2023, 6, 8, 5, 58, 34, 579, DateTimeKind.Utc).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 29, 1, 12, 27, 333, DateTimeKind.Utc).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 5, 16, 4, 32, 726, DateTimeKind.Utc).AddTicks(8957), new DateTime(2023, 9, 6, 17, 42, 17, 821, DateTimeKind.Utc).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 18, 13, 16, 3, 326, DateTimeKind.Utc).AddTicks(6794), new DateTime(2023, 7, 16, 11, 3, 46, 247, DateTimeKind.Utc).AddTicks(2309) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 28, 18, 50, 2, 648, DateTimeKind.Utc).AddTicks(611), new DateTime(2023, 8, 18, 8, 50, 13, 649, DateTimeKind.Utc).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 4, 13, 0, 53, 830, DateTimeKind.Utc).AddTicks(9879));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 1, 8, 2, 19, 722, DateTimeKind.Utc).AddTicks(4506), new DateTime(2023, 7, 8, 1, 54, 9, 880, DateTimeKind.Utc).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 13, 12, 13, 32, 564, DateTimeKind.Utc).AddTicks(7458), new DateTime(2023, 8, 15, 17, 7, 25, 485, DateTimeKind.Utc).AddTicks(918) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 29, 1, 42, 52, 802, DateTimeKind.Utc).AddTicks(8306), new DateTime(2023, 9, 1, 3, 10, 7, 256, DateTimeKind.Utc).AddTicks(6208) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 10, 18, 1, 49, 57, 473, DateTimeKind.Utc).AddTicks(4033), new DateTime(2023, 4, 19, 19, 36, 19, 843, DateTimeKind.Utc).AddTicks(6681) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 5, 6, 32, 1, 957, DateTimeKind.Utc).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 10, 3, 17, 29, 45, 888, DateTimeKind.Utc).AddTicks(5761), new DateTime(2022, 12, 27, 17, 19, 6, 258, DateTimeKind.Utc).AddTicks(7491) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 2, 20, 33, 10, 239, DateTimeKind.Utc).AddTicks(6296), new DateTime(2023, 9, 3, 9, 54, 8, 363, DateTimeKind.Utc).AddTicks(1641) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 28, 8, 1, 10, 775, DateTimeKind.Utc).AddTicks(5251), new DateTime(2023, 9, 5, 14, 56, 54, 915, DateTimeKind.Utc).AddTicks(6527) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 18, 18, 44, 40, 602, DateTimeKind.Utc).AddTicks(2187), new DateTime(2023, 8, 23, 20, 12, 42, 321, DateTimeKind.Utc).AddTicks(8006) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 20, 15, 17, 55, 335, DateTimeKind.Utc).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 18, 2, 43, 45, 204, DateTimeKind.Utc).AddTicks(9752), new DateTime(2023, 8, 31, 21, 54, 20, 711, DateTimeKind.Utc).AddTicks(4709) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 4, 6, 29, 37, 313, DateTimeKind.Utc).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 20, 11, 19, 6, 510, DateTimeKind.Utc).AddTicks(6361), new DateTime(2023, 4, 22, 17, 22, 38, 500, DateTimeKind.Utc).AddTicks(5183) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 1, 40, 34, 660, DateTimeKind.Utc).AddTicks(9276), new DateTime(2023, 7, 9, 17, 17, 57, 818, DateTimeKind.Utc).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 28, 18, 57, 43, 391, DateTimeKind.Utc).AddTicks(4474), new DateTime(2023, 5, 16, 19, 3, 2, 911, DateTimeKind.Utc).AddTicks(4902) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 6, 10, 40, 11, 870, DateTimeKind.Utc).AddTicks(1915), new DateTime(2023, 8, 30, 16, 28, 29, 61, DateTimeKind.Utc).AddTicks(693) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 1, 9, 54, 53, 364, DateTimeKind.Utc).AddTicks(2966), new DateTime(2023, 8, 10, 16, 7, 56, 847, DateTimeKind.Utc).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 18, 18, 8, 898, DateTimeKind.Utc).AddTicks(2044), new DateTime(2023, 6, 7, 17, 12, 58, 644, DateTimeKind.Utc).AddTicks(1361) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 3, 13, 45, 40, 675, DateTimeKind.Utc).AddTicks(1141), new DateTime(2023, 7, 4, 8, 39, 38, 342, DateTimeKind.Utc).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 11, 22, 21, 48, 546, DateTimeKind.Utc).AddTicks(952), new DateTime(2023, 8, 19, 0, 27, 33, 77, DateTimeKind.Utc).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 6, 8, 15, 28, 32, 27, DateTimeKind.Utc).AddTicks(9298), new DateTime(2022, 11, 29, 8, 5, 24, 993, DateTimeKind.Utc).AddTicks(3732) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 25, 20, 4, 25, 217, DateTimeKind.Utc).AddTicks(170), new DateTime(2023, 9, 5, 10, 27, 41, 555, DateTimeKind.Utc).AddTicks(2734) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 8, 44, 28, 721, DateTimeKind.Utc).AddTicks(6155), new DateTime(2023, 8, 1, 13, 20, 50, 175, DateTimeKind.Utc).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 1, 13, 8, 55, 48, 952, DateTimeKind.Utc).AddTicks(3298), new DateTime(2022, 10, 14, 9, 37, 51, 193, DateTimeKind.Utc).AddTicks(3537) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 26, 15, 54, 19, 299, DateTimeKind.Utc).AddTicks(9740), new DateTime(2023, 6, 5, 15, 30, 32, 76, DateTimeKind.Utc).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 2, 6, 26, 47, 71, DateTimeKind.Utc).AddTicks(1989), new DateTime(2023, 9, 4, 3, 11, 53, 485, DateTimeKind.Utc).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 6, 11, 1, 0, 717, DateTimeKind.Utc).AddTicks(2312), new DateTime(2023, 9, 6, 16, 54, 31, 744, DateTimeKind.Utc).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 3, 2, 10, 27, 74, DateTimeKind.Utc).AddTicks(5576), new DateTime(2023, 8, 16, 6, 9, 30, 633, DateTimeKind.Utc).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 24, 22, 24, 15, 500, DateTimeKind.Utc).AddTicks(8393), new DateTime(2023, 7, 10, 19, 44, 45, 342, DateTimeKind.Utc).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 26, 5, 57, 39, 164, DateTimeKind.Utc).AddTicks(2964), new DateTime(2023, 7, 28, 0, 7, 48, 557, DateTimeKind.Utc).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 3, 6, 4, 53, 474, DateTimeKind.Utc).AddTicks(8853), new DateTime(2023, 8, 27, 16, 0, 16, 380, DateTimeKind.Utc).AddTicks(6408) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 4, 44, 48, 859, DateTimeKind.Utc).AddTicks(5805), new DateTime(2023, 8, 12, 10, 4, 48, 782, DateTimeKind.Utc).AddTicks(1609) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 12, 9, 55, 10, 900, DateTimeKind.Utc).AddTicks(9216), new DateTime(2023, 7, 29, 1, 37, 49, 769, DateTimeKind.Utc).AddTicks(2918) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 18, 39, 874, DateTimeKind.Utc).AddTicks(3529), new DateTime(2023, 8, 19, 18, 34, 2, 995, DateTimeKind.Utc).AddTicks(5546) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 6, 4, 12, 2, 35, 899, DateTimeKind.Utc).AddTicks(3663), new DateTime(2023, 5, 20, 11, 54, 43, 787, DateTimeKind.Utc).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 21, 30, 57, 76, DateTimeKind.Utc).AddTicks(163), new DateTime(2022, 6, 30, 14, 11, 29, 434, DateTimeKind.Utc).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 25, 4, 1, 27, 455, DateTimeKind.Utc).AddTicks(6462), new DateTime(2023, 8, 29, 17, 31, 33, 693, DateTimeKind.Utc).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 28, 22, 46, 58, 319, DateTimeKind.Utc).AddTicks(1536), new DateTime(2023, 8, 31, 21, 49, 57, 108, DateTimeKind.Utc).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 3, 3, 15, 34, 25, 576, DateTimeKind.Utc).AddTicks(5625), new DateTime(2023, 4, 23, 5, 22, 0, 823, DateTimeKind.Utc).AddTicks(4414) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 18, 13, 51, 47, 667, DateTimeKind.Utc).AddTicks(2559), new DateTime(2023, 7, 29, 6, 0, 53, 232, DateTimeKind.Utc).AddTicks(5447) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 3, 18, 0, 34, 368, DateTimeKind.Utc).AddTicks(2431), new DateTime(2023, 9, 4, 2, 16, 43, 719, DateTimeKind.Utc).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 8, 18, 461, DateTimeKind.Utc).AddTicks(1830), new DateTime(2023, 9, 2, 0, 8, 9, 159, DateTimeKind.Utc).AddTicks(8406) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 1, 3, 50, 44, 386, DateTimeKind.Utc).AddTicks(9994), new DateTime(2022, 11, 2, 2, 1, 30, 688, DateTimeKind.Utc).AddTicks(6597) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 3, 58, 36, 877, DateTimeKind.Utc).AddTicks(8247), new DateTime(2023, 6, 13, 13, 9, 21, 102, DateTimeKind.Utc).AddTicks(2716) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 3, 30, 23, 47, 14, 752, DateTimeKind.Utc).AddTicks(2348), new DateTime(2022, 10, 19, 11, 8, 41, 273, DateTimeKind.Utc).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2019, 9, 19, 10, 14, 55, 897, DateTimeKind.Utc).AddTicks(252), new DateTime(2021, 7, 5, 20, 57, 47, 190, DateTimeKind.Utc).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 10, 12, 12, 32, 36, 167, DateTimeKind.Utc).AddTicks(44), new DateTime(2022, 12, 24, 19, 34, 41, 404, DateTimeKind.Utc).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 3, 0, 40, 3, 488, DateTimeKind.Utc).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 9, 15, 34, 49, 749, DateTimeKind.Utc).AddTicks(8746), new DateTime(2023, 6, 23, 8, 23, 28, 698, DateTimeKind.Utc).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 5, 14, 17, 28, 58, 215, DateTimeKind.Utc).AddTicks(3668), new DateTime(2023, 2, 4, 21, 19, 12, 718, DateTimeKind.Utc).AddTicks(516) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 162L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 11, 24, 14, 18, 36, 629, DateTimeKind.Utc).AddTicks(5033), new DateTime(2022, 10, 16, 15, 40, 30, 364, DateTimeKind.Utc).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 163L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 23, 16, 28, 53, 322, DateTimeKind.Utc).AddTicks(4649), new DateTime(2023, 7, 3, 23, 3, 20, 156, DateTimeKind.Utc).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 164L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 3, 6, 58, 17, 721, DateTimeKind.Utc).AddTicks(7814), new DateTime(2023, 9, 6, 0, 52, 48, 321, DateTimeKind.Utc).AddTicks(6608) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 165L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 4, 20, 17, 12, 23, 623, DateTimeKind.Utc).AddTicks(4070), new DateTime(2020, 11, 15, 3, 56, 57, 448, DateTimeKind.Utc).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 28, 3, 25, 12, 325, DateTimeKind.Utc).AddTicks(1154), new DateTime(2023, 9, 4, 11, 36, 52, 41, DateTimeKind.Utc).AddTicks(1446) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 4, 8, 8, 2, 40, 875, DateTimeKind.Utc).AddTicks(2075), new DateTime(2022, 10, 4, 18, 30, 21, 392, DateTimeKind.Utc).AddTicks(4021) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 7, 30, 7, 55, 4, 235, DateTimeKind.Utc).AddTicks(6900), new DateTime(2023, 4, 1, 13, 15, 49, 822, DateTimeKind.Utc).AddTicks(3853) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 56, 23, 63, DateTimeKind.Utc).AddTicks(3437), new DateTime(2023, 9, 4, 7, 36, 20, 766, DateTimeKind.Utc).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 8, 8, 19, 54, 16, 816, DateTimeKind.Utc).AddTicks(4463), new DateTime(2023, 4, 26, 1, 27, 2, 903, DateTimeKind.Utc).AddTicks(6871) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 6, 16, 48, 27, 65, DateTimeKind.Utc).AddTicks(2171), new DateTime(2023, 8, 5, 7, 26, 18, 75, DateTimeKind.Utc).AddTicks(1282) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 17, 8, 12, 49, 738, DateTimeKind.Utc).AddTicks(29), new DateTime(2023, 8, 22, 11, 54, 43, 262, DateTimeKind.Utc).AddTicks(5665) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 9, 11, 20, 26, 1, 65, DateTimeKind.Utc).AddTicks(7150), new DateTime(2022, 11, 14, 3, 45, 21, 875, DateTimeKind.Utc).AddTicks(9109) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 11, 6, 46, 51, 237, DateTimeKind.Utc).AddTicks(1338), new DateTime(2023, 8, 8, 12, 8, 24, 257, DateTimeKind.Utc).AddTicks(6258) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 3, 21, 17, 1, 10, 71, DateTimeKind.Utc).AddTicks(1740), new DateTime(2023, 4, 12, 11, 23, 12, 488, DateTimeKind.Utc).AddTicks(2745) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 1, 16, 26, 96, DateTimeKind.Utc).AddTicks(1020), new DateTime(2023, 9, 2, 8, 33, 50, 345, DateTimeKind.Utc).AddTicks(4887) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 4, 12, 20, 21, 209, DateTimeKind.Utc).AddTicks(9402), new DateTime(2023, 9, 5, 22, 44, 41, 171, DateTimeKind.Utc).AddTicks(6577) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 31, 32, 52, DateTimeKind.Utc).AddTicks(3097), new DateTime(2023, 6, 25, 17, 3, 52, 375, DateTimeKind.Utc).AddTicks(9307) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 2, 7, 4, 15, 821, DateTimeKind.Utc).AddTicks(6177), new DateTime(2023, 9, 3, 8, 4, 48, 768, DateTimeKind.Utc).AddTicks(163) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2019, 12, 3, 1, 29, 40, 377, DateTimeKind.Utc).AddTicks(84), new DateTime(2021, 1, 28, 9, 43, 29, 261, DateTimeKind.Utc).AddTicks(1768) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 2, 23, 24, 18, 818, DateTimeKind.Utc).AddTicks(2974), new DateTime(2023, 6, 8, 21, 38, 34, 31, DateTimeKind.Utc).AddTicks(5018) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 6, 45, 51, 369, DateTimeKind.Utc).AddTicks(1618), new DateTime(2023, 7, 31, 16, 11, 18, 579, DateTimeKind.Utc).AddTicks(3659) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 26, 9, 205, DateTimeKind.Utc).AddTicks(8093), new DateTime(2023, 7, 15, 8, 37, 21, 732, DateTimeKind.Utc).AddTicks(8463) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 21, 3, 52, 55, 258, DateTimeKind.Utc).AddTicks(5839), new DateTime(2023, 8, 26, 15, 30, 6, 169, DateTimeKind.Utc).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 23, 20, 11, 49, 998, DateTimeKind.Utc).AddTicks(4401), new DateTime(2023, 7, 2, 13, 42, 51, 230, DateTimeKind.Utc).AddTicks(5704) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 17, 16, 31, 0, 647, DateTimeKind.Utc).AddTicks(5582), new DateTime(2022, 12, 21, 5, 11, 45, 1, DateTimeKind.Utc).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 11, 6, 5, 50, 15, 980, DateTimeKind.Utc).AddTicks(9109), new DateTime(2021, 3, 1, 20, 4, 50, 79, DateTimeKind.Utc).AddTicks(4906) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 20, 14, 44, 45, 970, DateTimeKind.Utc).AddTicks(6776), new DateTime(2023, 6, 8, 12, 15, 24, 368, DateTimeKind.Utc).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 7, 0, 35, 11, 605, DateTimeKind.Utc).AddTicks(2880), new DateTime(2023, 9, 7, 1, 27, 43, 205, DateTimeKind.Utc).AddTicks(1417) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 29, 14, 4, 31, 766, DateTimeKind.Utc).AddTicks(7575), new DateTime(2023, 9, 6, 6, 43, 12, 695, DateTimeKind.Utc).AddTicks(4934) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 36, 10, 432, DateTimeKind.Utc).AddTicks(4746), new DateTime(2023, 7, 2, 20, 25, 55, 870, DateTimeKind.Utc).AddTicks(5307) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 9, 17, 4, 20, 71, DateTimeKind.Utc).AddTicks(8458), new DateTime(2023, 7, 5, 6, 40, 48, 530, DateTimeKind.Utc).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 9, 1, 43, 27, 651, DateTimeKind.Utc).AddTicks(8287), new DateTime(2023, 8, 19, 5, 45, 9, 128, DateTimeKind.Utc).AddTicks(6182) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 10, 2, 0, 4, 890, DateTimeKind.Utc).AddTicks(277), new DateTime(2023, 7, 4, 12, 18, 41, 87, DateTimeKind.Utc).AddTicks(9549) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 9, 14, 7, 35, 17, 834, DateTimeKind.Utc).AddTicks(1284), new DateTime(2023, 2, 4, 18, 1, 37, 301, DateTimeKind.Utc).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 5, 23, 31, 15, 819, DateTimeKind.Utc).AddTicks(527), new DateTime(2023, 9, 6, 9, 13, 24, 591, DateTimeKind.Utc).AddTicks(9225) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 12, 3, 44, 58, 943, DateTimeKind.Utc).AddTicks(5581), new DateTime(2023, 7, 25, 7, 48, 13, 16, DateTimeKind.Utc).AddTicks(8185) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 6, 7, 6, 25, 87, DateTimeKind.Utc).AddTicks(9303), new DateTime(2023, 6, 17, 11, 54, 52, 474, DateTimeKind.Utc).AddTicks(4684) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 3, 21, 6, 2, 634, DateTimeKind.Utc).AddTicks(4869), new DateTime(2023, 7, 21, 17, 4, 55, 57, DateTimeKind.Utc).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 29, 14, 57, 55, 124, DateTimeKind.Utc).AddTicks(9206), new DateTime(2023, 9, 4, 12, 50, 49, 142, DateTimeKind.Utc).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "RegisteredAt",
                value: new DateTime(2016, 5, 19, 15, 0, 42, 69, DateTimeKind.Utc).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                column: "RegisteredAt",
                value: new DateTime(2016, 4, 10, 12, 25, 53, 966, DateTimeKind.Utc).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                column: "RegisteredAt",
                value: new DateTime(2017, 11, 9, 12, 19, 10, 918, DateTimeKind.Utc).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                column: "RegisteredAt",
                value: new DateTime(2018, 7, 24, 20, 13, 38, 217, DateTimeKind.Utc).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                column: "RegisteredAt",
                value: new DateTime(2017, 8, 15, 6, 33, 46, 891, DateTimeKind.Utc).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                column: "RegisteredAt",
                value: new DateTime(2022, 3, 3, 16, 23, 42, 374, DateTimeKind.Utc).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                column: "RegisteredAt",
                value: new DateTime(2020, 9, 15, 17, 44, 10, 153, DateTimeKind.Utc).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                column: "RegisteredAt",
                value: new DateTime(2022, 5, 28, 22, 16, 13, 531, DateTimeKind.Utc).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                column: "RegisteredAt",
                value: new DateTime(2021, 12, 4, 4, 16, 56, 734, DateTimeKind.Utc).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                column: "RegisteredAt",
                value: new DateTime(2018, 7, 19, 1, 48, 36, 314, DateTimeKind.Utc).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11L,
                column: "RegisteredAt",
                value: new DateTime(2022, 3, 25, 5, 35, 0, 938, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12L,
                column: "RegisteredAt",
                value: new DateTime(2019, 9, 15, 5, 40, 1, 66, DateTimeKind.Utc).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13L,
                column: "RegisteredAt",
                value: new DateTime(2021, 3, 10, 7, 52, 45, 143, DateTimeKind.Utc).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14L,
                column: "RegisteredAt",
                value: new DateTime(2016, 6, 9, 19, 14, 16, 352, DateTimeKind.Utc).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15L,
                column: "RegisteredAt",
                value: new DateTime(2022, 3, 13, 14, 25, 25, 476, DateTimeKind.Utc).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16L,
                column: "RegisteredAt",
                value: new DateTime(2017, 6, 22, 11, 52, 17, 404, DateTimeKind.Utc).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17L,
                column: "RegisteredAt",
                value: new DateTime(2016, 1, 19, 22, 14, 8, 183, DateTimeKind.Utc).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18L,
                column: "RegisteredAt",
                value: new DateTime(2022, 12, 26, 20, 24, 57, 727, DateTimeKind.Utc).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19L,
                column: "RegisteredAt",
                value: new DateTime(2022, 4, 14, 14, 10, 32, 852, DateTimeKind.Utc).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20L,
                column: "RegisteredAt",
                value: new DateTime(2020, 12, 16, 3, 24, 34, 222, DateTimeKind.Utc).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21L,
                column: "RegisteredAt",
                value: new DateTime(2017, 1, 24, 4, 44, 49, 675, DateTimeKind.Utc).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22L,
                column: "RegisteredAt",
                value: new DateTime(2018, 5, 3, 17, 16, 29, 934, DateTimeKind.Utc).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23L,
                column: "RegisteredAt",
                value: new DateTime(2021, 11, 7, 6, 29, 25, 765, DateTimeKind.Utc).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24L,
                column: "RegisteredAt",
                value: new DateTime(2021, 4, 26, 17, 50, 48, 748, DateTimeKind.Utc).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25L,
                column: "RegisteredAt",
                value: new DateTime(2019, 2, 21, 12, 14, 57, 409, DateTimeKind.Utc).AddTicks(252));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26L,
                column: "RegisteredAt",
                value: new DateTime(2016, 6, 21, 14, 2, 29, 205, DateTimeKind.Utc).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27L,
                column: "RegisteredAt",
                value: new DateTime(2021, 12, 12, 2, 5, 34, 512, DateTimeKind.Utc).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28L,
                column: "RegisteredAt",
                value: new DateTime(2016, 7, 18, 3, 59, 32, 5, DateTimeKind.Utc).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29L,
                column: "RegisteredAt",
                value: new DateTime(2017, 8, 3, 18, 29, 2, 466, DateTimeKind.Utc).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30L,
                column: "RegisteredAt",
                value: new DateTime(2020, 8, 22, 0, 33, 46, 363, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31L,
                column: "RegisteredAt",
                value: new DateTime(2016, 12, 16, 13, 7, 17, 975, DateTimeKind.Utc).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32L,
                column: "RegisteredAt",
                value: new DateTime(2016, 12, 24, 14, 44, 8, 71, DateTimeKind.Utc).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33L,
                column: "RegisteredAt",
                value: new DateTime(2021, 11, 27, 8, 43, 58, 724, DateTimeKind.Utc).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34L,
                column: "RegisteredAt",
                value: new DateTime(2023, 3, 12, 23, 2, 25, 858, DateTimeKind.Utc).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35L,
                column: "RegisteredAt",
                value: new DateTime(2022, 2, 16, 17, 50, 6, 941, DateTimeKind.Utc).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36L,
                column: "RegisteredAt",
                value: new DateTime(2020, 4, 8, 0, 44, 5, 927, DateTimeKind.Utc).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37L,
                column: "RegisteredAt",
                value: new DateTime(2016, 5, 7, 7, 45, 48, 567, DateTimeKind.Utc).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38L,
                column: "RegisteredAt",
                value: new DateTime(2018, 12, 21, 4, 47, 55, 960, DateTimeKind.Utc).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39L,
                column: "RegisteredAt",
                value: new DateTime(2016, 7, 24, 17, 25, 37, 981, DateTimeKind.Utc).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40L,
                column: "RegisteredAt",
                value: new DateTime(2017, 10, 20, 18, 30, 52, 391, DateTimeKind.Utc).AddTicks(2822));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExampleTestCases",
                table: "ChallengeVersions");

            migrationBuilder.DropColumn(
                name: "PreloadedCode",
                table: "ChallengeVersions");

            migrationBuilder.DropColumn(
                name: "TestCases",
                table: "ChallengeVersions");

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ChallengeId", "CreatedAt", "CreatedBy", "LanguageId", "Status" },
                values: new object[] { 59L, new DateTime(2023, 8, 22, 6, 59, 51, 956, DateTimeKind.Utc).AddTicks(5657), 12L, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 38L, "Est aut repellendus qui fugit.", new DateTime(2023, 6, 4, 14, 8, 0, 794, DateTimeKind.Utc).AddTicks(9736), 4L, "Iusto aut nesciunt modi et quibusdam.", 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { 8L, "Omnis inventore velit.\nMaxime fuga fugiat eos.\nAdipisci id dolores et fugit vero vitae.", new DateTime(2021, 12, 24, 1, 18, 56, 753, DateTimeKind.Utc).AddTicks(187), 8L, "Consequuntur alias ipsam quo alias et quisquam voluptates.", 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 21L, "Nam omnis est magnam rerum eum repudiandae minima tenetur quis. Reprehenderit accusamus dolore est ratione maiores. Et perspiciatis sequi minima pariatur dignissimos eum. Dolorum qui cum voluptatibus quibusdam corporis saepe dolores. Error magni eum dolore minima amet. Temporibus esse magni nihil est officiis ducimus aut dolorem sit.", new DateTime(2023, 6, 11, 14, 48, 11, 801, DateTimeKind.Utc).AddTicks(8441), 16L, "Et vel voluptatum quia quia nesciunt sequi impedit.", 1, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 43L, "Et id nulla nesciunt. Nesciunt minima cupiditate. Dolore corrupti iusto ipsam sapiente. Maxime alias nam.", new DateTime(2023, 8, 22, 14, 46, 4, 544, DateTimeKind.Utc).AddTicks(1217), 24L, "Accusamus magnam quia laudantium id.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { 59L, "Corporis illum molestiae hic et officiis accusantium nostrum. Aut et error itaque animi eveniet ut delectus voluptates dolorem. Laudantium itaque sequi officiis sapiente et.", new DateTime(2023, 2, 27, 12, 48, 11, 969, DateTimeKind.Utc).AddTicks(9622), 7L, "Et pariatur sapiente.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 57L, "Non porro impedit.", new DateTime(2023, 3, 31, 6, 58, 8, 274, DateTimeKind.Utc).AddTicks(1264), 27L, "Blanditiis quidem earum tempore molestias.", 3, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 53L, "Sit molestiae adipisci repellat eum vel dolorum aut ullam distinctio.\nOmnis animi officiis tenetur.", new DateTime(2019, 12, 29, 21, 30, 54, 32, DateTimeKind.Utc).AddTicks(4840), 15L, "Fugit mollitia aut ab eum est quaerat consequatur.", 3, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 27L, "qui", new DateTime(2022, 12, 14, 16, 2, 35, 466, DateTimeKind.Utc).AddTicks(9290), 1L, "Dolore possimus quisquam optio veniam.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 3L, "unde", new DateTime(2023, 7, 8, 15, 28, 2, 785, DateTimeKind.Utc).AddTicks(3042), 34L, "Sit repellendus cupiditate quo quo doloribus.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 16L, "Soluta est libero voluptatum ullam unde libero dolorem voluptatem et.", new DateTime(2023, 6, 18, 3, 19, 7, 452, DateTimeKind.Utc).AddTicks(3651), 9L, "Officiis eos molestias explicabo.", 1, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { 51L, "omnis", new DateTime(2023, 9, 4, 10, 39, 20, 547, DateTimeKind.Utc).AddTicks(8959), 35L, "Modi eaque iusto commodi.", 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 38L, "Voluptatem et veniam iusto rerum.", new DateTime(2023, 4, 25, 4, 40, 47, 228, DateTimeKind.Utc).AddTicks(7678), 14L, "Culpa maiores officiis deleniti cumque similique optio et sed ab.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { 43L, "Nihil officia minima quae id occaecati quod.", new DateTime(2023, 8, 28, 18, 33, 19, 590, DateTimeKind.Utc).AddTicks(844), 7L, "Totam expedita hic vel sint rerum earum facilis.", 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 51L, "Itaque quidem debitis nisi voluptate. Placeat facere omnis ea quia ea voluptatibus id laborum. Consequatur iure nisi voluptatem temporibus.", new DateTime(2023, 7, 6, 5, 5, 31, 128, DateTimeKind.Utc).AddTicks(819), 19L, "Ipsa sequi voluptatum qui.", 3, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 65L, "Recusandae rerum dolor assumenda maiores placeat magnam debitis.\nFacilis velit et qui totam et iusto consequatur ut.", new DateTime(2022, 9, 2, 2, 57, 51, 118, DateTimeKind.Utc).AddTicks(8406), 35L, "Et expedita dignissimos et neque atque aut.", 2, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 28L, "Perspiciatis dolorum architecto placeat. Eum aut repellendus laudantium est cumque velit. Voluptatum fugiat aut. Est voluptatum natus sed qui. Inventore beatae totam et necessitatibus velit. Et pariatur voluptas veniam rerum.", new DateTime(2023, 1, 31, 12, 0, 37, 279, DateTimeKind.Utc).AddTicks(9005), 35L, "Nulla explicabo suscipit molestiae perferendis.", 1, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 7L, "Quis dignissimos ipsam et in dolores perferendis.", new DateTime(2021, 5, 17, 19, 21, 54, 18, DateTimeKind.Utc).AddTicks(202), 37L, "Dolorum praesentium blanditiis quia commodi non quis voluptatem.", 3, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { 24L, "Ab at at dolorem qui nobis doloremque.\nQuo aliquam omnis et illo voluptas culpa ea ducimus ea.\nEt eum est est neque qui.\nVoluptatem unde voluptatem non.\nDolor et dolor molestias et officia.", new DateTime(2021, 11, 10, 1, 16, 19, 672, DateTimeKind.Utc).AddTicks(8106), 5L, "Et at iusto illum.", 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 67L, "Vitae eligendi consequatur laboriosam commodi atque.\nDolor eos est repellat enim aliquam ratione.", new DateTime(2023, 8, 25, 23, 45, 21, 179, DateTimeKind.Utc).AddTicks(5908), 31L, "Voluptas et quis voluptatem autem voluptas ducimus maiores praesentium odit.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { 29L, "Rerum recusandae cum et officia odit aliquid saepe corrupti. Aliquid dolorum iste quia voluptatibus dolores nostrum ab quia dolor. Doloremque odio suscipit animi recusandae quo voluptatem odio.", new DateTime(2022, 9, 25, 15, 29, 22, 204, DateTimeKind.Utc).AddTicks(3583), 11L, "Est recusandae aliquam provident molestiae.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 58L, "Cumque sint tenetur sed et.", new DateTime(2023, 5, 1, 16, 2, 15, 949, DateTimeKind.Utc).AddTicks(9910), 10L, "Non aspernatur recusandae soluta ratione quibusdam et totam voluptatem.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 25L, "qui", new DateTime(2022, 11, 16, 23, 32, 49, 458, DateTimeKind.Utc).AddTicks(1602), 14L, "Laboriosam totam expedita reprehenderit sed blanditiis.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 38L, "Natus esse sint magnam incidunt velit adipisci voluptatem.", new DateTime(2023, 1, 5, 11, 7, 37, 694, DateTimeKind.Utc).AddTicks(6756), 10L, "Ea consequatur aut.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 24L, "Ut vitae aut molestias. Expedita provident ex beatae nihil numquam nihil adipisci consequatur. Dolor quae sit consequuntur. Esse et veniam saepe nisi eius. Labore aut aut molestiae quaerat iure voluptatem exercitationem ut. Doloremque facere similique molestiae error.", new DateTime(2022, 10, 7, 14, 44, 47, 108, DateTimeKind.Utc).AddTicks(3162), 25L, "Iusto possimus laudantium accusantium possimus mollitia totam blanditiis odio corrupti.", 2, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution" },
                values: new object[] { 13L, "Doloribus dolorem et accusamus nostrum aliquam aut repellat tenetur.", new DateTime(2020, 5, 7, 0, 1, 10, 419, DateTimeKind.Utc).AddTicks(3102), 37L, "Voluptas tempore reprehenderit nesciunt et dignissimos omnis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution" },
                values: new object[] { 60L, "Facilis quod expedita adipisci voluptates molestiae qui ut qui rerum. Perferendis iusto ea et quia. Harum nemo aliquam suscipit exercitationem error iure rerum. Et autem culpa nemo delectus voluptates.", new DateTime(2023, 7, 23, 1, 59, 20, 188, DateTimeKind.Utc).AddTicks(9076), 17L, "In iste voluptatum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 39L, "Sequi blanditiis vero.", new DateTime(2022, 8, 27, 16, 7, 9, 913, DateTimeKind.Utc).AddTicks(7862), 25L, "Vel dolorem occaecati minus natus explicabo repudiandae optio.", 4, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 69L, "nobis", new DateTime(2023, 4, 12, 14, 58, 57, 61, DateTimeKind.Utc).AddTicks(4714), 40L, "Ut enim atque amet.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 12L, "Minus id minus rem voluptatum amet.", new DateTime(2023, 1, 31, 9, 7, 12, 564, DateTimeKind.Utc).AddTicks(5260), 6L, "Odio ratione voluptatem.", 4, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { 37L, "Consequatur eveniet quidem enim quae voluptatum fugit error. Aut veritatis quo nemo fugiat deserunt veritatis ad. Et nihil autem.", new DateTime(2022, 10, 26, 15, 7, 30, 734, DateTimeKind.Utc).AddTicks(267), 40L, "Commodi perferendis ut.", 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 44L, "Quam iste aliquam ex repudiandae atque beatae odit excepturi.", new DateTime(2022, 6, 28, 16, 27, 20, 512, DateTimeKind.Utc).AddTicks(4014), 13L, "At maiores aut aliquid perferendis adipisci odio expedita.", 4, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 37L, "Voluptas corrupti voluptas quaerat in minus provident.", new DateTime(2022, 3, 13, 3, 17, 24, 877, DateTimeKind.Utc).AddTicks(2898), 8L, "Vel ut repudiandae et.", 1, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 43L, "Repudiandae voluptatum quod sit voluptas nobis. Magni harum expedita non. Voluptatibus tempora explicabo quasi esse aspernatur. Facere perspiciatis inventore asperiores hic. Nostrum dicta rerum omnis voluptatem consectetur.", new DateTime(2023, 9, 1, 23, 55, 14, 454, DateTimeKind.Utc).AddTicks(5579), 29L, "At praesentium ea ut.", 1, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 35L, "Omnis iure rerum magnam perspiciatis necessitatibus et vero deleniti autem. Eaque animi ut consequatur laborum laudantium quos. Inventore cupiditate labore voluptas officia neque ducimus aliquam eos. Dolores est tempore doloremque aspernatur consequuntur autem beatae.", new DateTime(2023, 8, 16, 23, 54, 12, 226, DateTimeKind.Utc).AddTicks(3627), 1L, "Dolorem recusandae necessitatibus dolores ea velit vero laboriosam.", 4, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 60L, "et", new DateTime(2021, 4, 1, 9, 35, 31, 341, DateTimeKind.Utc).AddTicks(4708), 8L, "Hic dolore eveniet nostrum voluptatem.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 38L, "Et consequatur et eius.", new DateTime(2022, 7, 27, 9, 0, 10, 57, DateTimeKind.Utc).AddTicks(3994), 1L, "Veritatis ex sunt aspernatur quidem voluptas non.", 4, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 51L, "Sequi aut aut nulla quod.", new DateTime(2023, 4, 5, 8, 38, 22, 921, DateTimeKind.Utc).AddTicks(2756), 26L, "Cum et autem.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 66L, "Laboriosam saepe temporibus non ipsa ut accusamus voluptas eos.\nRepellendus expedita est perferendis.", new DateTime(2022, 7, 22, 14, 26, 24, 868, DateTimeKind.Utc).AddTicks(9124), 27L, "Quisquam at reprehenderit beatae magnam.", 4, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 52L, "Temporibus quae fugiat.\nConsequatur quis commodi ipsum veritatis in officiis.\nAt cum nulla rerum fuga impedit doloremque qui unde deserunt.\nEt aliquid ratione quisquam molestiae.\nCommodi qui velit incidunt nulla.", new DateTime(2022, 1, 30, 0, 40, 55, 996, DateTimeKind.Utc).AddTicks(7900), 4L, "Quam consectetur ipsum et et soluta vel.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 14L, "Sit libero inventore odit facilis nesciunt.", new DateTime(2023, 1, 2, 21, 22, 28, 624, DateTimeKind.Utc).AddTicks(5112), 17L, "In ea animi autem qui dolores.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 50L, "quia", new DateTime(2023, 4, 18, 19, 41, 6, 923, DateTimeKind.Utc).AddTicks(8594), 35L, "Est odio vero optio consequuntur tempore est consequatur nemo.", 3, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 68L, "autem", new DateTime(2023, 2, 12, 14, 51, 24, 185, DateTimeKind.Utc).AddTicks(3977), 33L, "Rem cumque at consequatur tempora et facilis corporis ut iste.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 48L, "Et veniam veniam quia nemo cumque.\nAb nihil sed non qui omnis.\nEt harum dolores.\nOptio quisquam omnis est.", new DateTime(2023, 6, 8, 14, 13, 4, 218, DateTimeKind.Utc).AddTicks(9372), 33L, "Dolores quas ut nam illo consequatur sit amet repudiandae.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 35L, "autem", new DateTime(2023, 8, 31, 8, 34, 5, 577, DateTimeKind.Utc).AddTicks(5288), 4L, "Deleniti eaque doloribus.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 13L, "Ab est pariatur autem pariatur nostrum unde animi. Et illo ea. Iure unde fugit animi quo et dolorem.", new DateTime(2019, 7, 30, 15, 18, 34, 276, DateTimeKind.Utc).AddTicks(3470), 40L, "Quisquam quam aspernatur vel animi nostrum molestias necessitatibus.", 3, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 4L, "Eius dolore repellat sunt velit labore dolores nulla nesciunt libero. Cupiditate doloribus ab. Et ab enim consequatur. Debitis quis officiis quos. Saepe voluptate quia ut culpa ut. Autem in sit accusamus animi maxime molestiae.", new DateTime(2022, 8, 18, 23, 26, 36, 774, DateTimeKind.Utc).AddTicks(1986), 13L, "Qui eos reprehenderit culpa sint impedit.", 3, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 49L, "Atque dolorum odit non quis molestias.\nCorporis fugiat quis nemo culpa voluptatem omnis minus.\nQuisquam nemo corporis corporis rerum dolor sed.\nSapiente error dolore praesentium quos quia asperiores.\nImpedit tenetur voluptatem ipsum nostrum in dolores explicabo quae.\nFacere possimus sit maxime.", new DateTime(2023, 7, 11, 3, 43, 2, 685, DateTimeKind.Utc).AddTicks(6654), 33L, "Recusandae ea dicta numquam.", 4, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 22L, "Odio officiis consequatur non natus. Voluptatem vel non quaerat omnis. Ea provident eius. Iste quaerat cum a dicta et ratione. Ipsam libero id iusto nobis fugiat.", new DateTime(2023, 4, 11, 15, 31, 26, 504, DateTimeKind.Utc).AddTicks(2415), 19L, "Consequatur error molestias nihil quas omnis delectus consequatur quaerat labore.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 27L, "Maxime ut cumque.\nDolores unde non earum qui et non saepe natus rerum.", new DateTime(2023, 5, 21, 8, 13, 12, 554, DateTimeKind.Utc).AddTicks(7081), 18L, "Fuga neque quidem excepturi ipsa explicabo nesciunt nemo placeat.", 1, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 23L, "Porro est qui magni eum dolor optio.\nQuidem qui cumque hic maxime.\nNesciunt delectus omnis vero corporis eveniet et et in quis.\nEa ut quidem eius animi.\nTempora in consequatur voluptas velit cum dolore dolorum ut vitae.", new DateTime(2023, 8, 25, 18, 13, 36, 862, DateTimeKind.Utc).AddTicks(6084), 10L, "Tenetur ut hic qui dolorum dolorem repudiandae doloribus laboriosam quo.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 15L, "dolorem", new DateTime(2018, 9, 16, 9, 14, 38, 868, DateTimeKind.Utc).AddTicks(1138), 2L, "Non possimus voluptatem natus voluptatibus iure quod veniam et nostrum.", 2, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 34L, "Ut eaque vel animi placeat adipisci eaque.", new DateTime(2022, 11, 24, 21, 58, 38, 823, DateTimeKind.Utc).AddTicks(8335), 36L, "Rem autem vel aut sapiente.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 36L, "consectetur", new DateTime(2021, 7, 11, 11, 44, 5, 827, DateTimeKind.Utc).AddTicks(8085), 7L, "Voluptates voluptas fugiat.", 4, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 8L, "Aut quibusdam minus doloremque maxime aliquid. Nobis ut explicabo consequuntur delectus maiores blanditiis sit quo asperiores. Harum ut ullam et ab.", new DateTime(2022, 4, 17, 17, 31, 3, 129, DateTimeKind.Utc).AddTicks(3487), 40L, "Laborum veniam hic.", 4, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "InitialSolution", "LanguageId" },
                values: new object[] { 10L, "In quis vel iure blanditiis dolorem mollitia quo est quis.", new DateTime(2022, 8, 20, 9, 41, 55, 952, DateTimeKind.Utc).AddTicks(5511), "Totam dolore voluptatem repellendus doloribus et beatae laudantium aut neque.", 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 55L, "Et aut autem maiores sit qui et eveniet harum labore. Est sint iure tenetur numquam dolor. Quia dolore temporibus rem suscipit excepturi dicta quas.", new DateTime(2023, 8, 22, 20, 50, 55, 554, DateTimeKind.Utc).AddTicks(5125), 35L, "Tenetur molestiae distinctio commodi dolores optio iusto pariatur.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 38L, "Unde molestias natus ad quod. Dolor atque quaerat quia quod recusandae quia voluptas assumenda et. Soluta sit at velit repellendus ad accusamus autem facere deserunt. Illum aut modi quia. Quos molestiae dolorem hic consequatur. Voluptatem mollitia eius deserunt possimus repellendus laboriosam a laudantium.", new DateTime(2023, 8, 27, 3, 58, 45, 172, DateTimeKind.Utc).AddTicks(5041), 30L, "Ad dolorem autem minus in ullam quam.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 2L, "Eum sapiente libero vel voluptatibus et deserunt porro ea earum.\nSunt sint accusamus aliquam reiciendis consectetur sint dicta eaque autem.\nAliquam minima atque atque.\nQuis reprehenderit neque mollitia.\nRepudiandae est assumenda harum omnis.\nOmnis dolorem placeat et.", new DateTime(2022, 9, 13, 11, 1, 10, 89, DateTimeKind.Utc).AddTicks(7845), 13L, "Aut omnis incidunt.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution" },
                values: new object[] { 46L, "Adipisci aliquam impedit iure saepe dolores voluptatum corporis voluptas.\nUt expedita dolor qui.\nDolorum molestiae reiciendis.\nSint quis omnis et incidunt distinctio dolor distinctio.\nQuos ut deserunt.", new DateTime(2023, 1, 19, 18, 41, 22, 82, DateTimeKind.Utc).AddTicks(5785), 24L, "Quibusdam quia sunt." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 5L, "Eligendi mollitia aut est.\nRerum amet voluptatum qui porro fugiat dignissimos.", new DateTime(2023, 3, 18, 4, 23, 12, 383, DateTimeKind.Utc).AddTicks(6712), 19L, "Neque voluptatem minima eligendi ducimus repudiandae dolorem tempore delectus consequuntur.", 4, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution" },
                values: new object[] { 70L, "Voluptas quidem labore iste.\nIllo maiores sit ipsam sunt repellat et delectus.\nItaque voluptas ducimus iusto id dignissimos.\nHarum vero dolor sed.", new DateTime(2023, 3, 7, 7, 4, 53, 517, DateTimeKind.Utc).AddTicks(2259), 17L, "Error officia optio ut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 36L, "Pariatur nihil et atque est error ipsa facilis. Voluptatem dolore eum illo voluptatem reiciendis quia. Inventore ex minus illo accusamus mollitia fugiat ratione veritatis.", new DateTime(2022, 4, 5, 3, 30, 4, 704, DateTimeKind.Utc).AddTicks(3479), 38L, "Itaque excepturi praesentium qui alias hic.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 7L, "Corrupti neque ut mollitia aut.\nDeleniti cupiditate modi necessitatibus error corporis.\nVoluptatibus eum libero laboriosam officia dolorem sed.\nEst rerum porro et fugit molestiae sequi quasi velit cupiditate.\nVel cumque vel iusto mollitia unde dolor et.\nTempora porro atque.", new DateTime(2023, 8, 29, 3, 22, 13, 279, DateTimeKind.Utc).AddTicks(333), 25L, "In itaque deserunt dolorem dolores quis provident.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 35L, "Dolorem voluptas veritatis voluptas qui vel consequatur.", new DateTime(2023, 6, 23, 0, 31, 24, 239, DateTimeKind.Utc).AddTicks(5837), 24L, "Aperiam rerum rem eum blanditiis et.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { "In possimus sit temporibus vel nesciunt id autem culpa et.\nEt in nesciunt beatae vel velit.\nOptio omnis et sed aut est esse perferendis animi.\nLabore sed quia accusamus temporibus eum.\nOmnis fugiat reiciendis dolore dolorem pariatur iusto repellendus laborum.", new DateTime(2023, 8, 26, 9, 59, 13, 316, DateTimeKind.Utc).AddTicks(6572), 10L, "Autem voluptate voluptatem.", 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 21L, "Et natus sed dolores ipsa.\nIste blanditiis placeat.\nVoluptatem perspiciatis iusto mollitia provident.\nRem sit et unde placeat doloribus consequatur voluptate eum perspiciatis.\nIllo eveniet omnis deserunt sed aut est dignissimos id.", new DateTime(2023, 4, 16, 6, 6, 29, 547, DateTimeKind.Utc).AddTicks(4203), 24L, "Asperiores quam illum necessitatibus et veniam.", 3, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 1L, "Sapiente mollitia hic ratione quia.\nConsequatur consectetur quibusdam nemo et et et.\nMaiores eligendi velit iusto eum voluptatem molestiae.\nIpsum officia et quae sed.\nNihil minus sapiente voluptatibus delectus est recusandae neque.\nAut recusandae maiores harum esse nulla doloribus dolore.", new DateTime(2023, 1, 9, 5, 26, 20, 726, DateTimeKind.Utc).AddTicks(2000), 12L, "Enim rerum tempore et.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 25L, "Magni dicta explicabo assumenda.", new DateTime(2023, 6, 12, 22, 50, 45, 678, DateTimeKind.Utc).AddTicks(62), 12L, "Et qui tempore ex cum molestiae.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 12L, "Laboriosam officia ipsa debitis.", new DateTime(2022, 11, 14, 5, 56, 47, 180, DateTimeKind.Utc).AddTicks(7762), 22L, "Qui illo tempora et nulla sint molestias.", 2, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 38L, "Est repellendus est qui illo ad aperiam. Velit et non rerum sequi nulla. Dolore voluptatem quidem dicta. Distinctio mollitia et consequatur. Maiores enim commodi dicta omnis. Optio earum reiciendis eos et provident.", new DateTime(2023, 8, 21, 11, 48, 20, 896, DateTimeKind.Utc).AddTicks(9568), "Quam quaerat id ad placeat.", 3, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 30L, "Maiores quo totam.\nDelectus tempore vel.\nVoluptas incidunt earum dolor maiores qui.\nVelit aut voluptatem ea eligendi et repellendus sed.\nNulla id laboriosam deserunt cupiditate commodi voluptatibus magnam explicabo consequatur.\nOptio ratione praesentium aut ipsum officia unde magnam.", new DateTime(2020, 3, 17, 19, 51, 14, 101, DateTimeKind.Utc).AddTicks(8360), 24L, "Sit id consequatur eos sunt voluptatem quos aliquam fugit porro.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 56L, "tempora", new DateTime(2019, 8, 20, 22, 21, 1, 783, DateTimeKind.Utc).AddTicks(5907), 17L, "Voluptas perferendis qui sit amet nihil sed harum similique.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 59L, "beatae", new DateTime(2023, 2, 16, 14, 6, 3, 177, DateTimeKind.Utc).AddTicks(3861), 36L, "Vitae quia repudiandae perferendis ut rerum sint amet.", 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 57L, "in", new DateTime(2022, 7, 30, 16, 57, 19, 577, DateTimeKind.Utc).AddTicks(5124), 34L, "Consequatur soluta aliquid qui sint et iure totam veritatis in.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { 57L, "nisi", new DateTime(2022, 7, 7, 21, 20, 55, 590, DateTimeKind.Utc).AddTicks(1894), 14L, "Aut velit cupiditate voluptas in quis aut qui.", 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 8L, "Est ea itaque ut ullam molestiae nobis cumque maxime repellat. Autem quae aut reiciendis nihil est qui ipsa. Quaerat atque necessitatibus et voluptate eum iusto autem laudantium. Impedit fuga beatae illum necessitatibus ut earum autem temporibus repudiandae.", new DateTime(2019, 4, 18, 2, 38, 41, 887, DateTimeKind.Utc).AddTicks(1133), 14L, "Aut numquam illo distinctio omnis quia.", 4, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 69L, "Maxime est eligendi quia sint. Earum totam asperiores saepe labore temporibus. Fugit ullam incidunt numquam consequatur.", new DateTime(2023, 7, 1, 20, 19, 51, 75, DateTimeKind.Utc).AddTicks(9769), 6L, "Non fugit beatae.", 4, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 6L, "Molestias hic ex debitis molestiae quia nobis qui. At voluptatem sint sunt et natus inventore. Possimus cumque eveniet quasi. Accusantium voluptatem et fugiat.", new DateTime(2023, 7, 9, 7, 57, 0, 568, DateTimeKind.Utc).AddTicks(8001), 12L, "Magni ut nesciunt aliquid.", 3, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 19L, "provident", new DateTime(2022, 10, 14, 1, 55, 27, 525, DateTimeKind.Utc).AddTicks(3593), 29L, "Tempore quia qui voluptas non ut accusamus.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution" },
                values: new object[] { 10L, "Eaque quaerat deserunt deserunt est voluptatum modi quaerat placeat et.", new DateTime(2023, 8, 30, 6, 18, 12, 526, DateTimeKind.Utc).AddTicks(4750), 6L, "Exercitationem sunt deleniti recusandae deserunt velit nihil facilis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 63L, "Alias quis magnam provident quam.", new DateTime(2022, 4, 9, 11, 55, 12, 798, DateTimeKind.Utc).AddTicks(6918), 12L, "Mollitia consequatur sint itaque ut animi voluptate fugit labore quas.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 10L, "Magni autem sit.\nAt deleniti aliquid odit voluptatibus debitis.\nAutem asperiores eum quo quibusdam.\nAut est vitae ducimus.\nUt eaque harum dignissimos nemo architecto.", new DateTime(2023, 5, 20, 4, 28, 50, 88, DateTimeKind.Utc).AddTicks(2967), 12L, "Beatae aperiam et ut delectus aut neque at aliquid rerum.", 3, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 57L, "et", new DateTime(2023, 3, 8, 15, 3, 19, 561, DateTimeKind.Utc).AddTicks(354), 7L, "In ipsa ut qui.", 1, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 31L, "Voluptatum voluptatibus aut voluptate ipsum minima blanditiis voluptas.\nA est quibusdam voluptatibus tempore saepe.\nRerum consequatur sint harum nisi maxime et ipsa rem.\nEt mollitia accusantium laudantium sed dolore officia impedit similique et.\nPorro et rerum ea aliquam cum est maiores.", new DateTime(2023, 3, 27, 4, 39, 29, 262, DateTimeKind.Utc).AddTicks(2854), 7L, "Ut quam ducimus illo fugit recusandae explicabo.", 1, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 26L, "Omnis voluptas itaque quis est vero illum sit.", new DateTime(2023, 1, 26, 8, 34, 2, 208, DateTimeKind.Utc).AddTicks(3048), 11L, "Veniam id aut.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 55L, "Iusto eligendi esse sint facilis laborum ea quo quis.", new DateTime(2023, 3, 12, 8, 1, 30, 784, DateTimeKind.Utc).AddTicks(6956), 10L, "Eos ipsum sit aperiam ad dicta quasi dolor inventore ullam.", 4, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 8L, "adipisci", new DateTime(2018, 10, 13, 20, 23, 9, 979, DateTimeKind.Utc).AddTicks(1249), 29L, "Distinctio saepe dolorum delectus neque tempore.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 29L, "Repudiandae ut animi quaerat reprehenderit voluptas et. Est voluptate rerum iusto sit veniam dolor magnam et. Illum architecto repudiandae explicabo quia id ipsum. Et et beatae ipsam. Inventore ut quis.", new DateTime(2022, 1, 23, 12, 14, 54, 492, DateTimeKind.Utc).AddTicks(1803), 38L, "Assumenda impedit quidem quo et quam quia animi.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 46L, "Iste fuga ipsum fuga inventore.", new DateTime(2022, 7, 5, 22, 46, 20, 19, DateTimeKind.Utc).AddTicks(1124), 33L, "Voluptas molestiae laborum magnam aut.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { 40L, "assumenda", new DateTime(2023, 3, 24, 17, 32, 2, 739, DateTimeKind.Utc).AddTicks(7137), 23L, "Dicta magnam laboriosam consequatur optio suscipit aliquid eum provident sapiente.", 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 31L, "quaerat", new DateTime(2023, 7, 30, 15, 30, 21, 51, DateTimeKind.Utc).AddTicks(2759), 24L, "Atque et quisquam eveniet quo rerum consequatur et est repellat.", 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 45L, "Nisi occaecati at molestias veritatis alias laudantium suscipit. Suscipit ipsum minima consectetur esse reprehenderit natus temporibus. Aliquid autem ad ut est blanditiis architecto impedit.", new DateTime(2023, 1, 27, 9, 47, 24, 169, DateTimeKind.Utc).AddTicks(2110), 31L, "Et qui incidunt minima.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { 37L, "In fuga repellat sunt et alias sunt ratione enim distinctio.", new DateTime(2022, 12, 18, 6, 7, 55, 771, DateTimeKind.Utc).AddTicks(2330), 18L, "Libero sequi quos.", 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 66L, "eum", new DateTime(2022, 12, 26, 0, 43, 12, 99, DateTimeKind.Utc).AddTicks(7157), 7L, "Quaerat totam beatae voluptates in et ex.", 2, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 37L, "Aliquid modi aliquid.", new DateTime(2021, 10, 28, 16, 33, 6, 438, DateTimeKind.Utc).AddTicks(7925), 31L, "Molestiae sapiente animi.", 2, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 22L, "Nobis velit sint natus delectus enim.\nQuod quas et a asperiores cumque fuga necessitatibus error.\nAb et velit aperiam.\nConsequatur qui dicta.", new DateTime(2023, 1, 20, 2, 48, 6, 732, DateTimeKind.Utc).AddTicks(1054), 29L, "Odit beatae ipsam.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 39L, "Non atque nulla sed iste ipsam veritatis nihil.", new DateTime(2023, 8, 10, 3, 13, 44, 599, DateTimeKind.Utc).AddTicks(1957), 11L, "Error nobis velit aliquid excepturi ducimus ipsa.", 1, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 44L, "Nam sit nesciunt ducimus qui enim et enim autem sed.", new DateTime(2021, 8, 15, 19, 30, 8, 87, DateTimeKind.Utc).AddTicks(9933), 27L, "Autem error animi quia rem.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 25L, "dolor", new DateTime(2023, 7, 12, 9, 55, 32, 221, DateTimeKind.Utc).AddTicks(3295), 17L, "Est voluptas est id debitis.", 3, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 11L, "consequatur", new DateTime(2021, 9, 13, 11, 10, 59, 269, DateTimeKind.Utc).AddTicks(7778), 18L, "Voluptates quia sunt consequuntur omnis eos laudantium est facere.", 3, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 46L, "harum", new DateTime(2023, 7, 18, 13, 13, 22, 981, DateTimeKind.Utc).AddTicks(6738), 32L, "Dicta animi dolorem exercitationem asperiores veniam cumque est.", 4, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution" },
                values: new object[] { 5L, "Voluptas ipsa est veniam facere at quo occaecati.\nRepellat quos sint ipsa officiis odio est incidunt dolorum.\nExpedita quis aut.\nLibero quis harum aperiam qui asperiores temporibus id impedit dolores.\nRecusandae facilis commodi aliquid sunt aut eum.\nVitae cum doloribus perspiciatis placeat.", new DateTime(2023, 6, 5, 14, 19, 29, 560, DateTimeKind.Utc).AddTicks(8516), 24L, "Atque laudantium autem et dolores sunt consequatur sunt." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { 30L, "Voluptatem voluptatem dolor dolor odio earum autem. Aut non tempora ad aspernatur. Quia soluta quod. Quis vitae deserunt non ut nesciunt itaque nostrum minima corrupti. Ex aut voluptatibus consequatur maxime.", new DateTime(2019, 6, 1, 23, 20, 42, 486, DateTimeKind.Utc).AddTicks(6967), 31L, "Velit enim expedita nesciunt illo asperiores sed.", 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 44L, "Ut provident corrupti non consequatur.", new DateTime(2022, 2, 14, 20, 44, 7, 364, DateTimeKind.Utc).AddTicks(3697), 6L, "Ut beatae cumque itaque quia et non et tenetur.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { "Temporibus rem reiciendis sunt atque vel sint excepturi voluptas quo.", new DateTime(2023, 8, 26, 3, 53, 27, 950, DateTimeKind.Utc).AddTicks(2976), 22L, "Perferendis cupiditate iste et laudantium.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { 11L, "Qui et neque qui sapiente veritatis. Vel beatae praesentium vero. Neque et minima nam quae cum esse ullam. Repellendus eum et perferendis assumenda vitae molestiae qui.", new DateTime(2020, 2, 13, 7, 50, 2, 457, DateTimeKind.Utc).AddTicks(704), 29L, "Id qui voluptatem.", 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 4L, "Qui quasi ea. In tenetur facere et sunt explicabo magni consectetur. Maxime natus veniam ipsam ipsam hic autem sit eius aliquam. Qui sapiente a porro accusantium ad voluptas doloremque.", new DateTime(2022, 10, 1, 5, 54, 47, 422, DateTimeKind.Utc).AddTicks(1241), 30L, "Inventore voluptate nisi at qui laboriosam hic omnis iste tempora.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { 42L, "distinctio", new DateTime(2023, 3, 24, 23, 7, 17, 803, DateTimeKind.Utc).AddTicks(4477), 20L, "Qui omnis et dicta delectus ipsam.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 25L, "Aut autem et qui vel. Illum ipsum consectetur dolor recusandae aliquam earum quos neque corrupti. Sit omnis doloremque recusandae repellat. Quae alias recusandae est tempore impedit voluptas in enim. Veritatis aut accusamus omnis. In in molestiae id voluptas in.", new DateTime(2023, 5, 23, 13, 31, 3, 155, DateTimeKind.Utc).AddTicks(5600), 9L, "Doloremque in aut animi illum cumque dolorem iusto asperiores eaque.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 30L, "qui", new DateTime(2018, 2, 19, 14, 10, 17, 545, DateTimeKind.Utc).AddTicks(9044), 25L, "Harum nihil modi repellendus voluptatem aut ut officiis eos debitis.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 34L, "Deleniti perferendis possimus. Officiis dicta commodi quod. Eveniet cum enim. Consequatur quis enim quam et blanditiis et asperiores. Consequatur perferendis quisquam hic magnam sit consequuntur hic unde.", new DateTime(2022, 10, 31, 23, 37, 32, 88, DateTimeKind.Utc).AddTicks(4414), 30L, "Eum exercitationem recusandae repudiandae possimus aut id adipisci sequi nihil.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 55L, "Ipsam et id dolorum sint velit et.\nFacilis quod esse et quo sit et inventore.", new DateTime(2023, 4, 30, 16, 37, 53, 53, DateTimeKind.Utc).AddTicks(8815), 36L, "Quis qui provident quod eos autem qui aliquam.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 28L, "Aut omnis sed necessitatibus est et.\nNon molestiae iure architecto.\nArchitecto atque delectus officiis aut optio natus cupiditate ipsam.\nDeleniti est sit.\nNesciunt ex id unde mollitia et quia quia tempore voluptatibus.\nDoloremque amet ipsam velit nulla.", new DateTime(2022, 12, 30, 18, 26, 34, 346, DateTimeKind.Utc).AddTicks(6225), 5L, "Error magni quasi et.", 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 56L, "Impedit nobis impedit pariatur est.", new DateTime(2022, 12, 12, 18, 57, 13, 793, DateTimeKind.Utc).AddTicks(3658), 22L, "Animi quaerat ut modi rerum sit magni non.", 2, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 34L, "veritatis", new DateTime(2022, 12, 26, 0, 8, 53, 428, DateTimeKind.Utc).AddTicks(776), 14L, "Voluptatibus in omnis molestias et fugit rem dolorum sunt.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 48L, "Est natus labore quae mollitia qui sunt. Eos et nobis corrupti porro cumque eius distinctio. Amet quia facilis quis modi. Ut explicabo quam.", new DateTime(2023, 3, 9, 13, 55, 36, 337, DateTimeKind.Utc).AddTicks(519), 3L, "Sapiente debitis beatae quod nihil.", 1, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { 37L, "Dolorum qui expedita autem expedita quaerat expedita esse.", new DateTime(2022, 2, 22, 10, 54, 53, 939, DateTimeKind.Utc).AddTicks(5358), 28L, "Blanditiis consequatur quidem omnis incidunt sunt dolores odio.", 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 38L, "Inventore aperiam impedit et libero. Quod eligendi rerum voluptatem mollitia id. Est ullam voluptas hic sit quis rerum voluptas repellat est. Magnam vitae voluptatem et ipsam veritatis deserunt omnis dolorem. Animi omnis hic adipisci maiores maiores eligendi dolorem quod. Et dolor sint commodi expedita esse molestiae.", new DateTime(2022, 7, 12, 1, 4, 33, 668, DateTimeKind.Utc).AddTicks(8198), 23L, "Totam ut tenetur dolor autem ut.", 4, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { 67L, "Natus illum omnis ratione aut sed illum possimus doloremque.", new DateTime(2023, 2, 8, 8, 31, 38, 996, DateTimeKind.Utc).AddTicks(6986), 11L, "Repudiandae vel qui dolorem quia.", 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 27L, "Ut tempore ut ut et aperiam vel ea. Similique ducimus et ut et consequatur consequatur aliquid sed. Libero at sequi quia harum aut perferendis. Nisi sit ut dolorem rem sit at culpa. Repudiandae rem eaque.", new DateTime(2022, 11, 7, 22, 26, 18, 754, DateTimeKind.Utc).AddTicks(6722), 23L, "Rem similique ut a.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 35L, "At vitae laudantium animi minus atque exercitationem aperiam iure iste. Reiciendis id sed eius ut blanditiis. Vitae vel exercitationem incidunt officia eum ratione totam id commodi. Illum porro voluptas dolorem numquam repellat et rerum ipsam id.", new DateTime(2023, 5, 7, 19, 35, 28, 55, DateTimeKind.Utc).AddTicks(9051), 10L, "Suscipit ad autem laudantium velit unde.", 3, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution" },
                values: new object[] { 48L, "Blanditiis ut maxime recusandae sequi similique quo beatae.\nOccaecati sed quisquam quaerat eos qui cupiditate voluptas hic.\nIn at harum officiis in quia enim architecto ab similique.\nPerspiciatis autem consequatur consequatur eos rem consequatur iste.", new DateTime(2023, 6, 22, 15, 8, 57, 108, DateTimeKind.Utc).AddTicks(5992), 36L, "Excepturi mollitia nesciunt nesciunt error maxime libero possimus quos tempore." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 7L, "Neque quisquam harum sint.\nQui reprehenderit dolorem qui voluptas quos temporibus excepturi magni.\nQuod porro aliquam minima libero porro est voluptas ipsam in.\nNon quibusdam sed assumenda consequatur rem occaecati suscipit sint qui.", new DateTime(2020, 4, 19, 20, 47, 23, 731, DateTimeKind.Utc).AddTicks(4725), 2L, "Ipsa iusto corporis.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 13L, "Vero sint reprehenderit a voluptatem.\nDolorem necessitatibus mollitia harum a fugiat voluptatem.", new DateTime(2023, 8, 30, 12, 28, 28, 651, DateTimeKind.Utc).AddTicks(266), 7L, "Eum nisi dolor iure iure similique aspernatur corporis.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 7L, "Incidunt quae a ratione nam illum quia eos.\nSimilique qui voluptatem atque consequatur accusamus.\nNesciunt sed non tenetur earum corporis sunt.", new DateTime(2021, 8, 25, 3, 8, 30, 379, DateTimeKind.Utc).AddTicks(8395), 18L, "Aperiam labore officia architecto rerum quam dolores perferendis.", 1, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 66L, "Ea dolores nostrum sunt veritatis quidem dicta. Et architecto repudiandae. Saepe ea voluptate possimus molestiae a earum veritatis qui autem. Voluptas et et eos dolorum qui id a. Veniam sint at blanditiis est minus doloremque vel. Nesciunt quis quis fuga sed est eveniet sed qui voluptatum.", new DateTime(2023, 8, 24, 12, 16, 24, 513, DateTimeKind.Utc).AddTicks(9915), 9L, "Sit quas aliquam non eveniet in voluptates.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 22L, "Hic odit adipisci non natus veritatis labore.\nCorporis cumque ipsa.\nEt quas odio magni consequatur optio.", new DateTime(2023, 5, 17, 12, 11, 21, 599, DateTimeKind.Utc).AddTicks(3064), 26L, "Delectus voluptas repellat dolores laudantium cupiditate praesentium sed veniam.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution" },
                values: new object[] { 68L, "Incidunt reprehenderit ipsum eaque minima voluptatem autem.", new DateTime(2023, 3, 12, 15, 19, 46, 625, DateTimeKind.Utc).AddTicks(6261), 21L, "Doloremque rerum provident harum voluptates aliquam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 5L, "qui", new DateTime(2023, 5, 29, 0, 30, 26, 34, DateTimeKind.Utc).AddTicks(7546), 13L, "Ut aliquam sapiente dicta sit.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { 23L, "At voluptatibus quia porro nisi necessitatibus. Quam fugit quos. Similique unde culpa qui possimus minima dolorem facere. Laborum corrupti consequuntur optio modi commodi necessitatibus totam et.", new DateTime(2023, 8, 30, 0, 45, 10, 721, DateTimeKind.Utc).AddTicks(2583), 26L, "Eveniet cum non id sunt ab ea provident modi.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 4L, "cum", new DateTime(2022, 12, 7, 17, 16, 10, 721, DateTimeKind.Utc).AddTicks(5044), 3L, "Magni voluptatem molestias quisquam placeat consectetur.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 11L, "Excepturi ea quia tempora earum eos aut perferendis. Est dignissimos alias nam est vel. Est voluptatem enim vel error corporis et quaerat.", new DateTime(2019, 8, 1, 5, 42, 7, 88, DateTimeKind.Utc).AddTicks(7283), 5L, "Animi aliquam inventore aspernatur deleniti repellendus commodi at fuga dolores.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 63L, "consectetur", new DateTime(2022, 7, 24, 10, 53, 46, 864, DateTimeKind.Utc).AddTicks(31), 20L, "Perferendis quod placeat sed quos ipsam ut qui.", 2, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { 47L, "aut", new DateTime(2021, 6, 8, 18, 34, 15, 980, DateTimeKind.Utc).AddTicks(2709), 4L, "Vel dolor omnis.", 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 9L, "Fugit dolores atque eum.", new DateTime(2020, 8, 28, 2, 37, 29, 666, DateTimeKind.Utc).AddTicks(5832), 27L, "Sint et temporibus sapiente doloribus quod at possimus cumque.", 1, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { 39L, "Nam omnis quasi consequuntur.\nVeniam blanditiis voluptatem ut incidunt incidunt.\nVoluptatem magnam est repudiandae voluptas nobis.\nIllo est ratione.", new DateTime(2022, 2, 16, 5, 29, 26, 402, DateTimeKind.Utc).AddTicks(8802), 17L, "Facilis quia suscipit.", 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { "nobis", new DateTime(2023, 6, 16, 13, 46, 25, 463, DateTimeKind.Utc).AddTicks(7623), 38L, "Enim quo qui et molestiae animi consectetur voluptatibus et.", 4, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 9L, "Voluptatum voluptatem enim laborum quae consectetur dolor.\nDoloribus unde veritatis quod veniam porro repellat ut perferendis atque.\nVoluptatibus nam explicabo saepe.\nUnde perspiciatis ut.\nOfficia sint fugit tempore velit aut est nam natus.", new DateTime(2023, 4, 25, 6, 23, 22, 202, DateTimeKind.Utc).AddTicks(1588), 10L, "Iste cupiditate earum exercitationem qui consequatur et expedita molestias corrupti.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 9L, "Exercitationem quibusdam at.", new DateTime(2021, 10, 23, 2, 54, 11, 612, DateTimeKind.Utc).AddTicks(466), 3L, "Reiciendis aut omnis ducimus est et quam.", 2, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 18L, "Atque facere omnis non sint.\nAsperiores explicabo optio voluptatem.\nNihil odit autem in.\nVoluptatem sed ea commodi dolorum.", new DateTime(2022, 2, 14, 5, 14, 50, 298, DateTimeKind.Utc).AddTicks(8405), 20L, "Reiciendis qui quasi iusto reprehenderit ut ipsum quasi suscipit.", 4, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 25L, "Sunt at non.\nQuasi voluptate ratione.\nTempora est voluptas perferendis eos repudiandae aut et enim.\nQuod deserunt et aliquam.\nAutem cumque voluptatibus.\nSed fugiat quam sint laudantium error ex dolorem voluptate.", new DateTime(2023, 6, 19, 8, 1, 54, 160, DateTimeKind.Utc).AddTicks(4767), 9L, "Aut ad culpa ipsam placeat et.", 2, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 23L, "Soluta ut eius perspiciatis quo qui. Nemo sunt officia accusantium repellat aut magni et qui. Placeat qui voluptatum sapiente recusandae provident voluptas vitae ut. Neque tempora aut blanditiis. Quia maiores fugiat natus nisi.", new DateTime(2023, 8, 18, 10, 47, 11, 897, DateTimeKind.Utc).AddTicks(3052), 20L, "Veniam nulla numquam rem accusamus commodi.", 4, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution" },
                values: new object[] { 49L, "Dicta laborum eum.\nRem placeat quis.\nLaudantium accusamus harum libero beatae reiciendis.", new DateTime(2023, 7, 5, 5, 10, 8, 981, DateTimeKind.Utc).AddTicks(6024), 33L, "Dolorum quisquam nihil voluptatum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 27L, "Quia expedita dolores voluptatum illum quia accusantium nulla a quis. Dicta consectetur delectus ut blanditiis a dolorem. Modi corrupti aperiam facere et quam ipsa repudiandae aut amet. Ab omnis perferendis praesentium aliquam aut autem. At officiis hic nostrum.", new DateTime(2022, 7, 3, 4, 0, 48, 141, DateTimeKind.Utc).AddTicks(1881), 9L, "Odit aut nihil aut maiores.", 3, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 6L, "Dicta et voluptas illo est nostrum. Expedita eum labore a architecto qui impedit ut vitae et. Dicta enim velit nemo consequatur nisi non non est corrupti. Qui rerum deserunt quas. Ipsum ut provident.", new DateTime(2023, 7, 15, 2, 3, 52, 153, DateTimeKind.Utc).AddTicks(643), 2L, "Fuga delectus nulla neque.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 14L, "aut", new DateTime(2022, 12, 23, 22, 20, 17, 734, DateTimeKind.Utc).AddTicks(7399), 10L, "Qui aliquid eos eum et.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { "Optio ut rerum omnis cumque necessitatibus quas.", new DateTime(2023, 9, 2, 22, 17, 8, 835, DateTimeKind.Utc).AddTicks(4088), 9L, "Sed dolores nulla nulla occaecati molestiae et et aliquid.", 1, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { 5L, "Optio quisquam ut consequatur reprehenderit commodi eaque aliquam.", new DateTime(2023, 7, 14, 2, 21, 26, 889, DateTimeKind.Utc).AddTicks(8974), 9L, "Perspiciatis laboriosam ea.", 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 23L, "nam", new DateTime(2023, 8, 23, 2, 46, 0, 462, DateTimeKind.Utc).AddTicks(2241), 31L, "Maiores similique est saepe dignissimos sit ut ullam consequatur.", 4, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 62L, "Ratione minima excepturi dignissimos expedita dignissimos fuga commodi enim et.\nQuas vero ducimus.\nConsequatur laboriosam in ex ut qui culpa quae provident deleniti.", new DateTime(2023, 6, 3, 13, 15, 49, 169, DateTimeKind.Utc).AddTicks(8261), 5L, "Accusantium explicabo delectus expedita.", 4, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 45L, "illum", new DateTime(2023, 2, 23, 1, 18, 28, 755, DateTimeKind.Utc).AddTicks(9269), 16L, "Nisi ut et maxime.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 35L, "Aperiam maxime similique incidunt voluptatibus.\nEst error ipsa quaerat perspiciatis ullam nam ut inventore nihil.\nAmet iusto possimus iusto necessitatibus nulla aperiam dolorem aperiam.", new DateTime(2023, 5, 8, 11, 1, 18, 736, DateTimeKind.Utc).AddTicks(7465), "Aut dolores enim dignissimos minus et sunt.", 1, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 59L, "quia", new DateTime(2023, 4, 6, 21, 21, 21, 239, DateTimeKind.Utc).AddTicks(4894), 37L, "Debitis inventore ut.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { 60L, "Enim ut consectetur.", new DateTime(2021, 7, 24, 3, 37, 41, 688, DateTimeKind.Utc).AddTicks(469), 36L, "Ipsa repellat qui fugiat aperiam.", 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 25L, "Labore ducimus quam est alias alias non.", new DateTime(2022, 11, 24, 8, 52, 17, 673, DateTimeKind.Utc).AddTicks(1700), 34L, "Rerum facere ut.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 27L, "fugit", new DateTime(2022, 7, 22, 22, 18, 31, 124, DateTimeKind.Utc).AddTicks(3902), 4L, "Et eaque culpa sed quia aspernatur sed.", 4, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 28L, "tempora", new DateTime(2022, 12, 22, 10, 19, 51, 291, DateTimeKind.Utc).AddTicks(4196), 17L, "Accusamus saepe consectetur soluta rerum vel aut omnis.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 159L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { 9L, "exercitationem", new DateTime(2021, 6, 7, 5, 47, 6, 326, DateTimeKind.Utc).AddTicks(6914), 2L, "Distinctio omnis officia aspernatur dolores atque maxime in.", 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 28L, "Eos quo dolorum eum error non porro molestiae et inventore.", new DateTime(2022, 12, 17, 23, 47, 47, 298, DateTimeKind.Utc).AddTicks(5529), 25L, "Nulla rerum maiores blanditiis nemo nesciunt magni maxime repellat corrupti.", 1, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 8L, "Iure quas est.", new DateTime(2022, 2, 20, 21, 4, 15, 485, DateTimeKind.Utc).AddTicks(9697), 3L, "Provident soluta perferendis quia dolorem consequuntur perspiciatis et.", 4, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 162L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { 49L, "Quod animi nemo optio laborum voluptatum non ipsam rem. Voluptatem perferendis ipsum alias ea. Dolorem non dolor expedita tenetur eos. Vel quia quia reiciendis vitae.", new DateTime(2023, 8, 11, 3, 27, 16, 960, DateTimeKind.Utc).AddTicks(1281), 35L, "Nihil tempore ducimus natus voluptas voluptas.", 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 163L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 3L, "Aliquam libero ipsa explicabo et fugit. Facere fugiat animi ad. Occaecati quos dolores consequuntur adipisci repellendus et ullam exercitationem esse. In cum magni voluptatem. Voluptatem dolorem animi unde voluptas facere et.", new DateTime(2023, 8, 9, 15, 32, 0, 337, DateTimeKind.Utc).AddTicks(4612), 8L, "Debitis dolorem temporibus eligendi necessitatibus ipsum quidem repellendus sed.", 2, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 164L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { 41L, "Enim ipsam magni voluptas ut laudantium quam consequatur quibusdam.\nQui libero repellat est neque assumenda et.\nDicta ipsum mollitia qui.\nVoluptas dolores at accusantium consequatur a et itaque.", new DateTime(2022, 9, 11, 20, 27, 45, 161, DateTimeKind.Utc).AddTicks(7443), 12L, "Delectus sint ad omnis et quia in tempore.", 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 165L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 58L, "magnam", new DateTime(2022, 9, 26, 9, 44, 29, 240, DateTimeKind.Utc).AddTicks(9461), 17L, "Accusantium voluptas in id qui aut beatae.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { 51L, "Odio laborum voluptate officiis rerum numquam sunt voluptatem.", new DateTime(2023, 1, 25, 22, 48, 19, 583, DateTimeKind.Utc).AddTicks(4448), 25L, "Quam quam nesciunt ducimus tempore aut.", 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { 11L, "odit", new DateTime(2018, 12, 2, 8, 46, 15, 939, DateTimeKind.Utc).AddTicks(7280), 4L, "Error omnis itaque error sunt et in.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 12L, "iusto", new DateTime(2023, 8, 30, 11, 47, 58, 533, DateTimeKind.Utc).AddTicks(2501), 16L, "Eum est illum nobis beatae eos asperiores velit.", 1, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 5L, "Aspernatur aut ut quas vero est sit quia.\nBlanditiis dolorum rerum voluptas sint ut autem similique consequatur non.", new DateTime(2023, 8, 6, 7, 14, 35, 694, DateTimeKind.Utc).AddTicks(3112), 19L, "Ipsum inventore et vero vel.", 1, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { 23L, "corporis", new DateTime(2023, 8, 28, 5, 40, 40, 72, DateTimeKind.Utc).AddTicks(7907), 5L, "Nostrum reiciendis in.", 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution" },
                values: new object[] { 55L, "Provident quis perferendis culpa voluptatibus facilis perferendis expedita. Eum error placeat repellendus recusandae harum. Ullam veniam tempora sit. Rem beatae vel facilis officiis ipsum.", new DateTime(2023, 1, 22, 20, 28, 21, 729, DateTimeKind.Utc).AddTicks(2666), 4L, "Ut quos omnis veniam magnam eveniet incidunt libero possimus ipsa." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 32L, "Odit doloribus provident totam sapiente animi.", new DateTime(2023, 9, 2, 4, 22, 45, 279, DateTimeKind.Utc).AddTicks(4616), 29L, "Nobis et perferendis exercitationem id soluta blanditiis sunt.", 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 8L, "Officiis suscipit nemo sed.", new DateTime(2022, 9, 3, 15, 56, 2, 253, DateTimeKind.Utc).AddTicks(8602), 25L, "Inventore non sed recusandae odit.", 1, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { 18L, "voluptate", new DateTime(2021, 5, 12, 10, 31, 17, 648, DateTimeKind.Utc).AddTicks(224), 25L, "Id est omnis quasi aut ut qui.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 48L, "Neque quibusdam temporibus quas commodi soluta.", new DateTime(2023, 8, 18, 18, 57, 14, 886, DateTimeKind.Utc).AddTicks(2933), 7L, "Quibusdam aliquid mollitia aut explicabo aut sunt reiciendis.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 57L, "Et est porro doloribus perspiciatis. Facere nobis vel possimus. Doloremque autem aliquid harum consequatur quia aperiam est ipsa. Enim officia quisquam nesciunt qui harum dicta. Error quo voluptatibus officiis impedit quas dolorem.", new DateTime(2023, 3, 10, 20, 39, 12, 83, DateTimeKind.Utc).AddTicks(1955), 11L, "Ut dicta labore vel.", 2, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 45L, "expedita", new DateTime(2023, 7, 20, 1, 50, 1, 282, DateTimeKind.Utc).AddTicks(2860), 40L, "Dolorem sint dolores consequuntur eos vel harum ad et ut.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { 62L, "Temporibus sit et non odit. Qui aperiam officia illum qui ut et consequatur. Eius delectus accusamus aut ducimus aut et tempore rerum. Sint debitis ea delectus inventore delectus eum voluptates cumque.", new DateTime(2023, 3, 28, 14, 3, 28, 948, DateTimeKind.Utc).AddTicks(9392), 9L, "Animi libero dolor dolore ipsa omnis nesciunt vitae pariatur.", 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 59L, "Consequatur earum sed voluptatibus repellat sint reprehenderit ea. Atque impedit amet quibusdam modi et non at. Voluptas et consequatur rerum asperiores placeat laboriosam. Aperiam dolor sed saepe qui debitis. Velit aliquid accusantium itaque.", new DateTime(2023, 2, 27, 22, 12, 49, 931, DateTimeKind.Utc).AddTicks(1922), 13L, "Velit quibusdam tempora dolor numquam.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { 65L, "minus", new DateTime(2023, 7, 24, 17, 49, 54, 886, DateTimeKind.Utc).AddTicks(5648), 25L, "Id quas nisi iste.", 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { 18L, "Mollitia accusamus eaque. Accusamus temporibus suscipit quos laborum nam aliquam. Asperiores ut nulla dignissimos. Delectus dolores voluptatem eius suscipit incidunt beatae. Nisi quis odit explicabo ipsa blanditiis voluptatibus. Voluptas a voluptatem eligendi odit veritatis aut ad.", new DateTime(2020, 9, 20, 19, 18, 21, 994, DateTimeKind.Utc).AddTicks(704), 28L, "Quia hic quis facilis perspiciatis aut numquam sequi voluptas.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 40L, "Sapiente voluptatem cupiditate quas incidunt in sunt quia.", new DateTime(2023, 5, 15, 9, 57, 7, 988, DateTimeKind.Utc).AddTicks(9645), 38L, "Rerum eaque assumenda et et fuga similique quibusdam.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { 3L, "Quia iure et.\nAut provident cumque soluta qui.\nSed corporis quae.\nSoluta magnam quam.\nMaiores cumque molestias sit quaerat eveniet exercitationem.", new DateTime(2023, 8, 1, 10, 7, 33, 214, DateTimeKind.Utc).AddTicks(4846), 35L, "Qui ut voluptas maiores omnis dicta est eum odio.", 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 2L, "Labore pariatur voluptatem nemo.", new DateTime(2020, 6, 1, 1, 5, 40, 522, DateTimeKind.Utc).AddTicks(2523), 29L, "Fugiat vero nesciunt architecto sit omnis repudiandae.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 64L, "Dolores non vel sequi quas cumque dignissimos. Voluptatibus et cumque molestias sunt pariatur praesentium distinctio asperiores hic. Enim facilis suscipit assumenda nisi laborum optio.", new DateTime(2020, 2, 24, 7, 6, 5, 734, DateTimeKind.Utc).AddTicks(6010), 31L, "Sapiente aut impedit rerum error nemo magni.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution" },
                values: new object[] { 58L, "quisquam", new DateTime(2023, 2, 2, 15, 27, 52, 660, DateTimeKind.Utc).AddTicks(6022), 32L, "At hic quidem quo aperiam accusamus aut nam culpa." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 38L, "omnis", new DateTime(2023, 2, 6, 23, 32, 1, 350, DateTimeKind.Utc).AddTicks(2766), 24L, "Ut enim sit modi temporibus debitis.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 9L, "placeat", new DateTime(2022, 7, 8, 0, 50, 17, 807, DateTimeKind.Utc).AddTicks(1394), 35L, "Numquam ducimus ut expedita eos.", 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 41L, "Sunt veritatis architecto voluptatum tenetur error voluptas repellat dicta.\nPossimus quas blanditiis.\nEt et facilis id ad amet eaque ea aspernatur veniam.\nEveniet rerum eum ut ipsam aut animi.", new DateTime(2022, 1, 9, 23, 38, 43, 145, DateTimeKind.Utc).AddTicks(9688), 24L, "Laborum eos cupiditate nesciunt et ut molestiae.", 4, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 68L, "Ex magnam dolorum eligendi quam enim eum.", new DateTime(2023, 1, 21, 10, 49, 18, 683, DateTimeKind.Utc).AddTicks(1410), 38L, "Quibusdam veritatis et voluptatem omnis rerum fugiat aut.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 52L, "Et earum non iure necessitatibus culpa praesentium.\nOdio quos nisi accusantium et eligendi.\nSit corrupti placeat fugit harum minima.", new DateTime(2022, 2, 27, 12, 10, 52, 905, DateTimeKind.Utc).AddTicks(6252), 35L, "Earum explicabo est hic sequi placeat debitis.", 4, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 69L, "Nam quo facere quia.\nEarum harum quas laboriosam corrupti natus ad sint dignissimos beatae.", new DateTime(2023, 3, 6, 4, 39, 43, 959, DateTimeKind.Utc).AddTicks(7595), 6L, "Eligendi soluta commodi.", 3, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status" },
                values: new object[] { 70L, "Delectus sit officiis. Voluptatibus et aut animi consequatur atque magni earum quia dolor. Itaque laborum non voluptatem. Aut in provident culpa ex dolorum omnis odio. Aut inventore id similique velit. Rerum ipsa blanditiis aspernatur rerum repellat distinctio.", new DateTime(2023, 6, 16, 6, 25, 58, 94, DateTimeKind.Utc).AddTicks(887), 15L, "Nemo explicabo velit assumenda non fugiat sunt.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 52L, "Aut error quibusdam.\nEt ea aspernatur sed dolore.\nNihil reprehenderit autem repudiandae qui modi eveniet nesciunt.\nVoluptatem quo odio vitae ut eos doloribus pariatur sed.\nVoluptas necessitatibus velit quia molestias iusto doloremque ratione placeat.", new DateTime(2022, 9, 26, 10, 24, 43, 545, DateTimeKind.Utc).AddTicks(8842), 19L, "Animi deserunt eius.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 25L, "illum", new DateTime(2023, 1, 20, 1, 31, 34, 128, DateTimeKind.Utc).AddTicks(2061), 20L, "Sunt ab doloribus vero iusto autem eligendi.", 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 18L, "Aut enim et voluptatum omnis beatae ratione suscipit explicabo.", new DateTime(2023, 7, 26, 3, 28, 43, 88, DateTimeKind.Utc).AddTicks(6378), 19L, "Rerum excepturi error optio.", 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 64L, "Eum mollitia assumenda.", new DateTime(2022, 2, 24, 15, 44, 58, 317, DateTimeKind.Utc).AddTicks(7238), 36L, "Alias doloribus aspernatur.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 12L, "Consequuntur vel rerum ullam unde qui est debitis aspernatur. Voluptatem nostrum quasi quidem occaecati totam labore. Reiciendis esse quas impedit sunt alias. Natus voluptatem accusamus aliquam. Sunt est voluptate enim debitis est.", new DateTime(2023, 7, 16, 8, 44, 42, 98, DateTimeKind.Utc).AddTicks(8203), 5L, "Modi modi omnis recusandae.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 43L, "Esse consequatur aut odit maiores. At dolorum laborum esse quis rerum omnis. Voluptates aliquam architecto rerum debitis perspiciatis laborum et dolor.", new DateTime(2023, 8, 20, 9, 1, 13, 698, DateTimeKind.Utc).AddTicks(2621), 25L, "Inventore qui non deserunt occaecati unde cumque facere cupiditate cupiditate.", 2, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 32L, "Sed cupiditate sit.", new DateTime(2023, 8, 25, 23, 48, 29, 253, DateTimeKind.Utc).AddTicks(4307), 7L, "Delectus error vel voluptatem eaque praesentium et.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 20, 13, 25, 53, 296, DateTimeKind.Utc).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2018, 3, 14, 11, 22, 14, 411, DateTimeKind.Utc).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 15, 17, 43, 58, 851, DateTimeKind.Utc).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2022, 2, 28, 20, 53, 33, 977, DateTimeKind.Utc).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 17, 9, 46, 53, 117, DateTimeKind.Utc).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 16, 17, 3, 49, 31, DateTimeKind.Utc).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 4, 11, 29, 51, 159, DateTimeKind.Utc).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2017, 1, 15, 0, 24, 1, 295, DateTimeKind.Utc).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 3, 7, 3, 20, 533, DateTimeKind.Utc).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 28, 15, 16, 42, 504, DateTimeKind.Utc).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2018, 1, 12, 0, 43, 58, 79, DateTimeKind.Utc).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 6, 14, 32, 21, 527, DateTimeKind.Utc).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2017, 10, 21, 17, 30, 14, 135, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 10, 3, 50, 35, 938, DateTimeKind.Utc).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2018, 7, 12, 9, 9, 52, 977, DateTimeKind.Utc).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 14, 12, 16, 11, 598, DateTimeKind.Utc).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 13, 13, 43, 47, 745, DateTimeKind.Utc).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 15, 8, 55, 56, 311, DateTimeKind.Utc).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 19, 19, 55, 49, 134, DateTimeKind.Utc).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 19, 26, 14, 309, DateTimeKind.Utc).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 21, 37, 29, 346, DateTimeKind.Utc).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 22, 17, 9, 19, 686, DateTimeKind.Utc).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 16, 42, 30, 170, DateTimeKind.Utc).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 7, 6, 54, 7, 353, DateTimeKind.Utc).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 1, 3, 13, 34, 469, DateTimeKind.Utc).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 31, 19, 42, 4, 740, DateTimeKind.Utc).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 8, 12, 31, 19, 895, DateTimeKind.Utc).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTime(2022, 2, 8, 12, 49, 17, 509, DateTimeKind.Utc).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 23, 3, 5, 37, 965, DateTimeKind.Utc).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2017, 6, 30, 9, 37, 48, 952, DateTimeKind.Utc).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 5, 20, 14, 59, 549, DateTimeKind.Utc).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 2, 15, 4, 51, 376, DateTimeKind.Utc).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 8, 3, 53, 49, 759, DateTimeKind.Utc).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 16, 18, 39, 44, 537, DateTimeKind.Utc).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 6, 7, 56, 16, 79, DateTimeKind.Utc).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 28, 3, 22, 36, 460, DateTimeKind.Utc).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 23, 15, 24, 38, 270, DateTimeKind.Utc).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 15, 0, 41, 53, 598, DateTimeKind.Utc).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedAt",
                value: new DateTime(2022, 2, 8, 14, 53, 29, 873, DateTimeKind.Utc).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 10, 2, 21, 53, 873, DateTimeKind.Utc).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 27, 12, 11, 33, 908, DateTimeKind.Utc).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 31, 10, 39, 9, 833, DateTimeKind.Utc).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 7, 22, 46, 151, DateTimeKind.Utc).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedAt",
                value: new DateTime(2019, 2, 5, 12, 50, 6, 443, DateTimeKind.Utc).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 1, 21, 39, 7, 520, DateTimeKind.Utc).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 23, 19, 38, 19, 553, DateTimeKind.Utc).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 4, 6, 43, 4, 794, DateTimeKind.Utc).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 48L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 20, 7, 30, 260, DateTimeKind.Utc).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 9, 7, 28, 48, 227, DateTimeKind.Utc).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 17, 23, 43, 39, 243, DateTimeKind.Utc).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 42, 34, 286, DateTimeKind.Utc).AddTicks(68));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedAt",
                value: new DateTime(2022, 1, 26, 2, 0, 31, 894, DateTimeKind.Utc).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedAt",
                value: new DateTime(2019, 4, 9, 19, 11, 10, 685, DateTimeKind.Utc).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 16, 23, 16, 49, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 16, 23, 35, 18, 593, DateTimeKind.Utc).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 56L,
                column: "CreatedAt",
                value: new DateTime(2018, 4, 20, 23, 5, 21, 835, DateTimeKind.Utc).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 9, 5, 0, 186, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 16, 22, 37, 24, 871, DateTimeKind.Utc).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 12, 7, 25, 28, 322, DateTimeKind.Utc).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedAt",
                value: new DateTime(2019, 2, 22, 17, 8, 9, 172, DateTimeKind.Utc).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 22, 3, 35, 26, 508, DateTimeKind.Utc).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 29, 5, 6, 4, 213, DateTimeKind.Utc).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 12, 11, 47, 5, 817, DateTimeKind.Utc).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 64L,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 18, 3, 36, 46, 747, DateTimeKind.Utc).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 15, 3, 42, 8, 354, DateTimeKind.Utc).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 25, 18, 46, 17, 718, DateTimeKind.Utc).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 2, 9, 55, 34, 258, DateTimeKind.Utc).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 8, 8, 26, 21, 586, DateTimeKind.Utc).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 18, 1, 7, 661, DateTimeKind.Utc).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 19, 12, 4, 41, 907, DateTimeKind.Utc).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 15, 2, 22, 38, 338, DateTimeKind.Utc).AddTicks(6376), new DateTime(2023, 7, 13, 11, 13, 11, 579, DateTimeKind.Utc).AddTicks(5459), new DateTime(2022, 8, 9, 14, 51, 55, 640, DateTimeKind.Utc).AddTicks(2214), new DateTime(2023, 7, 15, 18, 39, 17, 974, DateTimeKind.Utc).AddTicks(1174) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 5, 29, 13, 191, DateTimeKind.Utc).AddTicks(5687), new DateTime(2023, 7, 24, 20, 7, 18, 67, DateTimeKind.Utc).AddTicks(1635), new DateTime(2023, 1, 16, 22, 22, 24, 226, DateTimeKind.Utc).AddTicks(6051), new DateTime(2023, 2, 1, 16, 45, 22, 360, DateTimeKind.Utc).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 3, 20, 44, 10, 97, DateTimeKind.Utc).AddTicks(2999), new DateTime(2023, 7, 22, 15, 51, 37, 331, DateTimeKind.Utc).AddTicks(2234), new DateTime(2023, 5, 5, 7, 35, 34, 340, DateTimeKind.Utc).AddTicks(5484), new DateTime(2023, 7, 16, 1, 8, 19, 726, DateTimeKind.Utc).AddTicks(7392) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 1, 9, 4, 21, 24, 936, DateTimeKind.Utc).AddTicks(2273), new DateTime(2022, 5, 27, 16, 17, 46, 473, DateTimeKind.Utc).AddTicks(5417), new DateTime(2021, 7, 28, 18, 39, 14, 483, DateTimeKind.Utc).AddTicks(2667), new DateTime(2022, 8, 8, 3, 47, 26, 301, DateTimeKind.Utc).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 6, 21, 17, 18, 474, DateTimeKind.Utc).AddTicks(4179), new DateTime(2023, 5, 1, 20, 22, 51, 667, DateTimeKind.Utc).AddTicks(2715), new DateTime(2022, 10, 25, 5, 33, 22, 805, DateTimeKind.Utc).AddTicks(7776), new DateTime(2023, 8, 9, 12, 37, 12, 44, DateTimeKind.Utc).AddTicks(9259) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 9, 10, 1, 1, 18, 592, DateTimeKind.Utc).AddTicks(4638), new DateTime(2021, 4, 7, 8, 13, 7, 346, DateTimeKind.Utc).AddTicks(110), new DateTime(2018, 12, 14, 12, 7, 29, 719, DateTimeKind.Utc).AddTicks(5810), new DateTime(2019, 12, 26, 15, 24, 48, 14, DateTimeKind.Utc).AddTicks(3471) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 2, 17, 11, 2, 16, 777, DateTimeKind.Utc).AddTicks(1179), new DateTime(2023, 1, 24, 22, 27, 47, 56, DateTimeKind.Utc).AddTicks(4784), new DateTime(2020, 4, 19, 18, 30, 47, 978, DateTimeKind.Utc).AddTicks(4370), new DateTime(2021, 1, 20, 3, 16, 32, 506, DateTimeKind.Utc).AddTicks(6997) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 10, 12, 15, 19, 26, 40, DateTimeKind.Utc).AddTicks(7223), new DateTime(2022, 8, 21, 9, 20, 30, 698, DateTimeKind.Utc).AddTicks(4183), new DateTime(2021, 5, 2, 22, 0, 58, 457, DateTimeKind.Utc).AddTicks(283), new DateTime(2021, 7, 14, 0, 57, 23, 845, DateTimeKind.Utc).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 5, 20, 20, 33, 51, 739, DateTimeKind.Utc).AddTicks(511), new DateTime(2023, 5, 21, 19, 34, 9, 101, DateTimeKind.Utc).AddTicks(3505), new DateTime(2021, 5, 29, 8, 23, 7, 395, DateTimeKind.Utc).AddTicks(2553), new DateTime(2022, 4, 27, 7, 54, 49, 812, DateTimeKind.Utc).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 12, 23, 22, 491, DateTimeKind.Utc).AddTicks(1159), new DateTime(2022, 3, 16, 16, 49, 0, 920, DateTimeKind.Utc).AddTicks(8664), new DateTime(2021, 3, 10, 0, 59, 54, 582, DateTimeKind.Utc).AddTicks(4694), new DateTime(2022, 11, 29, 19, 1, 31, 710, DateTimeKind.Utc).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 23, 3, 51, 13, 55, DateTimeKind.Utc).AddTicks(1903), new DateTime(2023, 4, 4, 21, 55, 17, 733, DateTimeKind.Utc).AddTicks(8773), new DateTime(2023, 1, 8, 0, 49, 30, 600, DateTimeKind.Utc).AddTicks(337), new DateTime(2023, 2, 11, 11, 34, 38, 736, DateTimeKind.Utc).AddTicks(2581) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 13, 10, 7, 19, 336, DateTimeKind.Utc).AddTicks(6257), new DateTime(2022, 12, 11, 15, 25, 15, 427, DateTimeKind.Utc).AddTicks(7334), new DateTime(2022, 9, 16, 20, 34, 16, 785, DateTimeKind.Utc).AddTicks(7541), new DateTime(2023, 8, 6, 21, 40, 50, 873, DateTimeKind.Utc).AddTicks(6891) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 13, 1, 19, 27, 155, DateTimeKind.Utc).AddTicks(7677), new DateTime(2023, 9, 4, 3, 45, 28, 842, DateTimeKind.Utc).AddTicks(3457), new DateTime(2023, 4, 13, 6, 39, 21, 545, DateTimeKind.Utc).AddTicks(4536), new DateTime(2023, 8, 25, 21, 43, 28, 57, DateTimeKind.Utc).AddTicks(6187) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 5, 21, 23, 39, 32, 658, DateTimeKind.Utc).AddTicks(205), new DateTime(2020, 7, 24, 8, 47, 26, 240, DateTimeKind.Utc).AddTicks(5003), new DateTime(2019, 11, 10, 0, 13, 46, 326, DateTimeKind.Utc).AddTicks(3064), new DateTime(2022, 10, 20, 9, 29, 7, 270, DateTimeKind.Utc).AddTicks(384) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 8, 30, 0, 57, 52, 772, DateTimeKind.Utc).AddTicks(6721), new DateTime(2022, 8, 9, 10, 1, 45, 602, DateTimeKind.Utc).AddTicks(6053), new DateTime(2021, 3, 28, 9, 42, 50, 272, DateTimeKind.Utc).AddTicks(9399), new DateTime(2023, 7, 2, 16, 6, 24, 482, DateTimeKind.Utc).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 4, 6, 33, 31, 886, DateTimeKind.Utc).AddTicks(4030), new DateTime(2023, 8, 14, 22, 41, 2, 508, DateTimeKind.Utc).AddTicks(722), new DateTime(2023, 2, 13, 2, 24, 44, 403, DateTimeKind.Utc).AddTicks(5101) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 1, 21, 11, 15, 5, 848, DateTimeKind.Utc).AddTicks(6488), new DateTime(2020, 12, 1, 9, 50, 57, 82, DateTimeKind.Utc).AddTicks(3076), new DateTime(2019, 1, 16, 13, 13, 10, 223, DateTimeKind.Utc).AddTicks(6368), new DateTime(2020, 8, 17, 9, 21, 14, 760, DateTimeKind.Utc).AddTicks(4685) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 14, 1, 705, DateTimeKind.Utc).AddTicks(1340), new DateTime(2023, 7, 28, 5, 36, 54, 242, DateTimeKind.Utc).AddTicks(5049), new DateTime(2020, 12, 21, 17, 1, 16, 218, DateTimeKind.Utc).AddTicks(8020), new DateTime(2021, 11, 27, 4, 43, 40, 789, DateTimeKind.Utc).AddTicks(6390) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 31, 12, 32, 21, 64, DateTimeKind.Utc).AddTicks(1392), new DateTime(2023, 6, 29, 13, 57, 23, 479, DateTimeKind.Utc).AddTicks(5155), new DateTime(2023, 6, 18, 21, 59, 25, 86, DateTimeKind.Utc).AddTicks(3687), new DateTime(2023, 7, 15, 7, 5, 6, 373, DateTimeKind.Utc).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 3, 23, 4, 24, 36, 557, DateTimeKind.Utc).AddTicks(9273), new DateTime(2020, 2, 23, 18, 22, 11, 68, DateTimeKind.Utc).AddTicks(6708), new DateTime(2019, 11, 24, 0, 50, 24, 873, DateTimeKind.Utc).AddTicks(288), new DateTime(2022, 3, 6, 15, 34, 38, 95, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 30, 18, 35, 20, 159, DateTimeKind.Utc).AddTicks(4522), new DateTime(2023, 5, 24, 20, 48, 16, 161, DateTimeKind.Utc).AddTicks(6976), new DateTime(2022, 2, 26, 21, 18, 52, 373, DateTimeKind.Utc).AddTicks(4679), new DateTime(2023, 6, 10, 21, 50, 44, 311, DateTimeKind.Utc).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 5, 8, 17, 15, 386, DateTimeKind.Utc).AddTicks(8907), new DateTime(2023, 4, 27, 13, 0, 14, 720, DateTimeKind.Utc).AddTicks(3500), new DateTime(2019, 12, 12, 1, 8, 2, 416, DateTimeKind.Utc).AddTicks(8894), new DateTime(2022, 5, 9, 6, 53, 0, 952, DateTimeKind.Utc).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 3, 23, 8, 35, 42, 116, DateTimeKind.Utc).AddTicks(9687), new DateTime(2020, 3, 17, 22, 12, 20, 183, DateTimeKind.Utc).AddTicks(2291), new DateTime(2017, 7, 18, 11, 53, 32, 173, DateTimeKind.Utc).AddTicks(3405), new DateTime(2023, 8, 25, 4, 35, 1, 25, DateTimeKind.Utc).AddTicks(4511) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 5, 20, 19, 10, 3, 176, DateTimeKind.Utc).AddTicks(5678), new DateTime(2019, 7, 30, 7, 40, 48, 187, DateTimeKind.Utc).AddTicks(6234), new DateTime(2019, 3, 28, 14, 19, 15, 403, DateTimeKind.Utc).AddTicks(6134), new DateTime(2020, 9, 15, 0, 4, 35, 649, DateTimeKind.Utc).AddTicks(1793) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 20, 1, 34, 137, DateTimeKind.Utc).AddTicks(7886), new DateTime(2023, 3, 29, 18, 38, 49, 532, DateTimeKind.Utc).AddTicks(3670), new DateTime(2021, 4, 8, 0, 3, 42, 549, DateTimeKind.Utc).AddTicks(8055), new DateTime(2022, 4, 4, 11, 7, 17, 651, DateTimeKind.Utc).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 19, 18, 35, 45, 539, DateTimeKind.Utc).AddTicks(8298), new DateTime(2023, 5, 9, 14, 27, 46, 558, DateTimeKind.Utc).AddTicks(4069), new DateTime(2023, 2, 7, 6, 58, 4, 292, DateTimeKind.Utc).AddTicks(9257), new DateTime(2023, 3, 28, 5, 45, 1, 925, DateTimeKind.Utc).AddTicks(416) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2023, 2, 15, 16, 11, 12, 916, DateTimeKind.Utc).AddTicks(6701), new DateTime(2022, 12, 20, 2, 23, 28, 161, DateTimeKind.Utc).AddTicks(6498), new DateTime(2022, 6, 29, 15, 15, 9, 659, DateTimeKind.Utc).AddTicks(7535) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 10, 4, 4, 562, DateTimeKind.Utc).AddTicks(763), new DateTime(2023, 5, 21, 4, 11, 33, 221, DateTimeKind.Utc).AddTicks(9141), new DateTime(2023, 3, 20, 7, 51, 32, 803, DateTimeKind.Utc).AddTicks(7225), new DateTime(2023, 8, 7, 7, 13, 56, 632, DateTimeKind.Utc).AddTicks(7311) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 16, 17, 46, 34, 566, DateTimeKind.Utc).AddTicks(3893), new DateTime(2023, 3, 29, 6, 31, 19, 986, DateTimeKind.Utc).AddTicks(4857), new DateTime(2023, 2, 19, 15, 7, 58, 712, DateTimeKind.Utc).AddTicks(181), new DateTime(2023, 7, 9, 14, 32, 27, 942, DateTimeKind.Utc).AddTicks(6799) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 5, 17, 49, 36, 956, DateTimeKind.Utc).AddTicks(475), new DateTime(2023, 7, 14, 18, 31, 32, 157, DateTimeKind.Utc).AddTicks(1315), new DateTime(2021, 8, 1, 0, 22, 23, 219, DateTimeKind.Utc).AddTicks(5429), new DateTime(2022, 6, 18, 13, 21, 53, 75, DateTimeKind.Utc).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 8, 2, 12, 15, 4, 342, DateTimeKind.Utc).AddTicks(5012), new DateTime(2023, 8, 14, 17, 26, 47, 969, DateTimeKind.Utc).AddTicks(25), new DateTime(2023, 8, 10, 17, 1, 30, 822, DateTimeKind.Utc).AddTicks(9622), new DateTime(2023, 8, 23, 7, 42, 4, 854, DateTimeKind.Utc).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 6, 1, 41, 54, 238, DateTimeKind.Utc).AddTicks(7730), new DateTime(2022, 3, 28, 4, 4, 13, 746, DateTimeKind.Utc).AddTicks(9141), new DateTime(2022, 2, 4, 13, 52, 3, 124, DateTimeKind.Utc).AddTicks(3245), new DateTime(2023, 6, 26, 6, 5, 21, 610, DateTimeKind.Utc).AddTicks(8566) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 8, 28, 12, 28, 17, 742, DateTimeKind.Utc).AddTicks(4093), new DateTime(2022, 6, 18, 7, 0, 25, 967, DateTimeKind.Utc).AddTicks(6686), new DateTime(2019, 6, 12, 8, 2, 34, 150, DateTimeKind.Utc).AddTicks(9176), new DateTime(2019, 8, 21, 3, 20, 10, 682, DateTimeKind.Utc).AddTicks(8641) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 12, 22, 29, 2, 182, DateTimeKind.Utc).AddTicks(3430), new DateTime(2023, 8, 27, 1, 45, 24, 746, DateTimeKind.Utc).AddTicks(8038), new DateTime(2022, 8, 12, 18, 49, 59, 755, DateTimeKind.Utc).AddTicks(3773), new DateTime(2022, 9, 10, 9, 48, 26, 661, DateTimeKind.Utc).AddTicks(9322) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2019, 11, 29, 10, 48, 33, 523, DateTimeKind.Utc).AddTicks(7748), new DateTime(2019, 10, 25, 0, 17, 38, 918, DateTimeKind.Utc).AddTicks(9035), new DateTime(2018, 8, 2, 0, 13, 11, 196, DateTimeKind.Utc).AddTicks(2482), new DateTime(2021, 3, 15, 11, 12, 20, 599, DateTimeKind.Utc).AddTicks(3465) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 10, 47, 15, 361, DateTimeKind.Utc).AddTicks(5016), new DateTime(2021, 11, 18, 18, 27, 32, 311, DateTimeKind.Utc).AddTicks(8997), new DateTime(2021, 4, 5, 11, 46, 33, 910, DateTimeKind.Utc).AddTicks(2589), new DateTime(2021, 12, 3, 5, 5, 41, 241, DateTimeKind.Utc).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 11, 34, 13, 759, DateTimeKind.Utc).AddTicks(9788), new DateTime(2023, 4, 1, 0, 31, 35, 356, DateTimeKind.Utc).AddTicks(2999), new DateTime(2022, 7, 4, 6, 12, 38, 185, DateTimeKind.Utc).AddTicks(4200), new DateTime(2023, 4, 13, 17, 37, 43, 792, DateTimeKind.Utc).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 17, 44, 30, 978, DateTimeKind.Utc).AddTicks(1121), new DateTime(2023, 8, 12, 5, 31, 48, 305, DateTimeKind.Utc).AddTicks(4632), new DateTime(2023, 6, 21, 9, 37, 7, 886, DateTimeKind.Utc).AddTicks(8378), new DateTime(2023, 8, 18, 0, 30, 40, 973, DateTimeKind.Utc).AddTicks(4136) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 18, 23, 39, 19, 324, DateTimeKind.Utc).AddTicks(9383), new DateTime(2023, 6, 22, 17, 31, 40, 676, DateTimeKind.Utc).AddTicks(7217), new DateTime(2023, 5, 17, 19, 58, 42, 61, DateTimeKind.Utc).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 24, 5, 13, 57, 837, DateTimeKind.Utc).AddTicks(8143), new DateTime(2022, 7, 4, 19, 25, 56, 405, DateTimeKind.Utc).AddTicks(7906), new DateTime(2020, 12, 14, 3, 3, 13, 334, DateTimeKind.Utc).AddTicks(924), new DateTime(2022, 8, 2, 17, 38, 21, 88, DateTimeKind.Utc).AddTicks(5135) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 12, 25, 4, 14, 26, 3, DateTimeKind.Utc).AddTicks(433), new DateTime(2020, 1, 22, 13, 25, 48, 5, DateTimeKind.Utc).AddTicks(7164), new DateTime(2019, 11, 26, 7, 5, 47, 692, DateTimeKind.Utc).AddTicks(3340), new DateTime(2023, 6, 6, 20, 48, 5, 134, DateTimeKind.Utc).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 5, 16, 21, 48, 41, 335, DateTimeKind.Utc).AddTicks(482), new DateTime(2023, 7, 10, 9, 15, 19, 936, DateTimeKind.Utc).AddTicks(4682), new DateTime(2020, 6, 3, 10, 34, 15, 252, DateTimeKind.Utc).AddTicks(2902), new DateTime(2020, 10, 30, 15, 38, 18, 213, DateTimeKind.Utc).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 19, 16, 0, 13, 193, DateTimeKind.Utc).AddTicks(8172), new DateTime(2023, 8, 14, 18, 35, 25, 354, DateTimeKind.Utc).AddTicks(542), new DateTime(2023, 7, 31, 11, 35, 58, 89, DateTimeKind.Utc).AddTicks(8014), new DateTime(2023, 8, 29, 19, 40, 5, 558, DateTimeKind.Utc).AddTicks(7775) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 23, 7, 11, 18, 602, DateTimeKind.Utc).AddTicks(8031), new DateTime(2023, 8, 10, 1, 14, 51, 437, DateTimeKind.Utc).AddTicks(4062), new DateTime(2023, 6, 25, 23, 58, 11, 358, DateTimeKind.Utc).AddTicks(2599), new DateTime(2023, 7, 20, 19, 2, 12, 356, DateTimeKind.Utc).AddTicks(2416) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 3, 20, 50, 9, 81, DateTimeKind.Utc).AddTicks(8381), new DateTime(2023, 4, 19, 9, 0, 26, 795, DateTimeKind.Utc).AddTicks(3054), new DateTime(2022, 9, 11, 11, 31, 9, 352, DateTimeKind.Utc).AddTicks(1793), new DateTime(2023, 3, 15, 23, 31, 42, 563, DateTimeKind.Utc).AddTicks(8679) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 13, 20, 13, 54, 962, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 2, 9, 14, 7, 40, 980, DateTimeKind.Utc).AddTicks(2318), new DateTime(2020, 6, 10, 12, 5, 11, 548, DateTimeKind.Utc).AddTicks(9173), new DateTime(2021, 11, 18, 8, 5, 29, 396, DateTimeKind.Utc).AddTicks(3878) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 5, 15, 20, 30, 50, 969, DateTimeKind.Utc).AddTicks(6568), new DateTime(2023, 8, 23, 8, 40, 55, 2, DateTimeKind.Utc).AddTicks(3293), new DateTime(2023, 4, 10, 3, 52, 34, 647, DateTimeKind.Utc).AddTicks(3667), new DateTime(2023, 8, 6, 0, 1, 53, 183, DateTimeKind.Utc).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 6, 29, 3, 54, 43, 824, DateTimeKind.Utc).AddTicks(2114), new DateTime(2021, 12, 8, 3, 32, 18, 63, DateTimeKind.Utc).AddTicks(6969), new DateTime(2020, 1, 1, 8, 12, 53, 123, DateTimeKind.Utc).AddTicks(6247), new DateTime(2021, 2, 18, 13, 21, 14, 356, DateTimeKind.Utc).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 6, 14, 5, 33, 48, 627, DateTimeKind.Utc).AddTicks(4807), new DateTime(2023, 8, 23, 8, 34, 40, 986, DateTimeKind.Utc).AddTicks(3247), new DateTime(2023, 3, 29, 10, 57, 47, 903, DateTimeKind.Utc).AddTicks(4496), new DateTime(2023, 8, 19, 19, 50, 4, 971, DateTimeKind.Utc).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2021, 8, 9, 4, 56, 31, 912, DateTimeKind.Utc).AddTicks(3915), new DateTime(2021, 6, 26, 5, 52, 36, 76, DateTimeKind.Utc).AddTicks(7246), new DateTime(2020, 3, 2, 20, 22, 21, 311, DateTimeKind.Utc).AddTicks(4224) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 4, 24, 18, 48, 58, 367, DateTimeKind.Utc).AddTicks(8849), new DateTime(2021, 5, 8, 12, 22, 23, 59, DateTimeKind.Utc).AddTicks(457), new DateTime(2019, 10, 27, 15, 8, 4, 967, DateTimeKind.Utc).AddTicks(4385), new DateTime(2023, 2, 10, 19, 47, 24, 765, DateTimeKind.Utc).AddTicks(4578) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 11, 21, 25, 5, 631, DateTimeKind.Utc).AddTicks(385), new DateTime(2023, 8, 1, 7, 12, 9, 850, DateTimeKind.Utc).AddTicks(150), new DateTime(2023, 6, 30, 9, 8, 40, 704, DateTimeKind.Utc).AddTicks(6034), new DateTime(2023, 7, 26, 16, 13, 36, 839, DateTimeKind.Utc).AddTicks(6746) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 4, 19, 9, 47, 558, DateTimeKind.Utc).AddTicks(1488), new DateTime(2023, 7, 30, 11, 50, 54, 55, DateTimeKind.Utc).AddTicks(5876), new DateTime(2022, 3, 19, 7, 50, 19, 848, DateTimeKind.Utc).AddTicks(5693), new DateTime(2022, 4, 7, 13, 3, 57, 84, DateTimeKind.Utc).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 3, 20, 12, 12, 9, 988, DateTimeKind.Utc).AddTicks(3893), new DateTime(2022, 9, 5, 0, 4, 12, 462, DateTimeKind.Utc).AddTicks(5342), new DateTime(2021, 10, 16, 1, 47, 48, 29, DateTimeKind.Utc).AddTicks(7071), new DateTime(2022, 4, 7, 20, 54, 4, 108, DateTimeKind.Utc).AddTicks(9537) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 1, 14, 1, 9, 49, 471, DateTimeKind.Utc).AddTicks(6995), new DateTime(2022, 9, 17, 0, 37, 10, 554, DateTimeKind.Utc).AddTicks(8646), new DateTime(2022, 8, 2, 6, 15, 46, 89, DateTimeKind.Utc).AddTicks(316), new DateTime(2023, 7, 29, 0, 12, 27, 812, DateTimeKind.Utc).AddTicks(194) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 28, 8, 36, 29, 778, DateTimeKind.Utc).AddTicks(2486), new DateTime(2023, 9, 3, 21, 52, 57, 536, DateTimeKind.Utc).AddTicks(9714), new DateTime(2023, 7, 2, 2, 23, 16, 153, DateTimeKind.Utc).AddTicks(7411), new DateTime(2023, 7, 9, 13, 26, 58, 232, DateTimeKind.Utc).AddTicks(2969) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 10, 28, 17, 48, 9, 881, DateTimeKind.Utc).AddTicks(4852), new DateTime(2022, 9, 12, 22, 17, 58, 34, DateTimeKind.Utc).AddTicks(7656), new DateTime(2022, 6, 3, 20, 34, 28, 401, DateTimeKind.Utc).AddTicks(3714), new DateTime(2022, 12, 6, 9, 47, 41, 154, DateTimeKind.Utc).AddTicks(1089) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 23, 22, 18, 21, 428, DateTimeKind.Utc).AddTicks(6732), new DateTime(2023, 3, 7, 17, 44, 13, 585, DateTimeKind.Utc).AddTicks(5922), new DateTime(2023, 2, 12, 2, 13, 28, 247, DateTimeKind.Utc).AddTicks(1554), new DateTime(2023, 4, 28, 9, 9, 57, 471, DateTimeKind.Utc).AddTicks(8335) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 5, 3, 1, 2, 967, DateTimeKind.Utc).AddTicks(8419), new DateTime(2022, 11, 25, 18, 29, 46, 944, DateTimeKind.Utc).AddTicks(8376), new DateTime(2017, 4, 18, 4, 16, 46, 468, DateTimeKind.Utc).AddTicks(1478), new DateTime(2023, 7, 8, 15, 23, 33, 13, DateTimeKind.Utc).AddTicks(6351) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 16, 16, 10, 37, 974, DateTimeKind.Utc).AddTicks(8218), new DateTime(2023, 1, 9, 1, 58, 46, 786, DateTimeKind.Utc).AddTicks(9302), new DateTime(2022, 10, 26, 2, 16, 53, 89, DateTimeKind.Utc).AddTicks(3456), new DateTime(2023, 3, 8, 15, 7, 50, 804, DateTimeKind.Utc).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 3, 28, 22, 31, 34, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2022, 8, 16, 17, 14, 40, 176, DateTimeKind.Utc).AddTicks(7518), new DateTime(2021, 10, 6, 5, 21, 56, 787, DateTimeKind.Utc).AddTicks(9986), new DateTime(2023, 3, 29, 1, 47, 32, 721, DateTimeKind.Utc).AddTicks(4746) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 8, 2, 22, 20, 40, 207, DateTimeKind.Utc).AddTicks(9259), new DateTime(2023, 3, 23, 23, 20, 32, 685, DateTimeKind.Utc).AddTicks(9674), new DateTime(2019, 11, 1, 9, 46, 4, 732, DateTimeKind.Utc).AddTicks(1204), new DateTime(2020, 8, 22, 16, 35, 12, 124, DateTimeKind.Utc).AddTicks(5978) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 17, 2, 23, 987, DateTimeKind.Utc).AddTicks(1644), new DateTime(2023, 5, 9, 2, 39, 31, 99, DateTimeKind.Utc).AddTicks(4216), new DateTime(2022, 2, 25, 0, 47, 46, 89, DateTimeKind.Utc).AddTicks(1195), new DateTime(2022, 7, 7, 22, 30, 39, 613, DateTimeKind.Utc).AddTicks(9202) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 21, 7, 45, 21, 826, DateTimeKind.Utc).AddTicks(8743), new DateTime(2022, 10, 22, 13, 13, 53, 691, DateTimeKind.Utc).AddTicks(2789), new DateTime(2022, 5, 27, 15, 39, 28, 960, DateTimeKind.Utc).AddTicks(5620), new DateTime(2023, 4, 5, 6, 0, 50, 482, DateTimeKind.Utc).AddTicks(166) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 6, 2, 16, 35, 16, 67, DateTimeKind.Utc).AddTicks(7200), new DateTime(2021, 8, 5, 1, 29, 47, 330, DateTimeKind.Utc).AddTicks(692), new DateTime(2021, 6, 18, 12, 11, 2, 138, DateTimeKind.Utc).AddTicks(5934), new DateTime(2022, 3, 31, 9, 1, 15, 613, DateTimeKind.Utc).AddTicks(2598) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 3, 23, 19, 49, 924, DateTimeKind.Utc).AddTicks(1226), new DateTime(2023, 8, 27, 22, 12, 51, 48, DateTimeKind.Utc).AddTicks(9167), new DateTime(2019, 3, 22, 17, 53, 1, 717, DateTimeKind.Utc).AddTicks(7508), new DateTime(2020, 11, 11, 9, 19, 20, 244, DateTimeKind.Utc).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 27, 5, 15, 26, 220, DateTimeKind.Utc).AddTicks(3377), new DateTime(2022, 10, 19, 2, 56, 40, 635, DateTimeKind.Utc).AddTicks(3574), new DateTime(2022, 6, 10, 9, 11, 20, 442, DateTimeKind.Utc).AddTicks(1378), new DateTime(2022, 12, 15, 7, 1, 52, 753, DateTimeKind.Utc).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2018, 4, 3, 8, 33, 51, 105, DateTimeKind.Utc).AddTicks(888), new DateTime(2018, 3, 17, 6, 48, 53, 582, DateTimeKind.Utc).AddTicks(9776), new DateTime(2017, 9, 18, 7, 36, 20, 291, DateTimeKind.Utc).AddTicks(3990), new DateTime(2019, 7, 8, 14, 36, 19, 877, DateTimeKind.Utc).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 7, 26, 3, 56, 23, 514, DateTimeKind.Utc).AddTicks(2147), new DateTime(2023, 7, 30, 15, 9, 55, 531, DateTimeKind.Utc).AddTicks(6892), new DateTime(2023, 6, 28, 11, 37, 38, 700, DateTimeKind.Utc).AddTicks(6678), new DateTime(2023, 7, 4, 4, 49, 49, 56, DateTimeKind.Utc).AddTicks(7623) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 16, 25, 54, 173, DateTimeKind.Utc).AddTicks(5978), new DateTime(2023, 1, 16, 18, 42, 5, 936, DateTimeKind.Utc).AddTicks(2781), new DateTime(2021, 7, 1, 9, 18, 17, 229, DateTimeKind.Utc).AddTicks(6004), new DateTime(2022, 10, 28, 4, 9, 3, 567, DateTimeKind.Utc).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 3, 16, 1, 48, 56, 260, DateTimeKind.Utc).AddTicks(5214), new DateTime(2022, 2, 19, 23, 14, 38, 500, DateTimeKind.Utc).AddTicks(7538), new DateTime(2021, 10, 25, 20, 10, 32, 953, DateTimeKind.Utc).AddTicks(8167), new DateTime(2023, 1, 31, 10, 18, 57, 539, DateTimeKind.Utc).AddTicks(9326) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 18, 22, 3, 58, 811, DateTimeKind.Utc).AddTicks(290), new DateTime(2023, 4, 21, 13, 49, 51, 241, DateTimeKind.Utc).AddTicks(9519), new DateTime(2022, 10, 6, 19, 48, 17, 668, DateTimeKind.Utc).AddTicks(3666), new DateTime(2023, 8, 18, 7, 2, 55, 203, DateTimeKind.Utc).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 28, 4, 12, 37, 672, DateTimeKind.Utc).AddTicks(124), new DateTime(2023, 8, 10, 9, 0, 36, 674, DateTimeKind.Utc).AddTicks(6169), new DateTime(2022, 3, 5, 15, 41, 50, 338, DateTimeKind.Utc).AddTicks(9383), new DateTime(2022, 8, 19, 13, 18, 45, 59, DateTimeKind.Utc).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 31, 11, 12, 47, 706, DateTimeKind.Utc).AddTicks(9533), new DateTime(2023, 6, 19, 0, 2, 51, 491, DateTimeKind.Utc).AddTicks(8087), new DateTime(2021, 7, 3, 8, 10, 54, 170, DateTimeKind.Utc).AddTicks(9668), new DateTime(2021, 12, 6, 18, 48, 39, 842, DateTimeKind.Utc).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 28, 10, 10, 16, 294, DateTimeKind.Utc).AddTicks(7808), new DateTime(2023, 8, 10, 19, 6, 43, 122, DateTimeKind.Utc).AddTicks(635), new DateTime(2023, 6, 27, 23, 16, 1, 260, DateTimeKind.Utc).AddTicks(6258), new DateTime(2023, 8, 29, 14, 14, 33, 548, DateTimeKind.Utc).AddTicks(1320) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 3, 1, 20, 52, 1, 818, DateTimeKind.Utc).AddTicks(6415), new DateTime(2023, 5, 6, 18, 19, 43, 892, DateTimeKind.Utc).AddTicks(1004), new DateTime(2023, 3, 16, 23, 10, 41, 96, DateTimeKind.Utc).AddTicks(2872), new DateTime(2023, 3, 22, 13, 33, 12, 22, DateTimeKind.Utc).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 12, 22, 1, 20, 266, DateTimeKind.Utc).AddTicks(210), new DateTime(2022, 12, 25, 15, 18, 53, 683, DateTimeKind.Utc).AddTicks(8057), new DateTime(2022, 2, 15, 15, 1, 2, 872, DateTimeKind.Utc).AddTicks(1664), new DateTime(2022, 7, 12, 13, 43, 10, 643, DateTimeKind.Utc).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2023, 6, 27, 4, 8, 10, 472, DateTimeKind.Utc).AddTicks(1162), new DateTime(2023, 5, 28, 16, 59, 44, 939, DateTimeKind.Utc).AddTicks(6823), new DateTime(2022, 1, 3, 13, 28, 11, 80, DateTimeKind.Utc).AddTicks(1756) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 28, 9, 7, 3, 500, DateTimeKind.Utc).AddTicks(4465), new DateTime(2022, 12, 23, 10, 9, 28, 507, DateTimeKind.Utc).AddTicks(5743), new DateTime(2022, 11, 4, 9, 4, 37, 418, DateTimeKind.Utc).AddTicks(155), new DateTime(2023, 8, 28, 7, 28, 32, 783, DateTimeKind.Utc).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2019, 5, 31, 6, 6, 40, 155, DateTimeKind.Utc).AddTicks(1423), new DateTime(2018, 11, 20, 21, 36, 6, 734, DateTimeKind.Utc).AddTicks(7635), new DateTime(2017, 4, 10, 14, 52, 54, 885, DateTimeKind.Utc).AddTicks(8025), new DateTime(2017, 12, 25, 20, 25, 48, 513, DateTimeKind.Utc).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 31, 19, 50, 19, 821, DateTimeKind.Utc).AddTicks(2718), new DateTime(2022, 9, 21, 15, 18, 35, 126, DateTimeKind.Utc).AddTicks(3986), new DateTime(2021, 10, 26, 20, 38, 42, 682, DateTimeKind.Utc).AddTicks(7947), new DateTime(2022, 7, 31, 8, 43, 9, 593, DateTimeKind.Utc).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 15, 44, 41, 91, DateTimeKind.Utc).AddTicks(6721), new DateTime(2023, 9, 1, 17, 4, 31, 306, DateTimeKind.Utc).AddTicks(6093), new DateTime(2023, 8, 30, 17, 40, 9, 401, DateTimeKind.Utc).AddTicks(4929), new DateTime(2023, 9, 1, 21, 34, 42, 620, DateTimeKind.Utc).AddTicks(3463) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 10, 17, 18, 2, 8, 265, DateTimeKind.Utc).AddTicks(5073), new DateTime(2021, 11, 18, 22, 54, 51, 918, DateTimeKind.Utc).AddTicks(6299), new DateTime(2018, 4, 18, 16, 18, 36, 593, DateTimeKind.Utc).AddTicks(6716), new DateTime(2019, 7, 9, 6, 4, 16, 547, DateTimeKind.Utc).AddTicks(5624) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 7, 19, 55, 354, DateTimeKind.Utc).AddTicks(9949), new DateTime(2023, 9, 1, 12, 29, 1, 868, DateTimeKind.Utc).AddTicks(7696), new DateTime(2023, 8, 24, 23, 30, 19, 391, DateTimeKind.Utc).AddTicks(1561), new DateTime(2023, 8, 28, 19, 2, 33, 835, DateTimeKind.Utc).AddTicks(7392) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 15, 32, 36, 533, DateTimeKind.Utc).AddTicks(8318), new DateTime(2023, 4, 2, 23, 31, 12, 628, DateTimeKind.Utc).AddTicks(3793), new DateTime(2016, 11, 12, 23, 3, 54, 42, DateTimeKind.Utc).AddTicks(2751), new DateTime(2020, 9, 23, 11, 45, 35, 705, DateTimeKind.Utc).AddTicks(3591) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 4, 18, 6, 28, 214, DateTimeKind.Utc).AddTicks(9556), new DateTime(2023, 3, 31, 20, 30, 21, 985, DateTimeKind.Utc).AddTicks(6713), new DateTime(2022, 8, 28, 19, 9, 52, 189, DateTimeKind.Utc).AddTicks(2179), new DateTime(2023, 8, 13, 9, 36, 22, 643, DateTimeKind.Utc).AddTicks(2009) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 51, 31, 891, DateTimeKind.Utc).AddTicks(4362), new DateTime(2023, 4, 3, 18, 44, 47, 961, DateTimeKind.Utc).AddTicks(731), new DateTime(2023, 3, 29, 15, 54, 7, 154, DateTimeKind.Utc).AddTicks(5020), new DateTime(2023, 7, 30, 21, 36, 24, 241, DateTimeKind.Utc).AddTicks(3336) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 2, 7, 4, 28, 20, 482, DateTimeKind.Utc).AddTicks(3956), new DateTime(2021, 1, 24, 11, 26, 4, 733, DateTimeKind.Utc).AddTicks(8242), new DateTime(2019, 6, 21, 3, 59, 21, 492, DateTimeKind.Utc).AddTicks(7259), new DateTime(2022, 9, 27, 17, 47, 35, 817, DateTimeKind.Utc).AddTicks(1689) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 15, 14, 3, 2, 83, DateTimeKind.Utc).AddTicks(4855), new DateTime(2023, 5, 1, 8, 23, 34, 628, DateTimeKind.Utc).AddTicks(3094), new DateTime(2022, 9, 20, 17, 18, 52, 751, DateTimeKind.Utc).AddTicks(5781), new DateTime(2023, 1, 7, 4, 17, 12, 503, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 28, 6, 21, 19, 357, DateTimeKind.Utc).AddTicks(8220), new DateTime(2023, 5, 27, 22, 32, 26, 203, DateTimeKind.Utc).AddTicks(4643), new DateTime(2019, 4, 3, 11, 25, 21, 920, DateTimeKind.Utc).AddTicks(386) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 9, 20, 23, 21, 18, 877, DateTimeKind.Utc).AddTicks(1485), new DateTime(2021, 9, 24, 16, 30, 56, 932, DateTimeKind.Utc).AddTicks(1120), new DateTime(2021, 3, 30, 10, 54, 24, 409, DateTimeKind.Utc).AddTicks(6429), new DateTime(2023, 5, 27, 22, 14, 15, 72, DateTimeKind.Utc).AddTicks(6888) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 18, 44, 881, DateTimeKind.Utc).AddTicks(4571), new DateTime(2023, 7, 25, 4, 26, 34, 103, DateTimeKind.Utc).AddTicks(4143), new DateTime(2023, 7, 12, 23, 5, 23, 450, DateTimeKind.Utc).AddTicks(3254), new DateTime(2023, 8, 11, 4, 26, 53, 514, DateTimeKind.Utc).AddTicks(611) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 3, 36, 51, DateTimeKind.Utc).AddTicks(8376), new DateTime(2023, 6, 3, 20, 4, 52, 472, DateTimeKind.Utc).AddTicks(4970), new DateTime(2023, 1, 10, 23, 38, 38, 493, DateTimeKind.Utc).AddTicks(9497), new DateTime(2023, 3, 16, 18, 11, 23, 796, DateTimeKind.Utc).AddTicks(5035) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 14, 21, 39, 53, 434, DateTimeKind.Utc).AddTicks(5002), new DateTime(2023, 1, 28, 7, 1, 10, 841, DateTimeKind.Utc).AddTicks(4677), new DateTime(2022, 5, 22, 2, 30, 43, 690, DateTimeKind.Utc).AddTicks(4147), new DateTime(2023, 2, 26, 12, 20, 8, 491, DateTimeKind.Utc).AddTicks(4821) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 5, 14, 9, 10, 52, 881, DateTimeKind.Utc).AddTicks(3038), new DateTime(2020, 6, 20, 23, 43, 11, 99, DateTimeKind.Utc).AddTicks(1931), new DateTime(2017, 10, 10, 7, 8, 55, 426, DateTimeKind.Utc).AddTicks(4656), new DateTime(2018, 5, 30, 0, 36, 34, 813, DateTimeKind.Utc).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 8, 27, 18, 29, 18, 761, DateTimeKind.Utc).AddTicks(8247), new DateTime(2023, 7, 16, 10, 53, 28, 743, DateTimeKind.Utc).AddTicks(3524), new DateTime(2021, 5, 14, 7, 10, 40, 178, DateTimeKind.Utc).AddTicks(276), new DateTime(2021, 10, 6, 1, 17, 19, 931, DateTimeKind.Utc).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 33, 10, 110, DateTimeKind.Utc).AddTicks(6872), new DateTime(2023, 2, 19, 6, 14, 26, 858, DateTimeKind.Utc).AddTicks(9958), new DateTime(2022, 12, 10, 20, 12, 25, 678, DateTimeKind.Utc).AddTicks(3170), new DateTime(2023, 2, 4, 1, 50, 6, 321, DateTimeKind.Utc).AddTicks(1459) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 22, 43, 15, 310, DateTimeKind.Utc).AddTicks(8529), new DateTime(2023, 7, 25, 19, 0, 3, 445, DateTimeKind.Utc).AddTicks(6454), new DateTime(2022, 12, 24, 12, 22, 5, 237, DateTimeKind.Utc).AddTicks(4716), new DateTime(2023, 7, 30, 20, 21, 6, 142, DateTimeKind.Utc).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 11, 34, 49, 409, DateTimeKind.Utc).AddTicks(2951), new DateTime(2022, 5, 18, 14, 31, 16, 26, DateTimeKind.Utc).AddTicks(9129), new DateTime(2021, 6, 30, 19, 34, 39, 921, DateTimeKind.Utc).AddTicks(7954), new DateTime(2022, 1, 22, 2, 43, 0, 651, DateTimeKind.Utc).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 6, 22, 0, 51, 10, 989, DateTimeKind.Utc).AddTicks(1618), new DateTime(2023, 8, 25, 6, 22, 40, 369, DateTimeKind.Utc).AddTicks(1194), new DateTime(2023, 6, 8, 2, 37, 59, 296, DateTimeKind.Utc).AddTicks(5970), new DateTime(2023, 7, 22, 5, 18, 19, 865, DateTimeKind.Utc).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 11, 6, 10, 825, DateTimeKind.Utc).AddTicks(2654), new DateTime(2023, 8, 22, 23, 5, 50, 110, DateTimeKind.Utc).AddTicks(5316), new DateTime(2023, 8, 4, 4, 34, 47, 629, DateTimeKind.Utc).AddTicks(2593), new DateTime(2023, 8, 19, 5, 40, 13, 524, DateTimeKind.Utc).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 3, 30, 7, 36, 30, 420, DateTimeKind.Utc).AddTicks(1975), new DateTime(2020, 12, 8, 8, 40, 44, 819, DateTimeKind.Utc).AddTicks(8923), new DateTime(2019, 10, 6, 8, 54, 51, 480, DateTimeKind.Utc).AddTicks(7091), new DateTime(2023, 7, 23, 17, 5, 16, 104, DateTimeKind.Utc).AddTicks(1232) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 3, 30, 6, 43, 49, 949, DateTimeKind.Utc).AddTicks(1123), new DateTime(2023, 4, 13, 0, 43, 50, 158, DateTimeKind.Utc).AddTicks(1536), new DateTime(2022, 11, 10, 11, 44, 51, 27, DateTimeKind.Utc).AddTicks(2487), new DateTime(2023, 1, 13, 10, 56, 39, 101, DateTimeKind.Utc).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 30, 1, 23, 56, 417, DateTimeKind.Utc).AddTicks(7043), new DateTime(2022, 8, 28, 8, 33, 17, 161, DateTimeKind.Utc).AddTicks(4327), new DateTime(2022, 8, 16, 11, 4, 48, 248, DateTimeKind.Utc).AddTicks(648), new DateTime(2023, 1, 22, 4, 32, 0, 137, DateTimeKind.Utc).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 10, 21, 10, 10, 38, 281, DateTimeKind.Utc).AddTicks(3592), new DateTime(2019, 11, 12, 14, 42, 7, 387, DateTimeKind.Utc).AddTicks(3007), new DateTime(2017, 6, 27, 0, 15, 29, 362, DateTimeKind.Utc).AddTicks(6191), new DateTime(2018, 8, 6, 7, 57, 38, 832, DateTimeKind.Utc).AddTicks(7634) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 8, 57, 21, 966, DateTimeKind.Utc).AddTicks(2180), new DateTime(2023, 7, 18, 20, 38, 25, 980, DateTimeKind.Utc).AddTicks(2850), new DateTime(2023, 6, 24, 7, 21, 17, 213, DateTimeKind.Utc).AddTicks(4806), new DateTime(2023, 7, 9, 1, 16, 57, 957, DateTimeKind.Utc).AddTicks(3657) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 16, 16, 19, 3, 76, DateTimeKind.Utc).AddTicks(3772), new DateTime(2022, 11, 20, 5, 32, 7, 359, DateTimeKind.Utc).AddTicks(5993), new DateTime(2022, 5, 7, 3, 6, 54, 1, DateTimeKind.Utc).AddTicks(1745), new DateTime(2023, 1, 2, 18, 17, 8, 372, DateTimeKind.Utc).AddTicks(7090) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 1, 1, 10, 39, 30, 724, DateTimeKind.Utc).AddTicks(1722), new DateTime(2020, 4, 27, 12, 33, 33, 734, DateTimeKind.Utc).AddTicks(8558), new DateTime(2019, 8, 27, 5, 28, 59, 645, DateTimeKind.Utc).AddTicks(9888), new DateTime(2020, 11, 28, 4, 0, 54, 53, DateTimeKind.Utc).AddTicks(1861) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 1, 3, 12, 2, 21, DateTimeKind.Utc).AddTicks(9949), new DateTime(2023, 8, 3, 17, 40, 19, 115, DateTimeKind.Utc).AddTicks(4225), new DateTime(2023, 4, 25, 10, 24, 5, 717, DateTimeKind.Utc).AddTicks(2090), new DateTime(2023, 8, 20, 23, 19, 57, 223, DateTimeKind.Utc).AddTicks(1221) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 16, 18, 30, 20, 317, DateTimeKind.Utc).AddTicks(3405), new DateTime(2022, 8, 12, 12, 31, 15, 682, DateTimeKind.Utc).AddTicks(9123), new DateTime(2022, 6, 13, 1, 11, 57, 675, DateTimeKind.Utc).AddTicks(8894), new DateTime(2022, 10, 3, 20, 46, 58, 680, DateTimeKind.Utc).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 3, 22, 45, 57, 658, DateTimeKind.Utc).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 24, 2, 35, 33, 802, DateTimeKind.Utc).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 14, 9, 21, 53, 465, DateTimeKind.Utc).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 30, 23, 28, 47, 52, DateTimeKind.Utc).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 18, 15, 20, 34, 185, DateTimeKind.Utc).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 12, 21, 58, 21, 898, DateTimeKind.Utc).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 11, 3, 45, 54, 543, DateTimeKind.Utc).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 18, 10, 19, 13, 849, DateTimeKind.Utc).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 9, 2, 1, 53, DateTimeKind.Utc).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 6, 4, 56, 694, DateTimeKind.Utc).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 11, 9, 38, 41, 111, DateTimeKind.Utc).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 8, 13, 57, 16, 975, DateTimeKind.Utc).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 24, 0, 34, 17, 762, DateTimeKind.Utc).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 19, 2, 9, 57, 168, DateTimeKind.Utc).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 26, 10, 22, 50, 479, DateTimeKind.Utc).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 8, 4, 35, 8, 117, DateTimeKind.Utc).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 2, 7, 3, 40, 408, DateTimeKind.Utc).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 5, 18, 51, 42, 634, DateTimeKind.Utc).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 6, 19, 5, 59, 372, DateTimeKind.Utc).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 28, 1, 11, 14, 624, DateTimeKind.Utc).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 19, 19, 14, 12, 35, DateTimeKind.Utc).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 6, 9, 25, 797, DateTimeKind.Utc).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 23, 20, 59, 30, 30, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 9, 0, 54, 2, 728, DateTimeKind.Utc).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 15, 15, 8, 3, 993, DateTimeKind.Utc).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 1, 0, 38, 42, 904, DateTimeKind.Utc).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 12, 12, 32, 48, 696, DateTimeKind.Utc).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 20, 20, 6, 9, 761, DateTimeKind.Utc).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 6, 13, 12, 312, DateTimeKind.Utc).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 2, 7, 12, 57, 535, DateTimeKind.Utc).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 19, 20, 14, 32, 235, DateTimeKind.Utc).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 0, 36, 48, 874, DateTimeKind.Utc).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 29, 12, 6, 55, 980, DateTimeKind.Utc).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 30, 9, 40, 26, 317, DateTimeKind.Utc).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedAt",
                value: new DateTime(2020, 3, 23, 9, 15, 32, 370, DateTimeKind.Utc).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 1, 9, 51, 41, 430, DateTimeKind.Utc).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 11, 1, 14, 54, 620, DateTimeKind.Utc).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 26, 6, 11, 20, 181, DateTimeKind.Utc).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 4, 8, 44, 22, 182, DateTimeKind.Utc).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 9, 2, 57, 35, 622, DateTimeKind.Utc).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 17, 18, 28, 11, 285, DateTimeKind.Utc).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 7, 13, 23, 3, 972, DateTimeKind.Utc).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 11, 41, 39, 527, DateTimeKind.Utc).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 20, 18, 36, 45, 190, DateTimeKind.Utc).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 3, 22, 47, 50, 807, DateTimeKind.Utc).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 1, 23, 45, 42, 710, DateTimeKind.Utc).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedAt",
                value: new DateTime(2021, 6, 1, 16, 23, 28, 179, DateTimeKind.Utc).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 48L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 8, 16, 55, 6, 398, DateTimeKind.Utc).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 14, 6, 3, 154, DateTimeKind.Utc).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 1, 8, 36, 26, 927, DateTimeKind.Utc).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 4, 14, 33, 14, 725, DateTimeKind.Utc).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 20, 12, 58, 38, 872, DateTimeKind.Utc).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 9, 4, 17, 34, 545, DateTimeKind.Utc).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 19, 25, 52, 847, DateTimeKind.Utc).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 1, 4, 10, 56, 163, DateTimeKind.Utc).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 56L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 5, 23, 33, 27, 239, DateTimeKind.Utc).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 18, 7, 50, 9, 558, DateTimeKind.Utc).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 19, 9, 21, 26, 572, DateTimeKind.Utc).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 31, 3, 34, 5, 497, DateTimeKind.Utc).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 9, 23, 25, 33, 457, DateTimeKind.Utc).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 19, 16, 28, 8, 359, DateTimeKind.Utc).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 4, 11, 7, 33, 540, DateTimeKind.Utc).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 18, 18, 12, 762, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 64L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 16, 48, 31, 267, DateTimeKind.Utc).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 26, 20, 34, 15, 55, DateTimeKind.Utc).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 21, 22, 52, 16, 195, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 7, 15, 40, 59, 647, DateTimeKind.Utc).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 19, 3, 45, 46, 894, DateTimeKind.Utc).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 4, 58, 54, 668, DateTimeKind.Utc).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 24, 0, 51, 14, 441, DateTimeKind.Utc).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 2, 14, 22, 11, 661, DateTimeKind.Utc).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 72L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 12, 6, 41, 26, 590, DateTimeKind.Utc).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 21, 11, 52, 53, 563, DateTimeKind.Utc).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 1, 19, 26, 15, 621, DateTimeKind.Utc).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 6, 12, 55, 39, 2, DateTimeKind.Utc).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 25, 1, 30, 42, 78, DateTimeKind.Utc).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 22, 23, 59, 22, 72, DateTimeKind.Utc).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 15, 56, 33, 228, DateTimeKind.Utc).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 15, 4, 27, 31, 766, DateTimeKind.Utc).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 80L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 1, 8, 30, 57, 38, DateTimeKind.Utc).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 19, 16, 38, 59, 363, DateTimeKind.Utc).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 2, 22, 7, 47, 525, DateTimeKind.Utc).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 2, 27, 49, 989, DateTimeKind.Utc).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 31, 0, 46, 59, 686, DateTimeKind.Utc).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 4, 7, 3, 25, 487, DateTimeKind.Utc).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 14, 7, 12, 32, 964, DateTimeKind.Utc).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 8, 12, 51, 28, 700, DateTimeKind.Utc).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 88L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 9, 1, 10, 6, DateTimeKind.Utc).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 18, 10, 33, 46, 569, DateTimeKind.Utc).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 22, 17, 7, 19, 757, DateTimeKind.Utc).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 14, 7, 47, 57, 621, DateTimeKind.Utc).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 3, 16, 20, 46, 692, DateTimeKind.Utc).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 5, 21, 7, 19, 806, DateTimeKind.Utc).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 19, 14, 39, 57, 280, DateTimeKind.Utc).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 23, 4, 41, 45, 744, DateTimeKind.Utc).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 96L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 2, 2, 38, 6, 505, DateTimeKind.Utc).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 29, 0, 7, 4, 669, DateTimeKind.Utc).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 7, 13, 12, 44, 755, DateTimeKind.Utc).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 11, 8, 38, 12, 533, DateTimeKind.Utc).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 17, 3, 37, 7, 362, DateTimeKind.Utc).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 31, 1, 27, 30, 47, DateTimeKind.Utc).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 31, 5, 57, 59, 77, DateTimeKind.Utc).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 26, 21, 2, 3, 727, DateTimeKind.Utc).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 104L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 31, 14, 41, 52, 33, DateTimeKind.Utc).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 16, 1, 46, 42, 125, DateTimeKind.Utc).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedAt",
                value: new DateTime(2021, 12, 7, 6, 30, 3, 881, DateTimeKind.Utc).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 26, 6, 14, 40, 300, DateTimeKind.Utc).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 15, 42, 5, 679, DateTimeKind.Utc).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 24, 1, 2, 4, 284, DateTimeKind.Utc).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 22, 5, 50, 17, 37, DateTimeKind.Utc).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 22, 8, 4, 621, DateTimeKind.Utc).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 112L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 1, 11, 31, 21, 57, DateTimeKind.Utc).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 15, 21, 36, 4, 245, DateTimeKind.Utc).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 17, 16, 16, 748, DateTimeKind.Utc).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 31, 5, 57, 16, 233, DateTimeKind.Utc).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 1, 17, 11, 46, 900, DateTimeKind.Utc).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedAt",
                value: new DateTime(2021, 12, 28, 7, 1, 35, 142, DateTimeKind.Utc).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 23, 40, 42, 295, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 1, 15, 3, 8, 509, DateTimeKind.Utc).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 120L,
                column: "CreatedAt",
                value: new DateTime(2022, 1, 4, 2, 16, 13, 892, DateTimeKind.Utc).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 2, 31, 59, 829, DateTimeKind.Utc).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 3, 20, 35, 11, 142, DateTimeKind.Utc).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 14, 2, 58, 5, 624, DateTimeKind.Utc).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 0, 55, 51, 156, DateTimeKind.Utc).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 31, 10, 34, 12, 40, DateTimeKind.Utc).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 13, 22, 25, 18, 618, DateTimeKind.Utc).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 3, 34, 41, 291, DateTimeKind.Utc).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 128L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 10, 23, 8, 42, 170, DateTimeKind.Utc).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 41, 9, 226, DateTimeKind.Utc).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 5, 9, 33, 929, DateTimeKind.Utc).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 7, 58, 6, 982, DateTimeKind.Utc).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 27, 5, 52, 7, 784, DateTimeKind.Utc).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 18, 21, 40, 0, 381, DateTimeKind.Utc).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 8, 13, 23, 669, DateTimeKind.Utc).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 13, 36, 0, 811, DateTimeKind.Utc).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 136L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 3, 7, 58, 9, 424, DateTimeKind.Utc).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 14, 10, 9, 56, 365, DateTimeKind.Utc).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 3, 5, 52, 58, 232, DateTimeKind.Utc).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 17, 14, 57, 26, 584, DateTimeKind.Utc).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 29, 22, 47, 20, 143, DateTimeKind.Utc).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 30, 14, 7, 18, 224, DateTimeKind.Utc).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 16, 7, 28, 54, 232, DateTimeKind.Utc).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 1, 8, 52, 38, 945, DateTimeKind.Utc).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 144L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 4, 13, 52, 43, 320, DateTimeKind.Utc).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 21, 40, 57, 80, DateTimeKind.Utc).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedAt",
                value: new DateTime(2021, 12, 9, 12, 51, 40, 263, DateTimeKind.Utc).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 31, 9, 35, 33, 844, DateTimeKind.Utc).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 5, 5, 1, 969, DateTimeKind.Utc).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 19, 18, 18, 53, 643, DateTimeKind.Utc).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 31, 16, 16, 59, 728, DateTimeKind.Utc).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 10, 52, 15, 706, DateTimeKind.Utc).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 152L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 12, 20, 35, 33, 567, DateTimeKind.Utc).AddTicks(3457));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 12, 5, 20, 17, 865, DateTimeKind.Utc).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 4, 8, 21, 2, 244, DateTimeKind.Utc).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 18, 43, 40, 114, DateTimeKind.Utc).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 9, 23, 52, 0, 461, DateTimeKind.Utc).AddTicks(1098));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 22, 12, 51, 15, 88, DateTimeKind.Utc).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 1, 6, 1, 14, 250, DateTimeKind.Utc).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 20, 3, 34, 43, 659, DateTimeKind.Utc).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 160L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 18, 8, 46, 56, 563, DateTimeKind.Utc).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 31, 23, 19, 47, 576, DateTimeKind.Utc).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 7, 17, 32, 54, 861, DateTimeKind.Utc).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 20, 20, 59, 10, 122, DateTimeKind.Utc).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 2, 22, 7, 47, 945, DateTimeKind.Utc).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 5, 7, 4, 7, 114, DateTimeKind.Utc).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 18, 14, 18, 20, 323, DateTimeKind.Utc).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 31, 23, 3, 57, 96, DateTimeKind.Utc).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 168L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 14, 0, 57, 14, 587, DateTimeKind.Utc).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 23, 16, 55, 26, 20, DateTimeKind.Utc).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 14, 4, 15, 28, 329, DateTimeKind.Utc).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 5, 19, 3, 30, 686, DateTimeKind.Utc).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 28, 12, 54, 26, 504, DateTimeKind.Utc).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 5, 2, 33, 3, 533, DateTimeKind.Utc).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 29, 13, 55, 15, 917, DateTimeKind.Utc).AddTicks(1318));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 14, 42, 15, 68, DateTimeKind.Utc).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 176L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 5, 13, 50, 2, 366, DateTimeKind.Utc).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 28, 12, 45, 7, 876, DateTimeKind.Utc).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 7, 21, 53, 39, 741, DateTimeKind.Utc).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 2, 0, 47, 10, 403, DateTimeKind.Utc).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 26, 10, 47, 43, 543, DateTimeKind.Utc).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 1, 59, 12, 413, DateTimeKind.Utc).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 23, 13, 55, 10, 879, DateTimeKind.Utc).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 7, 8, 42, 20, 96, DateTimeKind.Utc).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 184L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 13, 52, 29, 826, DateTimeKind.Utc).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 25, 14, 42, 20, 482, DateTimeKind.Utc).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 14, 4, 16, 13, 102, DateTimeKind.Utc).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 2, 21, 44, 24, 959, DateTimeKind.Utc).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 2, 18, 46, 34, 553, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 21, 4, 49, 24, 751, DateTimeKind.Utc).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 21, 20, 3, 55, 829, DateTimeKind.Utc).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 9, 19, 30, 44, 696, DateTimeKind.Utc).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 192L,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 9, 4, 27, 7, 299, DateTimeKind.Utc).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 3, 2, 26, 22, 73, DateTimeKind.Utc).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 18, 10, 30, 695, DateTimeKind.Utc).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 21, 1, 29, 390, DateTimeKind.Utc).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 23, 12, 52, 26, 825, DateTimeKind.Utc).AddTicks(1822));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 21, 8, 53, 37, 452, DateTimeKind.Utc).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 4, 14, 36, 43, 541, DateTimeKind.Utc).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 15, 10, 57, 11, 899, DateTimeKind.Utc).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 200L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 30, 18, 14, 10, 409, DateTimeKind.Utc).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 17, 19, 4, 53, 294, DateTimeKind.Utc).AddTicks(7178), new DateTime(2023, 9, 1, 14, 49, 32, 412, DateTimeKind.Utc).AddTicks(1979) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 29, 20, 54, 57, 241, DateTimeKind.Utc).AddTicks(7623), new DateTime(2023, 9, 2, 7, 3, 7, 547, DateTimeKind.Utc).AddTicks(1973) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 15, 0, 4, 23, 801, DateTimeKind.Utc).AddTicks(8383), new DateTime(2023, 9, 3, 20, 7, 27, 827, DateTimeKind.Utc).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 5, 18, 21, 3, 945, DateTimeKind.Utc).AddTicks(2487), new DateTime(2023, 4, 16, 16, 37, 22, 408, DateTimeKind.Utc).AddTicks(4363) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 22, 32, 49, 51, DateTimeKind.Utc).AddTicks(2507), new DateTime(2023, 8, 11, 23, 1, 41, 909, DateTimeKind.Utc).AddTicks(2145) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 23, 16, 52, 6, 448, DateTimeKind.Utc).AddTicks(3250), new DateTime(2023, 5, 25, 14, 8, 1, 857, DateTimeKind.Utc).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 21, 52, 8, 748, DateTimeKind.Utc).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 1, 0, 39, 26, 662, DateTimeKind.Utc).AddTicks(1002), new DateTime(2023, 8, 22, 13, 16, 34, 697, DateTimeKind.Utc).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 9, 26, 16, 37, 34, 683, DateTimeKind.Utc).AddTicks(7166), new DateTime(2023, 5, 10, 21, 7, 52, 5, DateTimeKind.Utc).AddTicks(3922) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 18, 1, 31, 54, 472, DateTimeKind.Utc).AddTicks(9192), new DateTime(2023, 7, 31, 9, 22, 39, 587, DateTimeKind.Utc).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 7, 9, 38, 8, 970, DateTimeKind.Utc).AddTicks(7959), new DateTime(2023, 5, 12, 5, 12, 13, 347, DateTimeKind.Utc).AddTicks(4823) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 10, 9, 11, 41, 895, DateTimeKind.Utc).AddTicks(6681), new DateTime(2023, 6, 24, 16, 17, 22, 387, DateTimeKind.Utc).AddTicks(4256) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 21, 58, 1, 523, DateTimeKind.Utc).AddTicks(282), new DateTime(2023, 8, 31, 12, 39, 22, 23, DateTimeKind.Utc).AddTicks(2014) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 17, 1, 0, 41, 71, DateTimeKind.Utc).AddTicks(6253), new DateTime(2023, 8, 29, 16, 46, 27, 249, DateTimeKind.Utc).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 8, 0, 6, 35, 701, DateTimeKind.Utc).AddTicks(1777), new DateTime(2023, 8, 10, 12, 56, 38, 264, DateTimeKind.Utc).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 2, 12, 31, 35, 420, DateTimeKind.Utc).AddTicks(489), new DateTime(2023, 9, 2, 16, 32, 38, 469, DateTimeKind.Utc).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 8, 5, 21, 38, 8, 958, DateTimeKind.Utc).AddTicks(6585), new DateTime(2023, 3, 7, 21, 14, 10, 26, DateTimeKind.Utc).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 1, 18, 9, 26, 115, DateTimeKind.Utc).AddTicks(7434), new DateTime(2023, 2, 23, 23, 32, 19, 240, DateTimeKind.Utc).AddTicks(9313) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 19, 16, 30, 57, 227, DateTimeKind.Utc).AddTicks(1695), new DateTime(2023, 8, 31, 12, 3, 57, 26, DateTimeKind.Utc).AddTicks(7004) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 21, 18, 56, 3, 709, DateTimeKind.Utc).AddTicks(489), new DateTime(2023, 8, 4, 10, 42, 48, 906, DateTimeKind.Utc).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 7, 18, 20, 6, 311, DateTimeKind.Utc).AddTicks(2761), new DateTime(2023, 8, 10, 20, 9, 9, 927, DateTimeKind.Utc).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 3, 15, 44, 42, 618, DateTimeKind.Utc).AddTicks(6125), new DateTime(2023, 9, 4, 14, 15, 15, 408, DateTimeKind.Utc).AddTicks(3228) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 4, 1, 57, 18, 742, DateTimeKind.Utc).AddTicks(5325), new DateTime(2023, 5, 14, 15, 3, 31, 741, DateTimeKind.Utc).AddTicks(6569) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 30, 15, 46, 48, 614, DateTimeKind.Utc).AddTicks(219), new DateTime(2023, 9, 4, 7, 5, 23, 25, DateTimeKind.Utc).AddTicks(3420) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 23, 6, 56, 30, 817, DateTimeKind.Utc).AddTicks(2458), new DateTime(2023, 5, 7, 21, 6, 41, 942, DateTimeKind.Utc).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 2, 33, 7, 568, DateTimeKind.Utc).AddTicks(3322), new DateTime(2023, 8, 12, 4, 4, 44, 631, DateTimeKind.Utc).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 31, 16, 25, 57, 663, DateTimeKind.Utc).AddTicks(9342), new DateTime(2023, 8, 3, 4, 0, 36, 904, DateTimeKind.Utc).AddTicks(671) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 2, 3, 5, 54, 695, DateTimeKind.Utc).AddTicks(6889), new DateTime(2023, 7, 3, 6, 41, 35, 962, DateTimeKind.Utc).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 19, 45, 28, 805, DateTimeKind.Utc).AddTicks(3780), new DateTime(2023, 8, 24, 0, 49, 48, 366, DateTimeKind.Utc).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 4, 9, 2, 35, 405, DateTimeKind.Utc).AddTicks(7969), new DateTime(2023, 9, 4, 10, 43, 1, 498, DateTimeKind.Utc).AddTicks(8319) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 27, 1, 32, 44, 756, DateTimeKind.Utc).AddTicks(8482), new DateTime(2023, 8, 28, 21, 11, 16, 161, DateTimeKind.Utc).AddTicks(5807) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 31, 5, 25, 26, 65, DateTimeKind.Utc).AddTicks(5713), new DateTime(2023, 4, 8, 3, 57, 52, 849, DateTimeKind.Utc).AddTicks(5312) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 19, 6, 48, 28, 965, DateTimeKind.Utc).AddTicks(2665), new DateTime(2023, 7, 22, 17, 54, 12, 355, DateTimeKind.Utc).AddTicks(1929) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 30, 11, 38, 38, 658, DateTimeKind.Utc).AddTicks(2988), new DateTime(2023, 8, 22, 23, 6, 5, 562, DateTimeKind.Utc).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 16, 23, 44, 72, DateTimeKind.Utc).AddTicks(8866), new DateTime(2023, 8, 17, 22, 6, 2, 957, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 11, 18, 38, 42, 661, DateTimeKind.Utc).AddTicks(688), new DateTime(2023, 7, 13, 3, 27, 50, 566, DateTimeKind.Utc).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 24, 22, 1, 27, 576, DateTimeKind.Utc).AddTicks(7234), new DateTime(2023, 5, 1, 13, 43, 21, 135, DateTimeKind.Utc).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 9, 25, 19, 8, 41, 422, DateTimeKind.Utc).AddTicks(5610), new DateTime(2023, 4, 26, 4, 25, 13, 423, DateTimeKind.Utc).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 22, 31, 58, 314, DateTimeKind.Utc).AddTicks(5843), new DateTime(2023, 5, 21, 14, 6, 2, 277, DateTimeKind.Utc).AddTicks(116) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 14, 14, 53, 59, 547, DateTimeKind.Utc).AddTicks(5939), new DateTime(2023, 4, 19, 9, 42, 9, 775, DateTimeKind.Utc).AddTicks(5898) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 9, 22, 24, 30, 922, DateTimeKind.Utc).AddTicks(26), new DateTime(2023, 5, 17, 18, 42, 2, 328, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 31, 20, 49, 56, 317, DateTimeKind.Utc).AddTicks(1592), new DateTime(2023, 9, 2, 1, 30, 16, 988, DateTimeKind.Utc).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 18, 16, 25, 25, 656, DateTimeKind.Utc).AddTicks(3792), new DateTime(2023, 9, 2, 20, 29, 44, 16, DateTimeKind.Utc).AddTicks(6437) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 2, 47, 0, 393, DateTimeKind.Utc).AddTicks(9391), new DateTime(2023, 7, 28, 15, 49, 25, 554, DateTimeKind.Utc).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 49, 59, 625, DateTimeKind.Utc).AddTicks(8596), new DateTime(2023, 7, 30, 20, 5, 3, 601, DateTimeKind.Utc).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 28, 2, 43, 30, 353, DateTimeKind.Utc).AddTicks(326), new DateTime(2023, 7, 5, 13, 46, 40, 838, DateTimeKind.Utc).AddTicks(183) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 26, 14, 56, 13, 937, DateTimeKind.Utc).AddTicks(8420), new DateTime(2023, 6, 30, 13, 58, 35, 608, DateTimeKind.Utc).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 25, 4, 18, 59, 883, DateTimeKind.Utc).AddTicks(5464), new DateTime(2023, 8, 30, 23, 53, 20, 541, DateTimeKind.Utc).AddTicks(9553) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 27, 12, 47, 55, 518, DateTimeKind.Utc).AddTicks(2207), new DateTime(2023, 8, 7, 14, 6, 51, 675, DateTimeKind.Utc).AddTicks(6134) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 1, 55, 24, 209, DateTimeKind.Utc).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 13, 0, 28, 56, 778, DateTimeKind.Utc).AddTicks(2975), new DateTime(2023, 6, 17, 15, 36, 40, 392, DateTimeKind.Utc).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 10, 14, 16, 25, 612, DateTimeKind.Utc).AddTicks(321), new DateTime(2023, 8, 21, 8, 34, 18, 223, DateTimeKind.Utc).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 19, 3, 4, 48, 597, DateTimeKind.Utc).AddTicks(2178), new DateTime(2023, 5, 26, 5, 52, 16, 714, DateTimeKind.Utc).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 21, 3, 52, 9, 490, DateTimeKind.Utc).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 23, 21, 17, 17, 504, DateTimeKind.Utc).AddTicks(4940), new DateTime(2023, 6, 3, 23, 11, 47, 462, DateTimeKind.Utc).AddTicks(8722) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 9, 12, 5, 0, 452, DateTimeKind.Utc).AddTicks(5520), new DateTime(2023, 8, 26, 14, 45, 43, 963, DateTimeKind.Utc).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 20, 3, 51, 42, 446, DateTimeKind.Utc).AddTicks(8962), new DateTime(2023, 6, 22, 21, 23, 58, 951, DateTimeKind.Utc).AddTicks(9653) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 26, 2, 30, 31, 433, DateTimeKind.Utc).AddTicks(8006), new DateTime(2023, 8, 9, 13, 52, 33, 457, DateTimeKind.Utc).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 28, 8, 10, 55, 251, DateTimeKind.Utc).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 4, 0, 29, 10, 799, DateTimeKind.Utc).AddTicks(2669), new DateTime(2023, 9, 4, 2, 55, 5, 591, DateTimeKind.Utc).AddTicks(6065) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 27, 15, 21, 44, 170, DateTimeKind.Utc).AddTicks(8199), new DateTime(2023, 8, 28, 12, 29, 29, 931, DateTimeKind.Utc).AddTicks(9756) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 13, 13, 14, 6, 475, DateTimeKind.Utc).AddTicks(7222), new DateTime(2023, 8, 13, 15, 17, 49, 82, DateTimeKind.Utc).AddTicks(6222) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 29, 14, 55, 9, 460, DateTimeKind.Utc).AddTicks(8310), new DateTime(2023, 9, 3, 20, 28, 38, 355, DateTimeKind.Utc).AddTicks(5761) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 16, 13, 233, DateTimeKind.Utc).AddTicks(3973), new DateTime(2023, 7, 6, 19, 8, 56, 359, DateTimeKind.Utc).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 28, 6, 36, 0, 148, DateTimeKind.Utc).AddTicks(2317), new DateTime(2023, 8, 28, 20, 54, 12, 446, DateTimeKind.Utc).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 31, 6, 20, 23, 350, DateTimeKind.Utc).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 12, 31, 4, 25, 18, 858, DateTimeKind.Utc).AddTicks(2320), new DateTime(2021, 12, 2, 3, 42, 0, 513, DateTimeKind.Utc).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 29, 7, 23, 53, 611, DateTimeKind.Utc).AddTicks(7096), new DateTime(2023, 7, 8, 0, 13, 54, 463, DateTimeKind.Utc).AddTicks(9581) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 2, 21, 18, 5, 416, DateTimeKind.Utc).AddTicks(2824), new DateTime(2023, 9, 3, 19, 38, 29, 307, DateTimeKind.Utc).AddTicks(8423) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 1, 10, 25, 59, 454, DateTimeKind.Utc).AddTicks(2116), new DateTime(2023, 2, 23, 19, 11, 47, 443, DateTimeKind.Utc).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 2, 21, 17, 22, 762, DateTimeKind.Utc).AddTicks(9357), new DateTime(2023, 9, 4, 13, 57, 8, 531, DateTimeKind.Utc).AddTicks(4314) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 10, 19, 39, 6, 876, DateTimeKind.Utc).AddTicks(9603), new DateTime(2023, 1, 29, 22, 29, 9, 19, DateTimeKind.Utc).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 11, 6, 12, 44, 1, 412, DateTimeKind.Utc).AddTicks(9034), new DateTime(2023, 3, 12, 7, 42, 56, 362, DateTimeKind.Utc).AddTicks(8802) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 28, 9, 16, 37, 395, DateTimeKind.Utc).AddTicks(6727), new DateTime(2023, 8, 28, 13, 8, 20, 278, DateTimeKind.Utc).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 25, 1, 56, 11, 917, DateTimeKind.Utc).AddTicks(3984), new DateTime(2023, 4, 10, 23, 8, 27, 640, DateTimeKind.Utc).AddTicks(7887) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 12, 6, 6, 55, 28, DateTimeKind.Utc).AddTicks(2568), new DateTime(2023, 1, 24, 12, 32, 31, 360, DateTimeKind.Utc).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 7, 39, 59, 693, DateTimeKind.Utc).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 8, 22, 1, 5, 502, DateTimeKind.Utc).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 4, 9, 44, 31, 597, DateTimeKind.Utc).AddTicks(3037), new DateTime(2023, 9, 4, 12, 18, 20, 775, DateTimeKind.Utc).AddTicks(3391) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 19, 6, 17, 25, 714, DateTimeKind.Utc).AddTicks(4751), new DateTime(2023, 8, 20, 5, 56, 18, 653, DateTimeKind.Utc).AddTicks(1649) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 18, 14, 43, 315, DateTimeKind.Utc).AddTicks(4862), new DateTime(2023, 7, 16, 22, 24, 49, 916, DateTimeKind.Utc).AddTicks(525) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 9, 38, 837, DateTimeKind.Utc).AddTicks(925), new DateTime(2023, 9, 4, 15, 14, 32, 308, DateTimeKind.Utc).AddTicks(9545) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 29, 10, 33, 49, 244, DateTimeKind.Utc).AddTicks(5914), new DateTime(2023, 6, 7, 18, 0, 41, 107, DateTimeKind.Utc).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 5, 30, 9, 46, 9, 214, DateTimeKind.Utc).AddTicks(987), new DateTime(2023, 3, 8, 10, 55, 51, 921, DateTimeKind.Utc).AddTicks(4969) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 1, 5, 47, 7, 894, DateTimeKind.Utc).AddTicks(273), new DateTime(2023, 9, 4, 8, 32, 27, 385, DateTimeKind.Utc).AddTicks(9105) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 2, 7, 28, 41, 555, DateTimeKind.Utc).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 18, 6, 14, 59, 585, DateTimeKind.Utc).AddTicks(3845), new DateTime(2023, 8, 1, 8, 16, 22, 366, DateTimeKind.Utc).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 0, 44, 17, 988, DateTimeKind.Utc).AddTicks(5562), new DateTime(2022, 3, 23, 2, 51, 30, 359, DateTimeKind.Utc).AddTicks(834) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 3, 2, 19, 12, 8, 955, DateTimeKind.Utc).AddTicks(824), new DateTime(2023, 7, 19, 2, 41, 55, 935, DateTimeKind.Utc).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 15, 11, 9, 17, 617, DateTimeKind.Utc).AddTicks(9607), new DateTime(2023, 9, 2, 8, 39, 5, 511, DateTimeKind.Utc).AddTicks(7562) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 8, 13, 57, 2, 715, DateTimeKind.Utc).AddTicks(977), new DateTime(2023, 7, 25, 21, 40, 3, 471, DateTimeKind.Utc).AddTicks(5322) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 2, 21, 53, 59, 549, DateTimeKind.Utc).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 18, 6, 45, 6, 34, DateTimeKind.Utc).AddTicks(8044), new DateTime(2023, 8, 22, 20, 1, 55, 483, DateTimeKind.Utc).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 3, 22, 0, 31, 6, 193, DateTimeKind.Utc).AddTicks(7148), new DateTime(2023, 5, 21, 21, 53, 29, 82, DateTimeKind.Utc).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 28, 15, 47, 53, 264, DateTimeKind.Utc).AddTicks(7324), new DateTime(2023, 8, 31, 14, 31, 20, 626, DateTimeKind.Utc).AddTicks(8969) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 23, 19, 51, 0, 537, DateTimeKind.Utc).AddTicks(6101), new DateTime(2023, 8, 31, 21, 59, 56, 21, DateTimeKind.Utc).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 8, 5, 50, 22, 991, DateTimeKind.Utc).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 10, 17, 27, 15, 558, DateTimeKind.Utc).AddTicks(3771), new DateTime(2023, 8, 11, 3, 52, 43, 756, DateTimeKind.Utc).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 14, 3, 31, 16, 647, DateTimeKind.Utc).AddTicks(5085), new DateTime(2023, 6, 1, 4, 28, 6, 913, DateTimeKind.Utc).AddTicks(4015) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 28, 9, 45, 29, 397, DateTimeKind.Utc).AddTicks(1020), new DateTime(2023, 9, 1, 12, 2, 36, 480, DateTimeKind.Utc).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 7, 9, 14, 9, 19, 964, DateTimeKind.Utc).AddTicks(2503), new DateTime(2023, 2, 21, 2, 45, 34, 657, DateTimeKind.Utc).AddTicks(7671) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 17, 45, 57, 896, DateTimeKind.Utc).AddTicks(1382), new DateTime(2023, 7, 25, 0, 31, 33, 977, DateTimeKind.Utc).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 21, 6, 2, 13, 46, DateTimeKind.Utc).AddTicks(8918), new DateTime(2023, 9, 2, 14, 20, 58, 884, DateTimeKind.Utc).AddTicks(2368) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 16, 9, 54, 29, 813, DateTimeKind.Utc).AddTicks(6320), new DateTime(2023, 8, 26, 16, 28, 42, 374, DateTimeKind.Utc).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 8, 5, 11, 0, 1, 427, DateTimeKind.Utc).AddTicks(9053), new DateTime(2023, 9, 4, 4, 39, 41, 779, DateTimeKind.Utc).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 15, 42, 15, 211, DateTimeKind.Utc).AddTicks(869), new DateTime(2021, 12, 11, 9, 49, 31, 210, DateTimeKind.Utc).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 16, 0, 11, 35, 645, DateTimeKind.Utc).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 31, 5, 29, 55, 843, DateTimeKind.Utc).AddTicks(6608), new DateTime(2023, 9, 3, 2, 2, 48, 15, DateTimeKind.Utc).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 13, 5, 44, 7, 255, DateTimeKind.Utc).AddTicks(1755), new DateTime(2023, 8, 10, 3, 35, 25, 973, DateTimeKind.Utc).AddTicks(5558) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 19, 15, 45, 21, 468, DateTimeKind.Utc).AddTicks(9544), new DateTime(2023, 7, 18, 20, 18, 19, 27, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 9, 16, 28, 54, 866, DateTimeKind.Utc).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 2, 15, 15, 43, 550, DateTimeKind.Utc).AddTicks(9456), new DateTime(2023, 4, 18, 0, 19, 44, 959, DateTimeKind.Utc).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 31, 4, 2, 44, 84, DateTimeKind.Utc).AddTicks(4945), new DateTime(2023, 8, 21, 7, 2, 24, 630, DateTimeKind.Utc).AddTicks(7199) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 11, 0, 18, 39, 72, DateTimeKind.Utc).AddTicks(1620), new DateTime(2023, 8, 19, 3, 55, 36, 949, DateTimeKind.Utc).AddTicks(8618) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 29, 20, 1, 8, 754, DateTimeKind.Utc).AddTicks(4814), new DateTime(2023, 9, 2, 3, 36, 14, 577, DateTimeKind.Utc).AddTicks(4623) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 15, 5, 31, 8, 605, DateTimeKind.Utc).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 28, 52, 589, DateTimeKind.Utc).AddTicks(3693), new DateTime(2023, 9, 2, 9, 48, 5, 337, DateTimeKind.Utc).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 33, 16, 665, DateTimeKind.Utc).AddTicks(6593), new DateTime(2023, 5, 14, 2, 55, 58, 726, DateTimeKind.Utc).AddTicks(401) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 8, 5, 0, 8, 912, DateTimeKind.Utc).AddTicks(5412), new DateTime(2023, 8, 29, 10, 33, 15, 998, DateTimeKind.Utc).AddTicks(7512) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 15, 19, 13, 17, 296, DateTimeKind.Utc).AddTicks(7238), new DateTime(2023, 8, 20, 22, 44, 19, 292, DateTimeKind.Utc).AddTicks(1468) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 8, 8, 36, 48, 358, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 14, 20, 35, 51, 164, DateTimeKind.Utc).AddTicks(7846), new DateTime(2023, 8, 19, 5, 21, 47, 74, DateTimeKind.Utc).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 20, 17, 50, 49, 292, DateTimeKind.Utc).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 25, 8, 17, 37, 621, DateTimeKind.Utc).AddTicks(5239), new DateTime(2023, 8, 25, 12, 17, 25, 856, DateTimeKind.Utc).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 2, 9, 1, 11, 17, 800, DateTimeKind.Utc).AddTicks(3803), new DateTime(2022, 12, 3, 16, 32, 32, 795, DateTimeKind.Utc).AddTicks(6369) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 7, 2, 44, 32, 792, DateTimeKind.Utc).AddTicks(4374), new DateTime(2023, 6, 3, 15, 7, 57, 143, DateTimeKind.Utc).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 29, 22, 44, 10, 592, DateTimeKind.Utc).AddTicks(3859), new DateTime(2023, 9, 3, 23, 42, 55, 8, DateTimeKind.Utc).AddTicks(9296) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 17, 12, 40, 24, 911, DateTimeKind.Utc).AddTicks(5114), new DateTime(2023, 7, 9, 14, 26, 42, 711, DateTimeKind.Utc).AddTicks(9866) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 1, 23, 42, 34, 667, DateTimeKind.Utc).AddTicks(4521), new DateTime(2023, 3, 7, 19, 42, 3, 273, DateTimeKind.Utc).AddTicks(769) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 21, 19, 29, 15, 845, DateTimeKind.Utc).AddTicks(2890), new DateTime(2023, 5, 23, 1, 54, 52, 308, DateTimeKind.Utc).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 9, 18, 54, 31, 897, DateTimeKind.Utc).AddTicks(7731), new DateTime(2023, 6, 16, 15, 8, 54, 825, DateTimeKind.Utc).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 28, 7, 23, 1, 521, DateTimeKind.Utc).AddTicks(3010), new DateTime(2023, 9, 2, 3, 37, 11, 894, DateTimeKind.Utc).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 13, 16, 51, 9, 160, DateTimeKind.Utc).AddTicks(8636), new DateTime(2023, 7, 31, 2, 43, 15, 43, DateTimeKind.Utc).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 25, 14, 42, 23, 995, DateTimeKind.Utc).AddTicks(968), new DateTime(2023, 8, 28, 16, 36, 20, 573, DateTimeKind.Utc).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 12, 5, 32, 34, 479, DateTimeKind.Utc).AddTicks(8817), new DateTime(2023, 5, 31, 13, 23, 13, 889, DateTimeKind.Utc).AddTicks(9503) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 25, 40, 722, DateTimeKind.Utc).AddTicks(3384), new DateTime(2023, 9, 4, 11, 54, 48, 45, DateTimeKind.Utc).AddTicks(9383) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 21, 1, 51, 47, 4, DateTimeKind.Utc).AddTicks(8533), new DateTime(2023, 8, 26, 10, 52, 8, 429, DateTimeKind.Utc).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 3, 20, 57, 36, 14, DateTimeKind.Utc).AddTicks(9172), new DateTime(2023, 9, 4, 2, 25, 10, 300, DateTimeKind.Utc).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 24, 12, 57, 36, 962, DateTimeKind.Utc).AddTicks(7906), new DateTime(2023, 8, 21, 15, 19, 58, 885, DateTimeKind.Utc).AddTicks(5807) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 24, 18, 16, 35, 91, DateTimeKind.Utc).AddTicks(8557), new DateTime(2023, 7, 10, 2, 55, 0, 882, DateTimeKind.Utc).AddTicks(3244) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 1, 12, 15, 42, 854, DateTimeKind.Utc).AddTicks(7243), new DateTime(2023, 5, 17, 15, 2, 4, 161, DateTimeKind.Utc).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 7, 17, 24, 20, 497, DateTimeKind.Utc).AddTicks(9802), new DateTime(2023, 8, 8, 15, 9, 9, 723, DateTimeKind.Utc).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 13, 15, 5, 30, 600, DateTimeKind.Utc).AddTicks(1106), new DateTime(2023, 8, 13, 1, 27, 40, 891, DateTimeKind.Utc).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 11, 6, 7, 6, 34, 879, DateTimeKind.Utc).AddTicks(3062), new DateTime(2023, 1, 19, 18, 51, 38, 540, DateTimeKind.Utc).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 14, 8, 39, 39, 135, DateTimeKind.Utc).AddTicks(5202), new DateTime(2023, 8, 1, 1, 38, 53, 816, DateTimeKind.Utc).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 21, 12, 21, 15, 829, DateTimeKind.Utc).AddTicks(8725), new DateTime(2023, 9, 1, 7, 13, 32, 958, DateTimeKind.Utc).AddTicks(7403) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 18, 6, 22, 24, 538, DateTimeKind.Utc).AddTicks(2222), new DateTime(2023, 8, 3, 4, 43, 54, 38, DateTimeKind.Utc).AddTicks(5093) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 22, 7, 5, 17, 337, DateTimeKind.Utc).AddTicks(9720), new DateTime(2023, 8, 26, 22, 26, 16, 840, DateTimeKind.Utc).AddTicks(270) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 30, 9, 27, 44, 490, DateTimeKind.Utc).AddTicks(8082), new DateTime(2023, 4, 8, 22, 8, 10, 867, DateTimeKind.Utc).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 3, 11, 8, 9, 381, DateTimeKind.Utc).AddTicks(8796), new DateTime(2023, 8, 27, 16, 37, 2, 92, DateTimeKind.Utc).AddTicks(3599) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 1, 10, 29, 47, 157, DateTimeKind.Utc).AddTicks(7917), new DateTime(2023, 3, 18, 16, 44, 30, 120, DateTimeKind.Utc).AddTicks(4137) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 10, 24, 8, 1, 23, 722, DateTimeKind.Utc).AddTicks(7532), new DateTime(2022, 11, 23, 15, 14, 50, 564, DateTimeKind.Utc).AddTicks(5047) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 29, 3, 56, 18, 309, DateTimeKind.Utc).AddTicks(8147), new DateTime(2023, 8, 30, 6, 22, 28, 596, DateTimeKind.Utc).AddTicks(9645) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 5, 8, 19, 52, 383, DateTimeKind.Utc).AddTicks(478), new DateTime(2023, 3, 5, 21, 26, 27, 986, DateTimeKind.Utc).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 8, 28, 5, 5, 23, 425, DateTimeKind.Utc).AddTicks(7852), new DateTime(2022, 10, 26, 22, 28, 2, 305, DateTimeKind.Utc).AddTicks(4215) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 30, 23, 6, 43, 374, DateTimeKind.Utc).AddTicks(8534), new DateTime(2023, 9, 1, 18, 48, 2, 398, DateTimeKind.Utc).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 7, 6, 23, 7, 59, 721, DateTimeKind.Utc).AddTicks(3064), new DateTime(2023, 1, 15, 2, 18, 57, 90, DateTimeKind.Utc).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 2, 1, 27, 39, 390, DateTimeKind.Utc).AddTicks(4540), new DateTime(2023, 7, 16, 10, 8, 5, 579, DateTimeKind.Utc).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 17, 40, 10, 633, DateTimeKind.Utc).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 3, 14, 50, 48, 11, DateTimeKind.Utc).AddTicks(5184), new DateTime(2023, 3, 31, 21, 20, 29, 426, DateTimeKind.Utc).AddTicks(1662) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 3, 8, 18, 6, 150, DateTimeKind.Utc).AddTicks(4307), new DateTime(2023, 6, 26, 20, 37, 23, 967, DateTimeKind.Utc).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 162L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 26, 13, 4, 53, 108, DateTimeKind.Utc).AddTicks(7688), new DateTime(2023, 9, 1, 18, 11, 38, 660, DateTimeKind.Utc).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 163L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 3, 11, 0, 48, 202, DateTimeKind.Utc).AddTicks(7251), new DateTime(2023, 9, 4, 2, 22, 35, 501, DateTimeKind.Utc).AddTicks(9842) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 164L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 24, 21, 53, 1, 457, DateTimeKind.Utc).AddTicks(9388), new DateTime(2023, 9, 1, 5, 24, 19, 21, DateTimeKind.Utc).AddTicks(1035) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 165L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 24, 14, 4, 6, 796, DateTimeKind.Utc).AddTicks(7314), new DateTime(2023, 8, 26, 11, 2, 46, 662, DateTimeKind.Utc).AddTicks(8877) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 2, 4, 0, 10, 130, DateTimeKind.Utc).AddTicks(8565), new DateTime(2023, 8, 17, 15, 11, 25, 300, DateTimeKind.Utc).AddTicks(6153) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 31, 10, 32, 54, 835, DateTimeKind.Utc).AddTicks(1795), new DateTime(2023, 9, 1, 21, 55, 18, 860, DateTimeKind.Utc).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 9, 6, 12, 41, 320, DateTimeKind.Utc).AddTicks(9471), new DateTime(2023, 7, 20, 3, 23, 50, 252, DateTimeKind.Utc).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 11, 16, 45, 5, 499, DateTimeKind.Utc).AddTicks(6248), new DateTime(2023, 8, 31, 15, 48, 26, 522, DateTimeKind.Utc).AddTicks(4392) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 12, 1, 2, 30, 525, DateTimeKind.Utc).AddTicks(903), new DateTime(2023, 7, 27, 7, 48, 50, 296, DateTimeKind.Utc).AddTicks(6544) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 28, 15, 27, 11, 606, DateTimeKind.Utc).AddTicks(7016), new DateTime(2023, 7, 30, 19, 25, 16, 591, DateTimeKind.Utc).AddTicks(2914) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 15, 9, 23, 36, 368, DateTimeKind.Utc).AddTicks(153), new DateTime(2023, 8, 20, 8, 58, 18, 92, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 26, 1, 13, 26, 296, DateTimeKind.Utc).AddTicks(4004), new DateTime(2023, 7, 8, 10, 55, 38, 984, DateTimeKind.Utc).AddTicks(8725) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 26, 5, 29, 8, 932, DateTimeKind.Utc).AddTicks(7841), new DateTime(2023, 8, 25, 13, 10, 34, 539, DateTimeKind.Utc).AddTicks(5653) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 7, 22, 16, 5, 35, 218, DateTimeKind.Utc).AddTicks(1167), new DateTime(2023, 5, 14, 13, 33, 12, 847, DateTimeKind.Utc).AddTicks(7481) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 21, 16, 10, 59, 257, DateTimeKind.Utc).AddTicks(1642), new DateTime(2023, 8, 14, 16, 58, 39, 413, DateTimeKind.Utc).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 6, 16, 10, 5, 855, DateTimeKind.Utc).AddTicks(1874), new DateTime(2023, 4, 9, 2, 6, 23, 391, DateTimeKind.Utc).AddTicks(4048) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 11, 12, 18, 318, DateTimeKind.Utc).AddTicks(2003), new DateTime(2023, 4, 2, 11, 22, 18, 21, DateTimeKind.Utc).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 11, 18, 20, 49, 42, DateTimeKind.Utc).AddTicks(9685), new DateTime(2023, 5, 11, 22, 11, 42, 190, DateTimeKind.Utc).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 6, 22, 48, 50, 281, DateTimeKind.Utc).AddTicks(9514), new DateTime(2023, 6, 13, 1, 19, 23, 855, DateTimeKind.Utc).AddTicks(1987) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 5, 31, 9, 9, 27, 835, DateTimeKind.Utc).AddTicks(6254), new DateTime(2023, 3, 20, 0, 49, 45, 357, DateTimeKind.Utc).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 26, 10, 30, 28, 5, DateTimeKind.Utc).AddTicks(4454), new DateTime(2023, 7, 28, 4, 33, 59, 643, DateTimeKind.Utc).AddTicks(3285) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 21, 17, 39, 47, 499, DateTimeKind.Utc).AddTicks(6158), new DateTime(2023, 7, 31, 6, 11, 48, 486, DateTimeKind.Utc).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 27, 19, 57, 6, 295, DateTimeKind.Utc).AddTicks(5848), new DateTime(2023, 8, 30, 8, 8, 55, 406, DateTimeKind.Utc).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 9, 19, 2, 56, 940, DateTimeKind.Utc).AddTicks(4064), new DateTime(2023, 5, 26, 11, 41, 23, 837, DateTimeKind.Utc).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 1, 41, 54, 389, DateTimeKind.Utc).AddTicks(4155), new DateTime(2023, 6, 11, 23, 42, 42, 437, DateTimeKind.Utc).AddTicks(6613) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 10, 2, 15, 31, 57, 732, DateTimeKind.Utc).AddTicks(9953), new DateTime(2022, 11, 9, 6, 51, 36, 661, DateTimeKind.Utc).AddTicks(9825) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 29, 4, 57, 8, 670, DateTimeKind.Utc).AddTicks(2244), new DateTime(2023, 7, 22, 19, 42, 32, 988, DateTimeKind.Utc).AddTicks(5178) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 27, 6, 20, 7, 446, DateTimeKind.Utc).AddTicks(5996), new DateTime(2023, 8, 28, 5, 58, 50, 646, DateTimeKind.Utc).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 11, 18, 15, 22, 43, 95, DateTimeKind.Utc).AddTicks(6303), new DateTime(2023, 5, 4, 13, 9, 48, 63, DateTimeKind.Utc).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 7, 28, 2, 16, 11, 125, DateTimeKind.Utc).AddTicks(9185), new DateTime(2023, 3, 11, 15, 26, 57, 856, DateTimeKind.Utc).AddTicks(9843) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 10, 10, 32, 1, 69, DateTimeKind.Utc).AddTicks(7383), new DateTime(2023, 7, 14, 18, 4, 21, 341, DateTimeKind.Utc).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 20, 11, 46, 15, 798, DateTimeKind.Utc).AddTicks(2613), new DateTime(2023, 8, 25, 18, 29, 2, 794, DateTimeKind.Utc).AddTicks(9369) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 21, 8, 50, 1, 489, DateTimeKind.Utc).AddTicks(7277), new DateTime(2023, 5, 24, 22, 18, 47, 378, DateTimeKind.Utc).AddTicks(7563) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 2, 2, 58, 45, 480, DateTimeKind.Utc).AddTicks(7455), new DateTime(2023, 9, 3, 3, 36, 49, 914, DateTimeKind.Utc).AddTicks(5951) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 8, 9, 59, 16, 33, DateTimeKind.Utc).AddTicks(7694), new DateTime(2023, 6, 12, 23, 14, 58, 54, DateTimeKind.Utc).AddTicks(1099) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 9, 22, 50, 7, 152, DateTimeKind.Utc).AddTicks(4583), new DateTime(2023, 5, 23, 7, 41, 9, 432, DateTimeKind.Utc).AddTicks(3940) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 3, 21, 47, 22, 0, DateTimeKind.Utc).AddTicks(786), new DateTime(2023, 6, 30, 22, 10, 46, 86, DateTimeKind.Utc).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 2, 11, 4, 10, 240, DateTimeKind.Utc).AddTicks(9027), new DateTime(2023, 5, 14, 17, 59, 4, 566, DateTimeKind.Utc).AddTicks(4967) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 7, 22, 0, 37, 846, DateTimeKind.Utc).AddTicks(4691), new DateTime(2023, 8, 26, 18, 12, 52, 607, DateTimeKind.Utc).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "RegisteredAt",
                value: new DateTime(2016, 5, 19, 11, 50, 50, 107, DateTimeKind.Utc).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                column: "RegisteredAt",
                value: new DateTime(2016, 4, 10, 10, 9, 12, 762, DateTimeKind.Utc).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                column: "RegisteredAt",
                value: new DateTime(2017, 11, 8, 20, 56, 31, 413, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                column: "RegisteredAt",
                value: new DateTime(2018, 7, 23, 23, 1, 3, 350, DateTimeKind.Utc).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                column: "RegisteredAt",
                value: new DateTime(2017, 8, 14, 17, 8, 23, 646, DateTimeKind.Utc).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                column: "RegisteredAt",
                value: new DateTime(2022, 3, 1, 13, 19, 5, 686, DateTimeKind.Utc).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                column: "RegisteredAt",
                value: new DateTime(2020, 9, 14, 2, 45, 37, 653, DateTimeKind.Utc).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                column: "RegisteredAt",
                value: new DateTime(2022, 5, 26, 17, 14, 20, 180, DateTimeKind.Utc).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                column: "RegisteredAt",
                value: new DateTime(2021, 12, 2, 3, 14, 2, 681, DateTimeKind.Utc).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                column: "RegisteredAt",
                value: new DateTime(2018, 7, 18, 4, 43, 52, 4, DateTimeKind.Utc).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11L,
                column: "RegisteredAt",
                value: new DateTime(2022, 3, 23, 2, 1, 6, 37, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12L,
                column: "RegisteredAt",
                value: new DateTime(2019, 9, 13, 22, 59, 51, 322, DateTimeKind.Utc).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13L,
                column: "RegisteredAt",
                value: new DateTime(2021, 3, 8, 12, 55, 26, 416, DateTimeKind.Utc).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14L,
                column: "RegisteredAt",
                value: new DateTime(2016, 6, 9, 15, 35, 36, 645, DateTimeKind.Utc).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15L,
                column: "RegisteredAt",
                value: new DateTime(2022, 3, 11, 11, 7, 19, 596, DateTimeKind.Utc).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16L,
                column: "RegisteredAt",
                value: new DateTime(2017, 6, 21, 23, 40, 1, 941, DateTimeKind.Utc).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17L,
                column: "RegisteredAt",
                value: new DateTime(2016, 1, 19, 21, 48, 23, 982, DateTimeKind.Utc).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18L,
                column: "RegisteredAt",
                value: new DateTime(2022, 12, 24, 10, 34, 53, 723, DateTimeKind.Utc).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19L,
                column: "RegisteredAt",
                value: new DateTime(2022, 4, 12, 10, 8, 56, 953, DateTimeKind.Utc).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20L,
                column: "RegisteredAt",
                value: new DateTime(2020, 12, 14, 10, 21, 44, 200, DateTimeKind.Utc).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21L,
                column: "RegisteredAt",
                value: new DateTime(2017, 1, 23, 19, 55, 35, 254, DateTimeKind.Utc).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22L,
                column: "RegisteredAt",
                value: new DateTime(2018, 5, 2, 21, 55, 35, 436, DateTimeKind.Utc).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23L,
                column: "RegisteredAt",
                value: new DateTime(2021, 11, 5, 6, 3, 7, 121, DateTimeKind.Utc).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24L,
                column: "RegisteredAt",
                value: new DateTime(2021, 4, 24, 21, 49, 1, 432, DateTimeKind.Utc).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25L,
                column: "RegisteredAt",
                value: new DateTime(2019, 2, 20, 10, 14, 32, 707, DateTimeKind.Utc).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26L,
                column: "RegisteredAt",
                value: new DateTime(2016, 6, 21, 10, 7, 48, 91, DateTimeKind.Utc).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27L,
                column: "RegisteredAt",
                value: new DateTime(2021, 12, 10, 0, 51, 55, 187, DateTimeKind.Utc).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28L,
                column: "RegisteredAt",
                value: new DateTime(2016, 7, 17, 23, 28, 42, 140, DateTimeKind.Utc).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29L,
                column: "RegisteredAt",
                value: new DateTime(2017, 8, 3, 5, 19, 17, 768, DateTimeKind.Utc).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30L,
                column: "RegisteredAt",
                value: new DateTime(2020, 8, 20, 10, 8, 50, 391, DateTimeKind.Utc).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31L,
                column: "RegisteredAt",
                value: new DateTime(2016, 12, 16, 5, 10, 37, 72, DateTimeKind.Utc).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32L,
                column: "RegisteredAt",
                value: new DateTime(2016, 12, 24, 6, 36, 28, 966, DateTimeKind.Utc).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33L,
                column: "RegisteredAt",
                value: new DateTime(2021, 11, 25, 7, 50, 20, 667, DateTimeKind.Utc).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34L,
                column: "RegisteredAt",
                value: new DateTime(2023, 3, 10, 11, 28, 52, 138, DateTimeKind.Utc).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35L,
                column: "RegisteredAt",
                value: new DateTime(2022, 2, 14, 15, 5, 49, 198, DateTimeKind.Utc).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36L,
                column: "RegisteredAt",
                value: new DateTime(2020, 4, 6, 13, 24, 5, 530, DateTimeKind.Utc).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37L,
                column: "RegisteredAt",
                value: new DateTime(2016, 5, 7, 4, 52, 40, 318, DateTimeKind.Utc).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38L,
                column: "RegisteredAt",
                value: new DateTime(2018, 12, 20, 4, 12, 15, 130, DateTimeKind.Utc).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39L,
                column: "RegisteredAt",
                value: new DateTime(2016, 7, 24, 12, 45, 52, 906, DateTimeKind.Utc).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40L,
                column: "RegisteredAt",
                value: new DateTime(2017, 10, 20, 3, 35, 3, 614, DateTimeKind.Utc).AddTicks(8614));

            migrationBuilder.CreateIndex(
                name: "IX_Tests_ChallengeVersionId",
                table: "Tests",
                column: "ChallengeVersionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_ChallengeVersions_ChallengeVersionId",
                table: "Tests",
                column: "ChallengeVersionId",
                principalTable: "ChallengeVersions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
