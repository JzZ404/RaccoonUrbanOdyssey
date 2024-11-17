using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform player; // Target == character to follow
    public float height = 2f;
    public float distance = 5f;
    public float tiltAngle = 60f;

    // Start is called before the first frame update
    void LateUpdate()
    {
        Vector3 newPosition = new Vector3(player.position.x, player.position.y + height, player.position.z - distance);
        // transform.position = new Vector3(player.position.x, player.position.y + height, player.position.z);
        transform.position = newPosition;
        transform.rotation = Quaternion.Euler(tiltAngle, 0f, 0f);
    }
}