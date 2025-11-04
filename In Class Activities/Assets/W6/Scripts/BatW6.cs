using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    // Speed is public so it can be tuned in the Inspector.
    public float speed = 5.0f;
    private Transform _playerTarget;
    private bool _isChasing = false;

    private void Start()
    {
        // Try to find the player (Cat) by tag. Make sure the player is tagged "Player" in the scene.
        var player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
            _playerTarget = player.transform;
        else
            Debug.LogWarning("BatW6: No GameObject with tag 'Player' found. Bats won't chase until a target is assigned.");

        // For Part 1 testing: start chasing immediately so bats chase when the game runs.
        StartChasing();
    }

    private void Update()
    {
        if (_isChasing && _playerTarget != null)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, _playerTarget.position, step);
        }
    }

    // Public method BatManager can call to start chasing.
    public void StartChasing()
    {
        // If no target assigned, try to find the player now.
        if (_playerTarget == null)
        {
            var player = GameObject.FindGameObjectWithTag("Player");
            if (player != null)
                _playerTarget = player.transform;
        }

        _isChasing = true;
    }

    // Public method BatManager can call to stop chasing.
    public void StopChasing()
    {
        _isChasing = false;
    }

    // Backwards-compatible method name: some scripts (BatManager in the
    // assignment) expect StopChasingPlayer(). Keep this as a thin alias
    // so both names work.
    public void StopChasingPlayer()
    {
        StopChasing();
    }

    // Optional: allow an external script to directly assign a specific target and start chasing it.
    public void ChasePlayer(Transform target)
    {
        _playerTarget = target;
        _isChasing = true;
    }
}
