using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorview : Element
{
    public GameObject door;

    private void OnCollisionEnter(Collision other)
    {
        EVENT.EventDoor("игрок у двери");
    }
}
