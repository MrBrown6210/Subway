using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Vector3 offset;
    GameObject player;
    private void Start()
    {
        player = FindObjectOfType<CharacterMovement>().gameObject;
    }

    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        transform.LookAt(player.transform);
    }
}
