using UnityEngine;

public class Explosion : MonoBehaviour
{
    private void SelfDestroy()
    {
        Destroy(gameObject);
    }
}
