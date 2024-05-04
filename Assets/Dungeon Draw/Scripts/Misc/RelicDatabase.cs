using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelicDatabase : MonoBehaviour
{
    public static List<Relic> allRelics = new List<Relic>();
    // private static string imagePath = "RelicArt/";

    public static void prePopulate()
    {
        allRelics.Add(new Relic(0, "RelicArt/Strawberry", "Strawberry", "Increases Max HP by 7", 50, rarityValues.common,  relicFunction.Instant, relicAbility.increaseMaxHp,7)); //Single function relic
        allRelics.Add(new Relic(1, "RelicArt/BigToe", "Big Toe", "Grants the player 50 gold and a random card", 150, rarityValues.uncommon, relicFunction.Instant, relicAbility.coinIncrease, relicFunction.Custom, relicAbility.Custom, 50, -1)); //Double function relic with one being a custom function
        allRelics.Add(new Relic(2, "RelicArt/Starfish", "Starfish", "A living breathing starfish... Raises Maximum HP by 14", 200, rarityValues.rare, relicFunction.Instant, relicAbility.increaseMaxHp, 14));
        allRelics.Add(new Relic(3, "RelicArt/TNT", "TNT", "First attack deals 6 extra damage", 100, rarityValues.common, relicFunction.Combat, relicAbility.Custom, 6));
        allRelics.Add(new Relic(4, "RelicArt/PurpleTurtle", "Purple Turtle", "Prevents the first time you would lose HP in combat", 250, rarityValues.rare));
        allRelics.Add(new Relic(5, "RelicArt/GreenLiquid", "Suspicious Green Liquid", "When an enemy dies, gain 1 mana and draw 1 card", 125, rarityValues.uncommon, relicFunction.Combat, relicAbility.Custom, 1));
        allRelics.Add(new Relic(6, "RelicArt/Cookie", "Chocolate Chip Cookie", "If you end your turn without block, gain 3 block", 100, rarityValues.common, relicFunction.Combat, relicAbility.Custom, 3));
        allRelics.Add(new Relic(7, "RelicArt/SandShovel", "Sand Shovel", "You can now dig for relics at rest sites", 1, rarityValues.rare));
    }

    public static Relic getRelic(int id)
    {
        return allRelics[id];
        
    }
   
}