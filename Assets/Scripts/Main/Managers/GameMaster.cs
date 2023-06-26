using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    [SerializeField] private GameObject LostMenu;

    void Start()
    {
        Time.timeScale = 1f;
    }

    public void ShowMenu()
    {
        LostMenu.SetActive(true);
        Time.timeScale = 0f;
    }
}
