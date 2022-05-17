
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Goal")
        {
            SceneManager.LoadScene("Winner");
        }

        if (collisionInfo.collider.tag == "Monster")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
