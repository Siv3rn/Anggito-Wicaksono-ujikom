using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject enemy;
    [SerializeField] private float counter;
    void Start()
    {
        StartCoroutine(SpawnEnemy());

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 6; i++)
        {
            if (counter == 5)
            {
                //Instantiate(enemy,transform.position,transform.rotation);
                counter = 0;
            }
            counter += 1 * Time.deltaTime;
        }
    }
    private IEnumerator SpawnEnemy(){
        float maxX = -8.5f;
        float minX = 12f;
        yield return new WaitForSeconds(2);
        Instantiate(enemy,new Vector3(transform.position.x,transform.position.y,transform.position.z),transform.rotation);
        StartCoroutine(SpawnEnemy());
    }
}
