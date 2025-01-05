using UnityEngine;

public class FW_WordController : MonoBehaviour {


    private void Update() {
        transform.position = new Vector2(transform.position.x, transform.position.y - FW_Manager.instance.speed * Time.deltaTime);

        if(transform.position.y <= -5.2) {
            Destroy(gameObject);
        }
    }


    private void OnDestroy() {
        FW_Manager.instance.currentWords--;
    }
}
