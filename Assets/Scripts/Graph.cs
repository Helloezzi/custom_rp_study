using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    [SerializeField]
    Transform pointPrefab;

    [SerializeField, Range(10, 100)]
    public int resolution = 10;

    private void Awake()
    {
        MyDraw();
    }

    private void MyDraw()
    {
        float step = 2f / resolution;
        Vector3 position = Vector3.zero;
        var scale = Vector3.one * step;
        Debug.Log(scale);
        
        for (int i = 0;i < resolution; i++)
        {
            Transform point = Instantiate(pointPrefab);
            position.x = (i + 0.5f) * step - 1f;
            Debug.Log($"position x : {position.x}");
            //position.y = position.x;                // y equals x
            position.y = position.x * position.x;   // y equals x squared
            point.localPosition = position;
            point.localScale = scale;
            point.SetParent(this.transform, false);
        }
    }
}
