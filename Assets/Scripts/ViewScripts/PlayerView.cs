using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : Element
{
  private void Start()
  {
      app.view.playerView = this;
      app.controller.ActiveTuzik();
  }
  private void OnMouseDown()
  {
      app.controller.Tuzik.TuzikJump();
  }
  
}
