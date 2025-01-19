using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }

        RollerBall player = other.gameObject.GetComponent<RollerBall>();
        other.transform.position = player.RespawnPoint.position;
    }
}
