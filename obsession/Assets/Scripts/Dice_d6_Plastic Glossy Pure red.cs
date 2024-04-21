using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice_d6_PlasticGlossyPurered : MonoBehaviour
{
    [SerializeField] private float _rotatSpeed;
    [SerializeField] private float _increaseSpeed;
    [SerializeField] private float _moveSpeed;

    private Vector3 scaleChange;

    private const string Horizontal = nameof(Horizontal);
    private const string Vertical = nameof(Vertical);

    void Update()
    {
        Rotation();
        Increase();
        Move();
    }

    private void Rotation()
    {
        transform.rotation *= Quaternion.Euler(0, _rotatSpeed, 0);
    }

    private void Increase()
    {
        scaleChange = new Vector3(+0.01f, +0.01f, +0.01f);

        transform.localScale += scaleChange * _increaseSpeed;
    }

    private void Move()
    {
        float direction = 1;
        float distance = direction * _moveSpeed * Time.deltaTime;

        transform.Translate(distance * Vector3.forward);
    }
}
