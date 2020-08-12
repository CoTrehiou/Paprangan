using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heros : MonoBehaviour
{

    [Header("KeyCode")]
    [SerializeField] KeyCode _forwardKey = KeyCode.Z;
    [SerializeField] KeyCode _backwardKey = KeyCode.S;
    [SerializeField] KeyCode _leftKey = KeyCode.Q;
    [SerializeField] KeyCode _rightKey = KeyCode.D;

    [Header("Movement")]
    [SerializeField] Transform _herosTransform;
    [SerializeField] float speed = 5f;


    [Header("Skills")]
    [SerializeField] List<Skill> _listSkills = new List<Skill>();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    protected void Update()
    {
        Move(_forwardKey, Vector3.forward);
        Move(_backwardKey, Vector3.back);
        Move(_leftKey, Vector3.left);
        Move(_rightKey, Vector3.right);
    }

    protected void Move(KeyCode key, Vector3 direction)
    {

        if (Input.GetKey(key))
        {
            _herosTransform.Translate(direction * Time.deltaTime * speed);
        }
    }
}
