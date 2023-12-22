using System;
namespace ChristmasWithTypes
{
    public class Christmas
    {
        public string[] Presents;
        public string Santa { get; set; }

        // TODO: Make the Height property nullable
        public int? TreeHeight { get; set; }

        // TODO: Make the property "Day" of type enum
        public enum Day
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        public Day ChristmasDay { get; set; } // Assign the day to this property
    }

}
}
