using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Element
{
    public void TuzikJump()
    {
        var TuzikLife = app.model.tuzik.life--;
        print(TuzikLife);
    }
}
