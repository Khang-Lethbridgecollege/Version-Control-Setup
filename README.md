# Version Control Setup
---
The project aims to improve performance issues, increase game sustainability over time by eliminating trash from code snippets, making the game run efficiently.

# Project Requirements
No trampolines or lights removed, balls spawn every 0.5 seconds, picking up and throwing ball at trampoline increases score, score is visible from starting area
Static and dynamic batching options are turned on
Game Objects that never move are statically batched
Moving objects with colliders all have rigidbodies on them. Moving trampolines are also not marked as static
Rigidbodies are used sparingly
Instantiate/Destroy process is replaced with Object Pooling 
Variables are stored when there is a change, rather than updating every frame (use update as little as possible)
Poor performing code options are replaced with higher performing options
4x or 8x MSAA is turn on
