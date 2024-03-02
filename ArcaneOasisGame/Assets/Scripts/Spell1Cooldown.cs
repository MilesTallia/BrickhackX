using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Spell1Cooldown : MonoBehaviour {
    [SerializeField]
    private Image imageCooldown;

    [SerializeField]
    private TMP_Text textCooldown;

    private bool isCooldown = false;
    private float cooldownTimer = 0;
    private float cooldownTime = 10.0f;

    public CastSpells castSpells;

    void Start() {
        textCooldown.gameObject.SetActive(false);
        imageCooldown.fillAmount = 0.0f;
    }

    void Update() {
        if(isCooldown) {
            ApplyCooldown();
        }        
    }

    void ApplyCooldown() {
        cooldownTimer -= Time.deltaTime;

        if(castSpells.getSpellTimer1() < 0.0f) {
            isCooldown = false;
            textCooldown.gameObject.SetActive(false);
            imageCooldown.fillAmount = 0.0f;
        } else {
            textCooldown.text = Mathf.RoundToInt(cooldownTimer).ToString();
            imageCooldown.fillAmount = cooldownTimer / cooldownTime;

        }
    }

    //for now does nothing
    // public bool UseSpell()
    // {
    //     if (CastSpells.getSpellTimer1() <= 0)
    //     {
    //         return false;
    //     }
    //     else
    //     {
    //         isCooldown = true;
    //         textCooldown.gameObject.SetActive(true);
    //         cooldownTimer = cooldownTime;
    //         return true;
    //     }
    // }
}
