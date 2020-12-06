---
title: "Getting Started with VR Optimization"
slug: "getting-started-with-vr-optimization"
excerpt: "This page explains the project objectives and requirements for the project"
hidden: false
createdAt: "2020-12-06T05:56:05.966Z"
updatedAt: "2020-12-06T05:56:05.967Z"
---
[block:api-header]
{
  "title": "VR Optimization"
}
[/block]
The project aims to improve performance issues, increase game sustainability over time by eliminating trash from code snippets, making the game run efficiently.
[block:image]
{
  "images": [
    {
      "image": [
        "https://files.readme.io/b93d2fb-Capture.PNG",
        "Capture.PNG",
        1590,
        855,
        "#444544"
      ]
    }
  ]
}
[/block]

[block:code]
{
  "codes": [
    {
      "code": "",
      "language": "csharp"
    }
  ]
}
[/block]

[block:embed]
{
  "html": false,
  "url": "https://github.com/mikethevrguy/VR-Performance-Exercise",
  "title": "mikethevrguy/VR-Performance-Exercise",
  "favicon": "https://github.com/favicon.ico",
  "image": "https://avatars3.githubusercontent.com/u/40547376?s=400&v=4"
}
[/block]

[block:api-header]
{
  "title": "Project requirements"
}
[/block]
No trampolines or lights removed, balls spawn every 0.5 seconds, picking up and throwing ball at trampoline increases score, score is visible from starting area
Static and dynamic batching options are turned on
Game Objects that never move are statically batched
Moving objects with colliders all have rigidbodies on them. Moving trampolines are also not marked as static
Rigidbodies are used sparingly
Instantiate/Destroy process is replaced with Object Pooling 
Variables are stored when there is a change, rather than updating every frame (use update as little as possible)
Poor performing code options are replaced with higher performing options
4x or 8x MSAA is turn on