using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public Transform go;
    public float speed_x;
    public float speed_y;
    public float speed_z;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(speed_x, speed_y, speed_z * Time.deltaTime); //rotates 50 degrees per second around z axis
        Debug.Log(go.transform.rotation.x);
        //go.transform.rotation = new Quaternion(go.transform.rotation.x + 0.01f * speed_x, go.transform.rotation.y + 0.01f * speed_y, go.transform.rotation.z+0.01f*speed_z,1f);
    }
}
