using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyAndDoor : MonoBehaviour
{
    public bool isHaveKey;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "key")
        {
            isHaveKey = true;
            Destroy(other.gameObject);
            Debug.Log("keyyy");
        }
        if (other.tag == "door"&&isHaveKey==true)
        {
            //add what you want when player colled
        }
    }
    public void Start()
    {
        isHaveKey = false;
    }
}
