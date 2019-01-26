using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;


    private float offset;
    
    
    // Start is called before the first frame update
    void Start()
    {
        offset = player.transform.position.x - transform.position.x;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPosition = transform.position;
        newPosition.x = player.transform.position.x - offset;
        transform.position = newPosition;
    }
}
