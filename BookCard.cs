using System;
using System.Collections.Generic;
using System.Text;

namespace pz___2._3
{
    class BookCard
    {
        public int ID; 
        public string author;
        public string title;
        public int year;
        public string condition;
        public BookCard(int _ID, string _author, string _title, int _year, string _condition)
        {
            ID = _ID;
            author = _author;
            title = _title;
            year = _year;
            condition = _condition;
        }

        public void GetBookInfo()
        {
            Console.WriteLine($"ID = {ID}, year = {year}, author = {author}, title = {title}, condition = {condition}");
        }
    }
}
    

