using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLightColor : MonoBehaviour
{
    Light light;
    private string state; 
    void OnGUI()
    {
        //GUI.Label(new Rect(5, 50, 100, 30), state);
        
        GUI.Label(new Rect(5, 10, 100, 30), "Light: " + (light.enabled ? "ON" : "OFF"));
        GUI.Label(new Rect(5, 40, 100, 30), "Press K to help!");
        if (Input.GetKey(KeyCode.K)){
            GUI.Label(new Rect(5, 60, 100, 30), "Speed: Shift");
            GUI.Label(new Rect(5, 80, 100, 30), "Move: A W D S ");
            GUI.Label(new Rect(5, 100, 100, 30), "Rotate: Mouse ");
            GUI.Label(new Rect(5, 120, 100, 30), "Light State: O ");
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.O))
        {
            light.enabled = !light.enabled;
        }
        
    }
}
