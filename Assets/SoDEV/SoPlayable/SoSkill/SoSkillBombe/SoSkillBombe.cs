using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoSkillBombe : SoEventSkill
{
    public IntReference _damage;
    public FloatReference _couldownXplosion;
    public FloatReference _couldownSpell;
    public FloatReference _currentCouldownSpell;
    public MonoSkillBomb _monoSkillBomb;
    // il appartient à une unité --> récupérer le parent du script
    public SoBombe _SoBombe;// ActiveSkill à besoin d'un receptacle pour la bombe

    public override void SoActiveSkill()
    {
        _couldownSpell = _monoSkillBomb._couldownSpell;
        _couldownXplosion = _monoSkillBomb._couldownXplosion;
        _damage = _monoSkillBomb._bombDamage;
        if (_currentCouldownSpell.Variable.Value < 0)
        {
            SoBombe Bombe = Instantiate(_SoBombe, new Vector3(0, 0, 0), Quaternion.identity) as SoBombe;
            Bombe.Damage = _damage;
            Bombe._couldownXplosion = _couldownXplosion;
            _currentCouldownSpell.Variable.Value += _couldownSpell.Variable.Value;
        }
    }
}
