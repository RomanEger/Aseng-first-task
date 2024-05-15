namespace Game;

public class GameClass
{
    public bool Game(int[] candy)
    {
        int maryPoints = 0;
        
        int nikolayPoints = 0;
        
        var candyList = candy.ToList();

        bool isMaryStep = true; 
        
        while (candyList.Count > 0)
        {
            if (candyList.First() > candyList.Last())
            {
                if (isMaryStep)
                    maryPoints += candyList.First();
                else 
                    nikolayPoints += candyList.First();
                candyList.Remove(candyList.First());
            }
            else
            {
                if (isMaryStep)
                    maryPoints += candyList.Last();
                else 
                    nikolayPoints += candyList.Last();
                candyList.Remove(candyList.Last());
            }
            isMaryStep = !isMaryStep;
        }

        return maryPoints > nikolayPoints;
    }
}