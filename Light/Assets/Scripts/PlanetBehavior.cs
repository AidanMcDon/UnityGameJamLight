using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlanetBehavior : MonoBehaviour
{
    public bool PlanetDead = false;
    public float PlanetHealth;
    public GameObject Planet;

    // Start is called before the first frame update
    void Start()
    {
       private int CurrentHealth = PlanetHealth;
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(CurrentHealth);
       if(PlanetDead == true)
        {
            //Destroy(Planet);
            Debub.Log("Planet Dead");
        }
    }

}
