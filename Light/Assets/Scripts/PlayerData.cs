using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(UiBarUpdater))]
public class PlayerData : MonoBehaviour
{
    private UiBarUpdater uiUpdater;
    [SerializeField] private float maxHealth, maxHeatShield, sunDamage, heatShieldRegenRate;
    public float health, heatShield;
    [SerializeField] private GameObject sun, particleSystemChild;

    // Start is called before the first frame update
    void Start()
    {
        uiUpdater = gameObject.GetComponent<UiBarUpdater>();
        health = maxHealth;
        heatShield = maxHeatShield;
    }

    // Update is called once per frame
    void Update()
    {
        if (Sun.InSun(gameObject))
        {
            particleSystemChild.GetComponent<ParticleSystem>().Play();
            if(heatShield > 0)
            {
                heatShield -= Time.deltaTime * sunDamage;
            }
            else
            {
                health -= Time.deltaTime * sunDamage;
            }
        }
        else if(heatShield < maxHeatShield)
        {
            particleSystemChild.GetComponent<ParticleSystem>().Stop();
            heatShield += Mathf.Min(heatShieldRegenRate * Time.deltaTime, maxHeatShield - heatShield);
        }


        uiUpdater.UpdateHealth(health/maxHealth);
        uiUpdater.UpdateHeatShield(heatShield/maxHeatShield);
    }
}
