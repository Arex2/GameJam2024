using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventController
{
    //MAKE THIS A SINGLETON?!
    public delegate void OnDeath();
    public static event OnDeath onDeath;

    public delegate void OnRespawn();
    public static event OnRespawn onRespawn;

    public delegate void OnHPClick();
    public static event OnRespawn onHPClick;

    public static void RaiseOnDeath()
    {
        if (onDeath != null) //Only raise event if things are subbed to the event
        {
            Debug.Log("Player death!");
            onDeath(); //invoke event
        }
    }

    public static void RaiseOnRespawn()
    {
        if (onRespawn != null) //Only raise event if things are subbed to the event
        {
            Debug.Log("Player respawn!");
            onRespawn(); //invoke event
        }
    }

    public static void RaiseHPClick()
    {
        if (onHPClick != null) //Only raise event if things are subbed to the event
        {
            Debug.Log("HPClick!");
            onHPClick(); //invoke event
        }
    }
    //        EventController.onDeath += ResetEnemy;//subscribes to the onDeath event
}
