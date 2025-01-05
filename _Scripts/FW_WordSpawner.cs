using UnityEngine;
using TMPro;

public class FW_WordSpawner : MonoBehaviour {

    [Header("Settings:")]
    public GameObject wordPrefab;

    private float currentTime;
    private float cameraXBound;


    private void Start() {
        cameraXBound = Camera.main.orthographicSize;
    }


    private void Update() {
        currentTime += Time.deltaTime;

        if (currentTime > FW_Manager.instance.spawnTime) {
            currentTime = 0;
            if (FW_Manager.instance.currentWords < FW_Manager.instance.maxWords) {
                FW_Manager.instance.currentWords++;
                GameObject newWordGO = Instantiate(wordPrefab, new Vector2(Random.Range(-cameraXBound, cameraXBound), 5.2f), Quaternion.identity);
                newWordGO.GetComponent<TextMeshPro>().text = FW_WordSetLoader.GetRandomWord();
                newWordGO.transform.SetParent(transform);
            }
        }
    }
}
