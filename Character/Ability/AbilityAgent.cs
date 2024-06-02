﻿using PlatformGame.Character.Collision;
using UnityEngine;
using UnityEngine.Events;

namespace PlatformGame.Character.Combat
{
    public class AbilityAgent
    {
        readonly HitBoxGroup mHitBox;
        float mLastActionTime;
        ActionData mLastUsedAction;
        [SerializeField] UnityEvent<Character, uint> mAttackEvent;

        public AbilityAgent(HitBoxGroup hitBox)
        {
            mHitBox = hitBox;
        }

        public bool InAction
        {
            get => mLastUsedAction != null && Time.time < mLastActionTime + mLastUsedAction.ActionDelay;
        }

        public void UseAbility(ActionData actionData)
        {
            mLastActionTime = Time.time;
            mLastUsedAction = actionData;
            var hitBoxData = actionData.HitBoxData;

            if (!hitBoxData.UseHitBox ||
                !actionData.Ability)
            {
                return;
            }
<<<<<<< HEAD:Character/Ability/AbilityAgent.cs

=======
            
>>>>>>> 55905e167fdf216c12329ed6e479be5122586bc9:Core/Combat/AbilityAgent.cs
            var filter = hitBoxData.Filter;
            mHitBox.SetAttackEvent(filter, actionData.Ability.DoActivation, actionData.ID);
        }
    }
}