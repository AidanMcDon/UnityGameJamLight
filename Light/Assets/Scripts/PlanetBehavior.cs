using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlanetBehavior : MonoBehaviour
{
    public bool PlanetDead = false;
    public float PlanetHealth = 50;
    public GameObject Planet, PlanetPrefab;
    private float CurrentHealth, StartingHealth, NewPlanetHealth;

    void Start()
    {
        GameObject PlanetPrefab = Resources.Load("Planet") as GameObject; //doesnt work
    }

    void Update()
    {
       if(PlanetDead == true) 
        {
            //*check if planet is dead, move offscreen, give more health, change sprite

            //Planet.transform.position = new Vector3(20, 20, 0); //teleports planet off screen
            //NewPlanetHealth = PlanetHealth + 20;
            //PlanetHealth = NewPlanetHealth;

            Destroy(Planet); //*causes errors in sun script
            Instantiate(PlanetPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            PlanetDead = false;
        }
    }

    void OnCollisionEnter(Collision collision) // check if player is colliding *doesnt work
    {
        Debug.Log("collision");
    }

}
