using BaseLib.Abstracts;
using Boxer.BoxerCode.Extensions;
using Godot;

namespace Boxer.BoxerCode.Character;

public class BoxerPotionPool : CustomPotionPoolModel
{
    public override Color LabOutlineColor => Boxer.Color;


    public override string BigEnergyIconPath => "charui/big_energy.png".ImagePath();
    public override string TextEnergyIconPath => "charui/text_energy.png".ImagePath();
}