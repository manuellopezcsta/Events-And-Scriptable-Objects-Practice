using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Transform movePoint;
    public Vector3 originalPos;
    bool open = false;
    public int doorID;

    void Start()
    {
        EventManager.current.openDoorEvent += openDoor;
        EventManager.current.resetDoorsEvent += resetDoor;
        originalPos = transform.position;
    }

    void openDoor(int triggerID)
    {
        if (doorID == triggerID)
        {
            open = true;
        }
    }

    void OnDisable()
    {
        EventManager.current.openDoorEvent -= openDoor;
        EventManager.current.resetDoorsEvent -= resetDoor;
    }

    void Update()
    {
        if (open)
        {
            transform.position = Vector2.MoveTowards(transform.position, movePoint.position, 5* Time.deltaTime);
        }
    }

    void resetDoor()
    {
        // Cierra la puerta
        open = false;
        transform.position = originalPos;
    }
}
