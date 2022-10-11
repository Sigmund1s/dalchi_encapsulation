class Score 
{
    private int CurrentScore;

    public Score(int defaultScore) {
        CurrentScore = defaultScore;
    }

    public int getCurrentScore()
    {
        return CurrentScore;
    }

    public void setCurrentScore(int newScore)
    {
        if (newScore < 0)
        {
            newScore = 0;
        }
        CurrentScore = newScore;
    }


}
