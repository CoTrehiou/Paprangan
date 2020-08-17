using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumUpdate : MonoBehaviour
{
    private float finalTime;
    private float currentNum;
    [SerializeField] Text textCouldown;
    // Start is called before the first frame update
    void Start()
    {
        currentNum = finalTime - Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        currentNum = finalTime - Time.time;
        textCouldown = currentNum;
    }
}