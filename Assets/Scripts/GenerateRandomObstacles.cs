using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateRandomObstacles : MonoBehaviour
{
    public GameObject treePrefab;
    public GameObject rampPrefab;
    public GameObject spikeyBallPrefab;
    public GameObject industryPrefab;

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

                float randomObstacle = Random.Range(0, 34);
                //Debug.Log("Obstacle: " + randomObstacle);

                if (randomObstacle >= 0 && randomObstacle <= 4)
                {
                    objectNext = null;
                }
                else if (randomObstacle >= 5 && randomObstacle <= 10)
                {
                    objectNext = null;
                }
                else if (randomObstacle >= 11 && randomObstacle <= 16)
                {
                    objectNext = treePrefab;
                }
                else if (randomObstacle >= 17 && randomObstacle <= 22)
                {
                    objectNext = treePrefab;
                }
                else if (randomObstacle >= 23 && randomObstacle <= 27)
                {
                    objectNext = rampPrefab;
                }
                else if (randomObstacle >= 28 && randomObstacle <= 32)
                {
                    objectNext = spikeyBallPrefab;
                }
                else if (randomObstacle == 33)
                {
                    objectNext = industryPrefab;
                }

                //switch (randomObstacle)
                //{
                //    case 0:
                //        break;
                //    case 1:
                //        objectNext = treePrefab;
                //        break;
                //    case 2:
                //        objectNext = rampPrefab;
                //        break;
                //    case 3:
                //        objectNext = spikeyBallPrefab;
                //        break;
                //    default:
                //        break;
                //}

                if (objectNext)
                {
                    float randomX = Random.Range(-23.0f, 23.0f);
                    //Debug.Log("Random X: " + randomX);

                    Vector3 obstaclePosition = new Vector3(randomX, objectNext.transform.position.y, 160f);

                    Vector3 obstacleRotationVector = new Vector3(objectNext.transform.eulerAngles.x, objectNext.transform.eulerAngles.y, objectNext.transform.eulerAngles.z);
                    Quaternion obstacleRotation = Quaternion.Euler(obstacleRotationVector.x, obstacleRotationVector.y, obstacleRotationVector.z);

                    Instantiate(objectNext, obstaclePosition, obstacleRotation);
                }

                timer = timer - waitTime; // Resets the timing interval
            }
        }
    }
}
