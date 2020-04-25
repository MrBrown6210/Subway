using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
    public UnityEvent onHit;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("x");
        onHit?.Invoke();
    }
}
