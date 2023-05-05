// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Source source = new Source("Piss Poop");

Quote wayne_gretsky = new Quote("Wayne Gretsky", "You miss 100% of the shots you don't take.",source);

Console.WriteLine(wayne_gretsky.GetQuote());

Board _board = new Board();
_board.AddQuote(wayne_gretsky);

_board.AddQuote(
    new Quote(
        "Paul",
        "God hath not given us the spirit of fear; but of power, and of love, and of a sound mind.",
        new Source("2 Timothy 1:7")
    )
);

_board.AddQuote(
    new Quote(
        "Sister Elaine S. Dalton",
        "Work hard to achieve your dreams. Don't let discouragement or mistakes delay you.",
        new Source(
            "How to Dare Great Things",
            "https://www.churchofjesuschrist.org"
        )
    )
);

_board.AddQuote(new Quote("Alma", "If ye have faith ye hope for things which are not " +
"seen, which are true.",new Source("Alma 32:21")));
_board.AddQuote(new Quote("Alma","Live in thanksgiving daily.",new Source("Alma 34:38")));
_board.AddQuote(new Quote("Alma","Counsel with the Lord in all thy doings, and he will"+
" direct thee for good.",new Source("Alma 37:37")));

// quoteboard.GetRandomQuote();

Menu _menu = new Menu(_board);
_menu.Display();