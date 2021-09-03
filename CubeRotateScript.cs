using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotateScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject cube = GameObject.Find("RotateCube");
        cube.transform.Rotate(0.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject cube = GameObject.Find("RotateCube");
        cube.transform.Rotate(Vector3.up, 40.0f*Time.deltaTime);
    }
}
