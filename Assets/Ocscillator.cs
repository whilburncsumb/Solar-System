using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ocscillator : MonoBehaviour
{
    private Vector3 startingPosition;
    // Start is called before the first frame update
    void Start()
    {
        startingPosition = GetComponent<Transform>().position;
        // Debug.Log("Starting at frame: " + Time.frameCount);
    }

    // Update is called once per frame
    void Update()
    {
        Transform siT = GetComponent<Transform>();
        float offset = Mathf.Sin(Time.time);
        siT.position = startingPosition + Vector3.right * offset;
        // Debug.Log("Printing at frame: " + Time.frameCount);
    }
}
