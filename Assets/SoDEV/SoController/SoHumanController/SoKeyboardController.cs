using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This is the class that own the commande
 */
[CreateAssetMenu]
public class SoKeyBoardController : ScriptableObject
{

    public List<KeyCode> _keycode = new List<KeyCode>()
                    {
                        KeyCode.Z,
                        KeyCode.S,
                        KeyCode.Q,
                        KeyCode.D,
                        KeyCode.H,
                        KeyCode.J,
                        KeyCode.K,
                        KeyCode.L,
                        KeyCode.M,
                        KeyCode.A,
                        KeyCode.E
                    };
}
