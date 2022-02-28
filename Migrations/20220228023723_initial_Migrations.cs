using Microsoft.EntityFrameworkCore.Migrations;

namespace POC.Migrations
{
    public partial class initial_Migrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Option1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Option2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Option3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Option4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "Answer", "Option1", "Option2", "Option3", "Option4", "QuestionText" },
                values: new object[,]
                {
                    { 1, 3, "Hyper Trainer Marking Language", "Hyper Text Marketing Language", "Hyper Text Markup Leveler", "Hyper Text Markup Language", "What does HTML stand for?" },
                    { 18, 2, "Programmable Lift Computer", "Program List Control", "Programmable Logic Controller", "Piezo Lamp Connector", "What does the term PLC stand for?" },
                    { 17, 3, "To decrease the current", "To increase the current", "To decrease the voltage momentarily", "To increase the voltage momentarily", "The purpose of choke in tube light is ?" },
                    { 16, 2, "Permanent magnet motor", "Series motor", "Squirrel cage motor", "Synchronous motor", "Which motor is NOT suitable for use as a DC machine?" },
                    { 15, 0, "Pumping", "Exciting", "Priming", "Raising", "The first step to getting output from a laser is to excite an active medium. What is this process called?" },
                    { 14, 3, "100 kHz", "1 GHz", "30 to 300 MHz", "3 to 30 MHz", "What frequency range is the High Frequency band?" },
                    { 13, 3, "Variant Voltage Vile Frequency", "Variable Velocity Variable Fun", "Very Very Vicious Frequency", "Variable Voltage Variable Frequency", "What does VVVF stand for?" },
                    { 12, 0, "Video Home System", "Very high speed", "Video horizontal standard", "Voltage house standard", "The most common format for a home video recorder is VHS. VHS stands for...?" },
                    { 11, 2, "Choke", "Inductor", "Resistor", "Capacitor", "Made from a variety of materials, such as carbon, which inhibits the flow of current...?" },
                    { 10, 1, "Dennis Ritchie & Ken Thompson", "David Filo & Jerry Yang", "Vint Cerf & Robert Kahn", "Steve Case & Jeff Bezos", "Who developed Yahoo?" },
                    { 9, 0, "Alan Turing", "Jeff Bezos", "George Boole", "Charles Babbage", "Who is largely responsible for breaking the German Enigma codes, created a test that provided a foundation for artificial intelligence?" },
                    { 8, 3, "To decrease the current", "To increase the current", "To decrease the voltage momentarily", "To increase the voltage momentarily", "The purpose of choke in tube light is ?" },
                    { 7, 0, "Flash", "Flange", "Fury", "FRAM", "Which is a type of Electrically-Erasable Programmable Read-Only Memory?" },
                    { 6, 1, "Sound", "Remote control", "Color balance", "High voltage", "Most modern TV's draw power even if turned off. The circuit the power is used in does what function?" },
                    { 5, 2, "1950s", "1960s", "1970s", "1980s", "In which decade was the SPICE simulator introduced?" },
                    { 4, 1, "Report", "Field", "Record", "File", "What is part of a database that holds only one type of information?" },
                    { 3, 1, "1850s", "1880s", "1930s", "1950s", "In which decade was the American Institute of Electrical Engineers (AIEE) founded?" },
                    { 2, 3, "Charles Babbage", "Linus Torvalds", "Dennis Ritchie", "James Gosling", "Who invented the first computer ?" },
                    { 19, 0, "Database", "Double Byte", "Data Block", "Driver Boot", "'DB' computer abbreviation usually means ?" },
                    { 20, 0, "Phil Zimmermann", "Tim Berners-Lee", "Marc Andreessen", "Ken Thompson", "Who created Pretty Good Privacy (PGP)?" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
