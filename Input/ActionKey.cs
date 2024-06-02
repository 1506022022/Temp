using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace PlatformGame.Input
{
    public static class ActionKey
    {
        public const string KEY_UP = "Up";
        public const string KEY_DOWN = "Down";
        public const string KEY_RIGHT = "Right";
        public const string KEY_LEFT = "Left";
        public const string KEY_JUMP = "Jump";
        public const string KEY_SWAP = "Tab";
        public const string KEY_ATTACK = "Attack";
        public const string KEY_GUARD = "Guard";
<<<<<<< HEAD:Input/ActionKey.cs
        public const string KEY_Debug = "Debug Load";
=======
        public const string KEY_PORTAL_JUMP = "PortalJump";
>>>>>>> 55905e167fdf216c12329ed6e479be5122586bc9:Core/Input/ActionKey.cs

        static readonly Dictionary<string, bool> mKeyDownMap = new Dictionary<string, bool>
        {
            { KEY_UP, false },
            { KEY_DOWN, false },
            { KEY_RIGHT, false },
            { KEY_LEFT, false },
            { KEY_JUMP, false },
            { KEY_SWAP, false },
            { KEY_ATTACK, false },
            { KEY_GUARD, false },
<<<<<<< HEAD:Input/ActionKey.cs
            { KEY_Debug, false }
=======
            { KEY_PORTAL_JUMP, false }
>>>>>>> 55905e167fdf216c12329ed6e479be5122586bc9:Core/Input/ActionKey.cs
        };

        static Dictionary<string, bool> KeyDownMap
        {
            get
            {
                Debug.Assert(mKeyDownMap != null);
                return mKeyDownMap;
            }
        }

        public static List<string> InputKeys => KeyDownMap.Keys.ToList();
        static float mLastUpdate;

        public static Dictionary<string, bool> GetKeyDownMap()
        {
            if (!(mLastUpdate < Time.time))
            {
                return mKeyDownMap;
            }

            foreach (var button in KeyDownMap.ToList())
            {
                mKeyDownMap[button.Key] = UnityEngine.Input.GetAxisRaw(button.Key) != 0;
            }

            mLastUpdate = Time.time;

            return mKeyDownMap;
        }
    }
}