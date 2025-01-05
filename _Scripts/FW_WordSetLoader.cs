using UnityEngine;

public class FW_WordSetLoader : MonoBehaviour {

    [Header("Settings:")]
    public TextAsset wordSet;

    private static string[] words;


    private void Start() {
        words = wordSet.text.Split('\n');
    }

    public static string GetRandomWord() {
        return words[Random.Range(0, words.Length)];
    }
}
