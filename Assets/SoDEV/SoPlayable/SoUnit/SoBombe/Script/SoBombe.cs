using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoBombe : MoInteractable
{
    public IntReference Damage;
    public FloatReference _couldownXplosion;
    private FloatReference _currentCouldown;
    // Start is called before the first frame update

    [SerializeField] ParticleSystem _explosion;
    [SerializeField] MeshRenderer _meshBomb;

    
    public ParticleSystem Explosion { get => _explosion; set => _explosion = value; }
    public MeshRenderer MeshBomb { get => _meshBomb; set => _meshBomb = value; }

    IEnumerator Start()
    {
        Debug.Log("ya!!!");
        yield return new WaitForSeconds(_couldownXplosion.Variable.Value);
        Debug.Log("wait5s");
        _meshBomb.enabled = false;
        _explosion.Play();
        Debug.Log(_explosion);
        yield return new WaitForSeconds(1f);
        Debug.Log("A pété");
        Destroy(gameObject);
    }

}
