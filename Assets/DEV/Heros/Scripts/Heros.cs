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

    [SerializeField] KeyCode _leftTurnKey = KeyCode.A;
    [SerializeField] KeyCode _rightTurnKey = KeyCode.E;

    [Header("Movement")]
    [SerializeField] Transform _herosTransform;
    [SerializeField] float speed = 5f;
    [SerializeField] float _speedTurn = 5f;


    [Header("Skills")]
    [SerializeField] KeyCode _keySkillOne = KeyCode.H;
    [SerializeField] KeyCode _keySkillTwo = KeyCode.J;
    [SerializeField] KeyCode _keySkillThree = KeyCode.K;
    [SerializeField] KeyCode _keySkillFour = KeyCode.L;
    [SerializeField] KeyCode _keySkillFive = KeyCode.M;

    [SerializeField] Skill _skillOne, _skillTwo, _skillThree, _skillFour, _skillFive;

    float _rotationAmount = 2;

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

        ActiveSkill(_keySkillOne, _skillOne);
        ActiveSkill(_keySkillTwo, _skillTwo);
        ActiveSkill(_keySkillThree, _skillThree);
        ActiveSkill(_keySkillFour, _skillFour);
        ActiveSkill(_keySkillFive, _skillFive);

        Rotate(_leftTurnKey, -1);
        Rotate(_rightTurnKey, 1);
    }

    private void Rotate(KeyCode _turnKey, int direction)
    {
        if (Input.GetKey(_turnKey))
        {
            Vector3 newRotation = Vector3.up * direction * _rotationAmount;
            transform.Rotate(newRotation);
        }
    }

    private void ActiveSkill(KeyCode keySkill, Skill skillNumber)
    {
        if (Input.GetKey(keySkill))
        {
            skillNumber.ActiveSkill();
        }
    }

    protected void Move(KeyCode key, Vector3 direction)
    {

        if (Input.GetKey(key))
        {
            _herosTransform.Translate(direction * Time.deltaTime * speed);
        }
    }
}
