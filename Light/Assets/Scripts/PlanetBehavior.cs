using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlanetBehavior : MonoBehaviour
{
    public bool PlanetDead = false;
    public float PlanetHealth;
    public GameObject Planet;
    private float CurrentHealth;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       if(PlanetDead == true)
        {

            Destroy(Planet);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision");
    }

}
