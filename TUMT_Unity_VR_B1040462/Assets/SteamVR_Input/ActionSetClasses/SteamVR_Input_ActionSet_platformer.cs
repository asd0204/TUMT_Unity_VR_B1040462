// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Valve.VR
{
    using System;
    using UnityEngine;
    
    
    public class SteamVR_Input_ActionSet_platformer : Valve.VR.SteamVR_ActionSet
    {
        
        public virtual SteamVR_Action_Vector2 Move
        {
            get
            {
                return SteamVR_Actions.platformer_Move;
            }
        }
        
        public virtual SteamVR_Action_Boolean Jump
        {
            get
            {
                return SteamVR_Actions.platformer_Jump;
            }
        }
    }
}
