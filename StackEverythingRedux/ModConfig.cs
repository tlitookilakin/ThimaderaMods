using Microsoft.Xna.Framework;
using StardewModdingAPI;

namespace Thimadera.StardewMods.StackEverythingRedux
{
    public class ModConfig
    {
        public bool EnableStackSplitRedux { get; set; } = true;
        public int MaxStackingNumber { get; set; } = 999;
        public int DefaultCraftingAmount { get; set; } = 1;
        public int DefaultShopAmount { get; set; } = 5;
        public bool DebuggingMode { get; set; } = false;
    }

    /// <summary>
    /// This class containe "tunables" that should not be user-editable
    /// </summary>
    /// <remarks>Gathered here so we can tune the mod from one place, instead of hunting down config knobs everywhere</remarks>
    internal static class StaticConfig
    {
        /// <summary>Valid modifier keys to hold while RightClick-ing</summary>
        internal static readonly SButton[] ModifierKeys = [SButton.LeftShift, SButton.RightShift];

        /// <summary>Delay between new menu appearing & our handler beginning</summary>
        /// <remarks>To allow time for other mods to manipulate inventories</remarks>
        internal static readonly int SplitMenuOpenDelayTicks = 2;

        /// <summary>Mods that we are conflicting with. If found, abort this mod</summary>
        internal static readonly string[] ConflictingMods = ["tstaples.StackSplitX"];

        /// <summary>Text color when the text is highlighted. This should contrast with HighlightColor.</summary>
        internal static readonly Color HighlightTextColor = Color.White;

        /// <summary>The background color of the highlighted text.</summary>
        internal static readonly Color HighlightColor = Color.Blue;
    }
}
