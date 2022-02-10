using System;

namespace pz___2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            BookCard b1 = new BookCard(1, "Пушкин", "Дубровский", 1999, "Отличное");
            BookCard b2 = new BookCard(2, "Лермонтов", "Парус", 2001, "Удовлетворяющие");
            BookCard b3 = new BookCard(3, "Есенин", "Сорокоуст", 1988, "Неудовлетворяющие");
            BookCard b4 = new BookCard(4, "Толстой", "Казаки", 1998, "Хорошое");

            b1.GetBookInfo();
            b2.GetBookInfo();
            b3.GetBookInfo();
            b4.GetBookInfo();
        }
    }
}
