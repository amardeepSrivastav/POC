using Microsoft.EntityFrameworkCore;
using POC.Models;

namespace POC.Data
{
    public class POCDbContext: DbContext
    {
        public POCDbContext(DbContextOptions<POCDbContext> opt):base(opt)
        {

        }
        
        public DbSet<Question> Questions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>().HasData(
                new Question{
                    QuestionId = 1,
                    QuestionText = "What does HTML stand for?",
                    Option1 = "Hyper Trainer Marking Language",
                    Option2 = "Hyper Text Marketing Language",
                    Option3 = "Hyper Text Markup Leveler",
                    Option4 = "Hyper Text Markup Language",
                    Answer = 3
                },
                new Question{
                    QuestionId = 2,
                    QuestionText = "Who invented the first computer ?",
                    Option1 = "Charles Babbage",
                    Option2 = "Linus Torvalds",
                    Option3 = "Dennis Ritchie",
                    Option4 = "James Gosling",
                    Answer = 3
                },
                new Question{
                    QuestionId = 3,
                    QuestionText = "In which decade was the American Institute of Electrical Engineers (AIEE) founded?",
                    Option1 = "1850s",
                    Option2 = "1880s",
                    Option3 = "1930s",
                    Option4 = "1950s",
                    Answer = 1
                },
                new Question{
                    QuestionId = 4,
                    QuestionText = "What is part of a database that holds only one type of information?",
                    Option1 = "Report",
                    Option2 = "Field",
                    Option3 = "Record",
                    Option4 = "File",
                    Answer = 1
                },
                new Question{
                    QuestionId = 5,
                    QuestionText = "In which decade was the SPICE simulator introduced?",
                    Option1 = "1950s",
                    Option2 = "1960s",
                    Option3 = "1970s",
                    Option4 = "1980s",
                    Answer = 2
                },
                new Question{
                    QuestionId = 6,
                    QuestionText = "Most modern TV's draw power even if turned off. The circuit the power is used in does what function?",
                    Option1 = "Sound",
                    Option2 = "Remote control",
                    Option3 = "Color balance",
                    Option4 = "High voltage",
                    Answer = 1
                },
                new Question{
                    QuestionId = 7,
                    QuestionText = "Which is a type of Electrically-Erasable Programmable Read-Only Memory?",
                    Option1 = "Flash",
                    Option2 = "Flange",
                    Option3 = "Fury",
                    Option4 = "FRAM",
                    Answer = 0
                },
                new Question{
                    QuestionId = 8,
                    QuestionText = "The purpose of choke in tube light is ?",
                    Option1 = "To decrease the current",
                    Option2 = "To increase the current",
                    Option3 = "To decrease the voltage momentarily",
                    Option4 = "To increase the voltage momentarily",
                    Answer = 3
                },
                new Question{
                    QuestionId = 9,
                    QuestionText = "Who is largely responsible for breaking the German Enigma codes, created a test that provided a foundation for artificial intelligence?",
                    Option1 = "Alan Turing",
                    Option2 = "Jeff Bezos",
                    Option3 = "George Boole",
                    Option4 = "Charles Babbage",
                    Answer = 0
                },
                new Question{
                    QuestionId = 10,
                    QuestionText = "Who developed Yahoo?",
                    Option1 = "Dennis Ritchie & Ken Thompson",
                    Option2 = "David Filo & Jerry Yang",
                    Option3 = "Vint Cerf & Robert Kahn",
                    Option4 = "Steve Case & Jeff Bezos",
                    Answer = 1
                },
                new Question{
                    QuestionId = 11,
                    QuestionText = "Made from a variety of materials, such as carbon, which inhibits the flow of current...?",
                    Option1 = "Choke",
                    Option2 = "Inductor",
                    Option3 = "Resistor",
                    Option4 = "Capacitor",
                    Answer = 2
                },
                new Question{
                    QuestionId = 12,
                    QuestionText = "The most common format for a home video recorder is VHS. VHS stands for...?",
                    Option1 = "Video Home System",
                    Option2 = "Very high speed",
                    Option3 = "Video horizontal standard",
                    Option4 = "Voltage house standard",
                    Answer = 0
                },
                new Question{
                    QuestionId = 13,
                    QuestionText = "What does VVVF stand for?",
                    Option1 = "Variant Voltage Vile Frequency",
                    Option2 = "Variable Velocity Variable Fun",
                    Option3 = "Very Very Vicious Frequency",
                    Option4 = "Variable Voltage Variable Frequency",
                    Answer = 3
                },
                new Question{
                    QuestionId = 14,
                    QuestionText = "What frequency range is the High Frequency band?",
                    Option1 = "100 kHz",
                    Option2 = "1 GHz",
                    Option3 = "30 to 300 MHz",
                    Option4 = "3 to 30 MHz",
                    Answer = 3
                },
                new Question{
                    QuestionId = 15,
                    QuestionText = "The first step to getting output from a laser is to excite an active medium. What is this process called?",
                    Option1 = "Pumping",
                    Option2 = "Exciting",
                    Option3 = "Priming",
                    Option4 = "Raising",
                    Answer = 0
                },
                new Question{
                    QuestionId = 16,
                    QuestionText = "Which motor is NOT suitable for use as a DC machine?",
                    Option1 = "Permanent magnet motor",
                    Option2 = "Series motor",
                    Option3 = "Squirrel cage motor",
                    Option4 = "Synchronous motor",
                    Answer = 2
                },
                new Question{
                    QuestionId = 17,
                    QuestionText = "The purpose of choke in tube light is ?",
                    Option1 = "To decrease the current",
                    Option2 = "To increase the current",
                    Option3 = "To decrease the voltage momentarily",
                    Option4 = "To increase the voltage momentarily",
                    Answer = 3
                },
                new Question{
                    QuestionId = 18,
                    QuestionText = "What does the term PLC stand for?",
                    Option1 = "Programmable Lift Computer",
                    Option2 = "Program List Control",
                    Option3 = "Programmable Logic Controller",
                    Option4 = "Piezo Lamp Connector",
                    Answer = 2
                },
                new Question{
                    QuestionId = 19,
                    QuestionText = "'DB' computer abbreviation usually means ?",
                    Option1 = "Database",
                    Option2 = "Double Byte",
                    Option3 = "Data Block",
                    Option4 = "Driver Boot",
                    Answer = 0
                },
                new Question{
                    QuestionId = 20,
                    QuestionText = "Who created Pretty Good Privacy (PGP)?",
                    Option1 = "Phil Zimmermann",
                    Option2 = "Tim Berners-Lee",
                    Option3 = "Marc Andreessen",
                    Option4 = "Ken Thompson",
                    Answer = 0
                }
            );
        }
    }
}