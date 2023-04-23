using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlanetBehavior : MonoBehaviour
{
    public bool PlanetDead = false;
    public float PlanetHealth = 50;
    public GameObject Planet;
    private float CurrentHealth, StartingHealth;

    // Start is called before the first frame update
    void Start()
    {
        //private float NewPlanetHealth;
    }

    // Update is called once per frame
    void Update()
    {
       if(PlanetDead == true) //check if planet is dead, move offscreen, give more health
        {
            Planet.transform.position = new Vector3(20, 20, 0); //teleports planet off screen
            //NewPlanetHealth = PlanetHealth + 20;
            //PlanetHealth = NewPlanetHealth;
            //Destroy(Planet);

                        //change art to next planet
            PlanetDead = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision");
    }

}
