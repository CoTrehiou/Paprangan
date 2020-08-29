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
public class ControllerReference : MonoBehaviour
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

    //[SerializeField] Transform _unitTransform;
    [SerializeField] float speed = 5f;
    [SerializeField] float _speedTurn = 5f;
    [SerializeField] float _rotationAmount = 2;




    // Start is called before the first frame update
    void Start()
    {

        ControlNewUnit();
        
        _forwardKey = _keyBoardController._keycode[0];
        _backwardKey = _keyBoardController._keycode[1];
        _leftKey = _keyBoardController._keycode[2];
        _rightKey = _keyBoardController._keycode[3];

        _keySkillOne = _keyBoardController._keycode[4];
        _keySkillTwo = _keyBoardController._keycode[5];
        _keySkillThree = _keyBoardController._keycode[6];
        _keySkillFour = _keyBoardController._keycode[7];
        _keySkillFive = _keyBoardController._keycode[8];

        _leftTurnKey = _keyBoardController._keycode[9];
        _rightTurnKey = _keyBoardController._keycode[10];

    }
    
    // Update is called once per frame
    protected void Update()
    {
        
        if (_unitControlled != _soPlayer.selected)
        {
            ControlNewUnit();
        }

        ActiveMove(_forwardKey, Vector3.forward);
        ActiveMove(_backwardKey, Vector3.back);
        ActiveMove(_leftKey, Vector3.left);
        ActiveMove(_rightKey, Vector3.right);

        ActiveSkill();


        Rotate(_leftTurnKey, -1, _unitControlled);
        Rotate(_rightTurnKey, 1, _unitControlled);
    }

    private void ControlNewUnit()
    {
        _unitControlled = _soPlayer.selected;
        /*_skillOne = _soPlayer.Heros._skillOne;
        _skillTwo = _soPlayer.Heros._skillTwo;
        _skillThree = _soPlayer.Heros._skillThree;
        _skillFour = _soPlayer.Heros._skillFour;
        _skillFive = _soPlayer.Heros._skillFive;*/
        if (_soPlayer.selected._skillOne) { _skillOne = _soPlayer.selected._skillOne; }
        if (_soPlayer._selected._skillTwo) { _skillTwo = _soPlayer._selected._skillTwo; }
        if (_soPlayer._selected._skillThree) { _skillThree = _soPlayer._selected._skillThree; }
        if (_soPlayer._selected._skillFour) { _skillFour = _soPlayer._selected._skillFour; }
        if (_soPlayer._selected._skillFive) { _skillFive = _soPlayer._selected._skillFive; }
        
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
    /*protected void Move(KeyCode key, Vector3 direction, MoControllable _unitControlled)
    {
        if (Input.GetKey(key))
        {
            _unitControlled.transform.Translate(direction * Time.deltaTime * speed);
            Debug.Log(_unitControlled);
        }
    }*/
    protected void ActiveMove(KeyCode key, Vector3 direction)
    {
        if (Input.GetKey(key)) { _unitControlled.Move(direction); }
    }


    private void ActiveSkill()
    {

        if (Input.GetKey(_keySkillOne)) { _unitControlled._skillOne.SoActiveSkill(); }
        /*if (Input.GetKey(_keySkillTwo)) { _unitControlled._skillTwo.SoActiveSkill(); }
        if (Input.GetKey(_keySkillThree)) { _unitControlled._skillThree.SoActiveSkill(); }
        if (Input.GetKey(_keySkillFour)) { _unitControlled._skillFour.SoActiveSkill(); }
        if (Input.GetKey(_keySkillFive)) { _unitControlled._skillFive.SoActiveSkill(); }*/

    }

    private void MoveTo(Position position)
        // move to a position
    {

    }

}