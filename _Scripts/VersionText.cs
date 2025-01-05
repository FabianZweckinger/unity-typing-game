using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class VersionText : MonoBehaviour {

    private void Start() {
        GetComponent<TextMeshProUGUI>().text = "V" + Application.version;
    }
}
