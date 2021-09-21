using CUE4Parse.FN.Enums.Fortnite;
using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.Fortnite
{
    [StructFallback]
    public class FFortEmoteMapping : IUStruct
    {
        public EFortCustomBodyType BodyType;
        public EFortCustomGender Gender;
        public FSoftObjectPath EmoteMontage; // UAnimMontage

        public FFortEmoteMapping(FStructFallback fallback)
        {
            BodyType = fallback.GetOrDefault<EFortCustomBodyType>(nameof(BodyType));
            Gender = fallback.GetOrDefault<EFortCustomGender>(nameof(Gender));
            EmoteMontage = fallback.GetOrDefault<FSoftObjectPath>(nameof(EmoteMontage));
        }
    }
}