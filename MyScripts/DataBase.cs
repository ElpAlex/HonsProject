using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DataBase : MonoBehaviour
{
    const string privateCode = "emXrQkiZP0OrKjsR3pJBUA6mR3r3k4NEKtFNWaVkV1VA";
    const string publicCode = "6016c1f68f40bb2a70427805";
    const string webURL = "http://dreamlo.com/lb/";

    public Highscore[] highscoresList;

    void Awake()
    {

        AddNewHighscore("Sebastian",0.5f);
        AddNewHighscore("Mary", 0.5f);
        AddNewHighscore("Bob", 0.5f);

        //DownloadHighscores();
    }

    public void AddNewHighscore(string username, float height)
    {
        StartCoroutine(UploadNewHighscore(username, height));
    }

    IEnumerator UploadNewHighscore(string username, float height)
    {
        UnityWebRequest www = new UnityWebRequest(webURL + privateCode + "/add/" + UnityWebRequest.EscapeURL(username) + "/" + height);
        yield return www.SendWebRequest();

        if (string.IsNullOrEmpty(www.error))
            print("Upload Successful");
        else
        {
            print("Error uploading: " + www.error);
        }
    }

    //public void DownloadHighscores()
    //{
    //    StartCoroutine("DownloadHighscoresFromDatabase");
    //}

    //IEnumerator DownloadHighscoresFromDatabase()
    //{
    //    WWW www = new WWW(webURL + publicCode + "/pipe/");
    //    yield return www;

    //    if (string.IsNullOrEmpty(www.error))
    //        FormatHighscores(www.text);
    //    else
    //    {
    //        print("Error Downloading: " + www.error);
    //    }
    //}

    //void FormatHighscores(string textStream)
    //{
    //    string[] entries = textStream.Split(new char[] { '\n' }, System.StringSplitOptions.RemoveEmptyEntries);
    //    highscoresList = new Highscore[entries.Length];

    //    for (int i = 0; i < entries.Length; i++)
    //    {
    //        string[] entryInfo = entries[i].Split(new char[] { '|' });
    //        string username = entryInfo[0];
    //        int score = int.Parse(entryInfo[1]);
    //        highscoresList[i] = new Highscore(username, score);
    //        print(highscoresList[i].username + ": " + highscoresList[i].score);
    //    }
    //}

}

public struct Highscore
{
    public string username;
    public int score;

    public Highscore(string _username, int _score)
    {
        username = _username;
        score = _score;
    }
}
