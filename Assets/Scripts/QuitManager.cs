using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class QuitManager : MonoBehaviour
{
    public void Exit()
    {
        DataPersistenceBetweenScenes.instance.bestScore = 0;
        DataPersistenceBetweenScenes.instance.winnerName = "";
        DataPersistenceBetweenScenes.instance.SaveScore();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
