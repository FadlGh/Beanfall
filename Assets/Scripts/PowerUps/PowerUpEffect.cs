using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUpEffect : ScriptableObject
{
    [SerializeField] protected string soudName;
    public abstract void Apply(GameObject target);
    public void PlaySound()
    {
        GameObject.FindGameObjectWithTag("AM").GetComponent<AudioManager>().Play(soudName);
    }
}
