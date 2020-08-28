using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Attribute:
 * have a controller Type
 * score
 */
[Serializable]
public class SoPlayer : MonoBehaviour
{
    [SerializeField]
    private IntVariable _score;
    [SerializeField]
    public So_heros Heros;

    public GameObject selected;
    [SerializeField]
    private List<MoControllable> _selfUnits;
    [SerializeField]
    private ControllerReference _controller;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Heros, new Vector3(0, 0, 0), Quaternion.identity);
        _selfUnits.Add(Heros);

        //Instanciate camera
        //Instanciate UI
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
