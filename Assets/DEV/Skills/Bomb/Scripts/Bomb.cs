using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] ParticleSystem _explosion;
    [SerializeField] MeshRenderer _meshBomb;

    [SerializeField] float _delayExplosion = 2f;

    public ParticleSystem Explosion { get => _explosion; set => _explosion = value; }
    public MeshRenderer MeshBomb { get => _meshBomb; set => _meshBomb = value; }

    IEnumerator Start()
    {
        yield return new WaitForSeconds(_delayExplosion);
        _meshBomb.enabled = false;
        _explosion.Play();
        yield return new WaitForSeconds(1f);
        Debug.Log("A pété");
        Destroy(gameObject);
    }
}
