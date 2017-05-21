using System.Collections.Generic;

namespace WitchesPuzzle
{
    public class WitchCard
    {
        public const int MAX_ROTATIONS = 4;

        public Dictionary<Direction, CardEdge> Edges;
        
        public bool MatchCard(WitchCard cardToMatch, Direction directionToMatch)
        {
            if (cardToMatch == null)
                return true;

            CardEdge edgeToCompare = null;

            switch(directionToMatch)
            {
                case Direction.Down:
                    edgeToCompare = cardToMatch.Edges[Direction.Up];
                    break;
                case Direction.Up:
                    edgeToCompare = cardToMatch.Edges[Direction.Down];
                    break;
                case Direction.Right:
                    edgeToCompare = cardToMatch.Edges[Direction.Left];
                    break;
                case Direction.Left:
                    edgeToCompare = cardToMatch.Edges[Direction.Right];
                    break;
            }

            return Edges[directionToMatch].WitchColor == edgeToCompare.WitchColor && 
                Edges[directionToMatch].WitchPart != edgeToCompare.WitchPart;
        }

        public void RotateCardClockwise()
        {
            var temp = Edges[Direction.Up];
            Edges[Direction.Up] = Edges[Direction.Left];
            Edges[Direction.Left] = Edges[Direction.Down];
            Edges[Direction.Down] = Edges[Direction.Right];
            Edges[Direction.Right] = temp;
        }
    }

    public class CardEdge
    {
        public Color WitchColor;
        public Part WitchPart;
    }
}
