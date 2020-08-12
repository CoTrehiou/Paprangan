using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField]
    Image Redbar;
    [SerializeField]
    private bool hasHealthPotion = true;
    [SerializeField]
    int MaxHealth =  100;
    [SerializeField]
    int CurrentHealth = 100;
    // Start is called before the first frame update
    void Start()
    {
        //m_ChangelLife.AddListener(UpdateHealthbar);
        // calcul of heakthbar shape in %


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void UpdateHealthbar()
    {
        int HealthbarShape = MaxHealth / CurrentHealth * 100;
    }

}
