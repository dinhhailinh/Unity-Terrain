using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    
    public GameObject player;

    private Vector3 offset;
    private float sideOffset;
    private Vector3 finalOffset;
   

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
        finalOffset = offset;
        finalOffset.x += sideOffset;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        Rotate();
        
        transform.position = Vector3.Lerp(transform.position, (player.transform.position + finalOffset), .25f);
        transform.LookAt(player.transform.position);
    }

    void Rotate()
    {
        finalOffset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * 4f, Vector3.up) * finalOffset;
    }
    
}
