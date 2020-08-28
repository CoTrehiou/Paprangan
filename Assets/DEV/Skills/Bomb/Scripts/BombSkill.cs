using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSkill : Skill
{
    [SerializeField] GameObject _bombe;
    [SerializeField] Heros _heros;
    [SerializeField] float _decalPlayer = 1;

    [SerializeField] float _delayExplosion = 2f;


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

 /*   private void Update()
    {
        //Vector3 _positionHeros = _heros.transform.position;
        Vector3 _positionBomb = _heros.transform.TransformPoint(Vector3.forward * _decalPlayer);//_heros.transform.position + _heros.transform.InverseTransformDirection(Vector3.forward * _decalPlayer) + _heros.transform.InverseTransformDirection(Vector3.forward * _decalPlayer); ;
        Debug.DrawRay(_positionBomb, Vector3.up,Color.red);
    }*/
    private void PlaceBomb()
    {
        canPutBomb = false;
     //   Vector3 _positionBomb = new Vector3(_heros.transform.localPosition.x, _heros.transform.localPosition.y, _heros.transform.localPosition.z + _decalPlayer);
     //   Debug.DrawRay(_positionBomb, Vector3.up);

        Vector3 _positionBomb = _heros.transform.TransformPoint(Vector3.forward * _decalPlayer);
        Instantiate(_bombe, _positionBomb, Quaternion.identity);
        
    }

    IEnumerator PlaceBombCoroutine()
    {
        yield return new WaitForSeconds(_delayExplosion);
        canPutBomb = true;
      /*  Bomb bombExplosion = _bombe.GetComponent<Bomb>();
        if(bombExplosion)
        {
           // bombExplosion.MeshBomb.enabled = false;
           // bombExplosion.Explosion.Play();
        }
        else
        {
            Debug.Log("BombExplosion not found");
        }
        yield return new WaitForSeconds(bombExplosion.Explosion.main.duration);

        Debug.Log("A pété");
        Destroy(this);*/
    }
}
