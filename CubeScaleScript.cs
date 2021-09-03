using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScaleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject cube = GameObject.Find("ScaleCube");
        cube.transform.localScale += new Vector3(1.0f, 0.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject cube = GameObject.Find("ScaleCube");

        if (cube.transform.localScale.x <= 2.0f && cube.transform.localScale.x <= 2.0f)
            cube.transform.localScale += new Vector3(1.0f, 1.0f, 1.5f) * Time.deltaTime;
        else
            cube.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f) * Time.deltaTime;
    }
}
