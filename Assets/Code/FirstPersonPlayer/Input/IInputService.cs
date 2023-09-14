using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Code.Input
{
    public interface IInputService
    {
        void Enable();
        void Disable();
        Vector2 ReadMovement();
        Vector2 ReadLook();
        bool ReadJump();
        bool ReadSprint();
    }
}