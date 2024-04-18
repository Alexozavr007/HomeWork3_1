using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_1_3 {
    internal class Book {
        public Author Author { get; private set; }
        public Title Title { get; private set; }
        public Content Content { get; private set; }


        public Book(Author author, Title title, Content content) {
            Content = content;
            Author = author;
            Title = title;
        }

        public void Show () {
            Author.Show();
            Title.Show();
            Content.Show();
        }
    }
}
