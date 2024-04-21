using UnityEngine;

public class lowpoly_earth : MonoBehaviour
{
    private const string Horizontal = nameof(Horizontal);

    [SerializeField] private float _moveSpeed;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        float movment = 0.25f;
        float distance = _moveSpeed * Time.deltaTime;

        transform.Translate(distance * Vector2.right);
    }
}
