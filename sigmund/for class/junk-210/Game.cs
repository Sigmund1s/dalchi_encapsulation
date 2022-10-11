class Game {

    Player player = new Player();

    Score score = new Score(300);

    Deck deck = new Deck();

    Card CurrentCard;

    public Game() {
        CurrentCard = deck.DrawRandomCard();
    }

    public void Play() {

        var keepPlaying = true;
        while (keepPlaying) {

            Console.WriteLine("");
            Console.WriteLine($"The card is: {CurrentCard.number}");

            var nextCard = deck.DrawRandomCard();
            var guess = player.Guess();

            var current = score.getCurrentScore(); // Just added for the private/encapsulation thing.

            if (guess == "h") {
                if (nextCard.number > CurrentCard.number) {
                    current += 100; // Just added for the private/encapsulation thing. Changed from Score.CurrentScore
                } else {
                    current -= 75;
                }

            } else if (guess == "l") {
                if (nextCard.number < CurrentCard.number) {
                    current += 100;
                } else {
                    current -= 75;
                }
            }

            score.setCurrentScore(current); //Just added for the private/encapsulation thing.

            Console.WriteLine($"Next card was: {nextCard.number}");
            Console.WriteLine($"Yours score is: {score.getCurrentScore}");
            CurrentCard = nextCard;

            keepPlaying = player.KeepPlaying();            
        }
    }
}
