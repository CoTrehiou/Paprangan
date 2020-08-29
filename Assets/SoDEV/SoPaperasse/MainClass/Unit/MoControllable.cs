using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//#define moving to point /moving to direction

/*
 * What he can do :
 * -his next fonctionnality must be optionnal
 * -be controllable (human or ia)
 * -moving in a direction (to the North !)
 * -making an action (spell)
 * -moving to a point whith navmesh and a algorythme (ex: A*)
 */
public class MoControllable : MonoBehaviour
{
    public MonoSkill _skillOne, _skillTwo, _skillThree, _skillFour, _skillFive;
    public FloatReference _speed;
    [SerializeField] Transform _MoControllableTransform;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Move(Vector3 direction)
    {
        Debug.Log("Ok Bro...");
        _MoControllableTransform.Translate(direction * Time.deltaTime * _speed.Variable.Value);
        Debug.Log(this);
    }
}