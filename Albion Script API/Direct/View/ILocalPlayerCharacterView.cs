using Ennui.Api.Direct.Object;
using Ennui.Api.Meta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct.View
{
    public interface ILocalPlayerCharacterView : IPlayerCharacterView
    {
         ILocalInputHandler InputHandler { get; }

         IPlacementGhost PlacementGhost { get; }

         void DoMoveClicked(Vector3<float> pos);

         void DoObjectViewClicked(IWorldObjectView view, string collider);

         void DoObjectViewClicked(IWorldObjectView view);

         void CastOnSelf(CharacterSpellSlot slot);

         void CastAt(CharacterSpellSlot slot, IEntityObjectView view);

         void CastAt(CharacterSpellSlot slot, Vector3<float> pos);

         void MountOrDismount();

         void MountOrDismount(IMountObject mount);

         void SetSelectedObjectId(long id);

         long GetSelectedObjectId();

         void AttackCurrentTarget();

         void UpdateQueuedAction();
    }
}
