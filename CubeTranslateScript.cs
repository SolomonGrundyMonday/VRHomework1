using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTranslateScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
	GameObject cube = GameObject.Find("TranslateCube");
        cube.transform.Translate(0.0f, 0.5f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
	GameObject cube = GameObject.Find("TranslateCube");
        cube.transform.Translate(Vector3.forward*Time.deltaTime);
    }
}
