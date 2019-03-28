using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pivotScript : MonoBehaviour
{
    public float pivotSize = .75f;
    public Color pivotColor = Color.yellow;

    private void OnDrawGizmos()
    {
        Gizmos.color = pivotColor;
        Gizmos.DrawWireSphere(transform.position, pivotSize);
    }
}
