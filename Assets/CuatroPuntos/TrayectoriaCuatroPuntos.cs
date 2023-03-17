using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class TrayectoriaCuatroPuntos : MonoBehaviour
{
    [SerializeField] Transform P0;
    [SerializeField] Transform P1;
    [SerializeField] Transform P2;
    [SerializeField] Transform P3;
    [SerializeField] Transform P0P1;
    [SerializeField] Transform P1P2;
    [SerializeField] Transform P2P3;
    [SerializeField] Transform P0P1yP1P2;
    [SerializeField] Transform P1P2yP2P3;
    [SerializeField] GameObject sphere;

    [SerializeField, Range(0f, 1f)] float t;
    [SerializeField] bool trazarLinea;

    

    void Update()
    {
        P0P1.position = Vector3.Lerp(P0.position, P1.position, t);
        P1P2.position = Vector3.Lerp(P1.position, P2.position, t);
        P2P3.position = Vector3.Lerp(P2.position, P3.position, t);
        Debug.DrawLine(P0P1.position, P1P2.position, Color.blue);
        Debug.DrawLine(P1P2.position, P2P3.position, Color.blue);

        P0P1yP1P2.position = Vector3.Lerp(P0P1.position, P1P2.position, t);
        P1P2yP2P3.position = Vector3.Lerp(P1P2.position, P2P3.position, t);
        Debug.DrawLine(P0P1yP1P2.position, P1P2yP2P3.position, Color.magenta);

        transform.position = Vector3.Lerp(P0P1yP1P2.position, P1P2yP2P3.position, t);

        if (trazarLinea) 
        { 
            Instantiate(sphere, transform.position, transform.rotation);
            //Instantiate(sphere, P0P1yP1P2.position, transform.rotation);
            //Instantiate(sphere, P1P2yP2P3.position, transform.rotation);
        }
    }
}
