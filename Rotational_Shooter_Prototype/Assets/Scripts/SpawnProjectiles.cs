using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProjectiles : MonoBehaviour
{
    #region Variables
    public GameObject projectile;
    #endregion

    private void Update()
    {
        GetMouseClickDown();
    }

    void GetMouseClickDown()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SpawnTheProjectileVOID();
        }
    }

    void SpawnTheProjectileVOID()
    {
        GameObject projectileClone;

        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       projectileClone = Instantiate(projectile, transform.position, Quaternion.Euler(0, 0, transform.eulerAngles.z)) as GameObject;

        Rigidbody projectileRigidBody = projectileClone.AddComponent<Rigidbody>();
        projectileRigidBody.velocity = mousePosition * 4.0f;
        projectileRigidBody.useGravity = false;
    }
} // main class
