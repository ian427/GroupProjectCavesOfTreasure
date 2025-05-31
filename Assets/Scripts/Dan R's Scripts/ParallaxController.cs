using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxController : MonoBehaviour
{
    Transform camera;
    Vector3 cameraStartPos;
    float distance;

    GameObject[] backgroundFrames;
    Material[] mats;
    float[] backgroundSpeeds;
    float furthestFrame;

    [Range(0.01f, 1.5f)]
    public float parallaxMovementSpeed;

    //Starts by setting the camera to the right position, where the player is
    void Start()
    {
        camera = Camera.main.transform;
        cameraStartPos = camera.position;

        int backCount = transform.childCount;
        mats = new Material[backCount];
        backgroundSpeeds = new float[backCount];
        backgroundFrames = new GameObject[backCount];

        for (int i = 0; i < backCount; i++)
        {
            backgroundFrames[i] = transform.GetChild(i).gameObject;
            mats[i] = backgroundFrames[i].GetComponent<Renderer>().material;
        }

        BackSpeedCalc(backCount);
    }

    //Calculates the distance apart in the Z order that the background frames are in
    void BackSpeedCalc(int backCount)
    {
        for(int i = 0; i < backCount; i++)
        {
            if ((backgroundFrames[i].transform.position.z - camera.position.z) > furthestFrame)
            {
                furthestFrame = backgroundFrames[i].transform.position.z - camera.position.z;
            }
        }

        for(int i = 0; i < backCount; i++)
        {
            backgroundSpeeds[i] = 1 - (backgroundFrames[i].transform.position.z - camera.position.z) / furthestFrame;
        }
    }

    //As the player moves, the frames will move with them and create the illusion of an endless background
    private void LateUpdate()
    {
        distance = camera.position.x - cameraStartPos.x;
        transform.position = new Vector3(camera.position.x, camera.position.y, 0);

        for (int i = 0; i < backgroundFrames.Length; i++)
        {
            float speed = backgroundSpeeds[i] * parallaxMovementSpeed;
            mats[i].SetTextureOffset("_MainTex", new Vector2(distance, 0) * speed);
        }
    }
}
