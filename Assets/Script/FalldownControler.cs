using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalldownControler : MonoBehaviour
{

    private CharacterController controller;
    public float falldown = -4f;
    Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        velocity.y += falldown * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
