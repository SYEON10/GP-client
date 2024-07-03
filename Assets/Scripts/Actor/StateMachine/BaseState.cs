using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Actor
{
    public abstract class BaseState
    {
        protected static ActorField _field;
        protected static WrapBody _body;
        protected static ActorAnimController _anim;

        public static void InitState(ActorField field, WrapBody body, Animator animator)
        {
            _field = field;
            _body = body;
            _anim = new ActorAnimController(animator);
        }

        public virtual void Jump()
        {
        }

        public virtual void Down()
        {
        }
        
        public virtual void Dash()
        {
        }

        public virtual void Move(Vector2 directionX)
        {
        }

        public virtual void EnterState()
        {
        }

        public virtual void UpdateState()
        {
        }

        public virtual void FixedUpdateState()
        {
        }

        public virtual void ExitState()
        {
        }
    }
}