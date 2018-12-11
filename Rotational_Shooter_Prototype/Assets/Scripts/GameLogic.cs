using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    #region Variables
    public float enemySpawnTimeFloat = 1.0f;
    public GameObject enemyToSpawn;
    public bool canSpawn = true;
    #endregion

    private void Start()
    {
        StartCoroutine(EnemySpawnTimer());
    }

    IEnumerator EnemySpawnTimer()
    {
        while(canSpawn == true)
        {
            SpawnEnemy0();
        }

        yield return new WaitForSeconds(enemySpawnTimeFloat);
    }

    void SpawnEnemy0()
    {
        Instantiate(enemyToSpawn, new Vector3(-38f, 18f, 0f), Quaternion.identity);
    }
} // main class
