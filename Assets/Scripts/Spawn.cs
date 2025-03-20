using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField]
    private GameObject obj;
    float RandX;
    Vector2 whereSpawn;
    private float SpawnRate;
    float NextSpawn = 0.0f;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Time.time > NextSpawn)
        {
            {
                SpawnRate = Random.Range(0.2f, 2f);
                NextSpawn = Time.time + SpawnRate;
                RandX = Random.Range(-14.9f, 7.58f);
                whereSpawn = new Vector2(RandX, transform.position.y);
                Instantiate(obj, whereSpawn, Quaternion.identity);
            }
        }
    }
}
