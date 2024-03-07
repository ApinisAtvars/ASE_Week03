Book some_book = new Book("B01", "There are words here", 2004, "Wordman Wordsmith");
Magazine some_magazine = new Magazine("M01", "WORD", 2024, 1);
DVD some_dvd = new DVD("D01", "DVD containing music", 2024, 100);

List<LibraryItem> libraryItems = new List<LibraryItem>();

libraryItems.Add(some_book);
libraryItems.Add(some_magazine);
libraryItems.Add(some_dvd);

foreach (LibraryItem item in libraryItems)
{
    item.PrintDetails();
}