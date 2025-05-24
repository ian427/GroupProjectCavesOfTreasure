using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public float followSpeed = 5f;
    public float yOffset = 0f;
    public Transform player;

    //The camera will follow the designated assigned transform of a game object frequently
    void Update()
    {
        Vector3 newpos = new Vector3(player.position.x, player.position.y + yOffset, -10f);
        transform.position = Vector3.Slerp(transform.position, newpos, followSpeed * Time.deltaTime);
    }
}
