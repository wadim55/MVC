using UnityEngine.EventSystems;

public class ButtonView : Element, IPointerClickHandler
{
    private void Start()
    {
        app.view.buttonView = this;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        app.controller.ActiveTuzik();
    }
}
