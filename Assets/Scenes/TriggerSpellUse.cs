using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpellUse : MonoBehaviour
{
    private int couldownSpell;
    private void Start()
    {
        GameEvents.current.SpellUseTrigger(couldownSpell);
    }

}
