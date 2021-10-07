using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //public float offsetZ = 10f;
    //public float offsetY = 10f;
    public float smoothing = 8f;
    //player transform component
    public Transform playerPos;
    public Vector3 cameraOffset;

    public bool lookAtTarget = false;

    // Start is called before the first frame update
    void Start()
    {
        //playerPos = FindObjectOfType<PlayerController>().transform;
        cameraOffset = transform.position - playerPos.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        FollowPlayer();
    }

    //Following the player
    void FollowPlayer()
    {
        //Vector3 targetPosition = new Vector3(playerPos.position.x , playerPos.position.y + offsetY, playerPos.position.z - offsetZ);
        //transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing * Time.deltaTime);
        Vector3 newPosition = playerPos.transform.position + cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPosition, smoothing);

        if (lookAtTarget)
        {
            transform.LookAt(playerPos);
        }
    }
}
