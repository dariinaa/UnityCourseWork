using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalZone : MonoBehaviour
{
    [SerializeField] private Vector3 launchForce;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }

        SceneManager.LoadSceneAsync(2);

        //other.GetComponent<Rigidbody>().AddForce(launchForce);
        //print("YOU WIN!!!");
    }
}
