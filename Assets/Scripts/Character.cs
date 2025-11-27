using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // STEP 2. Character 클래스에 캐릭터 데이터를 작성
    // 필요한 필드 및 생성자 작성
    // STEP 4. Character 클래스의 필드를 {get; private set;}으로 만들기 
    public string Name { get; private set; }
    public int Level { get; private set; }
    public int Atk { get; private set; }
    public int Def { get; private set; }
    public int Hp { get; private set; }
    public int Gold { get; private set; }
    public string Description { get; private set; }
    public int Critical { get; private set; }

    public List<Item> Inventory { get; private set; }

    public Character(string name, int level, int atk, int def, int hp, int gold, string description, int critical)
    {
        Name = name;
        Level = level;
        Atk = atk;
        Def = def;
        Hp = hp;
        Gold = gold;
        Description = description;
        Critical = critical;
    }
    
    public void Equip(Item item)
    {
        if (!item.IsEquipped)
        {
            item.IsEquipped = true;
        }
    }

    public void UnEquip(Item item)
    {
        if (item.IsEquipped)
        {
            item.IsEquipped = false;
        }
    }
}
