ComicBook comic1 = new ComicBook("Spider-Man", 1962, 5.99, "Marvel Comics", "Stan Lee");
ComicBook comic2 = new ComicBook("Batman", 1939, 10.99, "DC Comics", "Bob Kane");
ComicBook comic3 = new ComicBook("X-Men", 1963, 7.99, "Marvel Comics", "Stan Lee");


PostStamp postStamp1 = new PostStamp("First Postage Stamp", 1840, 25.50, "https://example.com/first-postage-stamp.jpg");
PostStamp postStamp2 = new PostStamp("Penny Black", 1840, 100.00, "https://example.com/penny-black.jpg");
PostStamp postStamp3 = new PostStamp("Blue Mauritius", 1847, 1500000.00, "https://example.com/blue-mauritius.jpg");


Wine wine1 = new Wine("Chardonnay", 2018, 25.99, 8.50, "France", WineType.WHITE);
Wine wine2 = new Wine("Merlot", 2015, 34.99, 9.75, "Italy", WineType.RED);
Wine wine3 = new Wine("Riesling", 2016, 19.99, 7.25, "Germany", WineType.SPARKLING);


List<Collectible> collectibles = new List<Collectible>()
{
    comic1,
    postStamp1,
    wine1,
    comic2,
    postStamp2,
    wine2,
    comic3,
    postStamp3,
    wine3
};



if (comic1 is Collectible)
{
    Console.WriteLine("Comics are collectibles");
}

if (wine1 is Collectible)
{
    Console.WriteLine("Wines are collectibles");
}

if (postStamp1 is Collectible)
{
    Console.WriteLine("Post stamps are collectibles");
}


// Sorting the list of Collectibles

Console.WriteLine(" ");

foreach (Collectible collectible in collectibles)
{
    Console.WriteLine(collectible.Price);
    // Console.WriteLine($"Start bid price: {collectible.StartBidPrice}, Type of collectible: {collectible.CollectType}");
}

Console.WriteLine("");


collectibles.Sort();


foreach (Collectible collectible in collectibles)
{
    Console.WriteLine(collectible.Price);
    // Console.WriteLine($"Start bid price: {collectible.StartBidPrice}, Type of collectible: {collectible.CollectType}");
}