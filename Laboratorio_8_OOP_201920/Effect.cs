using Laboratorio_8_OOP_201920.Cards;
using Laboratorio_8_OOP_201920.Enums;
using System.Collections.Generic;

namespace Laboratorio_8_OOP_201920
{
    public static class Effect
    {
        private static Dictionary<EnumEffect, string> effectDescriptions = new Dictionary<EnumEffect, string>()
        {
            { EnumEffect.bitingFrost, "Sets the strength of all melee cards to 1 for both players" },
            { EnumEffect.impenetrableFog, "Sets the strength of all range cards to 1 for both players" },
            { EnumEffect.torrentialRain, "Sets the strength of all longRange cards to 1 for both players" },
            { EnumEffect.clearWeather, "Removes all Weather Card (Biting Frost, Impenetrable Fog and Torrential Rain) effects" },
            { EnumEffect.moraleBoost, "Adds +1 to all units in the row (excluding itself)" },
            { EnumEffect.spy, "Place on your opponent's battlefield (counts towards opponent's total) and draw 2 cards from your deck" },
            { EnumEffect.tightBond, "Place next to a card with the same name to double the strength of both cards" },
            { EnumEffect.buff, "Doubles the strength of all unit cards in that row. Limited to 1 per row" },
            { EnumEffect.none, "None" },
        };

        public static string GetEffectDescription(EnumEffect e)
        {
            return effectDescriptions[e];
        }

        public static void ApplyEffect(Card playedCard, Player activePlayer, Player opponent, Board board)
        {
            //Recomendación: Utilice switch(playedCard.CardEffect) para definir los distintos efectos.
            switch (playedCard.CardEffect)
            {
                case EnumEffect.bitingFrost:
                    foreach (CombatCard card in activePlayer.Board.PlayerCards[activePlayer.Id][EnumType.melee])
                    {
                        card.AttackPoints = 1;
                    }
                    foreach (CombatCard card in activePlayer.Board.PlayerCards[opponent.Id][EnumType.melee])
                    {
                        card.AttackPoints = 1;
                    }
                    break;
                case EnumEffect.impenetrableFog:
                    foreach (CombatCard card in activePlayer.Board.PlayerCards[activePlayer.Id][EnumType.range])
                    {
                        card.AttackPoints = 1;
                    }
                    foreach (CombatCard card in activePlayer.Board.PlayerCards[opponent.Id][EnumType.range])
                    {
                        card.AttackPoints = 1;
                    }
                    break;
                case EnumEffect.torrentialRain:
                    foreach(CombatCard card in activePlayer.Board.PlayerCards[activePlayer.Id][EnumType.longRange])
                    {
                        card.AttackPoints = 1;
                    }
                    foreach (CombatCard card in activePlayer.Board.PlayerCards[opponent.Id][EnumType.longRange])
                    {
                        card.AttackPoints = 1;
                    }
                    break;
                case EnumEffect.clearWeather:
                    board.WeatherCards.Clear();
                    foreach (CombatCard card in activePlayer.Board.PlayerCards[activePlayer.Id][EnumType.melee])
                    {
                        card.AttackPoints = card.OriginalAttackPoints;
                    }
                    foreach (CombatCard card in activePlayer.Board.PlayerCards[opponent.Id][EnumType.melee])
                    {
                        card.AttackPoints = card.OriginalAttackPoints;
                    }
                    foreach (CombatCard card in activePlayer.Board.PlayerCards[activePlayer.Id][EnumType.range])
                    {
                        card.AttackPoints = card.OriginalAttackPoints;
                    }
                    foreach (CombatCard card in activePlayer.Board.PlayerCards[opponent.Id][EnumType.range])
                    {
                        card.AttackPoints = card.OriginalAttackPoints;
                    }
                    foreach (CombatCard card in activePlayer.Board.PlayerCards[activePlayer.Id][EnumType.longRange])
                    {
                        card.AttackPoints = card.OriginalAttackPoints;
                    }
                    foreach (CombatCard card in activePlayer.Board.PlayerCards[opponent.Id][EnumType.longRange])
                    {
                        card.AttackPoints = card.OriginalAttackPoints;
                    }
                    break;
                case EnumEffect.moraleBoost:
                    break;
                case EnumEffect.spy:
                    break;
                case EnumEffect.tightBond:
                    break;
                case EnumEffect.buff:
                    break;
                case EnumEffect.none:
                    break;
                default:
                    break;
            }
        }
    }
}
