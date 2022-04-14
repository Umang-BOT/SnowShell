using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    public GameObject enemy;
    
    // Start is called before the first frame update
    void Start()
    {

        //SpawnSpike();
        startspawning();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnSpike()
    {
        float randomx = Random.Range(-1.85f, 1.85f);
        Vector2 ran = new Vector2(randomx, transform.position.y);
        Instantiate(enemy, ran, Quaternion.identity);
    }
    public void startspawning()
    {
        InvokeRepeating("SpawnSpike", 1f, 0.5f);
    }
    public void stopspawning()
    {
        CancelInvoke("SpawnSpike");
    }
}
