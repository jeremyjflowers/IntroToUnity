using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour : MonoBehaviour
{
    public float YMin;
    public float YMax;
    public float VerticalSpeed = 2;
    public float HorizontalSpeed = 2;
    public float StartCos = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(HorizontalSpeed, 0, 0) * Time.deltaTime;
        StartCos += Time.deltaTime;
        transform.position += new Vector3(0, Mathf.Cos(StartCos), 0) * VerticalSpeed * Time.deltaTime;
    }
}
