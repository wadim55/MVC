using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorcontroller : Element
{
    private void OnEnable() //подписываемся на событие при включенном объекте
    {
        EVENT.door += OpenDoor;
    }
    private void OnDisable() //отписываемся от событие при отключенном объекте
    {
        EVENT.door -= OpenDoor;
    }

    public void OpenDoor(string doorevent)
    {
        app.view._Doorview.door.GetComponent<Animator>().enabled = true;
    }
}
