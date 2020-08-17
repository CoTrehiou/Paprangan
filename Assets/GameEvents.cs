using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    private void Awake()
    {
        current = this;
    }


    public event Action<float> onSpellUseTrigger;
    public void SpellUseTrigger(float couldownSpell)
    {
        if (onSpellUseTrigger != null)
        {
            onSpellUseTrigger(couldownSpell);
        }
    }
    
}
