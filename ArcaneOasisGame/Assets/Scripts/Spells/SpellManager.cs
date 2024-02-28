using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpellManager : MonoBehaviour
{
    public int spellSlots = 2;
    public List<Spell> spells = new List<Spell>();

    private List<KeyCode> keys = new List<KeyCode>{
        KeyCode.Alpha1, KeyCode.Alpha2, KeyCode.Alpha3, 
        KeyCode.Alpha4, KeyCode.Alpha5, KeyCode.Alpha6, 
        KeyCode.Alpha7, KeyCode.Alpha8, KeyCode.Alpha8
    };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < spells.Count; i++){
            if (Input.GetKeyDown(keys[i])){
                Spell spell = spells[i];
                if (spell.getTimer() <= 0){
                    spell.castSpell(0);
                }
            }
        }
    }

    public void addSpell(Spell spell){
        if (spells.Count < spellSlots){
            spells.Add(spell);
        }
    }

    public void removeSpell(Spell spell){
        spells.Remove(spell);
    }

    public void addSpellSlots(int num){
        spellSlots += num;
    }
}
