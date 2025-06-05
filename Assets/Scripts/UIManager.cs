using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtScore;
    public TextMeshProUGUI salud;
    // Start is called before the first frame update
    void Start()
    {
        txtScore.text = "0";  
    }

    // Update is called once per frame
    public void UpadateScore(int score)
    {
        txtScore.text = score.ToString();
    }
    public void UpdateHealth(int Health)
    {
        salud.text = Health.ToString();
    }
}
