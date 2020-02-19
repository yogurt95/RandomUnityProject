using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        print("Rotation Script Started on" + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        print("speed: " + speed);
        transform.Rotate(0,speed,0);
    }
}
