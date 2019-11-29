using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eventhand : MonoBehaviour
{
    public Movement mov;
    void OnGUI()
    {
        Event m_Event = Event.current;

        if (m_Event.type == EventType.MouseDown)
        {
            mov.mousedown();
            
        }

        if (m_Event.type == EventType.MouseDrag)
        {
            mov.mousedrag();
            
        }

        if (m_Event.type == EventType.MouseUp)
        {
            mov.mouseup();
            
        }
    }
}
