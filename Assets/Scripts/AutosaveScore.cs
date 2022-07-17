using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class AutosaveScore : MonoBehaviour
{
    [System.Serializable]
    class SaveData
    {
        public string playerNameToSave;
        public int playerScoreToSave;
    }

    //function to save player Name into a json file
    public void SavePlayerName()
    {
        SaveData data = new SaveData();
        data.playerNameToSave = MenuEngine.playerName;
        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    //function to save the score into a json file
    public void SavePlayerScore(int score)
    {
        SaveData data = new SaveData();
        data.playerScoreToSave = score;
        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);

    }


}
