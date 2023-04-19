using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlanetMovement))]
public class RandomPlanetMovement : MonoBehaviour
{
    //script is used to randomly assign a movement position to the gameobject. it checks every movecheckcooldown seconds and if the planet is still it assigns it a new position

    [SerializeField] private float moveCheckTime, moveCheckCooldown;
    [SerializeField] private float[] bounds;//the positions the assigned movment is set between. in the order: xMin, xMax, yMin, yMax
    // Start is called before the first frame update
    void Start()
    {
        moveCheckTime = moveCheckCooldown;
    }

    // Update is called once per frame
    void Update()
    {
        moveCheckTime -= Time.deltaTime;
        if(moveCheckTime <= 0)
        {
            if (!gameObject.GetComponent<PlanetMovement>().IsMoving())
            {
                gameObject.GetComponent<PlanetMovement>().MoveToPosition(new Vector2(Random.Range(bounds[0], bounds[1]), Random.Range(bounds[2], bounds[3])));

            }
            moveCheckTime = moveCheckCooldown;
        }
    }
}
