using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject playerBulletPrefab;
    public Transform projectileSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            //Debug.Log("Fire!");
            Instantiate(playerBulletPrefab, projectileSpawn.position, projectileSpawn.rotation);
        }
    }
}
