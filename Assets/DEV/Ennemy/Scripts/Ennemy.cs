using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ennemy : MonoBehaviour
{
    [SerializeField] SOEnnemy _soEnnemy;

    [SerializeField] NavMeshAgent _agentEnnemy;

     Heros _currentFocusHeros;


    /// <summary>
    /// When ennemy spawn, they choose one heros on list
    /// </summary>
    private void Start()
    {
        _agentEnnemy.speed = _soEnnemy.speed;
        _currentFocusHeros = GameManager._instance.FocusHeros();
       
    }

    private void FixedUpdate()
    {
        if (_currentFocusHeros)
        {
            _agentEnnemy.SetDestination(_currentFocusHeros.transform.position);
            transform.LookAt(_currentFocusHeros.transform.position);
        }
    }
}
