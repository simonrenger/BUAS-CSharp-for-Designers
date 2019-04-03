using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class BasicPlayerMovement : MonoBehaviour
{
    private Transform tr;

    public GameObject prefab;

    // Lets test it!
    public float MovementSpeed = 2.5f;

    void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        
        Debug.Log(gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float vert = Input.GetAxisRaw("Vertical");

        Vector3 worldPosition = transform.position;
        worldPosition += new Vector3(hor, 0, vert) * MovementSpeed;
        transform.position = worldPosition;

        if (Input.GetButton("Jump"))
        {
            GameObject newPlayer = Instantiate(prefab, transform.position + new Vector3(2, 0, 0), Quaternion.identity);
            newPlayer.GetComponent<BasicPlayerMovement>().prefab = prefab;

        }
    }
}
