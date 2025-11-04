Devlog: BatW6 (W6)

Notes / Plan

- Goal: Make each Bat chase the Cat (player) when enabled. Provide public methods the BatManager can call to start and stop chasing. Speed must be tunable in the Inspector.

Member variables needed

- _speed (float, [SerializeField]) — movement speed, tunable in Inspector.
- playerTransform (Transform) — reference to the Cat/Player transform to chase.
- _rb (Rigidbody2D) — physics body for movement; use linearVelocity for motion.
- _isChasing (bool) — whether the bat is currently chasing the player; toggled by public methods.

Methods needed

- Start() [Unity-provided]
  - Task: get references (Rigidbody2D, find GameObject tagged "Player"), warn if no player found, and (for testing) call StartChasing() so bats chase immediately when the game begins.

- Update() [Unity-provided]
  - Task: If _isChasing is true and playerTransform exists, compute normalized direction to player and set _rb.linearVelocity = direction * _speed. If not chasing, set linearVelocity to zero.

- StartChasing() [public, custom]
  - Task: set _isChasing = true so Update will move the bat.

- StopChasing() [public, custom]
  - Task: set _isChasing = false and zero the linear velocity so the bat stops immediately.

Design notes / edge cases

- If there is no GameObject tagged "Player", a warning is logged and the bat won't chase. BatManager (in the scene) should ensure a proper tag or pass a reference to the bat.
- Using Rigidbody2D.linearVelocity (recommended in newer Unity versions) rather than transform-based movement avoids physics tunneling and keeps behavior consistent with physics.
- If a bat doesn't have a Rigidbody2D, the script requires one via [RequireComponent(typeof(Rigidbody2D))]. The script also falls back to MoveTowards if _rb is null.

Testing

- For Part 1 we call StartChasing() in Start() so that all bats start chasing at game start.
- For Part 2 remove Start() or remove the StartChasing() call so bats don't chase automatically.

Next steps for pair work

- Add the `BatW6` component to all Bat GameObjects in the scene (Inspector). Ensure the player (Cat) GameObject has the tag "Player".
- Partner B should review this file and test using the running scene in the Unity Editor.

Finished by: (your names here)
Date: (fill in)
