using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{
    [SerializeField] float _delaySkill;
    // Start is called before the first frame update

    public void  ActiveSkill()
    {
        EventManager._instance.OnSkillUsed(_delaySkill);
    }
}
