using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public int triggerID;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Player")
        {
            EventManager.current.StartDoorEvent(triggerID);
        }
    }
}
