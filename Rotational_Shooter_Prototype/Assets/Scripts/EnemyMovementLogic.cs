using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementLogic : MonoBehaviour
{
    #region Variables

    #endregion

    private void Update()
    {
        MoveEnemyToPlayer();
    }

    void MoveEnemyToPlayer()
    {
        transform.position = Vector3.Slerp(transform.position, new Vector3(0, 0, 0), 1.0f * Time.deltaTime);
    }

} // main class
