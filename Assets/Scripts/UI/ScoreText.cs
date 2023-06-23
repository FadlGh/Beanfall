using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public int score;
    private TextMeshProUGUI textMeshPro;

    void Start()
    {
        textMeshPro  = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        textMeshPro.text = score.ToString();
    }
}
