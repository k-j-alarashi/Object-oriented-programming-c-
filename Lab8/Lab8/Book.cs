using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class Book
    {
        private int id;
        private string title;
        private Author author;

        public int Id { get { return id; } set { id = value;} }
        public string Title { get { return title; } set { title = value; } }
        public Author Author { get { return author; } set { author = value; } }

        public Book(int id , string title , string name, string phone, int age)
        {
            this.id = id;
            this.title = title;
            this.author = new Author(name, phone, age);
        }
    }
}
