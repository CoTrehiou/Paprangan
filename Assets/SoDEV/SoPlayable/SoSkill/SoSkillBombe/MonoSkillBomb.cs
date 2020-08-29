using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MonoSkillBomb : MonoSkill
{
    public IntReference _bombDamage;
    public FloatReference _couldownXplosion;
    public MoInteractable _SoBombe; //Unit lancé par le sort
    public FloatReference _currentCouldownSpell;
    [SerializeField] Transform _moControllable;
    public float _decalPlayer;
    

    public override void SoActiveSkill()
    {
        Debug.Log("activebombe");
        if (_currentCouldownSpell.Variable.Value <= 0)
        {
            Vector3 _positionBomb = _moControllable.transform.TransformPoint(Vector3.forward * _decalPlayer);
            SoBombe Bombe = Instantiate(_SoBombe, _positionBomb, Quaternion.identity) as SoBombe;
            Bombe.Damage = _bombDamage;
            Bombe._couldownXplosion = _couldownXplosion;
            _currentCouldownSpell.Variable.Value += _currentCouldownSpell.Variable.Value;
        }
    }
}
