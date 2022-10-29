using System;

public static class EVENT

{
    public static Action<string> door; //событие, на которое будет подписка

    public static void EventDoor(string number) //метод оповещения, о том что событие произошло
    {

        door?.Invoke(number); //оповещение, о том что событие произошло (? означает, что команда выполнится только если хоть кто-то подписан)

    }

}