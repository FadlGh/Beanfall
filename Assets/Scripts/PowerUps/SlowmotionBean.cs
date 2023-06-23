using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/SlowmotionBean")]
public class SlowmotionBean : PowerUpEffect
{
    [SerializeField] private float speed;

    public override void Apply(GameObject target)
    {
        target.GetComponent<PlayerMovement>().ChangeSpeed(speed);
    }
}
