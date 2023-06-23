using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/SlowmotionBean")]
public class SlowmotionBean : PowerUpEffect
{
    [SerializeField] private float speed;

    public override void Apply(GameObject target)
    {
        
    }

    private IEnumerator ChangeSpeed(GameObject target)
    {
        target.GetComponent<PlayerMovement>().maxSpeed = speed;

        yield return new WaitForSeconds(5);

        target.GetComponent<PlayerMovement>().maxSpeed = target.GetComponent<PlayerMovement>().defaultSpeed;
    }
}
