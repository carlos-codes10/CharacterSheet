using System.Xml.Schema;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterSheet : MonoBehaviour
{
    [SerializeField] string CharacterName;
    [SerializeField] int ProficiencyBonus;
    [SerializeField] bool FinesseWeapon;
    [SerializeField] [Range(-5, 5)] int Strength;
    [SerializeField] [Range(-5, 5)] int Dexterity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [ContextMenu("Retry Game")]
    void Start()
    {
        int HitMod;

        if (Strength > Dexterity) {
            HitMod = (Strength + ProficiencyBonus);
        }
        else {
            HitMod = (Dexterity + ProficiencyBonus);
        }

        if (HitMod > 0) {
            Debug.Log(CharacterName + " hit modifier is +" + HitMod);
        }
        else {
            Debug.Log(CharacterName + " hit modifier is " + HitMod);
        }

        int AC = Random.Range(10, 21);
        Debug.Log("Enemy AC is " + AC);

        int D20 = Random.Range(1, 21);
        Debug.Log(CharacterName +  " rolled " +  D20);

        int TotalDamage = (D20 + HitMod);

        if (TotalDamage > AC) {
            Debug.Log("Enemy Hit!");
        }
        else {
            Debug.Log("Enemy Miss!");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
