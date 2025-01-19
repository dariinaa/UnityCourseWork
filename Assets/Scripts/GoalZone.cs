using UnityEngine;

public class GoalZone : MonoBehaviour
{
    [SerializeField] private Vector3 launchForce;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }

        other.GetComponent<Rigidbody>().AddForce(launchForce);
        print("YOU WIN!!!");
    }
}
