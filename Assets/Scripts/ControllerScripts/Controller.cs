using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : Element
{
    public PlayerController Tuzik;

    [SerializeField] private GameObject prefabTuzik;
    [SerializeField] private GameObject tuzik;
    public void ActiveTuzik()
    {
        if (app.controller.tuzik != null) return;
        tuzik = Instantiate(prefabTuzik);
        tuzik.name = "tuzik";
        app.controller.Tuzik = tuzik.AddComponent<PlayerController>();
        app.model.tuzik = new PlayerModel();
    }
  
}
