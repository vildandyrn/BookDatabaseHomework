using BookDatabaseHomework;

Book book1 = new Book()
{
    Title = "Hakkaride Bir Mevsim",
    Author = "Ferit Edgü",
    PublisherId = 1,
    Category = "Roman",
};

BookDataContext db = new BookDataContext();
{
    db.Books.Add(book1);
    db.SaveChanges();
}
