using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public enum Rarity
{
    Base,
    Rare,
    TagTeam,
    ItemCard,
    //full art
    Special
}

public enum Brand
{
    TMNT,
    Transformers,
    Anime,
    DC,
    Marvel,
    Gaming,
    Simpsons
    //Disney Pixar PowerRangers 
}



[CreateAssetMenu(fileName = "New Card", menuName = "SO_Card")]
public class Card : ScriptableObject
{
    public string cardName;
    public string motto;
    public int cardNo;
    public Sprite frontArt;
    public Sprite backArt;
    public Rarity rarity;
    public Brand brand;
}
