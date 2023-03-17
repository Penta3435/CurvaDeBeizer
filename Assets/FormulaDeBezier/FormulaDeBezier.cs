using System;
using UnityEngine;

[ExecuteInEditMode]
public class FormulaDeBezier : MonoBehaviour
{
    [SerializeField] Transform[] Puntos;
    [SerializeField, Range(0, 1)] float t = 0;
    Vector3[] puntos;



    private void Update()
    {
        puntos = ArrTransformToArrVector3(Puntos);

        //dibujar linea
        for (var i = 0; i < puntos.Length-1; i++)
        {
            Debug.DrawLine(puntos[i], puntos[i + 1], Color.blue);
        }

        //calcular el punto
        while (puntos.Length > 1)
        {
            for (var i = 0; i < puntos.Length; i++)
            {
                if (i < puntos.Length - 1)
                {
                    puntos[i] = (puntos[i + 1] - puntos[i]) * t + puntos[i];    //(1-t)P0 + tP1 = (P1 - P0) * t + P0
                }
                else
                {
                    Array.Resize(ref puntos, puntos.Length - 1);
                }
            }
        }
        transform.position = puntos[0];
    }




    Vector3[] ArrTransformToArrVector3(Transform[] arrayTransform)
    {
        Vector3[] arrayVector3 = new Vector3[arrayTransform.Length];
        for (var i = 0; i < arrayTransform.Length; i++)
        {
            arrayVector3[i] = arrayTransform[i].position;
        }
        return arrayVector3;
    }
}
