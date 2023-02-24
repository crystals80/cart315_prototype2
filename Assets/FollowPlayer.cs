using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 playerOffset;

    // Start is called before the first frame update
    // Use this for initialization 
    void Start()
    {
        playerOffset = transform.position - player.transform.position;
    }

    // Update is called once per frame 
    void Update()
    {
        transform.LookAt(player.transform);
        transform.position = player.transform.position + playerOffset;
    }
}
