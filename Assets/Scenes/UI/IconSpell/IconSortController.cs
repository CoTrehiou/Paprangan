using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconSortController : MonoBehaviour
{
    private float finalTime;// need to be set by the spell
    public GameObject Couldown360;

    private void Start() //when script open it suscribe to the EventManager --> it only suscribe !
    {
        GameEvents.current.onSpellUseTrigger += SpellCouldown;
    }

    private void onDoorwayOpen() //c'est ici que l'on fait l'action
        //le sort have to put a cooldown on the UI
    {
        // 1 get the sort icon (faire une class UI?) ou serialized
        couldownSpell = NexTime - Time.time;
        
    }
    
    private void SpellCouldown(float couldownSpell) //afficher le couldown et griser le sort
    {
        finalTime = couldownSpell + Time.time;

        Instantiate(Couldown360, finalTime);
        Couldown360.transform.parent = IconSpell.transform; //???? comment fait t'on pour qu'il fasse réf à l'objet du script

    }
}
//start coroutine (param couldowSpell) boucle while avec le déconte qui diminiu a chaque update_perso