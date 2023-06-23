using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/ScoreBean")]
public class Bean : PowerUpEffect
{
    [SerializeField] private int amount;

    public override void Apply(GameObject target)
    {
        GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreText>().score += amount;
    }
}
