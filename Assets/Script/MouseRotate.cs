using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotate : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform body;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
    }
    public void Rotate()
    {
        float mouseX = Input.GetAxis("Mouse X")* mouseSensitivity * Time.deltaTime;

        body.Rotate(Vector3.up * mouseX);

    }
}
