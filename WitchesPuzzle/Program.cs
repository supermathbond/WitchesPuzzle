using System.Collections.Generic;

namespace WitchesPuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            var cards = InitCards();
            WitchesSolver solver = new WitchesSolver();
            solver.Solve(cards);
        }

        static WitchCard[] InitCards()
        {
           return new WitchCard[]
           {
                new WitchCard {Edges = new Dictionary<Direction, CardEdge> { {Direction.Up, new CardEdge { WitchColor = Color.Blue, WitchPart = Part.Head } },
                                                                             {Direction.Right, new CardEdge { WitchColor = Color.Red, WitchPart = Part.Head } },
                                                                             {Direction.Down, new CardEdge { WitchColor = Color.Red, WitchPart = Part.Tail } },
                                                                             {Direction.Left, new CardEdge { WitchColor = Color.Purple, WitchPart = Part.Tail } },
                                                                            } },
                new WitchCard {Edges = new Dictionary<Direction, CardEdge> { {Direction.Up, new CardEdge { WitchColor = Color.Green, WitchPart = Part.Head } },
                                                                             {Direction.Right, new CardEdge { WitchColor = Color.Red, WitchPart = Part.Tail } },
                                                                             {Direction.Down, new CardEdge { WitchColor = Color.Blue, WitchPart = Part.Tail } },
                                                                             {Direction.Left, new CardEdge { WitchColor = Color.Purple, WitchPart = Part.Head } },
                                                                            }},
                new WitchCard {Edges = new Dictionary<Direction, CardEdge> { {Direction.Up, new CardEdge { WitchColor = Color.Green, WitchPart = Part.Head } },
                                                                             {Direction.Right, new CardEdge { WitchColor = Color.Blue, WitchPart = Part.Tail } },
                                                                             {Direction.Down, new CardEdge { WitchColor = Color.Purple, WitchPart = Part.Tail } },
                                                                             {Direction.Left, new CardEdge { WitchColor = Color.Green, WitchPart = Part.Head } },
                                                                            }},
                new WitchCard {Edges = new Dictionary<Direction, CardEdge> { {Direction.Up, new CardEdge { WitchColor = Color.Blue, WitchPart = Part.Head } },
                                                                             {Direction.Right, new CardEdge { WitchColor = Color.Blue, WitchPart = Part.Head } },
                                                                             {Direction.Down, new CardEdge { WitchColor = Color.Red, WitchPart = Part.Tail } },
                                                                             {Direction.Left, new CardEdge { WitchColor = Color.Purple, WitchPart = Part.Tail } },
                                                                            }},
                new WitchCard {Edges = new Dictionary<Direction, CardEdge> { {Direction.Up, new CardEdge { WitchColor = Color.Blue, WitchPart = Part.Head } },
                                                                             {Direction.Right, new CardEdge { WitchColor = Color.Green, WitchPart = Part.Tail } },
                                                                             {Direction.Down, new CardEdge { WitchColor = Color.Blue, WitchPart = Part.Tail } },
                                                                             {Direction.Left, new CardEdge { WitchColor = Color.Red, WitchPart = Part.Head } },
                                                                            }},
                new WitchCard {Edges = new Dictionary<Direction, CardEdge> { {Direction.Up, new CardEdge { WitchColor = Color.Blue, WitchPart = Part.Head } },
                                                                             {Direction.Right, new CardEdge { WitchColor = Color.Blue, WitchPart = Part.Head } },
                                                                             {Direction.Down, new CardEdge { WitchColor = Color.Purple, WitchPart = Part.Tail } },
                                                                             {Direction.Left, new CardEdge { WitchColor = Color.Red, WitchPart = Part.Tail } },
                                                                            }},
                new WitchCard {Edges = new Dictionary<Direction, CardEdge> { {Direction.Up, new CardEdge { WitchColor = Color.Blue, WitchPart = Part.Head } },
                                                                             {Direction.Right, new CardEdge { WitchColor = Color.Purple, WitchPart = Part.Head } },
                                                                             {Direction.Down, new CardEdge { WitchColor = Color.Green, WitchPart = Part.Tail } },
                                                                             {Direction.Left, new CardEdge { WitchColor = Color.Blue, WitchPart = Part.Tail } },
                                                                            }},
                new WitchCard {Edges = new Dictionary<Direction, CardEdge> { {Direction.Up, new CardEdge { WitchColor = Color.Blue, WitchPart = Part.Tail } },
                                                                             {Direction.Right, new CardEdge { WitchColor = Color.Green, WitchPart = Part.Head } },
                                                                             {Direction.Down, new CardEdge { WitchColor = Color.Red, WitchPart = Part.Head } },
                                                                             {Direction.Left, new CardEdge { WitchColor = Color.Green, WitchPart = Part.Tail } },
                                                                            }},
                new WitchCard {Edges = new Dictionary<Direction, CardEdge> { {Direction.Up, new CardEdge { WitchColor = Color.Blue, WitchPart = Part.Tail } },
                                                                             {Direction.Right, new CardEdge { WitchColor = Color.Red, WitchPart = Part.Tail } },
                                                                             {Direction.Down, new CardEdge { WitchColor = Color.Green, WitchPart = Part.Head } },
                                                                             {Direction.Left, new CardEdge { WitchColor = Color.Purple, WitchPart = Part.Head } },
                                                                            }}
           };
        }
    }
}
