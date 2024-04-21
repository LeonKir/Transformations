using UnityEngine;

public class Dice_d6_PlasticGlossyPureblue : MonoBehaviour
{
    [SerializeField] private float _rotatSpeed;

    private void Update()
    {
        Rotation();
    }

    private void Rotation()
    {
        transform.rotation *= Quaternion.Euler(0, _rotatSpeed, 0);
    }
}
