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
        float magnificationValue = 0.1f;

        scaleChange = new Vector3(+magnificationValue, +magnificationValue, +magnificationValue);

        transform.localScale += scaleChange * _increaseSpeed;
    }
}
