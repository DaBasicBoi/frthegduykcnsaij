using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class dedlol : MonoBehaviour

{
    public GameObject Dedlol;
    public Transform player;


    // Start is called before the first frame update
    void Start()
    {
        Dedlol.SetActive(false);
    }

// Update is called once per frame
    void Update()
    {
        if(player.position.z == 150)
        {
            Uded();
        }
        else
        {
            Ualive();
        }
    }

    public void Uded()
    {
        Dedlol.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Ualive()
    {
        Dedlol.SetActive(false);
        Time.timeScale = 1f;
    }
}