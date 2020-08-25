using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombExplosion : MonoBehaviour
{
    [SerializeField] ParticleSystem _explosion;
    [SerializeField] MeshRenderer _meshBomb;

    public ParticleSystem Explosion { get => _explosion; set => _explosion = value; }
    public MeshRenderer MeshBomb { get => _meshBomb; set => _meshBomb = value; }
}
