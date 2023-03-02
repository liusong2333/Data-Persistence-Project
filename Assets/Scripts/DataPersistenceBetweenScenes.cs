using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class DataPersistenceBetweenScenes : MonoBehaviour
{
    public static DataPersistenceBetweenScenes instance;

    public string playerName;

    public string winnerName;

    public int bestScore;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        LoadScore();
    }

    [System.Serializable]
    class SaveData
    {
        public string winnerName;

        public int bestScore;

    }

    public void SaveScore()
    {
        SaveData data = new SaveData();

        data.winnerName = winnerName;
        data.bestScore = bestScore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            winnerName = data.winnerName;
            bestScore = data.bestScore;
        }
    }

}
