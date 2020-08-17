using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager _instance;
    public event Action<float> onSpellUseTrigger;

    void Awake()
    {

        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this);
        }
    }

    public void OnSkillUsed(float cooldownSpell)
    {
        onSpellUseTrigger?.Invoke(cooldownSpell);
    }

}
