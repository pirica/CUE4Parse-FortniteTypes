using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.Core.i18N;

namespace CUE4Parse.FN.Structs.Fortnite
{
    [StructFallback]
    public class FFortCosmeticAdaptiveStatPreview : IUStruct
    {
        public FText UnlockCondition;
        public FFortCosmeticAdaptiveStatPair[] StatValues;

        public FFortCosmeticAdaptiveStatPreview(FStructFallback fallback)
        {
            UnlockCondition = fallback.GetOrDefault<FText>(nameof(UnlockCondition));
            StatValues = fallback.GetOrDefault<FFortCosmeticAdaptiveStatPair[]>(nameof(StatValues));
        }
    }
}