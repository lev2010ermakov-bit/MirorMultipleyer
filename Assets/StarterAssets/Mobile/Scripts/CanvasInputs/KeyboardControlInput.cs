using System;
using UnityEngine;
using UnityEngine.Events;

public class KeyboardControlInput : MonoBehaviour
{
    [System.Serializable]
    public class Event : UnityEvent<Vector2> { }

    [System.Serializable]
    public class KeyEvent : UnityEvent<Boolean> { }

    [Header("Output")]
    public Event WASDOutputEvent;

    public KeyEvent JumpEvent;

    public KeyEvent SptintEvent;

    private void Update()
    {
        Vector2 InputVector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        WASDOutputEvent.Invoke(InputVector);
        JumpEvent.Invoke(Input.GetKey(KeyCode.Space));
        SptintEvent.Invoke(Input.GetKey(KeyCode.LeftShift));
    }
}
