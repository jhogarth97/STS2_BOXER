using BaseLib.Abstracts;
using BaseLib.Extensions;
using BaseLib.Utils;
using Boxer.BoxerCode.Character;
using Boxer.BoxerCode.Extensions;

namespace Boxer.BoxerCode.Potions;

[Pool(typeof(BoxerPotionPool))]
public abstract class BoxerPotion : CustomPotionModel
{
    public override string? CustomPackedImagePath =>
        $"{Id.Entry.RemovePrefix().ToLowerInvariant()}.png".PotionImagePath();

    public override string? CustomPackedOutlinePath =>
        $"{Id.Entry.RemovePrefix().ToLowerInvariant()}.png".PotionOutlineImagePath();
}