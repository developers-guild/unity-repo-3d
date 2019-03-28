using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseTurretScript : MonoBehaviour
{
    private Transform target;
    public float range = 15f;
    public Color turretRangeColor = Color.red;
    public string enemyTag = "Enemy";

    public Transform partToRotate;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }

    void UpdateTarget()
    {
        // retrieves all gameobjects that have the tag specified in the inspector
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        // Loop through all ocurrences looking for an enemy in range
        foreach(GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);

            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }

            if(nearestEnemy!=null && shortestDistance <= range)
            {
                target = nearestEnemy.transform;
            }
            else
            {
                target = null;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)  
            return;

        Vector3 direction = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(direction);

        Vector3 rotation = lookRotation.eulerAngles;

        partToRotate.rotation = Quaternion.Euler(0f, rotation.y, 0f);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
