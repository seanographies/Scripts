using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour {

    public Vector3 newCam;
    public Quaternion newCamrotate;
    public Quaternion oldCamrotate;
    private bool changeIt;
    public GameObject player;
    private Vector3 offset;


    // Use this for initialization
    void Start () {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate () {
        if(changeIt == true)
        {
           transform.position = newCam;
           transform.rotation = newCamrotate;
        }
        else
        {
            transform.position = player.transform.position + offset;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            changeIt = true;
            print("TOUCHED TRIGGER " + changeIt);
        }
        else
        {
            changeIt = false;
        }
    }
}
