using UnityEngine;

[CreateAssetMenu(fileName = "ItemDefinition", menuName = "Inventory/Item Definition", order = 0)]
public class ItemDefinition : ScriptableObject
{
    public Sprite Sprite;
    public bool IsStackable;
    public float Weight = 1;
    public int SellCost;
    public float BaseDurability = 100;
}