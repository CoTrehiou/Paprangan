using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Heros> _listHeros = new List<Heros>();
    public static GameManager _instance;

    private void Awake()
    {
        if (!_instance)
        {
            _instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public Heros FocusHeros()
    {
            Debug.Log(_listHeros.Count + "heros en stock");
            int numberHerosFocus = Random.Range(0, _listHeros.Count);
            Debug.Log("heroes n°" + numberHerosFocus);
            return _listHeros[numberHerosFocus];
    }
}
