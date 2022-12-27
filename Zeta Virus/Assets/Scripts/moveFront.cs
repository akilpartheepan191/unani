using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveFront : MonoBehaviour
{
    public Transform zom;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        zom.transform.position = new Vector3(zom.position.x, zom.position.y, zom.position.z + 0.01f*speed);
    }
}
