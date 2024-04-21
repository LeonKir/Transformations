using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pod : MonoBehaviour
{
    [SerializeField] private float _increaseSpeed;
    private Vector3 scaleChange;

    private void Update()
    {
        Increase();
    }

    private void Increase()
    {
        scaleChange = new Vector3(+0.01f, +0.01f, +0.01f);

        transform.localScale += scaleChange * _increaseSpeed;
    }
}
