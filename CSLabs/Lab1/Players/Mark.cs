using Lab1.Players.ParentPlayers;
using Lab1.Strategy.ParentStrategy;

namespace Lab1.Players
{
    public class Mark : Player
    {
        public Mark(IStrategy strategy) : base(strategy)
        {
        }
        public override int SayCard()
        {
            return HisStrategy.ReturnNumberCard(CardDeck);
        }
    };
}