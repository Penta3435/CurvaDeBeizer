using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode] 
public class LineasCuatroPuntos : MonoBehaviour
{
    [SerializeField] Transform P0;
    [SerializeField] Transform P1;
    [SerializeField] Transform P2;
    [SerializeField] Transform P3;
    void Update()
    {
        Debug.DrawLine(P0.position, P1.position, Color.green, 0f, false);
        Debug.DrawLine(P1.position, P2.position, Color.green, 0f, false);
        Debug.DrawLine(P2.position, P3.position, Color.green, 0f, false);
    }
}
