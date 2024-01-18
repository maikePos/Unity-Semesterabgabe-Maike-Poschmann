using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingTarget : MonoBehaviour
{
    [SerializeField] private float pivotOffset;
    private void OnEnable()
    {
        SortingManager.RegisterTarget(this);
    }

    private void OnDisable()
    {
        SortingManager.DeregisterTarget(this);
    }


    public float Height()
    {
        return transform.position.y + pivotOffset;
    }

    public void SetOrder(int newOrderIndex)
    {
        GetComponent<SpriteRenderer>().sortingOrder = newOrderIndex;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position + Vector3.up * pivotOffset, 0.5f);
    }
}
