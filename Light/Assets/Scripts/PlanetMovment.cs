using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetMovment : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MoveToPosition(new Vector3(2, 2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveToPosition(Vector2 position, float timeInSeconds = 3)
    {
        StartCoroutine(Move(transform.position, position, timeInSeconds));
    }

    private IEnumerator Move(Vector2 startPosition, Vector2 endPosition, float timeInSeconds)
    {
        int i = 0;

        while (Vector3.Distance(transform.position,endPosition) > 0.1f)
        {
            Debug.Log(i);

            Vector2 newPos = Vector2.Lerp(startPosition, endPosition, i / (float)120);

            transform.position = newPos;

            i++;

            yield return new WaitForSeconds(timeInSeconds/120);
        }


    } 
}
