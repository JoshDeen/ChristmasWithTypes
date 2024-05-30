using System;
namespace ChristmasWithTypes
{
    public class Christmas
    {
        public string[] Presents;
        public string Santa { get; set; }
        public int? TreeHeight { get; set; } //Fixed: Added to Null

        //Fixed: Added the days
        public enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

    }
}
