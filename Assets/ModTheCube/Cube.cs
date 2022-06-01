using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    //Variables
    public MeshRenderer Renderer;


    void Start()
    {
        //Change random position the cube
        Vector3 positionCube = new Vector3(Random.Range(-7, -9), Random.Range(4, 7), Random.Range(-5, -9));
        transform.position = positionCube;
        //Change scale the cube
        transform.localScale = Vector3.one * 0.4f;

        InvokeRepeating("ChangeColor", 1.0f * Time.deltaTime, 0.7f);
    }
    
    void Update()
    {
        transform.Rotate(10.0f * 15 * Time.deltaTime, 10.0f * 15 * Time.deltaTime, 10.0f * 15 * Time.deltaTime);
    }

    void ChangeColor()
    {
        Material material = Renderer.material;
        float color1 = Random.Range(0.0f, 1.0f);
        float color2 = Random.Range(0.0f, 1.0f);
        float color3 = Random.Range(0.0f, 1.0f);

        material.color = new Color(color1, color2, color3, 0.8f);
    }
}
