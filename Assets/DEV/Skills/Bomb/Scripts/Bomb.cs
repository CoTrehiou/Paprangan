using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : Skill
{
    [SerializeField] GameObject _bombe;
    [SerializeField] Heros _heros;
    [SerializeField] float _decalPlayer = 1;

    bool canPutBomb = true;
    public override void ActiveSkill()
    {
        if (canPutBomb)
        {
            base.ActiveSkill();
            //Take current position of heros and place bomb in front of him
            PlaceBomb();
            StartCoroutine(PlaceBombCoroutine());
        }
    }

    private void PlaceBomb()
    {
        canPutBomb = false;
        Vector3 _positionBomb = new Vector3(_heros.transform.position.x, _heros.transform.position.y, _heros.transform.position.z + _decalPlayer);
        Instantiate(_bombe, _positionBomb, Quaternion.identity);
    }

    IEnumerator PlaceBombCoroutine()
    {
        yield return new WaitForSeconds(_delaySkill);
        canPutBomb = true;
    }
}
