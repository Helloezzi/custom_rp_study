using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    [SerializeField]
    Transform pointPrefab;

    public int total = 10;

    private void Awake()
    {
        MyDraw();
    }

    private void MyDraw()
    {
        var scale = Vector3.one / 5f;
        Vector3 position = Vector3.zero;
        for (int i = 0;i < total; i++)
        {
            Transform point = Instantiate(pointPrefab);
            position.x = (i + 0.5f) / 5f - 1f;
            Debug.Log($"position x : {position.x}");
            //position.y = position.x;                // y equals x
            position.y = position.x * position.x;   // y equals x squared
            point.localPosition = position;
            point.localScale = scale;
        }
    }
}
