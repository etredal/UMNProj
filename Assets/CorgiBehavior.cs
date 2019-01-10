using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorgiBehavior : MonoBehaviour
{
    [SerializeField]
    Vector3 movement = new Vector3(0.0f, 0.0f, 0.0f);

    // Update is called once per frame
    void Update()
    {
        transform.position += movement;   
    }
}
