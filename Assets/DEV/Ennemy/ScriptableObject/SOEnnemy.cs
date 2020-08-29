using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ennemy", menuName = "ScriptableObjects/Ennemy", order = 1)]
public class SOEnnemy : ScriptableObject
{
    [Header("State")]
    public float _health = 100;
    public int speed = 10;

    [Header("Damage")]
    public float _attackDamage = 10;
    public float _attackRate = 2;

    [SerializeField] GameObject _apparenceEnnemy;
}
