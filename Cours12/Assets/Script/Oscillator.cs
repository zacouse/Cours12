using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class Oscillator : MonoBehaviour {
    [SerializeField] Vector3 movementVector = new Vector3(10f,10f,10f);
    [SerializeField] float period = 2f;

    [Range(0,1)]
    [SerializeField]
    float movementFactor;
    Vector3 startingPos;

	void Start () {
        startingPos = transform.position;
	}

	void Update () {
        if(period <= Mathf.Epsilon) {
            return;
        }
        float cycles = Time.time / period;
        float sinwave = Mathf.Sin(Mathf.PI * 2 * cycles);
        Vector3 offset = movementVector * sinwave;
        transform.position = startingPos + offset;
	}
}
