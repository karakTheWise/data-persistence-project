using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class AutosaveScore : MonoBehaviour
{
    static public string bestPlayerName;
    static public int bestScore;

    [System.Serializable]
    class SaveData
    {
        public string playerNameToSave;
        public int playerScoreToSave;

    }

    //function to save player Name into a json file
    public void SavePlayerScore(int score)
    {
        SaveData data = new SaveData();
        data.playerNameToSave = MenuEngine.playerName;
        data.playerScoreToSave = score;
        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }


    public void LoadPlayerScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            bestPlayerName = data.playerNameToSave;
            bestScore = data.playerScoreToSave;
        }
        else
        {
            bestPlayerName = "";
            bestScore = 0;
        }
    }


}
