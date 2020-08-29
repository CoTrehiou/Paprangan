using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SoSkillBombe : SoEventSkill
{
    [SerializeField]
    public IntReference _damage;
    public FloatReference _couldownXplosion;
    public FloatReference _couldownSpell;
    public FloatReference _currentCouldownSpell;
    public MonoSkillBomb _monoSkillBomb;
    // il appartient à une unité --> récupérer le parent du script
    public SoBombe _SoBombe;// ActiveSkill à besoin d'un receptacle pour la bombe


}
