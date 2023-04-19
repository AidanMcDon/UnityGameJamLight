using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    [SerializeField] private float maxHealth, maxHeatShield;
    public float health, heatShield;
    [SerializeField] private GameObject sun;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Sun.InSun(gameObject))
        {
            print("in the sun");
        }
    }
}
