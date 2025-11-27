using UnityEngine;

public class Item : MonoBehaviour
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public int AtkBonus { get; private set; }
    public int DefBonus { get; private set; }
    public bool IsEquipped { get; set; }

    public Item(string name, string description, int atk, int def)
    {
        Name = name;
        Description = description;
        AtkBonus = atk;
        DefBonus = def;
        IsEquipped = false;
    }
}
