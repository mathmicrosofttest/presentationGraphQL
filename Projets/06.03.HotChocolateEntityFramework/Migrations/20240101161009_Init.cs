using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _06_03.HotChocolateEntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false),
                    CompanyId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Vin = table.Column<string>(type: "TEXT", nullable: false),
                    Fuel = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CompanyId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0159c31c-99ae-464f-a6cc-ededd44600b1"), "Terry Inc" },
                    { new Guid("10344a04-defb-4875-bc15-ec6e973b4e77"), "O'Keefe - Emmerich" },
                    { new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Barton - Oberbrunner" },
                    { new Guid("51d70f2a-dcba-44c9-ab02-d32ba7c20888"), "Dickens - McClure" },
                    { new Guid("7860b54d-5388-49e9-b4ce-fc3c47a59201"), "Kiehn - Quitzon" },
                    { new Guid("788dda47-40c3-4013-8509-3718406e576f"), "Cormier Inc" },
                    { new Guid("95492c98-52ae-4857-9b6d-d499ad965781"), "Lind and Sons" },
                    { new Guid("acd0d6c0-64bd-46c7-92b9-53aea9060412"), "Pollich, Schoen and Glover" },
                    { new Guid("dacccc0a-0470-4e0d-bef6-52258192e8d3"), "Boehm, Hartmann and Conn" },
                    { new Guid("e40211ab-7cb7-4b03-9687-a455ea8f486a"), "Senger - Trantow" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CompanyId", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { new Guid("0292ea56-45c3-4e48-956b-c457622a53e4"), new Guid("7860b54d-5388-49e9-b4ce-fc3c47a59201"), "Danielle28@yahoo.com", "Danielle", "Berge", "(937) 346-7638" },
                    { new Guid("0456f269-8c66-4203-90c5-ffa650fdabf0"), new Guid("7860b54d-5388-49e9-b4ce-fc3c47a59201"), "Courtney_Reynolds24@gmail.com", "Courtney", "Reynolds", "1-725-960-0924 x7408" },
                    { new Guid("056ad579-3dc6-4723-bb1d-1ae63ac0c48a"), new Guid("dacccc0a-0470-4e0d-bef6-52258192e8d3"), "Miguel81@gmail.com", "Miguel", "Grant", "1-958-804-2535 x50272" },
                    { new Guid("09887250-80c4-4775-9c04-7e44cc1a5df0"), new Guid("dacccc0a-0470-4e0d-bef6-52258192e8d3"), "Emily_Lueilwitz34@yahoo.com", "Emily", "Lueilwitz", "1-957-529-9203 x4085" },
                    { new Guid("0d36673c-eeb8-4e50-88f9-2356fe5472d6"), new Guid("788dda47-40c3-4013-8509-3718406e576f"), "Garrett36@yahoo.com", "Garrett", "Spinka", "310-461-5202 x292" },
                    { new Guid("0d5ae744-a6c6-403d-9fb4-dbfc1ea11870"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Shannon.Terry@yahoo.com", "Shannon", "Terry", "(637) 537-2341" },
                    { new Guid("0d63ac92-15fa-4595-947a-9cc27299a68a"), new Guid("10344a04-defb-4875-bc15-ec6e973b4e77"), "Edgar.Morissette73@yahoo.com", "Edgar", "Morissette", "478-412-2113 x6689" },
                    { new Guid("1023280a-b2fb-49aa-b14f-aed0fcdc1e3f"), new Guid("10344a04-defb-4875-bc15-ec6e973b4e77"), "Lynn_Wyman@gmail.com", "Lynn", "Wyman", "(216) 301-3192 x4400" },
                    { new Guid("1287a5df-25d3-4217-ae27-362bdfbdbe1f"), new Guid("10344a04-defb-4875-bc15-ec6e973b4e77"), "Leland_Sauer14@yahoo.com", "Leland", "Sauer", "879-356-8919" },
                    { new Guid("15a44f02-8bea-48e8-a075-d1554e53f54e"), new Guid("0159c31c-99ae-464f-a6cc-ededd44600b1"), "Marjorie_Schuster66@yahoo.com", "Marjorie", "Schuster", "569-541-1634" },
                    { new Guid("17ada71d-217a-4041-b376-1050552abd11"), new Guid("51d70f2a-dcba-44c9-ab02-d32ba7c20888"), "George.Weber28@gmail.com", "George", "Weber", "348-830-5118 x25444" },
                    { new Guid("18cfa8cd-213f-4256-b193-0ca9a41fdcd2"), new Guid("10344a04-defb-4875-bc15-ec6e973b4e77"), "Tonya.Mayer@yahoo.com", "Tonya", "Mayer", "202-350-5639" },
                    { new Guid("19ae4eb8-19e7-47d1-a2ac-f0f8498b26e0"), new Guid("dacccc0a-0470-4e0d-bef6-52258192e8d3"), "Vernon71@yahoo.com", "Vernon", "Zemlak", "991.902.5189 x4590" },
                    { new Guid("1ca6d610-cf14-48b4-b8aa-2b94ae819e7d"), new Guid("10344a04-defb-4875-bc15-ec6e973b4e77"), "Freda86@yahoo.com", "Freda", "Morar", "1-207-846-0957 x1170" },
                    { new Guid("2306b740-43f8-48e1-be4a-4aa28961da26"), new Guid("788dda47-40c3-4013-8509-3718406e576f"), "Larry12@hotmail.com", "Larry", "Crooks", "(782) 535-5086" },
                    { new Guid("28821f3f-63a3-4759-ae15-3dd0b99154e7"), new Guid("e40211ab-7cb7-4b03-9687-a455ea8f486a"), "Abel87@gmail.com", "Abel", "Marks", "318-682-1956 x1807" },
                    { new Guid("2c06d082-7a07-43ce-8952-900549177d5f"), new Guid("0159c31c-99ae-464f-a6cc-ededd44600b1"), "Clyde.Jacobs48@gmail.com", "Clyde", "Jacobs", "950-793-2979 x1436" },
                    { new Guid("2cda9372-9eaf-47e6-87b8-c5165d98b6af"), new Guid("10344a04-defb-4875-bc15-ec6e973b4e77"), "Delia.Hessel@hotmail.com", "Delia", "Hessel", "1-593-373-7179" },
                    { new Guid("3079c526-4dac-42b6-a220-30fc648f938b"), new Guid("95492c98-52ae-4857-9b6d-d499ad965781"), "Terence64@yahoo.com", "Terence", "Kunze", "787-722-8242" },
                    { new Guid("33dcf9b8-622a-4078-ac70-ae205d41d2cc"), new Guid("51d70f2a-dcba-44c9-ab02-d32ba7c20888"), "Ray78@hotmail.com", "Ray", "Jaskolski", "566.913.2621 x01532" },
                    { new Guid("3b8a7808-760f-4343-89e4-e09dcd5cbbcd"), new Guid("dacccc0a-0470-4e0d-bef6-52258192e8d3"), "Norma2@hotmail.com", "Norma", "Kunde", "(464) 787-0977 x367" },
                    { new Guid("41bed6ed-637f-455b-9405-64b5d490086d"), new Guid("0159c31c-99ae-464f-a6cc-ededd44600b1"), "Terry.Johnston41@yahoo.com", "Terry", "Johnston", "526.910.5225 x05802" },
                    { new Guid("48f2e3b0-3109-4e21-8f7b-027efca0bf9b"), new Guid("10344a04-defb-4875-bc15-ec6e973b4e77"), "Leonard34@hotmail.com", "Leonard", "Weissnat", "386.457.3367 x314" },
                    { new Guid("4eaa0ad3-5ac0-4e6e-b387-cc80d1997269"), new Guid("dacccc0a-0470-4e0d-bef6-52258192e8d3"), "Lloyd.Bashirian@hotmail.com", "Lloyd", "Bashirian", "(844) 387-5957 x22171" },
                    { new Guid("569645c5-a69e-49a9-9ad3-7cabc216b3db"), new Guid("10344a04-defb-4875-bc15-ec6e973b4e77"), "Randy55@yahoo.com", "Randy", "Hilll", "944-736-6321" },
                    { new Guid("5c66c6ca-7ca4-4b0c-85ba-8369e035dc7a"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Gerald_Schiller@hotmail.com", "Gerald", "Schiller", "580.540.8825" },
                    { new Guid("6490db6f-1bf1-4dfe-9177-243e985f0614"), new Guid("95492c98-52ae-4857-9b6d-d499ad965781"), "Casey45@gmail.com", "Casey", "Kerluke", "235.360.3633 x5330" },
                    { new Guid("6540c58c-370b-4acb-8bb3-c359d451ee96"), new Guid("788dda47-40c3-4013-8509-3718406e576f"), "John_Murazik30@hotmail.com", "John", "Murazik", "352.851.9183 x93996" },
                    { new Guid("65d28ce2-1bd6-4b8d-9c15-3a1b00c5b80d"), new Guid("788dda47-40c3-4013-8509-3718406e576f"), "Steve_Bergstrom@yahoo.com", "Steve", "Bergstrom", "285.424.9576 x23000" },
                    { new Guid("6634bb07-20c2-4e4b-a275-bc340e7c9f9e"), new Guid("dacccc0a-0470-4e0d-bef6-52258192e8d3"), "Estelle_Rutherford33@hotmail.com", "Estelle", "Rutherford", "735.896.2527 x753" },
                    { new Guid("683733c7-ed49-4baa-9d07-f0a8ebf3e0e4"), new Guid("7860b54d-5388-49e9-b4ce-fc3c47a59201"), "Felix.Abernathy45@gmail.com", "Felix", "Abernathy", "1-596-362-4966" },
                    { new Guid("684b5a3d-cff0-45af-9b1d-11591617659b"), new Guid("e40211ab-7cb7-4b03-9687-a455ea8f486a"), "Darrell_Walter88@hotmail.com", "Darrell", "Walter", "201-665-7767 x9001" },
                    { new Guid("68c7d70e-5992-423e-b056-24602b83dc34"), new Guid("788dda47-40c3-4013-8509-3718406e576f"), "Brad_Boehm29@gmail.com", "Brad", "Boehm", "677-759-5237" },
                    { new Guid("6dd39c5f-f465-49fa-81ff-6b7bc70bd0cf"), new Guid("acd0d6c0-64bd-46c7-92b9-53aea9060412"), "Nettie.Sanford54@hotmail.com", "Nettie", "Sanford", "(776) 802-2252" },
                    { new Guid("6e835312-9cac-444b-82a2-9a5d4859d5be"), new Guid("51d70f2a-dcba-44c9-ab02-d32ba7c20888"), "Clara.Pouros51@yahoo.com", "Clara", "Pouros", "(208) 251-5903" },
                    { new Guid("7ae08f52-4e03-4336-9aad-1b0a7ed7b543"), new Guid("acd0d6c0-64bd-46c7-92b9-53aea9060412"), "Jaime_Greenfelder49@hotmail.com", "Jaime", "Greenfelder", "1-440-731-4720" },
                    { new Guid("80351255-9ae9-43e1-8f0f-fdfd3a2dc7ad"), new Guid("51d70f2a-dcba-44c9-ab02-d32ba7c20888"), "Chris97@yahoo.com", "Chris", "Rath", "877-746-0569 x8879" },
                    { new Guid("83957e53-d926-47f7-8450-9f649ff289a1"), new Guid("acd0d6c0-64bd-46c7-92b9-53aea9060412"), "Dale.Medhurst52@gmail.com", "Dale", "Medhurst", "828-935-7159 x56286" },
                    { new Guid("8650a20f-1a97-4b2d-b96d-efd2c36cb972"), new Guid("788dda47-40c3-4013-8509-3718406e576f"), "Juan.Abshire71@gmail.com", "Juan", "Abshire", "270-880-4035" },
                    { new Guid("89140d20-41ab-46a7-a9a4-c3e666fc39c5"), new Guid("51d70f2a-dcba-44c9-ab02-d32ba7c20888"), "Cassandra54@yahoo.com", "Cassandra", "Borer", "1-768-679-1883 x043" },
                    { new Guid("8b62c70b-1d47-4d23-b864-7d1707ce0449"), new Guid("7860b54d-5388-49e9-b4ce-fc3c47a59201"), "Jorge23@yahoo.com", "Jorge", "McKenzie", "1-640-841-8795" },
                    { new Guid("8c018102-4657-4fa3-9b78-98cab50b60c4"), new Guid("0159c31c-99ae-464f-a6cc-ededd44600b1"), "Ted.Morissette@hotmail.com", "Ted", "Morissette", "1-581-330-0169 x6778" },
                    { new Guid("8eedd0f5-844f-4b9a-ab70-7659af302835"), new Guid("acd0d6c0-64bd-46c7-92b9-53aea9060412"), "Yvette_Lemke36@yahoo.com", "Yvette", "Lemke", "484-428-3990" },
                    { new Guid("9137e9dd-84d0-4d41-b8c4-b84f00c4bb02"), new Guid("95492c98-52ae-4857-9b6d-d499ad965781"), "Jody.Turcotte8@yahoo.com", "Jody", "Turcotte", "1-765-862-8587 x92254" },
                    { new Guid("931853bf-316b-4800-b7a7-a48d89b31ffd"), new Guid("e40211ab-7cb7-4b03-9687-a455ea8f486a"), "Hector83@gmail.com", "Hector", "Boyle", "624.555.1357 x7039" },
                    { new Guid("977892a8-e743-4e9d-9775-1524893df08d"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Chelsea12@yahoo.com", "Chelsea", "O'Reilly", "(382) 306-8399" },
                    { new Guid("989f3250-e540-4dc0-a352-8c5de7c3f8b4"), new Guid("51d70f2a-dcba-44c9-ab02-d32ba7c20888"), "Joseph35@gmail.com", "Joseph", "Runolfsdottir", "975.430.1624" },
                    { new Guid("99cd7e07-6045-4398-a5e8-94f1e7200d8c"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Derek60@gmail.com", "Derek", "Hegmann", "729.987.2503 x264" },
                    { new Guid("9af21342-4064-4d6d-9540-a2d02c59c575"), new Guid("51d70f2a-dcba-44c9-ab02-d32ba7c20888"), "Christy_Moore@hotmail.com", "Christy", "Moore", "620-736-9821" },
                    { new Guid("9c9bdcc5-7e11-47c3-85c1-9eb1ccf21878"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Hubert96@yahoo.com", "Hubert", "White", "392.837.7587 x5956" },
                    { new Guid("9cf7cffd-c18f-48fc-88fd-2dcefab3f951"), new Guid("95492c98-52ae-4857-9b6d-d499ad965781"), "Clinton63@gmail.com", "Clinton", "Roob", "245-252-0522" },
                    { new Guid("a0f043f8-0082-4e9b-99b3-9ba6f3cd9a62"), new Guid("95492c98-52ae-4857-9b6d-d499ad965781"), "Krista.Parisian@hotmail.com", "Krista", "Parisian", "(624) 517-7097" },
                    { new Guid("a9405025-c36f-42e5-b893-6cb3c344e6c0"), new Guid("10344a04-defb-4875-bc15-ec6e973b4e77"), "Alan.Steuber56@yahoo.com", "Alan", "Steuber", "1-223-498-4247 x039" },
                    { new Guid("a9521f70-b9bc-423a-8db2-02493bc84000"), new Guid("e40211ab-7cb7-4b03-9687-a455ea8f486a"), "Joyce6@yahoo.com", "Joyce", "Paucek", "780-244-7720" },
                    { new Guid("bc38be9e-c198-405c-a569-31bb996a4483"), new Guid("dacccc0a-0470-4e0d-bef6-52258192e8d3"), "Nathan.Parisian13@gmail.com", "Nathan", "Parisian", "376.971.9066 x917" },
                    { new Guid("c11329d9-99b6-43fe-9ac8-37478f3633a3"), new Guid("10344a04-defb-4875-bc15-ec6e973b4e77"), "Dana.Hammes34@hotmail.com", "Dana", "Hammes", "465.248.2355" },
                    { new Guid("c128ace2-fc0a-4d15-ad60-314a46d11183"), new Guid("95492c98-52ae-4857-9b6d-d499ad965781"), "Leon_Hermann78@gmail.com", "Leon", "Hermann", "624-902-1357 x72458" },
                    { new Guid("c1d5801d-26cf-4541-99ec-394ae2526dac"), new Guid("0159c31c-99ae-464f-a6cc-ededd44600b1"), "Amy.DuBuque92@yahoo.com", "Amy", "DuBuque", "(293) 680-0636" },
                    { new Guid("c29aeb4e-47bf-4de6-87cf-13960b5b3843"), new Guid("10344a04-defb-4875-bc15-ec6e973b4e77"), "Mark_Gleichner61@gmail.com", "Mark", "Gleichner", "816.656.4011 x2489" },
                    { new Guid("c720117b-0eba-4e2d-891a-0605d304ce0a"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Wm_Reynolds@gmail.com", "Wm", "Reynolds", "748.404.9394 x1060" },
                    { new Guid("c7c4cbe8-fb2d-4a3b-848d-ee6d0b7948b2"), new Guid("dacccc0a-0470-4e0d-bef6-52258192e8d3"), "Toby31@hotmail.com", "Toby", "Auer", "312-256-1886" },
                    { new Guid("c80b8143-f8b8-4051-8e89-96f47eb28a29"), new Guid("7860b54d-5388-49e9-b4ce-fc3c47a59201"), "Karla.Reynolds8@yahoo.com", "Karla", "Reynolds", "280-979-1199 x1552" },
                    { new Guid("c9ab829c-f2f8-471a-8a01-b1ca02c5b182"), new Guid("10344a04-defb-4875-bc15-ec6e973b4e77"), "Shelly_Reichel14@hotmail.com", "Shelly", "Reichel", "1-917-753-3648" },
                    { new Guid("cb6e78a1-3536-4985-8c77-cc4494d8cf17"), new Guid("0159c31c-99ae-464f-a6cc-ededd44600b1"), "Louis.Gislason1@gmail.com", "Louis", "Gislason", "1-735-947-9587 x6746" },
                    { new Guid("cff29386-b7fc-4e98-96b9-c56f36d8db16"), new Guid("788dda47-40c3-4013-8509-3718406e576f"), "Adrian.Homenick55@hotmail.com", "Adrian", "Homenick", "611.394.8504 x1581" },
                    { new Guid("d9e48c79-0f4d-4429-9351-1135e503078a"), new Guid("0159c31c-99ae-464f-a6cc-ededd44600b1"), "Sam27@gmail.com", "Sam", "Zemlak", "(446) 471-1055 x26094" },
                    { new Guid("da2a6aff-018d-4545-ba39-80b8097e506f"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Ann_Gutmann@hotmail.com", "Ann", "Gutmann", "1-435-873-4587 x73369" },
                    { new Guid("df4c259f-da94-4fe4-a760-500291196391"), new Guid("e40211ab-7cb7-4b03-9687-a455ea8f486a"), "Fredrick_Christiansen@yahoo.com", "Fredrick", "Christiansen", "963.513.5207 x5427" },
                    { new Guid("e0ebfdfa-e702-456c-bcbb-a55aeaec7820"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Ramiro.MacGyver@yahoo.com", "Ramiro", "MacGyver", "633-446-1090 x855" },
                    { new Guid("e3326281-6ddf-4785-aa10-e4c25f2eb6df"), new Guid("acd0d6c0-64bd-46c7-92b9-53aea9060412"), "Vera.Goodwin55@gmail.com", "Vera", "Goodwin", "(483) 539-3679 x0297" },
                    { new Guid("e8482501-8fe5-4a28-8400-689575c47951"), new Guid("7860b54d-5388-49e9-b4ce-fc3c47a59201"), "Wesley_Johnston@yahoo.com", "Wesley", "Johnston", "(601) 272-3030 x12684" },
                    { new Guid("ea7232d3-fa7e-4c1d-9fd4-7f1674ea0654"), new Guid("7860b54d-5388-49e9-b4ce-fc3c47a59201"), "Roy85@yahoo.com", "Roy", "Ebert", "1-281-657-7381" },
                    { new Guid("edf563fa-a49d-4096-8a30-1b05f87e8944"), new Guid("e40211ab-7cb7-4b03-9687-a455ea8f486a"), "Jim_Breitenberg@hotmail.com", "Jim", "Breitenberg", "(593) 754-9832 x017" },
                    { new Guid("f4e3d6bf-cfa9-41c4-875a-ae821c06c23e"), new Guid("acd0d6c0-64bd-46c7-92b9-53aea9060412"), "Kristopher.Herzog44@yahoo.com", "Kristopher", "Herzog", "225-815-1981 x4723" },
                    { new Guid("ff2231b5-e78a-43a6-b16f-e2376dc4bcec"), new Guid("7860b54d-5388-49e9-b4ce-fc3c47a59201"), "Louis_Connelly@gmail.com", "Louis", "Connelly", "734-377-6822 x542" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CompanyId", "Fuel", "Model", "UserId", "Vin" },
                values: new object[,]
                {
                    { new Guid("0047d6fc-baef-4f0e-a209-8497181c9691"), new Guid("0159c31c-99ae-464f-a6cc-ededd44600b1"), "Hybrid", "Cruze", new Guid("ea7232d3-fa7e-4c1d-9fd4-7f1674ea0654"), "YNV0W3DP6HB197120" },
                    { new Guid("0061c294-1b82-4c51-a3c5-d728dc2b1a2d"), new Guid("95492c98-52ae-4857-9b6d-d499ad965781"), "Electric", "Model T", new Guid("989f3250-e540-4dc0-a352-8c5de7c3f8b4"), "ATT26RLPTMTT89883" },
                    { new Guid("01ad9ea5-7503-4216-a7ba-34a1bd738387"), new Guid("7860b54d-5388-49e9-b4ce-fc3c47a59201"), "Hybrid", "Model S", new Guid("6540c58c-370b-4acb-8bb3-c359d451ee96"), "H0BJEZDQJVH223027" },
                    { new Guid("04d60a31-c1e7-4e9d-83aa-f86f28c24cdc"), new Guid("95492c98-52ae-4857-9b6d-d499ad965781"), "Gasoline", "PT Cruiser", new Guid("c11329d9-99b6-43fe-9ac8-37478f3633a3"), "PROT97JH9VBC27109" },
                    { new Guid("064f0743-2425-4a28-947e-ff8c8e6a91fd"), new Guid("51d70f2a-dcba-44c9-ab02-d32ba7c20888"), "Diesel", "Land Cruiser", new Guid("e0ebfdfa-e702-456c-bcbb-a55aeaec7820"), "UBBENQ651JO765668" },
                    { new Guid("07dd755f-9c17-4de3-9a97-d8cfb1b854d9"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Electric", "Fiesta", new Guid("684b5a3d-cff0-45af-9b1d-11591617659b"), "3S8C3B237NWG80417" },
                    { new Guid("0a7f3af1-a238-447c-a439-4a18d6ddc3f4"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Diesel", "El Camino", new Guid("6634bb07-20c2-4e4b-a275-bc340e7c9f9e"), "29GASNDXMCHE19236" },
                    { new Guid("0bbf3ad8-ee36-42b6-be01-7135c7d0c569"), new Guid("dacccc0a-0470-4e0d-bef6-52258192e8d3"), "Hybrid", "A4", new Guid("5c66c6ca-7ca4-4b0c-85ba-8369e035dc7a"), "KZLRWBKLOZAQ87610" },
                    { new Guid("0c4251bc-36a4-4e3e-950d-570c0ec95585"), new Guid("51d70f2a-dcba-44c9-ab02-d32ba7c20888"), "Hybrid", "Prius", new Guid("c720117b-0eba-4e2d-891a-0605d304ce0a"), "HDZBF4WYDYC128136" },
                    { new Guid("0c8a7586-d27e-4b0e-8546-6e568b68d3b7"), new Guid("10344a04-defb-4875-bc15-ec6e973b4e77"), "Diesel", "XTS", new Guid("83957e53-d926-47f7-8450-9f649ff289a1"), "5BLVQK0ZD7ZR94856" },
                    { new Guid("0dc1157e-5681-4ce0-86c7-adefc8ea4c06"), new Guid("788dda47-40c3-4013-8509-3718406e576f"), "Gasoline", "XTS", new Guid("056ad579-3dc6-4723-bb1d-1ae63ac0c48a"), "R4SZID1U4SG938162" },
                    { new Guid("0ef18306-0c0b-4fe9-94e3-1e453491b2d0"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Gasoline", "A4", new Guid("c9ab829c-f2f8-471a-8a01-b1ca02c5b182"), "L0A89J7CK0HT24015" },
                    { new Guid("0f878153-578c-4e66-bc92-f66eefedec96"), new Guid("0159c31c-99ae-464f-a6cc-ededd44600b1"), "Hybrid", "Wrangler", new Guid("e3326281-6ddf-4785-aa10-e4c25f2eb6df"), "4CG012093OJB63866" },
                    { new Guid("11c57c8d-f5f0-4bc4-9662-737da5fafdee"), new Guid("acd0d6c0-64bd-46c7-92b9-53aea9060412"), "Diesel", "Mercielago", new Guid("c128ace2-fc0a-4d15-ad60-314a46d11183"), "EXH4PJA2JXIW14363" },
                    { new Guid("120e5664-77e0-4394-aa60-bb15ae275c67"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Hybrid", "Fiesta", new Guid("5c66c6ca-7ca4-4b0c-85ba-8369e035dc7a"), "W3WSIBC88XW626975" },
                    { new Guid("1214c2c6-6035-459b-bb8d-6d234b878f27"), new Guid("dacccc0a-0470-4e0d-bef6-52258192e8d3"), "Hybrid", "Alpine", new Guid("a0f043f8-0082-4e9b-99b3-9ba6f3cd9a62"), "I7XN2CZRUFGW91581" },
                    { new Guid("123885ff-70e6-4ad7-938a-a3a5aa5acafd"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Electric", "Countach", new Guid("0d5ae744-a6c6-403d-9fb4-dbfc1ea11870"), "X9KZKICHMLYX64148" },
                    { new Guid("124c3413-9a13-4469-8db6-670bf18e6e4f"), new Guid("10344a04-defb-4875-bc15-ec6e973b4e77"), "Electric", "A8", new Guid("3079c526-4dac-42b6-a220-30fc648f938b"), "LC304I7Y0SXN25891" },
                    { new Guid("13178614-7a29-469d-924d-d3abcff487c5"), new Guid("788dda47-40c3-4013-8509-3718406e576f"), "Hybrid", "Jetta", new Guid("33dcf9b8-622a-4078-ac70-ae205d41d2cc"), "R8HJTGQT16OB61360" },
                    { new Guid("1721a219-68e9-4021-b1fe-8ff7e06a2b02"), new Guid("0159c31c-99ae-464f-a6cc-ededd44600b1"), "Diesel", "XC90", new Guid("e8482501-8fe5-4a28-8400-689575c47951"), "44ZY5II9B3AX11564" },
                    { new Guid("18dbba9e-3b3e-460b-b86d-466dd82cec38"), new Guid("95492c98-52ae-4857-9b6d-d499ad965781"), "Electric", "Charger", new Guid("e0ebfdfa-e702-456c-bcbb-a55aeaec7820"), "L7SSEA9VTLGK29928" },
                    { new Guid("1a9f2cd2-591e-4e5d-995c-b3171a5358fd"), new Guid("e40211ab-7cb7-4b03-9687-a455ea8f486a"), "Electric", "LeBaron", new Guid("65d28ce2-1bd6-4b8d-9c15-3a1b00c5b80d"), "GC0OIU9RLCE831868" },
                    { new Guid("1ae40588-e1cc-49be-b2cf-d38116b8fb8a"), new Guid("e40211ab-7cb7-4b03-9687-a455ea8f486a"), "Diesel", "Jetta", new Guid("a9405025-c36f-42e5-b893-6cb3c344e6c0"), "C9AQDHFRINIW23617" },
                    { new Guid("1c6ebb3f-2b11-4f73-850e-acc4b688b9f5"), new Guid("10344a04-defb-4875-bc15-ec6e973b4e77"), "Diesel", "Civic", new Guid("19ae4eb8-19e7-47d1-a2ac-f0f8498b26e0"), "US20A0WLS1SZ40285" },
                    { new Guid("23a3b8a4-3fe7-43ef-8ae6-c0a6ca8ca989"), new Guid("788dda47-40c3-4013-8509-3718406e576f"), "Hybrid", "A8", new Guid("683733c7-ed49-4baa-9d07-f0a8ebf3e0e4"), "N4DZ43ZI9NQ099511" },
                    { new Guid("24487746-f599-4dc3-a6ab-59d1fbca325c"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Electric", "Model S", new Guid("c80b8143-f8b8-4051-8e89-96f47eb28a29"), "S6M9QC0REIGA41695" },
                    { new Guid("24911503-8f57-4aa1-8db5-fdf24f0cb1fd"), new Guid("95492c98-52ae-4857-9b6d-d499ad965781"), "Electric", "Land Cruiser", new Guid("65d28ce2-1bd6-4b8d-9c15-3a1b00c5b80d"), "FMX8H2EEPIWP88201" },
                    { new Guid("2498e8b6-fca6-440f-b99e-bd05de3e07cd"), new Guid("95492c98-52ae-4857-9b6d-d499ad965781"), "Electric", "ATS", new Guid("19ae4eb8-19e7-47d1-a2ac-f0f8498b26e0"), "172L6Y4WDHOG87836" },
                    { new Guid("24ed53d2-5d8d-47c9-b11a-c5428f600960"), new Guid("0159c31c-99ae-464f-a6cc-ededd44600b1"), "Diesel", "XC90", new Guid("977892a8-e743-4e9d-9775-1524893df08d"), "KBB98VUQ1YQ757760" },
                    { new Guid("2535a73e-2ee4-48ee-af40-e19db4c9eb92"), new Guid("acd0d6c0-64bd-46c7-92b9-53aea9060412"), "Hybrid", "Grand Cherokee", new Guid("6e835312-9cac-444b-82a2-9a5d4859d5be"), "UKQZWJIA64AW64166" },
                    { new Guid("2741d210-b5e0-4ed8-87ac-9f3a00b563a1"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Hybrid", "Corvette", new Guid("9137e9dd-84d0-4d41-b8c4-b84f00c4bb02"), "FVLEJ1H555TS46809" },
                    { new Guid("28102ec4-ff9f-40d5-99d8-afe6a9055881"), new Guid("0159c31c-99ae-464f-a6cc-ededd44600b1"), "Electric", "Volt", new Guid("1287a5df-25d3-4217-ae27-362bdfbdbe1f"), "34ZGUK2F6KW557844" },
                    { new Guid("2885c760-47b4-48c0-94cc-43e6971364cc"), new Guid("7860b54d-5388-49e9-b4ce-fc3c47a59201"), "Diesel", "Model T", new Guid("4eaa0ad3-5ac0-4e6e-b387-cc80d1997269"), "4LERIGT4WHG194205" },
                    { new Guid("28ad653f-959e-4cbe-b4c2-a9ca61ac64ad"), new Guid("7860b54d-5388-49e9-b4ce-fc3c47a59201"), "Hybrid", "Accord", new Guid("2c06d082-7a07-43ce-8952-900549177d5f"), "H0569HUXKIV318633" },
                    { new Guid("2afd7c23-9692-4b41-88b1-16f2d34d600f"), new Guid("dacccc0a-0470-4e0d-bef6-52258192e8d3"), "Electric", "Altima", new Guid("9c9bdcc5-7e11-47c3-85c1-9eb1ccf21878"), "4UW0DMH7RJJ269891" },
                    { new Guid("2b591ea2-f912-45b6-99a1-c1704a4545a9"), new Guid("acd0d6c0-64bd-46c7-92b9-53aea9060412"), "Gasoline", "LeBaron", new Guid("931853bf-316b-4800-b7a7-a48d89b31ffd"), "DYCPJD14L7MR81322" },
                    { new Guid("2ddf4f75-a45b-4055-a513-d3c706e20d7e"), new Guid("7860b54d-5388-49e9-b4ce-fc3c47a59201"), "Diesel", "A8", new Guid("80351255-9ae9-43e1-8f0f-fdfd3a2dc7ad"), "HDVFLWQ315K338763" },
                    { new Guid("30dbb735-3dcd-45ba-8836-1d8055ff7c61"), new Guid("0159c31c-99ae-464f-a6cc-ededd44600b1"), "Hybrid", "Fiesta", new Guid("19ae4eb8-19e7-47d1-a2ac-f0f8498b26e0"), "0V5J036BTDE386977" },
                    { new Guid("31337023-5972-4917-9fa4-2a3f54221655"), new Guid("0159c31c-99ae-464f-a6cc-ededd44600b1"), "Hybrid", "Roadster", new Guid("09887250-80c4-4775-9c04-7e44cc1a5df0"), "Q6GV4WKJWHP229387" },
                    { new Guid("335fd978-8664-4fb8-a0b4-dd2addc06382"), new Guid("788dda47-40c3-4013-8509-3718406e576f"), "Diesel", "ATS", new Guid("d9e48c79-0f4d-4429-9351-1135e503078a"), "TS1N39OTC5RL31917" },
                    { new Guid("3b47b387-008f-4628-819e-252dffc6c58c"), new Guid("788dda47-40c3-4013-8509-3718406e576f"), "Electric", "Mustang", new Guid("931853bf-316b-4800-b7a7-a48d89b31ffd"), "8UMYWA44H2P862121" },
                    { new Guid("3ca0c3c9-90ad-4da1-b2be-ab70c1421b4c"), new Guid("95492c98-52ae-4857-9b6d-d499ad965781"), "Electric", "LeBaron", new Guid("15a44f02-8bea-48e8-a075-d1554e53f54e"), "IBDCFN61W2VJ62853" },
                    { new Guid("414b3ec7-0320-4680-ba18-eddcaea69a12"), new Guid("7860b54d-5388-49e9-b4ce-fc3c47a59201"), "Hybrid", "Silverado", new Guid("9af21342-4064-4d6d-9540-a2d02c59c575"), "FZJQM8B103NJ69616" },
                    { new Guid("41b54a5d-fc84-4647-aaca-79d6b889eba7"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Diesel", "Mercielago", new Guid("89140d20-41ab-46a7-a9a4-c3e666fc39c5"), "W1O8KOCDV6RD66071" },
                    { new Guid("436d0cb5-d509-42b0-93a8-019496cae1d1"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Electric", "Fortwo", new Guid("19ae4eb8-19e7-47d1-a2ac-f0f8498b26e0"), "JFF5YLRHTRES99698" },
                    { new Guid("450d432f-8365-4fe2-9b75-57ea0682d279"), new Guid("e40211ab-7cb7-4b03-9687-a455ea8f486a"), "Electric", "Taurus", new Guid("c7c4cbe8-fb2d-4a3b-848d-ee6d0b7948b2"), "CMXACWIULHQF30860" },
                    { new Guid("45d5f534-3039-4a1d-8526-b251d9227b73"), new Guid("10344a04-defb-4875-bc15-ec6e973b4e77"), "Hybrid", "Colorado", new Guid("6490db6f-1bf1-4dfe-9177-243e985f0614"), "MX13G2S6UFZ259677" },
                    { new Guid("46dde0e9-8574-445e-b640-42237155110c"), new Guid("10344a04-defb-4875-bc15-ec6e973b4e77"), "Gasoline", "Spyder", new Guid("edf563fa-a49d-4096-8a30-1b05f87e8944"), "CQJRWOHPCVQR26028" },
                    { new Guid("47dbd844-8b65-4c21-94a0-11be6668c343"), new Guid("e40211ab-7cb7-4b03-9687-a455ea8f486a"), "Diesel", "Escalade", new Guid("0456f269-8c66-4203-90c5-ffa650fdabf0"), "G34OF8B61PDJ29269" },
                    { new Guid("48b49f89-1732-42fb-8864-44fd55e7d78b"), new Guid("51d70f2a-dcba-44c9-ab02-d32ba7c20888"), "Hybrid", "Mustang", new Guid("e3326281-6ddf-4785-aa10-e4c25f2eb6df"), "U1HFPR72Q4AR96873" },
                    { new Guid("4932e5cb-286e-4e04-b76e-11ece3cc2f69"), new Guid("10344a04-defb-4875-bc15-ec6e973b4e77"), "Hybrid", "Malibu", new Guid("8b62c70b-1d47-4d23-b864-7d1707ce0449"), "JP6OLUIC26WV77356" },
                    { new Guid("4b14b6a1-d5a6-43e3-b269-915b3055b860"), new Guid("0159c31c-99ae-464f-a6cc-ededd44600b1"), "Gasoline", "Wrangler", new Guid("8eedd0f5-844f-4b9a-ab70-7659af302835"), "ADLYS28FITT545146" },
                    { new Guid("4c1e6801-3cc4-4bf4-811d-4af99f3dd8b7"), new Guid("788dda47-40c3-4013-8509-3718406e576f"), "Hybrid", "Colorado", new Guid("5c66c6ca-7ca4-4b0c-85ba-8369e035dc7a"), "UN3KQ8MEVXSO45073" },
                    { new Guid("4df3cce2-c392-4659-9fa5-848414df6029"), new Guid("10344a04-defb-4875-bc15-ec6e973b4e77"), "Gasoline", "PT Cruiser", new Guid("6e835312-9cac-444b-82a2-9a5d4859d5be"), "C30ISX0NGEH738775" },
                    { new Guid("4f1d30e4-b38c-4568-8b21-53abc6aa0579"), new Guid("7860b54d-5388-49e9-b4ce-fc3c47a59201"), "Electric", "Impala", new Guid("c29aeb4e-47bf-4de6-87cf-13960b5b3843"), "CTHXXEB3OLLT31571" },
                    { new Guid("50c33a8b-1bd6-460b-bea2-3fdaa89f5608"), new Guid("95492c98-52ae-4857-9b6d-d499ad965781"), "Diesel", "F-150", new Guid("c9ab829c-f2f8-471a-8a01-b1ca02c5b182"), "XX171042FHZ446399" },
                    { new Guid("51a5b269-5d46-4807-8aee-7e268dbebe67"), new Guid("7860b54d-5388-49e9-b4ce-fc3c47a59201"), "Electric", "CX-9", new Guid("0456f269-8c66-4203-90c5-ffa650fdabf0"), "1D8XD7C0DRVZ26362" },
                    { new Guid("51adb03b-e8be-460d-a4a6-dca311995c99"), new Guid("e40211ab-7cb7-4b03-9687-a455ea8f486a"), "Hybrid", "Model T", new Guid("c720117b-0eba-4e2d-891a-0605d304ce0a"), "AEMXH9TSBUZJ36376" },
                    { new Guid("51c7883d-04c4-4a80-a1f8-dc5183020b7e"), new Guid("0159c31c-99ae-464f-a6cc-ededd44600b1"), "Hybrid", "Jetta", new Guid("683733c7-ed49-4baa-9d07-f0a8ebf3e0e4"), "NECRHKH76QJN88948" },
                    { new Guid("530ba90e-6fdc-46c6-8695-b61da2996256"), new Guid("51d70f2a-dcba-44c9-ab02-d32ba7c20888"), "Diesel", "Spyder", new Guid("4eaa0ad3-5ac0-4e6e-b387-cc80d1997269"), "R39O9UD2QFVJ18921" },
                    { new Guid("549d5860-45c4-481b-8d32-120f2166b0eb"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Hybrid", "Expedition", new Guid("c29aeb4e-47bf-4de6-87cf-13960b5b3843"), "ASW0YHKRZ5HY40010" },
                    { new Guid("554e17e5-21ea-43fb-ae2b-046f6292db89"), new Guid("dacccc0a-0470-4e0d-bef6-52258192e8d3"), "Hybrid", "Countach", new Guid("3b8a7808-760f-4343-89e4-e09dcd5cbbcd"), "0R3O336XHERK93254" },
                    { new Guid("55ba259a-30a3-4bfc-9a1c-7e3d1f130587"), new Guid("7860b54d-5388-49e9-b4ce-fc3c47a59201"), "Hybrid", "V90", new Guid("41bed6ed-637f-455b-9405-64b5d490086d"), "7HRG1VFT0RRH84844" },
                    { new Guid("56309a68-f29f-44ad-9a31-c04d1cba24f5"), new Guid("7860b54d-5388-49e9-b4ce-fc3c47a59201"), "Diesel", "Taurus", new Guid("99cd7e07-6045-4398-a5e8-94f1e7200d8c"), "QJEQQQKT7IO723355" },
                    { new Guid("5647c832-ddbd-4fbf-a54a-09bc7488d80b"), new Guid("95492c98-52ae-4857-9b6d-d499ad965781"), "Hybrid", "Explorer", new Guid("0d63ac92-15fa-4595-947a-9cc27299a68a"), "JQH5U6D234QW72233" },
                    { new Guid("56947cc5-2cac-40ad-9126-948e95125d85"), new Guid("acd0d6c0-64bd-46c7-92b9-53aea9060412"), "Hybrid", "911", new Guid("9af21342-4064-4d6d-9540-a2d02c59c575"), "D683JBUGZKSM15706" },
                    { new Guid("56e83bcc-c65a-4a85-9ce7-4db45e3a1c4e"), new Guid("e40211ab-7cb7-4b03-9687-a455ea8f486a"), "Hybrid", "ATS", new Guid("df4c259f-da94-4fe4-a760-500291196391"), "39BKB7VH7OGS10734" },
                    { new Guid("576a8faf-58b5-47fb-bfda-3218a3aaec37"), new Guid("dacccc0a-0470-4e0d-bef6-52258192e8d3"), "Electric", "Camry", new Guid("c80b8143-f8b8-4051-8e89-96f47eb28a29"), "K03PWYDTZ3CP22185" },
                    { new Guid("57d19a55-4476-450b-a9c2-42370093a8f7"), new Guid("e40211ab-7cb7-4b03-9687-a455ea8f486a"), "Hybrid", "Malibu", new Guid("931853bf-316b-4800-b7a7-a48d89b31ffd"), "ZE2Q4W42K1FN70531" },
                    { new Guid("58ea662f-46b1-4a4d-9027-808eea844b74"), new Guid("95492c98-52ae-4857-9b6d-d499ad965781"), "Gasoline", "CX-9", new Guid("89140d20-41ab-46a7-a9a4-c3e666fc39c5"), "CHCNMGWQ3XSP41991" },
                    { new Guid("59f9a1c8-cb79-43dd-b867-3ae5a70fafa9"), new Guid("acd0d6c0-64bd-46c7-92b9-53aea9060412"), "Electric", "Element", new Guid("cff29386-b7fc-4e98-96b9-c56f36d8db16"), "6F7N8DZWVCG734666" },
                    { new Guid("5b805403-1bd9-4d28-94ef-65dd11d12da0"), new Guid("788dda47-40c3-4013-8509-3718406e576f"), "Electric", "CX-9", new Guid("99cd7e07-6045-4398-a5e8-94f1e7200d8c"), "U1325AAVXPA392963" },
                    { new Guid("5bfcd2c8-785b-44ec-978d-edcd8d640f3c"), new Guid("acd0d6c0-64bd-46c7-92b9-53aea9060412"), "Diesel", "Aventador", new Guid("6e835312-9cac-444b-82a2-9a5d4859d5be"), "5F7RJMXT89TS62143" },
                    { new Guid("5d81358d-2cd5-4881-b6a0-9ab6f58ed107"), new Guid("51d70f2a-dcba-44c9-ab02-d32ba7c20888"), "Electric", "Mercielago", new Guid("6dd39c5f-f465-49fa-81ff-6b7bc70bd0cf"), "ADIJ3VP5SAA894889" },
                    { new Guid("5f79b344-4b2e-4a8a-aa3f-06160ed4b1cd"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Electric", "Alpine", new Guid("684b5a3d-cff0-45af-9b1d-11591617659b"), "ODDYX7PP02V263362" },
                    { new Guid("60dc08a0-e095-4c3c-9350-fe376977e098"), new Guid("0159c31c-99ae-464f-a6cc-ededd44600b1"), "Electric", "Ranchero", new Guid("a0f043f8-0082-4e9b-99b3-9ba6f3cd9a62"), "RPGX4VQ4QIID72442" },
                    { new Guid("6119c620-1605-451c-b534-df6fa8253367"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Diesel", "A4", new Guid("2cda9372-9eaf-47e6-87b8-c5165d98b6af"), "8ZYA1BH3VJIX88377" },
                    { new Guid("61398ebc-f29b-476c-a309-221f9193aa32"), new Guid("acd0d6c0-64bd-46c7-92b9-53aea9060412"), "Electric", "ATS", new Guid("65d28ce2-1bd6-4b8d-9c15-3a1b00c5b80d"), "GH5VDV5EQ0W077580" },
                    { new Guid("61ee7a2a-f4c8-4ff6-b07a-01df6583a6b5"), new Guid("dacccc0a-0470-4e0d-bef6-52258192e8d3"), "Diesel", "Camaro", new Guid("df4c259f-da94-4fe4-a760-500291196391"), "9YEV0O6HXVZS23847" },
                    { new Guid("6413557c-c67b-4ec2-8447-15ba3ab9edd2"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Gasoline", "Wrangler", new Guid("65d28ce2-1bd6-4b8d-9c15-3a1b00c5b80d"), "9NTUFUTRY7GT75607" },
                    { new Guid("648a27c7-4b76-4add-84e1-3ea9085b4f78"), new Guid("95492c98-52ae-4857-9b6d-d499ad965781"), "Electric", "Roadster", new Guid("a9521f70-b9bc-423a-8db2-02493bc84000"), "S8MZB7KPS6J567012" },
                    { new Guid("655cde06-5236-4121-974d-247bf4da8b36"), new Guid("dacccc0a-0470-4e0d-bef6-52258192e8d3"), "Hybrid", "Altima", new Guid("989f3250-e540-4dc0-a352-8c5de7c3f8b4"), "MN134SEMEILP49618" },
                    { new Guid("663962f7-e8c9-4498-87ae-dff21f1cec33"), new Guid("0159c31c-99ae-464f-a6cc-ededd44600b1"), "Diesel", "Mustang", new Guid("c11329d9-99b6-43fe-9ac8-37478f3633a3"), "Z6X1P9TJG1AU79603" },
                    { new Guid("6c93bcf5-670f-410b-83a9-6f3babb18b74"), new Guid("51d70f2a-dcba-44c9-ab02-d32ba7c20888"), "Hybrid", "El Camino", new Guid("6dd39c5f-f465-49fa-81ff-6b7bc70bd0cf"), "EZMK963UVZX178515" },
                    { new Guid("6dde2957-2294-4eac-8d58-695ff32669c4"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Gasoline", "Model 3", new Guid("5c66c6ca-7ca4-4b0c-85ba-8369e035dc7a"), "EOTRH11837N259300" },
                    { new Guid("6ed5b55f-2b46-4c6b-aea1-91e634249de9"), new Guid("e40211ab-7cb7-4b03-9687-a455ea8f486a"), "Diesel", "Escalade", new Guid("68c7d70e-5992-423e-b056-24602b83dc34"), "VPVETMPEU5KT84292" },
                    { new Guid("6ee68ff3-7c02-45fd-bcd1-6c0f25d4ba27"), new Guid("10344a04-defb-4875-bc15-ec6e973b4e77"), "Hybrid", "Spyder", new Guid("da2a6aff-018d-4545-ba39-80b8097e506f"), "L5KX2DBWZ8CD75827" },
                    { new Guid("70ad042d-79e3-4bd4-8a11-c53acebf61da"), new Guid("dacccc0a-0470-4e0d-bef6-52258192e8d3"), "Electric", "Taurus", new Guid("d9e48c79-0f4d-4429-9351-1135e503078a"), "0V02N2ABVXQX87292" },
                    { new Guid("70c1ec36-a0b7-4205-9270-2f238e5df087"), new Guid("acd0d6c0-64bd-46c7-92b9-53aea9060412"), "Electric", "Malibu", new Guid("989f3250-e540-4dc0-a352-8c5de7c3f8b4"), "4LAAK0JNBJGH12636" },
                    { new Guid("714e87cf-a679-4d77-84ae-382185c14b10"), new Guid("acd0d6c0-64bd-46c7-92b9-53aea9060412"), "Electric", "Camry", new Guid("6634bb07-20c2-4e4b-a275-bc340e7c9f9e"), "NVQY4TUC3GHT41374" },
                    { new Guid("719280b1-fffa-4984-9f95-d448f793f2cc"), new Guid("7860b54d-5388-49e9-b4ce-fc3c47a59201"), "Gasoline", "Taurus", new Guid("1ca6d610-cf14-48b4-b8aa-2b94ae819e7d"), "BXLPUDJYM8P776744" },
                    { new Guid("7308486e-7272-4054-9797-2ff158e5c34e"), new Guid("dacccc0a-0470-4e0d-bef6-52258192e8d3"), "Diesel", "2", new Guid("ff2231b5-e78a-43a6-b16f-e2376dc4bcec"), "BDWAOAU7Z1EJ93069" },
                    { new Guid("7319a96a-80d4-427c-b0c2-da71ee8cc335"), new Guid("95492c98-52ae-4857-9b6d-d499ad965781"), "Gasoline", "Ranchero", new Guid("19ae4eb8-19e7-47d1-a2ac-f0f8498b26e0"), "INJMMAPGG5T799079" },
                    { new Guid("73945739-c6ab-4e28-92eb-52eff77e9022"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Electric", "Grand Cherokee", new Guid("cb6e78a1-3536-4985-8c77-cc4494d8cf17"), "CF5NVL9LFEUD79926" },
                    { new Guid("73c98c75-4660-44e0-a7b9-2f7d4977026a"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Diesel", "Golf", new Guid("931853bf-316b-4800-b7a7-a48d89b31ffd"), "KSRLFPTMX9K232410" },
                    { new Guid("74c16c93-7313-4e63-a84d-2ead04d249a6"), new Guid("0159c31c-99ae-464f-a6cc-ededd44600b1"), "Diesel", "LeBaron", new Guid("65d28ce2-1bd6-4b8d-9c15-3a1b00c5b80d"), "TMB7V56D26OM62888" },
                    { new Guid("74e1dfad-8645-4301-b6aa-343ea01ea71e"), new Guid("788dda47-40c3-4013-8509-3718406e576f"), "Hybrid", "Civic", new Guid("a0f043f8-0082-4e9b-99b3-9ba6f3cd9a62"), "5VAV7S7B5LES71346" },
                    { new Guid("777bcb31-e7c1-4235-92f0-0c2dd3c79466"), new Guid("51d70f2a-dcba-44c9-ab02-d32ba7c20888"), "Gasoline", "V90", new Guid("3079c526-4dac-42b6-a220-30fc648f938b"), "8LTHFFY6IDIE89238" },
                    { new Guid("77c8b8cb-e3ff-4229-b4df-ec25c7f65f6f"), new Guid("e40211ab-7cb7-4b03-9687-a455ea8f486a"), "Gasoline", "Ranchero", new Guid("e3326281-6ddf-4785-aa10-e4c25f2eb6df"), "NBY84PRUWBA775943" },
                    { new Guid("7a6d0f93-91e1-4bce-b5ec-dcf898cf9e47"), new Guid("0159c31c-99ae-464f-a6cc-ededd44600b1"), "Electric", "Silverado", new Guid("6634bb07-20c2-4e4b-a275-bc340e7c9f9e"), "D6QE9X8BPGQP64275" },
                    { new Guid("7b3cbb55-2e9e-424d-a961-8575197f8975"), new Guid("dacccc0a-0470-4e0d-bef6-52258192e8d3"), "Hybrid", "Accord", new Guid("09887250-80c4-4775-9c04-7e44cc1a5df0"), "4LXO9ONBXPA668794" },
                    { new Guid("7bd2e932-6e47-4975-bd63-a9f530a26272"), new Guid("10344a04-defb-4875-bc15-ec6e973b4e77"), "Hybrid", "Camaro", new Guid("0d63ac92-15fa-4595-947a-9cc27299a68a"), "R1YLXEWQT1G528890" },
                    { new Guid("7bdf7670-0f8a-4aad-9b50-ce18d0a16b1b"), new Guid("788dda47-40c3-4013-8509-3718406e576f"), "Electric", "Civic", new Guid("83957e53-d926-47f7-8450-9f649ff289a1"), "E0ZCP1OTOAYY27632" },
                    { new Guid("7c224254-15cf-4445-9365-547d4a1c01a4"), new Guid("0159c31c-99ae-464f-a6cc-ededd44600b1"), "Electric", "LeBaron", new Guid("28821f3f-63a3-4759-ae15-3dd0b99154e7"), "52LTLFOSWCSY11144" },
                    { new Guid("7ca9b16f-7edd-4af8-9408-05fe74ca244e"), new Guid("acd0d6c0-64bd-46c7-92b9-53aea9060412"), "Gasoline", "Jetta", new Guid("ff2231b5-e78a-43a6-b16f-e2376dc4bcec"), "LURIYJO2XFJE55487" },
                    { new Guid("7e254261-3f76-402c-9ac8-5913a1a2cdbc"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Electric", "Jetta", new Guid("c7c4cbe8-fb2d-4a3b-848d-ee6d0b7948b2"), "D4FX9PK3IJEN57823" },
                    { new Guid("7f711b6e-411f-4856-a9dd-01052830e606"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Electric", "Camry", new Guid("989f3250-e540-4dc0-a352-8c5de7c3f8b4"), "5LOLWE39VKZ079277" },
                    { new Guid("8009fa04-cad3-470f-8c29-359ad6535012"), new Guid("51d70f2a-dcba-44c9-ab02-d32ba7c20888"), "Gasoline", "Spyder", new Guid("09887250-80c4-4775-9c04-7e44cc1a5df0"), "R1PK5YQLQ4Y372511" },
                    { new Guid("8231c836-edbd-4a7d-8f20-3f9866d8aa01"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Electric", "Ranchero", new Guid("19ae4eb8-19e7-47d1-a2ac-f0f8498b26e0"), "FZ1AIO1H6TLO33300" },
                    { new Guid("8260ca22-03cc-46ee-9de0-185af360af76"), new Guid("0159c31c-99ae-464f-a6cc-ededd44600b1"), "Gasoline", "Silverado", new Guid("da2a6aff-018d-4545-ba39-80b8097e506f"), "RPW27T1CDHYW82639" },
                    { new Guid("82c271ad-c9ab-4824-b83b-aec03a5f1eb0"), new Guid("95492c98-52ae-4857-9b6d-d499ad965781"), "Gasoline", "El Camino", new Guid("df4c259f-da94-4fe4-a760-500291196391"), "Z5I4D6WUSYGV43557" },
                    { new Guid("863364b3-8161-468e-a6e2-2d032f48fd59"), new Guid("acd0d6c0-64bd-46c7-92b9-53aea9060412"), "Diesel", "Sentra", new Guid("7ae08f52-4e03-4336-9aad-1b0a7ed7b543"), "GN6XJLYZ9EXP15132" },
                    { new Guid("8684d4d4-e230-4580-8dab-d97ac82866e6"), new Guid("788dda47-40c3-4013-8509-3718406e576f"), "Gasoline", "Silverado", new Guid("2306b740-43f8-48e1-be4a-4aa28961da26"), "8TL8GC44PQY960565" },
                    { new Guid("88d41b98-d1b7-4c57-94db-ce9f7ce72533"), new Guid("7860b54d-5388-49e9-b4ce-fc3c47a59201"), "Gasoline", "A8", new Guid("2c06d082-7a07-43ce-8952-900549177d5f"), "53LA8QDSZAGD72337" },
                    { new Guid("8905cf94-a757-4946-b555-b56106cce07d"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Gasoline", "Ranchero", new Guid("a0f043f8-0082-4e9b-99b3-9ba6f3cd9a62"), "52MAD1OJWTMW15719" },
                    { new Guid("894f918f-957d-4d5c-a708-81a5d378aeed"), new Guid("7860b54d-5388-49e9-b4ce-fc3c47a59201"), "Diesel", "Corvette", new Guid("0292ea56-45c3-4e48-956b-c457622a53e4"), "I6X4UCYBYYR775791" },
                    { new Guid("89baa820-9620-42ae-8858-7560c31e18b7"), new Guid("dacccc0a-0470-4e0d-bef6-52258192e8d3"), "Diesel", "Volt", new Guid("8c018102-4657-4fa3-9b78-98cab50b60c4"), "5DURNTOYVJXN10367" },
                    { new Guid("8be7229c-7441-44e4-84ef-0341a185c0fc"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Hybrid", "Element", new Guid("c29aeb4e-47bf-4de6-87cf-13960b5b3843"), "98QT7X5FFKMM88872" },
                    { new Guid("8dc9d427-69c2-4cfe-adcf-17c9b974d654"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Hybrid", "2", new Guid("19ae4eb8-19e7-47d1-a2ac-f0f8498b26e0"), "CMWXK9EJFGDE32160" },
                    { new Guid("8f929ea5-3e29-4b10-8ef0-5458bc29ff61"), new Guid("acd0d6c0-64bd-46c7-92b9-53aea9060412"), "Gasoline", "Camaro", new Guid("0d36673c-eeb8-4e50-88f9-2356fe5472d6"), "7Q2BXDYF86A535386" },
                    { new Guid("916dce57-b764-41b0-b3b1-b6a6300002de"), new Guid("0159c31c-99ae-464f-a6cc-ededd44600b1"), "Electric", "Model S", new Guid("80351255-9ae9-43e1-8f0f-fdfd3a2dc7ad"), "YLO9UNVZVHPI50631" },
                    { new Guid("9191de00-c327-426b-a8f0-6fcc7b8ae597"), new Guid("acd0d6c0-64bd-46c7-92b9-53aea9060412"), "Diesel", "CX-9", new Guid("6540c58c-370b-4acb-8bb3-c359d451ee96"), "XXU6MTMPXKR222039" },
                    { new Guid("930a5d41-1023-44c3-a843-cd2e03c6d608"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Hybrid", "Taurus", new Guid("1287a5df-25d3-4217-ae27-362bdfbdbe1f"), "7WBJ1VB2JOK954938" },
                    { new Guid("960a3cb4-1c52-474d-bb99-f91b2b5234ba"), new Guid("95492c98-52ae-4857-9b6d-d499ad965781"), "Gasoline", "Grand Caravan", new Guid("683733c7-ed49-4baa-9d07-f0a8ebf3e0e4"), "AKDLI09QA3A575906" },
                    { new Guid("96ee366e-cd38-4177-9f43-33518efa63c7"), new Guid("acd0d6c0-64bd-46c7-92b9-53aea9060412"), "Diesel", "Golf", new Guid("80351255-9ae9-43e1-8f0f-fdfd3a2dc7ad"), "ZRUQFYZHJNJG12537" },
                    { new Guid("97875a0e-d71c-496a-9747-42563f9520eb"), new Guid("51d70f2a-dcba-44c9-ab02-d32ba7c20888"), "Gasoline", "Aventador", new Guid("edf563fa-a49d-4096-8a30-1b05f87e8944"), "AEU6PVP5QXKN77276" },
                    { new Guid("9c58b8de-91fd-463f-84b0-8790c0776267"), new Guid("10344a04-defb-4875-bc15-ec6e973b4e77"), "Gasoline", "Grand Cherokee", new Guid("8b62c70b-1d47-4d23-b864-7d1707ce0449"), "S2Z58337OIT094860" },
                    { new Guid("9d07f4c6-a2e9-4211-b0cc-d11cd5e8285b"), new Guid("e40211ab-7cb7-4b03-9687-a455ea8f486a"), "Diesel", "A4", new Guid("89140d20-41ab-46a7-a9a4-c3e666fc39c5"), "VZO8NTEX73VK56670" },
                    { new Guid("9e1b28f4-63ca-45a0-b54c-69df6afe7e1f"), new Guid("51d70f2a-dcba-44c9-ab02-d32ba7c20888"), "Gasoline", "PT Cruiser", new Guid("6e835312-9cac-444b-82a2-9a5d4859d5be"), "4O61XWEY8TQ228532" },
                    { new Guid("9e2c35c5-d448-406e-936b-df2a0b5691aa"), new Guid("acd0d6c0-64bd-46c7-92b9-53aea9060412"), "Diesel", "Malibu", new Guid("edf563fa-a49d-4096-8a30-1b05f87e8944"), "BK92SIG8SAG020255" },
                    { new Guid("a220849f-a0d4-48a6-b9be-0a888f480d75"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Hybrid", "1", new Guid("c29aeb4e-47bf-4de6-87cf-13960b5b3843"), "5QJ8VXFL29MG73209" },
                    { new Guid("a65e5112-ca04-4b72-b0e0-1ec0938a66e1"), new Guid("10344a04-defb-4875-bc15-ec6e973b4e77"), "Electric", "A4", new Guid("c1d5801d-26cf-4541-99ec-394ae2526dac"), "34GAOJ87VEY452045" },
                    { new Guid("a7f45ad8-203b-4a83-a514-25be00495630"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Electric", "1", new Guid("c720117b-0eba-4e2d-891a-0605d304ce0a"), "7CC2Y5L7BWQK79407" },
                    { new Guid("a9f03a8b-5b64-4624-8221-c8fb10120e0a"), new Guid("788dda47-40c3-4013-8509-3718406e576f"), "Electric", "F-150", new Guid("569645c5-a69e-49a9-9ad3-7cabc216b3db"), "D5X8EH01PCKO99157" },
                    { new Guid("ac9c6f64-3590-4a15-8485-35c04e51551a"), new Guid("dacccc0a-0470-4e0d-bef6-52258192e8d3"), "Gasoline", "Explorer", new Guid("8eedd0f5-844f-4b9a-ab70-7659af302835"), "W2RHQBPR0UY329591" },
                    { new Guid("ad4ce131-19d9-413e-b7d2-3d180fe3713c"), new Guid("7860b54d-5388-49e9-b4ce-fc3c47a59201"), "Hybrid", "Explorer", new Guid("6634bb07-20c2-4e4b-a275-bc340e7c9f9e"), "V8ZWHEOLQAFF29098" },
                    { new Guid("adb16db4-afc1-4996-ac7d-2b5b9033d15d"), new Guid("dacccc0a-0470-4e0d-bef6-52258192e8d3"), "Hybrid", "Accord", new Guid("0d63ac92-15fa-4595-947a-9cc27299a68a"), "ULYYU8V2FHD919806" },
                    { new Guid("aee338b3-0a0d-4a2b-9125-71cafe999005"), new Guid("acd0d6c0-64bd-46c7-92b9-53aea9060412"), "Electric", "Grand Caravan", new Guid("c128ace2-fc0a-4d15-ad60-314a46d11183"), "L45NMFNUX6YR90600" },
                    { new Guid("b26325b9-66c2-4483-bc39-3844cbaba028"), new Guid("10344a04-defb-4875-bc15-ec6e973b4e77"), "Diesel", "Explorer", new Guid("6634bb07-20c2-4e4b-a275-bc340e7c9f9e"), "XUL8YD537UP229097" },
                    { new Guid("b3b02941-858c-426d-9d97-fa18d1740759"), new Guid("e40211ab-7cb7-4b03-9687-a455ea8f486a"), "Gasoline", "Durango", new Guid("8650a20f-1a97-4b2d-b96d-efd2c36cb972"), "795JC71DIHLX25066" },
                    { new Guid("b413dbb1-bafb-4908-88da-bde1e6ffc0b3"), new Guid("95492c98-52ae-4857-9b6d-d499ad965781"), "Gasoline", "1", new Guid("17ada71d-217a-4041-b376-1050552abd11"), "RPRSHMVQTZYK31376" },
                    { new Guid("b4e340df-b0e9-413f-9dc5-c733849c7fb7"), new Guid("95492c98-52ae-4857-9b6d-d499ad965781"), "Electric", "Corvette", new Guid("83957e53-d926-47f7-8450-9f649ff289a1"), "58E0QMWQ89V854225" },
                    { new Guid("b85f2f4a-2bd3-4f17-baa6-6a13cdf5dd0b"), new Guid("0159c31c-99ae-464f-a6cc-ededd44600b1"), "Gasoline", "Volt", new Guid("99cd7e07-6045-4398-a5e8-94f1e7200d8c"), "0I54SQMVAJLS93028" },
                    { new Guid("ba1eea85-ee1c-4270-9efb-74cb09ea1777"), new Guid("10344a04-defb-4875-bc15-ec6e973b4e77"), "Electric", "Malibu", new Guid("ea7232d3-fa7e-4c1d-9fd4-7f1674ea0654"), "NBQJXMWFORVH38755" },
                    { new Guid("ba2ef441-86ee-4013-8742-4d710f491686"), new Guid("95492c98-52ae-4857-9b6d-d499ad965781"), "Diesel", "Beetle", new Guid("3079c526-4dac-42b6-a220-30fc648f938b"), "9A4S648HV9NM54695" },
                    { new Guid("ba6114ba-3f54-4b6f-bf3a-0bc38d72c7a1"), new Guid("e40211ab-7cb7-4b03-9687-a455ea8f486a"), "Electric", "Mercielago", new Guid("3079c526-4dac-42b6-a220-30fc648f938b"), "M9TOX4MOMOI250332" },
                    { new Guid("bae1fb39-53a5-48df-8d31-ed9d2f6bc380"), new Guid("95492c98-52ae-4857-9b6d-d499ad965781"), "Electric", "Durango", new Guid("e0ebfdfa-e702-456c-bcbb-a55aeaec7820"), "H22552V74ROA80856" },
                    { new Guid("bb22df3c-b2af-4c06-bc25-26ee93d050fe"), new Guid("10344a04-defb-4875-bc15-ec6e973b4e77"), "Gasoline", "Civic", new Guid("0d36673c-eeb8-4e50-88f9-2356fe5472d6"), "MLA14IN4HOHB41823" },
                    { new Guid("bbd8fbec-5460-488e-a883-d6929c5eadcf"), new Guid("0159c31c-99ae-464f-a6cc-ededd44600b1"), "Gasoline", "XTS", new Guid("2c06d082-7a07-43ce-8952-900549177d5f"), "CLVYYDB80JUT21089" },
                    { new Guid("bcba555c-cbd9-4a71-8b9f-4be8194d87e1"), new Guid("e40211ab-7cb7-4b03-9687-a455ea8f486a"), "Gasoline", "Altima", new Guid("15a44f02-8bea-48e8-a075-d1554e53f54e"), "M30HIUELW0SF76910" },
                    { new Guid("bd1dd94e-e4a9-4350-9061-acd7b62fd665"), new Guid("dacccc0a-0470-4e0d-bef6-52258192e8d3"), "Diesel", "Silverado", new Guid("c7c4cbe8-fb2d-4a3b-848d-ee6d0b7948b2"), "OY9VKY1I1NHY33855" },
                    { new Guid("bd929327-0c1a-4ade-82c0-8e8fbfa591a8"), new Guid("7860b54d-5388-49e9-b4ce-fc3c47a59201"), "Hybrid", "Durango", new Guid("17ada71d-217a-4041-b376-1050552abd11"), "MXE45OCGQDG177832" },
                    { new Guid("bdb10249-66e3-4e2b-ad32-e237890b5d46"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Gasoline", "Silverado", new Guid("e0ebfdfa-e702-456c-bcbb-a55aeaec7820"), "4ZJN6T1RO1MY66151" },
                    { new Guid("bfe60319-4c00-433a-97b2-400e3a9e157f"), new Guid("dacccc0a-0470-4e0d-bef6-52258192e8d3"), "Gasoline", "Volt", new Guid("19ae4eb8-19e7-47d1-a2ac-f0f8498b26e0"), "OF2D3WRY8BVG75399" },
                    { new Guid("c2cb8705-3cca-40ac-8798-d21ba40d341d"), new Guid("0159c31c-99ae-464f-a6cc-ededd44600b1"), "Electric", "Sentra", new Guid("c1d5801d-26cf-4541-99ec-394ae2526dac"), "VX6IPPQQPBPC13156" },
                    { new Guid("c2fc6986-5733-41c3-a8f3-1e7d84533192"), new Guid("51d70f2a-dcba-44c9-ab02-d32ba7c20888"), "Diesel", "Mustang", new Guid("65d28ce2-1bd6-4b8d-9c15-3a1b00c5b80d"), "5II49OH0C5KS30298" },
                    { new Guid("c3251f39-20be-4394-8e00-927eb66e89fb"), new Guid("95492c98-52ae-4857-9b6d-d499ad965781"), "Diesel", "Element", new Guid("28821f3f-63a3-4759-ae15-3dd0b99154e7"), "HDGDDOPP1KC371136" },
                    { new Guid("c41ba6ae-f156-43d3-8317-3ab67010fc67"), new Guid("e40211ab-7cb7-4b03-9687-a455ea8f486a"), "Diesel", "Element", new Guid("cb6e78a1-3536-4985-8c77-cc4494d8cf17"), "RXCV63D0X4EQ15842" },
                    { new Guid("c4ffba13-dc59-4126-b1d8-b1d4e7ff7af2"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Electric", "A8", new Guid("bc38be9e-c198-405c-a569-31bb996a4483"), "BFS2HZCZH4BL13576" },
                    { new Guid("c778bca0-831c-4618-bf67-fb66cb032f4f"), new Guid("0159c31c-99ae-464f-a6cc-ededd44600b1"), "Hybrid", "Model 3", new Guid("9cf7cffd-c18f-48fc-88fd-2dcefab3f951"), "P36CMLXYLPY438895" },
                    { new Guid("c82b43a6-7365-4642-afaf-9d95368c9de9"), new Guid("acd0d6c0-64bd-46c7-92b9-53aea9060412"), "Hybrid", "Charger", new Guid("65d28ce2-1bd6-4b8d-9c15-3a1b00c5b80d"), "QECF3LHENRM327227" },
                    { new Guid("c9333267-ab5e-4dab-b188-cd9fd65b7dec"), new Guid("10344a04-defb-4875-bc15-ec6e973b4e77"), "Gasoline", "Grand Cherokee", new Guid("cb6e78a1-3536-4985-8c77-cc4494d8cf17"), "JNAKH7G5QRCZ74613" },
                    { new Guid("c9b5ddc1-f4e6-44aa-833b-64c9e024acc3"), new Guid("e40211ab-7cb7-4b03-9687-a455ea8f486a"), "Hybrid", "Expedition", new Guid("89140d20-41ab-46a7-a9a4-c3e666fc39c5"), "13ESYBLYL2XE56826" },
                    { new Guid("ca9b2769-bb0c-4b0e-b4d7-2a19a37a6e88"), new Guid("e40211ab-7cb7-4b03-9687-a455ea8f486a"), "Hybrid", "CTS", new Guid("683733c7-ed49-4baa-9d07-f0a8ebf3e0e4"), "WUL3O86H12DA56339" },
                    { new Guid("cb0748a3-762e-458c-91e1-a7324d72d34c"), new Guid("e40211ab-7cb7-4b03-9687-a455ea8f486a"), "Gasoline", "Expedition", new Guid("33dcf9b8-622a-4078-ac70-ae205d41d2cc"), "F5TSYLI7EHA687295" },
                    { new Guid("cbbe320f-fc5e-405d-8fab-9d2c20231f02"), new Guid("e40211ab-7cb7-4b03-9687-a455ea8f486a"), "Electric", "Model S", new Guid("9af21342-4064-4d6d-9540-a2d02c59c575"), "XYDYIVUNXDMW67225" },
                    { new Guid("cc55a6c8-66cb-4c7b-93e0-65d72c46845a"), new Guid("e40211ab-7cb7-4b03-9687-a455ea8f486a"), "Diesel", "Spyder", new Guid("c720117b-0eba-4e2d-891a-0605d304ce0a"), "6MRO68LG84WI82481" },
                    { new Guid("cdf3856c-fa46-43ed-a2e8-e48249b10e4e"), new Guid("7860b54d-5388-49e9-b4ce-fc3c47a59201"), "Electric", "XC90", new Guid("989f3250-e540-4dc0-a352-8c5de7c3f8b4"), "IP45R2KEVYRB29774" },
                    { new Guid("ce164c75-932a-43ac-8682-4ab5c0ddca1e"), new Guid("dacccc0a-0470-4e0d-bef6-52258192e8d3"), "Gasoline", "2", new Guid("0d36673c-eeb8-4e50-88f9-2356fe5472d6"), "7AYD89T5UGVE13619" },
                    { new Guid("ce8de3e8-907e-48e5-bf7a-287bf4c4f7ce"), new Guid("dacccc0a-0470-4e0d-bef6-52258192e8d3"), "Diesel", "Roadster", new Guid("a9405025-c36f-42e5-b893-6cb3c344e6c0"), "DWFSM5NPOTPV29212" },
                    { new Guid("d4f2c611-95ef-4b67-a5c3-f4dacb81a855"), new Guid("7860b54d-5388-49e9-b4ce-fc3c47a59201"), "Gasoline", "Colorado", new Guid("8650a20f-1a97-4b2d-b96d-efd2c36cb972"), "T4OJ3HHC9JUH34383" },
                    { new Guid("d8094115-242f-4725-a323-d8158c7cbde5"), new Guid("10344a04-defb-4875-bc15-ec6e973b4e77"), "Hybrid", "Civic", new Guid("7ae08f52-4e03-4336-9aad-1b0a7ed7b543"), "QFM43MQ6JWAT18933" },
                    { new Guid("d9b00a8d-0c18-4ed6-80e2-06107c6d772e"), new Guid("51d70f2a-dcba-44c9-ab02-d32ba7c20888"), "Gasoline", "Beetle", new Guid("8b62c70b-1d47-4d23-b864-7d1707ce0449"), "HCS7OFVS4HLW74719" },
                    { new Guid("da752299-a25b-4a2d-a408-6b24c3d61b38"), new Guid("788dda47-40c3-4013-8509-3718406e576f"), "Hybrid", "Fiesta", new Guid("3b8a7808-760f-4343-89e4-e09dcd5cbbcd"), "TRAB95F9GKS375375" },
                    { new Guid("db462e1d-687e-4fa4-94ab-598c61eb2b7c"), new Guid("10344a04-defb-4875-bc15-ec6e973b4e77"), "Electric", "Mustang", new Guid("c9ab829c-f2f8-471a-8a01-b1ca02c5b182"), "GGQ545DEORK695063" },
                    { new Guid("dd3efee8-94cd-4942-8b40-6b763fe36ff8"), new Guid("95492c98-52ae-4857-9b6d-d499ad965781"), "Gasoline", "PT Cruiser", new Guid("6634bb07-20c2-4e4b-a275-bc340e7c9f9e"), "3BKWZ0WCXKSV78906" },
                    { new Guid("e34612fa-fd38-42ea-8ded-236d2c5a6e72"), new Guid("e40211ab-7cb7-4b03-9687-a455ea8f486a"), "Electric", "Jetta", new Guid("80351255-9ae9-43e1-8f0f-fdfd3a2dc7ad"), "17VBDI9IKTJR46838" },
                    { new Guid("e45335e8-11d5-4ef0-a25a-50efb342130c"), new Guid("acd0d6c0-64bd-46c7-92b9-53aea9060412"), "Hybrid", "Countach", new Guid("c1d5801d-26cf-4541-99ec-394ae2526dac"), "9IGGHY8L8FW166616" },
                    { new Guid("e50a7afb-33a5-416e-ac17-d26089cfe72b"), new Guid("10344a04-defb-4875-bc15-ec6e973b4e77"), "Diesel", "Corvette", new Guid("33dcf9b8-622a-4078-ac70-ae205d41d2cc"), "81WI7JMNMHDA18253" },
                    { new Guid("e6898838-72b3-4fa3-aa6b-140cdfc402de"), new Guid("acd0d6c0-64bd-46c7-92b9-53aea9060412"), "Gasoline", "Impala", new Guid("683733c7-ed49-4baa-9d07-f0a8ebf3e0e4"), "QPVBM5XQCIFH23393" },
                    { new Guid("e94c0917-3bd2-4975-ad71-cc43dfcf9a4c"), new Guid("0159c31c-99ae-464f-a6cc-ededd44600b1"), "Diesel", "Beetle", new Guid("33dcf9b8-622a-4078-ac70-ae205d41d2cc"), "9MC7BIAU7UT039415" },
                    { new Guid("e9f0e79f-8f4e-4598-82e4-ec4183d0269f"), new Guid("acd0d6c0-64bd-46c7-92b9-53aea9060412"), "Hybrid", "911", new Guid("19ae4eb8-19e7-47d1-a2ac-f0f8498b26e0"), "5YEU8TL554NZ63964" },
                    { new Guid("ed211f08-864e-4253-a274-734130c29e24"), new Guid("e40211ab-7cb7-4b03-9687-a455ea8f486a"), "Gasoline", "XC90", new Guid("edf563fa-a49d-4096-8a30-1b05f87e8944"), "I5RM3CZ0DVVI31932" },
                    { new Guid("ed8030ba-2f56-4628-953b-f3a4d9a1005b"), new Guid("10344a04-defb-4875-bc15-ec6e973b4e77"), "Electric", "Camry", new Guid("a9521f70-b9bc-423a-8db2-02493bc84000"), "5NRBLY0HA6TC10058" },
                    { new Guid("ee79706a-c99b-46fb-9c39-7b628913c71a"), new Guid("95492c98-52ae-4857-9b6d-d499ad965781"), "Hybrid", "Fiesta", new Guid("056ad579-3dc6-4723-bb1d-1ae63ac0c48a"), "J59FW4I8DCGT17471" },
                    { new Guid("eec6424c-d76d-47e5-8fe7-05d144d13e69"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Electric", "Grand Caravan", new Guid("1ca6d610-cf14-48b4-b8aa-2b94ae819e7d"), "0SF5Z50PROCO71518" },
                    { new Guid("ef6eef07-8c10-4d28-bd6f-9cd04c9a563c"), new Guid("51d70f2a-dcba-44c9-ab02-d32ba7c20888"), "Gasoline", "Spyder", new Guid("80351255-9ae9-43e1-8f0f-fdfd3a2dc7ad"), "RF727VGE78G131862" },
                    { new Guid("efed735f-b045-4ea2-b893-1e2b5312a210"), new Guid("0159c31c-99ae-464f-a6cc-ededd44600b1"), "Electric", "Roadster", new Guid("9c9bdcc5-7e11-47c3-85c1-9eb1ccf21878"), "GAFIK5DJRQCD99413" },
                    { new Guid("f211463a-1055-43c7-97b8-ae07755aa08d"), new Guid("1cd52361-30d5-4bed-84ca-8e7403d8c937"), "Electric", "LeBaron", new Guid("2c06d082-7a07-43ce-8952-900549177d5f"), "KE1ZXNRYGLKK80251" },
                    { new Guid("f25a5032-137a-413c-8e63-b11fa7a306a7"), new Guid("e40211ab-7cb7-4b03-9687-a455ea8f486a"), "Diesel", "Corvette", new Guid("1287a5df-25d3-4217-ae27-362bdfbdbe1f"), "G8SVM43Q89VC30211" },
                    { new Guid("f3f53463-1087-4b87-97ca-3a3838968598"), new Guid("7860b54d-5388-49e9-b4ce-fc3c47a59201"), "Hybrid", "LeBaron", new Guid("bc38be9e-c198-405c-a569-31bb996a4483"), "HLUO5TXLW0W578452" },
                    { new Guid("f429d518-3199-4f1c-9461-942a20d775ba"), new Guid("0159c31c-99ae-464f-a6cc-ededd44600b1"), "Diesel", "Malibu", new Guid("8b62c70b-1d47-4d23-b864-7d1707ce0449"), "0M96WOOANNPE96495" },
                    { new Guid("f769ced6-d2e7-44df-a6ee-cfdf3d2a8134"), new Guid("e40211ab-7cb7-4b03-9687-a455ea8f486a"), "Diesel", "Volt", new Guid("3b8a7808-760f-4343-89e4-e09dcd5cbbcd"), "C5EKMII4XRLS61393" },
                    { new Guid("f7dc3081-28fe-430b-a54f-050b37d706d3"), new Guid("7860b54d-5388-49e9-b4ce-fc3c47a59201"), "Electric", "911", new Guid("0d36673c-eeb8-4e50-88f9-2356fe5472d6"), "Z5YL1R0W6MRR26354" },
                    { new Guid("f919ced9-cc56-4c6e-95bb-64da4758476d"), new Guid("788dda47-40c3-4013-8509-3718406e576f"), "Electric", "Ranchero", new Guid("1287a5df-25d3-4217-ae27-362bdfbdbe1f"), "0K9NK7G8W2PL90415" },
                    { new Guid("f93aed07-7f01-4e38-a362-32a6589bc776"), new Guid("e40211ab-7cb7-4b03-9687-a455ea8f486a"), "Gasoline", "Taurus", new Guid("c128ace2-fc0a-4d15-ad60-314a46d11183"), "55Z2B4JTWGAN46682" },
                    { new Guid("fbd838b0-df60-4e71-98e4-35c979039ff9"), new Guid("7860b54d-5388-49e9-b4ce-fc3c47a59201"), "Electric", "Golf", new Guid("41bed6ed-637f-455b-9405-64b5d490086d"), "VWOGONBS1DE636617" },
                    { new Guid("fbda710a-e9e7-4991-8975-a81829636b37"), new Guid("e40211ab-7cb7-4b03-9687-a455ea8f486a"), "Gasoline", "Land Cruiser", new Guid("89140d20-41ab-46a7-a9a4-c3e666fc39c5"), "CWL6PFLGHWM356161" },
                    { new Guid("fcbff57b-74c7-4c13-b3a2-2623d50ec4d2"), new Guid("acd0d6c0-64bd-46c7-92b9-53aea9060412"), "Gasoline", "A8", new Guid("056ad579-3dc6-4723-bb1d-1ae63ac0c48a"), "CHISQRDDMYIA95133" },
                    { new Guid("ff88d613-d214-428e-8fd5-f52b19a7b465"), new Guid("dacccc0a-0470-4e0d-bef6-52258192e8d3"), "Electric", "Aventador", new Guid("d9e48c79-0f4d-4429-9351-1135e503078a"), "UOG85N11TPP467472" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_CompanyId",
                table: "Users",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_CompanyId",
                table: "Vehicles",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_UserId",
                table: "Vehicles",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
