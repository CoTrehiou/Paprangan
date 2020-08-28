using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

//#define macro if controller is SoKeyboardController or SoMouseController

/*
 * C'est là classe qui control mais elle n'assigne pas les touche
 * il faudra rajouter autre part la possibilité de sélectionné différente unité
 */
[Serializable]
public class ControllerReference
{

    public SoKeyBoardController _keyBoardController;
    [SerializeField]
    private SoPlayer _soPlayer;
    private MoControllable _unitSelected;
    private MoControllable _unitControlled;
    private MonoSkill _skillOne, _skillTwo, _skillThree, _skillFour, _skillFive;

    KeyCode _forwardKey;
    KeyCode _backwardKey;
    KeyCode _leftKey;
    KeyCode _rightKey;

    KeyCode _keySkillOne;
    KeyCode _keySkillTwo;
    KeyCode _keySkillThree;
    KeyCode _keySkillFour;
    KeyCode _keySkillFive;

    KeyCode _leftTurnKey;
    KeyCode _rightTurnKey;

    [SerializeField] Transform _unitTransform;
    [SerializeField] float speed = 5f;
    [SerializeField] float _speedTurn = 5f;
    [SerializeField] float _rotationAmount = 2;




    // Start is called before the first frame update
    void Start()
    {
        ControlNewUnit();

        KeyCode _forwardKey = _keyBoardController._keycode[0];
        KeyCode _backwardKey = _keyBoardController._keycode[1];
        KeyCode _leftKey = _keyBoardController._keycode[2];
        KeyCode _rightKey = _keyBoardController._keycode[3];

        KeyCode _keySkillOne = _keyBoardController._keycode[4];
        KeyCode _keySkillTwo = _keyBoardController._keycode[5];
        KeyCode _keySkillThree = _keyBoardController._keycode[6];
        KeyCode _keySkillFour = _keyBoardController._keycode[7];
        KeyCode _keySkillFive = _keyBoardController._keycode[8];

        KeyCode _leftTurnKey = _keyBoardController._keycode[9];
        KeyCode _rightTurnKey = _keyBoardController._keycode[10];
    }
    
    // Update is called once per frame
    protected void Update()
    {
        if (_unitControlled != _soPlayer.selected)
        {
            ControlNewUnit();
        }


        Move(_forwardKey, Vector3.forward, _unitSelected);
        Move(_backwardKey, Vector3.back, _unitSelected);
        Move(_leftKey, Vector3.left, _unitSelected);
        Move(_rightKey, Vector3.right, _unitSelected);
        
        ActiveSkill(_keySkillOne, _skillOne, _unitSelected);
        ActiveSkill(_keySkillTwo, _skillTwo, _unitSelected);
        ActiveSkill(_keySkillThree, _skillThree, _unitSelected);
        ActiveSkill(_keySkillFour, _skillFour, _unitSelected);
        ActiveSkill(_keySkillFive, _skillFive, _unitSelected);

        Rotate(_leftTurnKey, -1, _unitSelected);
        Rotate(_rightTurnKey, 1, _unitSelected);
    }

    private void ControlNewUnit()
    {
        _unitControlled = _soPlayer.Heros;
        _skillOne = _soPlayer.Heros._skillOne;
        _skillTwo = _soPlayer.Heros._skillTwo;
        _skillThree = _soPlayer.Heros._skillThree;
        _skillFour = _soPlayer.Heros._skillFour;
        _skillFive = _soPlayer.Heros._skillFive;
        if (_soPlayer.Heros._skillOne) { _skillOne = _soPlayer.Heros._skillOne; }
        if (_soPlayer.Heros._skillTwo) { _skillTwo = _soPlayer.Heros._skillTwo; }
        if (_soPlayer.Heros._skillThree) { _skillThree = _soPlayer.Heros._skillThree; }
        if (_soPlayer.Heros._skillFour) { _skillFour = _soPlayer.Heros._skillFour; }
        if (_soPlayer.Heros._skillFive) { _skillFive = _soPlayer.Heros._skillFive; }
        
        // on récupère les capacités de cette nouvelle unité
        //foreach (SoSkill soSkill in _unitControlled.)

    }

    private void Rotate(KeyCode _turnKey, int direction, MoControllable _unitControlled)
    {
        if (Input.GetKey(_turnKey))
        {
            Vector3 newRotation = Vector3.up * direction * _rotationAmount;
            _unitControlled.transform.Rotate(newRotation);
        }
    }
    protected void Move(KeyCode key, Vector3 direction, MoControllable _unitControlled)
    {

        if (Input.GetKey(key))
        {
            _unitControlled.transform.Translate(direction * Time.deltaTime * speed);
        }
    }


    private void ActiveSkill(KeyCode keySkill, MonoSkill skillNumber, MoControllable _unitSelected)
    {
        if (Input.GetKey(keySkill))
        {
            skillNumber.soEventSkill.SoActiveSkill();
        }
    }

    private void MoveTo(Position position)
        // move to a position
    {

    }

}