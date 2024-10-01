using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum EventType
{
    START,
    CONTINUE,
    PAUSE,
    STOP
}

public class EventManager 
{
    private static readonly IDictionary<EventType, UnityEvent> dictionary = 
        new Dictionary<EventType, UnityEvent>();



}
