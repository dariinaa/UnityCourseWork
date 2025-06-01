using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }

        SceneManager.LoadSceneAsync(3);

        //RollerBall player = other.gameObject.GetComponent<RollerBall>();
        //other.transform.position = player.RespawnPoint.position;
    }
}
