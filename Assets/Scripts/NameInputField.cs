using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameInputField : MonoBehaviour
{

    public InputField inputField;

    private string playerName;

    // Start is called before the first frame update
    private void Start()
    {

        inputField = GetComponent<InputField>();

    }

    public void OnSubmit()
    {

        playerName = inputField.text;

        if (DataPersistenceBetweenScenes.instance != null)
        {
            DataPersistenceBetweenScenes.instance.playerName = playerName;

        }

        Debug.Log(DataPersistenceBetweenScenes.instance.playerName);
    }

}
