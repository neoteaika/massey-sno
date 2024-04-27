using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateRandomObstacles : MonoBehaviour
{
    public GameObject obstaclePrefab;

    public int objectMax = 20;

    private int objectCount = 0;

    private float waitTime = 1.25f; // Wait this amount of time before generating a new obstacle
    private float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject objectNext;

        if (obstaclePrefab) // Stops an unknown exception error
        {
            if (objectCount < objectMax) // Only render up to the maximum number of objects
            {
                float randomX = Random.Range(-23.0f, 23.0f);

                Vector3 obstaclePosition = new Vector3(randomX, 3f, -48f);
                Quaternion obstacleRotation = new Quaternion(0f, 0f, 0f, 1);

                timer += Time.deltaTime;

                if (timer > waitTime)
                {
                    Instantiate(obstaclePrefab, obstaclePosition, obstacleRotation);
                    timer = timer - waitTime; // Resets the timing interval

                    objectCount++;
                }
            }
        }
    }
}
