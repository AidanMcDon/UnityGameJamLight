using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Sun
{


    public static bool InSun(GameObject obj)
    {
        var sunPosition = GameObject.FindGameObjectWithTag("Sun").transform.position;
        var direction = obj.transform.position - sunPosition;

        RaycastHit2D hit = Physics2D.Raycast(sunPosition, direction, Mathf.Infinity, LayerMask.GetMask("Player","Planet"));

        if(hit.collider is not null)
        {
            Debug.DrawLine(sunPosition, hit.point,Color.white);

            if(hit.collider.gameObject == obj)
            {
                return true;
            }

        }


        return false;
    }
}
