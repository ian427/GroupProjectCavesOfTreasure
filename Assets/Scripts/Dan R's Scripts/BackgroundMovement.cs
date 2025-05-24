using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    Material material;
    float distance;

    [Range(0f, 0.5f)]
    public float speed = 0.2f;

    //Gets and assigns the renderer component
    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    //Depending on the direction moved, the background will scroll in that direction
    void Update()
    {
        distance += Time.deltaTime * speed;
        material.SetTextureOffset("_MainTex", Vector2.right * distance);
    }
}
