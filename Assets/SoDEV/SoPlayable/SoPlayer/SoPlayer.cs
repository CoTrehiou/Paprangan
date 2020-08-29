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
    public So_heros _selected;

    public So_heros selected;
    [SerializeField]
    private List<MoControllable> _selfUnits;
    /*[SerializeField]
    private ControllerReference _controller;*/
    // Start is called before the first frame update
    [SerializeField] ControllerReference _controller;

    public ControllerReference KeyBoardController { get => _controller; set => _controller = value; }


    void Start()
    {
        selected = Instantiate(_selected, new Vector3(0, 0, 0), Quaternion.identity) as So_heros;
        _selfUnits.Add(selected);
        Debug.Log(selected);

        _controller.enabled = true;

        //Instanciate camera
        //Instanciate UI
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
