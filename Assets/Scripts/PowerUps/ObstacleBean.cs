using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/ObstacleBean")]
public class ObstacleBean : PowerUpEffect
{
    [SerializeField] private int amount;

    public override void Apply(GameObject target)
    {
        target.GetComponent<PlayerHealth>().ApplyDamage(amount);
    }
}

