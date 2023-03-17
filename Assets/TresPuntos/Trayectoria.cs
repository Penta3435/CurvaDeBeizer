using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Trayectoria : MonoBehaviour
{
    [SerializeField] Transform P0;
    [SerializeField] Transform P1;
    [SerializeField] Transform P2;
    [SerializeField] Transform P0yP1;
    [SerializeField] Transform P1yP2;
    [SerializeField] GameObject sphere;

    [SerializeField, Range(0f, 1f)] float t;
    [SerializeField] bool trazarLinea;

    

    void Update()
    {
        P0yP1.position = Vector3.Lerp(P0.position, P1.position, t);
        P1yP2.position = Vector3.Lerp(P1.position, P2.position, t);
        Debug.DrawLine(P0yP1.position, P1yP2.position, Color.blue);

        transform.position = Vector3.Lerp(P0yP1.position, P1yP2.position, t);

        if (trazarLinea) 
        { 
            Instantiate(sphere, transform.position, transform.rotation);
        }
    }
}
