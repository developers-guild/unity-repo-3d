using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileAim : MonoBehaviour
{
    public float speed = 0.0f;
    public Transform target;
    public bool isMoving = false;

    private Vector3 direction;

    void Update()
    {
        if(isMoving && target != null)
        {
            direction = target.transform.position - transform.position;
            float mag = direction.magnitude;
            direction /= mag;

            transform.Translate(direction * speed * Time.deltaTime);
        }
    }
}
