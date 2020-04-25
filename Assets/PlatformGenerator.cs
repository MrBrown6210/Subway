using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public List<GameObject> list = new List<GameObject>();
    private float width = 0;
    private int count = 0;

    private Collider _collider;
    // Start is called before the first frame update
    void Start()
    {
        foreach (var go in list)
        {
            if (go.transform.localScale.z > width)
                width = go.transform.localScale.z;
        }

        Gen();
    }

    void DetectionMove()
    {
        transform.position = transform.position + new Vector3(0, 0, width);
    }

    void Gen ()
    {
        float offsetX = -1.2f;
        list.Sort((a, b) => { return 1 - 2 * Random.Range(0, 1); });
        foreach (var go in list)
        {
            Vector3 offset = new Vector3(offsetX, 0, width/2);
            Instantiate(go, transform.position + offset, go.transform.rotation);
            offsetX += 1.2f;
        }
        DetectionMove();
        count++;
    }

    private void OnTriggerEnter(Collider other)
    {
        Gen();
    }
}