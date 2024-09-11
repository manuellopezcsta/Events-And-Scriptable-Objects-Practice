using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class EventManager : MonoBehaviour
{
    public static EventManager current;
    // A las acciones le puedo pasar parametros.
    public event Action<int> openDoorEvent;
    public event Action changeBallColorEvent;
    public event Action resetDoorsEvent;
    void Awake()
    {
        if (current == null){
            current = this;
        } else {
            Destroy(gameObject);
        }
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            // changeBallColor != null es igual a poner openDoor?
            changeBallColorEvent?.Invoke();
        }
    }

    public void StartDoorEvent(int id)
    {
        openDoorEvent?.Invoke(id);
    }

    public void StartResetEvent()
    {
        // Como no tiene un parametro como openDoor, este cierra todas las puertas que esten subscritas al evento.
        resetDoorsEvent?.Invoke();
    }
}
