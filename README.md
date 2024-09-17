# Additional Unity Events
- By: Maarten R. Struijk Wilbrink
- For: Leiden University SOSXR
- Fully open source: Feel free to add to, or modify, anything you see fit.

This repo contains additional Unity events. 

## Installation
1. Open the Unity project you want to install the gizmos into.
2. Open the Package Manager window.
3. Click on the `+` button and select `Add package from git URL...`.
4. Paste the URL of this repo into the text field and press `Add`.


## Usage
1. Add any of the `UnityEventXXX` components to a GameObject.
2. Assign the desired method to the event.

Some components have additional properties that can be configured in the inspector, such as the timing of the event.


### In regard to BoundsIntersect vs CollisionEnter events (by ChatGPT)
#### Type of Detection:
- bounds.Intersects: A simple geometric check on the 'axis-aligned bounding boxes' (AABBs).
- OnCollisionEnter: A physics-based event triggered by the Unity physics engine.
#### Complexity:
- bounds.Intersects: Only checks for overlaps, without any details on impact, force, or specific collision points.
- OnCollisionEnter: Provides detailed information about the collision (e.g., impact points, forces).
#### Physics Engine:
- bounds.Intersects: Does not rely on Unity's physics engine.
- OnCollisionEnter: Relies on Unity's physics system (rigidbodies and colliders).

#### Explanation
"Axis-aligned" refers to how the bounding box is oriented in space relative to the coordinate system's axes (usually X, Y, and Z in 3D or X and Y in 2D). An axis-aligned bounding box (AABB) is a box that remains aligned with these axes, regardless of the object's rotation. Axis-aligned means that the edges of the bounding box are always perfectly horizontal and vertical in world space. If you rotate an object in your scene, its AABB does not rotate. Instead, it stretches or shrinks as needed to still encompass the object while staying aligned with the world axes.

#### Why it Matters:
- Simplicity and speed: Since AABBs are not rotated, it's computationally simpler and faster to check if two AABBs intersect. You only need to compare the min and max coordinates of the boxes along each axis.
- Limitation: AABBs are less precise when objects rotate, as the bounding box might grow larger than necessary to accommodate the object's new orientation. This can lead to false positives when checking for intersections.


