using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.Fortnite
{
    [StructFallback]
    public class FAthenaCharacterTaggedPartsList : IUStruct
    {
        public FSoftObjectPath[]? Parts; // UCustomCharacterPart[]
        
        public FAthenaCharacterTaggedPartsList(FStructFallback fallback)
        {
            Parts = fallback.GetOrDefault<FSoftObjectPath[]>(nameof(Parts));
        }
    }
}