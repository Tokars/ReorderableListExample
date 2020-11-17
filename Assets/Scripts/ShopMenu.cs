using System.Collections.Generic;
using UnityEngine;

public class ShopMenu : MonoBehaviour
{
    [HideInInspector] public List<Drinks> Drinks = new List<Drinks>();
}

[System.Serializable]
public class Drinks
{
    public string name;
    public float range;
    public Color color;
}