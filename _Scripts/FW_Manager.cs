using UnityEngine;

public class FW_Manager : MonoBehaviour {

    [Header("Game Settings:")]
    public float spawnTime;
    public float speed;
    public int maxWords;
    [HideInInspector] public int currentWords;

    public static FW_Manager instance;



    private void Awake() {
        instance = this;
    }
}
