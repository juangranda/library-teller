using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            //set the rental dates for each type via a static field
                //implement

            //create a list a propulate it with the date in our file
            FileIO getFile = new FileIO();

            //populate mediaToRent with the values returned from getFile instead of an empty list e.g. "new List<string>();"
            //implement
            List<string> mediaToRent = new List<string>();
            mediaToRent.Add("Type: Book, Title: The Count of Monte Cristo, Length: 928 pages");
            mediaToRent.Add("Type: DVD,Title: The Count of Monte Cristo,Length: 2h 14m");
            mediaToRent.Add("Type: Magazine,Title: People,Length: 50 pages");
            mediaToRent.Add("Type: Book,Title: Pride & Prejudice,Length: 272 pages");
            mediaToRent.Add("Type: DVD,Title: Avatar,Length: 2h 42m");
            
            //create a new list for us to use to store our media objects to rent
            List<Media> rentedMedia = new List<Media>();

            //for each line from the rental 
            foreach (string s in mediaToRent)
            {
                //match each needed component
                //populae with your regex to match the format

                Match match = Regex.Match(s, @"^Type:\s*(.*),Title:\s*(.*).Length:\s*([\w ]*)$");
                if (match.Success)
                {
                    //populate each component with the values from your capture groups
                    string type = match.Groups[1].ToString();
                    string title = match.Groups[2].ToString();
                    string length = match.Groups[3].ToString();

                    //using the components we got figure out which type of object we should create and insert
                    if (type.Equals("Book"))
                    {
                        //create a book object
                        //populate the book object with a title and length
                        //then add the newly created book to rentedMedia
                        Book myBook = new Book();
                        myBook.Title = title;
                        myBook.Length = length;
                        myBook.RentalLength = 7;
                        rentedMedia.Add(myBook);
                    }
                    //complete for the DVD and Magazine media types
                    //implement
                    if (type.Equals("DVD"))
                    {
                        DVD myDVD = new DVD();
                        myDVD.Title = title;
                        myDVD.Length = length;
                        myDVD.RentalLength = 7;
                        rentedMedia.Add(myDVD);
                    }
                    if (type.Equals("Magazine"))
                    {
                        Magazine myMagazine = new Magazine();
                        myMagazine.Title = title;
                        myMagazine.Length = length;
                        myMagazine.RentalLength = 7;
                        rentedMedia.Add(myMagazine);
                    }
                }
            }

            //for each media item we have in the list print the details for each
            foreach (Media mediaItem in rentedMedia)
            {
                    //for each mediaItem call PrintMediaDetails()
                    //implement
                    mediaItem.PrintMediaDetails();
            }

            //halt the program so we can read the output
            Console.ReadKey();
        }
    }
}
