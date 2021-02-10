using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    private float zoom;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        zoom += -Input.mouseScrollDelta.y;

        zoom = Mathf.Clamp(zoom, 50f, 120f);

        transform.position = new Vector3(transform.position.x, zoom, transform.position.z);

        transform.localPosition = new Vector3(player.position.x, transform.position.y, player.position.z);
    }
}
