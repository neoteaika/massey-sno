using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateRandomObstacles : MonoBehaviour
{
    public GameObject treePrefab;
    public GameObject rampPrefab;
    public GameObject spikeyBallPrefab;

    private float waitTime = 1.25f; // Wait this amount of time before generating a new obstacle
    private float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (treePrefab && rampPrefab && spikeyBallPrefab) // Stops an unknown exception error
        {

            timer += Time.deltaTime;

            if (timer > waitTime)
            {
                GameObject objectNext = null;

                float randomObstacle = Random.Range(0, 3);
                Debug.Log("Obstacle: " + randomObstacle);

                switch (randomObstacle)
                {
                    case 0:
                        break;
                    case 1:
                        objectNext = treePrefab;
                        break;
                    case 2:
                        objectNext = rampPrefab;
                        break;
                    case 3:
                        objectNext = spikeyBallPrefab;
                        break;
                    default:
                        break;
                }

                if (objectNext)
                {
                    float randomX = Random.Range(-23.0f, 23.0f);
                    Debug.Log("Random X: " + randomX);

                    Vector3 obstaclePosition = new Vector3(randomX, 0f, 248f);
                    Quaternion obstacleRotation = new Quaternion(0f, 0f, 0f, 1);

                    Instantiate(objectNext, obstaclePosition, obstacleRotation);
                }

                timer = timer - waitTime; // Resets the timing interval
            }
        }
    }
}
