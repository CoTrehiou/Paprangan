using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SoEventSkill : ScriptableObject
{
    public MoInteractable SoSkillUnit;//Ce qui est lancé par le sort
    // il appartient à une unité --> récupérer le parent du script
    public MoControllable soUnit;//lanceur
    
    public virtual void SoActiveSkill()
    {
    }
}