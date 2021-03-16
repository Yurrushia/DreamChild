using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlock : MonoBehaviour
{
    Vector3 p;
    Quaternion q;
    // Start is called before the first frame update
    void Start()
    {
        q=transform.rotation;
        p=transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y<-5)
        {
            transform.rotation=q;
            transform.position=p;
        }
    }
}
