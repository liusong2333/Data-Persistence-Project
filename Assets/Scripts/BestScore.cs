using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BestScore : MonoBehaviour
{
    public TextMeshProUGUI bestScore;
    // Start is called before the first frame update
    void Start()
    {
        bestScore = GetComponent<TextMeshProUGUI>();

        if(DataPersistenceBetweenScenes.instance != null)
        {
            bestScore.text = $"Best Score : {DataPersistenceBetweenScenes.instance.bestScore}";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
