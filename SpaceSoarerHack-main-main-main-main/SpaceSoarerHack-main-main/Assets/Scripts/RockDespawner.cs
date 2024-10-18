using UnityEngine;

public class RockDespawner : MonoBehaviour
{

    private float screenLeft;
    private PuzzleManager PuzzleManager;

    public void Initialize(PuzzleManager manager)
    {
        PuzzleManager = manager;
    }

    void Start()
    {
        // Calculate the screen's left boundary in world space
        screenLeft = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
    }

    void Update()
    {
        // Check if the rock has moved past the left boundary
        if (transform.position.x < screenLeft)
        {
            if (PuzzleManager != null)
            {
                Debug.Log("Yep the rock despawner is being callled");
                PuzzleManager.OnRockDestroyed(gameObject);
            }
            Debug.Log("Yep the rock despawner is being callled");
            Destroy(gameObject); // Destroy the rock
        }
    }
}
