using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiBarUpdater : MonoBehaviour
{

    [SerializeField] private GameObject healthUi, heatShieldUi;
    public void UpdateHealth(float healthScale)
    {
        healthUi.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, healthScale * 1000);
    }

    public void UpdateHeatShield(float heatShieldScale)
    {
        heatShieldUi.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, heatShieldScale * 1000);
    }
}
