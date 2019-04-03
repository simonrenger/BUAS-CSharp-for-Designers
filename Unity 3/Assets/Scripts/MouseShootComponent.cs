using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseShootComponent : MonoBehaviour
{
    public Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forward = transform.forward;

        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        
        if( Physics.Raycast(ray, out hit))
        {
            Debug.DrawLine(transform.position, hit.point, Color.black, 0.1f);
        }

    }
}
